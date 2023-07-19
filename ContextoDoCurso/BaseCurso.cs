namespace CursosOnline.ContextoDoCurso
{
    public class BaseCurso
    {
        public BaseCurso(string url, string titulo)
        {
            Url = url;
            Titulo = titulo;
        }

        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}