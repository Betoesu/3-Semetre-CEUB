using AppGestaoFuncionario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestaoFuncionario.Services
{
    public class GeracaoRelatorio
    {
        public string GerarRelatorio(Funcionario funcionario)
        {
            string cargoFormatado = char.ToUpper(funcionario.Cargo[0]) + funcionario.Cargo.Substring(1).ToLower();

            string relatorio = $"\nRelatório de Funcionário\n" +
                               $"Nome: {funcionario.Nome}\n" +
                               $"Cargo: {cargoFormatado}\n" +
                               $"Horas trabalhadas: {funcionario.HorasTrabalhadas}\n" +
                               $"Salário: {funcionario.Salario:C}";
            return relatorio;
        }
    }
}
