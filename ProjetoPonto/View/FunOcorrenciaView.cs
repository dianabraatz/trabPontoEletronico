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
using Coprel.Controller;

namespace Coprel.View
{
    public partial class FunOcorrenciaView : Form
    {
        int codigo;
        string data, nomeFuncionario;

        public FunOcorrenciaView(int numeroRegistro, string nome)
        {
            InitializeComponent();
            OcorrenciasController.PreencherTabela(this, numeroRegistro);
            nomeFuncionario = nome;
            lbNome.Text = Convert.ToString(nome);
            lbNumero.Text = Convert.ToString(numeroRegistro);

            btnJustificar.Enabled = false;
        }

        private void FunOcorrenciaView_Load(object sender, EventArgs e)
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
                    codigo = Convert.ToInt32(dr["Código"].ToString());
                    data = Convert.ToString(dr["data"].ToString());

                    btnJustificar.Enabled = true;
                }
                else
                    btnJustificar.Enabled = false;
            }
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            FunCadastraOcorrencia obj = new FunCadastraOcorrencia(nomeFuncionario,data,codigo);
            obj.Show();
        }
    }
}
