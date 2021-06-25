
namespace GUI
{
    partial class UserTraLuongControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDSTL = new System.Windows.Forms.TextBox();
            this.dgvTraLuong = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTraLuong = new System.Windows.Forms.Button();
            this.txtLuongTong = new System.Windows.Forms.TextBox();
            this.txtLuongThuong = new System.Windows.Forms.TextBox();
            this.txtSoBuoi = new System.Windows.Forms.TextBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblLuongTong = new System.Windows.Forms.Label();
            this.lblLuongThuong = new System.Windows.Forms.Label();
            this.lblSoBuoi = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.txtDSNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.txtLuongCa = new System.Windows.Forms.TextBox();
            this.lblLuongCa = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraLuong)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDSTL);
            this.panel2.Controls.Add(this.dgvTraLuong);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1620, 515);
            this.panel2.TabIndex = 5;
            // 
            // txtDSTL
            // 
            this.txtDSTL.BackColor = System.Drawing.Color.White;
            this.txtDSTL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDSTL.Enabled = false;
            this.txtDSTL.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSTL.Location = new System.Drawing.Point(500, 0);
            this.txtDSTL.Multiline = true;
            this.txtDSTL.Name = "txtDSTL";
            this.txtDSTL.ReadOnly = true;
            this.txtDSTL.Size = new System.Drawing.Size(1118, 80);
            this.txtDSTL.TabIndex = 27;
            this.txtDSTL.Text = "DANH SÁCH TRẢ LƯƠNG";
            this.txtDSTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvTraLuong
            // 
            this.dgvTraLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraLuong.Location = new System.Drawing.Point(500, 81);
            this.dgvTraLuong.Name = "dgvTraLuong";
            this.dgvTraLuong.Size = new System.Drawing.Size(1118, 432);
            this.dgvTraLuong.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnTraLuong);
            this.panel4.Controls.Add(this.txtLuongTong);
            this.panel4.Controls.Add(this.txtLuongThuong);
            this.panel4.Controls.Add(this.txtSoBuoi);
            this.panel4.Controls.Add(this.dtpNgayKT);
            this.panel4.Controls.Add(this.dtpNgayBD);
            this.panel4.Controls.Add(this.lblLuongTong);
            this.panel4.Controls.Add(this.lblLuongThuong);
            this.panel4.Controls.Add(this.lblSoBuoi);
            this.panel4.Controls.Add(this.lblNgayKT);
            this.panel4.Controls.Add(this.lblNgayBD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 513);
            this.panel4.TabIndex = 4;
            // 
            // btnTraLuong
            // 
            this.btnTraLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraLuong.Location = new System.Drawing.Point(325, 420);
            this.btnTraLuong.Name = "btnTraLuong";
            this.btnTraLuong.Size = new System.Drawing.Size(130, 60);
            this.btnTraLuong.TabIndex = 12;
            this.btnTraLuong.Text = "Trả lương";
            this.btnTraLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraLuong.UseVisualStyleBackColor = true;
            this.btnTraLuong.Click += new System.EventHandler(this.btnTraLuong_Click);
            // 
            // txtLuongTong
            // 
            this.txtLuongTong.Enabled = false;
            this.txtLuongTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongTong.Location = new System.Drawing.Point(185, 360);
            this.txtLuongTong.Name = "txtLuongTong";
            this.txtLuongTong.Size = new System.Drawing.Size(100, 26);
            this.txtLuongTong.TabIndex = 10;
            // 
            // txtLuongThuong
            // 
            this.txtLuongThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongThuong.Location = new System.Drawing.Point(185, 290);
            this.txtLuongThuong.Name = "txtLuongThuong";
            this.txtLuongThuong.Size = new System.Drawing.Size(100, 26);
            this.txtLuongThuong.TabIndex = 9;
            this.txtLuongThuong.Text = "0";
            this.txtLuongThuong.TextChanged += new System.EventHandler(this.txtLuongThuong_TextChanged);
            // 
            // txtSoBuoi
            // 
            this.txtSoBuoi.Enabled = false;
            this.txtSoBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoBuoi.Location = new System.Drawing.Point(185, 220);
            this.txtSoBuoi.Name = "txtSoBuoi";
            this.txtSoBuoi.Size = new System.Drawing.Size(100, 26);
            this.txtSoBuoi.TabIndex = 8;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Location = new System.Drawing.Point(185, 150);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(270, 26);
            this.dtpNgayKT.TabIndex = 6;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Location = new System.Drawing.Point(185, 80);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(270, 26);
            this.dtpNgayBD.TabIndex = 5;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged);
            // 
            // lblLuongTong
            // 
            this.lblLuongTong.AutoSize = true;
            this.lblLuongTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongTong.Location = new System.Drawing.Point(55, 360);
            this.lblLuongTong.Name = "lblLuongTong";
            this.lblLuongTong.Size = new System.Drawing.Size(90, 20);
            this.lblLuongTong.TabIndex = 4;
            this.lblLuongTong.Text = "Lương tổng";
            // 
            // lblLuongThuong
            // 
            this.lblLuongThuong.AutoSize = true;
            this.lblLuongThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongThuong.Location = new System.Drawing.Point(55, 290);
            this.lblLuongThuong.Name = "lblLuongThuong";
            this.lblLuongThuong.Size = new System.Drawing.Size(108, 20);
            this.lblLuongThuong.TabIndex = 3;
            this.lblLuongThuong.Text = "Lương thưởng";
            // 
            // lblSoBuoi
            // 
            this.lblSoBuoi.AutoSize = true;
            this.lblSoBuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBuoi.Location = new System.Drawing.Point(55, 220);
            this.lblSoBuoi.Name = "lblSoBuoi";
            this.lblSoBuoi.Size = new System.Drawing.Size(108, 20);
            this.lblSoBuoi.TabIndex = 2;
            this.lblSoBuoi.Text = "Số buổi đi làm";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKT.Location = new System.Drawing.Point(55, 150);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(106, 20);
            this.lblNgayKT.TabIndex = 1;
            this.lblNgayKT.Text = "Ngày kết thúc";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBD.Location = new System.Drawing.Point(55, 80);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(103, 20);
            this.lblNgayBD.TabIndex = 0;
            this.lblNgayBD.Text = "Ngày bắt đầu";
            // 
            // txtDSNV
            // 
            this.txtDSNV.BackColor = System.Drawing.Color.White;
            this.txtDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDSNV.Enabled = false;
            this.txtDSNV.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSNV.Location = new System.Drawing.Point(500, 0);
            this.txtDSNV.Multiline = true;
            this.txtDSNV.Name = "txtDSNV";
            this.txtDSNV.ReadOnly = true;
            this.txtDSNV.Size = new System.Drawing.Size(1118, 80);
            this.txtDSNV.TabIndex = 27;
            this.txtDSNV.Text = "DANH SÁCH NHÂN VIÊN";
            this.txtDSNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDSNV);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 515);
            this.panel1.TabIndex = 4;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.Location = new System.Drawing.Point(500, 80);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1118, 433);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtThongTin);
            this.panel3.Controls.Add(this.txtLuongCa);
            this.panel3.Controls.Add(this.lblLuongCa);
            this.panel3.Controls.Add(this.txtChucVu);
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.lblChucVu);
            this.panel3.Controls.Add(this.lblTen);
            this.panel3.Controls.Add(this.lblId);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 513);
            this.panel3.TabIndex = 3;
            // 
            // txtThongTin
            // 
            this.txtThongTin.BackColor = System.Drawing.Color.White;
            this.txtThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtThongTin.Enabled = false;
            this.txtThongTin.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(0, 0);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.ReadOnly = true;
            this.txtThongTin.Size = new System.Drawing.Size(498, 80);
            this.txtThongTin.TabIndex = 28;
            this.txtThongTin.Text = "THÔNG TIN";
            this.txtThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLuongCa
            // 
            this.txtLuongCa.Enabled = false;
            this.txtLuongCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCa.Location = new System.Drawing.Point(185, 360);
            this.txtLuongCa.Name = "txtLuongCa";
            this.txtLuongCa.Size = new System.Drawing.Size(170, 26);
            this.txtLuongCa.TabIndex = 7;
            // 
            // lblLuongCa
            // 
            this.lblLuongCa.AutoSize = true;
            this.lblLuongCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuongCa.Location = new System.Drawing.Point(55, 360);
            this.lblLuongCa.Name = "lblLuongCa";
            this.lblLuongCa.Size = new System.Drawing.Size(75, 20);
            this.lblLuongCa.TabIndex = 6;
            this.lblLuongCa.Text = "Lương ca";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(185, 290);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(170, 26);
            this.txtChucVu.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(185, 220);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(270, 26);
            this.txtTen.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(185, 150);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(55, 290);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(66, 20);
            this.lblChucVu.TabIndex = 2;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(55, 220);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(55, 150);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // UserTraLuongControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserTraLuongControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraLuong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTraLuong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTraLuong;
        private System.Windows.Forms.TextBox txtLuongTong;
        private System.Windows.Forms.TextBox txtLuongThuong;
        private System.Windows.Forms.TextBox txtSoBuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblLuongTong;
        private System.Windows.Forms.Label lblLuongThuong;
        private System.Windows.Forms.Label lblSoBuoi;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.TextBox txtDSTL;
        private System.Windows.Forms.TextBox txtDSNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.TextBox txtLuongCa;
        private System.Windows.Forms.Label lblLuongCa;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblId;
    }
}
