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
    public partial class UserThongKeNhapKhoControl : UserControl
    {
        public UserThongKeNhapKhoControl()
        {
            InitializeComponent();

            btnXuatExcelNhapKho.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\excels.png");
            btnXuatExcelNhapKho.ImageAlign = ContentAlignment.MiddleLeft;

            btnBaoCaoNhapKho.Image = Image.FromFile("D:\\QuanLyCanTin\\Images\\print.png");
            btnBaoCaoNhapKho.ImageAlign = ContentAlignment.MiddleLeft;

            dgvNhapKho.DataSource = ThongKeBUS.Instance.getDataNhapKho();
        }

        private void btnThongKeNhapKho_Click(object sender, EventArgs e)
        {
            dgvNhapKho.DataSource = ThongKeBUS.Instance.getDataNhapKhoTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);

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

        private void btnXuatExcelNhapKho_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExcelsNhapKho.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dgvNhapKho, saveFileDialogExcelsNhapKho.FileName);
            }
        }

        private void btnBaoCaoNhapKho_Click(object sender, EventArgs e)
        {
            frmThongKeNhapKho frmReportThongKeNhapHang = new frmThongKeNhapKho(dtpTuNgay, dtpDenNgay);
            frmReportThongKeNhapHang.ShowDialog();
        }
    }
}
