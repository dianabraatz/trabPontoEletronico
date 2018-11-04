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
    public partial class AdmVisualizarInformacoesView : Form
    {
        public AdmVisualizarInformacoesView(int numeroRegistro)
        {
            InitializeComponent();
            AdmVisualizarInformacoesController.PreencherCampos(this, numeroRegistro);
            AdmVisualizarInformacoesController.PreencherTabela(this, numeroRegistro);
        }

        private void AdmVisualizarInformacoes_Load(object sender, EventArgs e)
        {

        }
    }
}
