using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;
using WebApiExemploBiblioteca.Entidades.Livros;

namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        [HttpGet("MostrarLivro")]
        public string MostrarLivro(int idLivro,
                                       string tituloLivro)
        {
            Livro livro = new LivroFisico();
            livro.Id = idLivro;
            livro.Titulo = tituloLivro;

            string resultado = $"Id do Livro: {livro.Id}\r\n" +
                $"Titulo do Livro: {livro.Titulo}\r\n" +
                $"Autor do Livro: {livro.Autor}\r\n" +
                $"Editora do Livro: {livro.Editora}\r\n" +
                $"Data de Publicação do Livro: {livro.DataPublicacao}";


            return resultado;
        }
        [HttpPost("MostrarLivroFisicoJSON")]
        public IActionResult MostrarLivroFisicoJSON(int idLivroUsuario,
                                                   string tituloLivroUsuario,
                                                   string autorLivroUsuario,
                                                   string editoraLivroUsuario,
                                                   DateTime dataPublicacaoLivroUsuario,
                                                   string corredorLivroUsuario)
        {
            LivroFisico livroFisico = new LivroFisico();
            livroFisico.Id = idLivroUsuario;
            livroFisico.Titulo = tituloLivroUsuario;
            livroFisico.Autor = autorLivroUsuario;
            livroFisico.Editora = editoraLivroUsuario;
            livroFisico.DataPublicacao = dataPublicacaoLivroUsuario;
            livroFisico.Corredor = corredorLivroUsuario;

            string resultado = $"Id do Livro: {livroFisico.Id}\r\n" +
                $"Titulo do Livro: {livroFisico.Titulo}\r\n" +
                $"Autor do Livro: {livroFisico.Autor}\r\n" +
                $"Editora do Livro: {livroFisico.Editora}\r\n" +
                $"Data de Publicação do Livro: {livroFisico.DataPublicacao}\r\n" +
                $"Corredor: {livroFisico.Corredor}";


            return Ok(livroFisico);
        }

        [HttpPost("MostrarAudioBookJSON")]
        public IActionResult MostrarAudioBookJSON(int idLivroUsuario,
                                                   string tituloLivroUsuario,
                                                   string autorLivroUsuario,
                                                   string editoraLivroUsuario,
                                                   DateTime dataPublicacaoLivroUsuario,
                                                   string narradorLivro,
                                                   int duracaoMinutos)
        {
            Audiobook livroAudioBook = new Audiobook();
            livroAudioBook.Id = idLivroUsuario;
            livroAudioBook.Titulo = tituloLivroUsuario;
            livroAudioBook.Autor = autorLivroUsuario;
            livroAudioBook.Editora = editoraLivroUsuario;
            livroAudioBook.DataPublicacao = dataPublicacaoLivroUsuario;
            livroAudioBook.Narrador = narradorLivro;
            livroAudioBook.DuracaoMin = duracaoMinutos;

            return Ok(livroAudioBook);
        }

        [HttpPost("MostrarEbookJSON")]
        public IActionResult MostrarEbookJSON(int idLivroUsuario,
                                              string tituloLivroUsuario,
                                              string autorLivroUsuario,
                                              string editoraLivroUsuario,
                                              DateTime dataPublicacaoLivroUsuario,
                                              string urlDownload)
        {
            Ebook livroEbook = new Ebook();
            livroEbook.Id = idLivroUsuario;
            livroEbook.Titulo = tituloLivroUsuario;
            livroEbook.Autor = autorLivroUsuario;
            livroEbook.Editora = editoraLivroUsuario;
            livroEbook.DataPublicacao = dataPublicacaoLivroUsuario;
            livroEbook.UrlDownload = urlDownload;


            return Ok(livroEbook);
        }
    }
}
