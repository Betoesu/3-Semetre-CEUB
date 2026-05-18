using AppExercicioDIPBiblioteca.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDIPBiblioteca.Model
{
    public class AcervoFisico: IAcervo
    {
        public string Localizacao { get; set; }

        public string Titulo{ get; set; }

        public AcervoFisico(string titulo, string localizacao)
        {
            Titulo = titulo;
            Localizacao = localizacao;
        }

        public string GetInfo()
        {
            return $"{Titulo} – Estante {Localizacao}";
        }
    }
}
