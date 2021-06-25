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
    public partial class UserLichSuGiaoHangControl : UserControl
    {
        int idHD;
        public UserLichSuGiaoHangControl()
        {
            InitializeComponent();

            btnCTHD.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\details.png");
            btnCTHD.ImageAlign = ContentAlignment.MiddleLeft;

            load();
        }

        public void load()
        {
            dgvDSHD.DataSource = HoaDonBUS.Instance.getHoaDonDaGiao();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSHD.CurrentRow.Index;
            idHD = Convert.ToInt32(dgvDSHD.Rows[index].Cells[0].Value);
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
