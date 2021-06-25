using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private int idHD;
        private DateTime ngayLap;
        private int tongTien;
        private bool giaoHang;
        private string tenKhach;
        private string sdt;
        private string diaChi;
        private string ghiChu;
        private string trangThai;
        private int idKH;

        public HoaDonDTO()
        {
        }

        public HoaDonDTO(int idHD, DateTime ngayLap, int tongTien, bool giaoHang, string tenKhach, string sdt, string diaChi, string ghiChu, string trangThai, int idKH)
        {
            this.IdHD = idHD;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
            this.GiaoHang = giaoHang;
            this.TenKhach = tenKhach;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.GhiChu = ghiChu;
            this.TrangThai = trangThai;
            this.IdKH = idKH;
        }

        public int IdHD { get => idHD; set => idHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public bool GiaoHang { get => giaoHang; set => giaoHang = value; }
        public string TenKhach { get => tenKhach; set => tenKhach = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int IdKH { get => idKH; set => idKH = value; }
    }
}
