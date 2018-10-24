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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunOcorrenciaView));
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Location = new System.Drawing.Point(27, 206);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabela.Size = new System.Drawing.Size(675, 234);
            this.tabela.TabIndex = 0;
            this.tabela.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tabela_CellMouseClick);
            // 
            // btnJustificar
            // 
            this.btnJustificar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificar.Location = new System.Drawing.Point(610, 446);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(92, 30);
            this.btnJustificar.TabIndex = 1;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(292, 168);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(56, 20);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(292, 149);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(160, 20);
            this.lbNumero.TabIndex = 5;
            this.lbNumero.Text = "Numero de Registro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold);
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(275, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 33);
            this.label14.TabIndex = 69;
            this.label14.Text = "Ocorrências";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(-1, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 94);
            this.label9.TabIndex = 68;
            // 
            // FunOcorrenciaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(721, 488);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJustificar);
            this.Controls.Add(this.tabela);
            this.Name = "FunOcorrenciaView";
            this.Text = "DCPoint - Ocorrências";
            this.Load += new System.EventHandler(this.FunOcorrenciaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnJustificar;
        public System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
    }
}