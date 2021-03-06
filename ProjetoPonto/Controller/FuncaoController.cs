﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coprel.DAO;
using Coprel.Model;
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

        public static void PreencherCBNivelAcesso(FuncaoView tela)
        {
            DataTable data = FuncaoDAO.PreencheCBNivelAcesso();
            tela.cbNivelAcesso.DataSource = data;
            tela.cbNivelAcesso.ValueMember = "nivelAcesso";
            tela.cbNivelAcesso.DisplayMember = "nivelAcesso";
        }

        public static void CadastrarFuncao(FuncaoView tela)
        {
            //pega os valores dos text fields
            int nivelAcesso = Convert.ToInt32(tela.cbNivelAcesso.SelectedValue);
            string nome = tela.tbDescricao.Text;

            Funcao obj = new Funcao();
            obj.SetNivelAcesso(nivelAcesso);
            obj.SetNome(nome);

            FuncaoDAO dao = new FuncaoDAO();
            int resultado = dao.CadastraFuncao(obj);

            if (resultado == 1)
            {
                MessageBox.Show("Item inserido com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Houve algum erro ao cadastrar a função, tente novamente.");
        }

        public static void ExcluirFuncao(FuncaoView tela)
        {
            int codigo = Convert.ToInt32(tela.tbID.Text);

            Funcao obj = new Funcao();
            obj.SetCodFuncao(codigo);

            FuncaoDAO dao = new FuncaoDAO();
            int resultado = dao.ExcluiFuncao(obj);

            if (resultado == 1)
            {
                MessageBox.Show("O item foi excluido com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Ocorreu um erro ao excluir a função.");
        }

        public static void EditarFuncao(FuncaoView tela)
        {
            int codigo = Convert.ToInt32(tela.tbID.Text);
            int nivelAcesso = Convert.ToInt32(tela.cbNivelAcesso.SelectedValue);
            string nome = tela.tbDescricao.Text;

            Funcao obj = new Funcao();
            obj.SetCodFuncao(codigo);
            obj.SetNivelAcesso(nivelAcesso);
            obj.SetNome(nome);

            FuncaoDAO dao = new FuncaoDAO();
            int resultado = dao.EditarFuncao(obj);

            if (resultado == 1)
            {
                MessageBox.Show("O item foi alterado com sucesso.");
                PreencherTabela(tela);
            }
            else
                MessageBox.Show("Houve um erro ao efetuar a edição.");
        }

        public static void LimparCampos(FuncaoView tela)
        {
            tela.tbDescricao.Text = "";
            tela.tbID.Text = "";
            tela.cbNivelAcesso.SelectedValue = 0;

            tela.btnCadastrar.Enabled = false;
            tela.btnEditar.Enabled = false;
            tela.btnExcluir.Enabled = false;
        }

        public static void HabilitarBotoes(FuncaoView tela)
        {
            if ((tela.tbID.Text != String.Empty) && (tela.tbDescricao.Text != String.Empty))
            {
                tela.btnCadastrar.Enabled = false;
                tela.btnEditar.Enabled = true;
                tela.btnExcluir.Enabled = true;

            }
            else if ((tela.tbID.Text == String.Empty) && (tela.tbDescricao.Text != String.Empty))
            {
                tela.btnCadastrar.Enabled = true;
                tela.btnEditar.Enabled = false;
                tela.btnExcluir.Enabled = false;

            }
            else if ((tela.tbID.Text == String.Empty) && (tela.tbDescricao.Text != String.Empty))
            {
                tela.btnCadastrar.Enabled = false;
                tela.btnEditar.Enabled = false;
                tela.btnExcluir.Enabled = false;
            }
        }
    }
}
