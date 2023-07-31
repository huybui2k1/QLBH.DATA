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
    public partial class frmKhachHangUpdate : Form
    {
        public IKhachHangRepository KhachHangRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // false : Insert , True : Update
        public KhachHang KhachHangInfo { get; set; }
     
        public frmKhachHangUpdate()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHangUpdate_Load(object sender, EventArgs e)
        {
            if(InsertOrUpdate == true )
            {
                txtMakhachhang.Text = KhachHangInfo.MaKhachHang.ToString();
                txtTenkhachhang.Text = KhachHangInfo.TenKhachHang.ToString();
                txtDiachi.Text = KhachHangInfo.DiaChi.ToString();
                txtDienThoai.Text = KhachHangInfo.DienThoai.ToString();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHang
                {
                    MaKhachHang = Convert.ToInt32(txtMakhachhang.Text == "" ? 0: txtMakhachhang.Text),
                    TenKhachHang = txtTenkhachhang.Text,
                    DiaChi = txtDiachi.Text,
                    DienThoai = txtDienThoai.Text                
                };
                if (InsertOrUpdate == false)
                {
                    KhachHangRepository.InsertKhachHang(kh);

                    if(MessageBox.Show("Bạn đã tạo mới thành công!" , "Thông tin") ==DialogResult.OK)
                    {
                        this.Visible = false;
                        ((FrmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }
                else
                {
                    KhachHangRepository.UpdateKhachHang(kh);

                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((FrmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
