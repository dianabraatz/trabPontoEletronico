﻿namespace Coprel.View
{
    partial class ValidarJustificativaPontoView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tfCodPonto = new System.Windows.Forms.TextBox();
            this.tfCodOcorrencia = new System.Windows.Forms.TextBox();
            this.tfJustificativa = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Justificativa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Ponto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código da Ocorrência";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tfCodPonto
            // 
            this.tfCodPonto.Enabled = false;
            this.tfCodPonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCodPonto.Location = new System.Drawing.Point(230, 76);
            this.tfCodPonto.Name = "tfCodPonto";
            this.tfCodPonto.Size = new System.Drawing.Size(319, 26);
            this.tfCodPonto.TabIndex = 4;
            this.tfCodPonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tfCodOcorrencia
            // 
            this.tfCodOcorrencia.Enabled = false;
            this.tfCodOcorrencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCodOcorrencia.Location = new System.Drawing.Point(230, 114);
            this.tfCodOcorrencia.Name = "tfCodOcorrencia";
            this.tfCodOcorrencia.Size = new System.Drawing.Size(319, 26);
            this.tfCodOcorrencia.TabIndex = 6;
            this.tfCodOcorrencia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tfJustificativa
            // 
            this.tfJustificativa.Enabled = false;
            this.tfJustificativa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfJustificativa.Location = new System.Drawing.Point(230, 153);
            this.tfJustificativa.Multiline = true;
            this.tfJustificativa.Name = "tfJustificativa";
            this.tfJustificativa.Size = new System.Drawing.Size(319, 66);
            this.tfJustificativa.TabIndex = 7;
            this.tfJustificativa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(230, 234);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(319, 26);
            this.cbStatus.TabIndex = 8;
            // 
            // ValidarJustificativaPontoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 343);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tfJustificativa);
            this.Controls.Add(this.tfCodOcorrencia);
            this.Controls.Add(this.tfCodPonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ValidarJustificativaPontoView";
            this.Text = "ValidarJustificativaPontoView";
            this.Load += new System.EventHandler(this.ValidarJustificativaPontoView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tfCodPonto;
        public System.Windows.Forms.TextBox tfCodOcorrencia;
        public System.Windows.Forms.TextBox tfJustificativa;
        public System.Windows.Forms.ComboBox cbStatus;
    }
}