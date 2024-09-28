using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }



        private void DashboardButton_MouseEnter(object sender, EventArgs e)
        {
            DashboardButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void DashboardButton_MouseLeave(object sender, EventArgs e)
        {
            DashboardButton.BackColor = Color.FromArgb(98, 86, 202);
        }

        private void addUserButton_MouseEnter(object sender, EventArgs e)
        {
            addUserButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void addUserButton_MouseLeave(object sender, EventArgs e)
        {
            addUserButton.BackColor = Color.FromArgb(98, 86, 202);
        }

        private void allUserButton_MouseEnter(object sender, EventArgs e)
        {
            allUserButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void allUserButton_MouseLeave(object sender, EventArgs e)
        {
            allUserButton.BackColor = Color.FromArgb(98, 86, 202);
        }

        private void profileButton_MouseEnter(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.BackColor = Color.FromArgb(98, 86, 202);
        }

        private void logOutButton_MouseEnter(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void logOutButton_MouseLeave(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.FromArgb(98, 86, 202);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Show();
            uC_Dashboard1.BringToFront();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Hide();
           
        }
    }
}
