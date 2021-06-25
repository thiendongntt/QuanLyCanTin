
namespace GUI
{
    partial class frmThongKeNhapKho
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhapHangDataSet = new GUI.NhapHangDataSet();
            this.sp_getDataReportNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_getDataReportNhapHangTableAdapter = new GUI.NhapHangDataSetTableAdapters.sp_getDataReportNhapHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhapHangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportNhapHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NHAPHANG";
            reportDataSource1.Value = this.sp_getDataReportNhapHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportNhapKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhapHangDataSet
            // 
            this.NhapHangDataSet.DataSetName = "NhapHangDataSet";
            this.NhapHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_getDataReportNhapHangBindingSource
            // 
            this.sp_getDataReportNhapHangBindingSource.DataMember = "sp_getDataReportNhapHang";
            this.sp_getDataReportNhapHangBindingSource.DataSource = this.NhapHangDataSet;
            // 
            // sp_getDataReportNhapHangTableAdapter
            // 
            this.sp_getDataReportNhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThongKeNhapKho";
            this.Text = "frmThongKeNhapKho";
            this.Load += new System.EventHandler(this.frmThongKeNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhapHangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportNhapHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_getDataReportNhapHangBindingSource;
        private NhapHangDataSet NhapHangDataSet;
        private NhapHangDataSetTableAdapters.sp_getDataReportNhapHangTableAdapter sp_getDataReportNhapHangTableAdapter;
    }
}