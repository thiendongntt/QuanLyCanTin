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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu(DateTimePicker dtpTuNgay, DateTimePicker dtpDenNgay)
        {
            InitializeComponent();        
            this.sp_getDataReportDoanhThuTableAdapter.Fill(this.DoanhThuDataSet.sp_getDataReportDoanhThu, dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
            this.reportViewer1.RefreshReport();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DoanhThuDataSet.sp_getDataReportDoanhThu' table. You can move, or remove it, as needed.
            
        }
    }
}
