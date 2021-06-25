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
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            pbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            userQuanLyNhanVienControl.BringToFront();
            userQuanLyNhanVienControl.load();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            btnQLNV.BackColor = Color.White;
            btnQLNV.ForeColor = Color.Black;

            btnChamCong.BackColor = Color.Navy;
            btnChamCong.ForeColor = Color.White;

            btnTraLuong.BackColor = Color.Navy;
            btnTraLuong.ForeColor = Color.White;

            userQuanLyNhanVienControl.BringToFront();
            userQuanLyNhanVienControl.load();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            btnQLNV.BackColor = Color.Navy;
            btnQLNV.ForeColor = Color.White;

            btnChamCong.BackColor = Color.White;
            btnChamCong.ForeColor = Color.Black;

            btnTraLuong.BackColor = Color.Navy;
            btnTraLuong.ForeColor = Color.White;

            userChamCongControl.BringToFront();
            userChamCongControl.load();
        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            btnQLNV.BackColor = Color.Navy;
            btnQLNV.ForeColor = Color.White;

            btnChamCong.BackColor = Color.Navy;
            btnChamCong.ForeColor = Color.White;

            btnTraLuong.BackColor = Color.White;
            btnTraLuong.ForeColor = Color.Black;

            userTraLuongControl.BringToFront();
            userTraLuongControl.load();
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
