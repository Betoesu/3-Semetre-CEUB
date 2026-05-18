using BibliotecaApi.Models;

namespace WebApiBiblioteca.Services.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> ObterTodosAsync();
        Task<Cliente> ObterPorIdAsync(int id);
        Task<Cliente> InserirAsync(Livro livro);
        Task<bool> AtualizarAsync(Livro livro);
        Task<bool> ExcluirAsync(int id);
    }
}
