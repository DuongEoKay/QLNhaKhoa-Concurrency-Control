using System.Data;
using System.Data.SqlClient;
using QLNhaKhoa.Employee_form;
using QLNhaKhoa.Dentist_form;
using QLNhaKhoa.Admin_form;

namespace QLNhaKhoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtID;
            txtID.Focus();
        }

      

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("invalid credential");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                    sqlCon.Open();
                    SqlCommand cmd = sqlCon.CreateCommand();
                    cmd.CommandText = "Select * from NhanSu ns, KhachHang kh where ns.IDNHANSU = @idns AND ns.Matkhau = @mkns OR kh.IDKHACHHANG = @idkh AND kh.MatKhau = @mkkh";
                    cmd.Parameters.Add(new SqlParameter("@idns", txtID.Text));
                    cmd.Parameters.Add(new SqlParameter("@mkns", txtPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@idkh", txtID.Text));
                    cmd.Parameters.Add(new SqlParameter("@mkkh", txtPassword.Text));
                    cmd.ExecuteNonQuery();

                    if (txtID.Text.Contains("KH"))
                    {
                        Customer_Main f = new Customer_Main();
                        f.CurrentUser = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else if (txtID.Text.Contains("NV"))
                    {
                        Emp_Main f = new Emp_Main();
                        f.CurrentEmp = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else if (txtID.Text.Contains("NS"))
                    {
                        Dentist_Main f = new Dentist_Main();
                        f.CurrentDentist = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        Admin_Main f = new Admin_Main();
                        f.AD = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide(); ;
                    }

                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID hoặc mật khẩu sai! " + ex.Message);
                }
            }
        }
    }
}