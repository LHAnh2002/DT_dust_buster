using AdministratorDustBuster.DTO;
using AdministratorDustBuster.UI;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace AdministratorDustBuster
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;
        Config cf = new Config();

        public frmLogin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtMK.Properties.PasswordChar = '*';

            lbNote.Text = "";

            _httpClient = new HttpClient();

            string savedToken = Properties.Settings.Default.token;

            if (!string.IsNullOrEmpty(savedToken))
            {
                // Thực hiện xác thực sử dụng token đã lưu
                AuthenticateWithSavedToken(savedToken);
            }
            else
            {
                // Không có token đã lưu, cho phép người dùng đăng nhập bình thường
                InitializeLoginForm();
            }

        }

        private async void AuthenticateWithSavedToken(string savedToken)
        {
            try
            {
                // Gửi yêu cầu xác thực sử dụng token đã lưu đến API
                StringContent content = new StringContent("", Encoding.UTF8, "application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/verify-token/", content);

                if (response.IsSuccessStatusCode)
                {
                    // Token hợp lệ, chuyển tới form frmMain
                    OpenMainForm();
                }
                else
                {
                    // Token không hợp lệ hoặc đã hết hạn, hiển thị form đăng nhập
                    InitializeLoginForm();
                }
            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi HTTP nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InitializeLoginForm()
        {
            // Hiển thị form đăng nhập
            this.Show();
        }
        private void OpenMainForm()
        {
            // Đóng form đăng nhập và mở form frmMain
            this.Hide();
            frmMain f = new frmMain();
            f.ShowDialog();
        }
        private async void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.Trim();
            string password = txtMK.Text.Trim();

            // Tạo dữ liệu gửi đi dưới dạng JSON
            string jsonBody = $"{{ \"username\": \"{username}\", \"password\": \"{password}\" }}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu đăng nhập đến API
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/admin/login/", content);

                // Kiểm tra trạng thái của phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);

                    // Lấy thông tin token từ phản hồi
                    string accessToken = responseData.access_token;
                    string tokenType = responseData.token_type;
                    // Lấy thông tin token từ phản hồi và lưu trữ

                    Properties.Settings.Default.token = accessToken;
                    Properties.Settings.Default.Save();

                    this.Hide();
                    frmMain f = new frmMain();
                    f.ShowDialog();
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    // Phản hồi không thành công với mã lỗi 401 (Unauthorized)
                    // Xử lý lỗi theo chi tiết trả về từ API
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);
                    int errorCode = responseData.detail;

                    switch (errorCode)
                    {
                        case -1:
                            lbNote.Text = "Tên đăng nhập không tồn tại.";
                            lbNote.ForeColor = Color.Red;
                            break;
                        case -2:
                            lbNote.Text = "Mật khẩu không chính xác.";
                            lbNote.ForeColor = Color.Red;
                            break;
                        case -3:
                            lbNote.Text = "Tài khoản chưa được kích hoạt.";
                            lbNote.ForeColor = Color.Red;
                            break;
                        default:
                            XtraMessageBox.Show("Lỗi đăng nhập không xác định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    // Xử lý các lỗi khác nếu cần
                    XtraMessageBox.Show($"Lỗi không xác định: {response.StatusCode}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                // Xử lý các lỗi khác nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkQuenMK_Click(object sender, EventArgs e)
        {
            frmForgotPassword f = new frmForgotPassword();
            f.ShowDialog();
        }

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.Properties.PasswordChar = cbMK.Checked ? '\0' : '*';
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi phương thức xử lý đăng nhập
                btnDangnhap_Click(sender, e);
            }
        }
    }
}