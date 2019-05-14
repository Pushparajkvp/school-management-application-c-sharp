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
    public partial class Studentsdetailedlist : Form
    {
        public Studentsdetailedlist()
        {
            InitializeComponent();
        }
        private BindingSource bind = new BindingSource();
        private SqlControl sql = new SqlControl();
        private void Studentsdetailedlist_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676288_cmyk_04);
            dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            SqlControl sql = new SqlControl();
            sql.ExecSql("select class as [class] ,section as [section] from class");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboclass.Items.Contains(r["class"]) == false)
                    cboclass.Items.Add(r["class"]);
                if (cbosection.Items.Contains(r["section"]) == false)
                    cbosection.Items.Add(r["section"]);
            }
            sql.ExecSql("select name from students");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboname.Items.Contains(r["name"]) == false)
                    cboname.Items.Add(r["name"]);
            }
        }

        private void Studentsdetailedlist_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ((MainInterface)this.MdiParent).StudentAt.CreateOrShow();
        }

        private void cboname_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cboname.Text != "" & cbosection.Text != "")
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            else
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_classsection(@name,default,default,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void cboclass_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cboname.Text != "" & cbosection.Text != "")
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            else if (cbosection.Text != "")
            {
                sql.addprams("@date", dtp.Value);
                sql.addprams("@section", cbosection.Text);
                sql.addprams("@class", cboclass.Text);
                sql.ExecSql("select * from dbo.show_classsection(default,@class,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            else
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_classsection(@name,@class,default,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void cbosection_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cboname.Text != "" & cbosection.Text != "")
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_classsection(@name,@class,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            else if (cboclass.Text != "")
            {
                sql.addprams("@date", dtp.Value);
                sql.addprams("@section", cbosection.Text);
                sql.addprams("@class", cboclass.Text);
                sql.ExecSql("select * from dbo.show_classsection(default,@class,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            else
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@date", dtp.Value);
                sql.addprams("@section", cbosection.Text);
                sql.ExecSql("select * from dbo.show_classsection(@name,default,@section,@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            if (cboname.Text != "")
                PrintDocument1.Print();
        }
        private int index = 1;
        private void PrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = 250;
            Font fontss = new Font("Arial", 22);
            Font fonts = new Font("Arial", 16);
            Rectangle rectangles = new Rectangle();



            rectangles = new Rectangle(20, 200, 250, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Name", fontss, Brushes.Black, 22, 210);

            rectangles = new Rectangle(270, 200, 240, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Date", fonts, Brushes.Black, 272, 210);


            rectangles = new Rectangle(510, 200, 250, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Present/Absent", fonts, Brushes.Black, 512, 210);
            var loopTo = sql.count;
            for (var j = index; j <= loopTo; j++)
            {
                e.Graphics.DrawRectangle(Pens.Black, 20, height, 250, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[j - 1]["Student Name"].ToString(), fonts, Brushes.Brown, 22, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 270, height, 240, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[j - 1]["date"].ToString(), fonts, Brushes.Brown, 272, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 510, height, 250, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[j - 1]["P/A"].ToString(), fonts, Brushes.Brown, 512, height + 10);


                height += 50;
                if (height > 1000)
                {
                    index = j + 1;
                    e.HasMorePages = true;
                    return;
                }
            }
        }
        private void dtp_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dtp.Value > DateTime.Now.Date)
                dtp.Value = DateTime.Now.Date;
            cboname_SelectedIndexChanged(sender, e);
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            if (cboname.Text != "")
            {
                sql.addprams("@name", cboname.Text);
                sql.ExecSql("select *from dbo.show_classname(@name,default,default)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
            }
            else
                MessageBox.Show("Please Select A Student !", "Select", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
