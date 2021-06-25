using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;

        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBUS();
                }
                return instance;
            }
        }

        public DataTable getNhaCungCap() => NhaCungCapDAO.Instance.getNhaCungCap();

        public bool createNhaCungCap(NhaCungCapDTO ncc) => NhaCungCapDAO.Instance.createNhaCungCap(ncc);

        public bool updateNhaCungCap(NhaCungCapDTO ncc) => NhaCungCapDAO.Instance.updateNhaCungCap(ncc);

        public bool deleteNhaCungCap(int idNCC) => NhaCungCapDAO.Instance.deleteNhaCungCap(idNCC);
    }
}
