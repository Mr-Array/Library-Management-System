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
    public partial class Student : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;

        public string email_login { get; set; }

        public Student()
        {
            InitializeComponent();
        }

        private void search_book_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            SearchForm frm = new SearchForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();

        }

        private void show_books_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            showform frm = new showform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();
        }

        private void issu_book_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Issueform frm = new Issueform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(frm);
            this.mainpanel.Tag = frm;
            frm.Show();
        }

        private void show_id_Click(object sender, EventArgs e)
        {
            string select_qr = $"select UserID from Users\r\nwhere Email = '{email_login}';";
            cmd = new SqlCommand(select_qr, conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();


            MessageBox.Show($"Your ID is: {reader.GetInt32(0)}", "ID", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();



        }

        private void log_out_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("are you sure want log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login_Form login_Form = new Login_Form();
                this.Hide();
                login_Form.Show();

            }
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
