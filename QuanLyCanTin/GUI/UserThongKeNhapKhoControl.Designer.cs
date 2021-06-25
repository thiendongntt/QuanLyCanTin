
namespace GUI
{
    partial class UserThongKeNhapKhoControl
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
            this.btnBaoCaoNhapKho = new System.Windows.Forms.Button();
            this.btnXuatExcelNhapKho = new System.Windows.Forms.Button();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.saveFileDialogExcelsNhapKho = new System.Windows.Forms.SaveFileDialog();
            this.txtThongKeDoanhThu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongKeNhapKho = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaoCaoNhapKho
            // 
            this.btnBaoCaoNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNhapKho.Location = new System.Drawing.Point(1360, 890);
            this.btnBaoCaoNhapKho.Name = "btnBaoCaoNhapKho";
            this.btnBaoCaoNhapKho.Size = new System.Drawing.Size(160, 50);
            this.btnBaoCaoNhapKho.TabIndex = 17;
            this.btnBaoCaoNhapKho.Text = "Xuất báo cáo";
            this.btnBaoCaoNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCaoNhapKho.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhapKho.Click += new System.EventHandler(this.btnBaoCaoNhapKho_Click);
            // 
            // btnXuatExcelNhapKho
            // 
            this.btnXuatExcelNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcelNhapKho.Location = new System.Drawing.Point(1160, 890);
            this.btnXuatExcelNhapKho.Name = "btnXuatExcelNhapKho";
            this.btnXuatExcelNhapKho.Size = new System.Drawing.Size(160, 50);
            this.btnXuatExcelNhapKho.TabIndex = 16;
            this.btnXuatExcelNhapKho.Text = "Xuất Excels";
            this.btnXuatExcelNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcelNhapKho.UseVisualStyleBackColor = true;
            this.btnXuatExcelNhapKho.Click += new System.EventHandler(this.btnXuatExcelNhapKho_Click);
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AllowUserToAddRows = false;
            this.dgvNhapKho.AllowUserToDeleteRows = false;
            this.dgvNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Location = new System.Drawing.Point(100, 240);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.ReadOnly = true;
            this.dgvNhapKho.Size = new System.Drawing.Size(1420, 570);
            this.dgvNhapKho.TabIndex = 10;
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
            this.txtThongKeDoanhThu.Size = new System.Drawing.Size(1618, 80);
            this.txtThongKeDoanhThu.TabIndex = 44;
            this.txtThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            this.txtThongKeDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnThongKeNhapKho);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Location = new System.Drawing.Point(100, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 160);
            this.panel1.TabIndex = 45;
            // 
            // btnThongKeNhapKho
            // 
            this.btnThongKeNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhapKho.Location = new System.Drawing.Point(950, 65);
            this.btnThongKeNhapKho.Name = "btnThongKeNhapKho";
            this.btnThongKeNhapKho.Size = new System.Drawing.Size(150, 28);
            this.btnThongKeNhapKho.TabIndex = 20;
            this.btnThongKeNhapKho.Text = "Thống kê";
            this.btnThongKeNhapKho.UseVisualStyleBackColor = true;
            this.btnThongKeNhapKho.Click += new System.EventHandler(this.btnThongKeNhapKho_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(780, 65);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(128, 26);
            this.dtpDenNgay.TabIndex = 19;
            this.dtpDenNgay.Value = new System.DateTime(2021, 6, 20, 23, 14, 38, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chọn từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(500, 65);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(128, 26);
            this.dtpTuNgay.TabIndex = 16;
            // 
            // UserThongKeNhapKhoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtThongKeDoanhThu);
            this.Controls.Add(this.btnBaoCaoNhapKho);
            this.Controls.Add(this.btnXuatExcelNhapKho);
            this.Controls.Add(this.dgvNhapKho);
            this.Name = "UserThongKeNhapKhoControl";
            this.Size = new System.Drawing.Size(1618, 1028);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoNhapKho;
        private System.Windows.Forms.Button btnXuatExcelNhapKho;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcelsNhapKho;
        private System.Windows.Forms.TextBox txtThongKeDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKeNhapKho;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
    }
}
