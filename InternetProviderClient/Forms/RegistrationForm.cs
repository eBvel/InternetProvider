using Service.UI;
using System;
using System.Windows.Forms;

namespace InternetProviderClient
{
    public partial class RegistrationForm : Form, IClientUI
    {
        public string FirstName => tbFirstName.Text;
        public string SecondName => tbSecondName.Text;
        public string MiddleName => tbMiddleName.Text;
        public string Phone => tbPhoneNumber.Text;
        public string Password => tbPassword.Text;
        public string RepeatPassword => tbRepeatPassword.Text;
        public string Login => tbLogin.Text;
        public string City => tbCity.Text;
        public string Street => tbStreet.Text;
        public string House => tbHouse.Text;
        public int Flat => Convert.ToInt32(tbFlat.Text);

        public RegistrationForm() => InitializeComponent();


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (!Password.Equals(RepeatPassword)) throw new ArgumentException("Пароли не совпадают.", nameof(Password));
        }

        public void FullingFields(string firstName, string secondName, string middleName, string phone, string city, string street, string house, string flat)
        {
            tbFirstName.Text = firstName;
            tbSecondName.Text = secondName;
            tbMiddleName.Text = middleName;
            tbPhoneNumber.Text = phone;
            tbCity.Text = city;
            tbStreet.Text = street;
            tbHouse.Text = house;
            tbFlat.Text = flat;
        }
    }
}
