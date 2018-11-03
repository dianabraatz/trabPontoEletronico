using Coprel.DAO;
using Coprel.View;
using ProjetoPonto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coprel.Controller
{
    class SetorController
    {
        public static void PreencherTabela(SetorView tela)
        {
            DataSet ds = SetorDAO.PreencheTabela();
            tela.tabela.DataSource = ds;
            tela.tabela.DataMember = ds.Tables[0].TableName;
        }

        public static void CadastrarSetor(SetorView tela)
        {
            string nome = tela.tbNome.Text;

            Setor obj = new Setor();
            obj.SetNome(nome);

            SetorDAO dao = new SetorDAO();
            int resultado = dao.CadastraSetor(obj);

            if (resultado == 1)
            {
                MessageBox.Show("O setor foi cadastrado com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Houve um erro ao cadastrar o setor.");
        }

        public static void ExcluirSetor(SetorView tela)
        {
            int codigo = Convert.ToInt32(tela.tbCodigo.Text);

            Setor obj = new Setor();
            obj.SetCodSetor(codigo);

            SetorDAO dao = new SetorDAO();
            int resultado = dao.ExcluiSetor(obj);

            if (resultado == 1)
            {
                MessageBox.Show("A exclusão foi realizada com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Houve um erro ao excluir o setor. Tente novamente.");
        }

        public static void EditarSetor(SetorView tela)
        {
            int codigo = Convert.ToInt32(tela.tbCodigo.Text);
            string nome = tela.tbNome.Text;

            Setor obj = new Setor();
            obj.SetCodSetor(codigo);
            obj.SetNome(nome);

            SetorDAO dao = new SetorDAO();
            int resultado = dao.EditaSetor(obj);

            if (resultado == 1)
            {
                MessageBox.Show("Setor alterado com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Houve um erro ao editar o setor.");
        }

        public static void LimparCampos(SetorView tela)
        {
            tela.tbCodigo.Text = "";
            tela.tbNome.Text = "";
            tela.btnCadastrar.Enabled = false;
        }

        public static void HabilitarBotoes(SetorView tela)
        {
            if((tela.tbCodigo.Text != String.Empty) && (tela.tbNome.Text != String.Empty))
            {
                tela.btnCadastrar.Enabled = false;
                tela.btnEditar.Enabled = true;
                tela.btnExcluir.Enabled = true;

            }else if((tela.tbCodigo.Text == String.Empty) && (tela.tbNome.Text != String.Empty)) {
                tela.btnCadastrar.Enabled = true;
                tela.btnEditar.Enabled = false;
                tela.btnExcluir.Enabled = false;

            }else if((tela.tbCodigo.Text == String.Empty) && (tela.tbNome.Text != String.Empty)) {
                tela.btnCadastrar.Enabled = false;
                tela.btnEditar.Enabled = false;
                tela.btnExcluir.Enabled = false;

            }
        }
    }
}
