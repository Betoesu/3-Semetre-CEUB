using System.ComponentModel.DataAnnotations;
using WebApiBiblioteca.Model;

namespace BibliotecaApi.Models;

public class Autor
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Nome { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? Nacionalidade { get; set; }

    public DateTime? DataNascimento { get; set; }

    // Navegação: um Autor → muitos Livros (1:N)
    public ICollection<Livro> Livros { get; set; }
        = new List<Livro>();
}