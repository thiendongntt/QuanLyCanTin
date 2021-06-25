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
    public partial class UserNhapHangCuControl : UserControl
    {
        public UserNhapHangCuControl()
        {
            InitializeComponent();

            btnNhapHang.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\packing.png");
            btnNhapHang.ImageAlign = ContentAlignment.MiddleLeft;

            cbbNhaCungCap.DataSource = NhaCungCapBUS.Instance.getNhaCungCap();
            cbbNhaCungCap.DisplayMember = "TENNCC";
            cbbNhaCungCap.ValueMember = "IDNCC";

            load();
        }

        public void load()
        {
            dgvSanPham.DataSource = NhapHangBUS.Instance.getSanPham();
            dgvNhapHang.DataSource = NhapHangBUS.Instance.getNhapHang();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (lblIdSP.Text.Equals(""))
            {
                if (check())
                {
                    NhapHangDTO nh = new NhapHangDTO(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtSLNhap.Text), dtpNgayNhap.Value.Date, Convert.ToInt32(cbbNhaCungCap.SelectedValue));
                    if (NhapHangBUS.Instance.createNhapHang(nh))
                    {
                        SanPhamBUS.Instance.updateSLConLai(Convert.ToInt32(txtId.Text), Convert.ToInt32(txtSLNhap.Text));
                        MessageBox.Show("Nhập Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhập Thất bại");
                    }
                }
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSanPham.CurrentRow.Index;
            txtId.Text = dgvSanPham.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtGia.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            txtSLConLai.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();
            txtDonViTinh.Text = dgvSanPham.Rows[index].Cells[4].Value.ToString();
        }

        public bool check()
        {
            if (txtSLNhap.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return false;
            }
            return true;
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSLNhap.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số");
                txtSLNhap.Text = txtSLNhap.Text.Remove(txtSLNhap.Text.Length - 1);
            }
        }
    }
}
