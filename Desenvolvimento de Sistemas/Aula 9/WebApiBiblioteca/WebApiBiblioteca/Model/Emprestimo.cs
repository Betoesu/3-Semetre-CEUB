namespace WebApiBiblioteca.Model
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataEmprestimo { get; set; }= DateTime.Now;
        public DateTime? DataDevolucao { get; set; }
        public bool Devolvido { get; set; }= false;
        //Chave Estrangeira para Livro

        public int LivroId { get; set; }
        public Livro Livro { get; set; }

    }
}
