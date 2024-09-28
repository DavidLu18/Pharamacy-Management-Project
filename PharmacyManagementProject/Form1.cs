namespace PharmacyManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            userNameBox.Clear();
            passwordBox.Clear();
        }

        private void SignInButton_MouseEnter(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void SignInButton_MouseLeave(object sender, EventArgs e)
        {
            SignInButton.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void ResetButton_MouseHover(object sender, EventArgs e)
        {

        }

        private void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ResetButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void ResetButton_MouseLeave(object sender, EventArgs e)
        {
            ResetButton.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text == "admin" && passwordBox.Text == "pass")
            {
                Admin am = new Admin();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
