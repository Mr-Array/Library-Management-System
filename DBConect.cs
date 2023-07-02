using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class DBConect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void Opencon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void Closedcon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}