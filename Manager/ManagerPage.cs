using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewOrders form3 = new ViewOrders();
            form3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewInventory form4 = new ViewInventory();
            form4.Show();
            this.Close();
        }
    }
}
