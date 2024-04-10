using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    internal class Helper
    {
       
        public static DataSet getData(string query)
        {
            SqlConnection sqlCon = new SqlConnection(Program.sqlCon);
            sqlCon.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter ap = new SqlDataAdapter(query, sqlCon);
            ap.Fill(dt);
            sqlCon.Close();
            return dt;
        }
        public static void loadform(object Form, Panel mainPanel)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }
        public static void refreshData(string query, DataGridView d)
        {
            d.DataSource = getData(query).Tables[0];
        }
    }
}
