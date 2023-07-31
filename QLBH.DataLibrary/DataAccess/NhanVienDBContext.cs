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
    public class NhanVienDBContext : BaseDAL
    {
        private static NhanVienDBContext instance ;
        private static readonly object instanceLock = new object();
        public NhanVienDBContext() { }
        public static NhanVienDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NhanVienDBContext();
                    }
                    return instance;
                }
            }
        }
        ////
        public IEnumerable<NhanVien> GetNhanVienByKeyword(string tuKhoa)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from NhanVien where TenNhanVien like @TenNhanVien or DiaChi like @DiaChi ";
            var parameters = new List<SqlParameter>();
            var nhanViens = new List<NhanVien>();
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, "%" + tuKhoa + "%", DbType.String));
                parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, "%" + tuKhoa + "%", DbType.String));
               // var param = dataProvider.CreateParameter("@TenKhachHang", 200, tuKhoa, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    nhanViens.Add(new NhanVien
                    {
                        MaNhanVien = dataReader.GetInt32(0),
                        TenNhanVien = dataReader.GetString(1),
                        DiaChi = dataReader.GetString(2),
                        DienThoai = dataReader.GetString(3),
                        GioiTinh = dataReader.GetBoolean(2),
                        NgaySinh = dataReader.GetDateTime(5)

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
            return nhanViens;
        }
        //////
        ///
        public IEnumerable<NhanVien> GetNhanVienList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from NhanVien";
            var nhanViens = new List<NhanVien>();
            try
            {
               
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection );
                while (dataReader.Read())
                {
                    nhanViens.Add(new NhanVien
                    {
                        MaNhanVien = dataReader.GetInt32(0),
                        TenNhanVien = dataReader.GetString(1),
                        DiaChi = dataReader.GetString(2),
                        DienThoai = dataReader.GetString(3),
                        GioiTinh = dataReader.GetBoolean(2),
                        NgaySinh = dataReader.GetDateTime(5)
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
            return nhanViens;
        }
        ////--- get Nhan vien  byMaNhanVien

        public NhanVien GetNhanVienByID(int MaNhanVien)
        {
            NhanVien nv = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from NhanVien where MaNhanVien = @MaNhanVien";
            try
            {
                var param = dataProvider.CreateParameter("@MaNhanVien", 4, MaNhanVien, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    nv = new NhanVien
                    {
                        MaNhanVien = dataReader.GetInt32(0),
                        TenNhanVien = dataReader.GetString(1),
                        DiaChi = dataReader.GetString(2),
                        DienThoai = dataReader.GetString(3),
                        GioiTinh = dataReader.GetBoolean(2),
                        NgaySinh = dataReader.GetDateTime(5)
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
            return nv;
        }
        ///------- addd new
        public void AddNew(NhanVien nv)
        {
            try
            {
                NhanVien k = GetNhanVienByID(nv.MaNhanVien);
                if (k == null)
                {
                    string SQLInsert = "Insert INTO NhanVien(MaNhanVien, TenNhanVien, DiaChi ,DienThoai ,GioiTinh , NgaySinh) values(@MaKhachHang,@TenKhachHang,@DiaChi,@DienThoai ,@GioiTinh , @NgaySinh)";
                    var parameters = new List<SqlParameter>();
                  
                    parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, nv.TenNhanVien, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, nv.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, nv.DienThoai, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GioiTinh", 200, nv.GioiTinh, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@NgaySinh", 200, nv.NgaySinh, DbType.DateTime));
                    
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }
        ///// update
        public void Update(NhanVien nv)
        {
            try
            {
                NhanVien c = GetNhanVienByID(nv.MaNhanVien);
                if (c != null)
                {
                    string SQLUpdate = "Update NhanVien set TenNhanVien=@TenNhanVien ,DiaChi=@DiaChi,DienThoai= @DienThoai where MaNhanVien = @MaNhanVien)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@TenNhanVien", 200, nv.TenNhanVien, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiaChi", 200, nv.DiaChi, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DienThoai", 50, nv.DienThoai, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@GioiTinh", 200, nv.GioiTinh, DbType.Boolean));
                    parameters.Add(dataProvider.CreateParameter("@NgaySinh", 200, nv.NgaySinh, DbType.DateTime));

                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }

        ///remove 
        public void Remove(int MaNhanVien)
        {
            try
            {
                NhanVien kh = GetNhanVienByID(MaNhanVien);
                if (kh != null)
                {
                    string SQLDelete = "Delete NhanVien  where MaNhanVien = @MaNhanVien)";
                    var param = dataProvider.CreateParameter("@MaNhanVien", 4, MaNhanVien, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }

        }//end remove 

}
}
