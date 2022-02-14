using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Model.Entites
{
    public abstract class User
    {
        [Key] [MaxLength(16, ErrorMessage ="Длина логина не должна превышать 16 символов.")]
        public string Login { get; private set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; private set; }
        [Required]
        [MaxLength(20)]
        public string SecondName { get; private set; }
        [Required]
        [MaxLength(25)]
        public string MiddleName { get; private set; }

        public string FullName => $"{SecondName} {FirstName} {MiddleName}";
        public string ShortName => $"{SecondName} {FirstName.First()}.{MiddleName.First()}.";

        [Required]
        [MinLength(8, ErrorMessage = "Минимальная длина пароля 8 символов.")]
        [MaxLength(16, ErrorMessage = "Максимальная длина пароля 16 символов.")]
        public string Password { get;  private set; }

        public string Phone { get; private set; }

        public User() { }

        public User(string firstName, string secondName, string middleName, string phone)
        {
            FirstName = firstName;
            SecondName = secondName;
            MiddleName = middleName;
            Phone = phone;
        }

        public void SetLogin(string login)
        {
            if (string.IsNullOrEmpty(Login))
                Login = login;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(Password))
                Password = password;
        }

        public void SetPhone(string phone) => Phone = phone;
    }
}
