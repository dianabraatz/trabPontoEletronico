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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidarJustificativaPontoView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tfCodPonto = new System.Windows.Forms.TextBox();
            this.tfCodOcorrencia = new System.Windows.Forms.TextBox();
            this.tfJustificativa = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Justificativa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Ponto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código da Ocorrência";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tfCodPonto
            // 
            this.tfCodPonto.Enabled = false;
            this.tfCodPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCodPonto.Location = new System.Drawing.Point(223, 135);
            this.tfCodPonto.Name = "tfCodPonto";
            this.tfCodPonto.Size = new System.Drawing.Size(319, 26);
            this.tfCodPonto.TabIndex = 4;
            this.tfCodPonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tfCodOcorrencia
            // 
            this.tfCodOcorrencia.Enabled = false;
            this.tfCodOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCodOcorrencia.Location = new System.Drawing.Point(223, 173);
            this.tfCodOcorrencia.Name = "tfCodOcorrencia";
            this.tfCodOcorrencia.Size = new System.Drawing.Size(319, 26);
            this.tfCodOcorrencia.TabIndex = 6;
            this.tfCodOcorrencia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tfJustificativa
            // 
            this.tfJustificativa.Enabled = false;
            this.tfJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfJustificativa.Location = new System.Drawing.Point(223, 212);
            this.tfJustificativa.Multiline = true;
            this.tfJustificativa.Name = "tfJustificativa";
            this.tfJustificativa.Size = new System.Drawing.Size(319, 66);
            this.tfJustificativa.TabIndex = 7;
            this.tfJustificativa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(223, 293);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(319, 28);
            this.cbStatus.TabIndex = 8;
            // 
            // btnJustificar
            // 
            this.btnJustificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificar.Location = new System.Drawing.Point(435, 333);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(107, 31);
            this.btnJustificar.TabIndex = 9;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Validar Justificativa";
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(-2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 97);
            this.label6.TabIndex = 10;
            // 
            // ValidarJustificativaPontoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(588, 363);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnJustificar);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tfJustificativa);
            this.Controls.Add(this.tfCodOcorrencia);
            this.Controls.Add(this.tfCodPonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ValidarJustificativaPontoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCPoint - Validar Justificativa";
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
        private System.Windows.Forms.Button btnJustificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}