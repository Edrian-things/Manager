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
    public partial class ViewInventory : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=mixandmelt;Uid=root;Pwd=DBpass12345$;";
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        public void LoadInventory()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM menuitems", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataTable;
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

        
    }
}
