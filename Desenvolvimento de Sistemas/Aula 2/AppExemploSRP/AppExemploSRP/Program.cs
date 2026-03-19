using AppExemploSRP.model;

ClienteViolacaoSRP cliente = new ClienteViolacaoSRP("José das Couves", "QNigor 6767", "9999999999");
cliente.EnviarEmail("Jose das Alfaces", "Jose@couves");
cliente.GerarFatura();
cliente.SalvarCliente();

ClienteViolacaoSRP cliente2 = new ClienteViolacaoSRP("Maria das Alfaces");