using System;
using System.Drawing;
using System.Windows.Forms;
using InternetProviderClient.AdminUI.Reports;

namespace InternetProviderClient.AdminUI
{
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(150,150,150);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            var pb = (PictureBox)sender;
            pb.BackColor = this.Parent.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var btn = (PictureBox)sender;
            ShowReportByTag(Convert.ToInt32(btn.Tag));
        }

        private void ShowReportByTag(int tag)
        {
            switch (tag)
            {
                case 1:
                    new TariffsDiagramForm().Show();
                        break;
                case 2:
                    new MonthlyRevenueForm().Show();
                    break;
                default: throw new ArgumentException(nameof(tag));
            }
        }
    }
}
