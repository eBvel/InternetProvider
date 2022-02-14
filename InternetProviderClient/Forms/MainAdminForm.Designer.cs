namespace InternetProviderClient.Forms
{
    partial class MainAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbClients = new System.Windows.Forms.Label();
            this.lbTariffs = new System.Windows.Forms.Label();
            this.lbAdministration = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Controls.Add(this.lbClients, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTariffs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbAdministration, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbClients
            // 
            this.lbClients.BackColor = System.Drawing.Color.IndianRed;
            this.lbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbClients.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClients.Location = new System.Drawing.Point(3, 0);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(287, 57);
            this.lbClients.TabIndex = 1;
            this.lbClients.Tag = "1";
            this.lbClients.Text = "Клиенты";
            this.lbClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClients.Click += new System.EventHandler(this.label1_Click);
            this.lbClients.MouseEnter += new System.EventHandler(this.lbClients_MouseEnter);
            this.lbClients.MouseLeave += new System.EventHandler(this.lbClients_MouseLeave);
            // 
            // lbTariffs
            // 
            this.lbTariffs.BackColor = System.Drawing.Color.IndianRed;
            this.lbTariffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTariffs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTariffs.Location = new System.Drawing.Point(296, 0);
            this.lbTariffs.Name = "lbTariffs";
            this.lbTariffs.Size = new System.Drawing.Size(287, 57);
            this.lbTariffs.TabIndex = 1;
            this.lbTariffs.Tag = "2";
            this.lbTariffs.Text = "Тарифы";
            this.lbTariffs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTariffs.Click += new System.EventHandler(this.label1_Click);
            this.lbTariffs.MouseEnter += new System.EventHandler(this.lbClients_MouseEnter);
            this.lbTariffs.MouseLeave += new System.EventHandler(this.lbClients_MouseLeave);
            // 
            // lbAdministration
            // 
            this.lbAdministration.BackColor = System.Drawing.Color.IndianRed;
            this.lbAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAdministration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdministration.Location = new System.Drawing.Point(589, 0);
            this.lbAdministration.Name = "lbAdministration";
            this.lbAdministration.Size = new System.Drawing.Size(435, 57);
            this.lbAdministration.TabIndex = 1;
            this.lbAdministration.Tag = "3";
            this.lbAdministration.Text = "Администрирование";
            this.lbAdministration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdministration.Click += new System.EventHandler(this.label1_Click);
            this.lbAdministration.MouseEnter += new System.EventHandler(this.lbClients_MouseEnter);
            this.lbAdministration.MouseLeave += new System.EventHandler(this.lbClients_MouseLeave);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1323, 601);
            this.panel.TabIndex = 1;
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 658);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интернет провайдер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdminForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainAdminForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbClients;
        private System.Windows.Forms.Label lbTariffs;
        private System.Windows.Forms.Label lbAdministration;
        private System.Windows.Forms.Panel panel;
    }
}