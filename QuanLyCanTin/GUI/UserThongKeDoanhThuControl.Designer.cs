
namespace GUI
{
    partial class UserThongKeDoanhThuControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnReportDoanhThu = new System.Windows.Forms.Button();
            this.btnExcels = new System.Windows.Forms.Button();
            this.saveFileDialogExcels = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongKeDoanhThu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.txtThongKeDoanhThu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSPNhieuNhat = new System.Windows.Forms.Label();
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbChonBieuDo = new System.Windows.Forms.ComboBox();
            this.btnChartDoanhThu = new System.Windows.Forms.Button();
            this.lblBieuDoDoanhThu = new System.Windows.Forms.Label();
            this.txtBieuDo = new System.Windows.Forms.TextBox();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoanhThu)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportDoanhThu
            // 
            this.btnReportDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportDoanhThu.Location = new System.Drawing.Point(740, 900);
            this.btnReportDoanhThu.Name = "btnReportDoanhThu";
            this.btnReportDoanhThu.Size = new System.Drawing.Size(160, 50);
            this.btnReportDoanhThu.TabIndex = 34;
            this.btnReportDoanhThu.Text = "Xuất báo cáo";
            this.btnReportDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportDoanhThu.UseVisualStyleBackColor = true;
            this.btnReportDoanhThu.Click += new System.EventHandler(this.btnReportDoanhThu_Click);
            // 
            // btnExcels
            // 
            this.btnExcels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcels.Location = new System.Drawing.Point(540, 900);
            this.btnExcels.Name = "btnExcels";
            this.btnExcels.Size = new System.Drawing.Size(160, 50);
            this.btnExcels.TabIndex = 33;
            this.btnExcels.Text = "Xuất Excels";
            this.btnExcels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcels.UseVisualStyleBackColor = true;
            this.btnExcels.Click += new System.EventHandler(this.btnExcels_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvThongKeDoanhThu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtThongKeDoanhThu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnReportDoanhThu);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.btnExcels);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 1030);
            this.panel1.TabIndex = 37;
            // 
            // dgvThongKeDoanhThu
            // 
            this.dgvThongKeDoanhThu.AllowUserToAddRows = false;
            this.dgvThongKeDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeDoanhThu.Location = new System.Drawing.Point(0, 250);
            this.dgvThongKeDoanhThu.Name = "dgvThongKeDoanhThu";
            this.dgvThongKeDoanhThu.Size = new System.Drawing.Size(920, 520);
            this.dgvThongKeDoanhThu.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Controls.Add(this.dtpDenNgay);
            this.panel3.Controls.Add(this.dtpTuNgay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTuNgay);
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 170);
            this.panel3.TabIndex = 44;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(690, 70);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 28);
            this.btnThongKe.TabIndex = 48;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(490, 70);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(150, 26);
            this.dtpDenNgay.TabIndex = 46;
            this.dtpDenNgay.Value = new System.DateTime(2021, 6, 20, 23, 14, 51, 0);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(210, 70);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(150, 26);
            this.dtpTuNgay.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "đến ngày";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(80, 70);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(103, 20);
            this.lblTuNgay.TabIndex = 42;
            this.lblTuNgay.Text = "Chọn từ ngày";
            // 
            // txtThongKeDoanhThu
            // 
            this.txtThongKeDoanhThu.BackColor = System.Drawing.Color.White;
            this.txtThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtThongKeDoanhThu.Enabled = false;
            this.txtThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongKeDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.txtThongKeDoanhThu.Multiline = true;
            this.txtThongKeDoanhThu.Name = "txtThongKeDoanhThu";
            this.txtThongKeDoanhThu.ReadOnly = true;
            this.txtThongKeDoanhThu.Size = new System.Drawing.Size(918, 80);
            this.txtThongKeDoanhThu.TabIndex = 43;
            this.txtThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            this.txtThongKeDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(847, 820);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "VNĐ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(770, 820);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(19, 20);
            this.lblTongTien.TabIndex = 39;
            this.lblTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 820);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tổng tiền";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSPNhieuNhat);
            this.panel2.Controls.Add(this.chartTopSanPham);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblBieuDoDoanhThu);
            this.panel2.Controls.Add(this.txtBieuDo);
            this.panel2.Controls.Add(this.chartDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(920, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 1030);
            this.panel2.TabIndex = 38;
            // 
            // lblSPNhieuNhat
            // 
            this.lblSPNhieuNhat.AutoSize = true;
            this.lblSPNhieuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPNhieuNhat.Location = new System.Drawing.Point(240, 650);
            this.lblSPNhieuNhat.Name = "lblSPNhieuNhat";
            this.lblSPNhieuNhat.Size = new System.Drawing.Size(278, 20);
            this.lblSPNhieuNhat.TabIndex = 52;
            this.lblSPNhieuNhat.Text = "Biểu đồ sản phẩm bán nhiều nhất";
            // 
            // chartTopSanPham
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTopSanPham.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTopSanPham.Legends.Add(legend3);
            this.chartTopSanPham.Location = new System.Drawing.Point(40, 300);
            this.chartTopSanPham.Name = "chartTopSanPham";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Số lượng";
            series3.YValuesPerPoint = 2;
            this.chartTopSanPham.Series.Add(series3);
            this.chartTopSanPham.Size = new System.Drawing.Size(620, 320);
            this.chartTopSanPham.TabIndex = 51;
            this.chartTopSanPham.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbChonBieuDo);
            this.panel4.Controls.Add(this.btnChartDoanhThu);
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 170);
            this.panel4.TabIndex = 50;
            // 
            // cbChonBieuDo
            // 
            this.cbChonBieuDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonBieuDo.FormattingEnabled = true;
            this.cbChonBieuDo.Items.AddRange(new object[] {
            "Tổng doanh thu theo ngày",
            "Sản phẩm bán nhiều nhất"});
            this.cbChonBieuDo.Location = new System.Drawing.Point(120, 70);
            this.cbChonBieuDo.Name = "cbChonBieuDo";
            this.cbChonBieuDo.Size = new System.Drawing.Size(270, 28);
            this.cbChonBieuDo.TabIndex = 49;
            // 
            // btnChartDoanhThu
            // 
            this.btnChartDoanhThu.Location = new System.Drawing.Point(460, 70);
            this.btnChartDoanhThu.Name = "btnChartDoanhThu";
            this.btnChartDoanhThu.Size = new System.Drawing.Size(120, 28);
            this.btnChartDoanhThu.TabIndex = 48;
            this.btnChartDoanhThu.Text = "Xem biểu đồ";
            this.btnChartDoanhThu.UseVisualStyleBackColor = true;
            this.btnChartDoanhThu.Click += new System.EventHandler(this.btnChartDoanhThu_Click);
            // 
            // lblBieuDoDoanhThu
            // 
            this.lblBieuDoDoanhThu.AutoSize = true;
            this.lblBieuDoDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBieuDoDoanhThu.Location = new System.Drawing.Point(300, 650);
            this.lblBieuDoDoanhThu.Name = "lblBieuDoDoanhThu";
            this.lblBieuDoDoanhThu.Size = new System.Drawing.Size(156, 20);
            this.lblBieuDoDoanhThu.TabIndex = 46;
            this.lblBieuDoDoanhThu.Text = "Biểu đồ doanh thu";
            // 
            // txtBieuDo
            // 
            this.txtBieuDo.BackColor = System.Drawing.Color.White;
            this.txtBieuDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBieuDo.Enabled = false;
            this.txtBieuDo.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBieuDo.Location = new System.Drawing.Point(0, 0);
            this.txtBieuDo.Multiline = true;
            this.txtBieuDo.Name = "txtBieuDo";
            this.txtBieuDo.ReadOnly = true;
            this.txtBieuDo.Size = new System.Drawing.Size(698, 80);
            this.txtBieuDo.TabIndex = 44;
            this.txtBieuDo.Text = "BIỂU ĐỒ";
            this.txtBieuDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chartDoanhThu
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend4);
            this.chartDoanhThu.Location = new System.Drawing.Point(40, 300);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chartDoanhThu.Series.Add(series4);
            this.chartDoanhThu.Size = new System.Drawing.Size(620, 320);
            this.chartDoanhThu.TabIndex = 39;
            this.chartDoanhThu.Text = "chart1";
            // 
            // UserThongKeDoanhThuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserThongKeDoanhThuControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeDoanhThu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReportDoanhThu;
        private System.Windows.Forms.Button btnExcels;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcels;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.TextBox txtThongKeDoanhThu;
        private System.Windows.Forms.Label lblBieuDoDoanhThu;
        private System.Windows.Forms.TextBox txtBieuDo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DataGridView dgvThongKeDoanhThu;
        private System.Windows.Forms.Label lblSPNhieuNhat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSanPham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbChonBieuDo;
        private System.Windows.Forms.Button btnChartDoanhThu;
    }
}
