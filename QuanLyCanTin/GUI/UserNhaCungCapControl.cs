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
    public partial class UserNhaCungCapControl : UserControl
    {
        public UserNhaCungCapControl()
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

            load();
        }

        public void load()
        {
            dgvNhaCungCap.DataSource = NhaCungCapBUS.Instance.getNhaCungCap();

            txtId.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(0, txtTen.Text, txtDiaChi.Text, txtSdt.Text, txtEmail.Text);
                if (NhaCungCapBUS.Instance.createNhaCungCap(ncc))
                {
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
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
                    NhaCungCapDTO ncc = new NhaCungCapDTO(Convert.ToInt32(txtId.Text), txtTen.Text, txtDiaChi.Text, txtSdt.Text, txtEmail.Text);
                    if (NhaCungCapBUS.Instance.updateNhaCungCap(ncc))
                    {
                        MessageBox.Show("Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                load();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkClick())
            {
                if (checkData())
                {
                    NhaCungCapDTO ncc = new NhaCungCapDTO(Convert.ToInt32(txtId.Text), txtTen.Text, txtDiaChi.Text, txtSdt.Text, txtEmail.Text);
                    if (NhaCungCapBUS.Instance.updateNhaCungCap(ncc))
                    {
                        MessageBox.Show("Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                load();
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhaCungCap.CurrentRow.Index;

            txtId.Text = dgvNhaCungCap.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dgvNhaCungCap.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.Rows[index].Cells[2].Value.ToString();
            txtSdt.Text = dgvNhaCungCap.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvNhaCungCap.Rows[index].Cells[4].Value.ToString();
        }

        public bool checkData()
        {
            if (txtTen.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSdt.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }

        public bool checkClick()
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp");
                return false;
            }
            return true;
        }
    }
}
