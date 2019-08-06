namespace Contractor
{
    partial class users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.national_idLabel = new System.Windows.Forms.Label();
            this.printer_nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorDataSet = new Contractor.ContractorDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.national_idTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.printer_nameComboBox = new System.Windows.Forms.ComboBox();
            this.notifacationsCheckBox = new System.Windows.Forms.CheckBox();
            this.usersprivilageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.statisticsCheckBox = new System.Windows.Forms.CheckBox();
            this.sittingCheckBox = new System.Windows.Forms.CheckBox();
            this.usersCheckBox = new System.Windows.Forms.CheckBox();
            this.clientsCheckBox = new System.Windows.Forms.CheckBox();
            this.userViewDataGridView = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userusernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userprinterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useractiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paymentstypeCheckBox = new System.Windows.Forms.CheckBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new Contractor.ContractorDataSetTableAdapters.usersTableAdapter();
            this.users_privilageTableAdapter = new Contractor.ContractorDataSetTableAdapters.users_privilageTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(940, 88);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 26);
            this.usernameLabel.TabIndex = 62;
            this.usernameLabel.Text = "أسم المستخدم";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(940, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 26);
            this.passwordLabel.TabIndex = 64;
            this.passwordLabel.Text = "كلمة المرور";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(940, 168);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 26);
            this.nameLabel.TabIndex = 66;
            this.nameLabel.Text = "الأسم";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(451, 88);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(57, 26);
            this.phoneLabel.TabIndex = 68;
            this.phoneLabel.Text = "الهاتف";
            // 
            // national_idLabel
            // 
            this.national_idLabel.AutoSize = true;
            this.national_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.national_idLabel.Location = new System.Drawing.Point(449, 128);
            this.national_idLabel.Name = "national_idLabel";
            this.national_idLabel.Size = new System.Drawing.Size(83, 26);
            this.national_idLabel.TabIndex = 70;
            this.national_idLabel.Text = "رقم الهوية";
            // 
            // printer_nameLabel
            // 
            this.printer_nameLabel.AutoSize = true;
            this.printer_nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printer_nameLabel.Location = new System.Drawing.Point(449, 168);
            this.printer_nameLabel.Name = "printer_nameLabel";
            this.printer_nameLabel.Size = new System.Drawing.Size(59, 26);
            this.printer_nameLabel.TabIndex = 74;
            this.printer_nameLabel.Text = "الطابعة";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(666, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "المستخدمين";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_username", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.usernameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(538, 85);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(396, 32);
            this.usernameTextBox.TabIndex = 63;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.contractorDataSet;
            // 
            // contractorDataSet
            // 
            this.contractorDataSet.DataSetName = "ContractorDataSet";
            this.contractorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_password", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.passwordTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(538, 125);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(396, 32);
            this.passwordTextBox.TabIndex = 65;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(538, 165);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(396, 32);
            this.nameTextBox.TabIndex = 67;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_phone", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.phoneTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(12, 85);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(433, 32);
            this.phoneTextBox.TabIndex = 69;
            // 
            // national_idTextBox
            // 
            this.national_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_nationalid", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.national_idTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.national_idTextBox.Location = new System.Drawing.Point(12, 125);
            this.national_idTextBox.Name = "national_idTextBox";
            this.national_idTextBox.Size = new System.Drawing.Size(433, 32);
            this.national_idTextBox.TabIndex = 71;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersBindingSource, "user_active", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.activeCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCheckBox.Location = new System.Drawing.Point(936, 31);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(85, 32);
            this.activeCheckBox.TabIndex = 73;
            this.activeCheckBox.Text = "التفعيل";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // printer_nameComboBox
            // 
            this.printer_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_printer", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.printer_nameComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printer_nameComboBox.FormattingEnabled = true;
            this.printer_nameComboBox.Location = new System.Drawing.Point(12, 165);
            this.printer_nameComboBox.Name = "printer_nameComboBox";
            this.printer_nameComboBox.Size = new System.Drawing.Size(433, 32);
            this.printer_nameComboBox.TabIndex = 75;
            // 
            // notifacationsCheckBox
            // 
            this.notifacationsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifacationsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "notifications", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.notifacationsCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifacationsCheckBox.Location = new System.Drawing.Point(833, 31);
            this.notifacationsCheckBox.Name = "notifacationsCheckBox";
            this.notifacationsCheckBox.Size = new System.Drawing.Size(95, 32);
            this.notifacationsCheckBox.TabIndex = 79;
            this.notifacationsCheckBox.Text = "التنبيهات";
            this.notifacationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // usersprivilageBindingSource
            // 
            this.usersprivilageBindingSource.DataMember = "users_privilage";
            this.usersprivilageBindingSource.DataSource = this.contractorDataSet;
            // 
            // projectsCheckBox
            // 
            this.projectsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "projects", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.projectsCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsCheckBox.Location = new System.Drawing.Point(736, 31);
            this.projectsCheckBox.Name = "projectsCheckBox";
            this.projectsCheckBox.Size = new System.Drawing.Size(89, 32);
            this.projectsCheckBox.TabIndex = 91;
            this.projectsCheckBox.Text = "المشاريع";
            this.projectsCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentCheckBox
            // 
            this.paymentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "payments", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.paymentCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentCheckBox.Location = new System.Drawing.Point(494, 31);
            this.paymentCheckBox.Name = "paymentCheckBox";
            this.paymentCheckBox.Size = new System.Drawing.Size(131, 32);
            this.paymentCheckBox.TabIndex = 93;
            this.paymentCheckBox.Text = "الدفعات المالية";
            this.paymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // statisticsCheckBox
            // 
            this.statisticsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "statistics", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.statisticsCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsCheckBox.Location = new System.Drawing.Point(53, 31);
            this.statisticsCheckBox.Name = "statisticsCheckBox";
            this.statisticsCheckBox.Size = new System.Drawing.Size(89, 32);
            this.statisticsCheckBox.TabIndex = 95;
            this.statisticsCheckBox.Text = "التقارير";
            this.statisticsCheckBox.UseVisualStyleBackColor = true;
            // 
            // sittingCheckBox
            // 
            this.sittingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sittingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "sittings", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.sittingCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sittingCheckBox.Location = new System.Drawing.Point(269, 31);
            this.sittingCheckBox.Name = "sittingCheckBox";
            this.sittingCheckBox.Size = new System.Drawing.Size(92, 32);
            this.sittingCheckBox.TabIndex = 99;
            this.sittingCheckBox.Text = "الأعدادات";
            this.sittingCheckBox.UseVisualStyleBackColor = true;
            // 
            // usersCheckBox
            // 
            this.usersCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "users", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.usersCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersCheckBox.Location = new System.Drawing.Point(148, 31);
            this.usersCheckBox.Name = "usersCheckBox";
            this.usersCheckBox.Size = new System.Drawing.Size(115, 32);
            this.usersCheckBox.TabIndex = 101;
            this.usersCheckBox.Text = "المستخدمين";
            this.usersCheckBox.UseVisualStyleBackColor = true;
            // 
            // clientsCheckBox
            // 
            this.clientsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "clients", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.clientsCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsCheckBox.Location = new System.Drawing.Point(633, 31);
            this.clientsCheckBox.Name = "clientsCheckBox";
            this.clientsCheckBox.Size = new System.Drawing.Size(95, 32);
            this.clientsCheckBox.TabIndex = 103;
            this.clientsCheckBox.Text = "المعاملين";
            this.clientsCheckBox.UseVisualStyleBackColor = true;
            // 
            // userViewDataGridView
            // 
            this.userViewDataGridView.AllowUserToAddRows = false;
            this.userViewDataGridView.AllowUserToDeleteRows = false;
            this.userViewDataGridView.AllowUserToResizeColumns = false;
            this.userViewDataGridView.AllowUserToResizeRows = false;
            this.userViewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userViewDataGridView.AutoGenerateColumns = false;
            this.userViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userusernameDataGridViewTextBoxColumn,
            this.userpasswordDataGridViewTextBoxColumn,
            this.userprinterDataGridViewTextBoxColumn,
            this.userphoneDataGridViewTextBoxColumn,
            this.usernationalidDataGridViewTextBoxColumn,
            this.useractiveDataGridViewCheckBoxColumn});
            this.userViewDataGridView.DataSource = this.usersBindingSource;
            this.userViewDataGridView.Location = new System.Drawing.Point(12, 328);
            this.userViewDataGridView.MultiSelect = false;
            this.userViewDataGridView.Name = "userViewDataGridView";
            this.userViewDataGridView.ReadOnly = true;
            this.userViewDataGridView.RowHeadersVisible = false;
            this.userViewDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.userViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userViewDataGridView.Size = new System.Drawing.Size(1027, 321);
            this.userViewDataGridView.TabIndex = 103;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userusernameDataGridViewTextBoxColumn
            // 
            this.userusernameDataGridViewTextBoxColumn.DataPropertyName = "user_username";
            this.userusernameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.userusernameDataGridViewTextBoxColumn.Name = "userusernameDataGridViewTextBoxColumn";
            this.userusernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "user_password";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "كلمة المرور";
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userprinterDataGridViewTextBoxColumn
            // 
            this.userprinterDataGridViewTextBoxColumn.DataPropertyName = "user_printer";
            this.userprinterDataGridViewTextBoxColumn.HeaderText = "الطابعة";
            this.userprinterDataGridViewTextBoxColumn.Name = "userprinterDataGridViewTextBoxColumn";
            this.userprinterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userphoneDataGridViewTextBoxColumn
            // 
            this.userphoneDataGridViewTextBoxColumn.DataPropertyName = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.HeaderText = "الهاتف";
            this.userphoneDataGridViewTextBoxColumn.Name = "userphoneDataGridViewTextBoxColumn";
            this.userphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernationalidDataGridViewTextBoxColumn
            // 
            this.usernationalidDataGridViewTextBoxColumn.DataPropertyName = "user_nationalid";
            this.usernationalidDataGridViewTextBoxColumn.HeaderText = "رقم الهوية";
            this.usernationalidDataGridViewTextBoxColumn.Name = "usernationalidDataGridViewTextBoxColumn";
            this.usernationalidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useractiveDataGridViewCheckBoxColumn
            // 
            this.useractiveDataGridViewCheckBoxColumn.DataPropertyName = "user_active";
            this.useractiveDataGridViewCheckBoxColumn.HeaderText = "التفعيل";
            this.useractiveDataGridViewCheckBoxColumn.Name = "useractiveDataGridViewCheckBoxColumn";
            this.useractiveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.activeCheckBox);
            this.groupBox1.Controls.Add(this.notifacationsCheckBox);
            this.groupBox1.Controls.Add(this.paymentstypeCheckBox);
            this.groupBox1.Controls.Add(this.paymentCheckBox);
            this.groupBox1.Controls.Add(this.projectsCheckBox);
            this.groupBox1.Controls.Add(this.clientsCheckBox);
            this.groupBox1.Controls.Add(this.statisticsCheckBox);
            this.groupBox1.Controls.Add(this.sittingCheckBox);
            this.groupBox1.Controls.Add(this.usersCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 75);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصلاحيات";
            // 
            // paymentstypeCheckBox
            // 
            this.paymentstypeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentstypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usersprivilageBindingSource, "payments_type", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.paymentstypeCheckBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentstypeCheckBox.Location = new System.Drawing.Point(369, 31);
            this.paymentstypeCheckBox.Name = "paymentstypeCheckBox";
            this.paymentstypeCheckBox.Size = new System.Drawing.Size(117, 32);
            this.paymentstypeCheckBox.TabIndex = 93;
            this.paymentstypeCheckBox.Text = "أنواع الدفعات";
            this.paymentstypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 285);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(144, 37);
            this.delete_btn.TabIndex = 108;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(315, 285);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(137, 37);
            this.add_btn.TabIndex = 106;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.AddUsrBtn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(165, 285);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(144, 37);
            this.edit_btn.TabIndex = 107;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.Click += new System.EventHandler(this.updateUserBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(940, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 109;
            this.label2.Text = "بحث";
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textBox.Location = new System.Drawing.Point(538, 287);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(396, 32);
            this.Search_textBox.TabIndex = 105;
            this.Search_textBox.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // users_privilageTableAdapter
            // 
            this.users_privilageTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Contractor.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(554, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Contractor.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(610, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 661);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userViewDataGridView);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.national_idLabel);
            this.Controls.Add(this.national_idTextBox);
            this.Controls.Add(this.printer_nameLabel);
            this.Controls.Add(this.printer_nameComboBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.users_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.users_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userViewDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox national_idTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox printer_nameComboBox;
        private System.Windows.Forms.CheckBox notifacationsCheckBox;
        private System.Windows.Forms.CheckBox projectsCheckBox;
        private System.Windows.Forms.CheckBox paymentCheckBox;
        private System.Windows.Forms.CheckBox statisticsCheckBox;
        private System.Windows.Forms.CheckBox sittingCheckBox;
        private System.Windows.Forms.CheckBox usersCheckBox;
        private System.Windows.Forms.CheckBox clientsCheckBox;
        private System.Windows.Forms.DataGridView userViewDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox paymentstypeCheckBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label national_idLabel;
        private System.Windows.Forms.Label printer_nameLabel;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search_textBox;
        private ContractorDataSet contractorDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ContractorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private ContractorDataSetTableAdapters.users_privilageTableAdapter users_privilageTableAdapter;
        private System.Windows.Forms.BindingSource usersprivilageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userusernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userprinterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useractiveDataGridViewCheckBoxColumn;
    }
}

