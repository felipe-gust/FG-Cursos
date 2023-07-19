namespace CursosOnline.ContextoDeNotificacao
{
    public abstract class Notificavel
    {
        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public IList<Notificacao> Notificacoes { get; set; }
        public void AdicionarNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
    }
}