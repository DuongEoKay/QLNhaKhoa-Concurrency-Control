using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa.General_form
{
    public partial class Customer_Appointment : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Appointment()
        {
            InitializeComponent();
        }
        private void callProc()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_VIEW_LICHHEN", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IDNHASI", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@IDKHACHHANG", CurrentUser));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                dt.Clear();
                adapter.Fill(dt);
                appointmentData.DataSource = dt;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            callProc();
        }
    }
}
