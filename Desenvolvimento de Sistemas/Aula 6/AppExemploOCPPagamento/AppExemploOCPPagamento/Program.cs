using AppExemploOCPPagamento.Model;

CalculadoraPagamento calculador = new CalculadoraPagamento();
decimal valorPagamento, valorDaCompra;

Console.WriteLine($"Informe o valor da compra: ");
valorDaCompra = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe o Desconto: ");

valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoBlackFriday());
Console.WriteLine($"O valor da compra de R${valorDaCompra}" +
                  $" resultou em R${valorPagamento} depois de aplicado o desconto Black Friday");

valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoCupom());
Console.WriteLine($"O valor da compra de R${valorDaCompra}" +
                  $" resultou em R${valorPagamento} depois de aplicado o desconto do Cupom");

valorPagamento = calculador.CalcularTotal(valorDaCompra, new DescontoSemanaConsumidor());
Console.WriteLine($"O valor da compra de R${valorDaCompra}" +
                  $" resultou em R${valorPagamento} depois de aplicado o desconto da Semana do Consumidor");