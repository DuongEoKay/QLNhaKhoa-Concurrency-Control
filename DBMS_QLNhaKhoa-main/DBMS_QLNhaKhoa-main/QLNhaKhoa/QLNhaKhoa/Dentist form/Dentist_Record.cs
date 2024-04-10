using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Record : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Record()
        {
            InitializeComponent();
        }

        private void Dentist_Record_Load(object sender, EventArgs e)
        {
            string record_query = "select * from HOSOBENHNHAN";
            recordData.DataSource = Helper.getData(record_query).Tables[0];


        }

        private void refresh()
        {
            Helper.refreshData("select * from HOSOBENHNHAN ", recordData);
        }

        private void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = recordData.Rows[e.RowIndex];
                hosoTextbox.Text = dgvr.Cells["IDHOSO"].Value.ToString();


            }
        }





        private void themHS_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_HOSOBENHNHAN", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IDNHASI", CurrentDentist));
                cmd.Parameters.Add(new SqlParameter("@IDKHACHHANG", idkhachTextBox.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@THOIGIANKHAM", ngayHen.Value));
                cmd.ExecuteNonQuery();

                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateHoSo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_HOSOBENHNHAN_LU", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", hosoTextbox.Text));
                cmd.Parameters.Add("@SONGAYDOI", SqlDbType.Int).Value = doingayTextbox.Text;
                cmd.ExecuteNonQuery();

                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idkhachTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
