using BUS;
using DTO;
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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();

            btnClose.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\close-window.png");
            btnMinimize.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\minimize-window.png");
            ptbLogo.ImageLocation = "D:\\QuanLyCanTin\\Images\\utc2.png";

            btnLamMoi.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\reset.png");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;

            btnThem.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\add.png");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;

            btnSua.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\edit.png");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;

            btnXoa.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\delete.png");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;

            cbbChucVu.DataSource = ChucVuBUS.Instance.getChucVu();
            cbbChucVu.DisplayMember = "TENCV";
            cbbChucVu.ValueMember = "IDCV";

            load();
        }

        public void load()
        {
            dgvTaiKhoan.DataSource = TaiKhoanBUS.Instance.getTaiKhoan();

            txtIdTK.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            cbbChucVu.SelectedIndex = 0;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(0, txtTenDangNhap.Text, txtMatKhau.Text, Convert.ToInt32(cbbChucVu.SelectedValue));
                if (TaiKhoanBUS.Instance.createTaiKhoan(tk))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO(Convert.ToInt32(txtIdTK.Text), txtTenDangNhap.Text, txtMatKhau.Text, Convert.ToInt32(cbbChucVu.SelectedValue));
                if (TaiKhoanBUS.Instance.updateTaiKhoan(tk))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            load();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.deleteSanPham(Convert.ToInt32(txtIdTK.Text)))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            load();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTaiKhoan.CurrentRow.Index;
            txtIdTK.Text = dgvTaiKhoan.Rows[index].Cells[0].Value.ToString();
            txtTenDangNhap.Text = dgvTaiKhoan.Rows[index].Cells[1].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[index].Cells[2].Value.ToString();
            string chucVu = dgvTaiKhoan.Rows[index].Cells[3].Value.ToString();
            int idCV = 1;
            while (!ChucVuBUS.Instance.getTenCVByIdCV(idCV).Equals(chucVu))
            {
                idCV++;
            }
            cbbChucVu.SelectedValue = idCV;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool check()
        {
            if (txtTenDangNhap.Text.Equals("") || txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }
    }
}
