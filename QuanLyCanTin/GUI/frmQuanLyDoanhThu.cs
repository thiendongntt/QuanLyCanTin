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
    public partial class frmQuanLyDoanhThu : Form
    {
        public frmQuanLyDoanhThu()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            pbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            userThongKeDoanhThuControl.BringToFront();
            userThongKeDoanhThuControl.load();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            btnThongKeDoanhThu.BackColor = Color.White;
            btnThongKeDoanhThu.ForeColor = Color.Black;

            btnThongKeNhapKho.BackColor = Color.Navy;
            btnThongKeNhapKho.ForeColor = Color.White;

            userThongKeDoanhThuControl.BringToFront();
            userThongKeDoanhThuControl.load();
        }

        private void btnThongKeNhapKho_Click(object sender, EventArgs e)
        {
            btnThongKeDoanhThu.BackColor = Color.Navy;
            btnThongKeDoanhThu.ForeColor = Color.White;

            btnThongKeNhapKho.BackColor = Color.White;
            btnThongKeNhapKho.ForeColor = Color.Black;

            userThongKeNhapKhoControl.BringToFront();
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
