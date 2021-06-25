using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHangDTO
    {
        private int idSP;
        private int soLuong;
        private DateTime ngayNhap;
        private int idNCC;

        public NhapHangDTO()
        {
        }

        public NhapHangDTO(int idSP, int soLuong, DateTime ngayNhap, int idNCC)
        {
            this.IdSP = idSP;
            this.SoLuong = soLuong;
            this.NgayNhap = ngayNhap;
            this.IdNCC = idNCC;
        }

        public int IdSP { get => idSP; set => idSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int IdNCC { get => idNCC; set => idNCC = value; }
    }
}
