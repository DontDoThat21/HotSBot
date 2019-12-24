using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using IronOcr;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace HotSBot
{
    class InGameDetection
    {
        public bool inAGame = false;
        public bool searchingForGame = false;


        public string GetCurrentMap(Bitmap bm)
        {
            string mapResult = "";

            Bitmap img = new Bitmap(@"C:\Temp\HotSBot\mapCapture.jpg");

            string mapWereOn = "";
            using (TesseractEngine eng = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
            {
                using (Page page = eng.Process(img, PageSegMode.Auto))
                {
                    //mapWereOn = page.GetText().ToLower();
                    var Ocr = new AutoOcr();
                    var Result = Ocr.Read(@"C:\Temp\HotSBot\mapCapture.jpg");
                    mapWereOn += Result.Text;
                    img.Dispose();
                }
            }

            if (mapWereOn.Contains("mura"))
            {
                mapResult = "Hanamura";
                MessageBox.Show("Were on hanamura.");
            }
            else if (mapWereOn.Contains("tomb") | mapWereOn.Contains("spider"))
            {
                MessageBox.Show("We're on tomb.");
            }
            else if (mapWereOn.Contains("sky") | mapWereOn.Contains("temple"))
            {

            }
            else if (mapWereOn.Contains("battlefield") | mapWereOn.Contains("eternity"))
            {

            }
            else if (mapWereOn.Contains("alterac") | mapWereOn.Contains("pass"))
            {

            }
            else if (mapWereOn.Contains("heart") | mapWereOn.Contains("bay"))
            {

            }
            else if (mapWereOn.Contains("cursed") | mapWereOn.Contains("hollow"))
            {

            }
            else if (mapWereOn.Contains("garden") | mapWereOn.Contains("terror"))
            {

            }
            else if (mapWereOn.Contains("infernal") | mapWereOn.Contains("shrines"))
            {

            }
            else if (mapWereOn.Contains("tower") | mapWereOn.Contains("doom"))
            {

            }
            else if (mapWereOn.Contains("warhead") | mapWereOn.Contains("junction"))
            {

            }
            else // Since all other searches failed, assume we're searching, then verify as such?
            {
                //Thread.Sleep(3500);
                //Bitmap screenSearchRegion = new Bitmap((int)(Screen.PrimaryScreen.Bounds.Width/10),
                //                    (int)(Screen.PrimaryScreen.Bounds.Height * .2));
                //Graphics graphics = Graphics.FromImage(screenSearchRegion as Image);
                //graphics.CopyFromScreen((int)(Screen.PrimaryScreen.Bounds.Width*.90),
                //    Screen.PrimaryScreen.Bounds.Height - (int)(Screen.PrimaryScreen.Bounds.Height * .20), 
                //    0, 
                //    0, 
                //    screenSearchRegion.Size);

                //screenSearchRegion = MakeGrayscale(screenSearchRegion);
                //screenSearchRegion = AdjustContrast(screenSearchRegion, 100);
                //screenSearchRegion.Save(@"C:\Temp\HotSBot\screenSearchTime.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                //using (TesseractEngine engScreen = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
                //{
                //    using (Page pageScreenSearch = engScreen.Process(screenSearchRegion, PageSegMode.Auto))
                //    {
                //        mapWereOn = pageScreenSearch.GetText().ToLower();
                //        screenSearchRegion.Dispose();
                //    }
                //}

                // SearchForGame();

            }

            return mapResult;
        }

        internal void SelectTalent()
        {
            Random rand = new Random();
            int random1to3 = rand.Next(1, 3);
            SendKeys.SendWait($"^{random1to3.ToString()}");
        }

        internal void SelectRandomSelectHero()
        {
            VirtualMouse vm = new VirtualMouse();
            vm.MoveTo(32000, 37000); Thread.Sleep(300); // 60 to 51 is fine.
            vm.LeftClick(); Thread.Sleep(300);
            vm.MoveTo(9000, 15000); Thread.Sleep(300); // 60 to 51 is fine.
            vm.LeftClick(); Thread.Sleep(300);
            //vm.MoveTo(6000, 5000); Thread.Sleep(300); // 60 to 51 is fine.

        }

        internal void EndOfGameLeaveButtonClick()
        {
            VirtualMouse vm = new VirtualMouse();
            vm.MoveTo(1800, 63000); Thread.Sleep(100); // This handles Exit if need to exit/skip when game ends.
            vm.LeftClick();
            vm.MoveTo(6000, 62000); Thread.Sleep(100); // 60 to 51 is fine.
            vm.LeftClick();
        }
        //{
        //    //Thread.Sleep(3500);
        //    Bitmap screenSearchReady = new Bitmap((int)(Screen.PrimaryScreen.Bounds.Width * .2),
        //                            (int)(Screen.PrimaryScreen.Bounds.Height * .2));

        //    Graphics graphics = Graphics.FromImage(screenSearchReady as Image);
        //    graphics.CopyFromScreen((int)(Screen.PrimaryScreen.Bounds.Width * .40),
        //        Screen.PrimaryScreen.Bounds.Height - (int)(Screen.PrimaryScreen.Bounds.Height * .20),
        //        0,
        //        0,
        //        screenSearchReady.Size);

        //    screenSearchReady = MakeGrayscale(screenSearchReady);
        //    screenSearchReady = AdjustContrast(screenSearchReady, 100);
        //    screenSearchReady.Save(@"C:\Temp\HotSBot\screenSearchReady.jpg");

        //    var Ocr = new AutoOcr();
        //    var Result = Ocr.Read(@"C:\Temp\HotSBot\screenSearchReady.jpg");
        //    string res = Result.Text;

        //    if (inAGame == false)
        //    {
        //        using (TesseractEngine eng = new TesseractEngine("./tessdata", "eng", EngineMode.Default))
        //        {
        //            using (Page page = eng.Process(screenSearchReady, PageSegMode.Auto))
        //            {
        //                res += page.GetText().ToLower();
        //                if (res.Contains("cancel") | res.Contains("match") | res.Contains("searching") | res.Contains("estimated") | res.Contains("wait") 
        //                    | res.Contains("elapsed") | res.Contains("time") | res.Contains("searching") | res.Contains("search") | res.Contains("quick"))
        //                {
        //                    inAGame = false;
        //                    searchingForGame = true;
        //                    SearchForGame();
        //                }
        //                else
        //                {

        //                }
        //                screenSearchReady.Dispose();
        //            }
        //        }
        //    }
        //    else // Maybe we should gather in game data here? What hero are we?
        //    {

        //    }
        //}

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
             new float[] {.3f, .3f, .3f, 0, 0},
             new float[] {.59f, .59f, .59f, 0, 0},
             new float[] {.11f, .11f, .11f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }

        public static Bitmap AdjustContrast(Bitmap Image, float Value)
        {
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(
                new Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height),
                ImageLockMode.ReadWrite,
                NewBitmap.PixelFormat);
            int Height = NewBitmap.Height;
            int Width = NewBitmap.Width;

            unsafe
            {
                for (int y = 0; y < Height; ++y)
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for (int x = 0; x < Width; ++x)
                    {
                        byte B = row[columnOffset];
                        byte G = row[columnOffset + 1];
                        byte R = row[columnOffset + 2];

                        float Red = R / 255.0f;
                        float Green = G / 255.0f;
                        float Blue = B / 255.0f;
                        Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                        Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                        Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                        int iR = (int)Red;
                        iR = iR > 255 ? 255 : iR;
                        iR = iR < 0 ? 0 : iR;
                        int iG = (int)Green;
                        iG = iG > 255 ? 255 : iG;
                        iG = iG < 0 ? 0 : iG;
                        int iB = (int)Blue;
                        iB = iB > 255 ? 255 : iB;
                        iB = iB < 0 ? 0 : iB;

                        row[columnOffset] = (byte)iB;
                        row[columnOffset + 1] = (byte)iG;
                        row[columnOffset + 2] = (byte)iR;

                        columnOffset += 4;
                    }
                }
            }

            NewBitmap.UnlockBits(data);

            return NewBitmap;
        }

        public void ReadyUp()
        {
            VirtualMouse vm = new VirtualMouse();

            vm.MoveTo(28200, 60000);
            Thread.Sleep(500);
            vm.LeftClick();
        }

        public void DisconnectRejoiner()
        {
            VirtualMouse vm = new VirtualMouse();

            vm.MoveTo(30000, 40000);
            Thread.Sleep(500);
            vm.LeftClick();
        }

        public void GoMid()
        {
            Random rand = new Random();

            List<int> yCoords = new List<int>()
            {
                52000, 54000, 56000, 58000, 60000 // List<int> yCoords = new List<int>() { 52000, 53000, 54000, 55000, 56000, 57000, 58000, 59000, 60000 } ;
            };
            VirtualMouse vm = new VirtualMouse();

            for (int i = 0; i < yCoords.Count; i++)
            {
                vm.MoveTo(58150, yCoords.ElementAt(rand.Next(0, 4))); // 60 to 51 is fine.
                int randomSleep;
                randomSleep = rand.Next(700, 1300);
                Thread.Sleep(randomSleep);
                SendKeys.SendWait("+a");
            }
        }

        public void Feed()
        {
            Random rand = new Random();

            List<int> yCoords = new List<int>()
            {
                52000, 54000, 56000, 58000, 60000 // List<int> yCoords = new List<int>() { 52000, 53000, 54000, 55000, 56000, 57000, 58000, 59000, 60000 } ;
            };
            VirtualMouse vm = new VirtualMouse();

            for (int i = 0; i < yCoords.Count; i++)
            {
                vm.MoveTo(58150, yCoords.ElementAt(rand.Next(0, 4))); // 60 to 51 is fine.
                int randomSleep;
                randomSleep = rand.Next(700, 1300);
                Thread.Sleep(randomSleep);
                SendKeys.SendWait("+a");
            }

            for (int i = 0; i < yCoords.Count; i++)
            {
                vm.MoveTo(54300, yCoords.ElementAt(rand.Next(0, 4))); // 60 to 51 is fine.
                int randomSleep;
                randomSleep = rand.Next(700, 1300);
                Thread.Sleep(randomSleep);
                SendKeys.SendWait("+a");
            }

            for (int i = 0; i < yCoords.Count; i++)
            {
                vm.MoveTo(62000, yCoords.ElementAt(rand.Next(0, 4))); // 60 to 51 is fine.
                int randomSleep;
                randomSleep = rand.Next(700, 1300);
                Thread.Sleep(randomSleep);
                SendKeys.SendWait("+a");
            }
            Thread.Sleep(500);
            vm.LeftClick();


        }

        public void RandomAbility()
        {
            char[] charArray =
                {
                'q', 'w', 'e', 'd', 'r'
            };
            int abilitiesToPress = 1;   
            double decrementingPercentage = 1;
            Random rand = new Random();
            int percentageToStop = rand.Next(1, 100); // 0 to 100; 

            for (int i = 0; i < 5; i++)
            {
                decrementingPercentage = decrementingPercentage * .75;
                if ((decrementingPercentage * 100) >= percentageToStop)
                {
                    switch (i)
                    {
                        case 0:
                            SendKeys.SendWait("q");
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;

                        default:
                            break;
                            //Test.
                    }
                    SendKeys.SendWait("+a");
                }
                
                
            }


            // Here, we're going to randomly decide how many abilties to try to spam. In a random direction of course.
            for (int i = 0; i < 5; i++) // 5 max.. Q, W, E, R, D
            {

            }
        }
    }
}
