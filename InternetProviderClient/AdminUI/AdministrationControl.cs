using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternetProviderClient.AdminUI
{
    public partial class AdministrationControl : UserControl
    {
        private Control _currentControl;
        private Font defaultLabelFont;
        private Font selectedLabelFont;

        public AdministrationControl()
        {
            InitializeComponent();
            defaultLabelFont = new Font("Times New Roman", 14);
            selectedLabelFont = new Font("Times New Roman", 15, FontStyle.Underline);
        }

        private void lbAdministration_Click(object sender, EventArgs e)
        {
            var btn = (Label)sender;
            _currentControl = GetControlByTag(Convert.ToInt32(btn.Tag));
            SetControl();
        }

        private Control GetControlByTag(int tag)
        {
            switch (tag)
            {
                case 1: return new AdminsControl();
                case 2: return new ReportsControl();
                default: throw new ArgumentException(nameof(tag));
            }
        }

        private void SetControl()
        {
            _currentControl.Size = mainPanel.Size;

            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            mainPanel.Controls.Add(_currentControl);
        }

        private void mainPanel_SizeChanged(object sender, EventArgs e)
        {
            if (_currentControl is null) return;
            _currentControl.Size = mainPanel.Size;
        }

        private void lbAdministration_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = selectedLabelFont;
            btn.ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void lbAdministration_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = defaultLabelFont;
            btn.ForeColor = Color.Black;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
