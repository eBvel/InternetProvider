using InternetProviderClient.AdminUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternetProviderClient.Forms
{
    public partial class MainAdminForm : Form
    {
        private AuthorizationForm _authorizationForm;
        private Control _currentControl;

        private Font _defaultLabelFont;
        private Font _selectedLabelFont;

        public MainAdminForm(AuthorizationForm authorizationForm)
        {
            InitializeComponent();
            _authorizationForm = authorizationForm;

            _defaultLabelFont = new Font("Times New Roman", 14);
            _selectedLabelFont = new Font("Times New Roman", 16, FontStyle.Underline);

            _currentControl = GetControlByTag(1);
            SetControlToPanel();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var btn = (Label)sender;
            _currentControl = GetControlByTag(Convert.ToInt32(btn.Tag));
            SetControlToPanel();
        }

        private Control GetControlByTag(int tag)
        {
            switch (tag)
            {
                case 1 : return new ClientsControl();
                case 2 : return new TariffsControl();
                case 3 : return new AdministrationControl();
                default : throw new ArgumentException(nameof(tag));
            }
        }

        private void SetControlToPanel()
        {
            _currentControl.Size = this.panel.Size;

            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            panel.Controls.Add(_currentControl);
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _authorizationForm.Show();
            _authorizationForm = null;
        }

        private void lbClients_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = _selectedLabelFont;
            btn.ForeColor = Color.FromArgb(200,200,200);
        }

        private void lbClients_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = _defaultLabelFont;
            btn.ForeColor = Color.Black;
        }

        private void MainAdminForm_SizeChanged(object sender, EventArgs e)
        {
            if (_currentControl is null) return;
            _currentControl.Size = this.panel.Size;
        }
    }
}
