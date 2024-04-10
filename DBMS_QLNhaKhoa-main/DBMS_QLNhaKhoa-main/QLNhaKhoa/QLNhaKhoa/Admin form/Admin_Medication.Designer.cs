namespace QLNhaKhoa.Admin_form
{
    partial class Admin_Medication
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
            panel1 = new Panel();
            decrease = new Button();
            increase = new Button();
            label1 = new Label();
            soluongTextbox = new TextBox();
            unitBox = new TextBox();
            label8 = new Label();
            prescribeBox = new TextBox();
            label7 = new Label();
            expDateBox = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            priceBox = new TextBox();
            medNameBox = new TextBox();
            label4 = new Label();
            instockBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            medIDBox = new TextBox();
            refreshButton = new Button();
            updateMedButton = new Button();
            addMedButton = new Button();
            medData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(decrease);
            panel1.Controls.Add(increase);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(soluongTextbox);
            panel1.Controls.Add(unitBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(prescribeBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(expDateBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(medNameBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(instockBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(medIDBox);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(updateMedButton);
            panel1.Controls.Add(addMedButton);
            panel1.Controls.Add(medData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 525);
            panel1.TabIndex = 7;
            // 
            // decrease
            // 
            decrease.BackColor = Color.SteelBlue;
            decrease.FlatAppearance.BorderSize = 0;
            decrease.FlatStyle = FlatStyle.Flat;
            decrease.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            decrease.ForeColor = Color.White;
            decrease.Location = new Point(591, 55);
            decrease.Margin = new Padding(3, 2, 3, 2);
            decrease.Name = "decrease";
            decrease.Size = new Size(88, 28);
            decrease.TabIndex = 37;
            decrease.Text = "Giam";
            decrease.UseVisualStyleBackColor = false;
            decrease.Click += decrease_Click;
            // 
            // increase
            // 
            increase.BackColor = Color.SteelBlue;
            increase.FlatAppearance.BorderSize = 0;
            increase.FlatStyle = FlatStyle.Flat;
            increase.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            increase.ForeColor = Color.White;
            increase.Location = new Point(591, 22);
            increase.Margin = new Padding(3, 2, 3, 2);
            increase.Name = "increase";
            increase.Size = new Size(88, 29);
            increase.TabIndex = 36;
            increase.Text = "Them";
            increase.UseVisualStyleBackColor = false;
            increase.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(499, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 35;
            label1.Text = "Cap nhat SL";
            // 
            // soluongTextbox
            // 
            soluongTextbox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soluongTextbox.Location = new Point(499, 60);
            soluongTextbox.Margin = new Padding(3, 2, 3, 2);
            soluongTextbox.Name = "soluongTextbox";
            soluongTextbox.Size = new Size(86, 23);
            soluongTextbox.TabIndex = 33;
            // 
            // unitBox
            // 
            unitBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unitBox.Location = new Point(215, 61);
            unitBox.Margin = new Padding(3, 2, 3, 2);
            unitBox.Name = "unitBox";
            unitBox.Size = new Size(121, 23);
            unitBox.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(239, 160);
            label8.Name = "label8";
            label8.Size = new Size(80, 19);
            label8.TabIndex = 31;
            label8.Text = "Prescription";
            // 
            // prescribeBox
            // 
            prescribeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescribeBox.Location = new Point(239, 180);
            prescribeBox.Margin = new Padding(3, 2, 3, 2);
            prescribeBox.Name = "prescribeBox";
            prescribeBox.PlaceholderText = "Prescription";
            prescribeBox.Size = new Size(372, 23);
            prescribeBox.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(43, 160);
            label7.Name = "label7";
            label7.Size = new Size(107, 19);
            label7.TabIndex = 29;
            label7.Text = "Expiration Date";
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(43, 180);
            expDateBox.Margin = new Padding(3, 2, 3, 2);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(176, 23);
            expDateBox.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(436, 99);
            label6.Name = "label6";
            label6.Size = new Size(39, 19);
            label6.TabIndex = 27;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(43, 99);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 26;
            label5.Text = "Med Name";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(436, 119);
            priceBox.Margin = new Padding(3, 2, 3, 2);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(176, 23);
            priceBox.TabIndex = 25;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(43, 119);
            medNameBox.Margin = new Padding(3, 2, 3, 2);
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.Size = new Size(372, 23);
            medNameBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(354, 41);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 23;
            label4.Text = "In stock";
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(354, 61);
            instockBox.Margin = new Padding(3, 2, 3, 2);
            instockBox.Name = "instockBox";
            instockBox.Size = new Size(121, 23);
            instockBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(233, 40);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 21;
            label3.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(43, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 20;
            label2.Text = "Med ID";
            // 
            // medIDBox
            // 
            medIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medIDBox.Location = new Point(43, 60);
            medIDBox.Margin = new Padding(3, 2, 3, 2);
            medIDBox.Name = "medIDBox";
            medIDBox.PlaceholderText = "Med ID";
            medIDBox.Size = new Size(138, 23);
            medIDBox.TabIndex = 19;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(231, 225);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(88, 30);
            refreshButton.TabIndex = 18;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateMedButton
            // 
            updateMedButton.BackColor = Color.SteelBlue;
            updateMedButton.FlatAppearance.BorderSize = 0;
            updateMedButton.FlatStyle = FlatStyle.Flat;
            updateMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateMedButton.ForeColor = Color.White;
            updateMedButton.Location = new Point(136, 225);
            updateMedButton.Margin = new Padding(3, 2, 3, 2);
            updateMedButton.Name = "updateMedButton";
            updateMedButton.Size = new Size(88, 30);
            updateMedButton.TabIndex = 13;
            updateMedButton.Text = "Update";
            updateMedButton.UseVisualStyleBackColor = false;
            updateMedButton.Click += updateMedButton_Click;
            // 
            // addMedButton
            // 
            addMedButton.BackColor = Color.SteelBlue;
            addMedButton.FlatAppearance.BorderSize = 0;
            addMedButton.FlatStyle = FlatStyle.Flat;
            addMedButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMedButton.ForeColor = Color.White;
            addMedButton.Location = new Point(44, 225);
            addMedButton.Margin = new Padding(3, 2, 3, 2);
            addMedButton.Name = "addMedButton";
            addMedButton.Size = new Size(88, 30);
            addMedButton.TabIndex = 9;
            addMedButton.Text = "Add";
            addMedButton.UseVisualStyleBackColor = false;
            addMedButton.Click += addMedButton_Click;
            // 
            // medData
            // 
            medData.AllowUserToAddRows = false;
            medData.AllowUserToDeleteRows = false;
            medData.AllowUserToResizeColumns = false;
            medData.AllowUserToResizeRows = false;
            medData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            medData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            medData.BorderStyle = BorderStyle.None;
            medData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medData.Dock = DockStyle.Bottom;
            medData.Location = new Point(0, 263);
            medData.Margin = new Padding(3, 2, 3, 2);
            medData.Name = "medData";
            medData.RowHeadersWidth = 51;
            medData.Size = new Size(788, 262);
            medData.TabIndex = 0;
            medData.CellClick += medData_CellClick;
            // 
            // Admin_Medication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 525);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Medication";
            Text = "Admin_Medication";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button refreshButton;
        private Button updateMedButton;
        private Button addMedButton;
        private DataGridView medData;
        private TextBox unitBox;
        private Label label8;
        private TextBox prescribeBox;
        private Label label7;
        private DateTimePicker expDateBox;
        private Label label6;
        private Label label5;
        private TextBox priceBox;
        private TextBox medNameBox;
        private Label label4;
        private TextBox instockBox;
        private Label label3;
        private Label label2;
        private TextBox medIDBox;
        private Button decrease;
        private Button increase;
        private Label label1;
        private TextBox soluongTextbox;
    }
}