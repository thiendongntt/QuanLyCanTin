
namespace GUI
{
    partial class UserChamCongControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDSNV = new System.Windows.Forms.TextBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbCaTruc = new System.Windows.Forms.ComboBox();
            this.dtpNgayLam = new System.Windows.Forms.DateTimePicker();
            this.lblNgaylam = new System.Windows.Forms.Label();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.lblCaTruc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDSCC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDSNV);
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 1030);
            this.panel1.TabIndex = 13;
            // 
            // txtDSNV
            // 
            this.txtDSNV.BackColor = System.Drawing.Color.White;
            this.txtDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDSNV.Enabled = false;
            this.txtDSNV.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSNV.Location = new System.Drawing.Point(0, 0);
            this.txtDSNV.Multiline = true;
            this.txtDSNV.Name = "txtDSNV";
            this.txtDSNV.ReadOnly = true;
            this.txtDSNV.Size = new System.Drawing.Size(808, 80);
            this.txtDSNV.TabIndex = 26;
            this.txtDSNV.Text = "DANH SÁCH NHÂN VIÊN";
            this.txtDSNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(30, 100);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(750, 670);
            this.dgvNhanVien.TabIndex = 12;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbCaTruc);
            this.panel5.Controls.Add(this.dtpNgayLam);
            this.panel5.Controls.Add(this.lblNgaylam);
            this.panel5.Controls.Add(this.btnChamCong);
            this.panel5.Controls.Add(this.lblCaTruc);
            this.panel5.Location = new System.Drawing.Point(0, 770);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(810, 100);
            this.panel5.TabIndex = 11;
            // 
            // cbbCaTruc
            // 
            this.cbbCaTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCaTruc.FormattingEnabled = true;
            this.cbbCaTruc.Location = new System.Drawing.Point(514, 40);
            this.cbbCaTruc.Name = "cbbCaTruc";
            this.cbbCaTruc.Size = new System.Drawing.Size(121, 28);
            this.cbbCaTruc.TabIndex = 3;
            // 
            // dtpNgayLam
            // 
            this.dtpNgayLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLam.Location = new System.Drawing.Point(120, 40);
            this.dtpNgayLam.Name = "dtpNgayLam";
            this.dtpNgayLam.Size = new System.Drawing.Size(270, 26);
            this.dtpNgayLam.TabIndex = 0;
            // 
            // lblNgaylam
            // 
            this.lblNgaylam.AutoSize = true;
            this.lblNgaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaylam.Location = new System.Drawing.Point(20, 40);
            this.lblNgaylam.Name = "lblNgaylam";
            this.lblNgaylam.Size = new System.Drawing.Size(74, 20);
            this.lblNgaylam.TabIndex = 1;
            this.lblNgaylam.Text = "Ngày làm";
            // 
            // btnChamCong
            // 
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(680, 40);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(100, 26);
            this.btnChamCong.TabIndex = 4;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // lblCaTruc
            // 
            this.lblCaTruc.AutoSize = true;
            this.lblCaTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaTruc.Location = new System.Drawing.Point(430, 40);
            this.lblCaTruc.Name = "lblCaTruc";
            this.lblCaTruc.Size = new System.Drawing.Size(60, 20);
            this.lblCaTruc.TabIndex = 2;
            this.lblCaTruc.Text = "Ca trực";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDSCC);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvChamCong);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(810, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 1030);
            this.panel3.TabIndex = 14;
            // 
            // txtDSCC
            // 
            this.txtDSCC.BackColor = System.Drawing.Color.White;
            this.txtDSCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDSCC.Enabled = false;
            this.txtDSCC.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSCC.Location = new System.Drawing.Point(0, 0);
            this.txtDSCC.Multiline = true;
            this.txtDSCC.Name = "txtDSCC";
            this.txtDSCC.ReadOnly = true;
            this.txtDSCC.Size = new System.Drawing.Size(808, 80);
            this.txtDSCC.TabIndex = 27;
            this.txtDSCC.Text = "DANH SÁCH CHẤM CÔNG";
            this.txtDSCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 770);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 100);
            this.panel4.TabIndex = 15;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(30, 100);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.Size = new System.Drawing.Size(750, 670);
            this.dgvChamCong.TabIndex = 13;
            // 
            // UserChamCongControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "UserChamCongControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbbCaTruc;
        private System.Windows.Forms.DateTimePicker dtpNgayLam;
        private System.Windows.Forms.Label lblNgaylam;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Label lblCaTruc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.TextBox txtDSNV;
        private System.Windows.Forms.TextBox txtDSCC;
    }
}
