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

            this.reportViewer1.RefreshReport();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
