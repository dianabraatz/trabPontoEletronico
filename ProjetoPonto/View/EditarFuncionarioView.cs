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
using ProjetoPonto.Controller;

namespace ProjetoPonto.View
{
    public partial class EditarFuncionarioView : Form
    {
        int numeroRegistro;
        public EditarFuncionarioView(int numero)
        {
            InitializeComponent();
            numeroRegistro = numero;

            EditarFuncionarioController.PreencheCBFuncao(this);
            EditarFuncionarioController.PreencheCBSetor(this);

            EditarFuncionarioController.PreencheCampos(this, numeroRegistro);

        }

        private void EditarFuncionarioView_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionarioController obj = new EditarFuncionarioController();
            obj.EditaFuncionario(this);
        }
    }
}
