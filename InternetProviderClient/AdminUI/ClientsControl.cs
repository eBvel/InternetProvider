using System;
using System.Windows.Forms;
using Service.DataBaseControllers;
using Service.ClientService;
using System.Linq;

namespace InternetProviderClient.AdminUI
{
    public partial class ClientsControl : UserControl
    {
        public ClientsControl()
        {
            InitializeComponent();
            LoadClientList();
        }

        private async void LoadClientList()
        {
            table.DataSource = await new DataBase().GetListAsync(new ClientController());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();

            if (regForm.ShowDialog(this) == DialogResult.OK)
            {
                var clientEditing = new ClientEditing(regForm);
                clientEditing.Add();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.groupBox3.Enabled = false;

            var client = await new DataBase().GetEntityByName(table.GetEntityId(), new ClientController());
            regForm.FullingFields(client.FirstName, client.SecondName, client.MiddleName, client.Phone, client.Address.City, client.Address.Street, client.Address.House, client.Address.Flat.ToString());

            if (regForm.ShowDialog(this) == DialogResult.OK)
            {
                var clientEditing = new ClientEditing(regForm);
                clientEditing.Edit(client);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            if (MessageBox.Show("Пользователь будет удален безвозвратно!\nВы уверены?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                db.Remove(table.GetEntityId(), new ClientController());
        }

        private async void btnSetTariff_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var tsf = new TariffSelectionForm();
            tsf.cmbTariffs.DataSource = await db.GetListAsync(new TariffController());

            if (tsf.ShowDialog(this) == DialogResult.OK)
            {
                var id = (int)tsf.cmbTariffs.SelectedValue;
                db.ConnectTariff(table.GetEntityId(), id);
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            table.DataSource = (await new DataBase().GetListAsync(new ClientController())).Where(c => c.FullName.Contains(tbFind.Text)).ToList();
        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            var client = await db.GetEntityByName(table.GetEntityId(), new ClientController());
            client.Deposit(client.Tariff.MonthlyPrice);
            db.Edit(client, new ClientController());
        }
    }
}
