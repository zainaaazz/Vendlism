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
    public partial class frmLogin : Form
    {
        //test

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public Boolean isAdminUser = false;
        

        public string connectionString = @"Data Source=LAPTOP-7C5EDQSL\SQLEXPRESS;Initial Catalog=Vendilism;Integrated Security=True; Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void returnToNav()
        {
            frmNavigation NavForm = new frmNavigation();

         //   MessageBox.Show(isAdminUser.ToString());

            if (isAdminUser == true)
            {
                NavForm.btnReports.Visible = true;
                NavForm.btnUsers.Visible = true;
                NavForm.btnSuppliers.Visible = true;
            }
            else
            {
                NavForm.btnReports.Visible = false;
                NavForm.btnUsers.Visible = false;
                NavForm.btnSuppliers.Visible = false;
            }

            NavForm.ShowDialog();
            this.Close();
        }

        public frmLogin()
        {
            InitializeComponent();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            lblForgot.Text = "If password has been forgotten,\nplease contact an admin user to reset it";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string decPass = "";
            string username = txtUsername.Text;
            string password = txtPassword.Text;

           

            //  Boolean usernameFound = false;

            if (username != "")
            {
                errorProvider1.SetError(txtUsername, "");

                if (password != "")
                {
                    errorProvider1.SetError(txtPassword, "");

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string sql = "SELECT * FROM tblUser";
                    command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        if (username == reader.GetValue(1).ToString())
                        {
                            errorProvider1.SetError(txtUsername, "");

                            decPass = Decrypt(reader.GetValue(2).ToString(), 3);

                            if (reader.GetValue(3).ToString() == "True")
                            {
                                isAdminUser = true;
                            }
                            


                           // MessageBox.Show(isAdminUser.ToString());
                        }
                        else
                        {
                            errorProvider1.SetError(txtUsername, "Username not found");

                        }
                    }


                    conn.Close();

                    if (password == decPass)
                    {
                        errorProvider1.SetError(txtPassword, "");

                        returnToNav();
                    }
                    else
                    {
                        errorProvider1.SetError(txtPassword, "Invalid Password");

                        txtPassword.Text = "";
                    }

                }
                else
                {
                    errorProvider1.SetError(txtPassword, "Please enter your password");
                }
            }
            else
            {
                errorProvider1.SetError(txtUsername, "Please enter your username");
            }

           
        }

        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnLogIn");
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnLogIn");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMachine machine = new frmMachine();
            this.Hide();
            machine.Show();
        }
    }
}
