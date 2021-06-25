using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private int idTK;
        private string tenDangNhap;
        private string matKhau;
        private int idCV;

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(int idTK, string tenDangNhap, string matKhau, int idCV)
        {
            this.IdTK = idTK;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.IdCV = idCV;
        }

        public int IdTK { get => idTK; set => idTK = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int IdCV { get => idCV; set => idCV = value; }
    }
}
