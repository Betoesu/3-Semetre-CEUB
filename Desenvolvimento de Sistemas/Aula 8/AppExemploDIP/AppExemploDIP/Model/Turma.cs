using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploDIP.Model
{
    public class Turma
    {
        private string v;

        public Turma(string v)
        {
            this.v = v;
        }

        public Turma(string nome, string periodo)
        {
            Nome = nome;
            Periodo = periodo;
        }

        public string Nome { get; set; }
        public string Periodo { get; set; }
        public string GetInformacoesTurma() 
        {
            return $"{Nome} - {Periodo}";
        }
    }
}
