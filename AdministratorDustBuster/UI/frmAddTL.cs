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
    public partial class frmAddTL : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        RandomID random = new RandomID();
        public frmAddTL()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _httpClient = new HttpClient();

            lbnot.Text = "";
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int time = int.Parse(txtthoiluong.Text.Trim());
                string acreage = txtdientich.Text.Trim();
                string room = txtsophong.Text.Trim();
                int money = int.Parse(txtTien.Text.Trim());

                int status = 1;

                if (time.ToString() == "")
                {
                    lbnot.Text = "Thời lượng không thể bỏ trống.";
                    lbnot.ForeColor = System.Drawing.Color.Red;
                    txtthoiluong.Focus();
                    return;
                }
                if (acreage == "")
                {
                    lbnot.Text = "Diện tích không thể bỏ trống.";
                    lbnot.ForeColor = System.Drawing.Color.Red;
                    txtdientich.Focus();
                    return;
                }
                if (room == "")
                {
                    lbnot.Text = "Số phòng không thể bỏ trống.";
                    lbnot.ForeColor = System.Drawing.Color.Red;
                    txtsophong.Focus();
                    return;
                }
                if (money.ToString() == "")
                {
                    lbnot.Text = "Giá không thể bỏ trống.";
                    lbnot.ForeColor = System.Drawing.Color.Red;
                    txtTien.Focus();
                    return;
                }
                string jsonBody = $"{{\"time\": {time}, \"acreage\": \"{acreage}\", \"room\": \"{room}\", \"money\": {money}, \"status\": {status} }}";

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/admin/create-service-duration/", content);
                lbnot.Text = "Thêm Thời lượng thành công.";
                lbnot.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi tải data: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}