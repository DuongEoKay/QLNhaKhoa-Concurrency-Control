using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Main : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Emp_Main()
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
            f.CurrentUser = CurrentEmp;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }
       
        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Emp_Appointment f = new Emp_Appointment();
            f.CurrentEmp = CurrentEmp;
            Helper.loadform(f, this.mainPanel);
        }
        private void Emp_Main_Load(object sender, EventArgs e)
        {
         
            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NHANSU where IDNHANSU = '" + CurrentEmp + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    EmpName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
