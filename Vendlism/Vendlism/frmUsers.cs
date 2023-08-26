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
                adapter.Fill(ds, "tblUser");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblUser";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            //load Datagridview and comboboxes
            loadDB("SELECT * FROM tblUser");
            loadCMB("cmbDelete");
            loadCMB("cmbUpdate");

            //Set location of all the groupboxes
            var point = new Point(277, 326);
            grpAdd.Location = point;
            grpSearch.Location = point;
            grpDelete.Location = point;
            grpUpdate.Location = point;
           
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
                    // Handle the case where the component with the specified name is not found
                    MessageBox.Show("combobox: " + cmbName + " not found.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
            lblDeletePK.Text = "";
            cmbDelete.SelectedIndex = -1;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = true;
            grpUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUpdatePassword.Text = "";
            lblPK.Text = "";
            cmbUpdate.SelectedIndex = -1;

            rbUpdateAdmin.Checked = false;
            rbUpdateAdmin2.Checked = false;

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
            try
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

                //Because the " ' " symbol causes the sql statement to fuck out
                string symbols2 = "'";
                Boolean symbolCheck2 = false;

                foreach (char symbol in symbols2)
                {
                    if (sUsername.Contains(symbol))
                    {
                        symbolCheck2 = true;
                    }
                }

                //if username is correct length
                if (sUsername.Length >= 7)
                {
                    errorProviderPassword.SetError(txtUsername, "");

                    //if Username does not contain ' symbol
                    if (symbolCheck2 == false)
                    {
                        errorProviderPassword.SetError(txtUsername, "");

                        //if username doesnt exist in the database already
                        if (found == false)
                        {
                            errorProviderPassword.SetError(txtUsername, "");

                            //if password is correct length
                            if (sPassword.Length >= 7)
                            {
                                errorProviderPassword.SetError(txtPassword, "");

                                //if password contains at least one symbol (special character)
                                if (symbolCheck == true)
                                {
                                    errorProviderPassword.SetError(txtPassword, "");

                                    //if both passwords match each other
                                    if (sPassword == sConfirm)
                                    {
                                        errorProviderPassword.SetError(txtConfirm, "");
                                        errorProviderPassword.SetError(txtPassword, "");

                                        //if at least 1 radiobutton indicating user rights is selected
                                        if (rbAdmin.Checked == true || rbNotAdmin.Checked == true)
                                        {
                                            errorProviderPassword.SetError(rbAdmin, "");
                                            errorProviderPassword.SetError(rbNotAdmin, "");

                                            int admin = 0;

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

                                            //REFRESH COMBOBOX
                                            loadCMB("cmbUpdate");
                                            loadCMB("cmbDelete");

                                            //CLEAR FIELDS + COMPONENTS
                                            txtUsername.Text = "";
                                            txtPassword.Text = "";
                                            txtConfirm.Text = "";
                                            rbAdmin.Checked = false;
                                            rbNotAdmin.Checked = false;
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
                        errorProviderPassword.SetError(txtUsername, "Username cannot contain the following symbol '");
                        txtUsername.Focus();
                    }
                }
                else
                {
                    errorProviderPassword.SetError(txtUsername, "The username needs to be 7 or more characters!");
                    txtUsername.Focus();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                grpAdd.Visible = false;
                grpDelete.Visible = false;
                grpSearch.Visible = true;
                grpUpdate.Visible = false;
                //  grpSearch.Location.X 277,326;
                var point = new Point(277, 326);
                grpSearch.Location = point;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%"+txtSearch.Text+"%'");
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
            try
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
                        txtUpdatePassword.Text = Decrypt(reader.GetValue(2).ToString(), 3);

                        if (reader.GetValue(3).ToString() == "True")
                        {
                            rbUpdateAdmin.Checked = true;
                            rbUpdateAdmin2.Checked = false;
                        }
                        else
                        {
                            rbUpdateAdmin.Checked = false;
                            rbUpdateAdmin2.Checked = true;
                        }
                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button to reset
        private void button3_Click(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblUser");
            rbFilterNo.Checked = false;
            rbFilterYes.Checked = false;
            txtSearch.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        //DELETE USER BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if user selected a username from combobox to delete
                if (cmbDelete.SelectedIndex != -1)
                {
                    errorProviderPassword.SetError(cmbDelete, "");

                    //Ask User if they are sure they would like to delete the selected user
                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this user: " + cmbDelete.Text + "?", "Delete User Confirmation", MessageBoxButtons.YesNo);

                    //if they are sure and click YES
                    if (dialogResult == DialogResult.Yes)
                    {
                        //CODE TO DELETE USER
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string sql = $"DELETE FROM tblUser WHERE User_ID = " + lblDeletePK.Text;
                        command = new SqlCommand(sql, conn);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = command;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        conn.Close();

                        //REFRESH COMBOBOX
                        loadCMB("cmbDelete");
                        loadCMB("cmbUpdate");

                        //REFRESH DATAGRIDVIEW
                        loadDB("SELECT * FROM tblUser");

                        //Success message
                        MessageBox.Show("User Deleted Successfully");

                        //clear textbox and combobox
                        lblDeletePK.Text = "";
                        cmbDelete.SelectedIndex = -1;
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
                string sql = $"SELECT * FROM tblUser";
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

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUpdate.Text != "")
                {
                    errorProviderPassword.SetError(cmbUpdate, "");

                    int admin = 0;

                    if (rbUpdateAdmin.Checked)
                    {
                        admin = 1;
                    }
                    else if (rbUpdateAdmin2.Checked)
                    {
                        admin = 0;
                    }

                    //encrypt new/updated password
                    string encPassword = Encrypt(txtUpdatePassword.Text, 3);

                    //Code to update user
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = $"UPDATE tblUser SET Username = '" + cmbUpdate.Text + "', Password = '" + encPassword + "', isAdmin = " + admin + " WHERE User_ID = " + int.Parse(lblPK.Text); ;
                    command = new SqlCommand(sql, conn);
                    adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = command;
                    adapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();

                    //REFRESH COMBOBOX
                    loadCMB("cmbUpdate");
                    loadCMB("cmbDelete");

                    //REFRESH DATAGRIDVIEW
                    loadDB("SELECT * FROM tblUser");

                    //clear fields
                    lblPK.Text = "";
                    cmbUpdate.SelectedIndex = -1;
                    txtUpdatePassword.Text = "";
                    rbUpdateAdmin.Checked = false;
                    rbUpdateAdmin2.Checked = false;

                    //success message
                    MessageBox.Show("User Updated Successfully");

                }
                else
                {
                    errorProviderPassword.SetError(cmbUpdate, "Please select a user to update");
                    cmbUpdate.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbFilterYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFilterYes.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 1");
            }
            
        }

        private void rbFilterNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFilterNo.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 0");
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFilterNo.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 0 ORDER BY Username ASC");
            }
            else if (rbFilterYes.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 1 ORDER BY Username ASC");
            }
            else
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' ORDER BY Username ASC");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFilterNo.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 0 ORDER BY Username DESC");
            }
            else if (rbFilterYes.Checked)
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' AND isAdmin = 1 ORDER BY Username DESC");
            }
            else
            {
                loadDB("SELECT * FROM tblUser WHERE Username LIKE  '%" + txtSearch.Text + "%' ORDER BY Username DESC");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //reset button
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            rbAdmin.Checked = false;
            rbAdmin.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picture (button) to exit application
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //picture (button) for help
            MessageBox.Show("");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //return to main homepage 
        }
    }
}
