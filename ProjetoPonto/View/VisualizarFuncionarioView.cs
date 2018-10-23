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
        int numeroRegistro;

        public VisualizarFuncionarioView()
        {
            InitializeComponent();
            FuncionarioController.PreencherTabela(this);
            PreencheCBFiltro();

            cbFiltro.SelectedIndex = 0;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnVisualizar.Enabled = false;
            tfBuscar.Enabled = false;
            btnFiltrar.Enabled = false;
        }

        private void PreencheCBFiltro()
        {
            cbFiltro.Items.Insert(0, "Selecione o filtro");
            cbFiltro.Items.Insert(1, "Nome");
            cbFiltro.Items.Insert(2, "Setor");
            cbFiltro.Items.Insert(3, "Função");
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioController.ExcluirFuncionario(numeroRegistro);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FuncionarioController.PreencherTabela(this);
            tfBuscar.Text = "";
            cbFiltro.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FuncionarioController.ExecutarFiltro(this);
        }

        private void tfBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tfBuscar.Text != String.Empty)
            {
                btnFiltrar.Enabled = true;
            }
            else
                btnFiltrar.Enabled = false;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex != 0)
            {
                tfBuscar.Enabled = true;
            }
            else
                tfBuscar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionarioView obj = new EditarFuncionarioView(numeroRegistro);
            obj.Show();
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

        private void tabela_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tabela_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha = -1;

            if (tabela.SelectedRows.Count > 0)
            {
                linha = tabela.SelectedRows[0].Index;
            }
            else
            {
                if (tabela.SelectedCells.Count > 0)
                {
                    linha = tabela.SelectedCells[0].RowIndex;
                }
            }

            if (linha != -1)
            {
                if (tabela.Rows[linha].DataBoundItem != null) //verifica se a linha da tabela está vazia
                {
                    DataRowView dr = (DataRowView)tabela.Rows[linha].DataBoundItem;
                    numeroRegistro = Convert.ToInt32(dr["Numero de Registro"].ToString());

                    MessageBox.Show("adm: " + numeroRegistro);

                    btnVisualizar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                else
                {
                    btnVisualizar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }

            }
        }
    }
}
