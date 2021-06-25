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
    public class ChiTietHoaDonDAO : DBConnect
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAO();
                }
                return instance;
            }
        }

        public DataTable getChiTietHoaDon(int idHD)
        {
            DataTable dtCTHD = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETHOADON WHERE IDHD = " + idHD, Con);
                da.Fill(dtCTHD);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtCTHD;
        }

        public void createChiTietHoaDon(ChiTietHoaDonDTO cthd)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO CHITIETHOADON(IDHD, IDSP, SOLUONG, THANHTIEN) VALUES(@IDHD, @IDSP, @SOLUONG, @THANHTIEN)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDHD", SqlDbType.Int).Value = cthd.IdHD;
                cmd.Parameters.Add("@IDSP", SqlDbType.Int).Value = cthd.IdSP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.Parameters.Add("@THANHTIEN", SqlDbType.Int).Value = cthd.ThanhTien;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
        }
    }
}
