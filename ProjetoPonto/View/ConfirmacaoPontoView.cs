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

namespace ProjetoPonto.View
{
    public partial class ConfirmacaoPontoView : Form
    {
        public ConfirmacaoPontoView(int numeroRegistro)
        {
            InitializeComponent();
            PontoController.ConfirmaPonto(numeroRegistro, this);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginView obj = new LoginView();
            this.Close();
            obj.Show();
        }

        private void ConfirmacaoPontoView_Load(object sender, EventArgs e)
        {

        }
    }
}
