using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application_Project
{
    public partial class WorkingForm : Form
    {
        public WorkingForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products Products = new Products();
            Products.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agents Agents = new Agents();
            Agents.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order Order = new Order();
            Order.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Filter1 Filter1 = new Filter1();
            Filter1.Show();
        }
    }
}
