namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentist_Main));
            PrecriptionButton = new Button();
            dentistName = new Label();
            RecordButton = new Button();
            AppointmentButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // PrecriptionButton
            // 
            PrecriptionButton.BackColor = Color.RosyBrown;
            PrecriptionButton.FlatAppearance.BorderSize = 0;
            PrecriptionButton.FlatStyle = FlatStyle.Flat;
            PrecriptionButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecriptionButton.ForeColor = Color.Black;
            PrecriptionButton.Location = new Point(829, 3);
            PrecriptionButton.Margin = new Padding(3, 2, 3, 2);
            PrecriptionButton.Name = "PrecriptionButton";
            PrecriptionButton.Size = new Size(127, 30);
            PrecriptionButton.TabIndex = 10;
            PrecriptionButton.Text = "Prescription";
            PrecriptionButton.UseVisualStyleBackColor = false;
            PrecriptionButton.Click += PrecriptionButton_Click;
            // 
            // dentistName
            // 
            dentistName.BackColor = Color.RosyBrown;
            dentistName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dentistName.ForeColor = Color.Black;
            dentistName.Location = new Point(12, 9);
            dentistName.Name = "dentistName";
            dentistName.Size = new Size(142, 21);
            dentistName.TabIndex = 6;
            dentistName.Text = "<Dentist Name>";
            dentistName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RecordButton
            // 
            RecordButton.BackColor = Color.RosyBrown;
            RecordButton.FlatAppearance.BorderSize = 0;
            RecordButton.FlatStyle = FlatStyle.Flat;
            RecordButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordButton.ForeColor = Color.Black;
            RecordButton.Location = new Point(628, 3);
            RecordButton.Margin = new Padding(3, 2, 3, 2);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(99, 30);
            RecordButton.TabIndex = 3;
            RecordButton.Text = "Patient record";
            RecordButton.UseVisualStyleBackColor = false;
            RecordButton.Click += RecordButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.BackColor = Color.RosyBrown;
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.Black;
            AppointmentButton.Location = new Point(440, 3);
            AppointmentButton.Margin = new Padding(3, 2, 3, 2);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(99, 30);
            AppointmentButton.TabIndex = 2;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = false;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.BackColor = Color.RosyBrown;
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.Black;
            AccountButton.Location = new Point(272, 3);
            AccountButton.Margin = new Padding(3, 2, 3, 2);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(99, 30);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = false;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(-3, 43);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1053, 512);
            mainPanel.TabIndex = 3;
            // 
            // Dentist_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1050, 555);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(PrecriptionButton);
            Controls.Add(dentistName);
            Controls.Add(RecordButton);
            Controls.Add(AppointmentButton);
            Controls.Add(AccountButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dentist_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentist_Main";
            Load += Dentist_Main_Load;
            ResumeLayout(false);
        }

        #endregion
        private Label dentistName;
        private Button RecordButton;
        private Button AppointmentButton;
        private Button AccountButton;
        private Button ServiceButton;
        private Button PrecriptionButton;
        private Panel mainPanel;
    }
}