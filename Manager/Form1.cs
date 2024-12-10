namespace Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Manager" && txtPassword.Text == "Password")
            {
                ManagerPage form2 = new ManagerPage();
                form2.Show();
                this.Hide();
            }
            else
            {
                txtPassword.PlaceholderText = "Invalid Username or Password";
                txtUsername.PlaceholderText = "Invalid Username or Password";
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
