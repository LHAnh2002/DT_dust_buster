using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using AdministratorDustBuster.DTO;
using System.Net;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text;
namespace AdministratorDustBuster.UI
{
    public partial class frmService : DevExpress.XtraEditors.XtraForm
    {
        private readonly HttpClient _httpClient;

        Config cf = new Config();

        WaitForm1 waitForm = new WaitForm1();

        private BindingList<Service> getServices = new BindingList<Service>();
        public frmService()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            gcData.DataSource = getServices;

            HienThi();
            //gvData.CustomRowCellEdit += gvData_CustomRowCellEdit;
            //gvData.CustomUnboundColumnData += gvData_CustomUnboundColumnData;
            
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // Lấy chỉ số hàng được click
            int rowIndex = gvData.FocusedRowHandle;

            // Thực hiện các xử lý dựa trên chỉ số hàng hoặc dữ liệu hàng tại đó
            // Ví dụ:
            Service service = gvData.GetRow(rowIndex) as Service;
            if (service != null)
            {
                MessageBox.Show($"Button clicked for service: {service.Name}");
            }
        }
        //private void gvData_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        //{
        //    if (e.Column.FieldName == "Icon")
        //    {
        //        RepositoryItemPictureEdit repositoryItemPictureEdit = new RepositoryItemPictureEdit();
        //        e.RepositoryItem = repositoryItemPictureEdit;
        //    }
        //}

        //private void gvData_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        //{
        //    if (e.IsGetData && e.Column.FieldName == "Icon")
        //    {
        //        Service service = gvData.GetRow(e.ListSourceRowIndex) as Service;
        //        if (service != null)
        //        {
        //            Convert image URL to image
        //           Image image = DownloadImage(service.Icon);
        //            e.Value = image;
        //        }
        //    }
        //}

        private Image DownloadImage(string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show($"Failed to download image from {imageUrl}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Invalid image format: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while downloading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


        public async void HienThi()
        {
            try
            {
                HttpResponseMessage httpRequest = await _httpClient.GetAsync(cf.api + "/admin/select-service/");

                httpRequest.EnsureSuccessStatusCode();

                string responseBody = await httpRequest.Content.ReadAsStringAsync();

                dynamic responseData = JsonConvert.DeserializeObject<dynamic>(responseBody);
                List<Service> serviceList = JsonConvert.DeserializeObject<List<Service>>(JsonConvert.SerializeObject(responseData["service"]));
                getServices.Clear();

                // Thêm dịch vụ vào danh sách
                foreach (Service service in serviceList)
                {

                    if (int.Parse(service.Status) == 0)
                    {
                        service.Status = "Đang Khóa";
                    }
                    else
                    {
                        service.Status = "Đang Mở";
                    }
                    getServices.Add(service);
                }
                gvData.OptionsBehavior.Editable = false;
                

            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddDV f = new frmAddDV();
            f.FormClosed += FrmAddDV_FormClosed;
            f.ShowDialog();
        }
        private void FrmAddDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            HienThi();
        }
        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HienThi();
        }

        private async void btnKhoaDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[0]);
            string status = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[4]);
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
                HttpResponseMessage response = await _httpClient.PutAsync(cf.api + "/admin/update-service/", content);
                HienThi();
                XtraMessageBox.Show($"Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (HttpRequestException ex)
            {
                // Xử lý các lỗi khác nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcData_DoubleClick(object sender, EventArgs e)
        {
            string id = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[0]);
            string name = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[1]);
            string icon = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[2]);
            string note = (string)gvData.GetRowCellValue(gvData.FocusedRowHandle, gvData.Columns[3]);
            frmUpdateDV f = new frmUpdateDV(id, name, icon, note);
            f.FormClosed += FrmUpdateDV_FormClosed;
            f.ShowDialog();
        }
        private void FrmUpdateDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            HienThi();
        }
    }
}