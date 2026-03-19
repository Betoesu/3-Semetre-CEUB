using AppExemploSRP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploSRP.Service
{
    public class ClienteValidador
    {
        public bool Validado {  get; set; }
        public string Erro {  get; set; }

        public bool Validacao(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                Console.WriteLine("Nome do Cliente é obrigatório");
                return false;
            }
            if (cliente.Nome.Trim().Length < 3) {
                Console.WriteLine("Nome do Cliente deve ter pelo menos 3 caracteres");
                return false;
            }
        Console.WriteLine("Dados do Cliente validado com sucesso!!!");
        return true;
        }
    }

}
