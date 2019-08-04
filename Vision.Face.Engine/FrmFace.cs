using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Vision.DataModel;
using System.Runtime.InteropServices;
using Luxand;
using LiveRecognition;
using Apteka.Utils;

namespace Vision.Face.Engine
{
    public partial class FrmFace : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private enum ProgramState { psRemember, psRecognize }
        private ProgramState programState = ProgramState.psRecognize;
        private string cameraName;
        private bool needClose = false;
        private string userName;
        private string TrackerMemoryFile = "tracker70.dat";
        private int mouseX = 0;
        private int mouseY = 0;

        [DllImport("gdi32.dll")]
        static extern bool DeleteObject(IntPtr hObject);

        private List<tbFace> list;

        public FrmFace()
        {
            InitializeComponent();

            list = new List<tbFace>();
            gridControl1.DataSource = list;

            CreateEngine();
        }

        public void CreateEngine()
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("gyYgVWQTSzjiuGB/hH8dKgg0QrrIuhoHdfUCzD9rY+vru3WRZsaezTX6YWj9osdI/cmxY1NSdLkyWuugMPCxUG7/xNLegHLeaUpzVyKpDkaWL8tJIUsIL7xv9bhmgifPbAyTDuxF3VGxXmHkv/L/MStf9kdXV/A1vVvT93QC4vQ="))
            {
                MessageBox.Show("Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", "Error activating FaceSDK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
            FSDKCam.InitializeCapturing();

            string[] cameraList;
            int count;
            FSDKCam.GetCameraList(out cameraList, out count);

            if (0 == count)
            {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            cameraName = cameraList[0];

            FSDKCam.VideoFormatInfo[] formatList;
            FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out count);
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            programState = ProgramState.psRemember;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mouseX = 0;
            mouseY = 0;
        }

        private void Start(string MediaPath, int SelectedIndex)
        {
            int cameraHandle = 0;

            int r = FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle);
            if (r != FSDK.FSDKE_OK)
            {
                MessageBox.Show("Error opening the first camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            int tracker = 0; 	// creating a Tracker
            if (FSDK.FSDKE_OK != FSDK.LoadTrackerMemoryFromFile(ref tracker, TrackerMemoryFile)) // try to load saved tracker state
                FSDK.CreateTracker(ref tracker); // if could not be loaded, create a new tracker

            int err = 0; // set realtime face detection parameters
            FSDK.SetTrackerMultipleParameters(tracker, "HandleArbitraryRotations=false; DetermineFaceRotationAngle=false; InternalResizeWidth=100; FaceDetectionThreshold=5;", ref err);
            
            while (!needClose)
            {
                Int32 imageHandle = 0;
                if (FSDK.FSDKE_OK != FSDKCam.GrabFrame(cameraHandle, ref imageHandle)) // grab the current frame from the camera
                {
                    Application.DoEvents();
                    continue;
                }
                FSDK.CImage image = new FSDK.CImage(imageHandle);

                long[] IDs;
                long faceCount = 0;
                FSDK.FeedFrame(tracker, 0, image.ImageHandle, ref faceCount, out IDs, sizeof(long) * 256); // maximum of 256 faces detected
                Array.Resize(ref IDs, (int)faceCount);

                // make UI controls accessible (to find if the user clicked on a face)
                Application.DoEvents();

                Image frameImage = image.ToCLRImage();
                Graphics gr = Graphics.FromImage(frameImage);

                for (int i = 0; i < IDs.Length; ++i)
                {
                    FSDK.TFacePosition facePosition = new FSDK.TFacePosition();
                    FSDK.GetTrackerFacePosition(tracker, 0, IDs[i], ref facePosition);

                    int left = facePosition.xc - (int)(facePosition.w * 0.6);
                    int top = facePosition.yc - (int)(facePosition.w * 0.5);
                    int w = (int)(facePosition.w * 1.2);

                    int res = FSDK.GetAllNames(tracker, IDs[i], out string name, 65536); // maximum of 65536 characters

                    if (FSDK.FSDKE_OK == res && name.Length > 0)
                    { 
                        // draw name
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;

                        gr.DrawString(name, new Font("Arial", 16),
                            new System.Drawing.SolidBrush(Color.LightGreen),
                            facePosition.xc, top + w + 5, format);
                    }

                    Pen pen = Pens.LightGreen;
                    if (mouseX >= left && mouseX <= left + w && mouseY >= top && mouseY <= top + w)
                    {
                        pen = Pens.Blue;
                        if (ProgramState.psRemember == programState)
                        {
                            if (FSDK.FSDKE_OK == FSDK.LockID(tracker, IDs[i]))
                            {
                                // get the user name 
                                InputName inputName = new InputName();
                                if (DialogResult.OK == inputName.ShowDialog())
                                {
                                    userName = inputName.userName;
                                    if (userName == null || userName.Length <= 0)
                                    {
                                        string s = "";
                                        FSDK.SetName(tracker, IDs[i], "");
                                        FSDK.PurgeID(tracker, IDs[i]);
                                    }
                                    else
                                    {
                                        FSDK.SetName(tracker, IDs[i], userName);
                                    }
                                    FSDK.UnlockID(tracker, IDs[i]);
                                }
                            }
                        }
                    }
                    gr.DrawRectangle(pen, left, top, w, w);
                }

                programState = ProgramState.psRecognize;

                // display current frame
                pictureBox1.Image = frameImage;
                GC.Collect(); // collect the garbage after the deletion
            }
            FSDK.SaveTrackerMemoryToFile(tracker, TrackerMemoryFile);
            FSDK.FreeTracker(tracker);

            FSDKCam.CloseVideoCamera(cameraHandle);
            FSDKCam.FinalizeCapturing();
        }

        private void Stop()
        {
            needClose = true;
        }
        
        private void gridView1_Click(object sender, EventArgs e)
        {
            var sel = gridView1.GetFocusedRow() as tbFace;
            if (sel != null)
            {
                pictureBox2.Image = CImage.ByteArrayToImage( sel.PlateImageBg.Data);
            }
        }

        private void btnStart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Start("", 0);
        }

        private void btnStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Stop();
        }

        private void FrmFace_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
    }
}