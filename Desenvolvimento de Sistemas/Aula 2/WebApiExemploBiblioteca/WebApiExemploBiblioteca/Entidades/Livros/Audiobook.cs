namespace WebApiExemploBiblioteca.Entidades.Livros
{
    public class Audiobook : Livro
    {
        public string Narrador { get; set; }
        public int DuracaoMin { get; set; }

        public override DateTime CalcularPrazo()
        {
            return DateTime.Now.AddDays(10); ;
        }
    }
}
