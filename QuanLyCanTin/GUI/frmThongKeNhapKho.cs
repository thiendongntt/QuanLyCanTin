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
    public partial class frmThongKeNhapKho : Form
    {
        public frmThongKeNhapKho(DateTimePicker dtpTuNgay, DateTimePicker dtpDenNgay)
        {
            InitializeComponent();
            this.sp_getDataReportNhapHangTableAdapter.Fill(this.NhapHangDataSet.sp_getDataReportNhapHang, dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
            this.reportViewer1.RefreshReport();
        }

        private void frmThongKeNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NhapHangDataSet.sp_getDataReportNhapHang' table. You can move, or remove it, as needed.
            
        }
    }
}
