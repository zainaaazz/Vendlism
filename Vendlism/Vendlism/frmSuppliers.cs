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
    public partial class frmSuppliers : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            loadDB("SELECT * FROM tblSupplier");
            loadCMB("cmbDelete");
            loadCMB("cmbUpdate");

            //Set location of all the groupboxes
            var point = new Point(267, 309);
            grpAdd.Location = point;
            grpSearch.Location = point;
            grpDelete.Location = point;
            grpUpdate.Location = point;
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
                adapter.Fill(ds, "tblSupplier");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tblSupplier";
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
                    string sql = $"SELECT Supplier_Name FROM tblSupplier";
                    adapter = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "tblSupplier");
                    cmb.DisplayMember = "Supplier_Name";
                    cmb.ValueMember = "Supplier_Name";
                    cmb.DataSource = ds.Tables["tblSupplier"];
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
            grpUpdate.Visible = false;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = false;
            grpDelete.Visible = false;
            grpSearch.Visible = true;
            grpUpdate.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUpdateEmail.Text = "";
            txtUpdatePhone.Text = "";
            txtUpdateAddress.Text = "";
            lblPK.Text = "";
            cmbUpdate.SelectedIndex = -1;

            grpUpdate.Visible = true;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
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

        //RESET SEARCH
        private void button3_Click(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblSupplier");
            cbPotch.Checked = false;
            txtSearch.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%'");
        }

        //FILTER POTCH ONLY
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPotch.Checked)
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%' AND Supplier_Address LIKE '%Potchefstroom%'");
            }
            else
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%'");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPotch.Checked)
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%' AND Supplier_Address LIKE '%Potchefstroom%' ORDER BY Supplier_Name ASC");
            }
            else
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%' ORDER BY Supplier_Name ASC");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPotch.Checked)
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%' AND Supplier_Address LIKE '%Potchefstroom%' ORDER BY Supplier_Name DESC");
            }
            else
            {
                loadDB("SELECT * FROM tblSupplier WHERE Supplier_Name LIKE  '%" + txtSearch.Text + "%' ORDER BY Supplier_Name DESC");
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
                string sql = $"SELECT * FROM tblSupplier";
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

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                //if user selected a username from combobox to delete
                if (cmbDelete.SelectedIndex != -1)
                {
                    errorProviderPassword.SetError(cmbDelete, "");

                    //Ask User if they are sure they would like to delete the selected user
                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this supplier: " + cmbDelete.Text + "?", "Delete User Confirmation", MessageBoxButtons.YesNo);

                    //if they are sure and click YES
                    if (dialogResult == DialogResult.Yes)
                    {
                        //CODE TO DELETE USER
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        string sql = $"DELETE FROM tblSupplier WHERE Supplier_ID = " + lblDeletePK.Text;
                        command = new SqlCommand(sql, conn);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = command;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        conn.Close();

                        //REFRESH COMBOBOX
                        loadCMB("cmbDelete");
                        loadCMB("cmbUpdate");

                        //REFRESH DATAGRIDVIEW
                        loadDB("SELECT * FROM tblSupplier");

                        //Success message
                        MessageBox.Show("Supplier Deleted Successfully");

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

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = $"SELECT * FROM tblSupplier";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetValue(1).ToString() == cmbUpdate.Text)
                    {
                        lblPK.Text = reader.GetValue(0).ToString();
                        txtUpdateEmail.Text = reader.GetValue(2).ToString();
                        txtUpdatePhone.Text = reader.GetValue(3).ToString();
                        txtUpdateAddress.Text = reader.GetValue(4).ToString();

                    }
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUpdate.Text != "")
                {
                    errorProviderPassword.SetError(cmbUpdate, "");

                    //Because the " ' " symbol causes the sql statement to fuck out
                    string symbols2 = "'";
                    Boolean symbolCheck2 = false;

                    string sName = cmbUpdate.Text;

                    foreach (char symbol in symbols2)
                    {
                        if (sName.Contains(symbol) || txtUpdateAddress.Text.Contains(symbol) || txtUpdateEmail.Text.Contains(symbol) || txtUpdatePhone.Text.Contains(symbol))
                        {
                            symbolCheck2 = true;
                        }
                    }

                        //if  does not contain ' symbol
                        if (symbolCheck2 == false)
                        {
                            errorProviderPassword.SetError(cmbUpdate, "");

                            
                                errorProviderPassword.SetError(cmbUpdate, "");

                                //Code to update Supplier
                                if (conn.State == ConnectionState.Closed)
                                {
                                    conn.Open();
                                }
                                string sql3 = $"UPDATE tblSupplier SET Supplier_Name = '" + cmbUpdate.Text + "', Supplier_Email = '" + txtUpdateEmail.Text + "', Supplier_PhoneNum = " + txtUpdatePhone.Text + ", Supplier_Address = '" + txtUpdateAddress.Text + "' WHERE Supplier_ID = " + int.Parse(lblPK.Text); 
                                command = new SqlCommand(sql3, conn);
                                adapter = new SqlDataAdapter();
                                adapter.UpdateCommand = command;
                                adapter.UpdateCommand.ExecuteNonQuery();
                                conn.Close();

                                //REFRESH COMBOBOX
                                loadCMB("cmbUpdate");
                                loadCMB("cmbDelete");

                                //REFRESH DATAGRIDVIEW
                                loadDB("SELECT * FROM tblSupplier");

                                //clear fields
                                lblPK.Text = "";
                                cmbUpdate.SelectedIndex = -1;
                                txtUpdateEmail.Text = "";
                                txtUpdateAddress.Text = "";
                                txtUpdatePhone.Text = "";

                            //success message
                            MessageBox.Show("Supplier Updated Successfully");

                            
                        }
                        else
                        {
                            errorProviderPassword.SetError(cmbUpdate, "One of the entered fields contains the following symbol - You cannot enter that symbol'");
                            cmbUpdate.Focus();
                        }
                    
                }
                else
                {
                    errorProviderPassword.SetError(cmbUpdate, "Please select a Supplier to update");
                    cmbUpdate.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
