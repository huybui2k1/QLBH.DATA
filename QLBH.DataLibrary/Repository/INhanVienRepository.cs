using AutomobileLibrary.BussinessObject;
using QLBH.DataLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.Repository
{
    public  interface INhanVienRepository
    {
        IEnumerable<NhanVien> GetNhanViens();
       
        IEnumerable<NhanVien> GetNhanVienByKeyword(string keyword);
        NhanVien GetNhanVienByID(int MaNhanVien);
        void InsertNhanVien(NhanVien nhanVien);
       
        void UpdateNhanVien(NhanVien nhanVien);
        void DeleteNhanVien(int MaNhanVien);
    }
}
