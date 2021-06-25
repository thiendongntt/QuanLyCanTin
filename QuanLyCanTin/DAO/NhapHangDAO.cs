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
    public class NhapHangDAO : DBConnect
    {
        private static NhapHangDAO instance;

        public static NhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapHangDAO();
                }
                return instance;
            }
        }

        public DataTable getSanPham()
        {
            DataTable dtSanPham = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDSP, TENSP, GIA, SLCONLAI, DONVITINH FROM SANPHAM", Con);
                da.Fill(dtSanPham);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtSanPham;
        }

        public DataTable getNhapHang()
        {
            DataTable dtNhapHang = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHAPHANG", Con);
                da.Fill(dtNhapHang);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtNhapHang;
        }

        public bool createNhapHang(NhapHangDTO nh)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO NHAPHANG (IDSP, SOLUONG, NGAYNHAP, IDNCC) VALUES (@IDSP, @SOLUONG, @NGAYNHAP, @IDNCC)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = nh.IdSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = nh.SoLuong;
                cmd.Parameters.Add("@NGAYNHAP", SqlDbType.Date).Value = nh.NgayNhap;
                cmd.Parameters.Add("@IDNCC", SqlDbType.Int).Value = nh.IdNCC;
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
