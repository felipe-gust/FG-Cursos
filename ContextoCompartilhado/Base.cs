using CursosOnline.ContextoDeNotificacao;

namespace CursosOnline.ContextoCompartilhado
{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}