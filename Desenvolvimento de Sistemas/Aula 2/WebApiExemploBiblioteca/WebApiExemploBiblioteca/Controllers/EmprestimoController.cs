using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;
using WebApiExemploBiblioteca.Entidades.Livros;

namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmprestimoController : ControllerBase
    {
        [HttpGet("MostrarDadoEmprestimo")]
        public string MostrarDadoEmprestimo(int idEmprestimo,
                                        int idLivro,
                                        int idCliente,
                                        DateTime dataEmprestimo)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id = idEmprestimo;
            emprestimo.IdLivro = idLivro;
            emprestimo.IdCliente = idCliente;
            emprestimo.DataEmprestimo = dataEmprestimo;


            string resultado = $"Id do Empréstimo: {idEmprestimo}" +
                $"Id do Livro: {idLivro} " +
                $"Id do Cliente: {idCliente} " +
                $"Data do Empréstimo: {dataEmprestimo} ";

            return resultado;
        }
        [HttpPost("RealizarEmprestimo")]
        public IActionResult RealizarEmprestimo(int idEmprestimo,
                                                int idLivro,
                                                int idCliente,
                                                DateTime dataEmprestimo,
                                                int tipoLivro)
        {
            Emprestimo emprestimo= new Emprestimo();
            emprestimo.Id = idEmprestimo;
            emprestimo.IdLivro = idLivro;
            emprestimo.IdCliente = idCliente;
            emprestimo.DataEmprestimo = dataEmprestimo;

            switch (tipoLivro)
            {
                case 1://Livro Físico
                    LivroFisico livroFisico = new LivroFisico();
                    emprestimo.DataEntrega = livroFisico.CalcularPrazo();
                    break;

                case 2://Ebook
                    Ebook livroEbook = new Ebook();
                    emprestimo.DataEntrega = livroEbook.CalcularPrazo();
                    break;

                case 3://AudioBook
                    Audiobook livroAudiobook = new Audiobook();
                    emprestimo.DataEntrega = livroAudiobook.CalcularPrazo();
                    break;

                default:
                    return BadRequest("O tipo de livro dever ser 1 a 3");
            }

            return Ok(emprestimo);

        }
    }

}
