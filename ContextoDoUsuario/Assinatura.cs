using CursosOnline.ContextoCompartilhado;

namespace CursosOnline.ContextoDoUsuario
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }
        public DateTime DataFinal { get; set; }
        public bool EstaInativo => DataFinal <= DateTime.Now;
    }
}