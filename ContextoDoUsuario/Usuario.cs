using CursosOnline.ContextoCompartilhado;

namespace CursosOnline.ContextoDoUsuario
{
    public class Usuario : Base
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}