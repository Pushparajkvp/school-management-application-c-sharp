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
    public partial class AssociateService : Form
    {
        public AssociateService()
        {
            InitializeComponent();
        }

        SqlControl sql = new SqlControl();
        private void Button1_Click(object sender, EventArgs e)
        {
            int studentId =((MainInterface)this.MdiParent).Services.GetStudentId();
            int serviceId = ((ServiceID)cboname.SelectedItem).Id;
            int type = -1;
            ServiceID selectedItem = (ServiceID)cboname.SelectedItem;
            if (selectedItem.recur == 4)
                type = cbojoiningterm.SelectedIndex + 1;
            sql.addprams("@stu_id", studentId);
            sql.addprams("@serv_id", serviceId);
            sql.addprams("@term", type);
            sql.addprams("@amount",selectedItem.Amount);
            sql.ExecProc("EXEC [dbo].[Insert_Sub]  @stu_id,@serv_id,@term,@amount");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Associated service", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((MainInterface)this.MdiParent).Services.Cboname_SelectedIndexChanged(sender, e);
            this.Close();
        }

        private void AssociateService_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            cbojoiningterm.Visible = false;
            sql.ExecSql("Select * from services;");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                ServiceID obj = new ServiceID();
                obj.Id = (int)r["id"];
                obj.Name = r["name"].ToString();
                obj.recur = (Int16)r["recur"];
                obj.Amount = double.Parse(r["amount"].ToString());
                cboname.Items.Add(obj);
            }
            cbojoiningterm.SelectedIndex = 0;
        }
        private class ServiceID
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Int16 recur { get; set; }
            public double Amount { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        private void Cboname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceID selectedItem = (ServiceID)cboname.SelectedItem;
            if(selectedItem.recur == 4)
            {
                label2.Visible = true;
                cbojoiningterm.Visible = true;
            }
            else
            {
                label2.Visible = false;
                cbojoiningterm.Visible = false;
            }
        }
    }
}
