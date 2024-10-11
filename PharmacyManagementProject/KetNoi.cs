using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PharmacyManagementProject
{
    class KetNoi
    {
        public SqlConnection conn;
        public KetNoi()
        {
            conn = new SqlConnection("Data Source=DESKTOP-J19NSEJ;Initial Catalog=QL_NHATHUOC;Integrated Security=True;TrustServerCertificate=True");
        }
        public KetNoi(string str)
        {
            conn = new SqlConnection(str);
        }
        public bool checkkey(string s)
        {
            if (conn == null || conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand(s, conn);
            int count = (int)cmd.ExecuteScalar();
            conn.Close(); // Close the connection after executing the command

            return count > 0;
        }
    }
}
