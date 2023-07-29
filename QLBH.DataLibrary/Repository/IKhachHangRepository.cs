using AutomobileLibrary.BussinessObject;
using QLBH.DataLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.Repository
{
    public  interface IKhachHangRepository
    {
        IEnumerable<KhachHang> GetKhachHang();
        KhachHang GetKhachHangByID(int khachHangId);
        void InsertKhachHang(KhachHang khachHang);
       
        void UpdateKhachHangr(KhachHang khachHang);
        void DeleteKhachHang(int khachHangId);
    }
}
