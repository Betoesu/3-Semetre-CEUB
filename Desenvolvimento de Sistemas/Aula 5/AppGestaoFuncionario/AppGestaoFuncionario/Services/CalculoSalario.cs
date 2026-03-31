using AppGestaoFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoFuncionario.Services
{
    public class CalculoSalario
    {
        public float CalcularSalario(Funcionario funcionario)
        {
            float salario = 0;
            if (funcionario.Cargo.ToLower() == "diretor")
            {
                salario = funcionario.HorasTrabalhadas * 100;
            }
            else if (funcionario.Cargo.ToLower() == "desenvolvedor")
            {
                salario = funcionario.HorasTrabalhadas * 50;
            }
            else if (funcionario.Cargo.ToLower() == "estagiario")
            {
                salario = funcionario.HorasTrabalhadas * 5;
            }

            return salario;
        }
    }
}
