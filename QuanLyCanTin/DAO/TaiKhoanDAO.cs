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
    public class TaiKhoanDAO : DBConnect
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
        }

        public DataTable getTaiKhoan()
        {
            DataTable dtTaiKhoan = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDTK, TENDANGNHAP, MATKHAU, TENCV FROM TAIKHOAN TK INNER JOIN CHUCVU CV ON TK.IDCV = CV.IDCV", Con);
                da.Fill(dtTaiKhoan);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtTaiKhoan;
        }

        public DataTable getTaiKhoanByTenDangNhapAndMatKhau(string tenDangNhap, string matKhau)
        {
            DataTable dtTaiKhoan = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = '" + tenDangNhap + "' AND MATKHAU = '" + matKhau + "'", Con);
                da.Fill(dtTaiKhoan);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtTaiKhoan;
        }

        public bool createTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO TAIKHOAN (TENDANGNHAP, MATKHAU, IDCV) VALUES (@TENDANGNHAP, @MATKHAU, @IDCV)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = tk.TenDangNhap;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = tk.MatKhau;
                cmd.Parameters.Add("@IDCV", SqlDbType.Int).Value = tk.IdCV;
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

        public bool updateTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE TAIKHOAN SET TENDANGNHAP=@TENDANGNHAP, MATKHAU=@MATKHAU, IDCV=@IDCV WHERE IDTK=@IDTK";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDTK", SqlDbType.Int).Value = tk.IdTK;
                cmd.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = tk.TenDangNhap;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = tk.MatKhau;
                cmd.Parameters.Add("@IDCV", SqlDbType.Int).Value = tk.IdCV;
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

        public bool deleteSanPham(int idTK)
        {
            try
            {
                Con.Open();
                string sql = "DELETE TAIKHOAN WHERE IDTK = @IDTK";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDTK", SqlDbType.Int).Value = idTK;
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
    }
}
