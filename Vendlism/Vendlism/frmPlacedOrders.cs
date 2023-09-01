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
    public partial class frmPlacedOrders : Form
    {
        public frmPlacedOrders()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            grpPlaceOrder.Visible = true;
            grpCancelOrder.Visible = false;
            grpReceiveOrder.Visible = false;
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            grpPlaceOrder.Visible = false;
            grpCancelOrder.Visible = false;
            grpReceiveOrder.Visible = true;
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            grpPlaceOrder.Visible = false;
            grpCancelOrder.Visible = true;
            grpReceiveOrder.Visible = false;
        }

        private void frmPlacedOrders_Load(object sender, EventArgs e)
        {
            var point = new Point(268, 307); 
            grpPlaceOrder.Location = point;
            grpCancelOrder.Location = point;
            grpReceiveOrder.Location = point;
          
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


        private void btnPlaceOrder_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnPlaceOrder");
        }

        private void btnPlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnPlaceOrder");
        }

        private void btnReceiveOrder_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnReceiveOrder");
        }

        private void btnReceiveOrder_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnReceiveOrder");
        }

        private void btnCancelOrder_MouseEnter(object sender, EventArgs e)
        {
            enterHover("btnCancelOrder");
        }

        private void btnCancelOrder_MouseLeave(object sender, EventArgs e)
        {
            leaveHover("btnCancelOrder");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
