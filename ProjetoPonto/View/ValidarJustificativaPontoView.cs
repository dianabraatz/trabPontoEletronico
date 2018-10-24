﻿using System;
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
    public partial class ValidarJustificativaPontoView : Form
    {
        public ValidarJustificativaPontoView(int codigoOcorrencia)
        {
            InitializeComponent();
            AdmVisualizarOcorrenciaController.PreencherCampos(this, codigoOcorrencia);
            AdmVisualizarOcorrenciaController.PreencherCBStatus(this);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidarJustificativaPontoView_Load(object sender, EventArgs e)
        {

        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {
            AdmVisualizarOcorrenciaController.EditarOcorrencia(this);
        }
    }
}
