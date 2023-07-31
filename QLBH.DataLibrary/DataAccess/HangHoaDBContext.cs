using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.DataAccess;
using Microsoft.Data.SqlClient;
using QLBH.DataLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DataLibrary.DataAccess
{
    public class HangHoaDBContext : BaseDAL
    {
        private static HangHoaDBContext instance ;
        private static readonly object instanceLock = new object();
        public HangHoaDBContext() { }
        public static HangHoaDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HangHoaDBContext();
                    }
                    return instance;
                }
            }
        }
        ////
        public IEnumerable<HangHoa> GetHangHoaByKeyword(string keyword)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from HangHoa where TenHangHoa like @TenHangHoa or GhiChu like @GhiChu ";
            var parameters = new List<SqlParameter>();
            var hangHoas = new List<HangHoa>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenHanHoa", 200, "%" + keyword + "%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, "%" + keyword + "%", DbType.String));
            
                dataReader = dataProvider.GetDataAdapter(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    hangHoas.Add(new HangHoa
                    {
                        MaHangHoa = dataReader.GetInt32(0),
                        TenHangHoa = dataReader.GetString(1),
                        SoLuong = dataReader.GetInt32(2),
                        DonGiaNhap = dataReader.GetDecimal(3),
                        DonGiaBan = dataReader.GetDecimal(4),
                        Anh = dataReader.GetString(5),
                        GhiChu = dataReader.GetString(6) 
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                dataReader.Close();
                CloseConnection();

            }
            return hangHoas;
        }
        //////
        ///
        public IEnumerable<HangHoa> GetHangHoaList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from HangHoa";
            var hangHoa = new List<HangHoa>();
            try
            {
                dataReader = dataProvider.GetDataAdapter(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    hangHoa.Add(new HangHoa
                    {
                        MaHangHoa = dataReader.GetInt32(0),
                        TenHangHoa = dataReader.GetString(1),
                        SoLuong = dataReader.GetInt32(2),
                        DonGiaNhap = dataReader.GetDecimal(3),
                        DonGiaBan = dataReader.GetDecimal(4),
                        Anh = dataReader.GetString(5),
                        GhiChu = dataReader.GetString(6)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return hangHoa;
        }
        ////--- get car byID
        public HangHoa GetHangHoaByID(int hangHoaID)
        {
            HangHoa hh = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from HangHoa where MaHangHoa = @MaHangHoa";
            try
            {
                var param = dataProvider.CreateParameter("@MaHangHoa", 4, hangHoaID, DbType.Int32);
                dataReader = dataProvider.GetDataAdapter(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    hh = new HangHoa
                    {
                        MaHangHoa = dataReader.GetInt32(0),
                        TenHangHoa = dataReader.GetString(1),
                        SoLuong = dataReader.GetInt32(2),
                        DonGiaNhap = dataReader.GetDecimal(3),
                        DonGiaBan = dataReader.GetDecimal(4),
                        Anh = dataReader.GetString(5),
                        GhiChu = dataReader.GetString(6)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return hh;
        }
        ///------- addd new
        public void AddNew(HangHoa hh)
        {
            try
            {
                HangHoa h = GetHangHoaByID(hh.MaHangHoa);
                if (h == null)
                {
                    string SQLInsert = "Insert INTO HangHoa(TenHangHoa, SoLuong, DonGiaNhap ,DonGiaBan, Anh , GhiChu) values(@TenHangHoa,@SoLuong,@DonGiaNhap,@DonGiaBan,@Anh,@GhiChu)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenHangHoa", 200, hh.TenHangHoa, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@SoLuong", 10, hh.SoLuong, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaNhap", 10, hh.DonGiaNhap, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaBan", 10, hh.DonGiaBan, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Anh", 50, hh.Anh, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, hh.GhiChu, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }   
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
        ///// update
        public void Update(HangHoa hh)
        {
            try
            {
                HangHoa h = GetHangHoaByID(hh.MaHangHoa);
                if (h != null)
                {
                    string SQLUpdate = "Update HangHoa set TenHangHoa=@TenHangHoa ,SoLuong=@SoLuong,DonGiaNhap= @DonGiaNhap DonGiaBan=@DonGiaBan ,Anh=@Anh,GhiChu= @GhiChu where MaHangHoa = @MaHangHoa)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaHangHoa", 4, hh.MaHangHoa, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@TenHangHoa", 200, hh.TenHangHoa, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@SoLuong", 4, hh.SoLuong, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaNhap", 10, hh.DonGiaNhap, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@DonGiaBan", 10, hh.DonGiaBan, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@Anh", 50, hh.Anh, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GhiChu", 500, hh.GhiChu, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }    
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
        ///remove 
        public void Delete(int hangHoaID)
        {
            try
            {
                HangHoa hh = GetHangHoaByID(hangHoaID);
                if (hh != null)
                {
                    string SQLDelete = "Delete HangHoa  where MaHangHoa = @MaHangHoa)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, hangHoaID, DbType.Int32));
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }   
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }//end remove 
}
}
