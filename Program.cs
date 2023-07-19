using CursosOnline.ContextoDoCurso;

namespace CursosOnline;
class Program
{
    static void Main(string[] args)
    {
        var curso = new List<Curso>();
        var cursoLogica = new Curso("Fundamentos da Lógica de Programação", "fundamentos-logica");
        var cursoPoo = new Curso("Fundamentos da Programação Orientada a Objetos", "fundamentos-poo");
        var cursoCsharp = new Curso("Fundamentos do C#", "fundamentos-csharp");
        var cursoFrontend = new Curso("Fundamentos do FrontEnd com HTML, CSS e Javascript", "fundamentos-frontend");
        curso.Add(cursoCsharp);
        curso.Add(cursoFrontend);
        curso.Add(cursoLogica);
        curso.Add(cursoPoo);

        foreach (var cursos in curso)
        {
            Console.WriteLine($"{cursos.Url} - {cursos.Titulo}");
        }

        var artigo = new List<Artigo>();
        var artigoPoo = new Artigo("importancia-da-poo", "Orientação a Objetos e sua importância");
        var artigoClasseAbstrata = new Artigo("classe-abstrata", "O que é uma classe Abstrata?");
        artigo.Add(artigoPoo);
        artigo.Add(artigoClasseAbstrata);

        foreach (var artigos in artigo)
        {
            Console.WriteLine($"{artigos.Titulo} - {artigos.Url}");
        }
        
    }
}
