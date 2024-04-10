using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Main : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Dentist_Main()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentDentist;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            Dentist_Services f = new Dentist_Services();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Dentist_Appointment f = new Dentist_Appointment(CurrentDentist);
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void PrecriptionButton_Click(object sender, EventArgs e)
        {
            Dentist_Prescription f = new Dentist_Prescription();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Dentist_Record f = new Dentist_Record();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void Dentist_Main_Load(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NHANSU where IDNHANSU = '" + CurrentDentist + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dentistName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
