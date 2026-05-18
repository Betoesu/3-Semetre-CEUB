using AppExercicioDIPBiblioteca.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDIPBiblioteca.Model
{
    public class AcervoDigital : IAcervo
    {
        public string Titulo { get; set;  }
        public string Link { get; set; }

        public AcervoDigital(string titulo, string link)
        {
            Titulo = titulo;
            Link = link;
        }
        public string GetInfo()
        {
          return $"{Titulo} – Link {Link}";
        }
    }
}
