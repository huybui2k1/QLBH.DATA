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

namespace QLBH.GUI
{
    public partial class frmHangHoa : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        HangHoa hh;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
        }

        private void txtTimKiemHh_TextChanged(object sender, EventArgs e)
        {
            var hangHoas = hangHoaRepository.GetHangHoaByKeyword(txtTimKiemHh.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if(hangHoas.Count() == 0 )
                {
                    btnXoaHangHoa.Enabled = false;
                    btnSuaHangHoa.Enabled = false;
                }
                else
                {
                    btnXoaHangHoa.Enabled = true;
                    btnSuaHangHoa.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.AutoGenerateColumns = false;
                dgvHangHoa.Columns.Clear();  // Xóa tất cả các cột hiện có trên DataGridView
                // Thêm cột ID và Tên vào DataGridView
                var maHangHoa = new DataGridViewTextBoxColumn();
                maHangHoa.DataPropertyName = "MaHangHoa";
                maHangHoa.HeaderText = "Mã Hàng hoá";
                dgvHangHoa.Columns.Add(maHangHoa);

                var tenHangHoa = new DataGridViewTextBoxColumn();
                tenHangHoa.DataPropertyName = "TenHangHoa";
                tenHangHoa.HeaderText = "Tên Hàng hoá";
                dgvHangHoa.Columns.Add(tenHangHoa);

                var soLuong = new DataGridViewTextBoxColumn();
                soLuong.DataPropertyName = "SoLuong";
                soLuong.HeaderText = "Số lượng";
                dgvHangHoa.Columns.Add(soLuong);

                var donGiaNhap = new DataGridViewTextBoxColumn();
                donGiaNhap.DataPropertyName = "DonGiaNhap";
                donGiaNhap.HeaderText = "Đơn giá nhập";
                dgvHangHoa.Columns.Add(donGiaNhap);

                var donGiaBan = new DataGridViewTextBoxColumn();
                donGiaBan.DataPropertyName = "DonGiaBan";
                donGiaBan.HeaderText = "Đơn giá bán";
                dgvHangHoa.Columns.Add(donGiaBan);
                // Ẩn cột Ảnh
                //dgvHangHoa.Columns[5].Visible = false;
                dgvHangHoa.DataSource = source;


                if (hangHoas.Count() == 0)
                {
                    btnXoaHangHoa.Enabled = false;
                    btnSuaHangHoa.Enabled = false;
                }
                else
                {
                    btnXoaHangHoa.Enabled = true;
                    btnSuaHangHoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnTimKiemHH_Click(object sender, EventArgs e)
        {
            txtTimKiemHh_TextChanged(sender, e);
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật hàng hoa",
                InsertOrUpdate = false,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }
              
        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
                InsertOrUpdate = true,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                hangHoaRepository.DeleteHangHoa(hh.MaHangHoa);
                LoadHangHoaList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnDongHangHoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                var hangHoa = hangHoaRepository.GetHangHoaByID(Convert.ToInt32(row.Cells[0].Value));
                hh = new HangHoa()
                {
                    MaHangHoa = hangHoa.MaHangHoa,
                    TenHangHoa = hangHoa.TenHangHoa,
                    SoLuong = hangHoa.SoLuong,
                    DonGiaNhap = hangHoa.DonGiaNhap,
                    DonGiaBan = hangHoa.DonGiaBan,
                    Anh = hangHoa.Anh,
                    GhiChu = hangHoa.GhiChu
                };
            }
        }

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaHangHoa_Click(sender, e);
        }
    }
}
