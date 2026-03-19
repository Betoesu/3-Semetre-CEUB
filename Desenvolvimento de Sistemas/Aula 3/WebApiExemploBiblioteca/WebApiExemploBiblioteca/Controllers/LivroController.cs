using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        [HttpGet("MostrarLivroFisico")]
        public string MostrarLivroFisico(int idLivro,
                                       string tituloLivro,
                                       string autorLivro,
                                       string editoraLivro,
                                       DateTime dataPublicacaoLivro)
        {
            Livro livro = new LivroFisico();
            livro.Id = idLivro;
            livro.Titulo = tituloLivro;
            livro.Autor = autorLivro;
            livro.Editora = editoraLivro;
            livro.DataPublicacao = dataPublicacaoLivro;

            string resultado = $"Id do Livro: {livro.Id}\r\n" +
                $"Titulo do Livro: {livro.Titulo}\r\n" +
                $"Autor do Livro: {livro.Autor}\r\n" +
                $"Editora do Livro: {livro.Editora}\r\n" +
                $"Data de Publicação do Livro: {livro.DataPublicacao}";


            return resultado;
        }
        [HttpGet("MostrarLivroFisicoJSON")]
        public IActionResult MostrarLivroFisicoJSON(int idLivro,
                                                   string tituloLivro,
                                                   string autorLivro,
                                                   string editoraLivro,
                                                   DateTime dataPublicacaoLivro)
        {
            Livro livro = new LivroFisico();
            livro.Id = idLivro;
            livro.Titulo = tituloLivro;
            livro.Autor = autorLivro;
            livro.Editora = editoraLivro;
            livro.DataPublicacao = dataPublicacaoLivro;

            string resultado = $"Id do Livro: {livro.Id}\r\n" +
                $"Titulo do Livro: {livro.Titulo}\r\n" +
                $"Autor do Livro: {livro.Autor}\r\n" +
                $"Editora do Livro: {livro.Editora}\r\n" +
                $"Data de Publicação do Livro: {livro.DataPublicacao}";


            return Ok(livro);
        }
    }
}
