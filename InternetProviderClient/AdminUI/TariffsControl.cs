using System;
using System.Linq;
using System.Windows.Forms;
using Service.DataBaseControllers;
using Service.TariffService;

namespace InternetProviderClient.AdminUI
{
    public partial class TariffsControl : UserControl
    {
        public TariffsControl()
        {
            InitializeComponent();
            LoadTariffsData();
        }

        public async void LoadTariffsData() => table.DataSource = await new DataBase().GetListAsync(new TariffController());

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var db = new DataBase();
            if (MessageBox.Show("Тариф будет удален безвозвратно!\nВы уверены?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                db.Remove(table.GetEntityId(), new TariffController());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editingForm = new TariffEditingForm();

            if (editingForm.ShowDialog(this) == DialogResult.OK)
            {
                var tariffEditing = new TariffEditing(editingForm);
                tariffEditing.Add();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var editingForm = new TariffEditingForm();
            var tariff = await new DataBase().GetEntityById(Convert.ToInt32(table.GetEntityId()), new TariffController());
            editingForm.FullingFields(
                tariff.Name, 
                tariff.SpeedLimit.ToString(), 
                tariff.MonthlyTraffic.ToString(), 
                tariff.MonthlyPrice.ToString()
                );

            if (editingForm.ShowDialog(this) == DialogResult.OK)
            {
                var tariffEditing = new TariffEditing(editingForm);
                tariffEditing.Edit(tariff);
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            table.DataSource = (await new DataBase().GetListAsync(new TariffController())).Where(t => t.Name.Contains(tbFind.Text)).ToList();
        }
    }
}
