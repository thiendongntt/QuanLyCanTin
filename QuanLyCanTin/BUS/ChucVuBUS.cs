using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVuBUS
    {
        private static ChucVuBUS instance;

        public static ChucVuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuBUS();
                }
                return instance;
            }
        }

        public DataTable getChucVu() => ChucVuDAO.Instance.getChucVu();

        public string getTenCVByIdCV(int idCV) => ChucVuDAO.Instance.getTenCVByIdCV(idCV);
    }
}
