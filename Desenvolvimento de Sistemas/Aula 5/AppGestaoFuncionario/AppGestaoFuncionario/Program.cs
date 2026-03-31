using AppGestaoFuncionario.Entities;
using AppGestaoFuncionario.Services;

Funcionario funcionario = new Funcionario();
Console.WriteLine("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.WriteLine("\nHoras Trabalhadas: ");
funcionario.HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nCargo(Diretor|Desenvolvedor|Estagiario): ");
funcionario.Cargo = Console.ReadLine();

CalculoSalario salario = new CalculoSalario();
funcionario.Salario = salario.CalcularSalario(funcionario);

GeracaoRelatorio relatorio = new GeracaoRelatorio();
Console.WriteLine(relatorio.GerarRelatorio(funcionario));