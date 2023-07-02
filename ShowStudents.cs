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
    public partial class ShowStudents : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public ShowStudents()
        {
            InitializeComponent();
            string select_query = "select UserID , Username , Type ,Email , Address from Users where  Type = 'Student' order by UserID;";
            adapter = new SqlDataAdapter(select_query, conn);

            adapter.Fill(ds, "Users");

            dataGridViewStudents.DataSource = ds.Tables["Users"];
        }

        private void dataGridViewBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
