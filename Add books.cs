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

    public partial class Add_books : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Add_books()
        {
            InitializeComponent();
        }
        class TitleDuplictaed : Exception
        {
            public TitleDuplictaed(string message) : base(message)
            {

            }
        }
        private void Add_to_Click(object sender, EventArgs e)
        {
            string status = "";
            try
            {
                string select_qr = $"select Title from Books\r\nwhere Title = '{Title_txt.Text}';";
                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {


                    throw new TitleDuplictaed("Another book has the same Title.");
                }
                reader.Close();




                string insert_qr = "insert into Books(Title,ID,Author,section,Edition,Quantity,Price) values('" + Title_txt.Text + "','" + ID_text.Text + "','" + author_txt.Text + "','" + section_txt.Text + "','" + edition_txt.Text + "','" + qnt_txt.Text + "'," + price_txt.Text + ")";
                cmd = new SqlCommand(insert_qr, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Added sucessufully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (TitleDuplictaed ex)
            {
                status = ex.Message;
                MessageBox.Show(status, "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (SqlException ex)
            {
                status = ex.Message;

                MessageBox.Show("the problems is " + status);


            }



            finally
            {
                if (status.Length > 1)
                {
                    conn.Close();
                    ID_text.Clear();
                }
                else
                {

                    conn.Close();
                    Title_txt.Clear();
                    ID_text.Clear();
                    author_txt.Clear();
                    section_txt.Clear();
                    edition_txt.Clear();
                    qnt_txt.Clear();
                    price_txt.Clear();


                }



            }
        }
    }
}
    
