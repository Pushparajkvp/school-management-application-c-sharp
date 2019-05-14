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
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }
        private SqlControl sql = new SqlControl();
        private BindingSource bind = new BindingSource();

        public void ManageStudents_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676203_graduation);
            sql.ExecSql("select * from dbo.show_stud()");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);

            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void txtsearch_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (txtsearch.Text == "")
                ManageStudents_Load(sender, e);
            else
            {
                sql.addprams("@name", txtsearch.Text);
                sql.ExecSql("select * from dbo.show_studs(@name)");
                if (sql.exep != "")
                    MessageBox.Show(sql.exep);

                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
            }
        }

        private void bnnew_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).AddStudent.CreateOrShow();
            ManageStudents_Load(sender, e);
        }

        public void bnrefresh_Click(System.Object sender, System.EventArgs e)
        {
            ManageStudents_Load(sender, e);
        }

        private void bndelete_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                sql.addprams("@name", DataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("select * from students S left join gender G on S.gender = g.id left join class C on S.class = C.id where S.name = @name");
                string data = JsonConvert.SerializeObject(sql.data);
                sql.addprams("@data", data);
                sql.ExecSql("insert into archive(date,data) values(GETDATE(),@data);");
                sql.addprams("@name", DataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("delete from students where name = @name");
                if (sql.exep != "")
                    MessageBox.Show(sql.exep);
                MessageBox.Show("The Seleteced Student's details where deleted !","Complete", MessageBoxButtons.OK,MessageBoxIcon.Information);
                ManageStudents_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Operation could not be performed because you didnt select a Student!","No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }
        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            sql.addprams("@id", DataGridView1.CurrentRow.Cells[0].Value);
            sql.ExecSql("Select id from students where id = dbo.getid(@id)");
            if (sql.count > 0)
                _StudentIdToEdit = (int)sql.data.Tables[0].Rows[0]["id"];
            ((MainInterface)this.MdiParent).Edits.CreateOrShow();
        }
        private int _StudentIdToEdit;
        public int StudentIdToEdit
        {
            get
            {
                return _StudentIdToEdit;
            }
        }
    }
}
