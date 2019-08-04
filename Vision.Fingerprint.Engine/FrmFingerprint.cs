using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vision.DataModel;

namespace Vision.Fingerprint.Engine
{
    public partial class FrmFingerprint : RibbonForm
    {
        private FingerprintX fx;
        private bool IsStartCam = false;
        private bool IsFormActivate = true;
        private List<string> cbGolos = new List<string>();

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        public FrmFingerprint()
        {
            InitializeComponent();
          
                var method = ribbonControl.GetType().GetMethod("OnFullScreenModeChangeCore", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                method.Invoke(ribbonControl, null);

                fx = new FingerprintX();


                fx.OnNewFinger += Fx_OnNewFinger;
                Text = "Fingerprint device " + fx.DeviceId;           
        }
        
        public Bitmap CropImage(Image source, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
            return bmp;
        }

        private void Fx_OnNewFinger(object sender, Bitmap img)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, -1);

            if (IsFormActivate)
            {
                piFingerprint.Image = img;
                GetPersonFromFPDevice();
            }
        }

        private void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (FrmInsertPerson f = new FrmInsertPerson(fx))
            {
                IsFormActivate = false;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //var di = f.GetData();
                    //DbStore.InsPerson(f.edName.Text, ls);
                    //var db = DbStore.GetPersons();
                    //fx.Fill(db);

                    MessageBox.Show("Ok");
                }
                IsFormActivate = true;
            }
        }
              
        private void btnOk_Click(object sender, EventArgs e)
        {
            //gridControl2.DataSource = DbStore.GetTimePersons(String.Format("WHERE TB_DATE BETWEEN {0} AND {1}",
            //    dateEdit1.Text.ToQuote(), dateEdit2.Text.ToQuote()));
        }


        private void GetPersonFromFPDevice()
        {
            //var person = new tbFingerprint();
            //person.Id = -1;
            //person.FirstName = "";

            //var fp = new FingerprintX();
            //fp.AsBitmap = piFingerprint.Image as Bitmap;
            //person.Fingerprints.Add(fp);

            //var found = fx.Identify(person);

            //if (found != null)
            //{
            //    FoundPerson(found);
            //}
            //else
            //{
            //    piPhoto.Image = Image.FromFile("avatar_2x.png");
            //    SoundPlayer simpleSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "denied.wav");
            //    simpleSound.Play();
            //}
        }

        private void FoundPerson(tbFingerprint found)
        {
            //piPhoto.Image = CImage.ByteArrayToImage(found.Photo);
            //DbStore.InsTimeToPerson(found.Id);
            //gridControl1.DataSource = DbStore.GetTimePersons("WHERE TB_DATE BETWEEN TRUNC(SYSDATE) AND SYSDATE");
        }        
    }
}