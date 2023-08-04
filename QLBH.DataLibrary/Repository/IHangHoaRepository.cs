using AutomobileLibrary.BussinessObject;
using QLBH.DataLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.Repository
{
    public  interface IHangHoaRepository
    {
        IEnumerable<HangHoa> GetHangHoas();
       
        IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword);
        HangHoa GetHangHoaByID(int hangHoaID);
        void InsertHangHoa(HangHoa hangHoa);
       
        void UpdateHangHoa(HangHoa hangHoa);
        void DeleteHangHoa(int hangHoaID);
    }
}
