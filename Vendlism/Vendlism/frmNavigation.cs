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
        public frmNavigation()
        {
            InitializeComponent();
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
        private void frmNavigation_Load(object sender, EventArgs e)
        {
            if (lblAdmin.Text == "Admin")
            {
                btnReports.Enabled = true;
                btnUsers.Enabled = true;
                btnSuppliers.Enabled = true;
            }
            else if (lblAdmin.Text == "Not Admin")
            {
                btnReports.Enabled = false;
                btnUsers.Enabled = false;
                btnSuppliers.Enabled = false;
            }
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
            frmStockItems stock = new frmStockItems();
            this.Hide();
            stock.Show();

        }
    }
}
