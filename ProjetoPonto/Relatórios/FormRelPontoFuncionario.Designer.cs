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
            this.bdpontoDataSet1 = new Coprel.bdpontoDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bdpontoDataSet1
            // 
            this.bdpontoDataSet1.DataSetName = "bdpontoDataSet";
            this.bdpontoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRelPontoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 289);
            this.Name = "FormRelPontoFuncionario";
            this.Text = "FormRelPontoFuncionario";
            this.Load += new System.EventHandler(this.FormRelPontoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdpontoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bdpontoDataSet bdpontoDataSet1;
    }
}