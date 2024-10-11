using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Graph.Models.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagementProject.AdminUC
{
    public partial class UC_AddUser : UserControl
    {
        KetNoi kn = new KetNoi();
        SqlConnection cn;
        SqlCommand cmd;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void specialButtrons1_MouseEnter(object sender, EventArgs e)
        {
            specialButtrons1.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void specialButtrons1_MouseLeave(object sender, EventArgs e)
        {
            specialButtrons1.BackColor = Color.MediumSlateBlue;
        }

        private void specialButtrons2_MouseEnter(object sender, EventArgs e)
        {
            specialButtrons2.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void specialButtrons2_MouseLeave(object sender, EventArgs e)
        {
            specialButtrons2.BackColor = Color.MediumSlateBlue;
        }

        private void specialButtrons1_Click(object sender, EventArgs e)
        {
            string vaitro = ComboBoxRole.Texts;
            string ten = TextBoxUserName.Texts;
            string ngSinh = dateTimePicker1.Text;
            string sdt = TextBoxSDT.Texts;
            string email = TextBoxEmail.Texts;
            string userName = TextBoxNhapUser.Texts;
            string pass = TextBoxNhapPass.Texts;
            if (ten.Length == 0 && sdt.Length == 0 && email.Length == 0 && userName.Length == 0 && pass.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }

            if (!IsValidPhoneNumber(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (kn.checkkey("SELECT COUNT(*) FROM USERS WHERE SDT = '" + sdt + "'") == true)
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }
            if (kn.checkkey("SELECT COUNT(*) FROM USERS WHERE username = '" + userName + "'") == true)
            {
                MessageBox.Show("User đã tồn tại!");
                return;
            }
            try
            {
                cn = kn.conn;
                cn.Open();
                cmd = new SqlCommand("INSERT INTO USERS(ten,vaitro,ngsinh,sdt,email,username,pass) VALUES (@ten, @vaitro,@ngsinh, @sdt, @email, @username, @pass)", cn);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@vaitro", vaitro);
                cmd.Parameters.AddWithValue("@ngsinh", ngSinh);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("username", userName);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void specialButtrons2_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            ComboBoxRole.SelectedIndex = -1;
            TextBoxUserName.Texts = "";
            TextBoxSDT.Texts = "";
            TextBoxEmail.Texts = "";
            TextBoxNhapUser.Texts = "";
            TextBoxNhapPass.Texts = "";
        }
        public bool IsUsernameUnique(string username)
        {
            bool isUnique = true; // Default to unique
            try // Use the connection
            {
                cn = kn.conn;
                cn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        isUnique = false;
                    }
                }
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return isUnique;
        }
        private void TextBoxNhapUser__TextChanged(object sender, EventArgs e)
        {
            string username = TextBoxNhapUser.Texts;
            cmd = new SqlCommand("SELECT * FROM USERS WHERE username = '" + TextBoxNhapUser.Texts + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            if (IsUsernameUnique(username))
            {
                pictureBox1.ImageLocation = @"C:\\Users\\DAVID\\Downloads\\Image for pharamacy\\icons8-tick-128.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\\Users\\DAVID\\Downloads\\Image for pharamacy\\icons8-wrong-128.png";
            }
        }
    }
}
