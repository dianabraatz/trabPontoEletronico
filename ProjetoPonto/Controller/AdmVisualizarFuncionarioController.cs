using ProjetoPonto.DAO;
using ProjetoPonto.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class AdmVisualizarFuncionarioController
    {
        public static void PreencherTabela(VisualizarFuncionarioView tela)
        {
            DataSet ds = FuncionarioDAO.PreencheTabela();
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }


        public static void ExecutarFiltro(VisualizarFuncionarioView tela)
        {
            string sql = "";
            string valor = tela.tfBuscar.Text;
            int filtro = tela.cbFiltro.SelectedIndex;

            if (filtro != 0)
            {
                if (!String.IsNullOrEmpty(valor))
                {
                    //DataSet ds;
                    switch (filtro)
                    {
                        case 1:
                            sql = "SELECT f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionario', s.nome as Setor, fu.nome as Função, f.cpf as CPF, f.dataNascimento AS 'Data de Nascimento' " +
                             "FROM funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fu ON f.codFuncao = fu.codFuncao WHERE f.nome LIKE @valor";
                            break;
                        case 2:
                            sql = "SELECT f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionario', s.nome as Setor, fu.nome as Função, f.cpf as CPF, f.dataNascimento AS 'Data de Nascimento' " +
                             "FROM funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fu ON f.codFuncao = fu.codFuncao WHERE s.nome LIKE @valor";
                            break;
                        case 3:
                            sql = "SELECT f.numRegistro as 'Numero de Registro', f.nome as 'Nome do Funcionario', s.nome as Setor, fu.nome as Função, f.cpf as CPF, f.dataNascimento AS 'Data de Nascimento' " +
                              "FROM funcionario f JOIN setor s ON f.codSetor = s.codSetor JOIN funcao fu ON f.codFuncao = fu.codFuncao WHERE fu.nome LIKE @valor";
                            break;
                    }
                    DataSet ds = FuncionarioDAO.ExecutaFiltro(sql, valor);
                    tela.tabela.DataSource = ds;
                    tela.tabela.DataMember = ds.Tables[0].TableName;
                }
            }
            else
                MessageBox.Show("Selecione algum filtro.");
        }

        public static void ExcluirFuncionario(int numRegistro)
        {
            DialogResult dr = MessageBox.Show("Deseja excluir o usuário escolhido?", "Confirmação", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                FuncionarioDAO obj = new FuncionarioDAO();
                bool rs = obj.ExcluirFuncionario(numRegistro);

                if (rs)
                {
                    MessageBox.Show("O usuário foi excluido com sucesso.");
                }
                else
                    MessageBox.Show("Houve um erro na exclusão do usuário.");
            }
        }
    }
}
