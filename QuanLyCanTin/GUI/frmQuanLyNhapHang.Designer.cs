
namespace GUI
{
    partial class frmQuanLyNhapHang
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnNhapHangCu = new System.Windows.Forms.Button();
            this.btnNhapHangMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userNhaCungCapControl = new GUI.UserNhaCungCapControl();
            this.userNhapHangCuControl = new GUI.UserNhapHangCuControl();
            this.userNhapHangMoiControl = new GUI.UserNhapHangMoiControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnNhaCungCap);
            this.panel1.Controls.Add(this.btnNhapHangCu);
            this.panel1.Controls.Add(this.btnNhapHangMoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1080);
            this.panel1.TabIndex = 6;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 300);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.Navy;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.Location = new System.Drawing.Point(0, 648);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(300, 70);
            this.btnNhaCungCap.TabIndex = 5;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhapHangCu
            // 
            this.btnNhapHangCu.BackColor = System.Drawing.Color.Navy;
            this.btnNhapHangCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHangCu.ForeColor = System.Drawing.Color.White;
            this.btnNhapHangCu.Location = new System.Drawing.Point(0, 551);
            this.btnNhapHangCu.Name = "btnNhapHangCu";
            this.btnNhapHangCu.Size = new System.Drawing.Size(300, 70);
            this.btnNhapHangCu.TabIndex = 4;
            this.btnNhapHangCu.Text = "Nhập hàng cũ";
            this.btnNhapHangCu.UseVisualStyleBackColor = false;
            this.btnNhapHangCu.Click += new System.EventHandler(this.btnNhapHangCu_Click);
            // 
            // btnNhapHangMoi
            // 
            this.btnNhapHangMoi.BackColor = System.Drawing.Color.White;
            this.btnNhapHangMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHangMoi.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHangMoi.Location = new System.Drawing.Point(0, 459);
            this.btnNhapHangMoi.Name = "btnNhapHangMoi";
            this.btnNhapHangMoi.Size = new System.Drawing.Size(300, 70);
            this.btnNhapHangMoi.TabIndex = 3;
            this.btnNhapHangMoi.Text = "Nhập hàng mới";
            this.btnNhapHangMoi.UseVisualStyleBackColor = false;
            this.btnNhapHangMoi.Click += new System.EventHandler(this.btnNhapHangMoi_Click);
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
            this.panel2.TabIndex = 7;
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
            this.btnMinimize.TabIndex = 11;
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
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userNhaCungCapControl
            // 
            this.userNhaCungCapControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNhaCungCapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNhaCungCapControl.Location = new System.Drawing.Point(300, 50);
            this.userNhaCungCapControl.Name = "userNhaCungCapControl";
            this.userNhaCungCapControl.Size = new System.Drawing.Size(1620, 1030);
            this.userNhaCungCapControl.TabIndex = 10;
            // 
            // userNhapHangCuControl
            // 
            this.userNhapHangCuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNhapHangCuControl.Location = new System.Drawing.Point(300, 50);
            this.userNhapHangCuControl.Name = "userNhapHangCuControl";
            this.userNhapHangCuControl.Size = new System.Drawing.Size(1620, 1030);
            this.userNhapHangCuControl.TabIndex = 9;
            // 
            // userNhapHangMoiControl
            // 
            this.userNhapHangMoiControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userNhapHangMoiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNhapHangMoiControl.Location = new System.Drawing.Point(300, 50);
            this.userNhapHangMoiControl.Name = "userNhapHangMoiControl";
            this.userNhapHangMoiControl.Size = new System.Drawing.Size(1620, 1030);
            this.userNhapHangMoiControl.TabIndex = 8;
            // 
            // frmQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userNhaCungCapControl);
            this.Controls.Add(this.userNhapHangCuControl);
            this.Controls.Add(this.userNhapHangMoiControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhapHang";
            this.Text = "frmQuanLyNhapHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnNhapHangCu;
        private System.Windows.Forms.Button btnNhapHangMoi;
        private System.Windows.Forms.Panel panel2;
        private UserNhapHangMoiControl userNhapHangMoiControl;
        private UserNhapHangCuControl userNhapHangCuControl;
        private UserNhaCungCapControl userNhaCungCapControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}