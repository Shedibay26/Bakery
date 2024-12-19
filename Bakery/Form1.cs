using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Bakery
{
    public partial class Form1 : Form
    {
       OleDbConnection conn;
       OleDbCommand cmd;

        private int loginAttempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BakeryShop.accdb;");
            string query = "SELECT [Type] FROM Login WHERE Username = @username AND [Password] = @password";


            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);

            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string userType = result.ToString();

                    this.Hide();

                    if (userType == "Admin")
                    {
                        FormAdmin form2 = new FormAdmin();  // Admin Form
                        form2.Show();
                    }
                    else if (userType == "Staff")
                    {
                        FormAdmin form3 = new FormAdmin();  // Student Form
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show(); // Show the login form again if type is unrecognized
                    }
                }
                else
                {
                    // Increment the login attempts and show an error message
                    loginAttempts++;
                    MessageBox.Show("Invalid username or password.");

                    if (loginAttempts >= 3)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }
    }
}
