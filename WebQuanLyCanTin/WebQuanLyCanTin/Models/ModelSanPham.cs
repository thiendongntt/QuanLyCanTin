using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
namespace WebQuanLyCanTin.Models
{
    public class ModelSanPham
    {

        QUANLYCANTINEntities db = new QUANLYCANTINEntities();
        public ModelSanPham()
        {

        }
        public IEnumerable<SANPHAM> ListAll(int page, int pageSize)
        {
            return db.SANPHAMs.OrderByDescending(sp => sp.IDSP).ToPagedList(page, pageSize);
        }
    }
}
    