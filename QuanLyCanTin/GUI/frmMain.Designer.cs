
namespace GUI
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyKhoHang = new System.Windows.Forms.Button();
            this.btnQuanLyDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLyGiaoHang = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyBanHang = new System.Windows.Forms.Button();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 6;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(898, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 48);
            this.btnMinimize.TabIndex = 9;
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
            this.btnClose.Location = new System.Drawing.Point(948, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMenu);
            this.panel2.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panel2.Controls.Add(this.btnQuanLyKhoHang);
            this.panel2.Controls.Add(this.btnQuanLyDoanhThu);
            this.panel2.Controls.Add(this.btnQuanLyGiaoHang);
            this.panel2.Controls.Add(this.btnQuanLyNhanVien);
            this.panel2.Controls.Add(this.btnQuanLyBanHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 500);
            this.panel2.TabIndex = 7;
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(700, 300);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyTaiKhoan.TabIndex = 11;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyKhoHang
            // 
            this.btnQuanLyKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyKhoHang.Location = new System.Drawing.Point(700, 150);
            this.btnQuanLyKhoHang.Name = "btnQuanLyKhoHang";
            this.btnQuanLyKhoHang.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyKhoHang.TabIndex = 10;
            this.btnQuanLyKhoHang.Text = "Quản lý kho hàng";
            this.btnQuanLyKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyKhoHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhoHang.Click += new System.EventHandler(this.btnQuanLyKhoHang_Click);
            // 
            // btnQuanLyDoanhThu
            // 
            this.btnQuanLyDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDoanhThu.Location = new System.Drawing.Point(400, 300);
            this.btnQuanLyDoanhThu.Name = "btnQuanLyDoanhThu";
            this.btnQuanLyDoanhThu.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyDoanhThu.TabIndex = 9;
            this.btnQuanLyDoanhThu.Text = "Quản lý doanh thu";
            this.btnQuanLyDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyDoanhThu.UseVisualStyleBackColor = true;
            this.btnQuanLyDoanhThu.Click += new System.EventHandler(this.btnQuanLyDoanhThu_Click);
            // 
            // btnQuanLyGiaoHang
            // 
            this.btnQuanLyGiaoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyGiaoHang.Location = new System.Drawing.Point(400, 150);
            this.btnQuanLyGiaoHang.Name = "btnQuanLyGiaoHang";
            this.btnQuanLyGiaoHang.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyGiaoHang.TabIndex = 8;
            this.btnQuanLyGiaoHang.Text = "Quản lý giao hàng";
            this.btnQuanLyGiaoHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyGiaoHang.UseVisualStyleBackColor = true;
            this.btnQuanLyGiaoHang.Click += new System.EventHandler(this.btnQuanLyGiaoHang_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(100, 300);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyNhanVien.TabIndex = 7;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyBanHang
            // 
            this.btnQuanLyBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanHang.Location = new System.Drawing.Point(100, 150);
            this.btnQuanLyBanHang.Name = "btnQuanLyBanHang";
            this.btnQuanLyBanHang.Size = new System.Drawing.Size(250, 100);
            this.btnQuanLyBanHang.TabIndex = 6;
            this.btnQuanLyBanHang.Text = "Quản lý bán hàng";
            this.btnQuanLyBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanLyBanHang.UseVisualStyleBackColor = true;
            this.btnQuanLyBanHang.Click += new System.EventHandler(this.btnQuanLyBanHang_Click);
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
            this.txtMenu.Size = new System.Drawing.Size(998, 80);
            this.txtMenu.TabIndex = 21;
            this.txtMenu.Text = "QUẢN LÝ CĂN TIN UTC2";
            this.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyKhoHang;
        private System.Windows.Forms.Button btnQuanLyDoanhThu;
        private System.Windows.Forms.Button btnQuanLyGiaoHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyBanHang;
        private System.Windows.Forms.TextBox txtMenu;
    }
}