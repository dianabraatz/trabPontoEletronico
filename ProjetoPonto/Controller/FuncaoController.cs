using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coprel.DAO;
using Coprel.View;

namespace Coprel.Controller
{
    class FuncaoController
    {
        public static void PreencherTabela(FuncaoView tela)
        {
            DataSet ds = FuncaoDAO.PreencheTabela();
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }

        public static void DesabilitarItens(FuncaoView tela)
        {
            tela.tbID.Enabled = false;
            tela.tbDescricao.Enabled = false;
            tela.cbNivelAcesso.Enabled = false;

            tela.btnEditar.Visible = false;
            tela.btnExcluir.Visible = false;
            tela.btnCadastrar.Enabled = true;
        }

        public static void PreencherCBNivelAcesso(FuncaoView tela)
        {
            DataTable data = FuncaoDAO.PreencheCBNivelAcesso();
            tela.cbNivelAcesso.DataSource = data;
            tela.cbNivelAcesso.ValueMember = "nivelAcesso";
            tela.cbNivelAcesso.DisplayMember = "nivelAcesso";
        }
    }
}
