using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coprel.Model
{
    class Ocorrencia
    {
        int CodOcorrencia;
        string Justificativa;
        int Status;
        int CodPonto;

        public int GetCodOcorrencia()
        {
            return this.CodOcorrencia;
        }

        public void SetCodOcorrencia(int codigo)
        {
            CodOcorrencia = codigo;
        }

        public string GetJustificativa()
        {
            return this.Justificativa;
        }

        public void SetJustificativa(string value)
        {
            Justificativa = value;
        }

        public int GetStatus()
        {
            return this.Status;
        }

        public void SetStatus(int value)
        {
            Status = value;
        }

        public int GetCodPonto()
        {
            return this.CodPonto;
        }

        public void SetCodPonto(int value)
        {
            CodPonto = value;
        }

        

    }
}
