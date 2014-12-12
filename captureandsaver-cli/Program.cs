using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace captureandsaver_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Bitmap / Graphics
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gdigrap = Graphics.FromImage(bmp);
            //Copy all screen elements (CopyFromScreen)
            gdigrap.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
            //Graphics Dispose
            gdigrap.Dispose();
            //Save ("Screenshot-YYYY-MM-DD_HH-MM-SS.png")
            //TODO: ハードコードはよくなさそうなので後で設定用のiniとかで変更できるようにする
            bmp.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) 
                + "\\Screenshot-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "_"
                + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
