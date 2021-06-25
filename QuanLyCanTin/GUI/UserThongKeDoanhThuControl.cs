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
    public partial class UserThongKeDoanhThuControl : UserControl
    {
        public UserThongKeDoanhThuControl()
        {
            InitializeComponent();


            btnExcels.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\excels.png");
            btnExcels.ImageAlign = ContentAlignment.MiddleLeft;

            btnReportDoanhThu.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\print.png");
            btnReportDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;


            load();
        }

        public void load()
        {
            dgvThongKeDoanhThu.DataSource = ThongKeBUS.Instance.getAll();
            chartDoanhThu.Hide();
            lblBieuDoDoanhThu.Hide();
            chartTopSanPham.Hide();
            lblSPNhieuNhat.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Xuất ra thống kê từ ngày đến ngày
            dgvThongKeDoanhThu.DataSource = ThongKeBUS.Instance.getDonHangTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);
            
            // Tổng tiền
            lblTongTien.Text = "0";
            for (int i = 0; i < dgvThongKeDoanhThu.Rows.Count; i++)
            {
                lblTongTien.Text = (Convert.ToInt32(lblTongTien.Text) + Convert.ToInt32(dgvThongKeDoanhThu.Rows[i].Cells[2].Value)).ToString();
            }
        }

        private void btnChartDoanhThu_Click(object sender, EventArgs e)
        {
            if (cbChonBieuDo.Text == "")
            {
                MessageBox.Show("Vui lòng chọn biểu đồ!");
            }
            if (cbChonBieuDo.Text == "Tổng doanh thu theo ngày")
            {
                chartDoanhThu.Series["Doanh thu"].XValueMember = "NGAYLAP";
                chartDoanhThu.Series["Doanh thu"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                chartDoanhThu.Series["Doanh thu"].YValueMembers = "TONGTIEN";
                chartDoanhThu.Series["Doanh thu"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartDoanhThu.DataSource = ThongKeBUS.Instance.getDataChartDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
                chartDoanhThu.Show();
                lblBieuDoDoanhThu.Show();

                chartTopSanPham.Hide();
                lblSPNhieuNhat.Hide();
            }
            if (cbChonBieuDo.Text == "Sản phẩm bán nhiều nhất")
            {

                chartTopSanPham.Series["Số lượng"].XValueMember = "TENSP";
                chartTopSanPham.Series["Số lượng"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartTopSanPham.Series["Số lượng"].YValueMembers = "TONGSOLUONG";
                chartTopSanPham.Series["Số lượng"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                chartTopSanPham.DataSource = ThongKeBUS.Instance.getDataChartSanPhamBanChay(dtpTuNgay.Value, dtpDenNgay.Value);
                chartTopSanPham.Show();
                lblSPNhieuNhat.Show();

                chartDoanhThu.Hide();
                lblBieuDoDoanhThu.Hide();
            }
        }

        private void ToExcel(DataGridView dataGridView, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;


            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Thống kê doanh thu";

                // Export header
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Export content

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Save work book
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất file Excels thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcels_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExcels.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvThongKeDoanhThu, saveFileDialogExcels.FileName);
            }
        }

        private void btnReportDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frmReportThongKeDoanhThu = new frmThongKeDoanhThu(dtpTuNgay, dtpDenNgay);
            frmReportThongKeDoanhThu.ShowDialog();
        }
    }
}
