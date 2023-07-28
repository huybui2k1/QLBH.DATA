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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm_KH = new FrmKhachHang();
          frm_KH.MdiParent= this;
            frm_KH.Show();
        }
        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm_nv = new FrmNhanVien();
            frm_nv.MdiParent= this;
            frm_nv.Show();
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frm_login = new frmLogin();
            frm_login.MdiParent= this;
            frm_login.Show();
        }
    }
}
