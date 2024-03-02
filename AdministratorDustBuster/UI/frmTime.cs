using AdministratorDustBuster.DTO;
using AdministratorDustBuster.Model;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorDustBuster.UI
{
    public partial class frmTime : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        WaitForm1 waitForm = new WaitForm1();

        private BindingList<ServiceDuration> getServicesDuration = new BindingList<ServiceDuration>();

        public frmTime()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            gcData.DataSource = getServicesDuration;

            HienThi();
        }
        public async void HienThi()
        {
            try
            {
                HttpResponseMessage httpRequest = await _httpClient.GetAsync(cf.api + "/admin/select-service-duration/");

                httpRequest.EnsureSuccessStatusCode();

                string responseBody = await httpRequest.Content.ReadAsStringAsync();

                dynamic responseData = JsonConvert.DeserializeObject<dynamic>(responseBody);
                List<ServiceDuration> serviceDurationList = JsonConvert.DeserializeObject<List<ServiceDuration>>(JsonConvert.SerializeObject(responseData["service_duration"]));
                getServicesDuration.Clear();

                // Thêm dịch vụ vào danh sách
                foreach (ServiceDuration serviceDuration in serviceDurationList)
                {
                    serviceDuration.Money = int.Parse(serviceDuration.Money).ToString("C", CultureInfo.GetCultureInfo("vi-VN"));

                    if (int.Parse(serviceDuration.Status) == 0)
                    {
                        serviceDuration.Status = "Đang Khóa";
                    }
                    else
                    {
                        serviceDuration.Status = "Đang Mở";
                    }
                    getServicesDuration.Add(serviceDuration);
                }
                gvData.OptionsBehavior.Editable = false;


            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gcData_DoubleClick(object sender, EventArgs e)
        {
            string id = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[0]);
            int time = (int)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[1]);
            string acreage = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[2]);
            string room = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[3]);
            int money = (int)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[4]);
            frmUpdateTL f = new frmUpdateTL(id, time, acreage, room, money);
            f.FormClosed += FrmUpdateDV_FormClosed;
            f.ShowDialog();
        }
        private void FrmUpdateDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            HienThi();
        }
        private void btnAddTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddTL f = new frmAddTL();
            f.FormClosed += FrmAddTL_FormClosed;
            f.ShowDialog();
        }
        private void FrmAddTL_FormClosed(object sender, FormClosedEventArgs e)
        {
            HienThi();
        }
        private async void btnKhoaTL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[0]);
            string status = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[5]);
            int block;
            if (status == "Đang Mở")
            {
                block = 0;
            }
            else
            {
                block = 1;
            }

            string jsonBody = $"{{ \"id\": \"{id}\", \"status\": {block}}}";
            StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                // Gửi yêu cầu đăng nhập đến API
                HttpResponseMessage response = await _httpClient.PutAsync(cf.api + "/admin/update-status-service-duration/", content);
                HienThi();
                XtraMessageBox.Show($"Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (HttpRequestException ex)
            {
                // Xử lý các lỗi khác nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HienThi();
        }
    }
}