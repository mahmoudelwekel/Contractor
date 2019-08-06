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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }


        DateTime 
            datefrom = Convert.ToDateTime( DateTime.Now.ToShortDateString() + " 00:00:00"),       
            dateto   = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 23:59:59");

        private void payment_Load(object sender, EventArgs e)
        {
            
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                ClearAll();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }
        private void ClearAll()
        {
            try
            {

                this.projectsTableAdapter.Fill(this.contractorDataSet.projects);
                this.clientsTableAdapter.ActiveClients(this.contractorDataSet.clients);
                this.payment_typeTableAdapter.Fill(this.contractorDataSet.payment_type);
                this.paymentsTableAdapter.TodayPayment(this.contractorDataSet.payments, int.Parse(LoginInfo.id), datefrom, dateto);

                payment_amountNumericUpDown.Value = 0;
                payment_discriptionTextBox.Clear();

                paymentDataGridView.ClearSelection();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        
        private void AddPaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (payment_amountNumericUpDown.Value != 0)
                { 
                    this.paymentsTableAdapter.Insert(int.Parse(LoginInfo.id), (int)payment_client_idComboBox.SelectedValue, (int)payment_project_idComboBox.SelectedValue, payment_amountNumericUpDown.Value, DateTime.Now, payment_discriptionTextBox.Text, (int)payment_type_idComboBox.SelectedValue);
                    MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearAll();
                }

            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                DialogResult result = MessageBox.Show("هل أنت متأكد ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow product = null;
                    if (paymentDataGridView.SelectedRows.Count != 0)
                    {
                        product = paymentDataGridView.SelectedRows[0];
                    }
                    else { return; }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());
                        this.paymentsTableAdapter.Delete(id);
                        MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ClearAll();
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }






















        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                ClearAll();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                home home = new home();
                home.Show();
                this.Hide(); /*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void payment_MouseDown(object sender, MouseEventArgs e)
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
