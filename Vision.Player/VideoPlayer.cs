using System.Drawing;
using System.Windows.Forms;
using Declarations;
using Declarations.Players;
using Declarations.Media;
using Implementation;
using System;
using Declarations.Enums;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Vision.Player
{
    public partial class VideoPlayer : UserControl
    {
        public VideoPlayer()
        {
            InitializeComponent();

            Aspect_Ratio = AspectRatioMode.Default;
        }

        private IVideoPlayer m_player;
        private int FrameRate = 25;
        private int Index;
        private string Name;
        private IMemoryRenderer memRender;

        public AspectRatioMode Aspect_Ratio { get; set; }
        public delegate void NewFrame(Bitmap frame, int index, string name);
        public event NewFrame NewFrameEvent;

        public void Start(int index, string name, string url)
        {
            Index = index;
            Name = name;

            IMediaPlayerFactory factory = new MediaPlayerFactory();
            IMedia media = factory.CreateMedia<IMedia>(url);
            m_player = factory.CreatePlayer<IVideoPlayer>();
            m_player.WindowHandle = this.Handle;

            memRender = m_player.CustomRenderer;
            memRender.SetFormat(new BitmapFormat(Width, Height, ChromaType.RV16));

            m_player.AspectRatio = Aspect_Ratio;
            m_player.Open(media);
            m_player.Play();
            timer1.Enabled = true;
        }

        public void Stop()
        {
            timer1.Enabled = false;
            m_player.Stop();
        }

    
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                Bitmap bmp = memRender.CurrentFrame;

                //var bbb = FixedSize(bmp, Width, Height);

                var pictureboxContext = this.CreateGraphics();
                pictureboxContext.DrawImage(bmp, 0, 0);


                Console.WriteLine($"{memRender.CurrentFrame.Height} {memRender.CurrentFrame.Width} {memRender.CurrentFrame.Size}");
                bmp.Dispose();
            }
            catch (Exception)
            {

            }
        }

        public Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode = InterpolationMode.Default;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void VideoPlayer_Paint(object sender, PaintEventArgs e)
        {
            //if (bmp!=null)
            //e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
