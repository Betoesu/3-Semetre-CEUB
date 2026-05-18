using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploDIP.Model
{
    public class TurmaPresencial : ITurma
    {
        public TurmaPresencial(string nome, string periodo, string sala)
        {
            Nome = nome;
            Periodo = periodo;
            Sala = sala;
        }

        public string Nome {  get; set; }

        public string Periodo {  get; set; }

        public string Sala { get; set;}

        public string GetInformacoesTurma()
        {
            return $"{Nome} - {Periodo} | Sala: {Sala}";
        }
    }
}
