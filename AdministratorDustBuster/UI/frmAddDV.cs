using AdministratorDustBuster.DTO;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors;
using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorDustBuster.UI
{
    public partial class frmAddDV : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        WaitForm1 waitForm = new WaitForm1();

        AddImage uploader = new AddImage();

        RandomID random = new RandomID();

        

        public frmAddDV()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            picIcon.Properties.NullText = "Chọn vào để\nthêm Icon.";

            picIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

            _httpClient = new HttpClient();

            txtid.Text = "DV-" + random.GenerateRandomId().ToString().Trim();

            lbnot.Text = "";
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

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;

                string name = txtNameDV.Text.Trim();
                string note = txtNote.Text.Trim();

                int status = 1;

                if(name == "")
                {
                    lbnot.Text = "Tên dịch vụ không thể bỏ trống.";
                    lbnot.ForeColor = System.Drawing.Color.Red;
                    txtNameDV.Focus();
                    return;
                }
                string imageUrl = await uploader.UploadImageToFirebase(picIcon.Image, id);
                string jsonBody = $"{{ \"id\": \"{id}\", \"name\": \"{name}\", \"icon\": \"{imageUrl}\", \"note\": \"{note}\" , \"status\": {status} }}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/admin/create-service/", content);
                lbnot.Text = "Thêm Dịch vụ thành công.";
                lbnot.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải data: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}