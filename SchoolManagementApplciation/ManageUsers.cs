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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        private void bnsubmit_Click(System.Object sender, System.EventArgs e)
        {
            if (txtpass.Text == "" | txtrepass.Text == "" | txtsecurity.Text == "" | txtusername.Text == "")
            {
                MessageBox.Show("Please fill up The above fields","Info", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (txtpass.Text != txtrepass.Text)
            {
                MessageBox.Show("Your password and confirmation password does not match", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtsecurity.Text != "vinu")
            {
                MessageBox.Show("Your authentication password does not match", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlControl sql = new SqlControl();
            sql.addprams("@name", txtusername.Text);
            sql.ExecSql("select *From users where username =@name");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            if (sql.count != 0)
            {
                MessageBox.Show("There is already a user with that name please select a different username!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlControl sql1 = new SqlControl();
            sql1.addprams("@name", txtfullname.Text);
            sql1.addprams("@user", txtusername.Text);
            sql1.addprams("@pass", txtpass.Text);
            sql1.addprams("@pic", PictureBox1.ImageLocation);
            sql1.ExecSql("insert into Users(name,pass,picture,username) values(@user,@pass,@pic,@user)");
            if (sql1.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            MessageBox.Show("The new User Details hav been added to the database :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtfullname.Clear();
            txtpass.Clear();
            txtrepass.Clear();
            txtsecurity.Clear();
            txtusername.Clear();
            PictureBox1.Image = null;
            txtusername.Focus();
            ManageUsers_Load(sender, e);
        }

        private void bndelete_Click(System.Object sender, System.EventArgs e)
        {
            if (lstusernames.Text == "")
            {
                MessageBox.Show("Please Slect a Username from the above list box first :) ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (lstusernames.Items.Count == 1)
            {
                MessageBox.Show("You cannt delete this user because you need atleast 1 user to log in the software!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlControl sql = new SqlControl();
            sql.addprams("@user", lstusernames.Text);
            sql.ExecSql("delete from users where username = @user");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            ManageUsers_Load(sender, e);
        }

        private void ManageUsers_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676551_add_user);
            SqlControl sql = new SqlControl();
            sql.ExecSql("Select username from users order by username asc");
            lstusernames.Items.Clear();
            if (sql.count != 0)
            {
                var loopTo = sql.count;
                for (var j = 1; j <= loopTo; j++)
                    lstusernames.Items.Add(sql.data.Tables[0].Rows[j - 1]["username"]);
            }
        }

        private void bnload_Click(System.Object sender, System.EventArgs e)
        {
            {
                var withBlock = OpenFileDialog1;
                withBlock.Title = "Select a Jpeg photo";
                withBlock.FileName = "";
                withBlock.Multiselect = false;
                withBlock.Filter = "Images Files| *.png; *.jpg; *.jpeg; *.bmp; *.gif;";
                withBlock.ShowDialog();
                if (withBlock.FileName == "")
                    return;
                else
                    try { PictureBox1.Load(Utils.SaveImageToApplicationFolder(withBlock.FileName)); } catch (Exception ex) { MessageBox.Show("Please select an image", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void bnclear_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                PictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
