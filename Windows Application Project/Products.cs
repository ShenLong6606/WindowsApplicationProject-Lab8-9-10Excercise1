using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Windows_Application_Project
{
    public partial class Products : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=MSI;Initial Catalog=Database1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Item";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dsSanPham.DataSource = table;
        }
        public Products()
        {
            InitializeComponent();
        }

        private void OrderTable2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        private void dsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ItemID.ReadOnly = true;
            int i;
            i = dsSanPham.CurrentRow.Index;
            tb_ItemID.Text = dsSanPham.Rows[i].Cells[0].Value.ToString();
            tb_ItemName.Text = dsSanPham.Rows[i].Cells[1].Value.ToString();
            tb_Size.Text = dsSanPham.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Item values('"+tb_ItemID.Text+"' , '"+tb_ItemName.Text+ "' , '"+tb_Size.Text+ "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete from Item where ItemID = '"+tb_ItemID.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}