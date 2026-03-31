using AppExemploSRP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploSRP.Service
{
    public class NotificacaoService
    {
        public void EnviarEmail(Cliente cliente, string email)
        {
            Console.WriteLine($"E-mail enviado para {cliente.Nome} no endereço de e-mail {email}");
        }

        public void EnviarSMS(Cliente cliente)
        {
            Console.WriteLine($"SMS enviado para {cliente.Nome} no telegone {cliente.Telefone}");
        }
    }
}