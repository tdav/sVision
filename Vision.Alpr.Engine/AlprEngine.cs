using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision.Alpr.Engine
{
    public class AlprEngine
    {
        //private void axVideoCapture1_FrameReceived(object sender, AxDTKVideoCapLib._IDTKVideoCaptureEvents_FrameReceivedEvent e)
        //{
        //    try
        //    {
        //        engine.ReadFromBitmap((int)e.hBitmap, 0);
        //        if (engine.Plates.Count > 0)
        //        {
        //            string text = "";
        //            for (int i = 0; i < engine.Plates.Count; i++)
        //            {
        //                IPlate plate = engine.Plates.get_Item(i);
        //                if (text.Length > 0)
        //                    text += "\r\n";
        //                text += plate.Text;

        //                Image frame = Image.FromHbitmap((IntPtr)plate.Bitmap);

        //                Marshal.ReleaseComObject(plate);
        //                plate = null;
        //            }

        //            GC.Collect();

        //            SetText(text, labelPlates);
        //        }
        //    }
        //    catch (COMException ex)
        //    {
        //        string errorText = "";
        //        engine.GetLastErrorText(ref errorText);
        //        //MessageBox.Show(errorText + " (ErrorCode = " + ex.ErrorCode.ToString() + ")");
        //    }
        //    GC.Collect();
        //}
    }
}
