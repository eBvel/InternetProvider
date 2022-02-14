using Service.DataBaseControllers;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InternetProviderClient.AdminUI.Reports
{
    public partial class TariffsDiagramForm : Form
    {
        public TariffsDiagramForm()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var tariffs = (await new DataBase().GetListAsync(new ClientController())).Select(t => t.Tariff.Name).GroupBy(t => t).ToList();

            var series = new Series() { Name = "Pipka", ChartType = SeriesChartType.Pie };
            series.IsValueShownAsLabel = true;

            tariffs.ForEach(t => series.Points.AddXY(t.Key, t.Count()));
            series.Font = new Font("Times New Roman", 14);
            
            //TODO: Will change font of labels....

            chart.Series.Add(series);
        }
    }
}
