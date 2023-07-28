namespace QLBH.GUI
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tệpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tệpTinToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tệpTinToolStripMenuItem
            // 
            this.tệpTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DangNhap,
            this.mnu_Thoat});
            this.tệpTinToolStripMenuItem.Name = "tệpTinToolStripMenuItem";
            this.tệpTinToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.tệpTinToolStripMenuItem.Text = "Tệp tin";
            // 
            // mnu_DangNhap
            // 
            this.mnu_DangNhap.Name = "mnu_DangNhap";
            this.mnu_DangNhap.Size = new System.Drawing.Size(165, 26);
            this.mnu_DangNhap.Text = "Đăng nhập";
            this.mnu_DangNhap.Click += new System.EventHandler(this.mnu_DangNhap_Click);
            // 
            // mnu_Thoat
            // 
            this.mnu_Thoat.Name = "mnu_Thoat";
            this.mnu_Thoat.Size = new System.Drawing.Size(165, 26);
            this.mnu_Thoat.Text = "Thoát";
            this.mnu_Thoat.Click += new System.EventHandler(this.mnu_Thoat_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_KhachHang,
            this.mnu_NhanVien,
            this.mnu_HangHoa});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnu_KhachHang.Text = "QL Khách Hàng";
            this.mnu_KhachHang.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // mnu_NhanVien
            // 
            this.mnu_NhanVien.Name = "mnu_NhanVien";
            this.mnu_NhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnu_NhanVien.Text = "QL Nhân viên ";
            this.mnu_NhanVien.Click += new System.EventHandler(this.mnu_NhanVien_Click);
            // 
            // mnu_HangHoa
            // 
            this.mnu_HangHoa.Name = "mnu_HangHoa";
            this.mnu_HangHoa.Size = new System.Drawing.Size(224, 26);
            this.mnu_HangHoa.Text = "QL Hàng Hóa";
            this.mnu_HangHoa.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpTinToolStripMenuItem;
        private ToolStripMenuItem mnu_DangNhap;
        private ToolStripMenuItem mnu_Thoat;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mnu_KhachHang;
        private ToolStripMenuItem mnu_NhanVien;
        private ToolStripMenuItem mnu_HangHoa;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
    }
}