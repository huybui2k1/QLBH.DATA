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
    public partial class FrmHangHoa : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        HangHoa hh;
        public FrmHangHoa()
        {
            InitializeComponent();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            var hangHoas = hangHoaRepository.GetHangHoaByKeyword(txtTimkiem.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvData.DataSource = null;
                dgvData.DataSource = source;
                if(hangHoas.Count() == 0 )
                {
                    btnXoa.Enabled =false;
                    btnSua.Enabled =false; 
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
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

        private void FrmHangHoa_Load_1(object sender, EventArgs e)
        {
            LoadHangHoaList();

        }
        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvData.DataSource = null;
                dgvData.AutoGenerateColumns = false;
                dgvData.Columns.Clear();

                var maHangHoa = new DataGridViewTextBoxColumn();
                maHangHoa.DataPropertyName = "MaHangHoa";
                maHangHoa.HeaderText = "Mã hàng Hóa";
                dgvData.Columns.Add(maHangHoa);

                var tenHangHoa = new DataGridViewTextBoxColumn();
                tenHangHoa.DataPropertyName = "TenHangHoa";
                tenHangHoa.HeaderText = "Tên Hàng hoá";
                dgvData.Columns.Add(tenHangHoa);

                var soLuong = new DataGridViewTextBoxColumn();
                soLuong.DataPropertyName = "SoLuong";
                soLuong.HeaderText = "Số lượng";
                dgvData.Columns.Add(soLuong);

                var donGiaNhap = new DataGridViewTextBoxColumn();
                donGiaNhap.DataPropertyName = "DonGiaNhap";
                donGiaNhap.HeaderText = "Đơn giá nhập";
                dgvData.Columns.Add(donGiaNhap);

                var donGiaBan = new DataGridViewTextBoxColumn();
                donGiaBan.DataPropertyName = "DonGiaBan";
                donGiaBan.HeaderText = "Đơn giá bán";
                dgvData.Columns.Add(donGiaBan);



                dgvData.DataSource = source;

                if(hangHoas.Count() == 0 )
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvData.Rows.Count - 1)
           

            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);

        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem_TextChanged(sender, e);
        }
    }
}
