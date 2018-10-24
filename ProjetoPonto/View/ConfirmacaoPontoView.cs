using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.View;
using ProjetoPonto.Controller;

namespace ProjetoPonto.View
{
    public partial class ConfirmacaoPontoView : Form
    {
        int numReg = 0;
        string res;
        public ConfirmacaoPontoView(int numeroRegistro)
        {
            InitializeComponent();
            PontoController.VerificaPontosLogin(this, numeroRegistro);
            res = PontoController.ConfirmaPonto(numeroRegistro, this);


            numReg = numeroRegistro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginView obj = new LoginView();
            this.Close();
            obj.Show();
        }

        private void PreencheDados()
        {
        }

        private void ConfirmacaoPontoView_Load(object sender, EventArgs e)
        {

        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            FunOcorrenciaView obj = new FunOcorrenciaView(numReg, res);
            obj.Show();
            this.Hide();
        }
    }
}
