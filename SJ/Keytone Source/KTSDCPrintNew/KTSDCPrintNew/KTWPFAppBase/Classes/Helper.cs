﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Media.Imaging;


namespace KTWPFAppBase.Classes
{
    //Design by Pongsakorn Poosankam
    public class Helper
    {
        //Block Memory Leak
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr handle);
        public static BitmapSource bs;
        public static IntPtr ip;
        public static BitmapSource LoadBitmap(System.Drawing.Bitmap source)
        {

            ip = source.GetHbitmap();

            bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip, IntPtr.Zero, System.Windows.Int32Rect.Empty,

                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());

            DeleteObject(ip);

            return bs;

        }
        public static void SaveImageCapture(BitmapSource bitmap)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmap));
            encoder.QualityLevel = 100;

            // Configure save file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".Jpg"; // Default file extension
            dlg.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save Image
                string filename = dlg.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                encoder.Save(fstream);
                fstream.Close();
            }
        }

        public static BitmapImage GetBitmapImage(string path)
        {
            try
            { // Create source
                BitmapImage myBitImage = new BitmapImage();
                myBitImage.BeginInit();
                myBitImage.UriSource = new Uri(path);
                myBitImage.EndInit();

                return myBitImage;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static BitmapImage GetBitmapImage(byte[] imageBytes)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(imageBytes, 0, imageBytes.Length);

                return GetBitmapImage(mStream);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static BitmapImage GetBitmapImage(MemoryStream mStream)
        {
            try
            {
                BitmapImage myBitImage = new BitmapImage();
                myBitImage.BeginInit();

                myBitImage.StreamSource = mStream;
                myBitImage.EndInit();

                return myBitImage;
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
