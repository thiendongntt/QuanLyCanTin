using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeBUS();
                }
                return instance;
            }
        }

        public DataTable getAll()
        {
            return ThongKeDAO.Instance.getData();
        }
        public DataTable getDonHangTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return ThongKeDAO.Instance.getDonHangTheoNgay(tuNgay, denNgay);
        }

        public DataTable getDataNhapKho()
        {
            return ThongKeDAO.Instance.getDataNhapKho();
        }
        public DataTable getDataNhapKhoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return ThongKeDAO.Instance.getDataNhapKhoTheoNgay(tuNgay, denNgay);
        }

        public DataTable getDataChartDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            return ThongKeDAO.Instance.getDataChartDoanhThu(tuNgay, denNgay);
        }
        public DataTable getDataChartSanPhamBanChay(DateTime tuNgay, DateTime denNgay)
        {
            return ThongKeDAO.Instance.getDataChartSanPhamBanChay(tuNgay, denNgay);
        }
     
    }
}
