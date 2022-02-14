using Model.Entites;

namespace Service.UI
{
    public interface IClientUI
    {
        string FirstName { get; }
        string SecondName { get; }
        string MiddleName { get; }
        string Phone { get; }
        string Login { get; }
        string Password { get; }
        string City { get; }
        string Street { get; }
        string House { get; }
        int Flat { get; }

        void FullingFields(string firstName, string secondName, string middleName, string phone, string city, string street, string house, string flat);
    }
}
