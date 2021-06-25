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
    public class TraLuongBUS
    {
        private static TraLuongBUS instance;

        public static TraLuongBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TraLuongBUS();
                }
                return instance;
            }
        }

        public DataTable getNhanVien() => TraLuongDAO.Instance.getNhanVien();

        public DataTable getTraLuong() => TraLuongDAO.Instance.getTraLuong();

        public bool createTraLuong(TraLuongDTO tl) => TraLuongDAO.Instance.createTraLuong(tl);

        public int getSoBuoi(int id, DateTime ngayBatDau, DateTime ngayKetThuc) => TraLuongDAO.Instance.getSoBuoi(id, ngayBatDau, ngayKetThuc);
    }
}
