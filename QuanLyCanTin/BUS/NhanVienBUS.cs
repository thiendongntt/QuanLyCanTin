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
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }
        }

        public DataTable getNhanVien() => NhanVienDAO.Instance.getNhanVien();

        public bool createNhanVien(NhanVienDTO nv) => NhanVienDAO.Instance.createNhanVien(nv);

        public bool updateNhanVien(NhanVienDTO nv) => NhanVienDAO.Instance.updateNhanVien(nv);

        public bool deleteNhanVien(int idNV) => NhanVienDAO.Instance.deleteNhanVien(idNV);

        public DataTable timKiemNhanVien(string str) => NhanVienDAO.Instance.timKiemNhanVien(str);

    }
}
