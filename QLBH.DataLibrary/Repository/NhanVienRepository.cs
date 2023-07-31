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
    public class NhanVienRepository : INhanVienRepository
    {
        public IEnumerable<NhanVien> GetNhanViens() => NhanVienDBContext.Instance.GetNhanVienList();
        public  IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword) => NhanVienDBContext.Instance.GetNhanVienByKeyword(keyword); 
        public NhanVien GetNhanVienByID(int MaNhanVien) => NhanVienDBContext.Instance.GetNhanVienByID(MaNhanVien);
       
        public void InsertNhanVien(NhanVien nhanVien) => NhanVienDBContext.Instance.AddNew(nhanVien);
        public void DeleteNhanVien(int MaNhanVien) => NhanVienDBContext.Instance.Remove(MaNhanVien);

        public void UpdateNhanVien(NhanVien nhanVien) => NhanVienDBContext.Instance.Update(nhanVien);

       
    }
}
