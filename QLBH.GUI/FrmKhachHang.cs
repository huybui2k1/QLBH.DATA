using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;
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
    public partial class FrmKhachHang : Form
    {
        IKhachHangRepository khachHangRepository = new KhachHangRepository();
        //Create a data source
        BindingSource source;
        KhachHang kh;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangList();
        }

        public void LoadKhachHangList()
        {
            var khachHangs = khachHangRepository.GetKhachHangList();
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
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

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                btnChinhSua_Click(sender, e);
                
            //frmKhachHangUpdate frmkhachHangUpdate = new frmKhachHangUpdate
            //{
            //    Text = "Add Khach Hang",
            //    InsertOrUpdate = true,
            //    KhachHangInfo = GetKhachHangObject(),
            //    KhachHangRepository = khachHangRepository 
            //};
            //if (frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            //{
            //    LoadKhachHangList();
            //    //Set focus car inserted 
            //    source.Position = source.Count - 1;

            //}
        }
        //private KhachHang GetKhachHangObject()
        //{

        //    KhachHang kh  = null;
        //    try
        //    {
        //        kh = new KhachHang
        //        {
        //            MaKhachHang = Convert.ToInt32(lbMaKhachHang.Text),
                   
                   
        //        };

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Get Car");

        //    }
        //    return kh;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var khachHangs = khachHangRepository.GetKhachHangByKeyword(textBox1.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;



                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
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

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate
            {
                Text = "Cập nhật khách hàng",
                InsertOrUpdate = true,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if(frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count- 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                khachHangRepository.DeleteKhachHang(kh.MaKhachHang);
                LoadKhachHangList();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate() {
                Text = "Cập nhật khách hàng",
                InsertOrUpdate = false,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if(frmKhachHangUpdate.ShowDialog() ==DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count- 1;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count - 1)
            /// kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                kh = new KhachHang()
                {
                    MaKhachHang = Convert.ToInt32(row.Cells[0].Value),
                    TenKhachHang = row.Cells[1].Value.ToString(),
                    DiaChi = row.Cells[2].Value.ToString(),
                    DienThoai = row.Cells[3].Value.ToString()
                };
            }
        }
    }
}
