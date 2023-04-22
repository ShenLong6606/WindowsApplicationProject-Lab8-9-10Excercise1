﻿using System;
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
    public partial class Order : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=MSI;Initial Catalog=Database3;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable ton = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Orders";
            adapter.SelectCommand = command;
            ton.Clear();
            adapter.Fill(ton);
            dsOrders.DataSource = ton;
        }
        public Order()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into Orders values('" + tb_OrderID.Text + "' , '" + tb_OrderDate.Text + "' , '" + tb_AgentID.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            {
                connection = new SqlConnection(str);
                connection.Open();
                loaddata();
            }
        }

        private void dsOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_OrderID.ReadOnly = true;
            int i;
            i = dsOrders.CurrentRow.Index;
            tb_OrderID.Text = dsOrders.Rows[i].Cells[0].Value.ToString();
            tb_OrderDate.Text = dsOrders.Rows[i].Cells[1].Value.ToString();
            tb_AgentID.Text = dsOrders.Rows[i].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete from Orders where OrderID = '" + tb_OrderID.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
