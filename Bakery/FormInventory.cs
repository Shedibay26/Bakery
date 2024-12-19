using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Bakery
{
    public partial class FormInventory : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool isImageUploaded = false;

        public FormInventory()
        {
            InitializeComponent();
            GetUsers();
        }

        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=BakeryShop.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Product", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvStocks.DataSource = dt;
            // Close the database connection
            conn.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow users to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the file filter to only show image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jfif;*.jpeg;*.png;*.bmp";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox (pbImage)
                pbImage.Image = new Bitmap(openFileDialog.FileName);


                isImageUploaded = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbProductN.Text) ||    // First Name
                string.IsNullOrWhiteSpace(tbPrice.Text) ||    // Last Name
                string.IsNullOrWhiteSpace(tbRemQ.Text) ||     // Username
                string.IsNullOrWhiteSpace(tbPStocks.Text) ||     // Password
                string.IsNullOrWhiteSpace(tbTotal.Text) ||    // Repeat Password
                string.IsNullOrWhiteSpace(tbRM.Text) ||
              pbImage.Image == null)                  // Check if an image is selected
            {
                MessageBox.Show("Please fill in all fields."); // Display a message if any field is empty
                return; // Exit the method if any field is missing
            }
            // Check if the passwords match
      
            // SQL query to insert a new user into the 'useracc' table
            string query = "INSERT INTO Product (ProductName, ProductPrice, RemainingQuantity, ProductStocks, Total, RawMaterials , [Image]) VALUES " +
                "(@pn,@p,@rq,@ps,@t,@rm,i)";
            // Create the command to execute the query
            cmd = new OleDbCommand(query, conn);

            // Add values from textboxes and other controls to the command parameters
            cmd.Parameters.AddWithValue("@pn", tbProductN.Text); // First Name
            cmd.Parameters.AddWithValue("@p", tbPrice.Text); // Last Name
            cmd.Parameters.AddWithValue("@rq", tbRemQ.Text); // Birthdate (from DateTimePicker)
            cmd.Parameters.AddWithValue("@ps", tbPStocks.Text);   // Username
            cmd.Parameters.AddWithValue("@t", tbTotal.Text);
            cmd.Parameters.AddWithValue("@rm", tbRM.Text);// Password

            // Handle the image parameter (convert the image in PictureBox to byte array)
            using (MemoryStream ms = new MemoryStream())
            {
                pbImage.Image.Save(ms, pbImage.Image.RawFormat); // Save the image in its raw format to the memory stream
                cmd.Parameters.AddWithValue("@i", ms.ToArray()); // Add the image as a byte array to the SQL command
            }
            isImageUploaded = false;
            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the insert query
            MessageBox.Show("User Inserted Successfully"); // Show success message
            conn.Close(); // Close the connection to the database

            // Refresh DataGridView to show the newly inserted user
            GetUsers();




        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvStocks.CurrentRow.Cells[0].Value.ToString();
            tbProductN.Text = dgvStocks.CurrentRow.Cells[1].Value.ToString();
            tbPrice.Text = dgvStocks.CurrentRow.Cells[2].Value.ToString();
            tbPStocks.Text = dgvStocks.CurrentRow.Cells[3].Value.ToString();
            tbRemQ.Text = dgvStocks.CurrentRow.Cells[4].Value.ToString();
            tbTotal.Text = dgvStocks.CurrentRow.Cells[4].Value.ToString();
            tbRM.Text = dgvStocks.CurrentRow.Cells[5].Value.ToString();

            if (dgvStocks.CurrentRow.Cells["Image"].Value != DBNull.Value)
            {
                // Convert the byte array from the 'Photo' column to an image and display it
                byte[] imgData = (byte[])dgvStocks.CurrentRow.Cells["Image"].Value;
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    pbImage.Image = Image.FromStream(ms); // Load the image from the memory stream
                }
            }
            else
            {
                // If the 'Photo' column is null, clear the PictureBox
                pbImage.Image = null;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbProductN.Text) ||    // First Name
                string.IsNullOrWhiteSpace(tbPrice.Text) ||    // Last Name
                string.IsNullOrWhiteSpace(tbRemQ.Text) ||     // Username
                string.IsNullOrWhiteSpace(tbPStocks.Text) ||
                string.IsNullOrWhiteSpace(tbTotal.Text) ||
                string.IsNullOrWhiteSpace(tbRM.Text)) // Password
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Determine SQL query based on whether an image is uploaded
            string query = isImageUploaded
                ? "UPDATE Product SET ProductName=@pn, ProductPrice=@p, RemainingQuantity=@rq, ProductStocks=@ps, Total=@t, RawMaterials=@rm ,Photo=@i WHERE ID=@id"
                : "UPDATE Product SET ProductName=@pn, ProductPrice=@p, RemainingQuantity=@rq, ProductStocks=@ps, Total=@t, RawMaterials@rm WHERE ID=@id";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@pn", tbProductN.Text);
                cmd.Parameters.AddWithValue("@p", tbPrice.Text);
                cmd.Parameters.AddWithValue("@rq", tbRemQ);
                cmd.Parameters.AddWithValue("@ps", tbPStocks.Text);
                cmd.Parameters.AddWithValue("@t", tbTotal.Text);
                cmd.Parameters.AddWithValue("@rm", tbRM.Text);

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

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM Product WHERE ID LIKE @i";

            adapter = new OleDbDataAdapter(searchQuery, conn);

            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();

            dgvStocks.DataSource = dt;
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakeryShopDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.bakeryShopDataSet2.Product);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

 
