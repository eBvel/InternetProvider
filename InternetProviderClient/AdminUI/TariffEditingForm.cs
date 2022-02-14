using Service.UI;
using System.Windows.Forms;

namespace InternetProviderClient.AdminUI
{
    public partial class TariffEditingForm : Form, ITariffUI
    {
        public TariffEditingForm()
        {
            InitializeComponent();
        }

        public string TariffName => tbName.Text;
        public double Speed => double.Parse(tbSpeed.Text);
        public double Traffic => double.Parse(tbTraffic.Text);
        public decimal Price => decimal.Parse(tbPrice.Text);

        public void FullingFields(string name, string speed, string traffic, string price)
        {
            tbName.Text = name;
            tbSpeed.Text = speed;
            tbTraffic.Text = traffic;
            tbPrice.Text = price;
        }
    }
}
