namespace QLNhaKhoa
{
    partial class Account
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
            label6 = new Label();
            IDBox = new TextBox();
            label5 = new Label();
            passwordBox = new TextBox();
            updateButton = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            bdayBox = new DateTimePicker();
            nameBox = new TextBox();
            phoneBox = new TextBox();
            label3 = new Label();
            addressBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(IDBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bdayBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(addressBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 525);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(175, 161);
            label6.Name = "label6";
            label6.Size = new Size(23, 19);
            label6.TabIndex = 20;
            label6.Text = "ID";
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(175, 181);
            IDBox.Margin = new Padding(3, 2, 3, 2);
            IDBox.MaxLength = 11;
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "ID";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(110, 23);
            IDBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(481, 251);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(481, 271);
            passwordBox.Margin = new Padding(3, 2, 3, 2);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(132, 23);
            passwordBox.TabIndex = 17;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(306, 412);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(175, 38);
            updateButton.TabIndex = 16;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;

            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.setting;
            pictureBox1.InitialImage = Properties.Resources.setting;
            pictureBox1.Location = new Point(328, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(328, 251);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 14;
            label4.Text = "Date of birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(306, 161);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(175, 251);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 12;
            label1.Text = "Phone number";
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(328, 271);
            bdayBox.Margin = new Padding(3, 2, 3, 2);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(132, 23);
            bdayBox.TabIndex = 3;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(306, 181);
            nameBox.Margin = new Padding(3, 2, 3, 2);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(307, 23);
            nameBox.TabIndex = 2;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(175, 271);
            phoneBox.Margin = new Padding(3, 2, 3, 2);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(132, 23);
            phoneBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(175, 345);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(175, 364);
            addressBox.Margin = new Padding(3, 2, 3, 2);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(438, 23);
            addressBox.TabIndex = 0;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 525);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button updateButton;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker bdayBox;
        private TextBox nameBox;
        private TextBox phoneBox;
        private Label label5;
        private TextBox passwordBox;
        private Label label6;
        private TextBox IDBox;
        private Label label3;
        private TextBox addressBox;
    }
}