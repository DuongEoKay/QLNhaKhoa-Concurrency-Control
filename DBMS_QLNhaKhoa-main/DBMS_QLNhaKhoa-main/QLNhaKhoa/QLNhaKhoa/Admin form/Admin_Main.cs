using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Main : Form
    {
        public string AD { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Admin_Main()
        {
            InitializeComponent();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = AD;
            f.CurrentPass = CurrentPass;
            Helper.loadform(f, this.mainPanel);
        }



        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Admin_Medication f = new Admin_Medication();
            f.CurrentAdmin = AD;
            Helper.loadform(f, this.mainPanel);
        }



        public void Admin_Main_Load(object sender, EventArgs e)
        {
           
            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NhanSu where IDNhanSu='" + AD + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AdminName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
