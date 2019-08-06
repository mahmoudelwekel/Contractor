namespace Contractor
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.daydatelbl = new System.Windows.Forms.Label();
            this.notificationBtn = new System.Windows.Forms.PictureBox();
            this.usersprivilageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContractorDataSet = new Contractor.ContractorDataSet();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.statistics = new System.Windows.Forms.PictureBox();
            this.sitting = new System.Windows.Forms.PictureBox();
            this.clients = new System.Windows.Forms.PictureBox();
            this.users = new System.Windows.Forms.PictureBox();
            this.payment_type = new System.Windows.Forms.PictureBox();
            this.payment = new System.Windows.Forms.PictureBox();
            this.projects = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersprivilegesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_privilegesTableAdapter = new Contractor.ContractorDataSetTableAdapters.users_privilageTableAdapter();
            this.projectsViewTableAdapter = new Contractor.ContractorDataSetTableAdapters.ProjectsViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilegesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(728, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "لوحة التحكم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // daydatelbl
            // 
            this.daydatelbl.AutoSize = true;
            this.daydatelbl.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daydatelbl.Location = new System.Drawing.Point(240, 37);
            this.daydatelbl.Name = "daydatelbl";
            this.daydatelbl.Size = new System.Drawing.Size(0, 26);
            this.daydatelbl.TabIndex = 82;
            // 
            // notificationBtn
            // 
            this.notificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationBtn.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "notifications", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.notificationBtn.Enabled = false;
            this.notificationBtn.Image = global::Contractor.Properties.Resources._13;
            this.notificationBtn.Location = new System.Drawing.Point(164, 12);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(70, 77);
            this.notificationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notificationBtn.TabIndex = 64;
            this.notificationBtn.TabStop = false;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // usersprivilageBindingSource
            // 
            this.usersprivilageBindingSource.DataMember = "users_privilage";
            this.usersprivilageBindingSource.DataSource = this.ContractorDataSet;
            // 
            // ContractorDataSet
            // 
            this.ContractorDataSet.DataSetName = "ContractorDataSet";
            this.ContractorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Contractor.Properties.Resources.CopyRight;
            this.pictureBox3.Location = new System.Drawing.Point(0, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // statistics
            // 
            this.statistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statistics.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statistics.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "statistics", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.statistics.Enabled = false;
            this.statistics.Image = global::Contractor.Properties.Resources.التقارير;
            this.statistics.Location = new System.Drawing.Point(717, 137);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(271, 283);
            this.statistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statistics.TabIndex = 63;
            this.statistics.TabStop = false;
            this.statistics.Click += new System.EventHandler(this.statistics_Click);
            this.statistics.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.statistics.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // sitting
            // 
            this.sitting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sitting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sitting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sitting.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "sittings", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.sitting.Enabled = false;
            this.sitting.Image = global::Contractor.Properties.Resources._12;
            this.sitting.Location = new System.Drawing.Point(515, 137);
            this.sitting.Name = "sitting";
            this.sitting.Size = new System.Drawing.Size(196, 208);
            this.sitting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sitting.TabIndex = 62;
            this.sitting.TabStop = false;
            this.sitting.Click += new System.EventHandler(this.sittings_Click);
            this.sitting.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.sitting.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // clients
            // 
            this.clients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clients.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clients.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "clients", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.clients.Enabled = false;
            this.clients.Image = global::Contractor.Properties.Resources.clients;
            this.clients.Location = new System.Drawing.Point(717, 426);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(271, 220);
            this.clients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clients.TabIndex = 62;
            this.clients.TabStop = false;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            this.clients.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.clients.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // users
            // 
            this.users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.users.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "users", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.users.Enabled = false;
            this.users.Image = global::Contractor.Properties.Resources.المستخدمين;
            this.users.Location = new System.Drawing.Point(515, 351);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(196, 295);
            this.users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.users.TabIndex = 62;
            this.users.TabStop = false;
            this.users.Click += new System.EventHandler(this.users_Click);
            this.users.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.users.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // payment_type
            // 
            this.payment_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payment_type.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.payment_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payment_type.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "payments_type", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_type.Enabled = false;
            this.payment_type.Image = global::Contractor.Properties.Resources.payment_type;
            this.payment_type.Location = new System.Drawing.Point(255, 394);
            this.payment_type.Name = "payment_type";
            this.payment_type.Size = new System.Drawing.Size(230, 252);
            this.payment_type.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payment_type.TabIndex = 62;
            this.payment_type.TabStop = false;
            this.payment_type.Click += new System.EventHandler(this.payment_type_Click);
            this.payment_type.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.payment_type.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // payment
            // 
            this.payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payment.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "payments", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment.Enabled = false;
            this.payment.Image = global::Contractor.Properties.Resources.payment;
            this.payment.Location = new System.Drawing.Point(12, 137);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(473, 251);
            this.payment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payment.TabIndex = 62;
            this.payment.TabStop = false;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            this.payment.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.payment.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // projects
            // 
            this.projects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projects.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projects.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "projects", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.projects.Enabled = false;
            this.projects.Image = global::Contractor.Properties.Resources.projects;
            this.projects.Location = new System.Drawing.Point(12, 394);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(237, 252);
            this.projects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.projects.TabIndex = 61;
            this.projects.TabStop = false;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            this.projects.MouseLeave += new System.EventHandler(this.salesbill_MouseLeave);
            this.projects.MouseHover += new System.EventHandler(this.salesbill_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Contractor.Properties.Resources.بيانات_الشركة;
            this.pictureBox2.Location = new System.Drawing.Point(88, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Contractor.Properties.Resources._19;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.logout_Click);
            // 
            // usersprivilegesBindingSource
            // 
            this.usersprivilegesBindingSource.DataMember = "users_privilage";
            // 
            // users_privilegesTableAdapter
            // 
            this.users_privilegesTableAdapter.ClearBeforeFill = true;
            // 
            // projectsViewTableAdapter
            // 
            this.projectsViewTableAdapter.ClearBeforeFill = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.daydatelbl);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.sitting);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.users);
            this.Controls.Add(this.payment_type);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.notificationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilegesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox projects;
        private System.Windows.Forms.PictureBox statistics;
        private System.Windows.Forms.PictureBox payment;
        private System.Windows.Forms.PictureBox users;
        private System.Windows.Forms.PictureBox clients;
        private System.Windows.Forms.PictureBox sitting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox notificationBtn;
        private System.Windows.Forms.PictureBox payment_type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label daydatelbl;
        private System.Windows.Forms.BindingSource usersprivilegesBindingSource;
        private ContractorDataSet ContractorDataSet;
        private ContractorDataSetTableAdapters.users_privilageTableAdapter users_privilegesTableAdapter;
        private System.Windows.Forms.BindingSource usersprivilageBindingSource;
        private ContractorDataSetTableAdapters.ProjectsViewTableAdapter projectsViewTableAdapter;
    }
}

