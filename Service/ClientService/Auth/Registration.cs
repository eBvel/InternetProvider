using Model.Entites;

namespace Service.ClientService.Auth
{
    public class Registration
    {
        private Client _client;
        public Registration(Client client)
        {
            _client = client;
        }

        public Registration SetLogin(string login)
        {
            //Can do validation data;
            _client.SetLogin(login);
            return this;
        }

        public Registration SetPassword(string password)
        {
            //Can do validation data;
            _client.SetPassword(password);
            return this;
        }

        public Client Registrate() => _client;
    }
}
