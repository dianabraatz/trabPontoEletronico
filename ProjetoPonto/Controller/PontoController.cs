using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoPonto.DAO;
using ProjetoPonto.View;
using System.Windows.Forms;

namespace ProjetoPonto.Controller
{
    class PontoController
    {
        public static void ExecutaPonto(int numRegistro)
        {
            string sql;
            int resultado = 0;

            PontoDAO obj = new PontoDAO();
            int result = obj.VerificaPonto(numRegistro);

            switch (result)
            {
                case 1:
                    sql = "INSERT INTO ponto(dh_ponto1, numRegistro) VALUES (CURRENT_TIMESTAMP, @numRegistro);";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    break;

                case 2:
                    sql = "UPDATE ponto SET dh_ponto2 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro;";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    break;

                case 3:
                    sql = "UPDATE ponto SET dh_ponto3 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro;";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    break;

                case 4:
                    sql = "UPDATE ponto SET dh_ponto4 = CURRENT_TIMESTAMP WHERE CONVERT(date, dh_ponto1)= CONVERT(date, CURRENT_TIMESTAMP) AND numregistro = @numRegistro";
                    resultado = obj.CadastrarPonto(numRegistro, sql);
                    break;

                case 5:
                    MessageBox.Show("O funcionário já cadastrou todos os pontos diários possiveis");
                    break;

                case 6:
                    MessageBox.Show("Ocorreu um erro ao cadastrar o ponto.");
                    break;
            }

            if (resultado == 1)
            {
                ConfirmacaoPontoView tela = new ConfirmacaoPontoView(numRegistro);
                tela.Show();
            }
            else
            {
                LoginView tela = new LoginView();
                tela.Show();
            }


        }

        public static string ConfirmaPonto(int numRegistro, ConfirmacaoPontoView tela)
        {
            PontoDAO obj = new PontoDAO();
            List<String> resultado = obj.ConfirmaPonto(numRegistro);

            string res = resultado[2];
            tela.nome.Text = resultado[2];
            tela.data.Text = resultado[0];
            tela.hora.Text = resultado[1];
            tela.numRegistro.Text = resultado[3];
            return res;
        }

        public static void VerificaPontosLogin(ConfirmacaoPontoView tela, int numeroRegistro)
        {
            PontoDAO dao = new PontoDAO();
            bool rs = dao.VerificaPontoLargada(numeroRegistro);

            if (rs)
            {
                tela.btnOcorrencias.Visible = true;
            }
            else
                tela.btnOcorrencias.Visible = false;
        }
    }
}
