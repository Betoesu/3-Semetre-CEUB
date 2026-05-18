using AppExemploISP.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploISP.Model
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            //Envia email para ocliente
        }

        public void SalvarBanco()
        {
            //Insert na tabela cliente
        }

        public void ValidarDados()
        {
            //Validar CPF, e-mail
        }
    }
}
