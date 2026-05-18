//using AppExemploDIP.Model;

//var turma = new Turma("Turma Unica - BCC", "Noturno");
//var Aluno = new Aluno("Rogério", "2002200", turma);
//Aluno.ExibirInformacoesAluno();

using AppExemploDIP.Model;

ITurma presencial = new TurmaPresencial("Turma DS - BCC", "Noturno", "193");
ITurma online = new TurmaOnline("Turma DS - BCC", "Noturno", "meet.ceub.br/link");

var aluno1 = new Aluno("Rogério", "6767676767", presencial);
var aluno2 = new Aluno("Lara", "Feijon kon Farim nha", online);

aluno1.ExibirInformacoesAluno();
aluno2.ExibirInformacoesAluno();