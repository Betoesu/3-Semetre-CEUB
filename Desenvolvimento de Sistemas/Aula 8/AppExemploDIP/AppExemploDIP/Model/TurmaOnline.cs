using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploDIP.Model
{
    public class TurmaOnline : ITurma
    {
        

        public string Nome { get; set; }

        public string Periodo { get; set;}
        public string Link {  get; set;}

        public TurmaOnline(string nome, string periodo, string link)
        {
            Nome = nome;
            Periodo = periodo;
            Link = link;
        }

        public string GetInformacoesTurma()
        {
            return $"{Nome} - {Periodo} | Link de Acesso: {Link}";
        }
    }
}
