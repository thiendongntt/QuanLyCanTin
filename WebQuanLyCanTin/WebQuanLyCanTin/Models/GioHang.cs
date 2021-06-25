using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQuanLyCanTin.Models
{
    //public class CartItem
    //{
    //    public SANPHAM Shopping_SanPham { get; set; }
    //    public int soLuong { get; set; }
    //}
    public class GioHang
    {
        QUANLYCANTINEntities db = new QUANLYCANTINEntities();
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public SANPHAM SanPham { get; set; }
        

        public int total_price
        {
            get { return quantity * price; }
        }
    }
}