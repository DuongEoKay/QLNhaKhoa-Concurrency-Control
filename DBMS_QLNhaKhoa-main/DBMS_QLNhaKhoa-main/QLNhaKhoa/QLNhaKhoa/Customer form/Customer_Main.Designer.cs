namespace QLNhaKhoa
{
    partial class Customer_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Main));
            LeftPanel = new Panel();
            CustomerName = new Label();
            AppointmentButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.DimGray;
            LeftPanel.Controls.Add(CustomerName);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(3, 2, 3, 2);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(262, 555);
            LeftPanel.TabIndex = 1;
            // 
            // CustomerName
            // 
            CustomerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerName.ForeColor = Color.White;
            CustomerName.Location = new Point(49, 158);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(164, 21);
            CustomerName.TabIndex = 6;
            CustomerName.Text = "<Customer Name>";
            CustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(22, 281);
            AppointmentButton.Margin = new Padding(3, 2, 3, 2);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(219, 38);
            AppointmentButton.TabIndex = 2;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
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
            mainPanel.Location = new Point(262, 28);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(788, 525);
            mainPanel.TabIndex = 3;
            // 
            // Customer_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 555);
            ControlBox = false;
            Controls.Add(LeftPanel);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customer_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Main";
            Load += Customer_Main_Load;
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label CustomerName;
        private Button AppointmentButton;
        private Button AccountButton;
        private Panel mainPanel;
    }
}