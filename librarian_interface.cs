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
    public partial class librarian_interface : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public librarian_interface()
        {
            InitializeComponent();
        }
        

        private void add_book_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Add_books frm = new Add_books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Delete_Books frm = new Delete_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void Log_out_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            SearchForm frm = new SearchForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void show_books_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            showform frm = new showform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            Return_Books frm = new Return_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            BorrowedBooks frm = new BorrowedBooks();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Log_out_Click_1(object sender, EventArgs e)
        {
            Login_Form frm = new Login_Form();

            DialogResult res = MessageBox.Show("are you sure want log out?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login_Form frm2 = new Login_Form();
                frm2.Show();
                this.Hide();
            }
        }

        private void Btnst_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            ShowStudents frm = new ShowStudents();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(frm);
            this.main_panel.Tag = frm;
            frm.Show();
        }
    }
}