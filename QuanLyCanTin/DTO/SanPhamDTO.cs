using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private int idSP;
        private string tenSP;
        private int gia;
        private int slConLai;
        private string donViTinh;
        private string loai;
        private string hinhAnhSP;

        public SanPhamDTO()
        {
        }

        public SanPhamDTO(int idSP, string tenSP, int gia, int slConLai, string donViTinh, string loai, string hinhAnhSP)
        {
            this.IdSP = idSP;
            this.TenSP = tenSP;
            this.Gia = gia;
            this.SlConLai = slConLai;
            this.DonViTinh = donViTinh;
            this.Loai = loai;
            this.HinhAnhSP = hinhAnhSP;
        }

        public int IdSP { get => idSP; set => idSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int Gia { get => gia; set => gia = value; }
        public int SlConLai { get => slConLai; set => slConLai = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string Loai { get => loai; set => loai = value; }
        public string HinhAnhSP { get => hinhAnhSP; set => hinhAnhSP = value; }
    }
}
