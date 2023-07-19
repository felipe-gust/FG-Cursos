namespace CursosOnline.ContextoDoCurso
{
    public class Artigo : BaseCurso
    {
        public Artigo(string url, string titulo)
            : base(url, titulo)
        {
            
        }
        public DateTime DataDePublicacao { get; set; }
    }
}