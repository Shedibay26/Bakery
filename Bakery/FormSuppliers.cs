using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bakery
{
    public partial class FormSuppliers : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt;

        public FormSuppliers()
        {
            InitializeComponent();
        }
        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=BakeryShop.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Supplier", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvSupplier.DataSource = dt;
            // Close the database connection
            conn.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbSupplierN.Text) ||    
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tbCity.Text) ||    
                string.IsNullOrWhiteSpace(tbM.Text) ||    
                string.IsNullOrWhiteSpace(tbP.Text))    
            {
                MessageBox.Show("Please fill in all fields."); // Display a message if any field is empty
                return; // Exit the method if any field is missing
            }
            string query = "INSERT INTO Supplier (SupplierName, Address, City, Municipality, [Phone]) VALUES " +
                "(@sn,@a,@c,@m,@p)";
            // Create the command to execute the query
            cmd = new OleDbCommand(query, conn);

            // Add values from textboxes and other controls to the command parameters
            cmd.Parameters.AddWithValue("@sn", tbSupplierN.Text); 
            cmd.Parameters.AddWithValue("@a", tbAddress.Text); 
            cmd.Parameters.AddWithValue("@c", tbCity.Text);
            cmd.Parameters.AddWithValue("@m", tbM.Text);
            cmd.Parameters.AddWithValue("@p", tbP.Text);

            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the insert query
            MessageBox.Show("User Inserted Successfully"); // Show success message
            conn.Close(); // Close the connection to the database

            // Refresh DataGridView to show the newly inserted user
            GetUsers();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbSupplierN.Text) ||    
                string.IsNullOrWhiteSpace(tbAddress.Text) ||   
                string.IsNullOrWhiteSpace(tbCity.Text) ||    
                string.IsNullOrWhiteSpace(tbM.Text) ||
                string.IsNullOrWhiteSpace(tbP.Text)) 
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Determine SQL query based on whether an image is uploaded
            string query = isImageUploaded
                ? "UPDATE useracc SET Firstname=@fn, Lastname=@ln, Birthdate=@bd, Username=@u, [Password]=@p, Photo=@i WHERE ID=@id"
                : "UPDATE useracc SET Firstname=@fn, Lastname=@ln, Birthdate=@bd, Username=@u, [Password]=@p WHERE ID=@id";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fn", tbSupplierN.Text);
                cmd.Parameters.AddWithValue("@a", tbAddress.Text);
                cmd.Parameters.AddWithValue("@C", tbCity.Text);
                cmd.Parameters.AddWithValue("@m", tbM.Text);
                cmd.Parameters.AddWithValue("@p", tbP.Text);

                // Add image parameter if uploaded
                if (isImageUploaded && pbImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@i", ms.ToArray());
                    }
                }

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbID.Text));

                // Execute the update command
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rowsAffected > 0 ? "User Updated Successfully" : "No user found with the provided ID.");
            }

            // Reset flag and refresh DataGridView
            isImageUploaded = false;
            GetUsers();
        }
    }
}
