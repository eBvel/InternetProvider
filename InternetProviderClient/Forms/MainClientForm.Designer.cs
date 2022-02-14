namespace InternetProviderClient.Forms
{
    partial class MainClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainClientForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbPersonRoom = new System.Windows.Forms.PictureBox();
            this.lbTariffs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.pbPersonRoom, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTariffs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbPersonRoom
            // 
            this.pbPersonRoom.BackColor = System.Drawing.Color.SlateGray;
            this.pbPersonRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPersonRoom.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonRoom.Image")));
            this.pbPersonRoom.Location = new System.Drawing.Point(1008, 4);
            this.pbPersonRoom.Name = "pbPersonRoom";
            this.pbPersonRoom.Size = new System.Drawing.Size(91, 68);
            this.pbPersonRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPersonRoom.TabIndex = 0;
            this.pbPersonRoom.TabStop = false;
            this.pbPersonRoom.Click += new System.EventHandler(this.pbPersonRoom_Click);
            this.pbPersonRoom.MouseEnter += new System.EventHandler(this.pbPersonRoom_MouseEnter);
            this.pbPersonRoom.MouseLeave += new System.EventHandler(this.pbPersonRoom_MouseLeave);
            // 
            // lbTariffs
            // 
            this.lbTariffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTariffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTariffs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTariffs.Location = new System.Drawing.Point(4, 1);
            this.lbTariffs.Name = "lbTariffs";
            this.lbTariffs.Size = new System.Drawing.Size(280, 74);
            this.lbTariffs.TabIndex = 2;
            this.lbTariffs.Text = "Тарифы";
            this.lbTariffs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTariffs.Click += new System.EventHandler(this.btnTariffs_Click);
            this.lbTariffs.MouseEnter += new System.EventHandler(this.lbTariffs_MouseEnter);
            this.lbTariffs.MouseLeave += new System.EventHandler(this.lbTariffs_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(291, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Помощь";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btnHelp_Click);
            this.label1.MouseEnter += new System.EventHandler(this.lbTariffs_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.lbTariffs_MouseLeave);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 76);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1103, 611);
            this.panel.TabIndex = 1;
            // 
            // MainClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 687);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интернет провайдер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbPersonRoom;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbTariffs;
        private System.Windows.Forms.Label label1;
    }
}