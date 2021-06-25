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
    public class NhaCungCapDAO : DBConnect
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAO();
                }
                return instance;
            }
        }

        public DataTable getNhaCungCap()
        {
            DataTable dtNCC = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", Con);
                da.Fill(dtNCC);
            }
            catch (Exception)
            {
                Con.Close();
            }
            Con.Close();
            return dtNCC;
        }

        public bool createNhaCungCap(NhaCungCapDTO ncc)
        {
            try
            {
                Con.Open();
                string sql = "INSERT INTO NHACUNGCAP (TENNCC, DIACHI, SDT, EMAIL) VALUES (@TENNCC, @DIACHI, @SDT, @EMAIL)";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = ncc.Sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = ncc.Email;
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

        public bool updateNhaCungCap(NhaCungCapDTO ncc)
        {
            try
            {
                Con.Open();
                string sql = "UPDATE NHACUNGCAP SET TENNCC=@TENNCC, DIACHI=@DIACHI, SDT=@SDT, EMAIL=@EMAIL WHERE IDNCC=@IDNCC";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNCC", SqlDbType.Int).Value = ncc.IdNCC;
                cmd.Parameters.Add("@TENNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = ncc.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = ncc.Sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = ncc.Email;
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

        public bool deleteNhaCungCap(int idNCC)
        {
            try
            {
                Con.Open();
                string sql = "DELETE NHACUNGCAP WHERE IDNCC = @IDNCC";
                SqlCommand cmd = new SqlCommand(sql, Con);
                cmd.Parameters.Add("@IDNCC", SqlDbType.Int).Value = idNCC;
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
