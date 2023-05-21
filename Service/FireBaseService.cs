﻿using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using OOAD_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_Project.Model;

namespace OOAD_Project.Service
{
    internal class FireBaseService
    {
        private static IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "FDU6QrUwmvIyIdW0rXt7ZXyNiTK988aUC5LLQQB4",
            BasePath = "https://rental-disc-store-management-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        public IFirebaseClient client = new FireSharp.FirebaseClient(_config);

        public async void PushImage(PictureBox imgBox, String ImagePath)
        {
            //Push  - Picturebox  => ms => byte Array => toBase64String

            MemoryStream ms = new MemoryStream();
            Bitmap bitmap = new Bitmap(imgBox.Image);
            bitmap.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new ImageModel
            {
                Img = output
            };

            SetResponse response = await client.SetTaskAsync(ImagePath, data);
            ImageModel result = response.ResultAs<ImageModel>();

            imgBox.Image = null;

        }

        public async void RetrieveImage(PictureBox imgBox, String ImagePath)
        {
            //Retrieve base64 => byte[] => ms => bitmap

            FirebaseResponse response = await client.GetTaskAsync(ImagePath);
            if (response.Body != "null")
            {
                ImageModel image = response.ResultAs<ImageModel>();

                byte[] b = Convert.FromBase64String(image.Img);

                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));

                Bitmap bm = new Bitmap(ms, false);
                ms.Dispose();

                imgBox.Image = bm;
            }
            else
            {
                imgBox.Image = Resources.Cream_logo;
            }
        }
    }
}
