namespace Service
{
    public class Session : ISession
    {
        private ISession _currnetSession;

        public Session(ISession session) => _currnetSession = session;

        public void Start() => _currnetSession.Start();

        public void Stop() => _currnetSession.Stop();
    }
}
