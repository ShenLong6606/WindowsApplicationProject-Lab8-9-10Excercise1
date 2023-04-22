using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application_Project
{
    public partial class Agents : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=MSI;Initial Catalog=Database2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tablet = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Agents";
            adapter.SelectCommand = command;
            tablet.Clear();
            adapter.Fill(tablet);
            dsAgent.DataSource = tablet;
        }
        public Agents()
        {
            InitializeComponent();
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dsAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_AgentID.ReadOnly = true;
            int i;
            i = dsAgent.CurrentRow.Index;
            tb_AgentID.Text = dsAgent.Rows[i].Cells[0].Value.ToString();
            tb_AgentName.Text = dsAgent.Rows[i].Cells[1].Value.ToString();
            tb_Address.Text = dsAgent.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into Agents values('" + tb_AgentID.Text + "' , '" + tb_AgentName.Text + "' , '" + tb_Address.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete from Agents where AgentID = '" + tb_AgentID.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
