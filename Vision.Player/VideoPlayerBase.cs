using Declarations;
using Declarations.Media;
using Declarations.Players;
using Implementation;
using System;
using System.Drawing;

namespace Vision.Player
{

    public partial class VideoPlayerBase
    {
        public VideoPlayerBase(IntPtr handle)
        {
            Aspect_Ratio = AspectRatioMode.Default;
            Handle = handle;
        }

        private IVideoPlayer m_player;
        private IntPtr Handle;
        
        public AspectRatioMode Aspect_Ratio { get; set; }
        public delegate void NewFrame(Bitmap frame, int index, string name);
        public event NewFrame NewFrameEvent;

        public void Start(int index, string name, string url)
        {
            IMediaPlayerFactory factory = new MediaPlayerFactory();
            IMedia media = factory.CreateMedia<IMedia>(url);
            m_player = factory.CreatePlayer<IVideoPlayer>();
            m_player.WindowHandle = Handle;

            //IMemoryRenderer memRender = m_player.CustomRenderer;
            //memRender.SetCallback(delegate (Bitmap frame)
            //{
            //    // NewFrameEvent?.Invoke(frame, index, name);
            //    Console.WriteLine(frame.Size);
            //});

            //memRender.SetFormat(new BitmapFormat(704, 576, ChromaType.RV24));
            m_player.AspectRatio = Aspect_Ratio;
            m_player.Open(media);
            m_player.Play();
        }

        public void Stop()
        {
            m_player.Stop();
        }
    }
}
