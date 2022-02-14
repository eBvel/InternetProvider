using Service.UI;
using System;
using System.Windows.Forms;

namespace InternetProviderClient.AdminUI
{
    public partial class AdminEditingForm : Form, IAdminUI
    {
        public string FirstName => tbFirstName.Text;

        public string SecondName => tbSecondName.Text;

        public string MiddleName => tbMiddleName.Text;

        public string Phone => tbPhoneNumber.Text;

        public string Login => tbLogin.Text;

        public string Password => tbPassword.Text;

        private string password => tbRepeatPassword.Text;

        public AdminEditingForm()
        {
            InitializeComponent();
        }

       
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (Password.Equals(password) == false) throw new ArgumentException("Введенные пароли не совпадают.", nameof(Password));
        }

        public void FullingFields(string firstName, string secondName, string middleName, string phone)
        {
            tbFirstName.Text = firstName;
            tbSecondName.Text = secondName;
            tbMiddleName.Text = middleName;
            tbPhoneNumber.Text = phone;
        }
    }
}
