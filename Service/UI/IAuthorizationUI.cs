using Service.ClientService;

namespace Service.UI
{
    public interface IAuthorizationUI
    {
        string Login { get;}
        string Password { get;}
        ISession Session { get;}
        void Pay(IPayment payment);
    }
}
