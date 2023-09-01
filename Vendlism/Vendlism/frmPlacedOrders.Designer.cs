namespace Vendlism
{
    partial class frmPlacedOrders
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
            this.grpReceiveOrder = new System.Windows.Forms.GroupBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPK = new System.Windows.Forms.Label();
            this.lblPrimaryKey = new System.Windows.Forms.Label();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.grpCancelOrder = new System.Windows.Forms.GroupBox();
            this.lblDeletePK = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPlaceOrder = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReceiveOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.grpReceiveOrder.SuspendLayout();
            this.grpCancelOrder.SuspendLayout();
            this.grpPlaceOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReceiveOrder
            // 
            this.grpReceiveOrder.Controls.Add(this.txtUpdateAddress);
            this.grpReceiveOrder.Controls.Add(this.txtUpdatePhone);
            this.grpReceiveOrder.Controls.Add(this.label13);
            this.grpReceiveOrder.Controls.Add(this.lblPK);
            this.grpReceiveOrder.Controls.Add(this.lblPrimaryKey);
            this.grpReceiveOrder.Controls.Add(this.btnUpdateSupplier);
            this.grpReceiveOrder.Controls.Add(this.txtUpdateEmail);
            this.grpReceiveOrder.Controls.Add(this.label9);
            this.grpReceiveOrder.Controls.Add(this.label10);
            this.grpReceiveOrder.Controls.Add(this.label11);
            this.grpReceiveOrder.Controls.Add(this.cmbUpdate);
            this.grpReceiveOrder.Location = new System.Drawing.Point(268, 307);
            this.grpReceiveOrder.Name = "grpReceiveOrder";
            this.grpReceiveOrder.Size = new System.Drawing.Size(741, 250);
            this.grpReceiveOrder.TabIndex = 113;
            this.grpReceiveOrder.TabStop = false;
            this.grpReceiveOrder.Text = "RECEIVE ORDER";
            this.grpReceiveOrder.Visible = false;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(231, 170);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(157, 20);
            this.txtUpdateAddress.TabIndex = 31;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(231, 132);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(157, 20);
            this.txtUpdatePhone.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Supplier Address:";
            // 
            // lblPK
            // 
            this.lblPK.AutoSize = true;
            this.lblPK.Location = new System.Drawing.Point(232, 32);
            this.lblPK.Name = "lblPK";
            this.lblPK.Size = new System.Drawing.Size(10, 13);
            this.lblPK.TabIndex = 28;
            this.lblPK.Text = ".";
            // 
            // lblPrimaryKey
            // 
            this.lblPrimaryKey.AutoSize = true;
            this.lblPrimaryKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryKey.Location = new System.Drawing.Point(33, 27);
            this.lblPrimaryKey.Name = "lblPrimaryKey";
            this.lblPrimaryKey.Size = new System.Drawing.Size(74, 20);
            this.lblPrimaryKey.TabIndex = 27;
            this.lblPrimaryKey.Text = "Order ID:";
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.Location = new System.Drawing.Point(37, 205);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(351, 38);
            this.btnUpdateSupplier.TabIndex = 19;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(231, 94);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(157, 20);
            this.txtUpdateEmail.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Supplier Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Supplier Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Supplier Name:";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(231, 59);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(157, 21);
            this.cmbUpdate.TabIndex = 15;
            // 
            // grpCancelOrder
            // 
            this.grpCancelOrder.Controls.Add(this.lblDeletePK);
            this.grpCancelOrder.Controls.Add(this.label12);
            this.grpCancelOrder.Controls.Add(this.cmbDelete);
            this.grpCancelOrder.Controls.Add(this.btnDeleteSupplier);
            this.grpCancelOrder.Controls.Add(this.label7);
            this.grpCancelOrder.Location = new System.Drawing.Point(268, 374);
            this.grpCancelOrder.Name = "grpCancelOrder";
            this.grpCancelOrder.Size = new System.Drawing.Size(752, 250);
            this.grpCancelOrder.TabIndex = 115;
            this.grpCancelOrder.TabStop = false;
            this.grpCancelOrder.Text = "CANCEL PLACED ORDER";
            this.grpCancelOrder.Visible = false;
            // 
            // lblDeletePK
            // 
            this.lblDeletePK.AutoSize = true;
            this.lblDeletePK.Location = new System.Drawing.Point(211, 35);
            this.lblDeletePK.Name = "lblDeletePK";
            this.lblDeletePK.Size = new System.Drawing.Size(10, 13);
            this.lblDeletePK.TabIndex = 30;
            this.lblDeletePK.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Supplier ID:";
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(231, 61);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(163, 21);
            this.cmbDelete.TabIndex = 20;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(38, 113);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(356, 38);
            this.btnDeleteSupplier.TabIndex = 21;
            this.btnDeleteSupplier.Text = "Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search by Supplier Name:";
            // 
            // grpPlaceOrder
            // 
            this.grpPlaceOrder.Controls.Add(this.txtAddress);
            this.grpPlaceOrder.Controls.Add(this.button2);
            this.grpPlaceOrder.Controls.Add(this.txtPhone);
            this.grpPlaceOrder.Controls.Add(this.label4);
            this.grpPlaceOrder.Controls.Add(this.btnAddSupplier);
            this.grpPlaceOrder.Controls.Add(this.txtEmail);
            this.grpPlaceOrder.Controls.Add(this.txtName);
            this.grpPlaceOrder.Controls.Add(this.label3);
            this.grpPlaceOrder.Controls.Add(this.label2);
            this.grpPlaceOrder.Controls.Add(this.label1);
            this.grpPlaceOrder.Location = new System.Drawing.Point(374, 307);
            this.grpPlaceOrder.Name = "grpPlaceOrder";
            this.grpPlaceOrder.Size = new System.Drawing.Size(752, 250);
            this.grpPlaceOrder.TabIndex = 112;
            this.grpPlaceOrder.TabStop = false;
            this.grpPlaceOrder.Text = "PLACE ORDER";
            this.grpPlaceOrder.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(234, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(234, 100);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Supplier Phone Number:";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(37, 194);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(308, 38);
            this.btnAddSupplier.TabIndex = 12;
            this.btnAddSupplier.Text = "Add New Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPlaceOrder);
            this.groupBox1.Controls.Add(this.btnReceiveOrder);
            this.groupBox1.Controls.Add(this.btnCancelOrder);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(32, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 250);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.LightGray;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(17, 27);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(190, 39);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            this.btnPlaceOrder.MouseEnter += new System.EventHandler(this.btnPlaceOrder_MouseEnter);
            this.btnPlaceOrder.MouseLeave += new System.EventHandler(this.btnPlaceOrder_MouseLeave);
            // 
            // btnReceiveOrder
            // 
            this.btnReceiveOrder.BackColor = System.Drawing.Color.LightGray;
            this.btnReceiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveOrder.Location = new System.Drawing.Point(17, 83);
            this.btnReceiveOrder.Name = "btnReceiveOrder";
            this.btnReceiveOrder.Size = new System.Drawing.Size(190, 39);
            this.btnReceiveOrder.TabIndex = 2;
            this.btnReceiveOrder.Text = "RECEIVE ORDER";
            this.btnReceiveOrder.UseVisualStyleBackColor = false;
            this.btnReceiveOrder.Click += new System.EventHandler(this.btnReceiveOrder_Click);
            this.btnReceiveOrder.MouseEnter += new System.EventHandler(this.btnReceiveOrder_MouseEnter);
            this.btnReceiveOrder.MouseLeave += new System.EventHandler(this.btnReceiveOrder_MouseLeave);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(17, 139);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(190, 38);
            this.btnCancelOrder.TabIndex = 1;
            this.btnCancelOrder.Text = "CANCEL ORDER";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            this.btnCancelOrder.MouseEnter += new System.EventHandler(this.btnCancelOrder_MouseEnter);
            this.btnCancelOrder.MouseLeave += new System.EventHandler(this.btnCancelOrder_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(981, 188);
            this.dataGridView1.TabIndex = 110;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Vendlism.Properties.Resources.back_icon_png_16;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(32, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 56);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Vendlism.Properties.Resources.exittt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(954, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Vendlism.Properties.Resources.help_129;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(895, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 56);
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // frmPlacedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vendlism.Properties.Resources.ManageOrders;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 649);
            this.Controls.Add(this.grpReceiveOrder);
            this.Controls.Add(this.grpCancelOrder);
            this.Controls.Add(this.grpPlaceOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Name = "frmPlacedOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlacedOrders";
            this.Load += new System.EventHandler(this.frmPlacedOrders_Load);
            this.grpReceiveOrder.ResumeLayout(false);
            this.grpReceiveOrder.PerformLayout();
            this.grpCancelOrder.ResumeLayout(false);
            this.grpCancelOrder.PerformLayout();
            this.grpPlaceOrder.ResumeLayout(false);
            this.grpPlaceOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpReceiveOrder;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPK;
        private System.Windows.Forms.Label lblPrimaryKey;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.GroupBox grpCancelOrder;
        private System.Windows.Forms.Label lblDeletePK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpPlaceOrder;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReceiveOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}