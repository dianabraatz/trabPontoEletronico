using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPonto.Controller;

namespace ProjetoPonto.View
{
    public partial class CadastrarFuncionarioView : Form
    {
        public CadastrarFuncionarioView()
        {
            InitializeComponent();
            AdmCadastrarFuncionarioController.PreencheCBFuncao(this);
            AdmCadastrarFuncionarioController.PreencheCBSetor(this);
            AdmCadastrarFuncionarioController.InicializaCompontente(this);

            tfConfirmaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AdmCadastrarFuncionarioController f = new AdmCadastrarFuncionarioController();
            f.CadastrarFuncionario(this);
        }

        private void tfSenha_Leave(object sender, EventArgs e)
        {
            if (this.tfSenha.Text != string.Empty)
            {
                tfConfirmaSenha.Enabled = true;
                btnCadastrar.Enabled = true;
            }
            else
                tfConfirmaSenha.Enabled = false;
        }
    }
}
