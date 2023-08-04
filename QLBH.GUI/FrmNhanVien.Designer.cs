namespace QLBH.GUI
{
    partial class frmNhanVien
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
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.txtQLNV = new System.Windows.Forms.TextBox();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbQuanLyNV = new System.Windows.Forms.Label();
            this.btnDongNV = new System.Windows.Forms.Button();
            this.btnChinhSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemNV.Location = new System.Drawing.Point(609, 107);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(115, 32);
            this.btnTimKiemNV.TabIndex = 26;
            this.btnTimKiemNV.Text = "Tìm Kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = true;
            // 
            // txtQLNV
            // 
            this.txtQLNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQLNV.Location = new System.Drawing.Point(264, 109);
            this.txtQLNV.Name = "txtQLNV";
            this.txtQLNV.Size = new System.Drawing.Size(312, 30);
            this.txtQLNV.TabIndex = 25;
            this.txtQLNV.TextChanged += new System.EventHandler(this.txtQLNV_TextChanged);
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaNhanVien.Location = new System.Drawing.Point(85, 112);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(174, 23);
            this.lbMaNhanVien.TabIndex = 24;
            this.lbMaNhanVien.Text = "Từ khóa cần tìm kiếm";
            // 
            // lbQuanLyNV
            // 
            this.lbQuanLyNV.AutoSize = true;
            this.lbQuanLyNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbQuanLyNV.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuanLyNV.ForeColor = System.Drawing.Color.Black;
            this.lbQuanLyNV.Location = new System.Drawing.Point(270, 18);
            this.lbQuanLyNV.Name = "lbQuanLyNV";
            this.lbQuanLyNV.Size = new System.Drawing.Size(285, 38);
            this.lbQuanLyNV.TabIndex = 23;
            this.lbQuanLyNV.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnDongNV
            // 
            this.btnDongNV.Location = new System.Drawing.Point(630, 478);
            this.btnDongNV.Name = "btnDongNV";
            this.btnDongNV.Size = new System.Drawing.Size(94, 36);
            this.btnDongNV.TabIndex = 22;
            this.btnDongNV.Text = "Đóng";
            this.btnDongNV.UseVisualStyleBackColor = true;
            this.btnDongNV.Click += new System.EventHandler(this.btnDongNV_Click);
            // 
            // btnChinhSuaNV
            // 
            this.btnChinhSuaNV.Location = new System.Drawing.Point(286, 478);
            this.btnChinhSuaNV.Name = "btnChinhSuaNV";
            this.btnChinhSuaNV.Size = new System.Drawing.Size(94, 36);
            this.btnChinhSuaNV.TabIndex = 21;
            this.btnChinhSuaNV.Text = "Chỉnh sửa";
            this.btnChinhSuaNV.UseVisualStyleBackColor = true;
            this.btnChinhSuaNV.Click += new System.EventHandler(this.btnChinhSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(469, 478);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(94, 36);
            this.btnXoaNV.TabIndex = 20;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(85, 478);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(94, 36);
            this.btnThemNV.TabIndex = 19;
            this.btnThemNV.Text = "Thêm mới";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(85, 169);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 29;
            this.dgvNhanVien.Size = new System.Drawing.Size(639, 289);
            this.dgvNhanVien.TabIndex = 18;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellDoubleClick);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnTimKiemNV);
            this.Controls.Add(this.txtQLNV);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.lbQuanLyNV);
            this.Controls.Add(this.btnDongNV);
            this.Controls.Add(this.btnChinhSuaNV);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTimKiemNV;
        private TextBox txtQLNV;
        private Label lbMaNhanVien;
        private Label lbQuanLyNV;
        private Button btnDongNV;
        private Button btnChinhSuaNV;
        private Button btnXoaNV;
        private Button btnThemNV;
        private DataGridView dgvNhanVien;
    }
}