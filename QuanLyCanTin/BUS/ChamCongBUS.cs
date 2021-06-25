using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChamCongBUS
    {
        private static ChamCongBUS instance;

        public static ChamCongBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongBUS();
                }
                return instance;
            }
        }

        public DataTable getNhanVien() => ChamCongDAO.Instance.getNhanVien();

        public DataTable getChamCong() => ChamCongDAO.Instance.getChamCong();

        public bool createChamCong(ChamCongDTO cc) => ChamCongDAO.Instance.createChamCong(cc);

    }
}
