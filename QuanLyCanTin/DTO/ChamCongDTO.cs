using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCongDTO
    {
        private int idNV;
        private DateTime ngayLam;
        private string caTruc;

        public ChamCongDTO()
        {
        }

        public ChamCongDTO(int idNV, DateTime ngayLam, string caTruc)
        {
            this.IdNV = idNV;
            this.NgayLam = ngayLam;
            this.CaTruc = caTruc;
        }

        public int IdNV { get => idNV; set => idNV = value; }
        public DateTime NgayLam { get => ngayLam; set => ngayLam = value; }
        public string CaTruc { get => caTruc; set => caTruc = value; }
    }
}
