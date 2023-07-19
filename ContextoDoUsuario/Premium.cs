using CursosOnline.ContextoCompartilhado;
using CursosOnline.ContextoDeNotificacao;

namespace CursosOnline.ContextoDoUsuario
{
    public class Premium : Base
    {
        public Premium()
        {
            Assinaturas = new List<Assinatura>();
        }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public IList<Assinatura> Assinaturas { get; set; }
        public bool VerificaSePremium => Assinaturas.Any(x => !x.EstaInativo);
        public void CriarAssinatura(Assinatura assinatura)
        {
            if(VerificaSePremium)
            {
                AdicionarNotificacao(new Notificacao("Premium", "O usuário já possui assinatura ativa."));
                return;
            }
        }
    }
}