using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Services : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        private string query = "select DVK.*, DVSD.MAHSBA, DVSD.MAGIAYKHAMBENH, DVSD.GHICHU " +
                               "from DICHVUSUDUNG DVSD JOIN DICHVUKHAM DVK ON DVSD.MADICHVU = DVK.MADICHVU";
        public Dentist_Services()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            Helper.refreshData(query, serviceData);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Dentist_Services_Load(object sender, EventArgs e)
        {
            serviceData.DataSource = Helper.getData(query).Tables[0];

            cboService.DisplayMember = "TENDICHVU";
            cboService.ValueMember = "MADICHVU";
            cboService.DataSource = Helper.getData("select DVSD.MADICHVU, DVK.TENDICHVU from DICHVUKHAM DVK JOIN DICHVUSUDUNG DVSD ON DVK.MADICHVU = DVSD.MADICHVU").Tables[0];

            cboRecord.DisplayMember = "MAHSBA";
            cboRecord.ValueMember = "MAHSBA";
            cboRecord.DataSource = Helper.getData("select MAHSBA from HOSOBENHAN").Tables[0];

            cboCertificate.DisplayMember = "MAGIAYKHAMBENH";
            cboCertificate.ValueMember = "MAGIAYKHAMBENH";
            cboCertificate.DataSource = Helper.getData("select DISTINCT MAGIAYKHAMBENH from GIAYKHAMBENH").Tables[0];
        }

        private void serviceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = serviceData.Rows[e.RowIndex];
                servicesIDBox.Text = dgvr.Cells["MADICHVU"].Value.ToString();
                cboRecord.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                cboCertificate.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                cboService.Text = dgvr.Cells["TENDICHVU"].Value.ToString();
                noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();
            }
        }

        private void addServicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_DICHVUSUDUNG_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboService.SelectedItem;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", cboRecord.Text));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@MADICHVU", item["MADICHVU"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dịch vụ thất bại! " + ex.Message);
            }
        }

        private void updateServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_DICHVUSUDUNG_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                var item = (DataRowView)cboService.SelectedItem;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", cboRecord.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@MADICHVU", item["MADICHVU"].ToString().Trim()));
                cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dịch vụ thất bại! " + ex.Message);
            }
        }

        private void deleteServiceButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa loại thuốc này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_DICHVUSUDUNG_DEL", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    var item = (DataRowView)cboService.SelectedItem;

                    cmd.Parameters.Add(new SqlParameter("@MAHSBA", cboRecord.Text));
                    cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text));
                    cmd.Parameters.Add(new SqlParameter("@MADICHVU", item["MADICHVU"].ToString()));
                    cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại!");
                    }
                    refresh();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dịch vụ thất bại! " + ex.Message);
                }
            }
            else { }
        }
    }
}
