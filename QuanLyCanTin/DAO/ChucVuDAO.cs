using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChucVuDAO : DBConnect
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuDAO();
                }
                return instance;
            }
        }

        public DataTable getChucVu()
        {
            DataTable dtChucVu = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHUCVU", Con);
                da.Fill(dtChucVu);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtChucVu;
        }

        public string getTenCVByIdCV(int idCV)
        {
            string tenCV = "";
            try
            {
                Con.Open();
                string sql = "SELECT TENCV FROM CHUCVU WHERE IDCV = " + idCV;
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    tenCV = rd.GetString(0);
                }
            }
            catch (Exception)
            {
                Con.Close();
                throw;
            }
            Con.Close();
            return tenCV;
        }
    }
}
