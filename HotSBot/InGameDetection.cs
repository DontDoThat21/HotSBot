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

        List<char> usedChars = new List<char>();

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
            SendKeys.SendWait("l");
            SendKeys.SendWait("l");
        }

        public void DisconnectRejoiner()
        {
            VirtualMouse vm = new VirtualMouse();

            vm.MoveTo(30000, 40000);
            Thread.Sleep(500);
            vm.LeftClick();
            SendKeys.SendWait("l");
            SendKeys.SendWait("l");
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
            percentageToStop = 0;

            for (int i = 0; i < 5; i++)
            {
                decrementingPercentage = decrementingPercentage * .75;
                if ((decrementingPercentage * 100) >= percentageToStop)
                {
                    char hkey = SelectHotkeyRandomly(charArray, usedChars);
                    SendKeys.SendWait(hkey.ToString());
                }                
                
            }

        }

        private char SelectHotkeyRandomly(char[] charArray, List<char> usedChars)
        {
            VirtualMouse vm = new VirtualMouse();
            Random rand = new Random();
            int range = rand.Next(0, charArray.Length - 1);
            try
            {
                for (int i = 0; i < charArray.Length - 1; i++)
                {
                    char c = charArray[range];
                    range = rand.Next(0, charArray.Length - 1);

                    if (usedChars.Contains(c) == true)
                    {                        
                        SelectHotkeyRandomly(charArray, usedChars);
                        // We need to restart since we just casted that...
                    }
                    else if (usedChars.Contains(c) == false)
                    {
                        usedChars.Add(c);
                        SendKeys.SendWait("s");
                        int xOffset = rand.Next(-4, 4);
                        int yOffset = rand.Next(-4, 4);
                        vm.MoveTo(33500 + (xOffset * 3000), 30000 + (yOffset * 3000));
                        SendKeys.SendWait(c.ToString());
                    }
                    return c;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return '.';
        }
    }
}
