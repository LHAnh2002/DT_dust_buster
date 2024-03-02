using AdministratorDustBuster.Controller;
using AdministratorDustBuster.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorDustBuster.UI
{
    public partial class frmUpdateDV : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        ImageUrl imageUrl = new ImageUrl();

        AddImage uploader = new AddImage();

        public frmUpdateDV(string id, string name, string icon, string note)
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            picIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

            txtid.Text = id;

            txtNameDV.Text = name;

            imageUrl.ImageURL(picIcon, icon);

            txtNote.Text = note;

            lbnot.Text = "";

        }

        private async void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;

                string name = txtNameDV.Text.Trim();

                // Lấy ảnh từ PictureBox
                string imageUrl = await uploader.UploadImageToFirebase(picIcon.Image, id);

                string note = txtNote.Text.Trim();

                // Gửi yêu cầu xác thực sử dụng token đã lưu đến API
                string jsonBody = $"{{ \"id\": \"{id}\", \"name\": \"{name}\", \"icon\": \"{imageUrl}\", \"note\": \"{note}\" }}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync(cf.api + "/admin/update-all-service/", content);
                lbnot.Text = "Update dịch vụ thành công!";
                lbnot.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải data: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn tệp để người dùng chọn ảnh từ thư mục
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Title = "Chọn ảnh";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc ảnh từ tệp được chọn
                    string imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);

                    // Gán ảnh vào PictureBox
                    picIcon.Image = image;
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra trong quá trình đọc ảnh từ tệp
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}