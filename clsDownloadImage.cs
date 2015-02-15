using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace freelancehunt
{
    /// <summary>
    /// класс для загрузки изображения из интернета
    /// </summary>
    class clsDownloadImage
    {
        public delegate void evImageDownloadHandle(Image img);
        public event evImageDownloadHandle evImageDownload;

        int imgDownloadTryCount = 0;
        Image image = null;
        string url;
        PictureBox pcbAvatar = null;

        void downLoadImage()
        {
            Thread.Sleep(250);

            try
            {
                Image img = null;

                using (WebClient wClient = new WebClient())
                {
                    Uri uri = new Uri(this.url);

                    byte[] imageByte = wClient.DownloadData(uri);
                    using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                    {
                        ms.Write(imageByte, 0, imageByte.Length);
                        image = Image.FromStream(ms, true);
                    }
                }

                this.pcbAvatar.BeginInvoke(new Action(() =>
                {
                    this.pcbAvatar.Image = img;
                }));
            }
            catch (Exception)
            {
                try
                {
                    imgDownloadTryCount++;

                    if (imgDownloadTryCount < 100)
                    {
                        Thread.Sleep(500);

                        Thread th = new Thread(downLoadImage);
                        th.Start();

                        return;
                    }
                }
                catch (Exception) { }
            }
        }

        public clsDownloadImage(string url, PictureBox pcbAvatar)
        {
            this.url = url;

            Thread th = new Thread(downLoadImage);
            th.Start();
        }
    }
}
