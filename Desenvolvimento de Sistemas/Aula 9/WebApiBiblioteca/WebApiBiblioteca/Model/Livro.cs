namespace WebApiBiblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }

        //Chave estrangeira de Autor
        public int AutorId { get; set; }
        public Autor Autor { get; set; } = null;
        //
        public ICollection<Emprestimo> Emprestimos { get; set; }


    }
}
