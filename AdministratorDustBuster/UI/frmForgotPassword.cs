using AdministratorDustBuster.DTO;
using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing;
using System.Net;

namespace AdministratorDustBuster.UI
{
    public partial class frmForgotPassword : DevExpress.XtraEditors.XtraForm
    {

        private readonly HttpClient _httpClient;
        Config cf = new Config();

        public frmForgotPassword()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtmk.Properties.PasswordChar = '*';

            txtnlmk.Properties.PasswordChar = '*';

            lbNote.Text = "";

            _httpClient = new HttpClient();
        }

        private async void btnGuiMa_Click(object sender, EventArgs e)
        {
            btnGuiMa.Enabled = false;

            txtotp.Focus();

            string email = txtemail.Text.Trim() + "@gmail.com";

            // Tạo dữ liệu gửi đi dưới dạng JSON
            string jsonBody = $"{{ \"email\": \"{email}\"}}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu đăng nhập đến API
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/admin/request-otp/", content);

                // Kiểm tra trạng thái của phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);

                    // Gọi hàm đếm ngược
                    StartCountdownTimer();

                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Phản hồi không thành công với mã lỗi 401 (Unauthorized)
                    // Xử lý lỗi theo chi tiết trả về từ API
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);
                    int errorCode = responseData.detail;

                    switch (errorCode)
                    {
                        case -1:
                            lbNote.Text = "Email không tồn tại.";
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
        private void StartCountdownTimer()
        {
            // Thực hiện đếm ngược trong 60 giây
            int remainingSeconds = 60;
            Timer countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // Cập nhật mỗi giây
            countdownTimer.Tick += (sender, e) =>
            {
                remainingSeconds--;
                if (remainingSeconds <= 0)
                {
                    // Hủy bỏ hàm đếm ngược khi đã đủ 60 giây
                    countdownTimer.Stop();
                    // Kích hoạt nút "Gửi Mã" và đặt lại văn bản của nút
                    btnGuiMa.Enabled = true;
                    btnGuiMa.Text = "Gửi Mã";
                }
                else
                {
                    // Cập nhật văn bản của nút với thời gian còn lại
                    btnGuiMa.Text = $"Gửi Mã ({remainingSeconds}s)";
                }
            };
            // Bắt đầu đếm ngược
            countdownTimer.Start();
        }

        private async void btnxmotp_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim() + "@gmail.com";
            string otp = txtotp.Text.Trim();

            // Tạo dữ liệu gửi đi dưới dạng JSON
            string jsonBody = $"{{ \"email\": \"{email}\", \"otp\": \"{otp}\"}}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu đăng nhập đến API
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/verify-otp/", content);

                // Kiểm tra trạng thái của phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);

                    lbMK.Enabled = true;
                    lbnl.Enabled = true;
                    txtmk.Enabled = true;
                    txtnlmk.Enabled = true;
                    cbMK.Enabled = true;
                    cbNLMK.Enabled = true;
                    btnDLMK.Enabled = true;

                    txtmk.Focus();

                    lbNote.Text = "Xác minh thành công.";
                    lbNote.ForeColor = Color.Green;

                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    // Phản hồi không thành công với mã lỗi 401 (Unauthorized)
                    // Xử lý lỗi theo chi tiết trả về từ API
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);
                    int errorCode = responseData.detail;

                    switch (errorCode)
                    {
                        case -1:
                            lbNote.Text = "OTP không tồn tại.";
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

        private async void btnDLMK_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim() + "@gmail.com";
            string mk = txtmk.Text.Trim();
            string nlmk = txtnlmk.Text.Trim();

            if(mk != nlmk)
            {
                lbNote.Text = "Mật khẩu không trùng nhau.";
                lbNote.ForeColor = Color.Red;
                txtmk.Focus();

                return;
            }

            // Tạo dữ liệu gửi đi dưới dạng JSON
            string jsonBody = $"{{ \"email\": \"{email}\", \"new_password\": \"{mk}\"}}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu đăng nhập đến API
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/verify-otp/", content);

                // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic responseData = JsonConvert.DeserializeObject(responseBody);
             
                lbNote.Text = "Đổi mật khẩu thành công.";
                lbNote.ForeColor = Color.Green;

            }
            catch (HttpRequestException ex)
            {
                // Xử lý các lỗi khác nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMK_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.Properties.PasswordChar = cbMK.Checked ? '\0' : '*';
        }

        private void cbNLMK_CheckedChanged(object sender, EventArgs e)
        {
            txtnlmk.Properties.PasswordChar = cbNLMK.Checked ? '\0' : '*';
        }
    }

}