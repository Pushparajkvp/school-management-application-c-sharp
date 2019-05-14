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
    public partial class ManageServices : Form
    {
        public ManageServices()
        {
            InitializeComponent();
        }

        SqlControl sql = new SqlControl();
        private BindingSource bind = new BindingSource();
        public void ManageServices_Load(object sender, EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources.gear_icon);
            sql.ExecSql("select services.id as ID, services.name as Name, recurnames.name as [Frequency], amount as [Amount] from services left join recurnames on recurnames.id = services.recur");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);

            bind.DataSource = sql.data.Tables[0];
            dataGridView1.DataSource = bind;
            dataGridView1.Columns["ID"].Visible = false;
        }
        private void Btnadd_Click(object sender, EventArgs e)
        {
            ((MainInterface)this.MdiParent).AddService.CreateOrShow();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deleting service will remove this service from all students. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            try
            {
                sql.addprams("@id", (int)dataGridView1.CurrentRow.Cells[0].Value);
                sql.ExecSql("delete from services where id = @id");
                if (sql.exep != "")
                    MessageBox.Show(sql.exep);
                MessageBox.Show("The Seleteced Student's details where deleted !", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageServices_Load(sender, e);
                ((MainInterface)this.MdiParent).Services.Cboname_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Operation could not be performed because you didnt select a Student!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
        }

        private void Txtsearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Name like '%" + txtsearch.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        
    }
}
