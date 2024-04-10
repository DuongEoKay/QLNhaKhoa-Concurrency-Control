namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Record
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
            updateHoSo = new Button();
            themHS = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            idkhachTextBox = new TextBox();
            label3 = new Label();
            ngayHen = new DateTimePicker();
            doingayTextbox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            hosoTextbox = new TextBox();
            recordData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(updateHoSo);
            panel1.Controls.Add(themHS);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(recordData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 525);
            panel1.TabIndex = 0;
            // 
            // updateHoSo
            // 
            updateHoSo.BackColor = Color.SteelBlue;
            updateHoSo.FlatAppearance.BorderSize = 0;
            updateHoSo.FlatStyle = FlatStyle.Flat;
            updateHoSo.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateHoSo.ForeColor = Color.White;
            updateHoSo.Location = new Point(136, 225);
            updateHoSo.Margin = new Padding(3, 2, 3, 2);
            updateHoSo.Name = "updateHoSo";
            updateHoSo.Size = new Size(88, 30);
            updateHoSo.TabIndex = 4;
            updateHoSo.Text = "Update";
            updateHoSo.UseVisualStyleBackColor = false;
            updateHoSo.Click += updateHoSo_Click;
            // 
            // themHS
            // 
            themHS.BackColor = Color.SteelBlue;
            themHS.FlatAppearance.BorderSize = 0;
            themHS.FlatStyle = FlatStyle.Flat;
            themHS.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            themHS.ForeColor = Color.White;
            themHS.Location = new Point(44, 225);
            themHS.Margin = new Padding(3, 2, 3, 2);
            themHS.Name = "themHS";
            themHS.Size = new Size(88, 30);
            themHS.TabIndex = 3;
            themHS.Text = "Add";
            themHS.UseVisualStyleBackColor = false;
            themHS.Click += themHS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(253, 19);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 0;
            label1.Text = "Customer Medical Record";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(idkhachTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ngayHen);
            panel2.Controls.Add(doingayTextbox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(hosoTextbox);
            panel2.Location = new Point(44, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 188);
            panel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(32, 47);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 10;
            label5.Text = "ID khach hang";
            // 
            // idkhachTextBox
            // 
            idkhachTextBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idkhachTextBox.Location = new Point(32, 67);
            idkhachTextBox.Margin = new Padding(3, 2, 3, 2);
            idkhachTextBox.Name = "idkhachTextBox";
            idkhachTextBox.PlaceholderText = "ID Khach Hang";
            idkhachTextBox.Size = new Size(219, 23);
            idkhachTextBox.TabIndex = 9;
            idkhachTextBox.TextChanged += idkhachTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(381, 104);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 8;
            label3.Text = "Ngay kham";
            // 
            // ngayHen
            // 
            ngayHen.Location = new Point(381, 126);
            ngayHen.Name = "ngayHen";
            ngayHen.Size = new Size(219, 23);
            ngayHen.TabIndex = 7;
            // 
            // doingayTextbox
            // 
            doingayTextbox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doingayTextbox.Location = new Point(380, 67);
            doingayTextbox.Margin = new Padding(3, 2, 3, 2);
            doingayTextbox.Name = "doingayTextbox";
            doingayTextbox.PlaceholderText = "So ngay doi";
            doingayTextbox.Size = new Size(219, 23);
            doingayTextbox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(32, 106);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 5;
            label4.Text = "ID Ho So";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(379, 46);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 3;
            label2.Text = "So ngay doi";
            // 
            // hosoTextbox
            // 
            hosoTextbox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hosoTextbox.Location = new Point(32, 126);
            hosoTextbox.Margin = new Padding(3, 2, 3, 2);
            hosoTextbox.Name = "hosoTextbox";
            hosoTextbox.PlaceholderText = "ID Ho So";
            hosoTextbox.ReadOnly = true;
            hosoTextbox.Size = new Size(219, 23);
            hosoTextbox.TabIndex = 0;
            // 
            // recordData
            // 
            recordData.AllowUserToAddRows = false;
            recordData.AllowUserToDeleteRows = false;
            recordData.AllowUserToResizeColumns = false;
            recordData.AllowUserToResizeRows = false;
            recordData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            recordData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            recordData.BorderStyle = BorderStyle.None;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Bottom;
            recordData.Location = new Point(0, 263);
            recordData.Margin = new Padding(3, 2, 3, 2);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(788, 262);
            recordData.TabIndex = 2;
            recordData.CellClick += recordData_CellClick;
            // 
            // Dentist_Record
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 525);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dentist_Record";
            Text = "Dentist_Record";
            Load += Dentist_Record_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView recordData;
        private Panel panel2;
        private Label label1;
        private Button themHS;
        private Button updateHoSo;
        private TextBox hosoTextbox;
        private Label label2;
        private Label label4;
        private TextBox doingayTextbox;
        private Label label3;
        private DateTimePicker ngayHen;
        private Label label5;
        private TextBox idkhachTextBox;
    }
}