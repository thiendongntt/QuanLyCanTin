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
    public partial class UserTraLuongControl : UserControl
    {
        public UserTraLuongControl()
        {
            InitializeComponent();

            btnTraLuong.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\pay.png");
            btnTraLuong.ImageAlign = ContentAlignment.MiddleLeft;

            load();
        }

        public void load()
        {
            dgvNhanVien.DataSource = TraLuongBUS.Instance.getNhanVien();
            dgvTraLuong.DataSource = TraLuongBUS.Instance.getTraLuong();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dgvNhanVien.CurrentRow.Index;
            txtId.Text = dgvNhanVien.Rows[n].Cells[0].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[n].Cells[1].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[n].Cells[2].Value.ToString();
            txtLuongCa.Text = dgvNhanVien.Rows[n].Cells[3].Value.ToString();

            txtSoBuoi.Text = TraLuongBUS.Instance.getSoBuoi(Convert.ToInt32(txtId.Text), dtpNgayBD.Value.Date, dtpNgayKT.Value.Date).ToString();
            int luongThuong;
            if (txtLuongThuong.Text.Equals(""))
            {
                luongThuong = 0;
            }
            else
            {
                luongThuong = Convert.ToInt32(txtLuongThuong.Text);
            }
            txtLuongTong.Text = ((Convert.ToInt32(txtSoBuoi.Text) * Convert.ToInt32(txtLuongCa.Text)) + luongThuong).ToString();
        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Equals(""))
            {
                TraLuongDTO tl = new TraLuongDTO(Convert.ToInt32(txtId.Text), dtpNgayBD.Value.Date, dtpNgayKT.Value.Date, Convert.ToInt32(txtSoBuoi.Text), Convert.ToInt32(txtLuongThuong.Text), Convert.ToInt32(txtLuongTong.Text));
                if (TraLuongBUS.Instance.createTraLuong(tl))
                {
                    MessageBox.Show("Trả lương thành công");
                }
                else
                {
                    MessageBox.Show("Trả lương thất bại");
                }
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            txtSoBuoi.Text = TraLuongBUS.Instance.getSoBuoi(Convert.ToInt32(txtId.Text), dtpNgayBD.Value.Date, dtpNgayKT.Value.Date).ToString();
            int luongThuong;
            if (txtLuongThuong.Text.Equals(""))
            {
                luongThuong = 0;
            }
            else
            {
                luongThuong = Convert.ToInt32(txtLuongThuong.Text);
            }
            txtLuongTong.Text = ((Convert.ToInt32(txtSoBuoi.Text) * Convert.ToInt32(txtLuongCa.Text)) + luongThuong).ToString();
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            txtSoBuoi.Text = TraLuongBUS.Instance.getSoBuoi(Convert.ToInt32(txtId.Text), dtpNgayBD.Value.Date, dtpNgayKT.Value.Date).ToString();
            int luongThuong;
            if (txtLuongThuong.Text.Equals(""))
            {
                luongThuong = 0;
            }
            else
            {
                luongThuong = Convert.ToInt32(txtLuongThuong.Text);
            }
            txtLuongTong.Text = ((Convert.ToInt32(txtSoBuoi.Text) * Convert.ToInt32(txtLuongCa.Text)) + luongThuong).ToString();
        }

        private void txtLuongThuong_TextChanged(object sender, EventArgs e)
        {
            txtSoBuoi.Text = TraLuongBUS.Instance.getSoBuoi(Convert.ToInt32(txtId.Text), dtpNgayBD.Value.Date, dtpNgayKT.Value.Date).ToString();
            int luongThuong;
            if (txtLuongThuong.Text.Equals(""))
            {
                luongThuong = 0;
            }
            else
            {
                luongThuong = Convert.ToInt32(txtLuongThuong.Text);
            }    
            txtLuongTong.Text = ((Convert.ToInt32(txtSoBuoi.Text) * Convert.ToInt32(txtLuongCa.Text)) + luongThuong).ToString();
        }
    }
}
