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

namespace Windows_Application_Project
{
    public partial class Filter1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=Database4;Integrated Security=True");
        public Filter1()
        {
            InitializeComponent();
        }
        private void combo1()
        {
            string query1 = "select Status from Filter";

            SqlDataAdapter da = new SqlDataAdapter(query1, conn);
            conn.Open();
            DataSet dt = new DataSet();
            da.Fill(dt, "Status");
            SelectStatus.DisplayMember = "Status";
            SelectStatus.ValueMember = "Status";
            SelectStatus.DataSource = dt.Tables["Status"];
            conn.Close();
            if (SelectStatus.Items.Count > 1)
            {
                SelectStatus.SelectedIndex = -1;
            }
        }

        private void display_datagrid()
        {
            SqlCommand query2 = new SqlCommand("Select ItemID, Itemname, Price, Status from Filter where Status like '%" + SelectStatus.Text+ "'", conn);
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataTable dt2 = new DataTable();
            da2.SelectCommand = query2;
            dt2.Clear();
            da2.Fill(dt2);
            tb_Data.DataSource = dt2;
        }

        private void Filter1_Load(object sender, EventArgs e)
        {
            combo1();
            display_datagrid();
        }

        private void SelectStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_datagrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
