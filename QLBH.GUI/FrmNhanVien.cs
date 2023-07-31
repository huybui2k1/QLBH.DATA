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
    public partial class FrmNhanVien : Form
    {
        INhanVienRepository nhanVienRepository = new NhanVienRepository();
        //Create a data source
        BindingSource source;
        NhanVien nv;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            var nhanViens = nhanVienRepository.GetNhanVienByKeyword(txtTimKiemNV.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;



                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {

                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật nhân viên",
                InsertOrUpdate = false,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository

            };
            frmNhanVienUpdate.Owner = this;
            if(frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count- 1;
            }

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật nhân viên",
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

        private void btnXoa_Click_1(object sender, EventArgs e)
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

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
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

                    btnXoa.Enabled = false;
                    btnChinhSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnChinhSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        private void dgvNhanVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSua_Click(sender, e);
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
    }
}
