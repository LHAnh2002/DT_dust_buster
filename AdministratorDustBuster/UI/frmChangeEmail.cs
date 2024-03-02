using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Windows.Forms;
using AdministratorDustBuster.DTO;

namespace AdministratorDustBuster.UI
{
    public partial class frmChangeEmail : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;
        Config cf = new Config();

        string token = Properties.Settings.Default.token;
        public frmChangeEmail()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lbNote.Text = "";

            _httpClient = new HttpClient();
        }

        private async void btnGuiMa_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim() + "@gmail.com";

            if (email == "@gmail.com")
            {
                lbNote.Text = "Bạn cần nhập email.";
                lbNote.ForeColor = Color.Red;
                txtemail.Focus();
                return;
            }

            btnGuiMa.Enabled = false;

            txtotp.Focus();

            // Tạo dữ liệu gửi đi dưới dạng JSON
            string jsonBody = $"{{ \"email\": \"{email}\"}}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu otp đến API
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/admin/request-otp-new-email/", content);

                // Kiểm tra trạng thái của phản hồi
                if (response.IsSuccessStatusCode)
                {
                    // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic responseData = JsonConvert.DeserializeObject(responseBody);

                    // Gọi hàm đếm ngược
                    StartCountdownTimer();

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

                    string jsonemail = $"{{ \"email\": \"{email}\"}}";
                    StringContent content_email = new StringContent(jsonemail, Encoding.UTF8, "application/json");

                    try
                    {
                        // Gửi yêu cầu đăng nhập đến API
                        _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                        HttpResponseMessage response_email = await _httpClient.PutAsync(cf.api + "/admin/admin-update-email/", content_email);

                        // Kiểm tra trạng thái của phản hồi
                        if (response_email.IsSuccessStatusCode)
                        {
                            // Phản hồi thành công, tiếp tục xử lý phản hồi như thông thường
                            string responseBodyEmail = await response.Content.ReadAsStringAsync();
                            dynamic responseData_email = JsonConvert.DeserializeObject(responseBodyEmail);

                            lbNote.Text = "Xác thực email thành công.";
                            lbNote.ForeColor = Color.Green;

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
    }
}