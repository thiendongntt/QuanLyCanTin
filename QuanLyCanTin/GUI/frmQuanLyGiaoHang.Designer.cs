
namespace GUI
{
    partial class frmQuanLyGiaoHang
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
            this.btnDSGH = new System.Windows.Forms.Button();
            this.btnLSGH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userLichSuGiaoHangControl = new GUI.UserLichSuGiaoHangControl();
            this.userDanhSachGiaoHangControl = new GUI.UserDanhSachGiaoHangControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDSGH
            // 
            this.btnDSGH.BackColor = System.Drawing.Color.White;
            this.btnDSGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSGH.ForeColor = System.Drawing.Color.Black;
            this.btnDSGH.Location = new System.Drawing.Point(0, 550);
            this.btnDSGH.Name = "btnDSGH";
            this.btnDSGH.Size = new System.Drawing.Size(300, 70);
            this.btnDSGH.TabIndex = 0;
            this.btnDSGH.Text = "Danh sách giao hàng";
            this.btnDSGH.UseVisualStyleBackColor = false;
            this.btnDSGH.Click += new System.EventHandler(this.btnDSGH_Click);
            // 
            // btnLSGH
            // 
            this.btnLSGH.BackColor = System.Drawing.Color.Navy;
            this.btnLSGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSGH.ForeColor = System.Drawing.Color.White;
            this.btnLSGH.Location = new System.Drawing.Point(0, 700);
            this.btnLSGH.Name = "btnLSGH";
            this.btnLSGH.Size = new System.Drawing.Size(300, 70);
            this.btnLSGH.TabIndex = 1;
            this.btnLSGH.Text = "Lịch sử giao hàng";
            this.btnLSGH.UseVisualStyleBackColor = false;
            this.btnLSGH.Click += new System.EventHandler(this.btnLSGH_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnDSGH);
            this.panel1.Controls.Add(this.btnLSGH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1080);
            this.panel1.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 300);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
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
            this.panel2.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(1568, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 48);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userLichSuGiaoHangControl
            // 
            this.userLichSuGiaoHangControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userLichSuGiaoHangControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLichSuGiaoHangControl.Location = new System.Drawing.Point(300, 50);
            this.userLichSuGiaoHangControl.Name = "userLichSuGiaoHangControl";
            this.userLichSuGiaoHangControl.Size = new System.Drawing.Size(1620, 1030);
            this.userLichSuGiaoHangControl.TabIndex = 6;
            // 
            // userDanhSachGiaoHangControl
            // 
            this.userDanhSachGiaoHangControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userDanhSachGiaoHangControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDanhSachGiaoHangControl.Location = new System.Drawing.Point(300, 50);
            this.userDanhSachGiaoHangControl.Name = "userDanhSachGiaoHangControl";
            this.userDanhSachGiaoHangControl.Size = new System.Drawing.Size(1620, 1030);
            this.userDanhSachGiaoHangControl.TabIndex = 5;
            // 
            // frmQuanLyGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userLichSuGiaoHangControl);
            this.Controls.Add(this.userDanhSachGiaoHangControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyGiaoHang";
            this.Text = "frmQuanLyGiaoHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDSGH;
        private System.Windows.Forms.Button btnLSGH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private UserDanhSachGiaoHangControl userDanhSachGiaoHangControl;
        private UserLichSuGiaoHangControl userLichSuGiaoHangControl;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}