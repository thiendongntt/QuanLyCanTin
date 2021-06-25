using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanVienDAO : DBConnect
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }
        }

        public DataTable getNhanVien()
        {
            DataTable dtNhanvien = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDNV, TENNV, GIOITINH, NGAYSINH, DIACHI, SDT, EMAIL, TENCV, LUONGCA, HINHANHNV FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.IDCV = CV.IDCV", Con);
                da.Fill(dtNhanvien);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtNhanvien;
        }

        public bool createNhanVien(NhanVienDTO nv)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO NHANVIEN (TENNV, GIOITINH, NGAYSINH, DIACHI, SDT, EMAIL, IDCV, LUONGCA, HINHANHNV) VALUES (@TENNV, @GIOITINH, @NGAYSINH, @DIACHI, @SDT, @EMAIL, @IDCV, @LUONGCA, @HINHANHNV)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.Sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nv.Email;
                cmd.Parameters.Add("@IDCV", SqlDbType.Int).Value = nv.IdCV;
                cmd.Parameters.Add("@LUONGCA", SqlDbType.Int).Value = nv.LuongCa;
                cmd.Parameters.Add("@HINHANHNV", SqlDbType.NVarChar).Value = nv.HinhAnhNV;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Con.Close();
                return false;
            }
            Con.Close();
            return true;
        }

        public bool updateNhanVien(NhanVienDTO nv)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NHANVIEN SET TENNV=@TENNV, GIOITINH=@GIOITINH, NGAYSINH=@NGAYSINH, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL, IDCV=@IDCV, LUONGCA=@LUONGCA, HINHANHNV=@HINHANHNV WHERE IDNV=@IDNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNV", SqlDbType.Int).Value = nv.IdNV;
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nv.GioiTinh;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.Date).Value = nv.NgaySinh;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nv.Sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nv.Email;
                cmd.Parameters.Add("@IDCV", SqlDbType.Int).Value = nv.IdCV;
                cmd.Parameters.Add("@LUONGCA", SqlDbType.Int).Value = nv.LuongCa;
                cmd.Parameters.Add("@HINHANHNV", SqlDbType.NVarChar).Value = nv.HinhAnhNV;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Con.Close();
                return false;
            }
            Con.Close();
            return true;
        }

        public bool deleteNhanVien(int idNV)
        {
            try
            {
                Con.Open();
                string sql = "DELETE NHANVIEN WHERE IDNV = @IDNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNV", SqlDbType.Int).Value = idNV;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Con.Close();
                return false;
            }
            Con.Close();
            return true;
        }

        public DataTable timKiemNhanVien(string str)
        {
            DataTable dtNhanvien = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDNV, TENNV, GIOITINH, NGAYSINH, DIACHI, SDT, EMAIL, TENCV, LUONGCA, HINHANHNV FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.IDCV = CV.IDCV" +
                    " WHERE TENNV LIKE N'%" + str + "%' OR GIOITINH LIKE N'%" + str + "%' OR DIACHI LIKE N'%" + str + "%' OR TENCV LIKE N'%" + str + "%'", Con);
                da.Fill(dtNhanvien);
            }
            catch (Exception)
            {

                Con.Close();
            }
            return dtNhanvien;
        }
    }
}
