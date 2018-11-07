using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            btnJustificar.Enabled = false;
            cbTodos.Checked = false;

            AdmVisualizarOcorrenciaController.PreencheTabela(this);

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
                    label7.Text = Convert.ToString(dr["Justificativa"].ToString());
                    label5.Text = Convert.ToString(dr["Nome do Funcionário"].ToString());

                    DateTime dt = DateTime.ParseExact(dr["Data"].ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    label6.Text = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);

                    codigoOcorrencia = Convert.ToInt32(dr["Código da Ocorrencia"].ToString());

                    btnJustificar.Enabled = true;
                }
                else
                    btnJustificar.Enabled = false;
            }
        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            ValidarJustificativaPontoView obj = new ValidarJustificativaPontoView(codigoOcorrencia);
            obj.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string nome = tfBuscar.Text;
            AdmVisualizarOcorrenciaController.FiltraFuncionario(this, nome);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            AdmVisualizarOcorrenciaController.PreencheTabela(this);
        }

        private void tfBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            tfBuscar.Text = "";
        }

        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTodos.Checked == true)
            {
                AdmVisualizarOcorrenciaController.PreencheTabelaTodos(this);
            }
            else
                AdmVisualizarOcorrenciaController.PreencheTabela(this);
        }
    }
}
