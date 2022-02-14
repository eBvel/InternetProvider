using Model.Entites;

namespace Service.ClientService
{
    public class ActiveClient
    {
        public static Client Instance { get; set; }

        public ActiveClient(Client client) => Instance = client;
    }
}
