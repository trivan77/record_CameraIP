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

namespace Record_CameraIP
{
     public partial class Form1 : Form
     {
          MJPEGStream stream;
          
          public Form1()
          {
               InitializeComponent();
               stream = new MJPEGStream("http://192.168.1.120/action/stream?subject=mjpeg&user=admin@pwd=12345");
               stream.NewFrame += GetNewFrame;
          }

          void GetNewFrame(object sender, NewFrameEventArgs eventarg)
          {
               Bitmap bmp = (Bitmap)eventarg.Frame.Clone();
               display.Image = bmp;
          }

          private void btnStart_Click(object sender, EventArgs e)
          {
               stream.Start();
          }
     }
}
