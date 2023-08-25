namespace Vendlism
{
    partial class frmUsers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.imgOff2 = new System.Windows.Forms.PictureBox();
            this.imgOn2 = new System.Windows.Forms.PictureBox();
            this.imgOff = new System.Windows.Forms.PictureBox();
            this.imgOn = new System.Windows.Forms.PictureBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.rbNotAdmin = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbFilterNo = new System.Windows.Forms.RadioButton();
            this.rbFilterYes = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.cmbDelete = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.imgUpdateOff = new System.Windows.Forms.PictureBox();
            this.imgUpdateON = new System.Windows.Forms.PictureBox();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.rbUpdateAdmin2 = new System.Windows.Forms.RadioButton();
            this.rbUpdateAdmin = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.grpDelete.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateON)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(33, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(17, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(17, 139);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(190, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(17, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 39);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.grpUpdate);
            this.grpAdd.Controls.Add(this.imgOff2);
            this.grpAdd.Controls.Add(this.imgOn2);
            this.grpAdd.Controls.Add(this.imgOff);
            this.grpAdd.Controls.Add(this.imgOn);
            this.grpAdd.Controls.Add(this.txtConfirm);
            this.grpAdd.Controls.Add(this.label4);
            this.grpAdd.Controls.Add(this.btnAddUser);
            this.grpAdd.Controls.Add(this.txtPassword);
            this.grpAdd.Controls.Add(this.txtUsername);
            this.grpAdd.Controls.Add(this.rbNotAdmin);
            this.grpAdd.Controls.Add(this.rbAdmin);
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.label2);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Location = new System.Drawing.Point(246, 121);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(752, 250);
            this.grpAdd.TabIndex = 2;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "ADD USER";
            this.grpAdd.Visible = false;
            this.grpAdd.Enter += new System.EventHandler(this.grpAdd_Enter);
            // 
            // imgOff2
            // 
            this.imgOff2.BackColor = System.Drawing.Color.Transparent;
            this.imgOff2.BackgroundImage = global::Vendlism.Properties.Resources.Toggle_off1;
            this.imgOff2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOff2.Location = new System.Drawing.Point(369, 98);
            this.imgOff2.Name = "imgOff2";
            this.imgOff2.Size = new System.Drawing.Size(40, 22);
            this.imgOff2.TabIndex = 13;
            this.imgOff2.TabStop = false;
            this.imgOff2.Click += new System.EventHandler(this.imgOff2_Click);
            // 
            // imgOn2
            // 
            this.imgOn2.BackColor = System.Drawing.Color.Transparent;
            this.imgOn2.BackgroundImage = global::Vendlism.Properties.Resources.toggle_on1;
            this.imgOn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOn2.Location = new System.Drawing.Point(369, 98);
            this.imgOn2.Name = "imgOn2";
            this.imgOn2.Size = new System.Drawing.Size(40, 22);
            this.imgOn2.TabIndex = 12;
            this.imgOn2.TabStop = false;
            this.imgOn2.Visible = false;
            this.imgOn2.Click += new System.EventHandler(this.imgOn2_Click);
            // 
            // imgOff
            // 
            this.imgOff.BackColor = System.Drawing.Color.Transparent;
            this.imgOff.BackgroundImage = global::Vendlism.Properties.Resources.Toggle_off1;
            this.imgOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOff.Location = new System.Drawing.Point(369, 64);
            this.imgOff.Name = "imgOff";
            this.imgOff.Size = new System.Drawing.Size(40, 22);
            this.imgOff.TabIndex = 11;
            this.imgOff.TabStop = false;
            this.imgOff.Click += new System.EventHandler(this.imgOff_Click);
            // 
            // imgOn
            // 
            this.imgOn.BackColor = System.Drawing.Color.Transparent;
            this.imgOn.BackgroundImage = global::Vendlism.Properties.Resources.toggle_on1;
            this.imgOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOn.Location = new System.Drawing.Point(369, 64);
            this.imgOn.Name = "imgOn";
            this.imgOn.Size = new System.Drawing.Size(40, 22);
            this.imgOn.TabIndex = 10;
            this.imgOn.TabStop = false;
            this.imgOn.Visible = false;
            this.imgOn.Click += new System.EventHandler(this.imgOn_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(188, 102);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(157, 20);
            this.txtConfirm.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(37, 194);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(308, 38);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(188, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // rbNotAdmin
            // 
            this.rbNotAdmin.AutoSize = true;
            this.rbNotAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotAdmin.Location = new System.Drawing.Point(188, 159);
            this.rbNotAdmin.Name = "rbNotAdmin";
            this.rbNotAdmin.Size = new System.Drawing.Size(44, 21);
            this.rbNotAdmin.TabIndex = 4;
            this.rbNotAdmin.TabStop = true;
            this.rbNotAdmin.Text = "No";
            this.rbNotAdmin.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(188, 136);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(50, 21);
            this.rbAdmin.TabIndex = 3;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Yes";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Admin rights:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearchUser);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.rbFilterNo);
            this.grpSearch.Controls.Add(this.rbFilterYes);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.label8);
            this.grpSearch.Location = new System.Drawing.Point(277, 326);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(752, 250);
            this.grpSearch.TabIndex = 14;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "SEARCH USER";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(37, 126);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(321, 38);
            this.btnSearchUser.TabIndex = 7;
            this.btnSearchUser.Text = "Search Users";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(201, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbFilterNo
            // 
            this.rbFilterNo.AutoSize = true;
            this.rbFilterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilterNo.Location = new System.Drawing.Point(201, 88);
            this.rbFilterNo.Name = "rbFilterNo";
            this.rbFilterNo.Size = new System.Drawing.Size(140, 21);
            this.rbFilterNo.TabIndex = 4;
            this.rbFilterNo.TabStop = true;
            this.rbFilterNo.Text = "Normal users only";
            this.rbFilterNo.UseVisualStyleBackColor = true;
            // 
            // rbFilterYes
            // 
            this.rbFilterYes.AutoSize = true;
            this.rbFilterYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFilterYes.Location = new System.Drawing.Point(201, 61);
            this.rbFilterYes.Name = "rbFilterYes";
            this.rbFilterYes.Size = new System.Drawing.Size(134, 21);
            this.rbFilterYes.TabIndex = 3;
            this.rbFilterYes.TabStop = true;
            this.rbFilterYes.Text = "Admin users only";
            this.rbFilterYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filter Admin Users:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search by Username:";
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.cmbDelete);
            this.grpDelete.Controls.Add(this.button1);
            this.grpDelete.Controls.Add(this.textBox1);
            this.grpDelete.Controls.Add(this.label7);
            this.grpDelete.Location = new System.Drawing.Point(277, 326);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(752, 250);
            this.grpDelete.TabIndex = 15;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "DELETE USER";
            this.grpDelete.Visible = false;
            // 
            // cmbDelete
            // 
            this.cmbDelete.FormattingEnabled = true;
            this.cmbDelete.Location = new System.Drawing.Point(201, 62);
            this.cmbDelete.Name = "cmbDelete";
            this.cmbDelete.Size = new System.Drawing.Size(163, 21);
            this.cmbDelete.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search by Username:";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Controls.Add(this.lblPK);
            this.grpUpdate.Controls.Add(this.button2);
            this.grpUpdate.Controls.Add(this.imgUpdateOff);
            this.grpUpdate.Controls.Add(this.imgUpdateON);
            this.grpUpdate.Controls.Add(this.txtUpdatePassword);
            this.grpUpdate.Controls.Add(this.rbUpdateAdmin2);
            this.grpUpdate.Controls.Add(this.rbUpdateAdmin);
            this.grpUpdate.Controls.Add(this.label9);
            this.grpUpdate.Controls.Add(this.label10);
            this.grpUpdate.Controls.Add(this.label11);
            this.grpUpdate.Controls.Add(this.cmbUpdate);
            this.grpUpdate.Location = new System.Drawing.Point(120, 186);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(751, 250);
            this.grpUpdate.TabIndex = 14;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "UPDATE USER";
            this.grpUpdate.Visible = false;
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(187, 51);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(157, 21);
            this.cmbUpdate.TabIndex = 0;
            this.cmbUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbUpdate_SelectedIndexChanged);
            // 
            // imgUpdateOff
            // 
            this.imgUpdateOff.BackColor = System.Drawing.Color.Transparent;
            this.imgUpdateOff.BackgroundImage = global::Vendlism.Properties.Resources.Toggle_off1;
            this.imgUpdateOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUpdateOff.Location = new System.Drawing.Point(368, 91);
            this.imgUpdateOff.Name = "imgUpdateOff";
            this.imgUpdateOff.Size = new System.Drawing.Size(40, 22);
            this.imgUpdateOff.TabIndex = 24;
            this.imgUpdateOff.TabStop = false;
            // 
            // imgUpdateON
            // 
            this.imgUpdateON.BackColor = System.Drawing.Color.Transparent;
            this.imgUpdateON.BackgroundImage = global::Vendlism.Properties.Resources.toggle_on1;
            this.imgUpdateON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgUpdateON.Location = new System.Drawing.Point(368, 91);
            this.imgUpdateON.Name = "imgUpdateON";
            this.imgUpdateON.Size = new System.Drawing.Size(40, 22);
            this.imgUpdateON.TabIndex = 23;
            this.imgUpdateON.TabStop = false;
            this.imgUpdateON.Visible = false;
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(187, 91);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(157, 20);
            this.txtUpdatePassword.TabIndex = 20;
            // 
            // rbUpdateAdmin2
            // 
            this.rbUpdateAdmin2.AutoSize = true;
            this.rbUpdateAdmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdateAdmin2.Location = new System.Drawing.Point(187, 153);
            this.rbUpdateAdmin2.Name = "rbUpdateAdmin2";
            this.rbUpdateAdmin2.Size = new System.Drawing.Size(44, 21);
            this.rbUpdateAdmin2.TabIndex = 18;
            this.rbUpdateAdmin2.TabStop = true;
            this.rbUpdateAdmin2.Text = "No";
            this.rbUpdateAdmin2.UseVisualStyleBackColor = true;
            // 
            // rbUpdateAdmin
            // 
            this.rbUpdateAdmin.AutoSize = true;
            this.rbUpdateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdateAdmin.Location = new System.Drawing.Point(187, 130);
            this.rbUpdateAdmin.Name = "rbUpdateAdmin";
            this.rbUpdateAdmin.Size = new System.Drawing.Size(50, 21);
            this.rbUpdateAdmin.TabIndex = 17;
            this.rbUpdateAdmin.TabStop = true;
            this.rbUpdateAdmin.Text = "Yes";
            this.rbUpdateAdmin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Admin rights:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Username:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(31, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "Update User";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPK
            // 
            this.lblPK.AutoSize = true;
            this.lblPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPK.Location = new System.Drawing.Point(32, 21);
            this.lblPK.Name = "lblPK";
            this.lblPK.Size = new System.Drawing.Size(68, 20);
            this.lblPK.TabIndex = 27;
            this.lblPK.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = ".";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vendlism.Properties.Resources.MaintainUsers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 688);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpSearch);
            this.DoubleBuffered = true;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNotAdmin;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.PictureBox imgOn;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgOff;
        private System.Windows.Forms.PictureBox imgOff2;
        private System.Windows.Forms.PictureBox imgOn2;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbFilterNo;
        private System.Windows.Forms.RadioButton rbFilterYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.ComboBox cmbDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imgUpdateOff;
        private System.Windows.Forms.PictureBox imgUpdateON;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.RadioButton rbUpdateAdmin2;
        private System.Windows.Forms.RadioButton rbUpdateAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPK;
    }
}