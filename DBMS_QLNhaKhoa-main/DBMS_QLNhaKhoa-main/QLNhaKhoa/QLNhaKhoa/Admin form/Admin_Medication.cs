using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Medication : Form
    {
        string NQL;
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_Medication()
        {
            InitializeComponent();
        }


        private void refresh()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_VIEW_THUOC", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter.SelectCommand = cmd;
                dt.Clear();
                adapter.Fill(dt);
                medData.DataSource = dt;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex.Message);
            }
        }


        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();

                medIDBox.Text = dgvr.Cells["MATHUOC"].Value.ToString();
                unitBox.Text = dgvr.Cells["DVT"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTON"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                priceBox.Text = dgvr.Cells["DONGIA"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                prescribeBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();

            }
        }

        private void addMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_MEDICINE", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", unitBox.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTON", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGUOIQUANLY", CurrentAdmin));
                cmd.Parameters.Add("@MATHUOC", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex.Message);
            }

        }


        private void updateMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_MEDICINE_CD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", unitBox.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTON", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONGIA", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGUOIQUANLY", CurrentAdmin));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thuốc thất bại! " + ex.Message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_MEDICINE_THEM_SLTK", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTHEM", soluongTextbox.Text));
                cmd.ExecuteNonQuery();
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thuốc thất bại! " + ex.Message);
            }
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_MEDICINE_GIAM_SLTK", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGGIAM", soluongTextbox.Text));
                cmd.ExecuteNonQuery();
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thuốc thất bại! " + ex.Message);
            }
        }
    }
}
