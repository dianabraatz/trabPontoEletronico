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
    public partial class VisualizarFuncionarioView : Form
    {
        public VisualizarFuncionarioView()
        {
            InitializeComponent();
            FuncionarioController.PreencherTabela(this);
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void tfBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarFuncionarioView_Load(object sender, EventArgs e)
        {

        }
    }
}
