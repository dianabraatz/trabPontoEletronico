namespace Coprel.Relatórios
{
    partial class FormRelPontoFuncionario
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
            this.bdpontoDataSet = new Coprel.bdpontoDataSet();
            this.dataTablePFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pFTableAdapter = new Coprel.bdpontoDataSetTableAdapters.PFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPontoFuncionario";
            reportDataSource1.Value = this.dataTablePFBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Coprel.Relatórios.RelPontoFuncionário.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(529, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdpontoDataSet
            // 
            this.bdpontoDataSet.DataSetName = "bdpontoDataSet";
            this.bdpontoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTablePFBindingSource
            // 
            this.dataTablePFBindingSource.DataMember = "DataTablePF";
            this.dataTablePFBindingSource.DataSource = this.bdpontoDataSet;
            // 
            // pFTableAdapter
            // 
            this.pFTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelPontoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 317);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelPontoFuncionario";
            this.Text = "DCPoint - Relatório Ponto/Funcionário";
            this.Load += new System.EventHandler(this.FormRelPontoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bdpontoDataSet bdpontoDataSet;
        private System.Windows.Forms.BindingSource dataTablePFBindingSource;
        private bdpontoDataSetTableAdapters.PFTableAdapter pFTableAdapter;
    }
}