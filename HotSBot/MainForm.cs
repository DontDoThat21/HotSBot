using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using Tesseract;

namespace HotSBot
{
    public partial class hotsBot : Form
    {
        public hotsBot()
        {
            {
                InitializeComponent();
            }

        }

        private void hotsBot_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            VirtualMouse vm = new VirtualMouse();
            string result = "";

            Thread.Sleep(1000);
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                    Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(@"C:\Temp\HotSBot\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


            var allProcesses = Process.GetProcessesByName("explorer");
            if (allProcesses.Length == 0)
            {
                MessageBox.Show("");
            }
        }
    }
}
