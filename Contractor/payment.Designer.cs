namespace Contractor
{
    partial class payment
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
            System.Windows.Forms.Label payment_client_idLabel;
            System.Windows.Forms.Label payment_project_idLabel;
            System.Windows.Forms.Label payment_amountLabel;
            System.Windows.Forms.Label payment_discriptionLabel;
            System.Windows.Forms.Label payment_type_idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentuseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentclientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorDataSet = new Contractor.ContractorDataSet();
            this.paymenttypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymenttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentprojectidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdiscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new Contractor.ContractorDataSetTableAdapters.paymentsTableAdapter();
            this.payment_client_idComboBox = new System.Windows.Forms.ComboBox();
            this.payment_project_idComboBox = new System.Windows.Forms.ComboBox();
            this.payment_amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.payment_discriptionTextBox = new System.Windows.Forms.TextBox();
            this.payment_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.clientsTableAdapter = new Contractor.ContractorDataSetTableAdapters.clientsTableAdapter();
            this.projectsTableAdapter = new Contractor.ContractorDataSetTableAdapters.projectsTableAdapter();
            this.payment_typeTableAdapter = new Contractor.ContractorDataSetTableAdapters.payment_typeTableAdapter();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            payment_client_idLabel = new System.Windows.Forms.Label();
            payment_project_idLabel = new System.Windows.Forms.Label();
            payment_amountLabel = new System.Windows.Forms.Label();
            payment_discriptionLabel = new System.Windows.Forms.Label();
            payment_type_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_client_idLabel
            // 
            payment_client_idLabel.AutoSize = true;
            payment_client_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_client_idLabel.Location = new System.Drawing.Point(720, 88);
            payment_client_idLabel.Name = "payment_client_idLabel";
            payment_client_idLabel.Size = new System.Drawing.Size(123, 26);
            payment_client_idLabel.TabIndex = 12;
            payment_client_idLabel.Text = "المستلم \\ المسلِم";
            // 
            // payment_project_idLabel
            // 
            payment_project_idLabel.AutoSize = true;
            payment_project_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_project_idLabel.Location = new System.Drawing.Point(242, 88);
            payment_project_idLabel.Name = "payment_project_idLabel";
            payment_project_idLabel.Size = new System.Drawing.Size(65, 26);
            payment_project_idLabel.TabIndex = 14;
            payment_project_idLabel.Text = "المشروع";
            // 
            // payment_amountLabel
            // 
            payment_amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_amountLabel.AutoSize = true;
            payment_amountLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_amountLabel.Location = new System.Drawing.Point(987, 88);
            payment_amountLabel.Name = "payment_amountLabel";
            payment_amountLabel.Size = new System.Drawing.Size(51, 26);
            payment_amountLabel.TabIndex = 10;
            payment_amountLabel.Text = "المبلغ";
            // 
            // payment_discriptionLabel
            // 
            payment_discriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_discriptionLabel.AutoSize = true;
            payment_discriptionLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_discriptionLabel.Location = new System.Drawing.Point(987, 129);
            payment_discriptionLabel.Name = "payment_discriptionLabel";
            payment_discriptionLabel.Size = new System.Drawing.Size(61, 26);
            payment_discriptionLabel.TabIndex = 11;
            payment_discriptionLabel.Text = "التعليق";
            // 
            // payment_type_idLabel
            // 
            payment_type_idLabel.AutoSize = true;
            payment_type_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_type_idLabel.Location = new System.Drawing.Point(455, 88);
            payment_type_idLabel.Name = "payment_type_idLabel";
            payment_type_idLabel.Size = new System.Drawing.Size(44, 26);
            payment_type_idLabel.TabIndex = 13;
            payment_type_idLabel.Text = "النوع";
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
            this.label1.TabIndex = 9;
            this.label1.Text = "الدفعات المالية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::Contractor.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(554, 17);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(50, 50);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtn.TabIndex = 59;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Image = global::Contractor.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(610, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshBtn.TabIndex = 58;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.AllowUserToResizeColumns = false;
            this.paymentDataGridView.AllowUserToResizeRows = false;
            this.paymentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentidDataGridViewTextBoxColumn,
            this.paymentuseridDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn,
            this.paymentclientidDataGridViewTextBoxColumn,
            this.paymenttypeidDataGridViewTextBoxColumn,
            this.paymentprojectidDataGridViewTextBoxColumn,
            this.paymentdatetimeDataGridViewTextBoxColumn,
            this.paymentdiscriptionDataGridViewTextBoxColumn});
            this.paymentDataGridView.DataSource = this.paymentsBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(12, 166);
            this.paymentDataGridView.MultiSelect = false;
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.RowHeadersVisible = false;
            this.paymentDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.paymentDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentDataGridView.RowTemplate.Height = 30;
            this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGridView.Size = new System.Drawing.Size(1036, 488);
            this.paymentDataGridView.TabIndex = 8;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentuseridDataGridViewTextBoxColumn
            // 
            this.paymentuseridDataGridViewTextBoxColumn.DataPropertyName = "payment_user_id";
            this.paymentuseridDataGridViewTextBoxColumn.HeaderText = "payment_user_id";
            this.paymentuseridDataGridViewTextBoxColumn.Name = "paymentuseridDataGridViewTextBoxColumn";
            this.paymentuseridDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentuseridDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "payment_amount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentamountDataGridViewTextBoxColumn.Width = 65;
            // 
            // paymentclientidDataGridViewTextBoxColumn
            // 
            this.paymentclientidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentclientidDataGridViewTextBoxColumn.DataPropertyName = "payment_client_id";
            this.paymentclientidDataGridViewTextBoxColumn.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentclientidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.paymentclientidDataGridViewTextBoxColumn.DisplayMember = "client_name";
            this.paymentclientidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymentclientidDataGridViewTextBoxColumn.HeaderText = "المستلم \\ المسلم";
            this.paymentclientidDataGridViewTextBoxColumn.Name = "paymentclientidDataGridViewTextBoxColumn";
            this.paymentclientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentclientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentclientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentclientidDataGridViewTextBoxColumn.ValueMember = "client_id";
            this.paymentclientidDataGridViewTextBoxColumn.Width = 122;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.contractorDataSet;
            // 
            // contractorDataSet
            // 
            this.contractorDataSet.DataSetName = "ContractorDataSet";
            this.contractorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymenttypeidDataGridViewTextBoxColumn
            // 
            this.paymenttypeidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymenttypeidDataGridViewTextBoxColumn.DataPropertyName = "payment_type_id";
            this.paymenttypeidDataGridViewTextBoxColumn.DataSource = this.paymenttypeBindingSource;
            this.paymenttypeidDataGridViewTextBoxColumn.DisplayMember = "payment_type_name";
            this.paymenttypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymenttypeidDataGridViewTextBoxColumn.HeaderText = "النوع";
            this.paymenttypeidDataGridViewTextBoxColumn.Name = "paymenttypeidDataGridViewTextBoxColumn";
            this.paymenttypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymenttypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymenttypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymenttypeidDataGridViewTextBoxColumn.ValueMember = "payment_type_id";
            this.paymenttypeidDataGridViewTextBoxColumn.Width = 59;
            // 
            // paymenttypeBindingSource
            // 
            this.paymenttypeBindingSource.DataMember = "payment_type";
            this.paymenttypeBindingSource.DataSource = this.contractorDataSet;
            // 
            // paymentprojectidDataGridViewTextBoxColumn
            // 
            this.paymentprojectidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentprojectidDataGridViewTextBoxColumn.DataPropertyName = "payment_project_id";
            this.paymentprojectidDataGridViewTextBoxColumn.DataSource = this.projectsBindingSource;
            this.paymentprojectidDataGridViewTextBoxColumn.DisplayMember = "project_name";
            this.paymentprojectidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymentprojectidDataGridViewTextBoxColumn.HeaderText = "المشروع";
            this.paymentprojectidDataGridViewTextBoxColumn.Name = "paymentprojectidDataGridViewTextBoxColumn";
            this.paymentprojectidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentprojectidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentprojectidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentprojectidDataGridViewTextBoxColumn.ValueMember = "project_id";
            this.paymentprojectidDataGridViewTextBoxColumn.Width = 76;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "projects";
            this.projectsBindingSource.DataSource = this.contractorDataSet;
            // 
            // paymentdatetimeDataGridViewTextBoxColumn
            // 
            this.paymentdatetimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.paymentdatetimeDataGridViewTextBoxColumn.DataPropertyName = "payment_datetime";
            this.paymentdatetimeDataGridViewTextBoxColumn.HeaderText = "الوقت";
            this.paymentdatetimeDataGridViewTextBoxColumn.Name = "paymentdatetimeDataGridViewTextBoxColumn";
            this.paymentdatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentdatetimeDataGridViewTextBoxColumn.Width = 65;
            // 
            // paymentdiscriptionDataGridViewTextBoxColumn
            // 
            this.paymentdiscriptionDataGridViewTextBoxColumn.DataPropertyName = "payment_discription";
            this.paymentdiscriptionDataGridViewTextBoxColumn.HeaderText = "التعليق";
            this.paymentdiscriptionDataGridViewTextBoxColumn.Name = "paymentdiscriptionDataGridViewTextBoxColumn";
            this.paymentdiscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.contractorDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // payment_client_idComboBox
            // 
            this.payment_client_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentsBindingSource, "payment_client_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_client_idComboBox.DataSource = this.clientsBindingSource;
            this.payment_client_idComboBox.DisplayMember = "client_name";
            this.payment_client_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_client_idComboBox.FormattingEnabled = true;
            this.payment_client_idComboBox.Location = new System.Drawing.Point(505, 85);
            this.payment_client_idComboBox.Name = "payment_client_idComboBox";
            this.payment_client_idComboBox.Size = new System.Drawing.Size(209, 32);
            this.payment_client_idComboBox.TabIndex = 1;
            this.payment_client_idComboBox.ValueMember = "client_id";
            // 
            // payment_project_idComboBox
            // 
            this.payment_project_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentsBindingSource, "payment_project_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_project_idComboBox.DataSource = this.projectsBindingSource;
            this.payment_project_idComboBox.DisplayMember = "project_name";
            this.payment_project_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_project_idComboBox.FormattingEnabled = true;
            this.payment_project_idComboBox.Location = new System.Drawing.Point(12, 85);
            this.payment_project_idComboBox.Name = "payment_project_idComboBox";
            this.payment_project_idComboBox.Size = new System.Drawing.Size(224, 32);
            this.payment_project_idComboBox.TabIndex = 3;
            this.payment_project_idComboBox.ValueMember = "project_id";
            // 
            // payment_amountNumericUpDown
            // 
            this.payment_amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentsBindingSource, "payment_amount", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_amountNumericUpDown.DecimalPlaces = 2;
            this.payment_amountNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_amountNumericUpDown.Location = new System.Drawing.Point(849, 85);
            this.payment_amountNumericUpDown.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.payment_amountNumericUpDown.Name = "payment_amountNumericUpDown";
            this.payment_amountNumericUpDown.Size = new System.Drawing.Size(132, 32);
            this.payment_amountNumericUpDown.TabIndex = 0;
            // 
            // payment_discriptionTextBox
            // 
            this.payment_discriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_discriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentsBindingSource, "payment_discription", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_discriptionTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_discriptionTextBox.Location = new System.Drawing.Point(455, 126);
            this.payment_discriptionTextBox.Name = "payment_discriptionTextBox";
            this.payment_discriptionTextBox.Size = new System.Drawing.Size(526, 32);
            this.payment_discriptionTextBox.TabIndex = 4;
            // 
            // payment_type_idComboBox
            // 
            this.payment_type_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentsBindingSource, "payment_type_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_type_idComboBox.DataSource = this.paymenttypeBindingSource;
            this.payment_type_idComboBox.DisplayMember = "payment_type_name";
            this.payment_type_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_type_idComboBox.FormattingEnabled = true;
            this.payment_type_idComboBox.Location = new System.Drawing.Point(313, 85);
            this.payment_type_idComboBox.Name = "payment_type_idComboBox";
            this.payment_type_idComboBox.Size = new System.Drawing.Size(136, 32);
            this.payment_type_idComboBox.TabIndex = 2;
            this.payment_type_idComboBox.ValueMember = "payment_type_id";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // payment_typeTableAdapter
            // 
            this.payment_typeTableAdapter.ClearBeforeFill = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 123);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(150, 37);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(313, 123);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(136, 37);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.AddPaymentBtn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(168, 123);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(139, 37);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "تعديل";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 666);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(payment_client_idLabel);
            this.Controls.Add(this.payment_client_idComboBox);
            this.Controls.Add(payment_project_idLabel);
            this.Controls.Add(this.payment_project_idComboBox);
            this.Controls.Add(payment_amountLabel);
            this.Controls.Add(this.payment_amountNumericUpDown);
            this.Controls.Add(payment_discriptionLabel);
            this.Controls.Add(this.payment_discriptionTextBox);
            this.Controls.Add(payment_type_idLabel);
            this.Controls.Add(this.payment_type_idComboBox);
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "payment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدفعات المالية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.payment_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.payment_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private ContractorDataSet contractorDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private ContractorDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.ComboBox payment_client_idComboBox;
        private System.Windows.Forms.ComboBox payment_project_idComboBox;
        private System.Windows.Forms.NumericUpDown payment_amountNumericUpDown;
        private System.Windows.Forms.TextBox payment_discriptionTextBox;
        private System.Windows.Forms.ComboBox payment_type_idComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ContractorDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private ContractorDataSetTableAdapters.projectsTableAdapter projectsTableAdapter;
        private System.Windows.Forms.BindingSource paymenttypeBindingSource;
        private ContractorDataSetTableAdapters.payment_typeTableAdapter payment_typeTableAdapter;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentuseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentclientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymenttypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentprojectidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdiscriptionDataGridViewTextBoxColumn;
    }
}

