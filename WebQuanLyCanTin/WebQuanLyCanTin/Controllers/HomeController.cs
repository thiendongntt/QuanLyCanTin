using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using WebQuanLyCanTin.Models;



namespace WebQuanLyCanTin.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: Home
        QUANLYCANTINEntities db = new QUANLYCANTINEntities();
        public ActionResult Index()
        {       
            var danhSach = db.SANPHAMs.ToList(); // Lấy toàn bộ danh sách
            return View(danhSach); // Truyền danh sách ra bên ngoài
        }
        public static string getString(string s)
        {
            if (s.Length > 16)
            {
                return s.Substring(0, 16);
            }
            else
            {
                return s;
            }
        }

        public ActionResult ThemGioHang(int maSP)
        {
            List<GioHang> gioHang = new List<GioHang>();
            if (Session["GioHang"] == null)
            {              
             var sanPham = db.SANPHAMs.Find(maSP);
             gioHang.Add(new GioHang() { 
              SanPham = sanPham,
              id = sanPham.IDSP,
              name = sanPham.TENSP,
              image = sanPham.HINHANHSP,
              price = sanPham.GIA,
              quantity = 1,
              
            });
         
            Session["GioHang"] = gioHang;
            } else
            {
                gioHang = (List<GioHang>)Session["GioHang"];
                var count = gioHang.Count();
                var sanPham = db.SANPHAMs.Find(maSP);
                 
                for(int i = 0; i < count; i++)
                {
                    if(gioHang[i].SanPham.IDSP == maSP)
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
            return RedirectToAction("Index", "Home");
        }

        private int TongSoLuong()
        {
            int tongSoLuong = 0;
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            if(gioHang != null)
            {
                tongSoLuong += gioHang.Sum(sp => sp.quantity);
                Session.Add("TongSoLuong", tongSoLuong);
            }
            return tongSoLuong;
        }

        public ActionResult XoaGioHang(int maSP)
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            foreach(var item in gioHang)
            {
                if(item.SanPham.IDSP == maSP)
                {
                    gioHang.Remove(item);
                    break;
                }
            }
            Session["GioHang"] = gioHang;
            return Redirect("Index");
        }

        public ActionResult XoaHetGioHang()
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            gioHang.Clear();
            Session["GioHang"] = null;
          
            return Redirect("XemGioHang");
        }

        public ActionResult CapNhatSoLuong(FormCollection form)
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            int maSP = int.Parse(form["MaSP"]);
            int quantity = int.Parse(form["SoLuong"]);

            foreach (var item in gioHang)
            {
                if (item.SanPham.IDSP == maSP)
                {
                    item.quantity = quantity++;
                    break;
                }
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult XemGioHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == null)
            {
                return RedirectToAction("DangNhap", "User");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            
            int tongTien = 0;
            int tongSanPham = 0;
            ViewBag.TongTien = "";
            if(Session["GioHang"] != null)
            {
                List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
                foreach(GioHang sanPham in gioHang)
                {
                    tongTien += sanPham.price * sanPham.quantity;
                    tongSanPham += sanPham.quantity;
                }
                
            } 
           
            ViewBag.TongSanPham = tongSanPham;
            ViewBag.TongTien = tongTien;
            return View();
        }
        public ActionResult XoaGioHangXemGH(int maSP)
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            foreach (var item in gioHang)
            {
                if (item.SanPham.IDSP == maSP)
                {
                    gioHang.Remove(item);
                    break;
                }
            }
            Session["GioHang"] = gioHang;
            return Redirect("XemGioHang");
        }
        public ActionResult CapNhatSoLuongXemGH(FormCollection form)
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            int maSP = int.Parse(form["MaSP"]);
            int quantity = int.Parse(form["SoLuong"]);

            foreach (var item in gioHang)
            {
                if (item.SanPham.IDSP == maSP)
                {
                    item.quantity = quantity++;
                    break;
                }
            }
            return RedirectToAction("XemGioHang", "Home");
        }
        public ActionResult LoadGioHang()
        {
            List<GioHang> gioHang = null;
            if (Session["GioHang"] != null)
            {
                gioHang = (List<GioHang>)Session["GioHang"];
            }

            int tongTien = 0;
            int soLuong = 0;
            foreach(GioHang sanPham in gioHang)
            {
                tongTien += sanPham.price * sanPham.quantity;
            }
            soLuong = gioHang.Count;
            return Json(new { GioHang = gioHang, tongTien = tongTien, soLuong = soLuong }, JsonRequestBehavior.AllowGet);
        }
      
        [HttpGet]
        public ActionResult DatHang()
        {
            var st = Session["UserDangNhap"];
            if (Convert.ToInt32(st) == 0)
            {
                return RedirectToAction("DangNhap", "User");
            }
            int tongTien = 0;
            int tongSanPham = 0;
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            if (Session["GioHang"] == null)
            {
                RedirectToAction("Index", "Home");
            }
            if (Session["GioHang"] != null)
            {        
                foreach (GioHang sanPham in gioHang)
                {
                    tongTien += sanPham.price * sanPham.quantity;
                    tongSanPham += sanPham.quantity;
                }              
            }
          
            ViewBag.TongSanPham = tongSanPham;
            ViewBag.TongTien = tongTien;
            return View();
        }
        [HttpPost]
        public ActionResult DatHang(FormCollection form, string HinhThucThanhToan)
        {
            
            var st = Session["UserDangNhap"];
            if (Convert.ToInt32(st) == 0)
            {
                return RedirectToAction("DangNhap", "User");
            }
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            HOADON hd = new HOADON();
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];


            const string accountSid = "ACe3a8b773848d01d527c7b18a8a043af8";
            const string authToken = "637e8c0806e62e17009de4c6019cda1a";
            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber("+84" + kh.SDT);

           
            int tongTien = 0;
            int tongSanPham = 0;
            foreach (GioHang sanPham in gioHang)
            {
                tongTien += sanPham.price * sanPham.quantity;
                tongSanPham += sanPham.quantity;

            }
            ViewBag.TongSanPham = tongSanPham;
            ViewBag.TongTien = tongTien;

            hd.IDKH = kh.IDKH;
            hd.NGAYLAP = DateTime.Now;  
            hd.TONGTIEN = tongTien;
            hd.TENKH = kh.TENKH;
            hd.GIAOHANG = true;
            hd.SDT = kh.SDT;
            hd.DIACHI = form["phongNhanHang"];

            Session["PHONGNHANHANG"] = form["phongNhanHang"];
            Session.Add("DIACHI", hd.DIACHI);
            Session["DIACHI"] = hd.DIACHI;

            Session.Add("NGAYLAP", hd.NGAYLAP);
            foreach (var item in gioHang)
            {
                CHITIETHOADON cthd = new CHITIETHOADON();
                cthd.IDHD = hd.IDHD;
                cthd.IDSP = item.id;
                cthd.SOLUONG = item.quantity;
                cthd.THANHTIEN = item.quantity * item.price;
                db.CHITIETHOADONs.Add(cthd);

            }
         
            if (HinhThucThanhToan == "nhanhang")
            {
                // Cập nhật trạng thái           
         
                hd.TRANGTHAI = "Đang giao";
                db.HOADONs.Add(hd);
                db.SaveChanges();
                Session.Add("MAHOADON", hd.IDHD);

                // Email khách hàng
                string subject = "XÁC NHẬN ĐƠN HÀNG #"+ hd.IDHD;
                List<string> cc = new List<string>() { "thiendonggtvt@gmail.com" };
                StringBuilder sb = new StringBuilder();
                sb.Append($"<h2> ----- BQL Quản Lý Căn Tin UTC2 ----- </h2>");
                sb.Append($"<h3> Kính chào quý khách {kh.TENKH} </h3>");
                sb.Append("<p> Đơn hàng của bạn như sau: </p>");
              
                sb.Append("<table>");

                // Nội dung Email
                foreach (GioHang sanPham in gioHang)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td> <strong> Tên sản phẩm </strong> </br> {sanPham.name}</td>");
                    sb.Append($"<td> <strong> Đơn giá </br> </strong>  {sanPham.price}</br> </td>");
                    sb.Append($"<td> <strong> Số lượng </strong>  </br> {sanPham.quantity} </br> </td>");
                    sb.Append($"  <td> <strong> Thành tiền </strong> </br> {sanPham.quantity * sanPham.price} </td>");
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                sb.Append($"<p> Tổng tiền: <strong> {tongTien} </strong> </p>");
                sb.Append($"<p> Phòng nhận hàng: <strong> {hd.DIACHI} </strong> </p>");
                sb.Append("<p> Hình thức thanh toán: Nhận tiền khi giao hàng </p>");
                sb.Append("<h2>Cảm ơn quý khách đã tin tưởng và ủng hộ! </h2>");

                // Gửi
                var mailSender = new EmailHepper();
                mailSender.Send(kh.EMAIL, subject, sb.ToString(), cc);

                var message = MessageResource.Create(
                    to,
                    from: new PhoneNumber("+13133671310"),  
                    body: $"Xin chào " + kh.TENKH + ". Đơn hàng #" + hd.IDHD + " của bạn sẽ được giao trong ít phút nữa. Phòng: " + hd.DIACHI + ". Tổng tiền: " + tongTien);


                return RedirectToAction("XacNhanDatHang", "Home");
            }

            else if (HinhThucThanhToan == "momo")
            { 
                return RedirectToAction("XacNhanDonHangMoMo", "Home");
            }

           
            return RedirectToAction("DatHang");
            
        }

        public ActionResult ThanhToan()
        {
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            string endpoint = ConfigurationManager.AppSettings["endpoint"].ToString();
            string partnerCode = ConfigurationManager.AppSettings["partnerCode"].ToString();
            string accessKey = ConfigurationManager.AppSettings["accessKey"].ToString();
            string serectkey = ConfigurationManager.AppSettings["serectkey"].ToString();
            string orderInfo = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string returnUrl = ConfigurationManager.AppSettings["returnUrl"].ToString();
            string notifyurl = ConfigurationManager.AppSettings["notifyurl"].ToString();

            string amount = gioHang.Sum(n => n.price * n.quantity).ToString();
            string orderid = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            //before sign HMAC SHA256 signature
            string rawHash = "partnerCode=" +
                partnerCode + "&accessKey=" +
                accessKey + "&requestId=" +
                requestId + "&amount=" +
                amount + "&orderId=" +
                orderid + "&orderInfo=" +
                orderInfo + "&returnUrl=" +
                returnUrl + "&notifyUrl=" +
                notifyurl + "&extraData=" +
                extraData;
            MoMoSecurity crypto = new MoMoSecurity();
            string signature = crypto.signSHA256(rawHash, serectkey);
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }

            };
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());
            try
            {
                JObject jmessage = JObject.Parse(responseFromMomo);
                return Redirect(jmessage.GetValue("payUrl").ToString());
            }
            catch
            {
                TempData["ERROR"] = responseFromMomo;
                return RedirectToAction("XacNhanDonHangMoMo");
            }
        }

  
        public ActionResult XacNhanDonHangMoMo(FormCollection form)
        {
            var st = Session["UserDangNhap"];
            if (Convert.ToInt32(st) == 0)
            {
                return RedirectToAction("DangNhap", "User");
            }

            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];
            HOADON hd = new HOADON();

            // Tính tổng tiển và tổng số lượng
            int tongTien = 0;
            int tongSanPham = 0;
            foreach (GioHang sanPham in gioHang)
            {
                tongTien += sanPham.price * sanPham.quantity;
                tongSanPham += sanPham.quantity;
            }
            ViewBag.TongTien = tongTien;
            ViewBag.TongSanPham = tongSanPham;

            //Tạo hóa đơn mới
            hd.IDKH = kh.IDKH;
            hd.NGAYLAP = DateTime.Now;
            hd.TONGTIEN = tongTien;
            hd.TENKH = kh.TENKH;
            hd.DIACHI = (string)Session["DIACHI"];
            hd.GIAOHANG = true;
            hd.SDT = kh.SDT;
            hd.THANHTOAN = "Chua thanh toan";

            Session.Add("DIACHI", hd.DIACHI);
            Session.Add("NGAYLAP", hd.NGAYLAP);
            Session.Add("TENKH", hd.TENKH);

            db.HOADONs.Add(hd);
            db.SaveChanges();    
            Session["HOADON"] = hd;
           
            Session.Add("MAHOADON", hd.IDHD);
            return View(gioHang);
        }
        public ActionResult ReturnUrl()
        {
            string param = Request.QueryString.ToString().Substring(0, Request.QueryString.ToString().IndexOf("signature") - 1);
            param = Server.UrlDecode(param);
            MoMoSecurity crypto = new MoMoSecurity();
            string serectkey = ConfigurationManager.AppSettings["serectkey"].ToString();
            string signature = crypto.signSHA256(param, serectkey);

            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            KHACHHANG kh = (KHACHHANG)Session["TaiKhoan"];

            const string accountSid = "ACe3a8b773848d01d527c7b18a8a043af8";
            const string authToken = "637e8c0806e62e17009de4c6019cda1a";
            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber("+84" + kh.SDT);

            int tongTien = 0;
            int tongSanPham = 0;
            foreach (GioHang sanPham in gioHang)
            {
                tongTien += sanPham.price * sanPham.quantity;
                tongSanPham += sanPham.quantity;
            }
            ViewBag.TongTien = tongTien;
            ViewBag.TongSanPham = tongSanPham;

            HOADON ddh = (HOADON)Session["HOADON"];

            var thanhToan = db.HOADONs.Where(s => s.IDHD == ddh.IDHD).FirstOrDefault();
            db.Configuration.ValidateOnSaveEnabled = false;

            if (signature != Request["signature"].ToString())
            {
                ViewBag.message = "Thông tin Request không hợp lệ";
                return View(gioHang);
            }
            if (!Request.QueryString["errorCode"].Equals("0"))
            {
                string subject = "THANH TOÁN THẤT BẠI #" + ddh.IDHD;
                List<string> cc = new List<string>() { "thiendonggtvt@gmail.com" };
                StringBuilder sb = new StringBuilder();
                sb.Append($"<h2> ----- BQL Quản Lý Căn Tin UTC2 ----- </h2>");
                sb.Append($"<h3> Kính chào quý khách {kh.TENKH} </h3>");
                sb.Append("<p> Đơn hàng của bạn bị HỦY. Chi tiết đơn hàng như sau: </p>");
                sb.Append("<table>");

                // Nội dung Email
                foreach (GioHang sanPham in gioHang)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td> <strong> Tên sản phẩm </strong> </br> {sanPham.name}</td>");
                    sb.Append($"<td> <strong> Đơn giá </br> </strong>  {sanPham.price}</br> </td>");
                    sb.Append($"<td> <strong> Số lượng </strong>  </br> {sanPham.quantity} </br> </td>");
                    sb.Append($"  <td> <strong> Thành tiền </strong> </br> {sanPham.quantity * sanPham.price} </td>");
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                sb.Append($"<p> Tổng tiền: <strong> {tongTien} </strong> </p>");
                sb.Append("<p> Hình thức thanh toán: <strong> Momo </strong> </p>");
                sb.Append($"<p> Phòng nhận hàng: <strong> {thanhToan.DIACHI} </strong> </p>");
                sb.Append("<h2>Cảm ơn quý khách đã tin tưởng và ủng hộ! </h2>");

                // Gửi hóa đơn về email
                var mailSender = new EmailHepper();
                mailSender.Send(kh.EMAIL, subject, sb.ToString(), cc);

                var message = MessageResource.Create(
                         to,
                         from: new PhoneNumber("+13133671310"),
                         body: $"Xin chào " + kh.TENKH + ". Đơn hàng #" + thanhToan.IDHD + " của bạn bị hủy vì thanh toán thất bại. Tổng tiền: " + tongTien + ". Qúy khách vui lòng thanh toán lại!");

                return View(gioHang);
            }
            else
            {
                thanhToan.THANHTOAN = "Da thanh toan";
                db.SaveChanges();
                Session["GioHang"] = null;
            }

           
            Session["THANHTOAN"] = thanhToan.THANHTOAN;        
            ViewBag.ThanhToan = thanhToan.THANHTOAN;

          
            // Thêm CTHĐ nếu thanh toán = momo thành công
            if (thanhToan.THANHTOAN == "Da thanh toan")
            {

              foreach (var item in gioHang)
              {
                CHITIETHOADON cthd = new CHITIETHOADON();
                cthd.IDHD = thanhToan.IDHD;
                cthd.IDSP = item.id;
                cthd.SOLUONG = item.quantity;
                cthd.THANHTIEN = item.quantity * item.price;
                db.CHITIETHOADONs.Add(cthd);
                db.SaveChanges();
              }

                // Email

                string subject = "XÁC NHẬN ĐƠN HÀNG #" + ddh.IDHD;
                List<string> cc = new List<string>() { "thiendonggtvt@gmail.com" };
                StringBuilder sb = new StringBuilder();
                sb.Append($"<h2> ----- BQL Quản Lý Căn Tin UTC2 ----- </h2>");
                sb.Append($"<h3> Kính chào quý khách {kh.TENKH} </h3>");
                sb.Append("<p> Đơn hàng của bạn như sau: </p>");

                sb.Append("<table>");

                // Nội dung Email
                foreach (GioHang sanPham in gioHang)
                {
                    sb.Append("<tr>");
                    sb.Append($"<td> <strong> Tên sản phẩm </strong> </br> {sanPham.name}</td>");
                    sb.Append($"<td> <strong> Đơn giá </br> </strong>  {sanPham.price}</br> </td>");
                    sb.Append($"<td> <strong> Số lượng </strong>  </br> {sanPham.quantity} </br> </td>");
                    sb.Append($"  <td> <strong> Thành tiền </strong> </br> {sanPham.quantity * sanPham.price} </td>");
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                sb.Append($"<p> Tổng tiền: <strong> {tongTien} </strong> </p>");
                sb.Append("<p>  Hình thức thanh toán: <strong> Momo </strong> </p>");
                sb.Append($"<p> Trạng thái: <strong> {thanhToan.THANHTOAN} </strong> </p>");
                sb.Append($"<p> Phòng nhận hàng: <strong> {thanhToan.DIACHI} </strong> </p>");

                sb.Append("<h2>Cảm ơn quý khách đã tin tưởng và ủng hộ! </h2>");

                // Gửi hóa đơn về email
                var mailSender = new EmailHepper();
                mailSender.Send(kh.EMAIL, subject, sb.ToString(), cc);

                var message = MessageResource.Create(
                         to,
                         from: new PhoneNumber("+13133671310"),
                         body: $"Xin chào " + kh.TENKH + ". Đơn hàng #" + thanhToan.IDHD + " của bạn sẽ được giao trong ít phút nữa. Phòng: " + thanhToan.DIACHI + ". Tổng tiền: " + tongTien );
            }
           

                
            return View(gioHang);

        }

        public JsonResult NotifyUrl()
        {
            string param = "";//Request.Form.ToString().Substring(0, Request.Form.ToString().IndexOf("signature") - 1);
            param = "partner_code=" + Request["partner_code"] +
                    "&access_key=" + Request["access_key"] +
                    "&amount=" + Request["amount"] +
                    "&order_id=" + Request["order_id"] +
                    "&order_info=" + Request["order_info"] +
                    "&order_type=" + Request["order_type"] +
                    "&transaction_id=" + Request["transaction_id"] +
                    "&message=" + Request["message"] +
                    "&response_time=" + Request["response_time"] +
                    "&status_code=" + Request["status_code"];

            param = Server.UrlDecode(param);
            MoMoSecurity crypto = new MoMoSecurity();
            string serectkey = ConfigurationManager.AppSettings["serectkey"].ToString();
            string signature = crypto.signSHA256(param, serectkey);
            //Không được phép cập nhật trang thái đơn khi trạng đơn trong Database khác trạng đang chờ thanh toán
            //Trạng thái đơn kích nút thanh toán - Đang chờ thanh toán (-1)
            //Trạng thái giao dịch thành công (1)
            //Trạng thái giao dịch thất bại (0)

            if (signature != Request["signature"].ToString())
            {
                //Kiểm tra đơn hàng của các bạn trong database có khác trạng thái Đang chờ thanh toán hay không
                //Nếu mà bạn đã cập nhật trạng thái đơn hàng về (1) hoặc 0 rồi thì không cần phải cập nhật nữa
                //Nếu trạng thái đơn hàng của các bạn đang là chờ thanh toán thì các bạn cập nhật trạng thái  = 0 là thất bại ở đây

                //Khi nào thì mới cập nhật trạng thái đơn hàng?
            }
            string status_code = Request["status_code"].ToString();

            if ((status_code != "0"))
            {
                //Thất bại - Cập nhật trang thái đơn hàng
               
            }
            else
            {
                //Thành công - Cập nhật trang thái đơn hàng
              
            }
          
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult XacNhanDatHang()
        {
            var st = Session["UserDangNhap"];
            if (Convert.ToInt32(st) == 0)
            {
                return RedirectToAction("DangNhap", "User");
            }
            int tongTien = 0;
            int tongSanPham = 0;
            List<GioHang> gioHang = (List<GioHang>)Session["GioHang"];
            if (Session["GioHang"] != null)
            {
                
                foreach (GioHang sanPham in gioHang)
                {
                    tongTien += sanPham.price * sanPham.quantity;
                    tongSanPham += sanPham.quantity;
                }
                
            }
            ViewBag.TongSanPham = tongSanPham;
            ViewBag.TongTien = tongTien;
            Session["GioHang"] = null;
            return View(gioHang);
        }
       

    }
}