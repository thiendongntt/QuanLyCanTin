using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private int idNCC;
        private string tenNCC;
        private string diaChi;
        private string sdt;
        private string email;

        public NhaCungCapDTO()
        {
        }

        public NhaCungCapDTO(int idNCC, string tenNCC, string diaChi, string sdt, string email)
        {
            this.IdNCC = idNCC;
            this.TenNCC = tenNCC;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Email = email;
        }

        public int IdNCC { get => idNCC; set => idNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
