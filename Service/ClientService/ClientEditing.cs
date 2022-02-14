using Model.Entites;
using Service.ClientService.Auth;
using Service.DataBaseControllers;
using Service.UI;

namespace Service.ClientService
{
    public class ClientEditing
    {
        private IClientUI _ui;

        public ClientEditing(IClientUI ui) => _ui = ui;

        public void Add()
        {
            var db = new DataBase();
            db.Add
                (
                    new Registration
                        (
                            new ClientBuilder(_ui.FirstName, _ui.SecondName, _ui.MiddleName)
                           .SetPhone(_ui.Phone)
                           .SetAddress(_ui.City, _ui.Street, _ui.House, _ui.Flat)
                           .Build()
                        )
                       .SetLogin(_ui.Login)
                       .SetPassword(_ui.Password)
                       .Registrate()
                   , new ClientController()
               );
        }

        public void Edit(Client client)
        {
            var db = new DataBase();
            db.Edit
                (
                    new ClientBuilder(client)
                    .SetAddress(_ui.City, _ui.Street, _ui.House, _ui.Flat)
                    .SetPhone(_ui.Phone)
                    .Build()
                    , new ClientController()
                );
        }
    }
}
