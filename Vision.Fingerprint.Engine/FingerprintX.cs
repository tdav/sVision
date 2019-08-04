using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using SourceAFIS.Simple;
using Vision.DataModel;
using ZKFPEngXControl;

namespace Vision.Fingerprint.Engine
{
    public class FingerprintX : IDisposable
    {
        private ZKFPEngX fp;
        private AfisEngine Afis;
        public List<tbFingerprint> database = new List<tbFingerprint>();
        public string DeviceId;

        public delegate void DelegateOnNewFinger(object sender, Bitmap img);
        public event DelegateOnNewFinger OnNewFinger;
        
        public FingerprintX()
        {
            Afis = new AfisEngine();
            Afis.Threshold = 30;

            fp = new ZKFPEngX();
            fp.SensorIndex = 0;
            if (fp.InitEngine() == 0)
            {
                fp.FPEngineVersion = "10";
                fp.CreateFPCacheDB();

                fp.Active = true;
                fp.OnImageReceived += Fp_OnImageReceived;
                DeviceId = fp.SensorSN; 
            }
            else
            {
                DeviceId = "not found";
            }
        }

        private void Fp_OnImageReceived(ref bool AImageValid)
        {
            Bitmap img = new Bitmap(350, 400, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(img);
            IntPtr dc = g.GetHdc();
            fp.PrintImageAt(dc.ToInt32(), 0, 0, img.Width, img.Height);
            g.Dispose();

            OnNewFinger?.Invoke(this, img);
        }

        public void Fill(List<tbFingerprint> db)
        {
            database.Clear();

            foreach (tbFingerprint person in db)
            {
                Afis.Extract(person);

                // FSDK.CImage img = new FSDK.CImage(Asbt.Utils.CImage.ByteArrayToImage( person.Photo ));
                //person.PhotoTemplate = img.GetFaceTemplate();
                database.Add(person);
            }
        }

        public tbFingerprint Identify(tbFingerprint probe)
        {
            Afis.Extract(probe);
            return Afis.Identify(probe, database).FirstOrDefault() as tbFingerprint;
        }

        //public MyPerson IdentifyFromPhote(Image img)
        //{
        //    float Similarity = 0.0f;
        //    float Threshold = 0.0f;
        //    float FARValue = 80;

        //    byte[] facetem = faceRecognition.GetFaceTemplateFromImage(img);

        //    Threshold = faceRecognition.GetFARValue(FARValue);
        //    Dictionary<float, long> fountFace = new Dictionary<float, long>();
        //    foreach (MyPerson f in database)
        //    {
        //        Similarity = faceRecognition.MatchFaces(f.PhotoTemplate, facetem, FARValue);
        //        if (Similarity >= Threshold)
        //        {
        //            fountFace.Add(Similarity, f.Id);
        //        }
        //    };

        //    KeyValuePair< float, long> item = fountFace.OrderByDescending(key => key.Value).FirstOrDefault();

        //    foreach (MyPerson person in database)
        //    {
        //        if (person.Id == item.Value)
        //        {
        //            return person;
        //        }
        //    }
        //    return null;
        //}



        public float Verify(tbFingerprint probe, tbFingerprint match)
        {
            return Afis.Verify(probe, match);
        }

        public void Dispose()
        {
            // fp.Active = false;
        }
    }
}
