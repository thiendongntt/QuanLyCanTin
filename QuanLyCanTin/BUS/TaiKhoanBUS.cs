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
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanBUS();
                }
                return instance;
            }
        }

        public DataTable getTaiKhoan() => TaiKhoanDAO.Instance.getTaiKhoan();

        public DataTable getTaiKhoanByTenDangNhapAndMatKhau(string tenDangNhap, string matKhau) => TaiKhoanDAO.Instance.getTaiKhoanByTenDangNhapAndMatKhau(tenDangNhap, matKhau);

        public bool createTaiKhoan(TaiKhoanDTO tk) => TaiKhoanDAO.Instance.createTaiKhoan(tk);

        public bool updateTaiKhoan(TaiKhoanDTO tk) => TaiKhoanDAO.Instance.updateTaiKhoan(tk);
        
        public bool deleteSanPham(int idTK) => TaiKhoanDAO.Instance.deleteSanPham(idTK);
    }
}
