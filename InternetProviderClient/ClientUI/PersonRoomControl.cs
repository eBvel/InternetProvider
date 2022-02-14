using InternetProviderClient.ClientUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternetProviderClient.UI
{
    public partial class PersonRoomControl : UserControl
    {
        private Control _currentControl;
        private Font defaultLabelFont;
        private Font selectedLabelFont;

        public PersonRoomControl()
        {
            InitializeComponent();
            defaultLabelFont = new Font("Times New Roman", 14);
            selectedLabelFont = new Font("Times New Roman", 15, FontStyle.Underline);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var btn = (Label)sender;
            _currentControl = GetControlByTag(Convert.ToInt32(btn.Tag));
            SetControl();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = selectedLabelFont;
            btn.ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Label)sender;

            btn.Font = defaultLabelFont;
            btn.ForeColor = Color.Black;
        }

        private Control GetControlByTag(int tag)
        {
            switch (tag)
            {
                case 1: return new PersonDataControl();
                case 2: return new ClientSettingControl();
                case 3: return new ReportMonthsControl();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
