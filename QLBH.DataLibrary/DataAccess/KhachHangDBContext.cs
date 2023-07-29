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
    public class KhachHangDBContext : BaseDAL
    {
        private static KhachHangDBContext instance = null;
        private static readonly object instanceLock = new object();
        public KhachHangDBContext() { }
        public static KhachHangDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new KhachHangDBContext();
                    }
                    return instance;
                }
            }
        }
        //////
        ///
        public IEnumerable<KhachHang> GetKhachHangList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MaKhachHang , TenKhachHang ,DiaChi , DienThoai from KhachHang";
            var khachHang = new List<KhachHang>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    khachHang.Add(new KhachHang
                    {
                        MaKhachHang = dataReader.GetInt32(0),
                        TenKhachHang = dataReader.GetString(1),
                        DiaChi = dataReader.GetString(2),
                        DienThoai = dataReader.GetString(3)     
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
            return khachHang;
        }
        ////--- get car byID

        public KhachHang GetKhachHangByID(int khachHangID)
        {
            KhachHang kh = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from KhachHang where MaKhachHang = @MaKhachHang";
            try
            {
                var param = dataProvider.CreateParameter("@MaKhachHang", 4, khachHangID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    kh = new KhachHang
                    {
                        MaKhachHang = dataReader.GetInt32(0),
                        TenKhachHang = dataReader.GetString(1),
                        DiaChi = dataReader.GetString(2),
                        DienThoai = dataReader.GetString(3)
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
            return kh;
        }

        ///------- addd new
        public void AddNew(KhachHang kh)
        {
            try
            {
                KhachHang k = GetKhachHangByID(kh.MaKhachHang);
                if (k == null)
                {
                    string SQLInsert = "Insert INTO KhachHang(MaKhachHang, TenKhachHang, DiaChi ,DienThoai) values(@MaKhachHang,@TenKhachHang,@DiaChi,@DienThoai)";
                    var parameters = new List<SqlParameter>();
                  
                    parameters.Add(dataProvider.CreateParameter("@TenKhachHang", 200, kh.TenKhachHang, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, kh.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, kh.DienThoai, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The khachhang is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }

        ///// update
        public void Update(KhachHang kh)
        {
            try
            {
                KhachHang c = GetKhachHangByID(kh.MaKhachHang);
                if (c != null)
                {
                    string SQLUpdate = "Update KhachHang set TenKhachHang=@TenKhachHang ,DiaChi=@DiaChi,DienThoai= @DienThoai where MaKhachHang = @MaKhachHang)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MaKhachHang", 200, kh.MaKhachHang, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@TenKhachHang", 200, kh.TenKhachHang, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, kh.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, kh.DienThoai, DbType.Decimal));
                   
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("The khachhang does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }

        ///remove 
        public void Remove(int MaKhachHang)
        {
            try
            {
                KhachHang kh = GetKhachHangByID(MaKhachHang);
                if (kh != null)
                {
                    string SQLDelete = "Delete KhachHang  where MaKhachHang = @MaKhachHang)";
                    var param = dataProvider.CreateParameter("@CarID", 4, MaKhachHang, DbType.Int32);


                    dataProvider.Delete(SQLDelete, CommandType.Text, param);

                }
                else
                {
                    throw new Exception("The KhachHang does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }//end remove 

}
}
