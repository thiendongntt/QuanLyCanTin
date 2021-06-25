
namespace GUI
{
    partial class frmQuanLyBanHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnDoAnSang = new System.Windows.Forms.Button();
            this.btnDoUong = new System.Windows.Forms.Button();
            this.btnKhac = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoAnVat = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblVND = new System.Windows.Forms.Label();
            this.txtGioHang = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.White;
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(0, 400);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(300, 70);
            this.btnTatCa.TabIndex = 2;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnDoAnSang
            // 
            this.btnDoAnSang.BackColor = System.Drawing.Color.Navy;
            this.btnDoAnSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAnSang.ForeColor = System.Drawing.Color.White;
            this.btnDoAnSang.Location = new System.Drawing.Point(0, 500);
            this.btnDoAnSang.Name = "btnDoAnSang";
            this.btnDoAnSang.Size = new System.Drawing.Size(300, 70);
            this.btnDoAnSang.TabIndex = 3;
            this.btnDoAnSang.Text = "Đồ ăn sáng";
            this.btnDoAnSang.UseVisualStyleBackColor = false;
            this.btnDoAnSang.Click += new System.EventHandler(this.btnDoAnSang_Click);
            // 
            // btnDoUong
            // 
            this.btnDoUong.BackColor = System.Drawing.Color.Navy;
            this.btnDoUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoUong.ForeColor = System.Drawing.Color.White;
            this.btnDoUong.Location = new System.Drawing.Point(0, 700);
            this.btnDoUong.Name = "btnDoUong";
            this.btnDoUong.Size = new System.Drawing.Size(300, 70);
            this.btnDoUong.TabIndex = 4;
            this.btnDoUong.Text = "Đồ uống";
            this.btnDoUong.UseVisualStyleBackColor = false;
            this.btnDoUong.Click += new System.EventHandler(this.btnDoUong_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.BackColor = System.Drawing.Color.Navy;
            this.btnKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.ForeColor = System.Drawing.Color.White;
            this.btnKhac.Location = new System.Drawing.Point(0, 800);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(300, 70);
            this.btnKhac.TabIndex = 5;
            this.btnKhac.Text = "Khác";
            this.btnKhac.UseVisualStyleBackColor = false;
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnDoAnVat);
            this.panel1.Controls.Add(this.ptbLogo);
            this.panel1.Controls.Add(this.btnDoUong);
            this.panel1.Controls.Add(this.btnTatCa);
            this.panel1.Controls.Add(this.btnDoAnSang);
            this.panel1.Controls.Add(this.btnKhac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1080);
            this.panel1.TabIndex = 9;
            // 
            // btnDoAnVat
            // 
            this.btnDoAnVat.BackColor = System.Drawing.Color.Navy;
            this.btnDoAnVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAnVat.ForeColor = System.Drawing.Color.White;
            this.btnDoAnVat.Location = new System.Drawing.Point(0, 600);
            this.btnDoAnVat.Name = "btnDoAnVat";
            this.btnDoAnVat.Size = new System.Drawing.Size(300, 70);
            this.btnDoAnVat.TabIndex = 7;
            this.btnDoAnVat.Text = "Đồ ăn vặt";
            this.btnDoAnVat.UseVisualStyleBackColor = false;
            this.btnDoAnVat.Click += new System.EventHandler(this.btnDoAnVat_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(300, 300);
            this.ptbLogo.TabIndex = 6;
            this.ptbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1620, 50);
            this.panel2.TabIndex = 10;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1518, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 48);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1568, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1620, 1030);
            this.panel3.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblVND);
            this.panel5.Controls.Add(this.txtGioHang);
            this.panel5.Controls.Add(this.btnThanhToan);
            this.panel5.Controls.Add(this.txtTongTien);
            this.panel5.Controls.Add(this.lblTongTien);
            this.panel5.Controls.Add(this.dgvCTHD);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(800, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(820, 1030);
            this.panel5.TabIndex = 16;
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVND.Location = new System.Drawing.Point(720, 720);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(76, 33);
            this.lblVND.TabIndex = 20;
            this.lblVND.Text = "VND";
            // 
            // txtGioHang
            // 
            this.txtGioHang.BackColor = System.Drawing.Color.White;
            this.txtGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGioHang.Enabled = false;
            this.txtGioHang.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioHang.Location = new System.Drawing.Point(0, 0);
            this.txtGioHang.Multiline = true;
            this.txtGioHang.Name = "txtGioHang";
            this.txtGioHang.ReadOnly = true;
            this.txtGioHang.Size = new System.Drawing.Size(818, 80);
            this.txtGioHang.TabIndex = 19;
            this.txtGioHang.Text = "GIỎ HÀNG";
            this.txtGioHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(600, 830);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 50);
            this.btnThanhToan.TabIndex = 18;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(530, 720);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 40);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.Text = "0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(340, 720);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(136, 33);
            this.lblTongTien.TabIndex = 16;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 80);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(820, 600);
            this.dgvCTHD.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMenu);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 1030);
            this.panel4.TabIndex = 15;
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.White;
            this.txtMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMenu.Enabled = false;
            this.txtMenu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(0, 0);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.ReadOnly = true;
            this.txtMenu.Size = new System.Drawing.Size(800, 80);
            this.txtMenu.TabIndex = 20;
            this.txtMenu.Text = "MENU";
            this.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 950);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyBanHang";
            this.Tag = "0";
            this.Text = "frmQuanLyBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnDoAnSang;
        private System.Windows.Forms.Button btnDoUong;
        private System.Windows.Forms.Button btnKhac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtGioHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Button btnDoAnVat;
        private System.Windows.Forms.Label lblVND;
    }
}