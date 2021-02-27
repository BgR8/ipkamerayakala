using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;

namespace ipKamera
{
    public partial class Form1 : Form
    {
        MJPEGStream stream;
        public Form1()
        {
            InitializeComponent();
            // url, şifre ve kullanıcıadı IP kamera için
            stream = new MJPEGStream("http://192.168.1.21:4747/mjpegfeed?960x720");
            stream.NewFrame += GetNewFrame;
        }

        void GetNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            stream.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stream.Stop();
        }
    }
}
