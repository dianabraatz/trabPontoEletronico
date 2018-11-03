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
            FuncaoController.PreencherTabela(this);
            FuncaoController.DesabilitarItens(this);
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

                    cbEditar.Visible = true;
                }
                else
                {
                }

            }
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked == true)
            {
                if (tbDescricao.Text == String.Empty || tbID.Text == String.Empty)
                {
                    btnCadastrar.Enabled = false;
                }
                else
                    btnCadastrar.Enabled = true;

                cbNivelAcesso.Enabled = true;
                tbDescricao.Enabled = true;

                btnEditar.Visible = true;
                btnLimpar.Enabled = true;
                btnExcluir.Visible = true;
            }
            else
                FuncaoController.DesabilitarItens(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbDescricao.Text = "";
            tbID.Text = "";
            cbNivelAcesso.SelectedValue = 0;

            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCadastrar.Enabled = true;
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
    }
}
