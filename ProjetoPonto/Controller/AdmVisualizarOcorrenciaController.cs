using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coprel.View;
using Coprel.DAO;
using System.Data;
using Coprel.Model;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class AdmVisualizarOcorrenciaController
    {
        public static void PreencheTabela(AdmVisualizarOcorrenciasView tela)
        {
            OcorrenciaDAO obj = new OcorrenciaDAO();
            DataSet ds = obj.PreencheTabelaAdm();
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }

        public static void PreencherCBStatus(ValidarJustificativaPontoView tela)
        {
                DataTable data = OcorrenciaDAO.PreencheCBStatus();
                tela.cbStatus.DataSource = data;
                tela.cbStatus.ValueMember = "idStatus";
                tela.cbStatus.DisplayMember = "descricao";
        }

        public static void PreencherCampos(ValidarJustificativaPontoView tela, int codigoOcorrencia)
        {
            OcorrenciaDAO dao = new OcorrenciaDAO();
            IList<Ocorrencia> obj = dao.PreencherCampos(codigoOcorrencia);

            int count = obj.Count();

            foreach (Ocorrencia o in obj)
            {
                tela.tfCodOcorrencia.Text = Convert.ToString(o.GetCodOcorrencia());
                tela.tfCodPonto.Text = Convert.ToString(o.GetCodPonto());
                tela.tfJustificativa.Text = o.GetJustificativa();
                tela.cbStatus.SelectedValue = o.GetStatus();
            }
        }

        public static void EditarOcorrencia(ValidarJustificativaPontoView tela)
        {
            int codigoPonto = Convert.ToInt32(tela.tfCodPonto.Text);
            int codigoOcorrencia = Convert.ToInt32(tela.tfCodOcorrencia.Text);
            string Justificativa = tela.tfJustificativa.Text;
            int status = Convert.ToInt32(tela.cbStatus.SelectedValue);

            Ocorrencia o = new Ocorrencia();
            o.SetCodOcorrencia(codigoOcorrencia);
            o.SetCodPonto(codigoPonto);
            o.SetJustificativa(Justificativa);
            o.SetStatus(status);

            MessageBox.Show("" + status);

            OcorrenciaDAO obj = new OcorrenciaDAO();
            int rs = obj.EditarOcorrencia(o);

            if (rs == 1)
            {
                MessageBox.Show("A ocorrencia de código " + o.GetCodOcorrencia() + " foi alterada com sucesso.");
            }
            else
                MessageBox.Show("Houve algum erro ao justificar a ocorrencia.");
        }

    }
    }
}
