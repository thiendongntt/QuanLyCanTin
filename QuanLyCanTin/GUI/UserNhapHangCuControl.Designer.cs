
namespace GUI
{
    partial class UserNhapHangCuControl
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.txtLichSuNH = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.cbbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblSLNhap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtDanhSachSP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSLConLai = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.lblSLConLai = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblIdSP = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txtLichSuNH);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1620, 515);
            this.panel3.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvNhapHang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(543, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1077, 435);
            this.panel6.TabIndex = 30;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.Size = new System.Drawing.Size(1077, 435);
            this.dgvNhapHang.TabIndex = 20;
            // 
            // txtLichSuNH
            // 
            this.txtLichSuNH.BackColor = System.Drawing.Color.White;
            this.txtLichSuNH.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLichSuNH.Enabled = false;
            this.txtLichSuNH.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLichSuNH.Location = new System.Drawing.Point(543, 0);
            this.txtLichSuNH.Multiline = true;
            this.txtLichSuNH.Name = "txtLichSuNH";
            this.txtLichSuNH.ReadOnly = true;
            this.txtLichSuNH.Size = new System.Drawing.Size(1077, 80);
            this.txtLichSuNH.TabIndex = 29;
            this.txtLichSuNH.Text = "LỊCH SỬ NHẬP HÀNG";
            this.txtLichSuNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnNhapHang);
            this.panel4.Controls.Add(this.cbbNhaCungCap);
            this.panel4.Controls.Add(this.dtpNgayNhap);
            this.panel4.Controls.Add(this.txtSLNhap);
            this.panel4.Controls.Add(this.lblNhaCungCap);
            this.panel4.Controls.Add(this.lblNgayNhap);
            this.panel4.Controls.Add(this.lblSLNhap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(543, 515);
            this.panel4.TabIndex = 20;
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Location = new System.Drawing.Point(340, 410);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(150, 60);
            this.btnNhapHang.TabIndex = 33;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // cbbNhaCungCap
            // 
            this.cbbNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhaCungCap.FormattingEnabled = true;
            this.cbbNhaCungCap.Location = new System.Drawing.Point(220, 330);
            this.cbbNhaCungCap.Name = "cbbNhaCungCap";
            this.cbbNhaCungCap.Size = new System.Drawing.Size(170, 28);
            this.cbbNhaCungCap.TabIndex = 32;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Location = new System.Drawing.Point(220, 240);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(270, 26);
            this.dtpNgayNhap.TabIndex = 31;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNhap.Location = new System.Drawing.Point(220, 150);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(100, 26);
            this.txtSLNhap.TabIndex = 30;
            this.txtSLNhap.TextChanged += new System.EventHandler(this.txtSLNhap_TextChanged);
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(55, 330);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(107, 20);
            this.lblNhaCungCap.TabIndex = 29;
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(55, 240);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(85, 20);
            this.lblNgayNhap.TabIndex = 28;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // lblSLNhap
            // 
            this.lblSLNhap.AutoSize = true;
            this.lblSLNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNhap.Location = new System.Drawing.Point(55, 150);
            this.lblSLNhap.Name = "lblSLNhap";
            this.lblSLNhap.Size = new System.Drawing.Size(112, 20);
            this.lblSLNhap.TabIndex = 27;
            this.lblSLNhap.Text = "Số lượng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtDanhSachSP);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 515);
            this.panel1.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvSanPham);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(543, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1077, 435);
            this.panel5.TabIndex = 30;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(1077, 435);
            this.dgvSanPham.TabIndex = 13;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // txtDanhSachSP
            // 
            this.txtDanhSachSP.BackColor = System.Drawing.Color.White;
            this.txtDanhSachSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDanhSachSP.Enabled = false;
            this.txtDanhSachSP.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhSachSP.Location = new System.Drawing.Point(543, 0);
            this.txtDanhSachSP.Multiline = true;
            this.txtDanhSachSP.Name = "txtDanhSachSP";
            this.txtDanhSachSP.ReadOnly = true;
            this.txtDanhSachSP.Size = new System.Drawing.Size(1077, 80);
            this.txtDanhSachSP.TabIndex = 29;
            this.txtDanhSachSP.Text = "DANH SÁCH SẢN PHẨM";
            this.txtDanhSachSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtThongTin);
            this.panel2.Controls.Add(this.txtDonViTinh);
            this.panel2.Controls.Add(this.txtSLConLai);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.lblDonViTinh);
            this.panel2.Controls.Add(this.lblSLConLai);
            this.panel2.Controls.Add(this.lblGia);
            this.panel2.Controls.Add(this.lblTen);
            this.panel2.Controls.Add(this.lblIdSP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 515);
            this.panel2.TabIndex = 13;
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
            this.txtThongTin.Size = new System.Drawing.Size(541, 80);
            this.txtThongTin.TabIndex = 33;
            this.txtThongTin.Text = "THÔNG TIN";
            this.txtThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Enabled = false;
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(220, 430);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(170, 26);
            this.txtDonViTinh.TabIndex = 32;
            // 
            // txtSLConLai
            // 
            this.txtSLConLai.Enabled = false;
            this.txtSLConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLConLai.Location = new System.Drawing.Point(220, 360);
            this.txtSLConLai.Name = "txtSLConLai";
            this.txtSLConLai.Size = new System.Drawing.Size(170, 26);
            this.txtSLConLai.TabIndex = 31;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(220, 290);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(170, 26);
            this.txtGia.TabIndex = 30;
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(220, 220);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(270, 26);
            this.txtTen.TabIndex = 29;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(220, 150);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 28;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(55, 430);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(83, 20);
            this.lblDonViTinh.TabIndex = 27;
            this.lblDonViTinh.Text = "Đơn vị tính";
            // 
            // lblSLConLai
            // 
            this.lblSLConLai.AutoSize = true;
            this.lblSLConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLConLai.Location = new System.Drawing.Point(55, 360);
            this.lblSLConLai.Name = "lblSLConLai";
            this.lblSLConLai.Size = new System.Drawing.Size(121, 20);
            this.lblSLConLai.TabIndex = 26;
            this.lblSLConLai.Text = "Số lượng còn lại";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(55, 290);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 20);
            this.lblGia.TabIndex = 25;
            this.lblGia.Text = "Giá";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(55, 220);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 20);
            this.lblTen.TabIndex = 24;
            this.lblTen.Text = "Tên";
            // 
            // lblIdSP
            // 
            this.lblIdSP.AutoSize = true;
            this.lblIdSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSP.Location = new System.Drawing.Point(55, 150);
            this.lblIdSP.Name = "lblIdSP";
            this.lblIdSP.Size = new System.Drawing.Size(23, 20);
            this.lblIdSP.TabIndex = 23;
            this.lblIdSP.Text = "Id";
            // 
            // UserNhapHangCuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "UserNhapHangCuControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSLConLai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblSLConLai;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblIdSP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.ComboBox cbbNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblSLNhap;
        private System.Windows.Forms.TextBox txtLichSuNH;
        private System.Windows.Forms.TextBox txtDanhSachSP;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvNhapHang;
    }
}
