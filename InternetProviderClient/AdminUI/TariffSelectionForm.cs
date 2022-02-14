using System.Windows.Forms;

namespace InternetProviderClient.AdminUI
{
    public partial class TariffSelectionForm : Form
    {
        public TariffSelectionForm()
        {
            InitializeComponent();
            cmbTariffs.DisplayMember = "Name";
            cmbTariffs.ValueMember = "Id";
        }
    }
}
