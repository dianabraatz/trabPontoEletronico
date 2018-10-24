namespace ProjetoPonto.View
{
    partial class ConfirmacaoPontoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmacaoPontoView));
            this.button1 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.Label();
            this.numRegistro = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.btnOcorrencias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(108, 106);
            this.nome.Name = "nome";
            this.nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nome.Size = new System.Drawing.Size(200, 20);
            this.nome.TabIndex = 10;
            this.nome.Text = "NOME DO FUNCIONARIO";
            this.nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numRegistro
            // 
            this.numRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRegistro.Location = new System.Drawing.Point(111, 132);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(197, 18);
            this.numRegistro.TabIndex = 9;
            this.numRegistro.Text = "NUM REGISTRO";
            this.numRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(108, 181);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(200, 18);
            this.data.TabIndex = 13;
            this.data.Text = "DATA";
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(108, 157);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(200, 18);
            this.hora.TabIndex = 12;
            this.hora.Text = "HORARIO";
            this.hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOcorrencias
            // 
            this.btnOcorrencias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcorrencias.Location = new System.Drawing.Point(72, 286);
            this.btnOcorrencias.Name = "btnOcorrencias";
            this.btnOcorrencias.Size = new System.Drawing.Size(120, 38);
            this.btnOcorrencias.TabIndex = 14;
            this.btnOcorrencias.Text = "Ocorrencias";
            this.btnOcorrencias.UseVisualStyleBackColor = true;
            this.btnOcorrencias.Click += new System.EventHandler(this.btnOcorrencias_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 76);
            this.label1.TabIndex = 15;
            // 
            // ConfirmacaoPontoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(408, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOcorrencias);
            this.Controls.Add(this.data);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.numRegistro);
            this.Name = "ConfirmacaoPontoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCPoint - Confirmação do Ponto";
            this.Load += new System.EventHandler(this.ConfirmacaoPontoView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label nome;
        public System.Windows.Forms.Label numRegistro;
        public System.Windows.Forms.Label data;
        public System.Windows.Forms.Label hora;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnOcorrencias;
        private System.Windows.Forms.Label label1;
    }
}