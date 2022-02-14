using System.Linq;
using System.Windows.Forms;
using Service.ClientService;
using Service.DataBaseControllers;

namespace InternetProviderClient.ClientUI
{
    public partial class ReportMonthsControl : UserControl
    {
        public ReportMonthsControl()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            table.DataSource = (await new DataBase().GetListAsync(new ReportMonthController())).Where(rm => rm.ClientLogin.Equals(ActiveClient.Instance.Login)).ToList();
        }
    }
}
