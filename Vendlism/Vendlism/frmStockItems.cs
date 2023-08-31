using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Vendlism
{
    public partial class frmStockItems : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        int count = 0;

        Boolean updateIMG = false;
        byte[] updateImageData;

        public frmStockItems()
        {
            InitializeComponent();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }

     

        private void frmStockItems_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            loadDB("SELECT * FROM tblProduct ORDER BY Machine_Slot ASC");
            loadCMB("cmbDelete");
            loadCMB("cmbUpdate");

           // btnSearch_Click(sender, e);

            //Set location of all the groupboxes
            var point = new Point(264, 264);
            grpAdd.Location = point;
            grpSearch.Location = point;
            grpDelete.Location = point;
            grpUpdate.Location = point;

            // MessageBox.Show(countProducts().ToString());
          //  MessageBox.Show(getEmpty());

            if (countProducts() == 9)
            {
                lblAddWarning.Text = "All Machine Slots are occupied.\nRemove a product first in order to add\nnew product.";
                btnAdd.Enabled = false;
            }
            else
            {
                int avail = getCountEmpty();

                lblAddWarning.Text = "There are "+ avail.ToString()+" Machine Slots are available\nto add a new product.";
                btnAdd.Enabled = true;
            }

        }

        public void loadDB(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblProduct");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblProduct";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadCMB(string cmbName)
        {
            try
            {
                ComboBox cmb = Controls.Find(cmbName, true).FirstOrDefault() as ComboBox;
                if (cmb != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = $"SELECT Product_Name FROM tblProduct";
                    adapter = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblProduct");
                    cmb.DisplayMember = "Product_Name";
                    cmb.ValueMember = "Product_Name";
                    cmb.DataSource = ds.Tables["tblProduct"];
                    conn.Close();
                    cmb.SelectedIndex = -1;
                }
                else
                {
                    // Handle the case where the component with the specified name is not found
                    MessageBox.Show("combobox: " + cmbName + " not found.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void enterHover(String btnName)
        {
            Button btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#99D9EA");
                btn.ForeColor = Color.Black;
            }
            else
            {
                // Handle the case where the button with the specified name is not found
                MessageBox.Show("button: " + btnName + " not found.");
            }
        }

        public void leaveHover(String btnName)
        {
            Button btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (btn != null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#DCDCDC");
                btn.ForeColor = Color.Black;
            }
            else
            {
                // Handle the case where the button with the specified name is not found
                MessageBox.Show("button: " + btnName + " not found.");
            }
        }

        public Boolean checkSymbol(string name)
        {

            string symbols2 = "$'";
            Boolean symbolCheck2 = false;

            foreach (char symbol in symbols2)
            {
                if (name.Contains(symbol))
                {
                    symbolCheck2 = true;
                }
            }

            return symbolCheck2;
        }


        public int countProducts()
        {
            int count = 0;

            conn.Open();
            string sql = $"SELECT * FROM tblProduct";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                count++;
            }
            conn.Close();



            return count;
        }

        public int getEmpty()
        {
         //   int empty = 0;

            conn.Open();
            string sql = $"SELECT * FROM tblProduct";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            string sOutput="";
            
            while (reader.Read())
            {
                sOutput = sOutput+ (reader.GetValue(5)).ToString();
            }
            conn.Close();

//            MessageBox.Show("sOutput: "+sOutput);

            string sMissing = "";

            for (int i = 1; i<10; i++)
            {
                if (!sOutput.Contains(i.ToString()))
                {
                    sMissing = sMissing + i.ToString();
                }
            }

            if (sMissing.Length != 0)
            {
                int missing = int.Parse(sMissing.Substring(0, 1));

                //   MessageBox.Show("sMissing FIRST INDEX: " + missing.ToString());

                return missing;
            }
            else
            {
                return 0;
            }

            
        }

        public int getCountEmpty()
        {
            //   int empty = 0;

            conn.Open();
            string sql = $"SELECT * FROM tblProduct";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            string sOutput = "";

            while (reader.Read())
            {
                sOutput = sOutput + (reader.GetValue(5)).ToString();
            }
            conn.Close();

            //            MessageBox.Show("sOutput: "+sOutput);

            string sMissing = "";

            for (int i = 1; i < 10; i++)
            {
                if (!sOutput.Contains(i.ToString()))
                {
                    sMissing = sMissing + i.ToString();
                }
            }


            int missing = sMissing.Length;

           

            return missing;


        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnSearch");
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnSearch");
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnAdd");
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnAdd");
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnUpdate");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnUpdate");
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnDelete");
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnDelete");
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = false;
            grpDelete.Visible = false;
            grpSearch.Visible = true;
            grpUpdate.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
            grpUpdate.Visible = false;

            lblSlot.Text = "Machine Slot that Product will be added is in Machine Slot: "+ getEmpty().ToString();

            spnPrice.Value = 0;
            spnQuantity.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //  txtUpdateEmail.Text = "";
            //   txtUpdatePhone.Text = "";

            try
            {
                spnUpdateQuantity.Value = 0;
                spnUpdatePrice.Value = 0;

                lblPK.Text = "";
                lblUpdateSlot.Text = "";
                cmbUpdate.SelectedIndex = -1;

                grpUpdate.Visible = true;
                grpAdd.Visible = false;
                grpSearch.Visible = false;
                grpDelete.Visible = false;
                imgUpdate.BackgroundImage = null;
            }
            catch (OutOfMemoryException exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblDeletePK.Text = "";
            cmbDelete.SelectedIndex = -1;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = true;
            grpUpdate.Visible = false;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                //if user selected a username from combobox to delete
                if (cmbDelete.SelectedIndex != -1)
                {
                    errorProviderPassword.SetError(cmbDelete, "");

                    //Ask User if they are sure they would like to delete the selected user
                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this product: " + cmbDelete.Text + "?", "Delete User Confirmation", MessageBoxButtons.YesNo);

                    //if they are sure and click YES
                    if (dialogResult == DialogResult.Yes)
                    {
                        //CODE TO DELETE USER
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string sql = $"DELETE FROM tblProduct WHERE Product_ID = " + lblDeletePK.Text;
                        command = new SqlCommand(sql, conn);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = command;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        conn.Close();

                        //REFRESH COMBOBOX
                        loadCMB("cmbDelete");
                        loadCMB("cmbUpdate");

                        //REFRESH DATAGRIDVIEW
                        loadDB("SELECT * FROM tblProduct ORDER BY Machine_Slot ASC");

                        //Success message
                        MessageBox.Show("Product Deleted Successfully");

                        //clear textbox and combobox
                        lblDeletePK.Text = "";
                        cmbDelete.SelectedIndex = -1;

                        //Update number of slots available
                        int avail = getCountEmpty();

                        lblAddWarning.Text = "There are " + avail.ToString() + " Machine Slots are available\nto add a new product.";
                        btnAdd.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Operation Cancelled");
                    }
                }
                else
                {
                    errorProviderPassword.SetError(cmbDelete, "Please select a user to delete");
                    cmbDelete.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = $"SELECT * FROM tblProduct";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetValue(1).ToString() == cmbDelete.Text)
                    {
                        lblDeletePK.Text = reader.GetValue(0).ToString();
                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%'");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%'  AND Quantity_Available < 5 ORDER BY Product_Name ASC");
            }
            else
            {
                loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%' ORDER BY Product_Name ASC");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%' AND Quantity_Available < 5  ORDER BY Product_Name DESC");
            }
            else
            {
                loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%' ORDER BY Product_Name DESC");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
        }


        public Boolean productFound(string sName)
        {

            Boolean found = false;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"SELECT * FROM tblProduct";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {

                if (sName == (reader.GetValue(1)).ToString())
                {
                    found= true;
                }
            }
            conn.Close();

            return found;
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int quantity = Convert.ToInt32(spnQuantity.Value); 
            int price = Convert.ToInt32(spnPrice.Value);

            
            string productID = getEmpty().ToString();

            if (productFound(name) == false)
            {
                errorProviderPassword.SetError(txtName, "");

                // Open a file dialog to select an image
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the selected image file path
                    string imagePath = openFileDialog.FileName;

                    // Insert the image into the "image" field in tblProduct

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string updateQuery = $"INSERT INTO tblProduct (Product_Name,Quantity_Available,Selling_Price,Product_Image,Machine_Slot) VALUES (@name,@quantity,@price,@image,@productID)";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@quantity", quantity);
                    updateCommand.Parameters.AddWithValue("@price", price);
                    updateCommand.Parameters.AddWithValue("@image", File.ReadAllBytes(imagePath));
                    updateCommand.Parameters.AddWithValue("@productID", productID);
                    updateCommand.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New Product added successfully");
                    loadDB("SELECT * FROM tblProduct ORDER BY Machine_Slot ASC");
                    loadCMB("cmbDelete");
                    loadCMB("cmbUpdate");

                    if (countProducts() == 9)
                    {
                        grpAdd.Visible = false;
                        grpDelete.Visible = false;
                        grpSearch.Visible = true;
                        grpUpdate.Visible = false;
                        lblAddWarning.Text = "All Machine Slots are occupied.\nRemove a product first in order to add\nnew product.";
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        int avail = getCountEmpty();
                        lblAddWarning.Text = "There are " + avail.ToString() + " Machine Slots are available\nto add a new product.";
                        btnAdd.Enabled = true;
                    }
                    lblSlot.Text = "Machine Slot that Product will be added is in Machine Slot: " + getEmpty().ToString();
                }
            }
            else
            {
                errorProviderPassword.SetError(txtName, "A product with the same name already exists in the database");
                txtName.Focus();
            }

          

        }

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            if (count > 1)
            {
                
                try
                {
                    //  oldName = cmbUpdate.Text;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = $"SELECT * FROM tblProduct";
                    command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader.GetValue(1).ToString() == cmbUpdate.Text)
                        {
                            lblPK.Text = reader.GetValue(0).ToString();
                            //  txtUpdateName.Text = reader.GetValue(2).ToString();
                            // txtUpdatePhone.Text = reader.GetValue(3).ToString();
                            // txtUpdateAddress.Text = reader.GetValue(4).ToString();

                            spnUpdateQuantity.Value = Convert.ToInt32(reader.GetValue(2));
                            spnUpdatePrice.Value = Convert.ToInt32(reader.GetValue(3));
                            lblUpdateSlot.Text = reader.GetValue(5).ToString();

                            byte[] imageData = (byte[])reader[4];
                            //byte[] imageData = GetImageDataFromDatabase(Convert.ToInt32(reader.GetValue(5)));

                            // Convert the byte array to an Image object
                            Image image = ByteArrayToImage(imageData);

                            // Display the image in the PictureBox
                            imgUpdate.BackgroundImage = image;

                        }
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                catch (OutOfMemoryException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            updateIMG = true;
            // Retrieve the text entered by the user in textBox1
            string productID = lblUpdateSlot.Text;

            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Retrieve the selected image file path
                string imagePath = openFileDialog.FileName;

                 updateImageData = File.ReadAllBytes(imagePath);

                // Convert the byte array to an Image object
                Image image = ByteArrayToImage(updateImageData);

                // Display the image in the PictureBox
                imgUpdate.BackgroundImage = image;                  
                  
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            

            if (updateIMG==true)
            {

                string name = cmbUpdate.Text;
                int quantity = Convert.ToInt32(spnUpdateQuantity.Value);
                int price = Convert.ToInt32(spnUpdatePrice.Value);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string updateQuery = $"UPDATE tblProduct SET Product_Name = @name, Quantity_Available = @quantity, Selling_Price = @price, Product_Image = @image WHERE Machine_Slot = '{lblUpdateSlot.Text}'";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                    updateCommand.Parameters.AddWithValue("@name", name);
                    updateCommand.Parameters.AddWithValue("@quantity", quantity);
                    updateCommand.Parameters.AddWithValue("@price", price);
                    updateCommand.Parameters.AddWithValue("@image", updateImageData);
                    updateCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New Product updated successfully");
                    loadDB("SELECT * FROM tblProduct ORDER BY Machine_Slot ASC");
                    loadCMB("cmbDelete");
                    loadCMB("cmbUpdate");

                    

            }
            else
            {
                string name = cmbUpdate.Text;
                int quantity = Convert.ToInt32(spnUpdateQuantity.Value);
                int price = Convert.ToInt32(spnUpdatePrice.Value);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string updateQuery = $"UPDATE tblProduct SET Product_Name = @name, Quantity_Available = @quantity, Selling_Price = @price WHERE Machine_Slot = '{lblUpdateSlot.Text}'";
                SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                updateCommand.Parameters.AddWithValue("@name", name);
                updateCommand.Parameters.AddWithValue("@quantity", quantity);
                updateCommand.Parameters.AddWithValue("@price", price);
                
                updateCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Product updated successfully");
                loadDB("SELECT * FROM tblProduct ORDER BY Machine_Slot ASC");
                loadCMB("cmbDelete");
                loadCMB("cmbUpdate");
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            spnPrice.Value = 0;
            spnQuantity.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%' AND Quantity_Available < 5 ");
            }
            else
            {
                loadDB("SELECT * FROM tblProduct WHERE Product_Name LIKE  '%" + txtSearch.Text + "%'");
            }
        }
    }
}
