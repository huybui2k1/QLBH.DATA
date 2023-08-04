using QLBH.DataLibrary.BusinessObject;
using QLBH.DataLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH.GUI
{
    public partial class frmNhanVien : Form
    {
        INhanVienRepository nhanVienRepository = new NhanVienRepository();
        //Create a data source
        BindingSource source;
        NhanVien nv;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void LoadNhanVienList()
        {
            var nhanViens = nhanVienRepository.GetNhanViens();
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;


                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {

                    btnXoaNV.Enabled = false;
                    btnChinhSuaNV.Enabled = false;
                }
                else
                {
                    btnXoaNV.Enabled = true;
                    btnChinhSuaNV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSuaNV_Click(sender, e);
        }

        private void btnChinhSuaNV_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate
            {
                Text = "Cập nhật khách hàng",
                InsertOrUpdate = true,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void txtQLNV_TextChanged(object sender, EventArgs e)
        {
            var nhanViens = nhanVienRepository.GetNhanVienByKeyword(txtQLNV.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;



                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {

                    btnXoaNV.Enabled = false;
                    btnChinhSuaNV.Enabled = false;
                }
                else
                {
                    btnXoaNV.Enabled = true;
                    btnChinhSuaNV.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                nhanVienRepository.DeleteNhanVien(nv.MaNhanVien);
                LoadNhanVienList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật khách hàng",
                InsertOrUpdate = false,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDongNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count - 1)
            /// kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                nv = new NhanVien()
                {
                    MaNhanVien = Convert.ToInt32(row.Cells[0].Value),
                    TenNhanVien = row.Cells[1].Value.ToString(),
                    DiaChi = row.Cells[2].Value.ToString(),
                    DienThoai = row.Cells[3].Value.ToString(),
                    GioiTinh = Convert.ToBoolean(row.Cells[4].Value.ToString()),
                    NgaySinh = Convert.ToDateTime(row.Cells[5].Value.ToString())
                };
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }
    }
}
