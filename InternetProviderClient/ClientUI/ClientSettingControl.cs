using System;
using System.Windows.Forms;
using Service.ClientService;

namespace InternetProviderClient.ClientUI
{
    public partial class ClientSettingControl : UserControl
    {
        public ClientSettingControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            tbAmount.Visible = !tbAmount.Visible;
            lbAmount.Visible = !lbAmount.Visible;

            if (tbAmount.Visible is false)
            {
                ActiveClient.Instance.Deposit(tbAmount.Value);
                LoadData();
            }
        }

        private void LoadData()
        {
            var tariff = ActiveClient.Instance.Tariff;
            lbTariffName.Text = tariff.Name;
            lbTraffic.Text = $"{ActiveClient.Instance.CurrentTraffic} / {tariff.MonthlyTraffic} Гб";
            lbSpeed.Text = tariff.Speed;
            lbPrice.Text = tariff.Price;
            lbBalance.Text = $"{ActiveClient.Instance.Balance.ToString()} рублей";
            cbAdditionPay.Checked = ActiveClient.Instance.AutoAdditionTraffic;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var isTurn = ((CheckBox)sender).Checked;
            ActiveClient.Instance.TurnOnAdditionPay(isTurn);
        }
    }
}
