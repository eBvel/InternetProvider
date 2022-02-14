using Service.DataBaseControllers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InternetProviderClient.AdminUI.Reports
{
    public partial class MonthlyRevenueForm : Form
    {
        private DateTime _selectedDate => dateTimePicker1.Value;

        public MonthlyRevenueForm()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var db = new DataBase();

            var reportMonths = (await db.GetListAsync(new ReportMonthController())).Where(rm => rm.StartDate.Month == _selectedDate.Month).ToList();
            var clients = reportMonths.GroupBy(rm => rm.ClientLogin).Count();
            var traffic = reportMonths.Select(rm => rm.UsedTraffic).Sum();

            decimal revenue = 0;
            foreach (var rm in reportMonths)
                revenue += (await db.GetEntityByName(rm.TariffName, new TariffController())).MonthlyPrice;

            lbClients.Text = clients.ToString();
            lbTraffic.Text = traffic.ToString();
            lbRevenue.Text = revenue.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
