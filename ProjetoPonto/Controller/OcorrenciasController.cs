using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPonto.View;
using Coprel.View;
using Coprel.DAO;
using System.Data;
using Coprel.Model;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class OcorrenciasController
    {
        public static void PreencherTabela(FunOcorrenciaView tela, int numRegistro)
        {
            OcorrenciaDAO obj = new OcorrenciaDAO();
            DataSet ds = obj.VerificaPontos(numRegistro);
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;

        }

        public static void PreencherCBJustificativa(FunCadastraOcorrencia tela)
        {
            tela.cbJustificativa.Items.Insert(0, "A serviço da empresa");
            tela.cbJustificativa.Items.Insert(1, "Esquecimento");
            tela.cbJustificativa.Items.Insert(2, "Atestado");
            tela.cbJustificativa.Items.Insert(3, "Problemas no Ponto Eletrônico");
        }

        public void CadastraOcorrencia(FunCadastraOcorrencia tela, string justificativa)
        {
            Ocorrencia o = new Ocorrencia();
            o.SetCodPonto(Convert.ToInt32(tela.tfCod.Text));
            o.SetStatus(Convert.ToInt32(tela.cbStatus.SelectedValue));
            o.SetJustificativa(justificativa);

            OcorrenciaDAO obj = new OcorrenciaDAO();
            int rs = obj.CadastraOcorrencia(o);

            if (rs == 1)
            {
                DialogResult dr = MessageBox.Show("Ocorrência cadastrado com sucesso.", "Confirma", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    tela.Close();
                }
                
            }
            else
                MessageBox.Show("Houve um erro ao cadastrar a ocorrencia.");
        }

        public static void PreencheCBStatus(FunCadastraOcorrencia tela)
        {
            DataTable data = OcorrenciaDAO.PreencheCBStatus();
            tela.cbStatus.DataSource = data;
            tela.cbStatus.ValueMember = "idStatus";
            tela.cbStatus.DisplayMember = "descricao";
            tela.cbStatus.SelectedValue = 1;
        }

        
    }
}
