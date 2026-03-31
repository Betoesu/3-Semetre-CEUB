using AppExemploSRP.Domain;
using AppExemploSRP.model;
using AppExemploSRP.Service;


//ClienteViolacaoSRP cliente = new ClienteViolacaoSRP("José das Couves", "QNigor 6767", "9999999999");
//cliente.EnviarEmail("Jose das Alfaces", "Jose@couves");
//cliente.GerarFatura("");
//cliente.SalvarCliente();

Cliente cliente = new Cliente();
cliente.Nome = "IGOR CHRISTOFIDIS";
cliente.Endereco = "QNIGOR RUA 67";
cliente.Telefone = "61 9999 7070";

ClienteValidador validador = new ClienteValidador();
FaturaService faturaService = new FaturaService();
NotificacaoService notificacaoService = new NotificacaoService();

if (validador.Validacao(cliente))
{
    string fatura= faturaService.GerarFatura(cliente);
    Console.WriteLine(fatura);
    notificacaoService.EnviarSMS(cliente);
    notificacaoService.EnviarEmail(cliente, "igor@christofidis.com");
}