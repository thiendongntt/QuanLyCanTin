using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        private int idCV;
        private string tenCV;

        public ChucVuDTO()
        {
        }

        public ChucVuDTO(int idCV, string tenCV)
        {
            this.IdCV = idCV;
            this.TenCV = tenCV;
        }

        public int IdCV { get => idCV; set => idCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}
