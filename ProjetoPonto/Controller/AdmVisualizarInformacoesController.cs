using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coprel.View;
using ProjetoPonto.DAO;
using ProjetoPonto.Model;

namespace Coprel.Controller
{
    class AdmVisualizarInformacoesController
    {
        public static void PreencherCampos(AdmVisualizarInformacoesView tela, int numeroRegistro)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            IList<Funcionario> lista = dao.PreencheCamposAVF(numeroRegistro);

            int count = lista.Count();

            foreach (Funcionario f in lista)
            {
                tela.numReg.Text = Convert.ToString(f.GetNumeroRegistro());
                tela.nome.Text = Convert.ToString(f.GetNome());
                tela.cpf.Text = Convert.ToString(f.GetCPF());
                tela.cnh.Text = Convert.ToString(f.GetCNH());
                tela.funcao.Text = Convert.ToString(f.GetNomeFuncao());
                tela.setor.Text = Convert.ToString(f.GetNomeSetor());
                tela.ctps.Text = Convert.ToString(f.GetCTPS());
                tela.dtAdm.Text = Convert.ToString(f.GetDataAdmissao());
                tela.dtNasc.Text = Convert.ToString(f.GetDataNascimento());
                tela.rg.Text = Convert.ToString(f.GetRG());
            }
        }

        public static void PreencherTabela(AdmVisualizarInformacoesView tela, int numeroRegistro)
        {
            DataSet ds = FuncionarioDAO.PreencheTabelaPontoAVF(numeroRegistro);
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }
    }
}
