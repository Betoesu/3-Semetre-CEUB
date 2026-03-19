using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        [HttpGet("MostrarEmprestimo")]
        public string MostrarEmprestimo(int idEmprestimo, int idLivro, int idCliente, DateTime dataEmprestimo, DateTime dataEntrega, bool entregue)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id = idEmprestimo;
            emprestimo.IdLivro = idLivro;
            emprestimo.IdCliente = idCliente;
            emprestimo.DataEmprestimo = dataEmprestimo;
            emprestimo.DataEntrega = dataEntrega;
            emprestimo.Entregue = entregue;

            string resultado = $"Id do Empréstimo: {idEmprestimo}" +
                $"Id do Livro: {idLivro} " +
                $"Id do Cliente: {idCliente} " +
                $"Data do Empréstimo: {dataEmprestimo} " +
                $"Data da Entrega: {dataEntrega} " +
                $"Foi entregue: {entregue} ";
            return resultado;
        }
    }
}
