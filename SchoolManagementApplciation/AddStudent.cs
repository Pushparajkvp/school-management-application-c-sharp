using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementApplciation
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private SqlControl sql = new SqlControl();

        private void AddStudent_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676551_add_user);
            cls();
        }

       
        private void bnclearpictue_Click(System.Object sender, System.EventArgs e)
        {
            PictureBox1.Image = null;
        }
        public void cls()
        {
            sql.ExecSql("select class as [class] ,section as [section] from class");
            if ( sql.exep != "")
            {
                MessageBox.Show(sql.exep,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboclass.Items.Contains(r["class"]) == false)
                    cboclass.Items.Add(r["class"]);
                if (cbostream.Items.Contains(r["section"]) == false)
                    cbostream.Items.Add(r["section"]);
            }
        }
        private void bnloadpicture_Click(System.Object sender, System.EventArgs e)
        {
            var withBlock = OpenFileDialog1;
            withBlock.Title = "Select a Jpeg image";
            withBlock.FileName = "";
            withBlock.Multiselect = false;
            withBlock.AddExtension = true;
            withBlock.Filter = "Images Files| *.png; *.jpg; *.jpeg; *.bmp; *.gif;";
            withBlock.ShowDialog();
            if (withBlock.FileName != "")
            {
                try
                {
                    PictureBox1.Load(Utils.SaveImageToApplicationFolder(withBlock.FileName));
                } catch(Exception ex)
                {
                    MessageBox.Show("Please select an image", "Invalid file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                    
           
        }
        private void bnsave_Click(System.Object sender, System.EventArgs e)
        {
            if (txtaddress.Text == "" | txtemail.Text == "" | txtfullname.Text == "" | txtphone.Text == "" | txtregno.Text == "" | cboclass.Text == "" | cbogender.Text == "" | cbostream.Text == "")
            {
                MessageBox.Show("No fields must be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                if (txtphone.Text.Length < 8)
                {
                    MessageBox.Show("The phone number is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sql.addprams("@name", txtfullname.Text);
            sql.ExecSql("select name from students where name = @name");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }

            if (sql.count != 0)
            {
                MessageBox.Show("There is already a student with exact name please add initial to the name", "Same Full names", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you all the student details are entered correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            sql.addprams("@name", txtfullname.Text);
            sql.addprams("@Fname", Ftxt.Text);
            sql.addprams("@Mname", Mtxt.Text);
            sql.addprams("@Rnum", txtregno.Text);
            sql.addprams("@date", dtp.Value);
            sql.addprams("@add", txtaddress.Text);
            sql.addprams("@phone",txtphone.Text);
            sql.addprams("@pic", PictureBox1.ImageLocation);
            sql.addprams("@email", txtemail.Text);
            sql.addprams("@gender", cbogender.SelectedIndex + 1);
            sql.addprams("@class", cboclass.Text);
            sql.addprams("@section", cbostream.Text);
            sql.ExecProc("exec Insert_class @gender,@name,@Fname,@Mname,@Rnum,@add,@phone,@pic,@email ,@date ,@class,@section");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            bnclear_Click(sender, e);
            MessageBox.Show("The Student is saved in vinu ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ManageStudents manageStudents = ((MainInterface)this.MdiParent).ManageStudents;
            if (manageStudents.IsHandleCreated)
                manageStudents.bnrefresh_Click(sender, e);
            this.Close();
        }
       
        private void txtphone_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (long.TryParse(txtphone.Text, out long result) == false)
                txtphone.Clear();
        }

        private void txtregno_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (int.TryParse(txtregno.Text, out int result) == false)
                txtregno.Clear();
        }
        private void bnclear_Click(System.Object sender, System.EventArgs e)
        {
            txtaddress.Clear();
            txtemail.Clear();
            txtfullname.Clear();
            txtphone.Clear();
            cboclass.Text = "";
            cbogender.Text = "";
            cbostream.Text = "";
            PictureBox1.Image = null;
            txtregno.Focus();
        }
    }
}
