namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_Main));
            LeftPanel = new Panel();
            AppointmentButton = new Button();
            EmpName = new Label();
            AccountButton = new Button();
            mainPanel = new Panel();
            LeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.DimGray;
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(EmpName);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Margin = new Padding(3, 2, 3, 2);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(262, 555);
            LeftPanel.TabIndex = 4;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(22, 231);
            AppointmentButton.Margin = new Padding(3, 2, 3, 2);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(219, 30);
            AppointmentButton.TabIndex = 13;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // EmpName
            // 
            EmpName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpName.ForeColor = Color.White;
            EmpName.Location = new Point(0, 158);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(262, 21);
            EmpName.TabIndex = 6;
            EmpName.Text = "<Employee Name>";
            EmpName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(22, 188);
            AccountButton.Margin = new Padding(3, 2, 3, 2);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(219, 30);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Location = new Point(262, 30);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(788, 525);
            mainPanel.TabIndex = 5;
            // 
            // Emp_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 555);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Emp_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Dashboard";
            Load += Emp_Main_Load;
            LeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label EmpName;
        private Button AccountButton;
        private Panel mainPanel;
        private Button AppointmentButton;
    }
}