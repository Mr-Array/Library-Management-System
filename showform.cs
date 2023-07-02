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
    public partial class showform : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        public showform()
        {
            InitializeComponent();

            string select_query = "select * from Books\r\norder by ID,section asc;";
            adapter = new SqlDataAdapter(select_query, conn);

            adapter.Fill(ds, "Books");

            dataGridViewbooks.DataSource = ds.Tables["Books"];

        }

        private void dataGridViewbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
