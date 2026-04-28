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
            foreach (string line in File.ReadLines("Users.txt"))
            {
                string[] parts = line.Split("|");
                string userRole = parts[0];
                string userName = parts[1];
                string password = parts[2];
                Session.UserRole = userRole;
                Session.Username = userName;

                if (UserIdText.Text == userName)
                {
                    if (PasswordText.Text == password)
                    {
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.ShowDialog();
                        this.Close();
                    }
                }

            }
            MessageBox.Show("Invalid username or password. Please try again.");
        }
    }
}
