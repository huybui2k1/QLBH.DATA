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
    public class HangHoaRepository : IHangHoaRepository
    {
        public IEnumerable<HangHoa> GetHangHoas() => HangHoaDBContext.Instance.GetHangHoaList();
        public IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword) => HangHoaDBContext.Instance.GetHangHoaByKeyword(keyword);
        public HangHoa GetHangHoaByID(int hangHoaID) => HangHoaDBContext.Instance.GetHangHoaByID(hangHoaID);
       
        public void InsertHangHoa(HangHoa hh) => HangHoaDBContext.Instance.AddNew(hh);
        public void DeleteHangHoa(int hangHoaID) => HangHoaDBContext.Instance.Delete(hangHoaID);

        public void UpdateHangHoa(HangHoa hh) => HangHoaDBContext.Instance.Update(hh);

       
    }
}
