using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UI
{
    public interface IAdminUI
    {
        string FirstName { get; }
        string SecondName { get; }
        string MiddleName { get; }
        string Phone { get; }
        string Login { get; }
        string Password { get; }

        void FullingFields(string firstName, string secondName, string middleName, string phone);
    }
}
