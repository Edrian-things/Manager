using MySql.Data.MySqlClient;
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
    public partial class ViewOrders : Form
    {

        private string connectionString = "Server=localhost;Port=3306;Database=mixandmelt;Uid=root;Pwd=DBpass12345$;";

        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }


        private void LoadOrders()
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM orders", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = dataTable;
            }




        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            ManagerPage form2 = new ManagerPage();
            form2.Show();
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