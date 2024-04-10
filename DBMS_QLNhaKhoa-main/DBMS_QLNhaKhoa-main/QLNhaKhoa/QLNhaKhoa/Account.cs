using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class Account : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Account()
        {
            InitializeComponent();
        }

  
        private void Account_Load(object sender, EventArgs e)
        {
            string query = "select HOTEN,SDT, DIACHI from NHANSU where IDNhanSu ='" + CurrentUser + "'";
            if (CurrentUser.Contains("KH"))
            {
                query = "select HOTEN,NGAYSINH,SDT from KHACHHANG where IDKhachHang='" + CurrentUser + "'";
            }
            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                   if (CurrentUser.Contains("KH")) bdayBox.Text = reader["NGAYSINH"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    phoneBox.Text = reader["SDT"].ToString();
                   if(!CurrentUser.Contains("KH")) addressBox.Text = reader["DiaChi"].ToString();
                    passwordBox.Text = CurrentPass;
                    IDBox.Text = CurrentUser;
                    sqlCon.Close();
                }
               
            }
        }

       
    }
}
