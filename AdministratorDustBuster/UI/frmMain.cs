using AdministratorDustBuster.DTO;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace AdministratorDustBuster.UI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly HttpClient _httpClient;
        Config cf = new Config();

        string savedToken = Properties.Settings.Default.token;

        WaitForm1 waitForm = new WaitForm1();

        public frmMain()
        {
            InitializeComponent();

            _httpClient = new HttpClient();

            
        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private async void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Gửi yêu cầu xác thực sử dụng token đã lưu đến API
                StringContent content = new StringContent("", Encoding.UTF8, "application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", savedToken);
                HttpResponseMessage response = await _httpClient.PostAsync(cf.api + "/logout/", content);
                this.Hide();
                frmLogin f = new frmLogin();
                f.ShowDialog();

            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi HTTP nếu cần
                XtraMessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmProfile));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmProfile f = new frmProfile();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        

        private void btnCongtacvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmCollaborators));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCollaborators f = new frmCollaborators();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnqlDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmService));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmService f = new frmService();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnqlThoiluong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmTime));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTime f = new frmTime();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmStaff));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmStaff f = new frmStaff();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}