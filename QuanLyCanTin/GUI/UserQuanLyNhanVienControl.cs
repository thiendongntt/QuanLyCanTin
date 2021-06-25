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
    public partial class UserQuanLyNhanVienControl : UserControl
    {
        public UserQuanLyNhanVienControl()
        {
            InitializeComponent();

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
            dgvNhanVien.DataSource = NhanVienBUS.Instance.getNhanVien();

            txtIdNV.Text = "";
            txtTenNV.Text = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
            cbbChucVu.SelectedIndex = 0;
            txtLuongCa.Text = "";
            pbHinhAnhNV.ImageLocation = "";
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
                pbHinhAnhNV.ImageLocation = duongDan;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (rdbNam.Checked)
                {
                    NhanVienDTO nv = new NhanVienDTO(0, txtTenNV.Text, rdbNam.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtSdt.Text, txtEmail.Text, Convert.ToInt32(cbbChucVu.SelectedValue), Convert.ToInt32(txtLuongCa.Text), pbHinhAnhNV.ImageLocation);
                    if (NhanVienBUS.Instance.createNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (rdbNu.Checked)
                {
                    NhanVienDTO nv = new NhanVienDTO(0, txtTenNV.Text, rdbNu.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtSdt.Text, txtEmail.Text, Convert.ToInt32(cbbChucVu.SelectedValue), Convert.ToInt32(txtLuongCa.Text), pbHinhAnhNV.ImageLocation);
                    if (NhanVienBUS.Instance.createNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
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
                    if (rdbNam.Checked)
                    {
                        NhanVienDTO nv = new NhanVienDTO(Convert.ToInt32(txtIdNV.Text), txtTenNV.Text, rdbNam.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtSdt.Text, txtEmail.Text, Convert.ToInt32(cbbChucVu.SelectedValue), Convert.ToInt32(txtLuongCa.Text), pbHinhAnhNV.ImageLocation);
                        if (NhanVienBUS.Instance.updateNhanVien(nv))
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                    else if (rdbNu.Checked)
                    {
                        NhanVienDTO nv = new NhanVienDTO(Convert.ToInt32(txtIdNV.Text), txtTenNV.Text, rdbNu.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtSdt.Text, txtEmail.Text, Convert.ToInt32(cbbChucVu.SelectedValue), Convert.ToInt32(txtLuongCa.Text), pbHinhAnhNV.ImageLocation);
                        if (NhanVienBUS.Instance.updateNhanVien(nv))
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                }
                load();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkClick())
            {
                if (NhanVienBUS.Instance.deleteNhanVien(Convert.ToInt32(txtIdNV.Text)))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                load();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.CurrentRow.Index;
            txtIdNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            string gioiTinh = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            if (rdbNam.Text.Equals(gioiTinh))
            {
                rdbNam.Checked = true;
            }
            else if (rdbNu.Text.Equals(gioiTinh))
            {
                rdbNu.Checked = true;
            }
            dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[index].Cells[3].Value);
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtSdt.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            string chucVu = dgvNhanVien.Rows[index].Cells[7].Value.ToString();
            int idCV = 1;
            while (!ChucVuBUS.Instance.getTenCVByIdCV(idCV).Equals(chucVu))
            {
                idCV++;
            }
            cbbChucVu.SelectedValue = idCV;
            txtLuongCa.Text = dgvNhanVien.Rows[index].Cells[8].Value.ToString();
            pbHinhAnhNV.ImageLocation = dgvNhanVien.Rows[index].Cells[9].Value.ToString();
        }

        private bool checkData()
        {
            if (txtTenNV.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSdt.Text.Equals("") || txtEmail.Text.Equals("") || txtLuongCa.Text.Equals("") || !rdbNam.Checked && !rdbNu.Checked)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }

        private bool checkClick()
        {
            if (txtIdNV.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
                return false;
            }
            return true;
        }

        private void txtLuongCa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLuongCa.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số");
                txtLuongCa.Text = txtLuongCa.Text.Remove(txtLuongCa.Text.Length - 1);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBUS.Instance.timKiemNhanVien(txtTimKiem.Text);
        }
    }
}
