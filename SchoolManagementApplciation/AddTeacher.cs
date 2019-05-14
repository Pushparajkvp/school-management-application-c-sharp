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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }
        private SqlControl sql = new SqlControl();
        private void bnclear_Click(System.Object sender, System.EventArgs e)
        {
            imageT.Image = null;
        }

        private void bnload_Click(System.Object sender, System.EventArgs e)
        {
            {
                var withBlock = OpenFileDialog1;
                withBlock.Title = "Load Teacher's Photo ";
                withBlock.Multiselect = false;
                withBlock.FileName = "";
                withBlock.Filter = "Images Files| *.png; *.jpg; *.jpeg; *.bmp; *.gif;";
                withBlock.ShowDialog();
                if (withBlock.FileName == "")
                    return;
                else
                    try { imageT.Load(Utils.SaveImageToApplicationFolder(withBlock.FileName)); } catch (Exception ex) { MessageBox.Show("Please select an image", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void bnsave_Click(System.Object sender, System.EventArgs e)
        {
            if (txtemail.Text == "" | txtfullname.Text == "" | txtphone.Text == "" | txtaddress.Text == "" | cbodesignation.Text == "" | cbogender.Text == "" | txtqua.Text == "")
            {
                MessageBox.Show("No fields must be left blank","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (long.Parse(txtphone.Text) < 10000000)
            {
               MessageBox.Show("Invalid Phone number!","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               return;
            }
            sql.addprams("@name", txtfullname.Text);
            sql.ExecSql("select name from teacher where name = @name");
            if (sql.count != 0)
            {
                MessageBox.Show("There is already a student with exact name please make a little adjustment to help the software :) ", "Same Full names", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql.addprams("@name", txtfullname.Text);
            sql.addprams("@gender", cbogender.SelectedIndex + 1);
            sql.addprams("@dob", DateTimePicker1.Value);
            sql.addprams("@desig", cbodesignation.Text);
            sql.addprams("@qua", txtqua.Text);
            sql.addprams("@add", txtaddress.Text);
            sql.addprams("@phone", txtphone.Text);
            sql.addprams("@email", txtemail.Text);
            sql.addprams("@fee", double.Parse(ComboBox1.Text));
            sql.addprams("@join", dtp.Value);
            sql.addprams("@pic", imageT.ImageLocation);
            sql.ExecProc("exec insert_teacher @name,@gender,@dob,@desig,@qua,@add,@phone,@email,@fee,@join,@pic");
            if (sql.exep != "")
            {
               MessageBox.Show(sql.exep);
                return;
            }
            MessageBox.Show("The details about the teacher is stored","Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            bnclear_Click(sender, e);
            ((MainInterface)this.MdiParent).ManageTeacher.bnrefresh_Click(sender,e);
            this.Close();
        }
        private void AddTeacher_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676422_Teacher_male_24);
            sql.ExecSql("Select name from designation");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cbodesignation.Items.Contains(r["name"]) == false)
                    cbodesignation.Items.Add(r["name"]);
            }
        }

        private void bnclearing_Click(System.Object sender, System.EventArgs e)
        {
            txtaddress.Clear();
            txtemail.Clear();
            txtfullname.Clear();
            txtphone.Clear();
            cbodesignation.Text = "";
            cbodesignation.Text = "";
            cbogender.Text = "";
            txtqua.Clear();
            ComboBox1.Text = "";
            imageT.Image = null;
        }

        private void txtphone_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (long.TryParse(txtphone.Text, out long result) == false)
                txtphone.Clear();
        }
    }
}
