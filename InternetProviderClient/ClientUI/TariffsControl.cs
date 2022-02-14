using System;
using System.Windows.Forms;
using Service.DataBaseControllers;
using Service.ClientService;
using System.Linq;

namespace InternetProviderClient.UI
{
    public partial class TariffsControl : UserControl
    {
        public TariffsControl()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            table.DataSource = await new DataBase().GetListAsync(new TariffController());
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            table.DataSource = (await new DataBase().GetListAsync(new TariffController())).Where(t => t.Name.Contains(tbFind.Text)).ToList();
        }

        private async void btnConnectTariff_Click(object sender, EventArgs e)
        {
            var tariff = await new DataBase().GetEntityById(Convert.ToInt32(table.GetEntityId()), new TariffController());
            if (ActiveClient.Instance.SetTariff(tariff))
                MessageBox.Show("Выбранный тариф был подключен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show($"На вашем счете недостаточно средств для подключения данного тарифа \"{tariff.Name}\"", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
