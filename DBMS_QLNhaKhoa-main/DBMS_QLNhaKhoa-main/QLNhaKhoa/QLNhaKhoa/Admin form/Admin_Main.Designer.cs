namespace QLNhaKhoa.Admin_form
{
    partial class Admin_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main));
            LeftPanel = new Panel();
            AdminName = new Label();
            MedicationButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.DimGray;
            LeftPanel.BorderStyle = BorderStyle.FixedSingle;
            LeftPanel.Controls.Add(AdminName);
            LeftPanel.Controls.Add(MedicationButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(3, 2, 3, 2);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(262, 555);
            LeftPanel.TabIndex = 3;
            LeftPanel.Paint += LeftPanel_Paint;
            // 
            // AdminName
            // 
            AdminName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminName.ForeColor = Color.White;
            AdminName.Location = new Point(-1, 151);
            AdminName.Name = "AdminName";
            AdminName.Size = new Size(262, 21);
            AdminName.TabIndex = 6;
            AdminName.Text = "<Admin Name>";
            AdminName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedicationButton
            // 
            MedicationButton.FlatAppearance.BorderSize = 0;
            MedicationButton.FlatStyle = FlatStyle.Flat;
            MedicationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicationButton.ForeColor = Color.White;
            MedicationButton.Location = new Point(22, 248);
            MedicationButton.Margin = new Padding(3, 2, 3, 2);
            MedicationButton.Name = "MedicationButton";
            MedicationButton.Size = new Size(219, 38);
            MedicationButton.TabIndex = 3;
            MedicationButton.Text = "Medication";
            MedicationButton.UseVisualStyleBackColor = true;
            MedicationButton.Click += MedicationButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(22, 206);
            AccountButton.Margin = new Padding(3, 2, 3, 2);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(219, 38);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Location = new Point(262, 30);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(788, 525);
            mainPanel.TabIndex = 4;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 555);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Main";
            Load += Admin_Main_Load;
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label AdminName;
        private Button MedicationButton;
        private Button AccountButton;
        private Panel mainPanel;
    }
}