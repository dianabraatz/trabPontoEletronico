namespace Coprel.View
{
    partial class FunOcorrenciaView
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
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(34, 168);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabela.Size = new System.Drawing.Size(675, 234);
            this.tabela.TabIndex = 0;
            this.tabela.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabela_CellMouseClick);
            // 
            // btnJustificar
            // 
            this.btnJustificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificar.Location = new System.Drawing.Point(617, 408);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(92, 30);
            this.btnJustificar.TabIndex = 1;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 88);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(300, 126);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(54, 18);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(300, 107);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(152, 18);
            this.lbNumero.TabIndex = 5;
            this.lbNumero.Text = "Numero de Registro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ocorrências";
            // 
            // FunOcorrenciaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnJustificar);
            this.Controls.Add(this.tabela);
            this.Name = "FunOcorrenciaView";
            this.Text = "FunOcorrenciaView";
            this.Load += new System.EventHandler(this.FunOcorrenciaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJustificar;
        public System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Label lbNumero;
    }
}