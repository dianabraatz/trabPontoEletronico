using System;
using ProjetoPonto.View;
using ProjetoPonto.Model;
using ProjetoPonto.DAO;
using ProjetoPonto;
using System.Windows.Forms;
using ProjetoPonto.Controller;

namespace Coprel.Controller
{
    class LoginController
    {
        public void VerificaUsuario(LoginView tela)
        {
            int numRegistro = Convert.ToInt32(tela.tfNumeroRegistro.Text);
            string senha = tela.tfSenha.Text;

            Funcionario f = new Funcionario();
            f.SetNumeroRegistro(numRegistro);
            f.SetSenha(senha);

            FuncionarioDAO obj = new FuncionarioDAO();
            bool result = obj.verificaLogin(f);

            if (result)
            {
                VerificaNivelAcesso(f);
                tela.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao efetuar login");
                tela.Show();
            }

        }

        public void VerificaNivelAcesso(Funcionario f)
        {
            FuncionarioDAO obj = new FuncionarioDAO();
            int nivelAcesso = obj.VerificaNivelAcesso(f);

            if (nivelAcesso == 1)
            {
                PontoAdministradorView telaAdmin = new PontoAdministradorView(f.GetNumeroRegistro());
                telaAdmin.Show();
            }
            else
            {
                PontoController.ExecutaPonto(f.GetNumeroRegistro());
            }
        }
    }
}
