using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using QLBH.DataLibrary.BusinessObject;
using QLBH.DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.Repository
{
    public class NguoiDungRepository : INguoiDungRepository
    {
        public NguoiDung GetNguoiDungLogin(string TenDangNhap ,string MatKhau) => NguoiDungDBContext.Instance.GetInfo(TenDangNhap,MatKhau);
    }
}
