using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendlism
{
    public partial class frmNavigation : Form

    {
        private frmLogin frmLogin;
        //public bool isAdminUser { set; get; }

        public frmNavigation(frmLogin frmLogin)
        {
            InitializeComponent();
            //this.isAdminUser = isAdminUser;
            this.frmLogin = frmLogin;
            UpdateButtonVisibility();
        }

        private void UpdateButtonVisibility()
        {
            if(frmLogin != null && frmLogin.isAdminUser)
            {
                btnReports.Visible = true;
                btnUsers.Visible = true;
                btnSuppliers.Visible = true;
            }
            else
            {
                btnReports.Visible = false;
                btnUsers.Visible = false;
                btnSuppliers.Visible = false;
            }
        }

        frmLogin log = new frmLogin();

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
        private void frmNavigation_Load(object sender, EventArgs e)
        {
            UpdateButtonVisibility();
            /*if (log.isAdminUser == true)
            {
                btnReports.Visible = true;
                btnUsers.Visible = true;
                btnSuppliers.Visible = true;
            }
            else if (log.isAdminUser ==false)
            {
                btnReports.Visible = false;
                btnUsers.Visible = false;
                btnSuppliers.Visible = false;
            }*/
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnUsers");
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnUsers");
        }

        private void btnSuppliers_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnSuppliers");
        }

        private void btnSuppliers_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnSuppliers");
        }

        private void btnProducts_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnProducts");
        }

        private void btnProducts_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnProducts");
        }

        private void btnOrders_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnOrders");
        }

        private void btnOrders_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnOrders");
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnReports");
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnReports");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            this.Hide();
            users.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmStockItems stock = new frmStockItems(frmLogin);
            this.Hide();
            stock.Show();

        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers supp = new frmSuppliers(frmLogin);
            this.Hide();
            supp.Show();
        }
    }
}
