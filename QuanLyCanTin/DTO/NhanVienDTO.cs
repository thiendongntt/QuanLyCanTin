using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private int idNV;
        private string tenNV;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private string sdt;
        private string email;
        private int idCV;
        private int luongCa;
        private string hinhAnhNV;

        public NhanVienDTO()
        {
        }

        public NhanVienDTO(int idNV, string tenNV, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt, string email, int idCV, int luongCa, string hinhAnhNV)
        {
            this.IdNV = idNV;
            this.TenNV = tenNV;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Email = email;
            this.IdCV = idCV;
            this.LuongCa = luongCa;
            this.HinhAnhNV = hinhAnhNV;
        }

        public int IdNV { get => idNV; set => idNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int IdCV { get => idCV; set => idCV = value; }
        public int LuongCa { get => luongCa; set => luongCa = value; }
        public string HinhAnhNV { get => hinhAnhNV; set => hinhAnhNV = value; }
    }
}
