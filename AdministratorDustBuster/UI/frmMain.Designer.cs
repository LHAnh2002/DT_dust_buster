namespace AdministratorDustBuster.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btndangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnthoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btngoimon = new DevExpress.XtraBars.BarButtonItem();
            this.btnthanhtoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnCongtacvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnqlDichVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnqlThoiluong = new DevExpress.XtraBars.BarButtonItem();
            this.btn = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.rbTrangchu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.qlban = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpDichvu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDoitac = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.skinPaletteDropDownButtonItem2 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem3 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnNhanvien = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btndangxuat,
            this.btnUser,
            this.barButtonItem1,
            this.btnthoat,
            this.barButtonItem3,
            this.btngoimon,
            this.btnthanhtoan,
            this.btnCongtacvien,
            this.btnqlDichVu,
            this.btnqlThoiluong,
            this.btn,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinPaletteRibbonGalleryBarItem2,
            this.skinPaletteDropDownButtonItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem2,
            this.skinPaletteRibbonGalleryBarItem3,
            this.skinDropDownButtonItem2,
            this.btnNhanvien});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbTrangchu,
            this.qlban,
            this.rbDoitac});
            this.ribbon.Size = new System.Drawing.Size(1198, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btndangxuat
            // 
            this.btndangxuat.Caption = "Đăng xuất";
            this.btndangxuat.Id = 1;
            this.btndangxuat.ImageOptions.Image = global::AdministratorDustBuster.Properties.Resources.icons8_logout_50;
            this.btndangxuat.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.icons8_logout_50;
            this.btndangxuat.LargeWidth = 70;
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndangxuat_ItemClick);
            // 
            // btnUser
            // 
            this.btnUser.Caption = "Người dùng";
            this.btnUser.Id = 2;
            this.btnUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUser.ImageOptions.LargeImage")));
            this.btnUser.LargeWidth = 70;
            this.btnUser.Name = "btnUser";
            this.btnUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUser_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnthoat
            // 
            this.btnthoat.Caption = "Thoát";
            this.btnthoat.Id = 4;
            this.btnthoat.ImageOptions.Image = global::AdministratorDustBuster.Properties.Resources.delete_16x16;
            this.btnthoat.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.delete_32x32;
            this.btnthoat.LargeWidth = 70;
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthoat_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btngoimon
            // 
            this.btngoimon.Caption = "Gọi món";
            this.btngoimon.Id = 6;
            this.btngoimon.ImageOptions.Image = global::AdministratorDustBuster.Properties.Resources.clip_16x16;
            this.btngoimon.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.icons8_order_64;
            this.btngoimon.LargeWidth = 70;
            this.btngoimon.Name = "btngoimon";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Caption = "Thanh toán";
            this.btnthanhtoan.Id = 8;
            this.btnthanhtoan.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.icons8_pay_80;
            this.btnthanhtoan.LargeWidth = 70;
            this.btnthanhtoan.Name = "btnthanhtoan";
            // 
            // btnCongtacvien
            // 
            this.btnCongtacvien.Caption = "Cộng tác viên";
            this.btnCongtacvien.Id = 9;
            this.btnCongtacvien.ImageOptions.Image = global::AdministratorDustBuster.Properties.Resources.employee_16x16;
            this.btnCongtacvien.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.employee_32x32;
            this.btnCongtacvien.LargeWidth = 70;
            this.btnCongtacvien.Name = "btnCongtacvien";
            this.btnCongtacvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCongtacvien_ItemClick);
            // 
            // btnqlDichVu
            // 
            this.btnqlDichVu.Caption = "Dịch Vụ";
            this.btnqlDichVu.Id = 12;
            this.btnqlDichVu.ImageOptions.LargeImage = global::AdministratorDustBuster.Properties.Resources.icons8_sweep_60;
            this.btnqlDichVu.LargeWidth = 70;
            this.btnqlDichVu.Name = "btnqlDichVu";
            this.btnqlDichVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnqlDichVu_ItemClick);
            // 
            // btnqlThoiluong
            // 
            this.btnqlThoiluong.Caption = "Thười Lượng";
            this.btnqlThoiluong.Id = 13;
            this.btnqlThoiluong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnqlThoiluong.ImageOptions.LargeImage")));
            this.btnqlThoiluong.LargeWidth = 70;
            this.btnqlThoiluong.Name = "btnqlThoiluong";
            this.btnqlThoiluong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnqlThoiluong_ItemClick);
            // 
            // btn
            // 
            this.btn.Caption = "barButtonItem2";
            this.btn.Id = 14;
            this.btn.Name = "btn";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group1";
            this.skinPaletteRibbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.skinPaletteRibbonGalleryBarItem1.Id = 18;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinPaletteRibbonGalleryBarItem2
            // 
            this.skinPaletteRibbonGalleryBarItem2.Caption = "skinPaletteRibbonGalleryBarItem2";
            this.skinPaletteRibbonGalleryBarItem2.Id = 19;
            this.skinPaletteRibbonGalleryBarItem2.Name = "skinPaletteRibbonGalleryBarItem2";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 20;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 21;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // rbTrangchu
            // 
            this.rbTrangchu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.rbTrangchu.Name = "rbTrangchu";
            this.rbTrangchu.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btndangxuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanvien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "User";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.Image = global::AdministratorDustBuster.Properties.Resources.icons8_order_64;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCongtacvien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btngoimon);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnthanhtoan);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.skinDropDownButtonItem2);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnthoat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tiện Ích";
            // 
            // qlban
            // 
            this.qlban.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpDichvu,
            this.ribbonPageGroup4});
            this.qlban.Name = "qlban";
            this.qlban.Text = "Tác Vụ";
            // 
            // rbpDichvu
            // 
            this.rbpDichvu.ItemLinks.Add(this.btnqlDichVu);
            this.rbpDichvu.ItemLinks.Add(this.btnqlThoiluong);
            this.rbpDichvu.Name = "rbpDichvu";
            this.rbpDichvu.Text = "Dịch Vụ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbDoitac
            // 
            this.rbDoitac.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.rbDoitac.Name = "rbDoitac";
            this.rbDoitac.Text = "Đối tác";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 589);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1198, 24);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Gọi món";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.LargeWidth = 70;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // skinPaletteDropDownButtonItem2
            // 
            this.skinPaletteDropDownButtonItem2.Id = 22;
            this.skinPaletteDropDownButtonItem2.Name = "skinPaletteDropDownButtonItem2";
            // 
            // skinPaletteRibbonGalleryBarItem3
            // 
            this.skinPaletteRibbonGalleryBarItem3.Caption = "skinPaletteRibbonGalleryBarItem3";
            this.skinPaletteRibbonGalleryBarItem3.Id = 23;
            this.skinPaletteRibbonGalleryBarItem3.Name = "skinPaletteRibbonGalleryBarItem3";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 24;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Caption = "Nhân Viên";
            this.btnNhanvien.Id = 25;
            this.btnNhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.ImageOptions.LargeImage")));
            this.btnNhanvien.LargeWidth = 70;
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanvien_ItemClick);
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1198, 613);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbTrangchu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btndangxuat;
        private DevExpress.XtraBars.BarButtonItem btnUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnthoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage qlban;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpDichvu;
        private DevExpress.XtraBars.BarButtonItem btngoimon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnthanhtoan;
        private DevExpress.XtraBars.BarButtonItem btnCongtacvien;
        private DevExpress.XtraBars.BarButtonItem btnqlDichVu;
        private DevExpress.XtraBars.BarButtonItem btnqlThoiluong;
        private DevExpress.XtraBars.BarButtonItem btn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDoitac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem2;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem2;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem3;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNhanvien;
    }
}