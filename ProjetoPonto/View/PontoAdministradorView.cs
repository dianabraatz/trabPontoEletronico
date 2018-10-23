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
    public partial class PontoAdministradorView : Form
    {
        int numRegistro = 0;

        public PontoAdministradorView(int numero)
        {
            InitializeComponent();
            numRegistro = numero;
        }

        private void PontoAdministradorView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeAdministrador obj = new HomeAdministrador();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PontoController.ExecutaPonto(numRegistro);
        }

    }
}
