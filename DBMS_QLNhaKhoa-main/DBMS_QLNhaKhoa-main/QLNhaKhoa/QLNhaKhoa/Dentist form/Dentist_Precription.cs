using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Prescription : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Prescription()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            Helper.refreshData("select * from SUDUNGTHUOC", prescriptionData);
        }

        private void Dentist_Prescription_Load(object sender, EventArgs e)
        {
            prescriptionData.DataSource = Helper.getData("select * from SUDUNGTHUOC").Tables[0];

            cboRecord.DisplayMember = "IDHOSO";
   
            cboRecord.DataSource = Helper.getData("select HSBN.IDHOSO from HOSOBENHNHAN HSBN").Tables[0];

            cboMedication.DisplayMember = "MATHUOC";
            cboMedication.DataSource = Helper.getData("select MATHUOC from THUOC").Tables[0];

          
        }
        private void prescriptionData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = prescriptionData.Rows[e.RowIndex];
                quantityBox.Text = dgvr.Cells["SOLUONG"].Value.ToString();
                cboRecord.Text = dgvr.Cells["IDHOSO"].Value.ToString();
                cboMedication.Text = dgvr.Cells["IDTHUOC"].Value.ToString();
         
             
         
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void addPreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_INSERT_SUDUNGTHUOC", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

    
     
                cmd.Parameters.Add(new SqlParameter("@SOLUONG", quantityBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", cboMedication.Text));
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", cboRecord.Text));

                cmd.ExecuteNonQuery();
             
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void updatePreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_SUDUNGTHUOC_CYD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SOLUONGMOI", quantityBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", cboMedication.Text));
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", cboRecord.Text));
                cmd.ExecuteNonQuery();
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletePreButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SP_DELETE_SUDUNGTHUOC_CYD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MATHUOC", cboMedication.Text));
                cmd.Parameters.Add(new SqlParameter("@IDHOSO", cboRecord.Text));
                cmd.ExecuteNonQuery();
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
