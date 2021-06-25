using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TraLuongDTO
    {
        private int idNV;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int soCaLam;
        private int luongThuong;
        private int luongTong;

        public TraLuongDTO()
        {
        }

        public TraLuongDTO(int idNV, DateTime ngayBatDau, DateTime ngayKetThuc, int soCaLam, int luongThuong, int luongTong)
        {
            this.IdNV = idNV;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.SoCaLam = soCaLam;
            this.LuongThuong = luongThuong;
            this.LuongTong = luongTong;
        }

        public int IdNV { get => idNV; set => idNV = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int SoCaLam { get => soCaLam; set => soCaLam = value; }
        public int LuongThuong { get => luongThuong; set => luongThuong = value; }
        public int LuongTong { get => luongTong; set => luongTong = value; }
    }
}
