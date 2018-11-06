using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.Relatórios
{
    public partial class FormRelPontoFuncionario : Form
    {
        public FormRelPontoFuncionario()
        {
            InitializeComponent();
        }

        private void FormRelPontoFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdpontoDataSet.DataTablePF'. Você pode movê-la ou removê-la conforme necessário.
            this.pFTableAdapter.FillPF(this.bdpontoDataSet.DataTablePF);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
