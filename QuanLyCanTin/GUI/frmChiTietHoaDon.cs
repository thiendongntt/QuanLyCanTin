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
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon(int idHD)
        {
            InitializeComponent();

            dgvCTHD.DataSource = ChiTietHoaDonBUS.Instance.getChiTietHoaDon(idHD);
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
