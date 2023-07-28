

using QLBH.DataLibrary.BusinessObject;
using QLBH.DataLibrary.Repository;

namespace QLBH.GUI
{
    public partial class frmLogin : Form
    {
        public INguoiDungRepository NguoiDungRepository { get; set; }
        INguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                //if(string.IsNullOrEmpty(txtTenDangNhap.Text))
                //{
                    
                //}
               var nguoiDung = GetNguoiDungObject();
               var user  = nguoiDungRepository.GetNguoiDungLogin(nguoiDung.TenDangNhap,nguoiDung.MatKhau);
                if (user != null)
                {
                    this.Visible = false;
                    if(MessageBox.Show("Bạn đã đăng nhập thành công ", "Thông Tin") == DialogResult.OK)
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                    }
                 
                }
                else
                {
                    MessageBox.Show("Bạn đã đăng nhập thất bại", "Thông tin");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private NguoiDung GetNguoiDungObject()
        {
            NguoiDung nguoiDung = null;
            try
            {
                nguoiDung = new NguoiDung()
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text
                };
            }
            catch (Exception ex)
            {
            throw new  Exception(ex.Message);

            }
            return nguoiDung;
        }
    }
}