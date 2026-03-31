using AppExemploSRP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploSRP.Service
{
    internal class FaturaService
    {
        public string GerarFatura(Cliente cliente)
        {
            string fatura = "";
            fatura = $"---------------Fatura---------------\r\n" +
                     $"Cliente: {cliente.Nome}\r\n" +
                     $"Endereço: {cliente.Endereco}\r\n" +
                     $"Telefone: {cliente.Telefone}\r\n" +
                     $"Data da Geração da Fatura: {DateTime.Now:dd/MM/yyyy}" +
                     $"------Fatura gerada com sucesso------\r\n";


            return fatura;
        }
    }
}
