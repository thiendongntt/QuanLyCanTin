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
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;

        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }
        }

        public bool createHoaDon(HoaDonDTO hd) => HoaDonDAO.Instance.createHoaDon(hd);

        public int getIdHD(HoaDonDTO hd) => HoaDonDAO.Instance.getIdHD(hd);

        public DataTable getHoaDonCanGiao() => HoaDonDAO.Instance.getHoaDonCanGiao();

        public DataTable getHoaDonDaGiao() => HoaDonDAO.Instance.getHoaDonDaGiao();

        public bool setThanhCongHoaDon(int idHD) => HoaDonDAO.Instance.setThanhCongHoaDon(idHD);

        public bool setThatBaiHoaDon(int idHD) => HoaDonDAO.Instance.setThatBaiHoaDon(idHD);
    }
}
