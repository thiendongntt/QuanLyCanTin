
namespace GUI
{
    partial class frmQuanLyDoanhThu
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
            this.btnThongKeNhapKho = new System.Windows.Forms.Button();
            this.btnThongKeDoanhThu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userThongKeNhapKhoControl = new GUI.UserThongKeNhapKhoControl();
            this.userThongKeDoanhThuControl = new GUI.UserThongKeDoanhThuControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.btnThongKeNhapKho);
            this.panel1.Controls.Add(this.btnThongKeDoanhThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1080);
            this.panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 300);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // btnThongKeNhapKho
            // 
            this.btnThongKeNhapKho.BackColor = System.Drawing.Color.Navy;
            this.btnThongKeNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnThongKeNhapKho.Location = new System.Drawing.Point(0, 700);
            this.btnThongKeNhapKho.Name = "btnThongKeNhapKho";
            this.btnThongKeNhapKho.Size = new System.Drawing.Size(300, 70);
            this.btnThongKeNhapKho.TabIndex = 5;
            this.btnThongKeNhapKho.Text = "Thống kê nhập kho";
            this.btnThongKeNhapKho.UseVisualStyleBackColor = false;
            this.btnThongKeNhapKho.Click += new System.EventHandler(this.btnThongKeNhapKho_Click);
            // 
            // btnThongKeDoanhThu
            // 
            this.btnThongKeDoanhThu.BackColor = System.Drawing.Color.White;
            this.btnThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.btnThongKeDoanhThu.Location = new System.Drawing.Point(0, 550);
            this.btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            this.btnThongKeDoanhThu.Size = new System.Drawing.Size(300, 70);
            this.btnThongKeDoanhThu.TabIndex = 4;
            this.btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.btnThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThu.Click += new System.EventHandler(this.btnThongKeDoanhThu_Click);
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
            this.panel2.TabIndex = 1;
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
            this.btnMinimize.TabIndex = 13;
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
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userThongKeNhapKhoControl
            // 
            this.userThongKeNhapKhoControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userThongKeNhapKhoControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userThongKeNhapKhoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userThongKeNhapKhoControl.Location = new System.Drawing.Point(300, 50);
            this.userThongKeNhapKhoControl.Name = "userThongKeNhapKhoControl";
            this.userThongKeNhapKhoControl.Size = new System.Drawing.Size(1620, 1030);
            this.userThongKeNhapKhoControl.TabIndex = 3;
            // 
            // userThongKeDoanhThuControl
            // 
            this.userThongKeDoanhThuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userThongKeDoanhThuControl.Location = new System.Drawing.Point(300, 50);
            this.userThongKeDoanhThuControl.Name = "userThongKeDoanhThuControl";
            this.userThongKeDoanhThuControl.Size = new System.Drawing.Size(1620, 1030);
            this.userThongKeDoanhThuControl.TabIndex = 2;
            // 
            // frmQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.userThongKeNhapKhoControl);
            this.Controls.Add(this.userThongKeDoanhThuControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyDoanhThu";
            this.Text = "frmQuanLyDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKeNhapKho;
        private System.Windows.Forms.Button btnThongKeDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private UserThongKeDoanhThuControl userThongKeDoanhThuControl;
        private UserThongKeNhapKhoControl userThongKeNhapKhoControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}