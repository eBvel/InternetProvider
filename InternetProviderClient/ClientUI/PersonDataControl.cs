using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.ClientService;

namespace InternetProviderClient.ClientUI
{
    public partial class PersonDataControl : UserControl
    {
        private List<TextBox> labels;
        public PersonDataControl()
        {
            InitializeComponent();
            FullingFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            labels = this.Controls.OfType<TextBox>().ToList();

            foreach (var label in labels)
                label.Enabled = true;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void FullingFields()
        {
            tbFirstName.Text = ActiveClient.Instance.FirstName;
            tbSecondName.Text = ActiveClient.Instance.SecondName;
            tbMiddleName.Text = ActiveClient.Instance.MiddleName;
            tbPhone.Text = ActiveClient.Instance.Phone;
            tbCity.Text = ActiveClient.Instance.Address.City;
            tbStreet.Text = ActiveClient.Instance.Address.Street;
            tbHouse.Text = ActiveClient.Instance.Address.House;
            tbFlat.Text = ActiveClient.Instance.Address.Flat.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            labels.ForEach(l => l.Enabled = false);

            ActiveClient.Instance.SetAddress(tbCity.Text, tbStreet.Text, tbHouse.Text, Convert.ToInt32(tbFlat.Text));
            ActiveClient.Instance.SetPhone(tbPhone.Text);

            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }
    }
}
