using Model.Entites;

namespace Service.ClientService.Auth
{
    public class ClientBuilder
    {
        private Client _client;

        public ClientBuilder(string firstName, string secondName, string middleName) => _client = new Client(firstName, secondName, middleName);
        public ClientBuilder(Client client) => _client = client;

        public ClientBuilder SetPhone(string phone)
        {
            _client.SetPhone(phone);
            return this;
        }

        public ClientBuilder SetAddress(string city, string street, string house, int flat)
        {
            _client.SetAddress(city, street, house, flat);
            return this;
        }

        public Client Build() => _client;
    }
}
