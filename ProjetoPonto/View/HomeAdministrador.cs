﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.View;
using ProjetoPonto.View;

namespace ProjetoPonto.View
{
    public partial class HomeAdministrador : Form
    {
        public HomeAdministrador()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            VisualizarFuncionarioView obj = new VisualizarFuncionarioView();
            obj.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            AdmVisualizarOcorrenciasView obj = new AdmVisualizarOcorrenciasView();
            obj.Show();
        }
    }
}
