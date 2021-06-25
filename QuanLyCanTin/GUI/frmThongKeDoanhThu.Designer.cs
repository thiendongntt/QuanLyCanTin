
namespace GUI
{
    partial class frmThongKeDoanhThu
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
            this.sp_getDataReportDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoanhThuDataSet = new GUI.DoanhThuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_getDataReportDoanhThuTableAdapter = new GUI.DoanhThuDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_getDataReportDoanhThuBindingSource
            // 
            this.sp_getDataReportDoanhThuBindingSource.DataMember = "sp_getDataReportDoanhThu";
            this.sp_getDataReportDoanhThuBindingSource.DataSource = this.DoanhThuDataSet;
            // 
            // DoanhThuDataSet
            // 
            this.DoanhThuDataSet.DataSetName = "DoanhThuDataSet";
            this.DoanhThuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HOADON";
            reportDataSource1.Value = this.sp_getDataReportDoanhThuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportDoanhThu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1186, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_getDataReportDoanhThuTableAdapter
            // 
            this.sp_getDataReportDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_getDataReportDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_getDataReportDoanhThuBindingSource;
        private DoanhThuDataSet DoanhThuDataSet;
        private DoanhThuDataSetTableAdapters.sp_getDataReportDoanhThuTableAdapter sp_getDataReportDoanhThuTableAdapter;
    }
}