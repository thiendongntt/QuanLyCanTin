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
    public class TraLuongDAO : DBConnect
    {
        private static TraLuongDAO instance;

        public static TraLuongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TraLuongDAO();
                }
                return instance;
            }
        }

        public DataTable getNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDNV, TENNV, TENCV, LUONGCA FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.IDCV = CV.IDCV", Con);
                da.Fill(dtNhanVien);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtNhanVien;
        }

        public DataTable getTraLuong()
        {
            DataTable dtTraLuong = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TL.IDNV, TENNV, NGAYBATDAU, NGAYKETTHUC, SOCALAM, LUONGTHUONG, LUONGTONG FROM TRALUONG TL INNER JOIN NHANVIEN NV ON TL.IDNV = NV.IDNV", Con);
                da.Fill(dtTraLuong);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtTraLuong;
        }

        public bool createTraLuong(TraLuongDTO tl)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO TRALUONG (IDNV, NGAYBATDAU, NGAYKETTHUC, SOCALAM, LUONGTHUONG, LUONGTONG) VALUES (@IDNV, @NGAYBATDAU, @NGAYKETTHUC, @SOCALAM, @LUONGTHUONG, @LUONGTONG)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNV", SqlDbType.Int).Value = tl.IdNV;
                cmd.Parameters.Add("@NGAYBATDAU", SqlDbType.Date).Value = tl.NgayBatDau;
                cmd.Parameters.Add("@NGAYKETTHUC", SqlDbType.Date).Value = tl.NgayKetThuc;
                cmd.Parameters.Add("@SOCALAM", SqlDbType.Int).Value = tl.SoCaLam;
                cmd.Parameters.Add("@LUONGTHUONG", SqlDbType.Int).Value = tl.LuongThuong;
                cmd.Parameters.Add("@LUONGTONG", SqlDbType.Int).Value = tl.LuongTong;
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

        public int getSoBuoi(int idNV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int soBuoi = 0;
            try
            {
                Con.Open();
                string sql = "SELECT COUNT(*) FROM CHAMCONG WHERE IDNV = " + idNV + " AND NGAYLAM >= '" + ngayBatDau.Date + "'AND NGAYLAM <= '" + ngayKetThuc.Date + "'  GROUP BY IDNV";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    soBuoi = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {
                Con.Close();
                throw;
            }
            Con.Close();
            return soBuoi;
        }
    }
}
