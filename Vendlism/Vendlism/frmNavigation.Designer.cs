namespace Vendlism
{
    partial class frmNavigation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.LightGray;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Location = new System.Drawing.Point(32, 279);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(384, 39);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "MAINTAIN USERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseEnter += new System.EventHandler(this.btnUsers_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.LightGray;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Location = new System.Drawing.Point(32, 223);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(384, 39);
            this.btnSuppliers.TabIndex = 6;
            this.btnSuppliers.Text = "MAINTAIN SUPPLIERS";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            this.btnSuppliers.MouseEnter += new System.EventHandler(this.btnSuppliers_MouseEnter);
            this.btnSuppliers.MouseLeave += new System.EventHandler(this.btnSuppliers_MouseLeave);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.LightGray;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(32, 109);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(384, 38);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "MAINTAIN PRODUCTS";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            this.btnProducts.MouseEnter += new System.EventHandler(this.btnProducts_MouseEnter);
            this.btnProducts.MouseLeave += new System.EventHandler(this.btnProducts_MouseLeave);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightGray;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Location = new System.Drawing.Point(32, 358);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(384, 39);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "REQUEST REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.MouseEnter += new System.EventHandler(this.btnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.LightGray;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Location = new System.Drawing.Point(32, 166);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(384, 39);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "MANAGE PLACED ORDERS";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.MouseEnter += new System.EventHandler(this.btnOrders_MouseEnter);
            this.btnOrders.MouseLeave += new System.EventHandler(this.btnOrders_MouseLeave);
            // 
            // frmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vendlism.Properties.Resources.NAVIGATION;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 499);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnReports);
            this.DoubleBuffered = true;
            this.Name = "frmNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNavigation";
            this.Load += new System.EventHandler(this.frmNavigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnUsers;
        public System.Windows.Forms.Button btnSuppliers;
        public System.Windows.Forms.Button btnProducts;
        public System.Windows.Forms.Button btnReports;
        public System.Windows.Forms.Button btnOrders;
    }
}