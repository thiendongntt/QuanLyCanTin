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
    public class ChamCongDAO : DBConnect
    {
        private static ChamCongDAO instance;

        public static ChamCongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongDAO();
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT IDNV, TENNV, GIOITINH, DIACHI, TENCV FROM NHANVIEN NV INNER JOIN CHUCVU CV ON NV.IDCV = CV.IDCV", Con);
                da.Fill(dtNhanVien);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtNhanVien;
        }

        public DataTable getChamCong()
        {
            DataTable dtChamCong = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHAMCONG", Con);
                da.Fill(dtChamCong);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtChamCong;
        }

        public bool createChamCong(ChamCongDTO cc)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO CHAMCONG (IDNV, NGAYLAM, CATRUC) VALUES (@IDNV, @NGAYLAM, @CATRUC)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNV", SqlDbType.NVarChar).Value = cc.IdNV;
                cmd.Parameters.Add("@NGAYLAM", SqlDbType.Date).Value = cc.NgayLam;
                cmd.Parameters.Add("@CATRUC", SqlDbType.NVarChar).Value = cc.CaTruc;
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
