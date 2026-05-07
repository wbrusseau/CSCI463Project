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
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "information", "Users.txt");
            foreach (string line in File.ReadLines(filePath))
            {
                string[] parts = line.Split("|");
                string userRole = parts[0];
                string userName = parts[1];
                string password = parts[2];
                string fullName = parts[3];
                Session.UserRole = userRole;
                Session.Username = userName;
                Session.FullName = fullName;

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

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
