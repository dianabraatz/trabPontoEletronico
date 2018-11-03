using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Funcao
    {
        int codFuncao;
        int nivelAcesso;
        string nome;

        public int GetCodFuncao()
        {
            return codFuncao;
        }

        public int GetNivelAcesso()
        {
            return nivelAcesso;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetCodFuncao(int value)
        {
            this.codFuncao = value;
        }

        public void SetNivelAcesso(int value)
        {
            this.nivelAcesso = value;
        }

        public void SetNome(string value)
        {
            this.nome = value;
        }

    }
}
