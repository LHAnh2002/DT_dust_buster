using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;
using System.Net.Http;
using AdministratorDustBuster.DTO;
using System.Net;
using AdministratorDustBuster.Controller;
namespace AdministratorDustBuster.UI
{
    public partial class frmProfile : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        WaitForm1 waitForm = new WaitForm1();

        string savedToken = Properties.Settings.Default.token;

        public string imageUrl;

        public string id;

        AddImage uploader = new AddImage();

        ImageUrl Url = new ImageUrl();

        public frmProfile()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            string savedToken = Properties.Settings.Default.token;

            picAvt.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // Lấy kích thước hiện thời của PictureEdit
            Size size = picAvt.Size;

            // Tính đường kính của hình tròn (lấy giá trị nhỏ nhất giữa chiều rộng và chiều cao của PictureEdit)
            int diameter = Math.Min(size.Width, size.Height);

            // Tạo hình tròn
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(Point.Empty, new Size(diameter, diameter)));

            // Thiết lập Region cho PictureEdit
            picAvt.Region = new Region(path);

            

            hienThi(savedToken);
        }


        public async void hienThi(string token)
        {
            try
            {
                // Gửi yêu cầu GET đến API và nhận phản hồi
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await _httpClient.GetAsync(cf.api + "/admin/select-admin-information/");

                // Đảm bảo yêu cầu thành công
                response.EnsureSuccessStatusCode();

                // Đọc phản hồi dưới dạng chuỗi JSON
                string responseBody = await response.Content.ReadAsStringAsync();

                // Phân tích chuỗi JSON thành đối tượng AdminInfo
                dynamic responseData = JsonConvert.DeserializeObject(responseBody);
                Admin adminInfo = JsonConvert.DeserializeObject<Admin>(JsonConvert.SerializeObject(responseData["admin_info"]));

                // Hiển thị thông tin trong các điều khiển giao diện của bạn
                id = adminInfo.Id;
                txtid.Text = id;
                txtname.Text = adminInfo.Name;
                txtemail.Text = adminInfo.Email;
                txtsdt.Text = adminInfo.PhoneNumber;
                imageUrl = adminInfo.Image.Trim();
                if(adminInfo.Sex == 1)
                {
                    txtgioitinh.Text = "Nam";
                }
                else if(adminInfo.Sex == 2)
                {
                    txtgioitinh.Text = "Nữ";
                }
                else
                {
                    txtgioitinh.Text = "Khác";
                }
                txtngaysinh.Text = adminInfo.DateBirth;
                txtDiachi.Text = adminInfo.permanent_address;
                txtdiachitamtru.Text = adminInfo.temporary_residence_address;
                txtcv.Text = adminInfo.position;
                txtngaythamgia.Text = adminInfo.JoiningDate;
                if(adminInfo.Role == 2)
                {
                    txtQuyenhan.Text = "Admin";
                }else if(adminInfo.Role == 1)
                {
                    txtQuyenhan.Text = "Quản lý";
                }
                else
                {
                    txtQuyenhan.Text = "Nhân viên";
                }

                if(imageUrl != "")
                {
                    Url.ImageURL(picAvt, imageUrl);
                }

            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndoiemail_Click(object sender, EventArgs e)
        {
            frmChangeEmail frm = new frmChangeEmail();
            frm.ShowDialog();
        }

        private void picAvt_Click(object sender, EventArgs e)
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
                    picAvt.Image = image;
                }
                catch (Exception ex)
                {
                    // Xử lý nếu có lỗi xảy ra trong quá trình đọc ảnh từ tệp
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                waitForm.Show();
                // Lấy ảnh từ PictureBox
                string imageUrl = await uploader.UploadImageToFirebase(picAvt.Image, id);
                string phonenumber = txtsdt.Text.Trim();
                // Gửi yêu cầu xác thực sử dụng token đã lưu đến API
                string jsonBody = $"{{ \"image\": \"{imageUrl}\", \"phonenumber\": \"{phonenumber}\" }}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
                HttpResponseMessage response = await _httpClient.PutAsync(cf.api + "/admin/update-admin-avatar/", content);
                waitForm.Close();
                XtraMessageBox.Show("Chỉnh sửa Thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải data: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}