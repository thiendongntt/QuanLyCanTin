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
    public partial class frmQuanLyGiaoHang : Form
    {
        public frmQuanLyGiaoHang()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            pbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            userDanhSachGiaoHangControl.BringToFront();
            userDanhSachGiaoHangControl.load();
        }

        private void btnDSGH_Click(object sender, EventArgs e)
        {
            btnDSGH.BackColor = Color.White;
            btnDSGH.ForeColor = Color.Black;

            btnLSGH.BackColor = Color.Navy;
            btnLSGH.ForeColor = Color.White;

            userDanhSachGiaoHangControl.BringToFront();
            userDanhSachGiaoHangControl.load();
        }

        private void btnLSGH_Click(object sender, EventArgs e)
        {
            btnDSGH.BackColor = Color.Navy;
            btnDSGH.ForeColor = Color.White;

            btnLSGH.BackColor = Color.White;
            btnLSGH.ForeColor = Color.Black;

            userLichSuGiaoHangControl.BringToFront();
            userLichSuGiaoHangControl.load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
