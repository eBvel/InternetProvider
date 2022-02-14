using Model;
using Model.Entites;

namespace Service.ClientService.Auth
{
    public class Authorization
    {
        private Context _currentContext;
        public Authorization(Context context) => _currentContext = context;

        public User Authorize(string login, string password)
        {
            User user;

            user = _currentContext.Admins.Find(login);
            if (user is null)
                user = _currentContext.Clients.Find(login);

            _currentContext.Dispose();

            if (user.Password.Equals(password))
                return user;
            else return null;
        }
    }
}
