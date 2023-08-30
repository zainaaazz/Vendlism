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
    public partial class frmStockItems : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmStockItems()
        {
            InitializeComponent();
        }

        private void frmStockItems_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);

            loadDB("SELECT * FROM tblProduct");
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
           // int empty = getEmpty();

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

        public string getEmpty()
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

        //    MessageBox.Show("sMissing: "+sMissing);

            return sOutput;


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

            spnPrice.Value = 0;
            spnQuantity.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //  txtUpdateEmail.Text = "";
            //   txtUpdatePhone.Text = "";

            spnUpdateQuantity.Value = 0;
            spnUpdatePrice.Value = 0;

            lblPK.Text = "";
            cmbUpdate.SelectedIndex = -1;

            grpUpdate.Visible = true;
            grpAdd.Visible = false;
            grpSearch.Visible = false;
            grpDelete.Visible = false;
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
                        loadDB("SELECT * FROM tblProduct");

                        //Success message
                        MessageBox.Show("Product Deleted Successfully");

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
    }
}
