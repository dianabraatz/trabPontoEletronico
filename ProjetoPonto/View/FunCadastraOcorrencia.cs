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
using Coprel.DAO;

namespace Coprel.View
{
    public partial class FunCadastraOcorrencia : Form
    {
        public FunCadastraOcorrencia(string nome, string data, int codigo)
        {
            InitializeComponent();

            tfCod.Text = Convert.ToString(codigo);
            lbNome.Text = Convert.ToString(nome);
            tfData.Text = Convert.ToString(data);

            OcorrenciasController.PreencheCBStatus(this);
            OcorrenciasController.PreencherCBJustificativa(this);

        }

        private void checkOutras_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkOutras.Checked)
            {
                tfJustificativa.Enabled = true;
                cbJustificativa.Enabled = false;
            }else
            {
                tfJustificativa.Enabled = false;
                cbJustificativa.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string justificativa;
            OcorrenciasController obj = new OcorrenciasController();

            if (checkOutras.Checked)
            {
                justificativa = tfJustificativa.Text;
            }
            else
            {
                justificativa = cbJustificativa.Text;
            }


            obj.CadastraOcorrencia(this, justificativa);
        }

        private void FunCadastraOcorrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
