using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Coprel.View;
using ProjetoPonto.Model;
using ProjetoPonto.DAO;

namespace Coprel.Controller
{
    class AdmAlterarSenhaController
    {
        public static bool ConfereSenhas(AdmAlteraSenhaView tela)
        {
            if (tela.tbSenha.Text != String.Empty)
            {
                if (tela.tbConfirma.Text != String.Empty)
                {
                    if (tela.tbSenha.Text.Equals(tela.tbConfirma.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
                MessageBox.Show("Os campos não podem ser nulos.");
            return false;

        }

        public static void AlteraSenha(AdmAlteraSenhaView tela, int numeroRegistro)
        {
            if (ConfereSenhas(tela))
            {
                Funcionario f = new Funcionario();
                f.SetSenha(Convert.ToString(tela.tbSenha.Text));
                f.SetNumeroRegistro(numeroRegistro);

                FuncionarioDAO obj = new FuncionarioDAO();
                int resultado = obj.AlteraSenha(f);

                if (resultado == 1)
                {
                    MessageBox.Show("A senha foi alterada com sucesso.");
                    tela.Close();
                }
                else
                    MessageBox.Show("Houve algum erro ao alterar a senha. Tente novamente.");
                tela.Close();

            }
            else
            {
                MessageBox.Show("As senhas precisam ser identicas.");
                tela.tbConfirma.Text = "";
            }
                
                
        }
    }
}
