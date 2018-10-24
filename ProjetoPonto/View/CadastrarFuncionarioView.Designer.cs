namespace ProjetoPonto.View
{
    partial class CadastrarFuncionarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFuncionarioView));
            this.tfRG = new System.Windows.Forms.MaskedTextBox();
            this.tfDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.tfDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tfCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tfConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tfCTPS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tfCNH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tfNome = new System.Windows.Forms.TextBox();
            this.tfNumeroRegistro = new System.Windows.Forms.TextBox();
            this.tfSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tfRG
            // 
            this.tfRG.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfRG.Location = new System.Drawing.Point(287, 213);
            this.tfRG.Mask = "00000000000000";
            this.tfRG.Name = "tfRG";
            this.tfRG.Size = new System.Drawing.Size(267, 27);
            this.tfRG.TabIndex = 62;
            // 
            // tfDataAdmissao
            // 
            this.tfDataAdmissao.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfDataAdmissao.Location = new System.Drawing.Point(287, 342);
            this.tfDataAdmissao.Mask = "00/00/0000";
            this.tfDataAdmissao.Name = "tfDataAdmissao";
            this.tfDataAdmissao.Size = new System.Drawing.Size(267, 27);
            this.tfDataAdmissao.TabIndex = 61;
            this.tfDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // tfDataNascimento
            // 
            this.tfDataNascimento.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfDataNascimento.Location = new System.Drawing.Point(287, 310);
            this.tfDataNascimento.Mask = "00/00/0000";
            this.tfDataNascimento.Name = "tfDataNascimento";
            this.tfDataNascimento.Size = new System.Drawing.Size(267, 27);
            this.tfDataNascimento.TabIndex = 60;
            this.tfDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tfCPF
            // 
            this.tfCPF.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCPF.Location = new System.Drawing.Point(287, 245);
            this.tfCPF.Mask = "000.000.000-00";
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Size = new System.Drawing.Size(267, 27);
            this.tfCPF.TabIndex = 63;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(88, 557);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(107, 31);
            this.btnVoltar.TabIndex = 59;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(334, 557);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 31);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(447, 557);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 31);
            this.btnCadastrar.TabIndex = 57;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tfConfirmaSenha
            // 
            this.tfConfirmaSenha.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfConfirmaSenha.Location = new System.Drawing.Point(287, 503);
            this.tfConfirmaSenha.Name = "tfConfirmaSenha";
            this.tfConfirmaSenha.Size = new System.Drawing.Size(267, 27);
            this.tfConfirmaSenha.TabIndex = 56;
            this.tfConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Confirmar senha";
            // 
            // cbFuncao
            // 
            this.cbFuncao.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(287, 407);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(267, 28);
            this.cbFuncao.TabIndex = 54;
            // 
            // cbSetor
            // 
            this.cbSetor.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(287, 439);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(267, 28);
            this.cbSetor.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "CTPS ...........................";
            // 
            // tfCTPS
            // 
            this.tfCTPS.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCTPS.Location = new System.Drawing.Point(287, 375);
            this.tfCTPS.Name = "tfCTPS";
            this.tfCTPS.Size = new System.Drawing.Size(267, 27);
            this.tfCTPS.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Setor ...........................";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Função ........................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "CNH .............................";
            // 
            // tfCNH
            // 
            this.tfCNH.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCNH.Location = new System.Drawing.Point(287, 277);
            this.tfCNH.Name = "tfCNH";
            this.tfCNH.Size = new System.Drawing.Size(267, 27);
            this.tfCNH.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "CPF ..............................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "RG ................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nome ............................";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Data de Admissão ........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data de Nascimento .....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Senha ..........................";
            // 
            // tfNome
            // 
            this.tfNome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNome.Location = new System.Drawing.Point(287, 181);
            this.tfNome.Name = "tfNome";
            this.tfNome.Size = new System.Drawing.Size(267, 27);
            this.tfNome.TabIndex = 40;
            // 
            // tfNumeroRegistro
            // 
            this.tfNumeroRegistro.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNumeroRegistro.Location = new System.Drawing.Point(287, 149);
            this.tfNumeroRegistro.Name = "tfNumeroRegistro";
            this.tfNumeroRegistro.Size = new System.Drawing.Size(267, 27);
            this.tfNumeroRegistro.TabIndex = 39;
            // 
            // tfSenha
            // 
            this.tfSenha.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSenha.Location = new System.Drawing.Point(287, 471);
            this.tfSenha.Name = "tfSenha";
            this.tfSenha.Size = new System.Drawing.Size(267, 27);
            this.tfSenha.TabIndex = 38;
            this.tfSenha.UseSystemPasswordChar = true;
            this.tfSenha.Leave += new System.EventHandler(this.tfSenha_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Numero de Registro ......";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 94);
            this.label9.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(354, 33);
            this.label14.TabIndex = 65;
            this.label14.Text = "Cadastro de Funcionário";
            // 
            // CadastrarFuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(642, 612);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tfRG);
            this.Controls.Add(this.tfDataAdmissao);
            this.Controls.Add(this.tfDataNascimento);
            this.Controls.Add(this.tfCPF);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tfConfirmaSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tfCTPS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tfCNH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfNome);
            this.Controls.Add(this.tfNumeroRegistro);
            this.Controls.Add(this.tfSenha);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFuncionarioView";
            this.Text = "DCPoint - Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.CadastrarFuncionarioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox tfRG;
        public System.Windows.Forms.MaskedTextBox tfDataAdmissao;
        public System.Windows.Forms.MaskedTextBox tfDataNascimento;
        public System.Windows.Forms.MaskedTextBox tfCPF;
        public System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.TextBox tfConfirmaSenha;
        public System.Windows.Forms.ComboBox cbFuncao;
        public System.Windows.Forms.ComboBox cbSetor;
        public System.Windows.Forms.TextBox tfCTPS;
        public System.Windows.Forms.TextBox tfCNH;
        public System.Windows.Forms.TextBox tfNome;
        public System.Windows.Forms.TextBox tfNumeroRegistro;
        public System.Windows.Forms.TextBox tfSenha;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
    }
}