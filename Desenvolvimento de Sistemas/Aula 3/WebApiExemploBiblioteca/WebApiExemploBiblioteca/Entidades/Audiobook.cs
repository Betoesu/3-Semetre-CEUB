namespace WebApiExemploBiblioteca.Entidades
{
    public class Audiobook : Livro
    {
        public string Narrador { get; set; }
        public int DuracaoMin { get; set; }
    }
}
