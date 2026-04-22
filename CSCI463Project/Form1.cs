namespace CSCI463Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserIdText.Text == "UserID" && PasswordText.Text == "Password")
            {
                Form dashboard = new Form();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void UserIdText_GotFocus(object sender, EventArgs e)
        {
            if (UserIdText.Text == "UserID")
            {
                UserIdText.Text = "";
                UserIdText.ForeColor = Color.Black;
            }
        }
        private void UserIdText_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserIdText.Text))
            {
                UserIdText.Text = "UserID";
                UserIdText.ForeColor = Color.Gray;
            }
        }
        private void UserIdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
