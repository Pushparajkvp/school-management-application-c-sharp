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
    public partial class feesda : Form
    {
        public feesda()
        {
            InitializeComponent();
        }
        private BindingSource bind = new BindingSource();
        private void feesda_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676753_vector_65_04);
            SqlControl sql = new SqlControl();
            sql.addprams("@name", txtsearch.Text);
            sql.ExecSql("Select * from dbo.show_fee(@name)");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }
        private void txtsearch_KeyUp(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            SqlControl sql = new SqlControl();
            sql.addprams("@name", txtsearch.Text);
            sql.ExecSql("Select * from dbo.show_fee(@name)");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }
        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            index = 0;
            document.Print();
        }

        private void feesda_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ((MainInterface)this.MdiParent).FeesStructures.CreateOrShow();
        }
        private int index = 0;
        private void document_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = 100;
            SqlControl sql = new SqlControl();
            sql.ExecSql("select name,due from students where due>0");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            Font fontss = new Font("Arial", 22);
            e.Graphics.DrawString("The List of Students With Due", fontss, Brushes.ForestGreen, 200, 50);
            Font fonts = new Font("Arial", 10);
            var loopTo = sql.count - 1;
            for (var r = index; r <= loopTo; r++)
            {
                e.Graphics.DrawRectangle(Pens.Black, 100, height, 200, 40);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["due"].ToString(), fonts, Brushes.Black, 400, height + 5);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["name"].ToString(), fonts, Brushes.Black, 100, height + 5);
                e.Graphics.DrawLine(Pens.Black, 350, height + 20, 320, height + 20);
                e.Graphics.DrawRectangle(Pens.Black, 400, height, 150, 40);
                height += 80;
                if (height > 1000)
                {
                    height = 100;
                    index = r + 1;
                    e.HasMorePages = true;
                    return;
                }
            }
        }
    }
}
