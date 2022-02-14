using InternetProviderClient.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InternetProviderClient.Forms
{
    public partial class MainClientForm : Form
    {
        private AuthorizationForm _authorizationForm;
        private Control _currentControl;

        private Font defaultLabelFont;
        private Font selectedLabelFont;

        public MainClientForm(AuthorizationForm authorizationForm)
        {
            InitializeComponent();
            _authorizationForm = authorizationForm;

            defaultLabelFont = new Font("Times New Roman", 14);
            selectedLabelFont = new Font("Times New Roman", 16, FontStyle.Underline);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _authorizationForm.Show();
        }

        private void btnTariffs_Click(object sender, EventArgs e)
        {
            SetCurrentControl(new TariffsControl());

            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            panel.Controls.Add(_currentControl);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SetCurrentControl(new HelpControl());

            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            panel.Controls.Add(_currentControl);
        }

        private void pbPersonRoom_Click(object sender, EventArgs e)
        {
           SetCurrentControl(new PersonRoomControl());

            if (panel.Controls.Count > 0)
                panel.Controls.RemoveAt(0);
            panel.Controls.Add(_currentControl);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if(_currentControl != null)
            _currentControl.Size = this.panel.Size;
        }

        private void SetCurrentControl(Control control)
        {
            _currentControl = control;
            _currentControl.Size = this.panel.Size;
        }

        private void lbTariffs_MouseEnter(object sender, EventArgs e)
        {
            var lb = (Label)sender;
            lb.Font = selectedLabelFont;
            lb.ForeColor = Color.FromArgb(220,220,220); 
        }

        private void lbTariffs_MouseLeave(object sender, EventArgs e)
        {
            var lb = (Label)sender;

            lb.Font = defaultLabelFont;
            lb.ForeColor = Color.Black;
        }

        private void pbPersonRoom_MouseEnter(object sender, EventArgs e)
        {
            pbPersonRoom.BackColor = Color.AliceBlue;
        }

        private void pbPersonRoom_MouseLeave(object sender, EventArgs e)
        {
            pbPersonRoom.BackColor = pbPersonRoom.Parent.BackColor;
        }
    }
}
