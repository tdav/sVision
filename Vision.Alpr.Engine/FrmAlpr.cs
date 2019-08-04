using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DTK.LPR.Lib;
using ReadWriteMemory;
using System.IO;
using Vision.DataModel;
using Apteka.Utils;
using Apteka.Others;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace Vision.Alpr.Engine
{
    public partial class FrmAlpr : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private VideoCapture videoCap = null;
        private LPREngine engine = null;
        private LPRParams lprParams = new LPRParams();
        private bool patched;

        private List<tbAlpr> list;

        public FrmAlpr()
        {
            InitializeComponent();

            list = new List<tbAlpr>();
            gridControl1.DataSource = list;
        }
 
        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void CreateLPREngine(bool bVideo)
        {
            if (engine != null)
            {
                engine.Dispose();
            }

            // Set LPR settings
            //lprParams.MinCharHeight = (int)numMinCharHeight.Value;
            //lprParams.MaxCharHeight = (int)numMaxCharHeight.Value;
            //lprParams.Countries = txtCountryCodes.Text;
            //lprParams.FPSLimit = (int)numFPSLimit.Value;
            //lprParams.NumThreads = (int)numNumThreads.Value;
            //lprParams.RecognitionOnMotion = cbRecognitionOnMotion.Checked;
            //lprParams.BurnFormatString = txtBurnString.Text;
            //lprParams.BurnPosition = cmbBurnPos.SelectedIndex;

            // Create LPREngine object
            if (bVideo)
                engine = new LPREngine(lprParams, true, OnLicensePlateDetected);
            else
                engine = new LPREngine(lprParams, false, null);

            if (engine.IsLicensed == 1)
                MessageBox.Show("The computer have not runtime license activated. The LPR will be disabled.\nPlease contact at support@dtksoft.com to request trial license.", "No License", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (engine.IsLicensed == 2)
                MessageBox.Show("The runtime license do not allow more channels. The LPR will be disabled.", "No License", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Start(string MediaPath, int SelectedIndex)
        {
            if (!patched)
            {
                if (DoPatch64Bit(Path.GetFileNameWithoutExtension(AppDomain.CurrentDomain.FriendlyName), "DTKLPR4.dll"))
                {
                    patched = true;
                    //  MessageBox.Show("Patched!");
                }
                else
                {
                    patched = false;
                    MessageBox.Show("Not patched!");
                }
            }

            CreateLPREngine(true);

            if (videoCap != null)
            {
                videoCap.StopCapture();
                videoCap.Dispose();
            }

            // Create video capture object
            videoCap = new VideoCapture(OnFrameCaptured, OnCaptureError, engine);

            // Start capture from selected video source
            if (SelectedIndex == 0)
                videoCap.StartCaptureFromIPCamera(MediaPath);

            if (SelectedIndex == 1)
                videoCap.StartCaptureFromFile(MediaPath, 0);

            if (SelectedIndex == 2)
                videoCap.StartCaptureFromDevice(0, 0, 0);
        }

        private void Stop()
        {
            if (videoCap != null)
                videoCap.StopCapture();
        }

        public void OnFrameCaptured(VideoCapture videoCap, IntPtr pBuffer, int width, int height, int stride, PIXFMT pixelFormat, long timestamp, object customObject)
        {
            LPREngine engine = (LPREngine)customObject;
            engine.PutFrameImageBuffer(pBuffer, width, height, stride, pixelFormat, timestamp, 0);
            Bitmap bmp = DTKLPR4.CreateBitmapFromBuffer(pBuffer, width, height, stride, pixelFormat);
            SetFrame(bmp);
        }

        public void OnCaptureError(VideoCapture videoCap, ERR_CAPTURE errorCode, object customObject)
        {
            if (errorCode == ERR_CAPTURE.EOF)
            {
                SetFrame(null);
            }
        }

        public void OnLicensePlateDetected(LPREngine engine, LicensePlate plate)
        {
            AddPlate(plate);
        }

        public void AddPlate(LicensePlate plate)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { AddPlate(plate); });
                return;
            }

            var d = new tbAlpr();
            d.CreateDate = plate.DateTime;
            d.Plate = plate.Text + ((plate.CountryCode.Length > 0) ? " (" + plate.CountryCode + ")" : "");
            d.Direction = plate.Direction.ToString();
            d.PlateImageSm.Data = CImage.ImageToByte( plate.PlateImage );
            d.PlateImageBg.Data = CImage.ImageToByte(plate.Image);
            pictureBox2.Image = plate.Image;

            list.Add(d);
            gridControl1.RefreshDataSource();

            gridView1.MoveLast();
        }

        public void SetFrame(Image image)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate { SetFrame(image); });
                return;
            }
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = image;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            var sel = gridView1.GetFocusedRow() as tbAlpr;
            if (sel != null)
            {
                pictureBox2.Image = CImage.ByteArrayToImage( sel.PlateImageBg.Data);
            }
        }

        private bool DoPatch64Bit(string appExe, string dllName)
        {
            ProcessMemory Mem = new ProcessMemory(appExe);

            if (!Mem.CheckProcess())
            {
                //"Is Running ?"
                return false;
            }
            else
                Mem.StartProcess();

            byte[] buff;

            IntPtr baseoffset;
            IntPtr offset;
            baseoffset = Mem.DllImageAddress(dllName);
            offset = baseoffset + 23704519;
            buff = Mem.ReadMem(offset, 3);

            if (!(buff[0] == 0xC6 && buff[1] == 0x00 && buff[2] == 0x24))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0x90;
            buff[1] = 0x90;
            buff[2] = 0x90;
            Mem.WriteMem(offset, buff);

            offset = baseoffset + 23704541;
            buff = Mem.ReadMem(offset, 5);

            if (!(buff[0] == 0xC6 && buff[1] == 0x44 && buff[2] == 0x08 && buff[3] == 0xFF))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0x90;
            buff[1] = 0x90;
            buff[2] = 0x90;
            buff[3] = 0x90;
            buff[4] = 0x90;

            Mem.WriteMem(offset, buff);
            offset = baseoffset + 22128914;
            buff = Mem.ReadMem(offset, 2);

            if (!(buff[0] == 0x74 && buff[1] == 0x03))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0xEB;
            Mem.WriteMem(offset, buff);
            offset = baseoffset + 22129554;

            buff = Mem.ReadMem(offset, 4);

            if (!(buff[0] == 0x0F && buff[1] == 0x85 && buff[2] == 0xB5 && buff[3] == 0x03))
            {
                //"Not Found!"
                return false;
            }

            buff[2] = 0x00;
            buff[3] = 0x00;
            Mem.WriteMem(offset, buff);
            offset = baseoffset + 22128738;
            buff = Mem.ReadMem(offset, 2);

            if (!(buff[0] == 0x74 && buff[1] == 0x03))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0xEB;
            Mem.WriteMem(offset, buff);
            offset = baseoffset + 22128504;
            buff = Mem.ReadMem(offset, 2);

            if (!(buff[0] == 0x74 && buff[1] == 0x03))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0xEB;
            Mem.WriteMem(offset, buff);
            offset = baseoffset + 23735088;
            buff = Mem.ReadMem(offset, 8);

            if (!(buff[0] == 0x41 && buff[1] == 0x80 && buff[2] == 0xBD && buff[3] == 0xC4 && buff[4] == 0x02))
            {

                //"Not Found!"
                return false;
            }

            buff[1] = 0xC6;
            buff[2] = 0x85;
            buff[7] = 0x01;
            Mem.WriteMem(offset, buff);
            offset = baseoffset + 23735096;
            buff = Mem.ReadMem(offset, 5);

            if (!(buff[0] == 0x0F && buff[1] == 0x85 && buff[2] == 0xAB && buff[3] == 0x00 && buff[4] == 0x00))
            {
                //"Not Found!"
                return false;
            }

            buff[0] = 0x90;
            buff[1] = 0xE9;
            Mem.WriteMem(offset, buff);
            return true;
        }

        private void btnVideo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var VideoFile = openFileDialog1.FileName;
                Start(VideoFile, 1);
            }
        }

        private void btnImage_ItemClick(object sender, ItemClickEventArgs e)
        {
            var url = ImputBoxDev.Show("RTSP Url", "Введите URL-адрес IP-камеры");
            if (url != "")
            {
                Start(url, 0);
            }
        }

        private void btnStop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Stop();
        }
    }
}