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
    public partial class SearchForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        public SearchForm()
        {
            InitializeComponent();
        }


        private void search_btn_Click(object sender, EventArgs e)
        {
            if (title_txt.Text != "")
            {




                try
                {


                    data.Clear();
                    string select_qr = $"select * from Books\r\nwhere Title like '%{title_txt.Text}%' ;";
                    adapter = new SqlDataAdapter(select_qr, conn);
                    adapter.Fill(data);
                    dataGridView_result.DataSource = data;

                }


                catch (Exception ex)
                {
                    MessageBox.Show("the problem is" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    title_txt.Clear();


                }

            }
            else
            {
                try
                {


                    data.Clear();
                    string select_qr = $"select * from Books\r\nwhere ID = {Convert.ToInt32(book_idtxt.Text)} ;";
                    adapter = new SqlDataAdapter(select_qr, conn);
                    adapter.Fill(data);
                    dataGridView_result.DataSource = data;
                    if (data.Rows.Count == 0)
                    {

                        throw new Exception("the ID is not exist");
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    book_idtxt.Clear();


                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
