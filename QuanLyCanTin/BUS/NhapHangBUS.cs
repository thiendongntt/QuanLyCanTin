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
    public class NhapHangBUS
    {
        private static NhapHangBUS instance;

        public static NhapHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapHangBUS();
                }
                return instance;
            }
        }

        public DataTable getSanPham() => NhapHangDAO.Instance.getSanPham();

        public DataTable getNhapHang() => NhapHangDAO.Instance.getNhapHang();

        public bool createNhapHang(NhapHangDTO nh) => NhapHangDAO.Instance.createNhapHang(nh);
    }
}
