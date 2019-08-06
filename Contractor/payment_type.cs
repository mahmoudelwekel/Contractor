using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contractor
{
    public partial class payment_type : Form
    {
        public payment_type()
        {
            InitializeComponent();

        }


        public void clear_all()
        {
            try
            {
                // TODO: This line of code loads data into the 'contractorDataSet.payment_type' table. You can move, or remove it, as needed.
                this.payment_typeTableAdapter.Fill(this.contractorDataSet.payment_type);

                payment_type_nameTextBox.Clear();
                payment_type_descripTextBox.Clear();

                dataGridView1.ClearSelection();

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                home ob = new home();
                ob.Show();
                this.Hide(); /*this.Dispose();*/

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void sizes_Load(object sender, EventArgs e)
        {

            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");


                typelist.DisplayMember = "Text";
                typelist.ValueMember = "Value";
                paymenttypeoperatorDataGridViewTextBoxColumn.DisplayMember = "Text";
                paymenttypeoperatorDataGridViewTextBoxColumn.ValueMember = "Value";

                var items = new[] {
                    new { Text = "واردات", Value = Convert.ToInt16( "1") },
                    new { Text = "مصروفات", Value = Convert.ToInt16( "-1") }
                    };

                typelist.DataSource = items;
                paymenttypeoperatorDataGridViewTextBoxColumn.DataSource = items;


                clear_all();
                this.BringToFront();
                this.Activate();

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void addsizebtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (payment_type_nameTextBox.Text != ""&& payment_type_nameTextBox.Text != null&& payment_type_nameTextBox.Text != string.Empty)
                {

                    this.payment_typeTableAdapter.Insert(payment_type_nameTextBox.Text, payment_type_descripTextBox.Text, Convert.ToInt16(typelist.SelectedValue));
                    MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear_all();
                }

            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void editsizebtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                DialogResult result = MessageBox.Show("هل أنت متأكد ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow product = null;
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        product = dataGridView1.SelectedRows[0];
                    }
                    else { return; }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());

                        this.payment_typeTableAdapter.Update(payment_type_nameTextBox.Text, payment_type_descripTextBox.Text, Convert.ToInt16(typelist.SelectedValue), id);

                        MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clear_all();
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void searchsizetxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.payment_typeTableAdapter.Search(this.contractorDataSet.payment_type, searchsizetxt.Text);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void deletesizebtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                DialogResult result = MessageBox.Show("هل أنت متأكد ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow product = null;
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        product = dataGridView1.SelectedRows[0];
                    }
                    else { return; }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());
                        this.payment_typeTableAdapter.Delete(id);
                        MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clear_all();
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
            clear_all();
        }

        private void sizes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                }

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        
    }
}
