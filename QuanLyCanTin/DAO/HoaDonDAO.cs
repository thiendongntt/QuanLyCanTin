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
    public class HoaDonDAO : DBConnect
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
        }

        public bool createHoaDon(HoaDonDTO hd)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO HOADON (NGAYLAP, TONGTIEN, GIAOHANG, TENKH, SDT, DIACHI, GHICHU, TRANGTHAI) VALUES (@NGAYLAP, @TONGTIEN, @GIAOHANG, @TENKH, @SDT, @DIACHI, @GHICHU, @TRANGTHAI)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = hd.NgayLap;
                cmd.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = hd.TongTien;
                cmd.Parameters.Add("@GIAOHANG", SqlDbType.Bit).Value = hd.GiaoHang;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = hd.TenKhach;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = hd.Sdt;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hd.DiaChi;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = hd.GhiChu;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = hd.TrangThai;
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

        public int getIdHD(HoaDonDTO hoaDon)
        {
            int IdHD = -1;
            try
            {
                Con.Open();
                string sql = "SELECT IDHD FROM HOADON WHERE NGAYLAP = @NGAYLAP AND TONGTIEN=@TONGTIEN AND GIAOHANG=@GIAOHANG AND TENKH=@TENKH AND SDT=@SDT AND DIACHI=@DIACHI AND GHICHU=@GHICHU AND TRANGTHAI=@TRANGTHAI";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date).Value = hoaDon.NgayLap;
                cmd.Parameters.Add("@TONGTIEN", SqlDbType.Int).Value = hoaDon.TongTien;
                cmd.Parameters.Add("@GIAOHANG", SqlDbType.Bit).Value = hoaDon.GiaoHang;
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = hoaDon.TenKhach;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = hoaDon.Sdt;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = hoaDon.DiaChi;
                cmd.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = hoaDon.GhiChu;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.NVarChar).Value = hoaDon.TrangThai;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    IdHD = rd.GetInt32(0);
                }
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return IdHD;
        }

        public DataTable getHoaDonCanGiao()
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON WHERE GIAOHANG = 'True' AND TRANGTHAI = N'Đang giao'", Con);
                da.Fill(dtHoaDon);
            }
            catch (Exception)
            {
                Con.Close();
            }

            Con.Close();
            return dtHoaDon;
        }

        public DataTable getHoaDonDaGiao()
        {
            DataTable dtHoaDon = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON WHERE GIAOHANG = 'True' AND TRANGTHAI = N'Thành công' OR TRANGTHAI = N'Thất bại'", Con);
                da.Fill(dtHoaDon);
            }
            catch (Exception)
            {
                Con.Close();
            }

            Con.Close();
            return dtHoaDon;
        }

        public bool setThanhCongHoaDon(int idHD)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE HOADON SET TRANGTHAI = N'Thành công' WHERE IDHD = " + idHD;
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Con.Close();
            }
        }
        public bool setThatBaiHoaDon(int idHD)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE HOADON SET TRANGTHAI = N'Thất bại' WHERE IDHD = " + idHD;
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
