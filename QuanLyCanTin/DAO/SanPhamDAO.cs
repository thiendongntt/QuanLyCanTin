using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO : DBConnect
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM", Con);
                da.Fill(dtSanPham);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtSanPham;
        }

        public DataTable getSanPhamByLoai(string loai)
        {
            DataTable dtSanPham = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM WHERE LOAI = '" + loai + "'", Con);
                da.Fill(dtSanPham);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtSanPham;
        }

        public int getIdSP(SanPhamDTO sp)
        {
            int IdSP = -1;
            try
            {
                Con.Open();
                string sql = "SELECT IDSP FROM SANPHAM WHERE TENSP = @TENSP AND GIA=@GIA AND SLCONLAI=@SLCONLAI AND DONVITINH=@DONVITINH AND LOAI=@LOAI AND HINHANHSP=@HINHANHSP";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = sp.Gia;
                cmd.Parameters.Add("@SLCONLAI", SqlDbType.Int).Value = sp.SlConLai;
                cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = sp.DonViTinh;
                cmd.Parameters.Add("@LOAI", SqlDbType.NVarChar).Value = sp.Loai;
                cmd.Parameters.Add("@HINHANHSP", SqlDbType.NVarChar).Value = sp.HinhAnhSP;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    IdSP = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return IdSP;
        }

        public bool createSanPham(SanPhamDTO sp)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO SANPHAM (TENSP, GIA, SLCONLAI, DONVITINH, LOAI, HINHANHSP) VALUES (@TENSP, @GIA, @SLCONLAI, @DONVITINH, @LOAI, @HINHANHSP)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = sp.Gia;
                cmd.Parameters.Add("@SLCONLAI", SqlDbType.Int).Value = sp.SlConLai;
                cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = sp.DonViTinh;
                cmd.Parameters.Add("@LOAI", SqlDbType.NVarChar).Value = sp.Loai;
                cmd.Parameters.Add("@HINHANHSP", SqlDbType.NVarChar).Value = sp.HinhAnhSP;
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

        public bool updateSanPham(SanPhamDTO sp)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE SANPHAM SET TENSP=@TENSP, GIA=@GIA, SLCONLAI=@SLCONLAI, DONVITINH=@DONVITINH, LOAI=@LOAI, HINHANHSP=@HINHANHSP WHERE IDSP=@IDSP";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = sp.IdSP;
                cmd.Parameters.Add("@TENSP", SqlDbType.NVarChar).Value = sp.TenSP;
                cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = sp.Gia;
                cmd.Parameters.Add("@SLCONLAI", SqlDbType.Int).Value = sp.SlConLai;
                cmd.Parameters.Add("@DONVITINH", SqlDbType.NVarChar).Value = sp.DonViTinh;
                cmd.Parameters.Add("@LOAI", SqlDbType.NVarChar).Value = sp.Loai;
                cmd.Parameters.Add("@HINHANHSP", SqlDbType.NVarChar).Value = sp.HinhAnhSP;
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

        public bool deleteSanPham(int idSP)
        {
            try
            {
                Con.Open();
                string sql = "DELETE SANPHAM WHERE IDSP = @IDSP";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = idSP;
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

        public bool updateSLConLai(int idSP, int soLuong)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE SANPHAM SET SLCONLAI = SLCONLAI + @SOLUONG WHERE IDSP=@IDSP";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = idSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = soLuong;
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
