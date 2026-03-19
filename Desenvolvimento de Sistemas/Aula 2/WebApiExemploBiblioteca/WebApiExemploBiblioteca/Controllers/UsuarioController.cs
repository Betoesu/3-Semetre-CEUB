using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entidades;

namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("MostrarUsuario")]
        public string MostrarUsuario(int idUsuario,
                                    string nomeUsuario,
                                    string cpfUsuario,
                                    string enderecoUsuario,
                                    string cidadeUsuario,
                                    string telefoneCelularUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Id = idUsuario;
            usuario.Nome = nomeUsuario;
            usuario.Endereco = enderecoUsuario;
            usuario.Cpf = cpfUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular = telefoneCelularUsuario;
            string resultado = $"Usuário: {usuario.Id}\r\n " +
                $"Nome: {usuario.Nome}\r\n" +
                $"Cpf: {usuario.Cpf}\r\n" +
                $"Cidade: {usuario.Cidade}\r\n" +
                $"Endereco: {usuario.Endereco}\r\n" +
                $"Telefone Celular: {usuario.TelefoneCelular}";

            return resultado;
        }
        [HttpGet("MostrarUsuarioJSON")]
        public IActionResult MostrarUsuarioJSON(int idUsuario,
                                                string nomeUsuario,
                                                string cpfUsuario,
                                                string enderecoUsuario,
                                                string cidadeUsuario,
                                                string telefoneCelularUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Id = idUsuario;
            usuario.Nome = nomeUsuario;
            usuario.Endereco = enderecoUsuario;
            usuario.Cpf = cpfUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular = telefoneCelularUsuario;
   

            return Ok(usuario);
        }
    }
}
