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
    public partial class AdmVisualizarOcorrenciasView : Form
    {
        int codigoOcorrencia = 0;
        public AdmVisualizarOcorrenciasView()
        {
            InitializeComponent();

        }

        private void AdmVisualizarOcorrenciasView_Load(object sender, EventArgs e)
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
                    label6.Text = Convert.ToString(dr["Data"].ToString());
                    label7.Text = Convert.ToString(dr["Justificativa"].ToString());
                    label5.Text = Convert.ToString(dr["Nome do Funcionário"].ToString());
                    codigoOcorrencia = Convert.ToInt32(dr["Código da Ocorrencia"].ToString());

                    btnJustificar.Enabled = true;
                }
                else
                    btnJustificar.Enabled = false;
            }
        }
    }
}
