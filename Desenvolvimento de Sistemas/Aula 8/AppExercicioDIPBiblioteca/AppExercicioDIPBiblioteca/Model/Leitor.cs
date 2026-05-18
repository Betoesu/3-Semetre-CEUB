using AppExercicioDIPBiblioteca.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicioDIPBiblioteca.Model
{
    public class Leitor
    {
        public string Nome { get; set; }
        public string Registro { get; set; }

        // 🔴 Dependência concreta — problema a ser resolvido
        public IAcervo Acervo { get; set; }

        public Leitor(string nome, string registro, IAcervo acervo)
        {
            Nome = nome;
            Registro = registro;
            Acervo = acervo;
        }

        public void ExibirEmprestimo()
        {
            Console.WriteLine(
                $"Leitor: {Nome} ({Registro}) | Item: {Acervo.GetInfo()}"
            );
        }
    }
}
