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
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUS();
                }
                return instance;
            }
        }

        public DataTable getChiTietHoaDon(int idHD) => ChiTietHoaDonDAO.Instance.getChiTietHoaDon(idHD);

        public void createChiTietHoaDon(ChiTietHoaDonDTO cthd) => ChiTietHoaDonDAO.Instance.createChiTietHoaDon(cthd);
    }
}
