namespace InternetProviderClient.AdminUI
{
    partial class AdministrationControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbAdministration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lbReports = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.lbReports);
            this.panel1.Controls.Add(this.lbAdministration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 777);
            this.panel1.TabIndex = 0;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.Location = new System.Drawing.Point(16, 208);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(78, 27);
            this.lbExit.TabIndex = 0;
            this.lbExit.Text = "Выход";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbAdministration_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbAdministration_MouseLeave);
            // 
            // lbAdministration
            // 
            this.lbAdministration.AutoSize = true;
            this.lbAdministration.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAdministration.Location = new System.Drawing.Point(16, 61);
            this.lbAdministration.Name = "lbAdministration";
            this.lbAdministration.Size = new System.Drawing.Size(188, 27);
            this.lbAdministration.TabIndex = 0;
            this.lbAdministration.Tag = "1";
            this.lbAdministration.Text = "Администраторы";
            this.lbAdministration.Click += new System.EventHandler(this.lbAdministration_Click);
            this.lbAdministration.MouseEnter += new System.EventHandler(this.lbAdministration_MouseEnter);
            this.lbAdministration.MouseLeave += new System.EventHandler(this.lbAdministration_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(228, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1147, 30);
            this.label3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(228, 747);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1147, 30);
            this.label4.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(228, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1147, 717);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.SizeChanged += new System.EventHandler(this.mainPanel_SizeChanged);
            // 
            // lbReports
            // 
            this.lbReports.AutoSize = true;
            this.lbReports.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbReports.Location = new System.Drawing.Point(16, 111);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(88, 27);
            this.lbReports.TabIndex = 0;
            this.lbReports.Tag = "2";
            this.lbReports.Text = "Отчеты";
            this.lbReports.Click += new System.EventHandler(this.lbAdministration_Click);
            this.lbReports.MouseEnter += new System.EventHandler(this.lbAdministration_MouseEnter);
            this.lbReports.MouseLeave += new System.EventHandler(this.lbAdministration_MouseLeave);
            // 
            // AdministrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "AdministrationControl";
            this.Size = new System.Drawing.Size(1375, 777);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbAdministration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lbReports;
    }
}
