using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO : DBConnect
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAO();
                }
                return instance;
            }
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDHD AS N'Mã hóa đơn', NGAYLAP AS N'Ngày lập', TONGTIEN AS N'Tổng tiền' FROM HOADON", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dt;
        }

        public DataTable getDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDHD AS N'Mã hóa đơn', NGAYLAP AS N'Ngày lập', TONGTIEN AS N'Tổng tiền' FROM HOADON WHERE NGAYLAP >= '" + tuNgay + "' AND NGAYLAP <= '" + denNgay + "'", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }

            Con.Close();
            return dt;
        }

        public DataTable getDataNhapKho()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT IDSP AS N'Mã sản phẩm', SOLUONG AS N'Số lượng', NGAYNHAP AS N'Ngày nhập', TENNCC AS 'Tên nhà cung cấp' FROM NHAPHANG NH INNER JOIN NHACUNGCAP NCC ON NH.IDNCC = NCC.IDNCC";
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, Con);
                da.Fill(dt);
            }
            catch
            {
                Con.Close();
            }
            return dt;
        }

        public DataTable getDataNhapKhoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT IDSP AS N'Mã sản phẩm', SOLUONG AS N'Số lượng', NGAYNHAP AS N'Ngày nhập', TENNCC AS 'Tên nhà cung cấp' FROM NHAPHANG NH INNER JOIN NHACUNGCAP NCC ON NH.IDNCC = NCC.IDNCC WHERE NGAYNHAP >= '" + tuNgay + "' AND NGAYNHAP <= '" + denNgay + "'";
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }
            return dt;
        }

        public DataTable getDataChartDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT NGAYLAP, MONTH(NGAYLAP) AS THANG, SUM(TONGTIEN) AS TONGTIEN FROM HOADON WHERE NGAYLAP >= '" + tuNgay + "' AND NGAYLAP <= '" + denNgay + "' GROUP BY NGAYLAP, MONTH(NGAYLAP) ORDER BY NGAYLAP";
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }
            return dt;
        }

        public DataTable getDataChartSanPhamBanChay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT TOP 5 SP.TENSP AS TENSP, SUM(CTHD.SOLUONG) AS TONGSOLUONG FROM SANPHAM SP INNER JOIN CHITIETHOADON CTHD ON SP.IDSP = CTHD.IDSP INNER JOIN HOADON HD ON HD.IDHD = CTHD.IDHD WHERE NGAYLAP >= '" + tuNgay + "' AND NGAYLAP <= '" + denNgay + "' GROUP BY SP.TENSP ORDER BY SUM(SOLUONG) DESC";
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, Con);
                da.Fill(dt);
            }
            catch (Exception)
            {
                Con.Close();
            }
            return dt;
        }
    }
}
