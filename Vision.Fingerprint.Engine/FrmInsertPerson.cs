using Apteka.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vision.DataModel;

namespace Vision.Fingerprint.Engine
{
    public partial class FrmInsertPerson : DevExpress.XtraEditors.XtraForm
    {
        private int index = 0;
        private FingerprintX _fx;

        public FrmInsertPerson(FingerprintX fx)
        {
            InitializeComponent();
            _fx = fx;
            _fx.OnNewFinger += Fx_OnNewFinger;
            
        }

        private void Fx_OnNewFinger(object sender, Bitmap img)
        {
            index++;

            switch (index)
            {
                case 1: piFp1.Image = img;
                    break;
                case 2: piFp2.Image = img;
                    break;
                case 3: piFp3.Image = img;
                    break;
                case 4: piFp4.Image = img;
                    break;
            }
            
        }

        private void FrmInsertPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fx.OnNewFinger -= Fx_OnNewFinger;
        }

        public tbFingerprint GetData()
        {
            var fi = new tbFingerprint();
            fi.LastName = edName.Text; 
            fi.Templates = new List<tbBinaryData>();
            fi.Templates.Add(new tbBinaryData(CImage.ImageToByte(piFp1.Image)));
            fi.Templates.Add(new tbBinaryData(CImage.ImageToByte(piFp2.Image)));
            fi.Templates.Add(new tbBinaryData(CImage.ImageToByte(piFp3.Image)));
            fi.Templates.Add(new tbBinaryData(CImage.ImageToByte(piFp4.Image)));
            fi.Photo = new tbBinaryData(CImage.ImageToByte(piPhoto.Image));
            return fi;
        }
    }
}
