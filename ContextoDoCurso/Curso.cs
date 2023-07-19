using CursosOnline.ContextoDoCurso.Enums;

namespace CursosOnline.ContextoDoCurso
{
    public class Curso : BaseCurso
    {
        public Curso(string titulo, string url)
            : base(titulo, url)
        {
            
        }
        public string Tag { get; set; }
        public ENivelDoCurso Level { get; set; }        
    }
}