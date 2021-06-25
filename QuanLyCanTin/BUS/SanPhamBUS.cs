using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;

        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamBUS();
                }
                return instance;
            }
        }

        public DataTable getSanPham() => SanPhamDAO.Instance.getSanPham();

        public DataTable getSanPhamByLoai(string loai) => SanPhamDAO.Instance.getSanPhamByLoai(loai);

        public int getIdSP(SanPhamDTO sp) => SanPhamDAO.Instance.getIdSP(sp);

        public bool createSanPham(SanPhamDTO sp) => SanPhamDAO.Instance.createSanPham(sp);

        public bool updateSanPham(SanPhamDTO sp) => SanPhamDAO.Instance.updateSanPham(sp);

        public bool deleteSanPham(int idSP) => SanPhamDAO.Instance.deleteSanPham(idSP);

        public bool updateSLConLai(int idSP, int soLuong) => SanPhamDAO.Instance.updateSLConLai(idSP, soLuong);
    }
}
