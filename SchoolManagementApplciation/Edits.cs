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
    public partial class Edits : Form
    {
        public Edits()
        {
            InitializeComponent();
        }

        private SqlControl sql = new SqlControl();
        private int ids;
        private void Edits_Load(System.Object sender, System.EventArgs e)
        {
            sql.ExecSql("select distinct(class) as [class] from class");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboclass.Items.Contains(r["class"]) == false)
                    cboclass.Items.Add(r["class"]);
            }
            sql.ExecSql("select distinct(section) as [sec] from class");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cbostream.Items.Contains(r["sec"]) == false)
                    cbostream.Items.Add(r["sec"]);
            }
            ids = ((MainInterface)this.MdiParent).ManageStudents.StudentIdToEdit;

            sql.addprams("@id", ids);
            sql.ExecSql("select * from dbo.show_studing(@id)");

            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            if (sql.count > 0)
            {
                txtaddress.Text = sql.data.Tables[0].Rows[0]["address"].ToString();
                txtemail.Text = sql.data.Tables[0].Rows[0]["Email"].ToString();
                txtname.Text = sql.data.Tables[0].Rows[0]["Student Name"].ToString();
                txtphone.Text = sql.data.Tables[0].Rows[0]["Phone Number"].ToString();
                cboclass.Text = sql.data.Tables[0].Rows[0]["Class"].ToString();
                cbogender.Text = sql.data.Tables[0].Rows[0]["Gender"].ToString();
                cbostream.Text = sql.data.Tables[0].Rows[0]["Section"].ToString();
                PictureBox1.ImageLocation = sql.data.Tables[0].Rows[0]["pic"].ToString();
            }
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            {
                var withBlock = OpenFileDialog1;
                withBlock.Title = "Select a image";
                withBlock.FileName = "";
                withBlock.Multiselect = false;
                withBlock.Filter = "Images Files| *.png; *.jpg; *.jpeg; *.bmp; *.gif;";
                withBlock.ShowDialog();
                if (withBlock.FileName != "")
                    PictureBox1.Load(Utils.SaveImageToApplicationFolder(withBlock.FileName));
            }
        }

        private void Button2_Click(System.Object sender, System.EventArgs e)
        {
            PictureBox1.Image = null;
        }

        private void Button3_Click(System.Object sender, System.EventArgs e)
        {
            sql.addprams("@id", ids);
            sql.addprams("@name", txtname.Text);
            sql.addprams("@gender", cbogender.SelectedIndex + 1);
            sql.addprams("@add", txtaddress.Text);
            sql.addprams("@phone", txtphone.Text);
            sql.addprams("@class", cboclass.Text);
            sql.addprams("@section", cbostream.Text);
            sql.addprams("@email", txtemail.Text);
            sql.addprams("@pic", PictureBox1.ImageLocation);
            sql.ExecProc("exec Insert_studing @id,@name,@gender,@add,@phone,@class,@section,@email,@pic");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            MessageBox.Show("The Changes Has Been Made", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void Edits_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ((MainInterface)this.MdiParent).ManageStudents.ManageStudents_Load(sender, e);
            ((MainInterface)this.MdiParent).ManageStudents.txtsearch.Text = "";
        }
    }
}
