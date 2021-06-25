using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        private int idHD;
        private int idSP;
        private int soLuong;
        private int thanhTien;

        public ChiTietHoaDonDTO()
        {
        }

        public ChiTietHoaDonDTO(int idHD, int idSP, int soLuong, int thanhTien)
        {
            this.IdHD = idHD;
            this.IdSP = idSP;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public int IdHD { get => idHD; set => idHD = value; }
        public int IdSP { get => idSP; set => idSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
