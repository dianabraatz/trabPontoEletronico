using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoPonto.View;
using ProjetoPonto.Model;
using ProjetoPonto.DAO;
using System.Data;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class EditarFuncionarioController
    {
        //string str;

        public static void PreencheCBFuncao(EditarFuncionarioView tela)
        {
            DataTable data = FuncionarioDAO.PreencheCBFuncao();
            tela.cbFuncao.DataSource = data;
            tela.cbFuncao.ValueMember = "codFuncao";
            tela.cbFuncao.DisplayMember = "nome";
        }

        public static void PreencheCBSetor(EditarFuncionarioView tela)
        {
            DataTable data = FuncionarioDAO.PreencheCBSetor();
            tela.cbSetor.DataSource = data;
            tela.cbSetor.ValueMember = "codSetor";
            tela.cbSetor.DisplayMember = "nome";
        }

        public static void PreencheCampos(EditarFuncionarioView tela, int numeroRegistro)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            IList<Funcionario> obj = dao.PreencheCampos(numeroRegistro);

            int count = obj.Count();

            foreach (Funcionario f in obj)
            {
                tela.tfNome.Text = f.GetNome();
                tela.tfCNH.Text = f.GetCNH();
                tela.tfCPF.Text = f.GetCPF();
                tela.tfCTPS.Text = f.GetCTPS();
                tela.tfDataAdmissao.Text = Convert.ToString(f.GetDataAdmissao());
                tela.tfDataNascimento.Text = Convert.ToString(f.GetDataNascimento());
                tela.tfNumeroRegistro.Text = Convert.ToString(f.GetNumeroRegistro());
                tela.tfRG.Text = f.GetRG();
                tela.cbFuncao.SelectedValue = f.GetCodFuncao();
                tela.cbSetor.SelectedValue = f.GetCodSetor();
            }
        }

        public void EditaFuncionario(EditarFuncionarioView tela)
        {
            //System.Data.SqlClient.SqlException: 'The parameterized query '(@numRegistro int, @senha nvarchar(4000), @DataNascimento datetime' expects the parameter '@senha', which was not supplied.'

            Funcionario f = new Funcionario();
            f.SetNumeroRegistro(Convert.ToInt32(tela.tfNumeroRegistro.Text));
            f.SetNome(tela.tfNome.Text);
            f.SetRG(tela.tfRG.Text);
            f.SetDataNascimento(Convert.ToDateTime(tela.tfDataNascimento.Text));
            f.SetDataAdmissao(Convert.ToDateTime(tela.tfDataAdmissao.Text));
            f.SetCPF(tela.tfCPF.Text);
            f.SetCTPS(tela.tfCTPS.Text);
            f.SetCNH(tela.tfCNH.Text);
            f.SetCodFuncao(Convert.ToInt32(tela.cbFuncao.SelectedValue));
            f.SetCodSetor(Convert.ToInt32(tela.cbSetor.SelectedValue));

            FuncionarioDAO funcionario = new FuncionarioDAO();
            int resultado = funcionario.EditarFuncionario(f);

            if (resultado == 1)
            {
                MessageBox.Show("Dados do funcionario " + f.GetNome() + " alterados com sucesso!");
            }
            else
                MessageBox.Show("Não foi possível alterar os dados do usuário. Tente novamente.");
        }
    }
}
