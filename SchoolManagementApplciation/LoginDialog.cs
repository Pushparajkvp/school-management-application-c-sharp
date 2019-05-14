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
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private SqlControl sql = new SqlControl();
        private void OK_Click(System.Object sender, System.EventArgs e)
        {
            if (UsernameTextBox.Text == "" | PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter your Username and password!", "Fields Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sql.addprams("@name", UsernameTextBox.Text);
            sql.addprams("@pass", PasswordTextBox.Text);
            sql.ExecSql("Select * from users where username = @name and pass = @pass");
            if (sql.count == 0)
            {
                MessageBox.Show("Invalid Username or Password", "Wrong info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                UsernameTextBox.Focus();
                return;
            }
            else
            {
                this.Hide();
                MainInterface mainInterface = new MainInterface();
                mainInterface.FormClosed += (s, args) => this.Close();
                mainInterface.Show();
            }
        }

        private void Cancel_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void LoginDialog_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676300_Login_Manager);
        }
    }
}
