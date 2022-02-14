using Model.Entites;
using Service.DataBaseControllers;
using Service.UI;

namespace Service.AdminService
{
    public class AdminEditing
    {
        private IAdminUI _ui;

        public AdminEditing(IAdminUI ui) => _ui = ui;

        public void Add()
        {
            var db = new DataBase();
            db.Add
                (
                    new AdminBuilder(_ui.FirstName, _ui.SecondName, _ui.MiddleName, _ui.Phone)
                    .SetLogin(_ui.Login)
                    .SetPassword(_ui.Password)
                    .Build(), 
                    new AdminController()
                );
        }

        public void Edit(Admin admin)
        {
            var db = new DataBase();
            db.Edit
                (
                    new AdminBuilder(admin)
                    .SetPhone(_ui.Phone)
                    .Build(),
                    new AdminController()
                );
        }
    }
}
