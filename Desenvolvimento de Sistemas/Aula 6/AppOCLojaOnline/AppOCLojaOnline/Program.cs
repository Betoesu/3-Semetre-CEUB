using AppOCLojaOnline.Model;

CalcularPagamento calculador = new CalcularPagamento();
decimal valorPagamento, valorTotal;
Console.WriteLine("Informe o valor da compra: ");
valorTotal = Convert.ToDecimal(Console.ReadLine());

while (true) 
{
    Console.WriteLine("Informe o Desconto: (Cupom | Quantidade | Sazonal)");
    string descontoUsado = Console.ReadLine();

    if (descontoUsado.ToLower() == "cupom")
    {
        valorPagamento = calculador.CalcularTotal(valorTotal, new DescontoCupom());
        Console.WriteLine($"O valor da compra de {valorTotal:C} " +
                          $"resultou em {valorPagamento:C} depois da promoção atráves do {descontoUsado}");
        break;
    }

    else if (descontoUsado.ToLower() == "quantidade")
    {
        valorPagamento = calculador.CalcularTotal(valorTotal, new DescontoCupom());
        Console.WriteLine($"O valor da compra de {valorTotal:C} " +
                          $"resultou em {valorPagamento:C} depois da promoção atráves da {descontoUsado}");
        break;
    }

    else if (descontoUsado.ToLower() == "sazonal")
    {
        valorPagamento = calculador.CalcularTotal(valorTotal, new DescontoCupom());
        Console.WriteLine($"O valor da compra de {valorTotal:C} " +
                          $"resultou em {valorPagamento:C} depois da promoção atráves do desconto {descontoUsado}");
        break;
    }

    else
    {
        Console.WriteLine("\nInforme um dos 3 tipos de desconto\n");
    }
}

    valorPagamento = calculador.CalcularTotal(valorTotal, new DescontoCupom());