using System.Windows.Forms;
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
            table.DataSource = await new DataBase().GetListAsync(new ReportMonthController());
        }
    }
}
