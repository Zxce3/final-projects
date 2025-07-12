namespace Zakatin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;  // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;  // Hide password
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if username and password are correct
            if (username == "admin" && password == "admin123")
            {
                // If login is successful, open the MainForm
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();  // Hide the Login Form after login
            }
            else
            {
                MessageBox.Show("Username atau passwordnya salah!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // This will close the whole application
        }
    }
}