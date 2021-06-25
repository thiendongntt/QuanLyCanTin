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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon(DataTable dtCTHD, int tongTien)
        {
            InitializeComponent();

            dgvCTHD.DataSource = dtCTHD;
            txtTongTien.Text = tongTien.ToString();
        }

        private void rdbMuaTaiQuan_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtTenKH.Enabled = false;
            txtSdt.Text = "";
            txtSdt.Enabled = false;
            txtDiaChi.Text = "";
            txtDiaChi.Enabled = false;
            txtGhiChu.Text = "";
            txtGhiChu.Enabled = false;
        }

        private void rdbDatHang_CheckedChanged(object sender, EventArgs e)
        {
            txtTenKH.Enabled = true;
            txtSdt.Enabled = true;
            txtDiaChi.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            bool giaoHang = false;
            string trangThai = "";
            if (rdbDatHang.Checked)
            {
                giaoHang = true;
                trangThai = "Đang giao";
            }
            else if (rdbMuaTaiQuan.Checked)
            {
                giaoHang = false;
                trangThai = "";
            }
            HoaDonDTO hd = new HoaDonDTO(0, dtpNgayLap.Value.Date, Convert.ToInt32(txtTongTien.Text), giaoHang, txtTenKH.Text, txtSdt.Text, txtDiaChi.Text, txtGhiChu.Text, trangThai, 0);
            if (HoaDonBUS.Instance.createHoaDon(hd))
            {
                int idHD = HoaDonBUS.Instance.getIdHD(hd);
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO(idHD, Convert.ToInt32(dgvCTHD.Rows[i].Cells[0].Value), Convert.ToInt32(dgvCTHD.Rows[i].Cells[3].Value), Convert.ToInt32(dgvCTHD.Rows[i].Cells[4].Value));
                    ChiTietHoaDonBUS.Instance.createChiTietHoaDon(cthd);
                    int idSP = Convert.ToInt32(dgvCTHD.Rows[i].Cells[0].Value);
                    int soLuong = -Convert.ToInt32(dgvCTHD.Rows[i].Cells[3].Value);
                    SanPhamBUS.Instance.updateSLConLai(idSP, soLuong);
                }
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
