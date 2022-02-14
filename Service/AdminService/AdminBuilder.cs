using Model.Entites;

namespace Service.AdminService
{
    public class AdminBuilder
    {
        private Admin _admin;
        public AdminBuilder(string firstName, string secondName, string middleName, string phone) 
            => _admin = new Admin(firstName, secondName, middleName, phone);

        public AdminBuilder(Admin admin) => _admin = admin;

        public AdminBuilder SetLogin(string login)
        {
            _admin.SetLogin(login);
            return this;
        }

        public AdminBuilder SetPassword(string password)
        {
            _admin.SetPassword(password);
            return this;
        }

        public AdminBuilder SetPhone(string phone)
        {
            _admin.SetPhone(phone);
            return this;
        }

        public Admin Build() => _admin;
    }
}
