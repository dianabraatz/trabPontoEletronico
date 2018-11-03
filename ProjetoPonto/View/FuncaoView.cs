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
    public partial class FuncaoView : Form
    {
        public FuncaoView()
        {
            InitializeComponent();

            tbID.Enabled = false;
            tbDescricao.Enabled = false;
            cbNivelAcesso.Enabled = false;

            btnCadastrar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
                       
            FuncaoController.PreencherTabela(this);
            FuncaoController.PreencherCBNivelAcesso(this);

        }

        private void FuncaoView_Load(object sender, EventArgs e)
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
                    tbID.Text = Convert.ToString(dr["Código"].ToString());
                    tbDescricao.Text = Convert.ToString(dr["Descrição"].ToString());
                    cbNivelAcesso.SelectedValue = Convert.ToInt32(dr["Nível de Acesso"].ToString());

                }
            }
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked)
            {
                tbDescricao.Enabled = true;
                cbNivelAcesso.Enabled = true;
            }
            else
            {
                tbDescricao.Enabled = false;
                cbNivelAcesso.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FuncaoController.LimparCampos(this);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FuncaoController.CadastrarFuncao(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja continuar com a exclusão?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                FuncaoController.ExcluirFuncao(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja continuar com a edição?", "Confirmar", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                FuncaoController.EditarFuncao(this);
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            FuncaoController.HabilitarBotoes(this);
        }

        private void tbDescricao_TextChanged(object sender, EventArgs e)
        {
            FuncaoController.HabilitarBotoes(this);
        }
    }
}
