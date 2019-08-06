namespace Contractor
{
    partial class payment_type
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
            System.Windows.Forms.Label payment_type_nameLabel;
            System.Windows.Forms.Label payment_type_descripLabel;
            System.Windows.Forms.Label payment_type_operatorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment_type));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymenttypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenttypeoperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymenttypedescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorDataSet = new Contractor.ContractorDataSet();
            this.searchsizetxt = new System.Windows.Forms.TextBox();
            this.payment_typeTableAdapter = new Contractor.ContractorDataSetTableAdapters.payment_typeTableAdapter();
            this.payment_type_nameTextBox = new System.Windows.Forms.TextBox();
            this.payment_type_descripTextBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.typelist = new System.Windows.Forms.ComboBox();
            payment_type_nameLabel = new System.Windows.Forms.Label();
            payment_type_descripLabel = new System.Windows.Forms.Label();
            payment_type_operatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_type_nameLabel
            // 
            payment_type_nameLabel.AutoSize = true;
            payment_type_nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_type_nameLabel.Location = new System.Drawing.Point(14, 85);
            payment_type_nameLabel.Name = "payment_type_nameLabel";
            payment_type_nameLabel.Size = new System.Drawing.Size(47, 26);
            payment_type_nameLabel.TabIndex = 9;
            payment_type_nameLabel.Text = "الأسم";
            // 
            // payment_type_descripLabel
            // 
            payment_type_descripLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_type_descripLabel.AutoSize = true;
            payment_type_descripLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_type_descripLabel.Location = new System.Drawing.Point(481, 85);
            payment_type_descripLabel.Name = "payment_type_descripLabel";
            payment_type_descripLabel.Size = new System.Drawing.Size(57, 26);
            payment_type_descripLabel.TabIndex = 11;
            payment_type_descripLabel.Text = "الوصف";
            // 
            // payment_type_operatorLabel
            // 
            payment_type_operatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_type_operatorLabel.AutoSize = true;
            payment_type_operatorLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_type_operatorLabel.Location = new System.Drawing.Point(287, 85);
            payment_type_operatorLabel.Name = "payment_type_operatorLabel";
            payment_type_operatorLabel.Size = new System.Drawing.Size(66, 26);
            payment_type_operatorLabel.TabIndex = 10;
            payment_type_operatorLabel.Text = "التصنيف";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(869, 119);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 37);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.Click += new System.EventHandler(this.deletesizebtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(544, 120);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(153, 37);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "أضافة";
            this.addBtn.Click += new System.EventHandler(this.addsizebtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(703, 120);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(160, 37);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "تعديل";
            this.editBtn.Click += new System.EventHandler(this.editsizebtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "أنواع الدفعات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(16, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 26);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "البحث";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymenttypeidDataGridViewTextBoxColumn,
            this.paymenttypenameDataGridViewTextBoxColumn,
            this.paymenttypeoperatorDataGridViewTextBoxColumn,
            this.paymenttypedescripDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.DataSource = this.payment_typeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(23, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 409);
            this.dataGridView1.TabIndex = 7;
            // 
            // paymenttypeidDataGridViewTextBoxColumn
            // 
            this.paymenttypeidDataGridViewTextBoxColumn.DataPropertyName = "payment_type_id";
            this.paymenttypeidDataGridViewTextBoxColumn.HeaderText = "payment_type_id";
            this.paymenttypeidDataGridViewTextBoxColumn.Name = "paymenttypeidDataGridViewTextBoxColumn";
            this.paymenttypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymenttypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymenttypenameDataGridViewTextBoxColumn
            // 
            this.paymenttypenameDataGridViewTextBoxColumn.DataPropertyName = "payment_type_name";
            this.paymenttypenameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.paymenttypenameDataGridViewTextBoxColumn.Name = "paymenttypenameDataGridViewTextBoxColumn";
            this.paymenttypenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymenttypeoperatorDataGridViewTextBoxColumn
            // 
            this.paymenttypeoperatorDataGridViewTextBoxColumn.DataPropertyName = "payment_type_operator";
            this.paymenttypeoperatorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymenttypeoperatorDataGridViewTextBoxColumn.HeaderText = "التصنيف";
            this.paymenttypeoperatorDataGridViewTextBoxColumn.Name = "paymenttypeoperatorDataGridViewTextBoxColumn";
            this.paymenttypeoperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymenttypeoperatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymenttypeoperatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // paymenttypedescripDataGridViewTextBoxColumn
            // 
            this.paymenttypedescripDataGridViewTextBoxColumn.DataPropertyName = "payment_type_descrip";
            this.paymenttypedescripDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.paymenttypedescripDataGridViewTextBoxColumn.Name = "paymenttypedescripDataGridViewTextBoxColumn";
            this.paymenttypedescripDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payment_typeBindingSource
            // 
            this.payment_typeBindingSource.DataMember = "payment_type";
            this.payment_typeBindingSource.DataSource = this.contractorDataSet;
            // 
            // contractorDataSet
            // 
            this.contractorDataSet.DataSetName = "ContractorDataSet";
            this.contractorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchsizetxt
            // 
            this.searchsizetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchsizetxt.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchsizetxt.Location = new System.Drawing.Point(67, 122);
            this.searchsizetxt.Name = "searchsizetxt";
            this.searchsizetxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchsizetxt.Size = new System.Drawing.Size(408, 32);
            this.searchsizetxt.TabIndex = 3;
            this.searchsizetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchsizetxt.TextChanged += new System.EventHandler(this.searchsizetxt_TextChanged);
            // 
            // payment_typeTableAdapter
            // 
            this.payment_typeTableAdapter.ClearBeforeFill = true;
            // 
            // payment_type_nameTextBox
            // 
            this.payment_type_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_type_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_typeBindingSource, "payment_type_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_type_nameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_type_nameTextBox.Location = new System.Drawing.Point(67, 82);
            this.payment_type_nameTextBox.Name = "payment_type_nameTextBox";
            this.payment_type_nameTextBox.Size = new System.Drawing.Size(214, 32);
            this.payment_type_nameTextBox.TabIndex = 0;
            // 
            // payment_type_descripTextBox
            // 
            this.payment_type_descripTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_type_descripTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_typeBindingSource, "payment_type_descrip", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_type_descripTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_type_descripTextBox.Location = new System.Drawing.Point(544, 82);
            this.payment_type_descripTextBox.Name = "payment_type_descripTextBox";
            this.payment_type_descripTextBox.Size = new System.Drawing.Size(485, 32);
            this.payment_type_descripTextBox.TabIndex = 2;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Image = global::Contractor.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(398, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshBtn.TabIndex = 129;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::Contractor.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(454, 17);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(50, 50);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtn.TabIndex = 67;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // typelist
            // 
            this.typelist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.typelist.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.payment_typeBindingSource, "payment_type_operator", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.typelist.DisplayMember = "client_name";
            this.typelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typelist.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typelist.FormattingEnabled = true;
            this.typelist.Location = new System.Drawing.Point(359, 82);
            this.typelist.Name = "typelist";
            this.typelist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typelist.Size = new System.Drawing.Size(116, 32);
            this.typelist.TabIndex = 130;
            this.typelist.ValueMember = "client_id";
            // 
            // payment_type
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 595);
            this.ControlBox = false;
            this.Controls.Add(this.typelist);
            this.Controls.Add(payment_type_nameLabel);
            this.Controls.Add(this.payment_type_nameTextBox);
            this.Controls.Add(payment_type_descripLabel);
            this.Controls.Add(this.payment_type_descripTextBox);
            this.Controls.Add(payment_type_operatorLabel);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.searchsizetxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "payment_type";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انواع الدفعات المالية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sizes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sizes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
        private  System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchsizetxt;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private ContractorDataSet contractorDataSet;
        private System.Windows.Forms.BindingSource payment_typeBindingSource;
        private ContractorDataSetTableAdapters.payment_typeTableAdapter payment_typeTableAdapter;
        private System.Windows.Forms.TextBox payment_type_nameTextBox;
        private System.Windows.Forms.TextBox payment_type_descripTextBox;
        private System.Windows.Forms.ComboBox typelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymenttypeoperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenttypedescripDataGridViewTextBoxColumn;
    }
}