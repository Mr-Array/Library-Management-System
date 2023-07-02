using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ShowLibrarians : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public ShowLibrarians()
        {
            InitializeComponent();
            string select_query = "select UserID , Username, Type , Email , Address from Users where  Type = 'Librarian' order by UserID;";
            adapter = new SqlDataAdapter(select_query, conn);

            adapter.Fill(ds, "Users");

            dataGridViewLibrarians.DataSource = ds.Tables["Users"];
        }
    }
}