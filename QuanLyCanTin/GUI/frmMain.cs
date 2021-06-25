using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain(int idCV)
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");

            btnQuanLyBanHang.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\hamburger.png");
            btnQuanLyBanHang.ImageAlign = ContentAlignment.MiddleLeft;

            btnQuanLyGiaoHang.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\delivery.png");
            btnQuanLyGiaoHang.ImageAlign = ContentAlignment.MiddleLeft;

            btnQuanLyKhoHang.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\warehouse.png");
            btnQuanLyKhoHang.ImageAlign = ContentAlignment.MiddleLeft;

            btnQuanLyNhanVien.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\payroll.png");
            btnQuanLyNhanVien.ImageAlign = ContentAlignment.MiddleLeft;

            btnQuanLyDoanhThu.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\chart.png");
            btnQuanLyDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;

            btnQuanLyTaiKhoan.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\account.png");
            btnQuanLyTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;

            if (idCV == 1)
            {
                btnQuanLyBanHang.Enabled = true;
                btnQuanLyGiaoHang.Enabled = true;
                btnQuanLyKhoHang.Enabled = true;
                btnQuanLyNhanVien.Enabled = true;
                btnQuanLyDoanhThu.Enabled = true;
                btnQuanLyTaiKhoan.Enabled = false;
            }
            else if (idCV == 2)
            {
                btnQuanLyBanHang.Enabled = true;
                btnQuanLyGiaoHang.Enabled = false;
                btnQuanLyKhoHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyDoanhThu.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
            }
            else if (idCV == 3)
            {
                btnQuanLyBanHang.Enabled = false;
                btnQuanLyGiaoHang.Enabled = true;
                btnQuanLyKhoHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyDoanhThu.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
            }
            else if (idCV == 4)
            {
                btnQuanLyBanHang.Enabled = false;
                btnQuanLyGiaoHang.Enabled = false;
                btnQuanLyKhoHang.Enabled = false;
                btnQuanLyNhanVien.Enabled = false;
                btnQuanLyDoanhThu.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = true;
            }
        }

        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            frmQuanLyBanHang frmQuanLyBanHang = new frmQuanLyBanHang();
            frmQuanLyBanHang.Show();
        }

        private void btnQuanLyGiaoHang_Click(object sender, EventArgs e)
        {
            frmQuanLyGiaoHang frmQuanLyGiaoHang = new frmQuanLyGiaoHang();
            frmQuanLyGiaoHang.Show();
        }

        private void btnQuanLyKhoHang_Click(object sender, EventArgs e)
        {
            frmQuanLyNhapHang frmQuanLyNhapHang = new frmQuanLyNhapHang();
            frmQuanLyNhapHang.Show();
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            frmQuanLyNhanVien.Show();
        }

        private void btnQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            frmQuanLyDoanhThu frmQuanLyDoanhThu = new frmQuanLyDoanhThu();
            frmQuanLyDoanhThu.Show();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQuanLyTaiKhoan = new frmQuanLyTaiKhoan();
            frmQuanLyTaiKhoan.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
