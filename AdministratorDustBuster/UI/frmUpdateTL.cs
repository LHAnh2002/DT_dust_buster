using AdministratorDustBuster.DTO;
using DevExpress.XtraEditors;
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
    public partial class frmUpdateTL : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();
        public frmUpdateTL(string id, int time, string acreage, string room, int money)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _httpClient = new HttpClient();

            lbnot.Text = "";

            txtid.Text = id;

            txtthoiluong.Text = time.ToString();

            txtdientich.Text = acreage;

            txtsophong.Text = room;

            txtTien.Text = money.ToString();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;

                int time = int.Parse(txtthoiluong.Text.Trim());
                string acreage = txtdientich.Text.Trim();
                string room = txtsophong.Text.Trim();
                int money = int.Parse(txtTien.Text.Trim());

                // Gửi yêu cầu xác thực sử dụng token đã lưu đến API
                string jsonBody = $"{{ \"id\": \"{id}\", \"time\": {time}, \"acreage\": \"{acreage}\", \"room\": \"{room}\", \"money\": {money} }}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PutAsync(cf.api + "/admin/update-service-duration/", content);
                lbnot.Text = "Sửa Thời lượng thành công!";
                lbnot.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải data: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}