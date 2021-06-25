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
    public partial class UserNhapHangMoiControl : UserControl
    {
        public UserNhapHangMoiControl()
        {
            InitializeComponent();

            btnLamMoi.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\reset.png");
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;

            btnThemSP.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\add.png");
            btnThemSP.ImageAlign = ContentAlignment.MiddleLeft;

            btnSua.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\edit.png");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;

            btnXoa.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\delete.png");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;

            cbbDonViTinh.Items.Add("Cái");
            cbbDonViTinh.Items.Add("Trái");
            cbbDonViTinh.Items.Add("Hộp");
            cbbDonViTinh.Items.Add("Chai");
            cbbDonViTinh.Items.Add("Lon");
            cbbDonViTinh.Items.Add("Tô");

            cbbLoai.Items.Add("DoAnSang");
            cbbLoai.Items.Add("DoAnVat");
            cbbLoai.Items.Add("DoUong");
            cbbLoai.Items.Add("Khac");

            cbbNhaCungCap.DataSource = NhaCungCapBUS.Instance.getNhaCungCap();
            cbbNhaCungCap.DisplayMember = "TENNCC";
            cbbNhaCungCap.ValueMember = "IDNCC";

            load();
        }

        public void load()
        {
            dgvSanPham.DataSource = SanPhamBUS.Instance.getSanPham();

            txtId.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";
            cbbDonViTinh.SelectedIndex = 0;
            cbbLoai.SelectedIndex = 0;
            dtpNgayNhap.Value = DateTime.Now;
            cbbNhaCungCap.SelectedIndex = 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                SanPhamDTO sp = new SanPhamDTO(0, txtTen.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtSL.Text), cbbDonViTinh.SelectedItem.ToString(), cbbLoai.SelectedItem.ToString(), pbHinhAnhSP.ImageLocation);
                if (SanPhamBUS.Instance.createSanPham(sp))
                {
                    int idSP = SanPhamBUS.Instance.getIdSP(sp);
                    NhapHangDTO nh = new NhapHangDTO(idSP, Convert.ToInt32(txtSL.Text), dtpNgayNhap.Value.Date, Convert.ToInt32(cbbNhaCungCap.SelectedValue));
                    NhapHangBUS.Instance.createNhapHang(nh);
                    MessageBox.Show("Thêm Thành công");
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại");
                }
            }
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkClick())
            {
                if (checkData())
                {
                    SanPhamDTO sp = new SanPhamDTO(Convert.ToInt32(txtId.Text), txtTen.Text, Convert.ToInt32(txtGia.Text), Convert.ToInt32(txtSL.Text), cbbDonViTinh.SelectedItem.ToString(), cbbLoai.SelectedItem.ToString(), pbHinhAnhSP.ImageLocation);
                    if (SanPhamBUS.Instance.updateSanPham(sp))
                    {
                        MessageBox.Show("Sửa Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất bại");
                    }
                }
                load();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkClick())
            {
                if (SanPhamBUS.Instance.deleteSanPham(Convert.ToInt32(txtId.Text)))
                {
                    MessageBox.Show("Xóa Thành công");
                }
                else
                {
                    MessageBox.Show("Xóa Thất bại");
                }
                load();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string duongDan = "";
            OpenFileDialog ofl = new OpenFileDialog();
            ofl.Title = " Vui lòng chọn ảnh ^_^ ";
            ofl.Filter = " JPG|*.jpg|PNG|*.png|GIF|*gif";
            if (ofl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                duongDan = ofl.FileName;
                pbHinhAnhSP.ImageLocation = duongDan;
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSanPham.CurrentRow.Index;
            txtId.Text = dgvSanPham.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dgvSanPham.Rows[index].Cells[1].Value.ToString();
            txtGia.Text = dgvSanPham.Rows[index].Cells[2].Value.ToString();
            txtSL.Text = dgvSanPham.Rows[index].Cells[3].Value.ToString();

            string donViTinh = dgvSanPham.Rows[index].Cells[4].Value.ToString();
            int index1 = 0;
            cbbDonViTinh.SelectedIndex = index1;
            while (!cbbDonViTinh.SelectedItem.ToString().Equals(donViTinh))
            {
                index1++;
                cbbDonViTinh.SelectedIndex = index1;
            }

            string loai = dgvSanPham.Rows[index].Cells[5].Value.ToString();
            int index2 = 0;
            cbbLoai.SelectedIndex = index2;
            while (!cbbLoai.SelectedItem.ToString().Equals(loai))
            {
                index2++;
                cbbLoai.SelectedIndex = index2;
            }
            pbHinhAnhSP.ImageLocation = dgvSanPham.Rows[index].Cells[6].Value.ToString();
            dtpNgayNhap.Value = DateTime.Now;
            cbbNhaCungCap.SelectedIndex = 0;
        }

        public bool checkData()
        {
            if (txtTen.Text.Equals("") || txtGia.Text.Equals("") || txtSL.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }

        private bool checkClick()
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return false;
            }
            return true;
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGia.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số");
                txtGia.Text = txtGia.Text.Remove(txtGia.Text.Length - 1);
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSL.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số");
                txtSL.Text = txtSL.Text.Remove(txtSL.Text.Length - 1);
            }
        }
    }
}
