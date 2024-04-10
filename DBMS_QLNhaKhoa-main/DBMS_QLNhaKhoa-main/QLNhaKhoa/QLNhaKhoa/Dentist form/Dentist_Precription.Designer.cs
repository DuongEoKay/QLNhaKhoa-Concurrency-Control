namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Prescription
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
            panel = new Panel();
            updatePreButton = new Button();
            deletePreButton = new Button();
            addPreButton = new Button();
            label1 = new Label();
            prescriptionData = new DataGridView();
            cboMedication = new ComboBox();
            cboRecord = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            quantityBox = new TextBox();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.Controls.Add(cboMedication);
            panel.Controls.Add(cboRecord);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Controls.Add(label2);
            panel.Controls.Add(quantityBox);
            panel.Controls.Add(updatePreButton);
            panel.Controls.Add(deletePreButton);
            panel.Controls.Add(addPreButton);
            panel.Controls.Add(label1);
            panel.Controls.Add(prescriptionData);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(788, 525);
            panel.TabIndex = 7;
            // 
            // updatePreButton
            // 
            updatePreButton.BackColor = Color.SteelBlue;
            updatePreButton.FlatAppearance.BorderSize = 0;
            updatePreButton.FlatStyle = FlatStyle.Flat;
            updatePreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatePreButton.ForeColor = Color.White;
            updatePreButton.Location = new Point(578, 215);
            updatePreButton.Margin = new Padding(3, 2, 3, 2);
            updatePreButton.Name = "updatePreButton";
            updatePreButton.Size = new Size(88, 30);
            updatePreButton.TabIndex = 5;
            updatePreButton.Text = "Update";
            updatePreButton.UseVisualStyleBackColor = false;
            updatePreButton.Click += updatePreButton_Click;
            // 
            // deletePreButton
            // 
            deletePreButton.BackColor = Color.SteelBlue;
            deletePreButton.FlatAppearance.BorderSize = 0;
            deletePreButton.FlatStyle = FlatStyle.Flat;
            deletePreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletePreButton.ForeColor = Color.White;
            deletePreButton.Location = new Point(671, 215);
            deletePreButton.Margin = new Padding(3, 2, 3, 2);
            deletePreButton.Name = "deletePreButton";
            deletePreButton.Size = new Size(88, 30);
            deletePreButton.TabIndex = 4;
            deletePreButton.Text = "Delete";
            deletePreButton.UseVisualStyleBackColor = false;
            deletePreButton.Click += deletePreButton_Click;
            // 
            // addPreButton
            // 
            addPreButton.BackColor = Color.SteelBlue;
            addPreButton.FlatAppearance.BorderSize = 0;
            addPreButton.FlatStyle = FlatStyle.Flat;
            addPreButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPreButton.ForeColor = Color.White;
            addPreButton.Location = new Point(486, 215);
            addPreButton.Margin = new Padding(3, 2, 3, 2);
            addPreButton.Name = "addPreButton";
            addPreButton.Size = new Size(88, 30);
            addPreButton.TabIndex = 3;
            addPreButton.Text = "Add";
            addPreButton.UseVisualStyleBackColor = false;
            addPreButton.Click += addPreButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Prescription";
            // 
            // prescriptionData
            // 
            prescriptionData.AllowUserToDeleteRows = false;
            prescriptionData.AllowUserToResizeColumns = false;
            prescriptionData.AllowUserToResizeRows = false;
            prescriptionData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            prescriptionData.BorderStyle = BorderStyle.None;
            prescriptionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionData.Dock = DockStyle.Bottom;
            prescriptionData.Location = new Point(0, 263);
            prescriptionData.Margin = new Padding(3, 2, 3, 2);
            prescriptionData.Name = "prescriptionData";
            prescriptionData.RowHeadersWidth = 51;
            prescriptionData.Size = new Size(788, 262);
            prescriptionData.TabIndex = 2;
            prescriptionData.CellClick += prescriptionData_CellClick;
            // 
            // cboMedication
            // 
            cboMedication.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMedication.FormattingEnabled = true;
            cboMedication.Location = new Point(29, 128);
            cboMedication.Margin = new Padding(3, 2, 3, 2);
            cboMedication.Name = "cboMedication";
            cboMedication.Size = new Size(219, 24);
            cboMedication.TabIndex = 16;
            // 
            // cboRecord
            // 
            cboRecord.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRecord.FormattingEnabled = true;
            cboRecord.Location = new Point(29, 73);
            cboRecord.Margin = new Padding(3, 2, 3, 2);
            cboRecord.Name = "cboRecord";
            cboRecord.Size = new Size(219, 24);
            cboRecord.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(29, 170);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 14;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(29, 109);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 13;
            label4.Text = "Medication";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(29, 53);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 12;
            label2.Text = "Customer record";
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(29, 189);
            quantityBox.Margin = new Padding(3, 2, 3, 2);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(219, 23);
            quantityBox.TabIndex = 11;
            // 
            // Dentist_Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 525);
            ControlBox = false;
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dentist_Prescription";
            Text = "Dentist_Precription";
            Load += Dentist_Prescription_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Button deletePreButton;
        private Label label1;
        private DataGridView prescriptionData;
        private Button updatePreButton;
        private Button addPreButton;
        private ComboBox cboMedication;
        private ComboBox cboRecord;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox quantityBox;
    }
}