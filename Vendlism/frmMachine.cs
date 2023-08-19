using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Vendlism
{
    public partial class frmMachine : Form
    {

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public frmMachine()
        {
            InitializeComponent();
        }

        private void frmMachine_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn = new SqlConnection(connectionString);


            for (int i = 1; i <= 9; i++)
            {
                string labelName = "lblProduct" + i.ToString();
                Label label = Controls.Find(labelName, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = $"SELECT * FROM tblProducts WHERE Product_ID = " + i;
                    command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader();

                    string name = "";


                    while (reader.Read())
                    {
                        name = (reader.GetValue(1)).ToString();
                    }
                    conn.Close();

                    label.Text = name;
                }
                else
                {
                    // Handle the case where the label with the specified name is not found
                    // You can choose to throw an exception, display an error message, or take any other appropriate action.
                    // For this example, we'll simply print a message to the console.

                    MessageBox.Show("Label " + labelName + " not found.");
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                string pictureBoxName = "imgProduct" + i.ToString();
                PictureBox pictureBox = Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;

                if (pictureBox != null)
                {
                    // Fetch the image data from the database for the corresponding Product_ID
                    byte[] imageData = GetImageDataFromDatabase(i);

                    // Convert the byte array to an Image object
                    Image image = ByteArrayToImage(imageData);

                    // Display the image in the PictureBox
                    pictureBox.BackgroundImage = image;

                }
                else
                {
                    // Handle the case where the PictureBox with the specified name is not found
                    // You can choose to throw an exception, display an error message, or take any other appropriate action.
                    // For this example, we'll simply print a message to the console.
                    Console.WriteLine("PictureBox " + pictureBoxName + " not found.");
                }
            }

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql2 = $"SELECT Product_Name FROM tblProducts";
            adapter = new SqlDataAdapter(sql2, conn);
            DataSet ds2 = new DataSet();
            adapter.Fill(ds2, "tblProducts");
            cmbProduct.DisplayMember = "Product_Name"; //THE COLUMN NAME 
            cmbProduct.ValueMember = "Product_Name";
            cmbProduct.DataSource = ds2.Tables["tblProducts"];
            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the text entered by the user in textBox1
            string productID = textBox1.Text;

            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected image file path
                string imagePath = openFileDialog.FileName;

                // Insert the image into the "image" field in tblProducts
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    // Check if the product exists in the database
                    string checkProductQuery = $"SELECT COUNT(*) FROM tblProducts WHERE Product_ID = '{productID}'";
                    SqlCommand checkProductCommand = new SqlCommand(checkProductQuery, conn);
                    int productCount = Convert.ToInt32(checkProductCommand.ExecuteScalar());

                    if (productCount > 0)
                    {
                        // Update the "image" field for the specified product
                        string updateQuery = $"UPDATE tblProducts SET Product_Image = @image WHERE Product_ID = '{productID}'";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                        updateCommand.Parameters.AddWithValue("@image", File.ReadAllBytes(imagePath));
                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Image inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Product not found in the database.");
                    }
                    conn.Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }

        private byte[] GetImageDataFromDatabase(int productId)
        {
            byte[] imageData = null;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            // Create a SqlCommand to fetch the image data from the database
            using (SqlCommand command = new SqlCommand("SELECT Product_Image FROM tblProducts WHERE Product_ID = @ProductId", conn))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                // Execute the command and read the image data
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Check if the column exists and it's not null
                        if (!reader.IsDBNull(0))
                        {
                            // Retrieve the image data as a byte array
                            imageData = (byte[])reader[0];
                        }
                    }
                }
            }
            conn.Close();

            return imageData;

           
        }

        // Method to convert a byte array to an Image object
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }

        private void lblProduct9_Click(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = $"SELECT * FROM tblProducts";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            
          
            while (reader.Read())
            {
                if ((reader.GetValue(1)).ToString() == cmbProduct.Text)
                {
                    lblPrice.Text = cmbProduct.Text + ": R" + (reader.GetValue(3)).ToString();
                }
                
               
            }
            conn.Close();

        }
    }
}
