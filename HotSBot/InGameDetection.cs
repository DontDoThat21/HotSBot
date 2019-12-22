using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace HotSBot
{
    class InGameDetection
    {
        public void GetGameStatus()
        {
            Bitmap img = new Bitmap(@"C:\Users\ttrub\Desktop\tomb.jpg");
            TesseractEngine eng = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = eng.Process(img, PageSegMode.Auto);

            string mapWereOn = page.GetText().ToLower();
            
            if (mapWereOn.Contains("mura"))
            {
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
        }
    }
}
