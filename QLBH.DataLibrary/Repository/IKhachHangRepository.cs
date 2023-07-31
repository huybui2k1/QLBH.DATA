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
        IEnumerable<KhachHang> GetKhachHangList();
       
        IEnumerable<KhachHang> GetKhachHangByKeyword(string keyword);
        KhachHang GetKhachHangByID(int khachHangId);
        void InsertKhachHang(KhachHang khachHang);
       
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(int khachHangId);
    }
}
