using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

       

        private void delete_lib_Click(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            deleteformcs frm = new deleteformcs();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void Add_lib_Click(object sender, EventArgs e)
        {
           Register frm = new Register();
           // frm.hideitem("Student");
           // frm.HideButton();
           frm.Show();
        }

      

        
        private void show_books_Click(object sender, EventArgs e)
        {
            
        }

        private void add_book_Click_1(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            Add_books frm = new Add_books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            Delete_Books frm = new Delete_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            SearchForm frm = new SearchForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            Return_Books frm = new Return_Books();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            BorrowedBooks frm = new BorrowedBooks();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

       

       

        

        private void Btnst_Click(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            ShowStudents frm = new ShowStudents();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
           
        }

        private void show_books_Click_1(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            showform frm = new showform();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            adminpanel.Controls.Clear();
            ShowLibrarians frm = new ShowLibrarians();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.adminpanel.Controls.Add(frm);
            this.adminpanel.Tag = frm;
            frm.Show();
        }

        private void log_out_Click_2(object sender, EventArgs e)
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
    }
}
