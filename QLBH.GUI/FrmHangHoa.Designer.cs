namespace QLBH.GUI
{
    partial class frmHangHoa
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
            this.btnTimKiemHH = new System.Windows.Forms.Button();
            this.txtTimKiemHh = new System.Windows.Forms.TextBox();
            this.lbMaHangHoa = new System.Windows.Forms.Label();
            this.lbDanhmucHH = new System.Windows.Forms.Label();
            this.btnDongHangHoa = new System.Windows.Forms.Button();
            this.btnSuaHangHoa = new System.Windows.Forms.Button();
            this.btnXoaHangHoa = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiemHH
            // 
            this.btnTimKiemHH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiemHH.Location = new System.Drawing.Point(603, 119);
            this.btnTimKiemHH.Name = "btnTimKiemHH";
            this.btnTimKiemHH.Size = new System.Drawing.Size(115, 32);
            this.btnTimKiemHH.TabIndex = 26;
            this.btnTimKiemHH.Text = "Tìm Kiếm";
            this.btnTimKiemHH.UseVisualStyleBackColor = true;
            this.btnTimKiemHH.Click += new System.EventHandler(this.btnTimKiemHH_Click);
            // 
            // txtTimKiemHh
            // 
            this.txtTimKiemHh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiemHh.Location = new System.Drawing.Point(258, 121);
            this.txtTimKiemHh.Name = "txtTimKiemHh";
            this.txtTimKiemHh.Size = new System.Drawing.Size(312, 30);
            this.txtTimKiemHh.TabIndex = 25;
            this.txtTimKiemHh.TextChanged += new System.EventHandler(this.txtTimKiemHh_TextChanged);
            // 
            // lbMaHangHoa
            // 
            this.lbMaHangHoa.AutoSize = true;
            this.lbMaHangHoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaHangHoa.Location = new System.Drawing.Point(79, 124);
            this.lbMaHangHoa.Name = "lbMaHangHoa";
            this.lbMaHangHoa.Size = new System.Drawing.Size(174, 23);
            this.lbMaHangHoa.TabIndex = 24;
            this.lbMaHangHoa.Text = "Từ khóa cần tìm kiếm";
            // 
            // lbDanhmucHH
            // 
            this.lbDanhmucHH.AutoSize = true;
            this.lbDanhmucHH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDanhmucHH.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmucHH.ForeColor = System.Drawing.Color.Black;
            this.lbDanhmucHH.Location = new System.Drawing.Point(264, 30);
            this.lbDanhmucHH.Name = "lbDanhmucHH";
            this.lbDanhmucHH.Size = new System.Drawing.Size(282, 38);
            this.lbDanhmucHH.TabIndex = 23;
            this.lbDanhmucHH.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // btnDongHangHoa
            // 
            this.btnDongHangHoa.Location = new System.Drawing.Point(624, 490);
            this.btnDongHangHoa.Name = "btnDongHangHoa";
            this.btnDongHangHoa.Size = new System.Drawing.Size(94, 36);
            this.btnDongHangHoa.TabIndex = 22;
            this.btnDongHangHoa.Text = "Đóng";
            this.btnDongHangHoa.UseVisualStyleBackColor = true;
            this.btnDongHangHoa.Click += new System.EventHandler(this.btnDongHangHoa_Click);
            // 
            // btnSuaHangHoa
            // 
            this.btnSuaHangHoa.Location = new System.Drawing.Point(280, 490);
            this.btnSuaHangHoa.Name = "btnSuaHangHoa";
            this.btnSuaHangHoa.Size = new System.Drawing.Size(94, 36);
            this.btnSuaHangHoa.TabIndex = 21;
            this.btnSuaHangHoa.Text = "Chỉnh sửa";
            this.btnSuaHangHoa.UseVisualStyleBackColor = true;
            this.btnSuaHangHoa.Click += new System.EventHandler(this.btnSuaHangHoa_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.Location = new System.Drawing.Point(463, 490);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(94, 36);
            this.btnXoaHangHoa.TabIndex = 20;
            this.btnXoaHangHoa.Text = "Xóa";
            this.btnXoaHangHoa.UseVisualStyleBackColor = true;
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.Location = new System.Drawing.Point(79, 490);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(94, 36);
            this.btnThemHangHoa.TabIndex = 19;
            this.btnThemHangHoa.Text = "Thêm mới";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(79, 181);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 29;
            this.dgvHangHoa.Size = new System.Drawing.Size(639, 289);
            this.dgvHangHoa.TabIndex = 18;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            this.dgvHangHoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellDoubleClick);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.btnTimKiemHH);
            this.Controls.Add(this.txtTimKiemHh);
            this.Controls.Add(this.lbMaHangHoa);
            this.Controls.Add(this.lbDanhmucHH);
            this.Controls.Add(this.btnDongHangHoa);
            this.Controls.Add(this.btnSuaHangHoa);
            this.Controls.Add(this.btnXoaHangHoa);
            this.Controls.Add(this.btnThemHangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTimKiemHH;
        private TextBox txtTimKiemHh;
        private Label lbMaHangHoa;
        private Label lbDanhmucHH;
        private Button btnDongHangHoa;
        private Button btnSuaHangHoa;
        private Button btnXoaHangHoa;
        private Button btnThemHangHoa;
        private DataGridView dgvHangHoa;
    }
}