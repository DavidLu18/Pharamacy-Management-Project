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

namespace PharmacyManagementProject.AdminUC
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        void FillChart()
        {
           SqlConnection con = new SqlConnection("Data Source=DESKTOP-3J5H5H9;Initial Catalog=pharmacy;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM medicine", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
