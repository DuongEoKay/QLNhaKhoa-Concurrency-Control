using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Appointment : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Appointment()
        {
            InitializeComponent();
        }

        private void Emp_Appointment_Load(object sender, EventArgs e)
        {
            appointmentData.DataSource = Helper.getData("select * from LICHHEN").Tables[0];

            cboCustomer.DisplayMember = "IDKHACHHANG";
            cboCustomer.ValueMember = "MAKHACHHANG";
            cboCustomer.DataSource = Helper.getData("select IDKHACHHANG from KHACHHANG").Tables[0];

            cboDentists.DisplayMember = "IDNHANSU";
            cboDentists.ValueMember = "MANHANVIEN";
            cboDentists.DataSource = Helper.getData("select IDNHANSU from NHANSU where LOAINHANSU = 'NS'").Tables[0];
        }

        private void refresh()
        {
            Helper.refreshData("select * from LICHHEN", appointmentData);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

       
        private void makeAppButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_LICHHEN_DR", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@THOIGIANKHAM", appointDate.Value));
                cmd.Parameters.Add(new SqlParameter("@IDKHACHHANG",cboCustomer.Text));
                cmd.Parameters.Add(new SqlParameter("@IDNHASI", cboDentists.Text));
                cmd.Parameters.Add(new SqlParameter("@IDNVDATLICH", CurrentEmp));
                      cmd.Parameters.Add("@IDLICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
               
              cmd.ExecuteNonQuery();
              
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

     

        
    }
}
