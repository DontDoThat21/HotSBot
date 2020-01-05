using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Deployment.Application;

namespace HotSBot
{
    public partial class hotsBot : Form
    {
        //public DateTime gameFoundTime = DateTime.Now;
        public DateTime timeToStop = new DateTime();
        private KeyHandler ghk;
        string ver;

        public hotsBot()
        {
            {    
                InitializeComponent();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeToStop = SetTimeToEndBot();

            Task startBotAsync = new Task(() =>
            {
                Begin();
            }); startBotAsync.Start();

            //Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            //                        Screen.PrimaryScreen.Bounds.Height);
            
            //bitmap = new Bitmap(@"C:\Users\Tylor\Desktop\goodGreen.png");
            //IronOcr.AutoOcr ocr = new IronOcr.AutoOcr();
            //var x = ocr.Read(bitmap);
            //string res = x.Text;

            //bitmap.Save(@"C:\Users\Tylor\Desktop\testColor.png");

            //if (Directory.Exists(@"C:\Temp:HotsBot\"))
            //{
            //    bitmap.Save(@"C:\Temp\HotSBot\mapCapture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //}
            //else
            //{
            //    Directory.CreateDirectory(@"C:\Temp\HotSBot\");
            //    bitmap.Save(@"C:\Temp\HotSBot\mapCapture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //}

            //InGameDetection igd = new InGameDetection();
            //igd.GetCurrentMap(bitmap);

        }

        private DateTime SetTimeToEndBot()
        {
            int hours = 0;
            bool hoursIsNum = int.TryParse(hoursTBox.Text, out hours);
            if (!hoursIsNum | hoursTBox.Text == "")
            {
                rtbConsole.AppendText("\n Failed to enter number of hours. Assuming infinite.");
            }

            int mins = 0;
            bool minsIsNum = int.TryParse(minsTBox.Text, out mins);
            if (!minsIsNum | minsTBox.Text == "")
            {
                rtbConsole.AppendText("\n Failed to enter number of minutes.");
            }

            int day = DateTime.Now.AddHours(hours).AddMinutes(mins).Day; // This sets the day of the added hour/mins.

            DateTime timeToEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day, hours, mins, 0, 0);
            return timeToEnd;
        }

        private void Begin()
        {

            var hotsExists = Process.GetProcessesByName("HeroesOfTheStorm_x64");
            if (hotsExists.Length == 0)
            {
                string hotsLoc = "";
                try
                {
                    hotsLoc = Registry.GetValue(@"HKEY_CLASSES_ROOT\Blizzard.StormReplay\DefaultIcon", "", "wtf?").ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't find HotS.");
                }
                if (hotsLoc.Contains("HeroesSwitcher_x64")) 
                {
                    int indexStop = hotsLoc.IndexOf(",") - 2;
                    hotsLoc = hotsLoc.Replace("\"", "");
                    hotsLoc = hotsLoc.Substring(0, indexStop);
                    Process.Start(hotsLoc);
                    //rtbConsole.AppendText($"Openning up HotS found at {hotsLoc}, retard :) \n");
                    //rtbConsole.AppendText($"Openning up HotS found at {hotsLoc}, retard :) \n");
                }
            }

            InGameDetection ig = new InGameDetection();
            Task obj;

            //ig.RandomAbility();

            ig.SelectRandomSelectHero();
            Thread.Sleep(500);
            
            ig.ReadyUp();
            Thread.Sleep(500);

            ig.GoMid();
            Thread.Sleep(500);

            ig.Feed();
            Thread.Sleep(500);

            ig.SelectTalent();
            Thread.Sleep(500);

            ig.DisconnectRejoiner();
            Thread.Sleep(500);

            ig.EndOfGameLeaveButtonClick();
            Thread.Sleep(2000);
            
            Task redo = new Task(() =>
            {
                Begin();
            }); redo.Start();

        }

        private void hotsBot_Load(object sender, EventArgs e)
        {
            //picBoxMurky.Op
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
