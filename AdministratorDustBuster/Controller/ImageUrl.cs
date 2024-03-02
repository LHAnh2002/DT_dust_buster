using System;
using System.Drawing;
using System.Net;
using DevExpress.XtraEditors;

namespace AdministratorDustBuster.Controller
{
    internal class ImageUrl
    {
        public void ImageURL(PictureEdit pic, string url)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Tải hình ảnh từ URL
                    byte[] imageData = webClient.DownloadData(url);

                    // Chuyển đổi dữ liệu byte thành hình ảnh
                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image loadedImage = Image.FromStream(ms);

                        // Gán hình ảnh vào PictureEdit
                        pic.Image = loadedImage;
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có
                    XtraMessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
