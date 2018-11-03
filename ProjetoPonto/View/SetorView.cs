using Coprel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.View
{
    public partial class SetorView : Form
    {
        public SetorView()
        {
            InitializeComponent();

            tbCodigo.Enabled = false;
            tbNome.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;

            SetorController.PreencherTabela(this);
        }

        private void SetorView_Load(object sender, EventArgs e)
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
                    tbCodigo.Text = Convert.ToString(dr["Código"].ToString());
                    tbNome.Text = Convert.ToString(dr["Nome"].ToString());
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SetorController.CadastrarSetor(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja continuar com a exclusão?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                SetorController.ExcluirSetor(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja alterar o nome de setor?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                SetorController.EditarSetor(this);
            }
        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked)
            {
                tbNome.Enabled = true;
               
            }
            else
            {
                tbNome.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            SetorController.LimparCampos(this);
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            SetorController.HabilitarBotoes(this);
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            SetorController.HabilitarBotoes(this);
        }
    }
}
