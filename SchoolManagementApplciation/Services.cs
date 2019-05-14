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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }
        private SqlControl sql = new SqlControl();
        private BindingSource bind = new BindingSource();
        private void Services_Load(object sender, EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources.gear_icon);
            Grpdetails.Visible = false;
            dataGridView1.Visible = false;
            btndeleteassociation.Visible = false; 
            button1.Visible = false;
            label3.Visible = false;
            sql.ExecSql("Select name as [Student],id as [Id] from students");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                StudentId obj = new StudentId();
                obj.ID = (int)r["Id"];
                obj.Name = r["Student"].ToString();
                cboname.Items.Add(obj);
            }
            

        }

        public void Cboname_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql.addprams("@name", cboname.Text);
            sql.ExecSql("select * from dbo.show_students(@name)");
            if (sql.exep != "")
            {

                MessageBox.Show(sql.exep);
                return;
            }

            if (sql.count != 0)
            {
                Grpdetails.Visible = true;
                picbox.ImageLocation = sql.data.Tables[0].Rows[0]["pic"].ToString();
                lblage.Text = sql.data.Tables[0].Rows[0]["age"].ToString();
                lblclass.Text = sql.data.Tables[0].Rows[0]["Class"].ToString();
                lblname.Text = sql.data.Tables[0].Rows[0]["Student Name"].ToString();
                lblsection.Text = sql.data.Tables[0].Rows[0]["Section"].ToString();
                lbldue.Text = sql.data.Tables[0].Rows[0]["due"].ToString();
            }
            sql.addprams("@name", cboname.Text);
            sql.ExecSql("select sub.id as ID,serv.name as Name,recur.name as Frequency,serv.amount as Amount from subscriptions as sub left join services as serv on serv.id = sub.service_id left join recurnames as recur on recur.id = serv.recur left join students as stu on stu.id=sub.student_id where stu.name = @name");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            dataGridView1.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            btndeleteassociation.Visible = true;
            bind.DataSource = sql.data.Tables[0];
            dataGridView1.DataSource = bind;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ((MainInterface)this.MdiParent).AssociateService.CreateOrShow();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ((MainInterface)this.MdiParent).ManageServices.CreateOrShow();
        }
        public int GetStudentId()
        {
            return ((StudentId)cboname.SelectedItem).ID;
        }
        private class StudentId
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void Btndeleteassociation_Click(object sender, EventArgs e)
        {
            try
            {
                sql.addprams("@id", (int)dataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("delete from subscriptions where id = @id");
                if (sql.exep != "")
                    MessageBox.Show(sql.exep);
                MessageBox.Show("The Seleteced Student's details where deleted !", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cboname_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Operation could not be performed because you didnt select a Student!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

        private void Butedit_Click(object sender, EventArgs e)
        {
            txtdue.Visible = true;
            lbldue.Visible = false;
            txtdue.Focus();
        }

        private void Txtdue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlControl sql = new SqlControl();
                sql.addprams("@name", cboname.Text);
                sql.addprams("@due", double.Parse(txtdue.Text));
                sql.ExecSql("update students set due = @due where name = @name");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                txtdue.Visible = false;
                lbldue.Visible = true;
                Cboname_SelectedIndexChanged(sender, e);
            }
        }
    }
}
