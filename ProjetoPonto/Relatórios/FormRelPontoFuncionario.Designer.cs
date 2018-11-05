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
            this.bdpontoDataSet1 = new Coprel.bdpontoDataSet();
            this.dataTableTableAdapterPF1 = new Coprel.bdpontoDataSetTableAdapters.DataTableTableAdapterPF();
            this.pontoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bdpontoDataSet1
            // 
            this.bdpontoDataSet1.DataSetName = "bdpontoDataSet";
            this.bdpontoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableTableAdapterPF1
            // 
            this.dataTableTableAdapterPF1.ClearBeforeFill = true;
            // 
            // pontoFuncionarioBindingSource
            // 
            this.pontoFuncionarioBindingSource.DataSource = this.bdpontoDataSet1;
            this.pontoFuncionarioBindingSource.Position = 0;
            this.pontoFuncionarioBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPF";
            reportDataSource1.Value = this.pontoFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Coprel.Relatórios.RelPontoFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(481, 289);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRelPontoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 289);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelPontoFuncionario";
            this.Text = "DCPoint - Relatório de Ponto por Funcionário";
            this.Load += new System.EventHandler(this.FormRelPontoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pontoFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bdpontoDataSet bdpontoDataSet1;
        private bdpontoDataSetTableAdapters.DataTableTableAdapterPF dataTableTableAdapterPF1;
        private System.Windows.Forms.BindingSource pontoFuncionarioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}