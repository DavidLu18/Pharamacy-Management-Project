using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace PharmacyManagementProject.AdminUC
{
    public partial class UC_Dashboard : UserControl
    {
        KetNoi kn = new KetNoi();
        Microsoft.Data.SqlClient.SqlConnection cn;
        Microsoft.Data.SqlClient.SqlCommand cmd;
        
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        void FillChart()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUserCount();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateUserCount();
            button1.PerformClick();
        }
        private void UpdateUserCount()
        {
            try
            {
                using (cn = new Microsoft.Data.SqlClient.SqlConnection(kn.conn.ConnectionString)) 
                {
                    cn.Open();
                    string adminQuery = "SELECT COUNT(*) FROM users WHERE vaitro = N'Quản Trị Viên'";
                    using (cmd = new Microsoft.Data.SqlClient.SqlCommand(adminQuery, cn))
                    {
                        int adminCount = (int)cmd.ExecuteScalar();
                        NumberAdminLabel.Text = adminCount.ToString(); 
                    }
                    string pharmacistQuery = "SELECT COUNT(*) FROM users WHERE vaitro = N'Dược Sĩ'";
                    using (cmd = new Microsoft.Data.SqlClient.SqlCommand(pharmacistQuery, cn))
                    {
                        int pharmacistCount = (int)cmd.ExecuteScalar();
                        NumberPharaLabel.Text = pharmacistCount.ToString(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching user count: " + ex.Message);
                Console.WriteLine(ex); 
            }
        }
    }
}
