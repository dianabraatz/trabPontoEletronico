using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.Controller;

namespace Coprel.View
{
    public partial class AdmAlteraSenhaView : Form
    {
        int numeroRegistro = 0;
        public AdmAlteraSenhaView(int numRegistro)
        {
            InitializeComponent();
            numeroRegistro = numRegistro;
            tbConfirma.Enabled = false;
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            if (tbSenha.Text != String.Empty)
            {
                tbConfirma.Enabled = true;
            }
            else
                tbConfirma.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdmAlterarSenhaController.AlteraSenha(this, numeroRegistro);
        }
    }
}
