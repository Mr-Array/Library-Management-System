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
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-M8GG6J5\SQLEXPRESS;Initial Catalog=library_System;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            CmbRole.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select_qr = "";
            try
            {

                string user = Usernametxt.Text;
                string password = Passwordtxt.Text;
                string type = "";



                if (CmbRole.SelectedItem == null)
                {
                    throw new Exception("Please, choose the Type");
                }
                else
                {
                    type = CmbRole.SelectedItem.ToString();
                }

                select_qr = $"select Username , password , type , Email  from Users\r\n where Username = '{user}' and password ='{password}' and type = '{type}';";

                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        if (user == reader.GetString(0) && password == reader.GetString(1))
                        {

                            if ("Librarian" == reader.GetString(2))
                            {

                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                librarian_interface frm1 = new librarian_interface();
                                frm1.Show();
                                this.Hide();
                                break;
                            }
                            else if ("Student" == reader.GetString(2))
                            {

                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 Student frm2 = new Student();
                                frm2.email_login = reader.GetString(3);
                                 frm2.Show();
                                this.Hide();
                                break;
                            }
                            else if ("System User" == reader.GetString(2))
                            {
                                MessageBox.Show($"login succefully\nwelcome {user}", "login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                  adminform frm3 = new adminform();
                                  frm3.Show();
                                this.Hide();
                                break;
                            }


                        }

                    }

                }
                else
                {
                    MessageBox.Show("invalid Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                conn.Close();
                Usernametxt.Clear();
                Passwordtxt.Clear();
                CmbRole.SelectedIndex = -1;
            }

        }
    }
}
