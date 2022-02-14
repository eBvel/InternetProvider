using InternetProviderClient.Forms;
using Service;
using Service.AdminService;
using Service.ClientService;
using Service.DataBaseControllers;
using Service.TariffService;
using Service.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace InternetProviderClient
{
    public partial class AuthorizationForm : Form, IAuthorizationUI
    {
        public string Login => tbLogin.Text;
        public string Password => tbPassword.Text;
        public ISession Session => _session;

        private Session _session;
        private string path = "launched.txt";

        public AuthorizationForm()
        {
            InitializeComponent();

            if (!File.Exists(path))
            {
                new DataBase().Add
                    (
                        new AdminBuilder("Иванов", "Иван", "Иванович", "")
                        .SetLogin("admin123")
                        .SetPassword("admin123")
                        .Build(), new AdminController()
                    );
                new DataBase().Add(new TariffBuilder("По умолчанию", 0, 0, 0).Build(), new TariffController());

                File.Create(path);
            }
        }

        private void lbRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new RegistrationForm();
            this.Hide();
            if (regForm.ShowDialog(this) == DialogResult.OK)
            {
                var clientEditing = new ClientEditing(regForm);
                clientEditing.Add();
            }
            this.Show();
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            var user = await new DataBase().Authorization(this);
            if (user is null) throw new ArgumentException("Логин или пароль введены не верно.");

            if (new ClientController().IsClient(user))
            {
                new MainClientForm(this).Show();
                var clientSession = new ClientSession(user);
                clientSession.PaidHandler += Pay;
                _session = new Session(clientSession);
            }
            else
            {
                new MainAdminForm(this).Show();
                _session = new Session(new AdminSession());
            }

            _session.Start();
            this.Hide();
        }

        private void Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEnter_Click(sender, e);
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_session is null) return;
            _session.Stop();
        }

        public void Pay(IPayment payment)
        {
            payment.Pay();
        }
    }
}
