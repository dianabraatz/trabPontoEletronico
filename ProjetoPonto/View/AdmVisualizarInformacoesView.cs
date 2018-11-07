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
using ProjetoPonto.View;

namespace Coprel.View
{
    public partial class AdmVisualizarInformacoesView : Form
    {

        int numRegistro = 0;
        public AdmVisualizarInformacoesView(int numeroRegistro)
        {
            InitializeComponent();

            numRegistro = numeroRegistro;
            AdmVisualizarInformacoesController.PreencherCampos(this, numeroRegistro);
            AdmVisualizarInformacoesController.PreencherTabela(this, numeroRegistro);
        }

        private void AdmVisualizarInformacoes_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarFuncionarioView obj = new EditarFuncionarioView(numRegistro);
            obj.Show();

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmAlteraSenhaView obj = new AdmAlteraSenhaView(numRegistro);
            obj.Show();
        }
    }
}
