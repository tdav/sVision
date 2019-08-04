using AS.Video.Core;
using System;

namespace Vision.Player
{
    public class PlayerEngine
    {
        public bool Run(string url, string username, string password)
        {
            var t = new VideoSourceInfo();
            t.ConnectionString = "rtsp://192.168.1.120";
            t.Login = "admin";
            t.Password = "123456";
            t.DesiredMaxFrameRate = 10;
            var ss = AS.Video.Sources.Basic.OpenCv.OpenCvVideoSourceCreator.TryToCreateVideoSource(t);
            ss.NewFrame += Ss_NewFrame;
            ss.Start();
            return true;
        }

        private void Ss_NewFrame(object sender, NewFrameEventArgs e)
        {
            Console.WriteLine(e.FrameTime);
        }
    }
}
