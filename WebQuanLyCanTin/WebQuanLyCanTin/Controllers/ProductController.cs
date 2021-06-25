using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using WebQuanLyCanTin.Models;
namespace WebQuanLyCanTin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        QUANLYCANTINEntities db = new QUANLYCANTINEntities();
        
        public ActionResult Index()
        {
            var danhSachSP = db.SANPHAMs.ToList();
            return View(danhSachSP);
        }
        public ActionResult ThemGioHang(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("SanPhamPartial");
        }
        public ActionResult ThemGioHangDoAnSang(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("DoAnSang");
        }
        public ActionResult ThemGioHangDoAnVat(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("DoAnVat");
        }
        public ActionResult ThemGioHangDoUong(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("DoUong");
        }
        public ActionResult ThemGioHangKhac(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("Khac");
        }
        public ActionResult ThemGioHangTimKiem(int maSP)
        {
            if (Session["GioHang"] == null)
            {
                List<GioHang> gioHang = new List<GioHang>();
                var sanPham = db.SANPHAMs.Find(maSP);
                gioHang.Add(new GioHang()
                {
                    SanPham = sanPham,
                    id = sanPham.IDSP,
                    name = sanPham.TENSP,
                    image = sanPham.HINHANHSP,
                    price = sanPham.GIA,
                    quantity = 1,

                });

                Session["GioHang"] = gioHang;
            }
            else
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);

                for (int i = 0; i < count; i++)
                {
                    if (gioHang[i].SanPham.IDSP == maSP)
                    {
                        int tangSoLuong = gioHang[i].quantity;
                        gioHang.Remove(gioHang[i]);
                        gioHang.Add(new GioHang()
                        {
                            SanPham = sanPham,
                            id = sanPham.IDSP,
                            name = sanPham.TENSP,
                            image = sanPham.HINHANHSP,
                            price = sanPham.GIA,
                            quantity = tangSoLuong + 1
                        });
                        break;
                    }
                    else
                    {

                        var prd = gioHang.Where(x => x.SanPham.IDSP == maSP).SingleOrDefault();
                        if (prd == null)
                        {
                            gioHang.Add(new GioHang()
                            {
                                SanPham = sanPham,
                                id = sanPham.IDSP,
                                name = sanPham.TENSP,
                                image = sanPham.HINHANHSP,
                                price = sanPham.GIA,
                                quantity = 1,
                            });
                        }
                    }
                }


                Session["GioHang"] = gioHang;
            }
            return RedirectToAction("timKiemSanPham");
        }
        public ActionResult SanPhamPartial(int page = 1, int pageSize = 12)
        {
            //var dsSanPham = db.SANPHAMs.OrderBy(sp => sp.LOAI).ToList().ListAll() ;
            var dsSanPham = new ModelSanPham();
            var model = dsSanPham.ListAll(page, pageSize);
       
            //var dsSanPham = db.SANPHAMs.Where(sp => sp.LOAI != "Ăn sáng" && sp.LOAI != "Đồ ăn vật" && sp.LOAI != "Đồ uống");

            return View(model);
        }
        
        public ActionResult DoAnSang(int page = 1, int pageSize = 12)
        {
            var dsDoAnSang = db.SANPHAMs.Where(sp => sp.LOAI == "Đồ ăn sáng").ToList();
            if (dsDoAnSang.Count == 0)
            {
                ViewBag.thongBao = "Sản phẩm đã hết. Xin quý khách thông cảm";
            }
            return View(dsDoAnSang);
        }
        public ActionResult DoAnVat(int page = 1, int pageSize = 12)
        {
            var dsDoAnVat = db.SANPHAMs.Where(sp => sp.LOAI == "Đồ ăn vặt").ToList();
            if (dsDoAnVat.Count == 0)
            {
                ViewBag.thongBao = "Sản phẩm đã hết. Xin quý khách thông cảm";
            }
            return View(dsDoAnVat);
        }
        public ActionResult DoUong(int page = 1, int pageSize = 12)
        {
            var dsDoUong = db.SANPHAMs.Where(sp => sp.LOAI == "Đồ uống").ToList();
            if (dsDoUong.Count == 0)
            {
                ViewBag.thongBao = "Sản phẩm đã hết. Xin quý khách thông cảm";
            }
            return View(dsDoUong);
        }
        public ActionResult Khac(int page = 1, int pageSize = 12)
        {
            var dsKhac = db.SANPHAMs.Where(sp => sp.LOAI == "Khác").ToList();
            if (dsKhac.Count == 0)
            {
                ViewBag.thongBao = "Sản phẩm đã hết. Xin quý khách thông cảm";
            }
            return View(dsKhac);
        }
        public ActionResult timKiemSanPham(string tenSP)
        {
 
            var query = (db.SANPHAMs.Where(s => s.TENSP.Contains(tenSP))).ToList();
            ViewBag.SanPhamTimKiem = query;
            return View(query);

        }

    }
}