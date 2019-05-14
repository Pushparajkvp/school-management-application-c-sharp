using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagementApplciation
{
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
            cbofreq.SelectedIndex = 0;
        }
        SqlControl sql = new SqlControl();

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtserviceamount.Text == "" || txtservicename.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Fields Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sql.addprams("@name", txtservicename.Text);
            sql.addprams("@recur", cbofreq.SelectedIndex + 1);
            sql.addprams("@amount", double.Parse(txtserviceamount.Text));
            sql.ExecSql("insert into services(name,recur,amount) values(@name,@recur,@amount)");
            MessageBox.Show("Service Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((MainInterface)this.MdiParent).ManageServices.ManageServices_Load(sender, e);
            this.Close();
        }
    }
}
