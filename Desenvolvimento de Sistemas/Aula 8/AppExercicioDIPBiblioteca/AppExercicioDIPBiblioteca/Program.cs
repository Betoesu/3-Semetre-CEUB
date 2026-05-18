
using AppExercicioDIPBiblioteca.Model;
using AppExercicioDIPBiblioteca.Model.Interface;

IAcervo fisico = new AcervoFisico("Acervo Físico", "Estante 67");
IAcervo digital = new AcervoDigital("Acervo Digital", "www.igor6767mebeija.com.br");

var leitor1 = new Leitor("Pedroca Papai", "registro123", fisico);
