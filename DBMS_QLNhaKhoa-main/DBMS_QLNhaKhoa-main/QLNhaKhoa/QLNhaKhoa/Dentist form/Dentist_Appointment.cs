using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Appointment : Form
    {
        public string CurrentDentist;
        public Dentist_Appointment(string ID)
        {
            InitializeComponent();
            CurrentDentist = ID;

        }



        void refresh()
        {


            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SP_VIEW_LICHHEN_NS", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IDNHASI", CurrentDentist));
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            appointmentData.DataSource = dt;
            sqlCon.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
