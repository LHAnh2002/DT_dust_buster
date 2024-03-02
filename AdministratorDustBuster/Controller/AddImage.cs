using DevExpress.Utils.Behaviors.Common;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorDustBuster.DTO
{
    internal class AddImage
    {
        private FirebaseStorage storage;
        
        public async Task<string> UploadImageToFirebase(Image image, string id)
        {
            storage = new FirebaseStorage("dustbuster-d9b9f.appspot.com");

            // Tạo MemoryStream từ ảnh
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                memoryStream.Position = 0;

                // Tải lên ảnh vào Firebase Storage
                var task = storage.Child(id+"png").PutAsync(memoryStream);

                // Lấy URL của ảnh đã tải lên
                string imageUrl = await task;
                return imageUrl.ToString();
            }
        }
    }
}
