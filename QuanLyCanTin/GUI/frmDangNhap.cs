using BUS;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            pbBanner.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2_banner.png";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = TaiKhoanBUS.Instance.getTaiKhoanByTenDangNhapAndMatKhau(txtTenDangNhap.Text, txtMatKhau.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                int idCV = Convert.ToInt32(dt.Rows[0][3]);
                frmMain frmMain = new frmMain(idCV);
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
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
