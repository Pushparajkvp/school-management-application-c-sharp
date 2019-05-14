using Newtonsoft.Json;
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
    public partial class ManageTeacher : Form
    {
        public ManageTeacher()
        {
            InitializeComponent();
        }

        private SqlControl sql = new SqlControl();
        private BindingSource bind = new BindingSource();
        private void ManageTeacher_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676422_Teacher_male_24);
            sql.addprams("@name", TextBox1.Text);
            sql.ExecSql("Select * from dbo.teacher_show(@name)");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }


        private void TextBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            sql.addprams("@name", TextBox1.Text);
            sql.ExecSql("Select * from dbo.teacher_show(@name)");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void bndelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                sql.addprams("@name", DataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("select * from teacher T left join gender G on G.id = T.gender left join designation D on D.id = T.designation where T.name = @name");
                string data = JsonConvert.SerializeObject(sql.data);
                sql.addprams("@data", data);
                sql.ExecSql("insert into archive(date,data) values(GETDATE(),@data);");
                sql.addprams("@name", DataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("delete from teacher where name = @name");
                if (sql.exep != "")
                    MessageBox.Show(sql.exep);
                MessageBox.Show("The Seleteced Student's details where deleted !","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ManageTeacher_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Operation could not be performed because you didnt select a Teacher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        public void bnrefresh_Click(System.Object sender, System.EventArgs e)
        {
            ManageTeacher_Load(sender, e);
        }
        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Bnadd_Click(object sender, EventArgs e)
        {
            ((MainInterface)this.MdiParent).AddTeacher.CreateOrShow();
            ManageTeacher_Load(sender, e);
        }
    }
}
