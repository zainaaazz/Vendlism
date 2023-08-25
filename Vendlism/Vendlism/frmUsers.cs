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

namespace Vendlism
{
    public partial class frmUsers : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public frmUsers()
        {
            InitializeComponent();
        }

        public void loadDB(string sql)
        {
            conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            
            command = new SqlCommand(sql, conn);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblUser");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "tblUser";
            conn.Close();

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //   btnAdd.BackColor = ColorTranslator.FromHtml("#99D9EA");

            loadDB("SELECT * FROM tblUser");

            var point = new Point(277, 326);
            grpAdd.Location = point;
            grpSearch.Location = point;
            grpDelete.Location = point;
            grpUpdate.Location = point;

            

            loadCMB("cmbDelete");
            loadCMB("cmbUpdate");

           


        }

        public void loadCMB(string cmbName)
        {
            ComboBox cmb = Controls.Find(cmbName, true).FirstOrDefault() as ComboBox;
            if (cmb != null)
            { 
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = $"SELECT Username FROM tblUser";
                adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblUser");
                cmb.DisplayMember = "Username";
                cmb.ValueMember = "Username";
                cmb.DataSource = ds.Tables["tblUser"];
                conn.Close();
                cmb.SelectedIndex = -1;
                
            }
            else
            {
                // Handle the case where the label with the specified name is not found
                // You can choose to throw an exception, display an error message, or take any other appropriate action.
                // For this example, we'll simply print a message to the console.

                MessageBox.Show("combobox: " + cmbName + " not found.");
            }
        }

        public static string Encrypt(string input, int key)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + key);
            }
            return new string(chars);
        }

        public static string Decrypt(string input, int key)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - key);
            }
            return new string(chars);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
            grpUpdate.Visible = false;

        }

        public void enterHover(String btnName)
        {
            Button btn = Controls.Find(btnName, true).FirstOrDefault() as Button;
            if (btn !=null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#99D9EA"); 
                btn.ForeColor = Color.Black;


            }
            else
            {
                // Handle the case where the label with the specified name is not found
                // You can choose to throw an exception, display an error message, or take any other appropriate action.
                // For this example, we'll simply print a message to the console.

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
                // Handle the case where the label with the specified name is not found
                // You can choose to throw an exception, display an error message, or take any other appropriate action.
                // For this example, we'll simply print a message to the console.

                MessageBox.Show("button: " + btnName + " not found.");
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnAdd");
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnAdd");
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnDelete");
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnDelete");
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnUpdate");
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnUpdate");
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = true;
            grpUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = true;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
            
        }

        private void imgOff_Click(object sender, EventArgs e)
        {
            imgOff.Visible = false;
            imgOn.Visible = true;
            txtPassword.PasswordChar = '\0';

        }

        private void imgOn_Click(object sender, EventArgs e)
        {
            imgOff.Visible = true;
            imgOn.Visible = false;
            txtPassword.PasswordChar = '*';
        }

        private void imgOn2_Click(object sender, EventArgs e)
        {
            imgOff2.Visible = true;
            imgOn2.Visible = false;
            txtConfirm.PasswordChar = '*';
        }

        private void imgOff2_Click(object sender, EventArgs e)
        {
            imgOff2.Visible = false;
            imgOn2.Visible = true;
            txtConfirm.PasswordChar = '\0';
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;
            string sConfirm = txtConfirm.Text;

            Boolean found = false;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"SELECT * FROM tblUser";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
               if (sUsername == (reader.GetValue(1)).ToString())
               {
                    found = true;
               }
            }
            conn.Close();

            string symbols = "!@#$%^&*";
            Boolean symbolCheck = false;

            foreach (char symbol in symbols)
            {
                if (sPassword.Contains(symbol))
                {
                    symbolCheck = true;
                }
            }

            //if username is correct length
            if (sUsername.Length >= 7)
            {
                //if username doesnt exists in the database already
                if (found == false)
                {
                    //if password is correct length
                    if (sPassword.Length >= 7)
                    {
                        //if password contains at least one symbol (special character)
                        if (symbolCheck == true)
                        {
                            //if both passwords match each other
                            if (sPassword == sConfirm)
                            {
                                //if at least 1 radiobutton indicating user rights is selected
                                if (rbAdmin.Checked == true || rbNotAdmin.Checked == true)
                                {

                                    int admin=0;

                                    if (rbAdmin.Checked)
                                    {
                                        admin = 1;
                                    }
                                    else if (rbNotAdmin.Checked)
                                    {
                                        admin = 0;
                                    }

                                    //ENCRYPT PASSWORD
                                    string encPassword = Encrypt(sPassword, 3);

                                    //ADD TO DATABASE



                                    if (conn.State == ConnectionState.Closed)
                                    {
                                        conn.Open();
                                    }
                                    string sql2 = $"INSERT INTO tblUser(Username, Password, isAdmin) VALUES ('{sUsername}','{encPassword}', {admin})";
                                    command = new SqlCommand(sql2, conn);
                                    adapter = new SqlDataAdapter();
                                    adapter.InsertCommand = command;
                                    adapter.InsertCommand.ExecuteNonQuery();
                                    conn.Close();

                                    MessageBox.Show("New User added successfully!");

                                    //REFRESH DATABASE
                                    loadDB("SELECT * FROM tblUser");


                                }
                                else
                                {
                                    errorProviderPassword.SetError(rbAdmin, "Select at least one radiobutton!");
                                    errorProviderPassword.SetError(rbNotAdmin, "Select at least one radiobutton!");
                                    txtConfirm.Focus();
                                }
                            }
                            else
                            {
                                errorProviderPassword.SetError(txtConfirm, "Passwords do not match!");
                                errorProviderPassword.SetError(txtPassword, "Passwords do not match!");
                                txtConfirm.Focus();
                            }
                        }
                        else
                        {
                            errorProviderPassword.SetError(txtPassword, "Passwords needs to contain a symbol or special character (!@#$%^&*)");
                            txtPassword.Focus();
                        }
                        
                    }
                    else
                    {
                        errorProviderPassword.SetError(txtPassword, "Passwords needs to be 7 or more characters long!");
                        txtPassword.Focus();
                    }
                }
                else
                {
                    errorProviderPassword.SetError(txtUsername, "This Username already exists in the database!");
                    txtUsername.Focus();
                }
            }
            else
            {
                errorProviderPassword.SetError(txtUsername, "The username needs to be 7 or more characters!");
                txtUsername.Focus();
            }


            
            
           
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnSearch");
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnSearch");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = false;
            grpDelete.Visible = false;
            grpSearch.Visible = true;
            grpUpdate.Visible = false;
            //  grpSearch.Location.X 277,326;
            var point = new Point(277,326);
            grpSearch.Location = point;

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (rbFilterNo.Checked == true || rbFilterYes.Checked == true)
            {
                int admin = 0;
                if (rbFilterNo.Checked == false)
                {
                    admin = 0;
                }
                else if (rbFilterYes.Checked == true)
                {
                    admin = 1;
                }

                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = " + admin);
            }
            else
            {
              
            }

           
           

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%"+txtSearch.Text+"%'");
        }

        private void grpAdd_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpUpdate.Visible = true;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
        }

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = $"SELECT * FROM tblUser";
            command = new SqlCommand(sql, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == cmbUpdate.Text)
                {
                 lblPK.Text = reader.GetValue(0).ToString();
                }
                
               
            }
            conn.Close();

        }
    }
}
