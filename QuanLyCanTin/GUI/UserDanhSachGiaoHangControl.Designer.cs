
namespace GUI
{
    partial class UserDanhSachGiaoHangControl
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
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.btnThanhCong = new System.Windows.Forms.Button();
            this.btnThatBai = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(80, 120);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(1440, 740);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // btnThanhCong
            // 
            this.btnThanhCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhCong.Location = new System.Drawing.Point(940, 900);
            this.btnThanhCong.Name = "btnThanhCong";
            this.btnThanhCong.Size = new System.Drawing.Size(150, 60);
            this.btnThanhCong.TabIndex = 1;
            this.btnThanhCong.Text = "Thành công";
            this.btnThanhCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhCong.UseVisualStyleBackColor = true;
            this.btnThanhCong.Click += new System.EventHandler(this.btnThanhCong_Click);
            // 
            // btnThatBai
            // 
            this.btnThatBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThatBai.Location = new System.Drawing.Point(1140, 900);
            this.btnThatBai.Name = "btnThatBai";
            this.btnThatBai.Size = new System.Drawing.Size(150, 60);
            this.btnThatBai.TabIndex = 2;
            this.btnThatBai.Text = "Thất bại";
            this.btnThatBai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThatBai.UseVisualStyleBackColor = true;
            this.btnThatBai.Click += new System.EventHandler(this.btnThatBai_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHD.Location = new System.Drawing.Point(1340, 900);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(180, 60);
            this.btnCTHD.TabIndex = 3;
            this.btnCTHD.Text = "Chi tiết hóa đơn";
            this.btnCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.White;
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTieuDe.Enabled = false;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(0, 0);
            this.txtTieuDe.Multiline = true;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.ReadOnly = true;
            this.txtTieuDe.Size = new System.Drawing.Size(1620, 80);
            this.txtTieuDe.TabIndex = 21;
            this.txtTieuDe.Text = "DANH SÁCH ĐƠN HÀNG CẦN GIAO";
            this.txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserDanhSachGiaoHangControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.btnThatBai);
            this.Controls.Add(this.btnThanhCong);
            this.Controls.Add(this.dgvDSHD);
            this.Name = "UserDanhSachGiaoHangControl";
            this.Size = new System.Drawing.Size(1620, 1030);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Button btnThanhCong;
        private System.Windows.Forms.Button btnThatBai;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.TextBox txtTieuDe;
    }
}
