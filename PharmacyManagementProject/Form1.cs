using System.Data.SqlClient;

namespace PharmacyManagementProject
{
    public partial class Form1 : Form
    {
        KetNoi kn = new KetNoi();
        SqlCommand cmd;
        SqlConnection cn;
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
            string username = userNameBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = kn.conn)
            {
                if (connection == null || kn.conn == null)
                {
                    MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    connection.Open();
                    cmd = new SqlCommand("SELECT vaitro FROM Users WHERE username = @username AND pass = @Password", connection);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        if (role == "Quản Trị Viên")
                        {
                            Admin adminForm = new Admin();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (role == "Dược Sĩ")
                        {
                            Pharmacist pharmacistForm = new Pharmacist(); 
                            pharmacistForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Vai trò không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Lỗi khi truy vấn cơ sở dữ liệu: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Một lỗi đã xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }









            /* if (userNameBox.Text == "admin" && passwordBox.Text == "pass")
             {
                 Admin am = new Admin();
                 am.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Wrong Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }*/
        }
    }
}
