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
    public partial class UserDanhSachGiaoHangControl : UserControl
    {
        int idHD;
        public UserDanhSachGiaoHangControl()
        {
            InitializeComponent();

            btnThanhCong.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\pass.png");
            btnThanhCong.ImageAlign = ContentAlignment.MiddleLeft;

            btnThatBai.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\fail.png");
            btnThatBai.ImageAlign = ContentAlignment.MiddleLeft;

            btnCTHD.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\details.png");
            btnCTHD.ImageAlign = ContentAlignment.MiddleLeft;

            load();
        }
        public void load()
        {
            dgvDSHD.DataSource = HoaDonBUS.Instance.getHoaDonCanGiao();
        }
        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSHD.CurrentRow.Index;
            idHD = Convert.ToInt32(dgvDSHD.Rows[index].Cells[0].Value);
        }

        private void btnThanhCong_Click(object sender, EventArgs e)
        {
            if (idHD > 0) 
            {
                if (HoaDonBUS.Instance.setThanhCongHoaDon(idHD))
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng");
            }
        }

        private void btnThatBai_Click(object sender, EventArgs e)
        {
            if (idHD > 0)
            {
                if (HoaDonBUS.Instance.setThatBaiHoaDon(idHD))
                {
                    DataTable dt = ChiTietHoaDonBUS.Instance.getChiTietHoaDon(idHD);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int idSP = Convert.ToInt32(dt.Rows[i][1]);
                        int soLuong = Convert.ToInt32(dt.Rows[i][2]);
                        SanPhamBUS.Instance.updateSLConLai(idSP, soLuong);
                    }
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng");
            }
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            if (idHD > 0)
            {
                frmChiTietHoaDon frmChiTietHoaDon = new frmChiTietHoaDon(idHD);
                frmChiTietHoaDon.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng");
            }
        }
    }
}
