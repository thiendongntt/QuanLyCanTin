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
    public partial class frmQuanLyNhapHang : Form
    {
        public frmQuanLyNhapHang()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            pbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            userNhapHangMoiControl.BringToFront();
            userNhapHangMoiControl.load();
        }

        private void btnNhapHangMoi_Click(object sender, EventArgs e)
        {
            btnNhapHangMoi.BackColor = Color.White;
            btnNhapHangMoi.ForeColor = Color.Black;

            btnNhapHangCu.BackColor = Color.Navy;
            btnNhapHangCu.ForeColor = Color.White;

            btnNhaCungCap.BackColor = Color.Navy;
            btnNhaCungCap.ForeColor = Color.White;

            userNhapHangMoiControl.BringToFront();
            userNhapHangMoiControl.load();
        }

        private void btnNhapHangCu_Click(object sender, EventArgs e)
        {
            btnNhapHangMoi.BackColor = Color.Navy;
            btnNhapHangMoi.ForeColor = Color.White;

            btnNhapHangCu.BackColor = Color.White;
            btnNhapHangCu.ForeColor = Color.Black;

            btnNhaCungCap.BackColor = Color.Navy;
            btnNhaCungCap.ForeColor = Color.White;

            userNhapHangCuControl.BringToFront();
            userNhapHangCuControl.load();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            btnNhapHangMoi.BackColor = Color.Navy;
            btnNhapHangMoi.ForeColor = Color.White;

            btnNhapHangCu.BackColor = Color.Navy;
            btnNhapHangCu.ForeColor = Color.White;

            btnNhaCungCap.BackColor = Color.White;
            btnNhaCungCap.ForeColor = Color.Black;

            userNhaCungCapControl.BringToFront();
            userNhaCungCapControl.load();
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
