using AutomobileLibrary.BussinessObject;
using QLBH.DataLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.Repository
{
    public interface INguoiDungRepository
    {
       public  NguoiDung GetNguoiDungLogin(string TenDangNhap ,string MatKhau);
    }
}
