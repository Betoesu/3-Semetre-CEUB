using BibliotecaApi.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public Task<Emprestimo> RealizarEmprestimoAsync(int livroId, int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
