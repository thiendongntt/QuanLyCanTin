using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebQuanLyCanTin.Models;

namespace WebQuanLyCanTin.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        QUANLYCANTINEntities db = new QUANLYCANTINEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(KHACHHANG khachHang)
        {
            if (!String.IsNullOrEmpty(khachHang.TAIKHOAN) && !String.IsNullOrEmpty(khachHang.MATKHAU))
            {
                KHACHHANG check = db.KHACHHANGs.SingleOrDefault(s => s.TAIKHOAN.Equals(khachHang.TAIKHOAN) && s.MATKHAU.Equals(khachHang.MATKHAU));
                if (check == null)
                {
                    ViewBag.ThongBao = "Tài khoản hoặc mật khẩu không đúng!";
                    //return View("Index", khachHang);
                    return View();
                }
                else
                {                   
                    Session["TaiKhoan"] = check;
                    Session.Add("User", khachHang.TAIKHOAN);
                    Session["UserDangNhap"] = "1";
                    return RedirectToAction("XemGioHang", "Home");
                }

            }
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(KHACHHANG khachHang)
        {

            if (ModelState.IsValid)
            {
                var check = db.KHACHHANGs.FirstOrDefault(s => s.TAIKHOAN == khachHang.TAIKHOAN);
                if (check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.KHACHHANGs.Add(khachHang);
                    db.SaveChanges();
                    return RedirectToAction("DangNhap", "User");
                }
                else
                {
                    ViewBag.ThongBao = "Tên tài khoản đã tồn tại";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult LayLaiMatKhau()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LayLaiMatKhau(KHACHHANG kh, FormCollection form)
        {
           
            string emailNguoiDung = form["LAYLAIMK"];
    
            string randomMatKhau = "";
         
                string[] chuoiMatKhau = new string[6];
                int i;
                Random chuoiKyTu = new Random();
                for(i = 0; i < 6; i++)
                {
                    chuoiMatKhau[i] = Convert.ToChar(Convert.ToInt32(chuoiKyTu.Next(65, 87))).ToString();
                    randomMatKhau += (chuoiMatKhau[i].ToString());
                }
         
            randomMatKhau = randomMatKhau.ToLower();

            var thongTinNguoiLay = db.KHACHHANGs.Where(s => s.EMAIL == emailNguoiDung).FirstOrDefault();
         
               if(thongTinNguoiLay != null)
              {
                thongTinNguoiLay.MATKHAU = randomMatKhau;

                //Session["MatKhauMoiRandom"] = thongTinNguoiLay;
                db.Configuration.ValidateOnSaveEnabled = false;
                db.SaveChanges();
                string subject = "ĐỔI MẬT KHẨU #" + thongTinNguoiLay.IDKH;
                List<string> cc = new List<string>() { "thiendonggtvt@gmail.com" };
                StringBuilder sb = new StringBuilder();

                sb.Append($" <h2> ***** Ban Quản Lý Căn Tin ***** </h2>");
                sb.Append($"<h2>Kính chào quý khách: {thongTinNguoiLay.TENKH} </h2>");
                sb.Append($" <h2> Thông tin đăng nhập mới của quý khách là: </h2>");
                sb.Append($"<h3> Tài khoản: {thongTinNguoiLay.TAIKHOAN} </h3>");
                sb.Append($"<h3> Mật khẩu: {thongTinNguoiLay.MATKHAU} </h3>");
                var mailSender = new EmailHepper();
                mailSender.Send(thongTinNguoiLay.EMAIL, subject, sb.ToString(), cc);

                ViewBag.ThongBaoKhongLoi = "Mật khẩu mới đã được gửi tới email: " + emailNguoiDung;

                //return RedirectToAction("DoiMatKhau", "User");
                 } 
               else
                {
                ViewBag.ThongBaoLoi = "Email không đúng hoặc không tồn tại!";
                //return RedirectToAction("LayLaiMatKhau");
                }

            return View();
        }

        public ActionResult DoiMatKhau(FormCollection form)
        {
            var st = Session["UserDangNhap"];
            if (Convert.ToInt32(st) == 0)
            {
                return RedirectToAction("DangNhap", "User");
            }
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];
           
           
            if(kh == null)
            {
                return RedirectToAction("DangNhap", "User");
            }
            else
            {
                var updateMatKhau = db.KHACHHANGs.Where(s => s.IDKH == kh.IDKH).FirstOrDefault();
                // Lấy dữ liệu người dùng nhập vào
                string matKhauCu = form["MATKHAUCU"];
                string matKhauMoi = form["MATKHAUMOI"];
                string nhapLaiMKMoi = form["NHAPLAIMKMOI"];
                string matKhauSQL = kh.MATKHAU; 
             
                if (matKhauCu == "" || matKhauMoi == "" || nhapLaiMKMoi == "" )
                {
                    ViewBag.ThongBaoLoi = "Các trường này là bắt buộc";

                }

              else if (matKhauMoi != nhapLaiMKMoi)
                {
                    ViewBag.ThongBaoLoi = "Mật khẩu nhập lại không khớp mật khẩu mới";

                }
                else if (matKhauCu != matKhauSQL)
                {


                }
                else
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    updateMatKhau.MATKHAU = matKhauMoi;
                    db.SaveChanges();
                    ViewBag.ThongBaoKhongLoi = "ĐỔI MẬT KHẨU THÀNH CÔNG!";
                    //RedirectToAction("Index", "Home");
                }
            }
            return View();                
        }

        public ActionResult DangXuat()
        {
            Session["TaiKhoan"] = null;
            Session["GioHang"] = null;
            Session["UserDangNhap"] = "1";
            return RedirectToAction("Index", "Home");
        }
    }
}