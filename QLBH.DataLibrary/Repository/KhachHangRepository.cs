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
    public class KhachHangRepository  : IKhachHangRepository
    {
        public IEnumerable<KhachHang> GetKhachHangList() => KhachHangDBContext.Instance.GetKhachHangList();
        public  IEnumerable<KhachHang> GetKhachHangByKeyword(string keyword) => KhachHangDBContext.Instance.GetKhachHangByKeyword(keyword); 
        public KhachHang GetKhachHangByID(int khachHangId) => KhachHangDBContext.Instance.GetKhachHangByID(khachHangId);
       
        public void InsertKhachHang(KhachHang khachHang) => KhachHangDBContext.Instance.AddNew(khachHang);
        public void DeleteKhachHang(int khachHangId) => KhachHangDBContext.Instance.Remove(khachHangId);

        public void UpdateKhachHang(KhachHang khachHang) => KhachHangDBContext.Instance.Update(khachHang);

       
    }
}
