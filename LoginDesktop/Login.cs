namespace LoginDesktop
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Login Successful");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            // validate null or empty
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username or Password cannot be empty");
            }
        }
    }
}