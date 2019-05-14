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
    public partial class TeacherDetailedAttendance : Form
    {
        public TeacherDetailedAttendance()
        {
            InitializeComponent();
        }
        private SqlControl sql = new SqlControl();
        private BindingSource bind = new BindingSource();
        private void TeacherDetailedAttendance_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676288_cmyk_04);
            dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            sql.ExecSql("Select *from teacher");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }

            var loopTo = sql.count;
            for (var j = 1; j <= loopTo; j++)
            {
                if (cboname.Items.Contains(sql.data.Tables[0].Rows[j - 1]["name"]) == false)
                    cboname.Items.Add(sql.data.Tables[0].Rows[j - 1]["name"]);
            }
            this.Icon =  Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676288_cmyk_04);
        }

        private void cboname_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            sql.addprams("@name", cboname.Text);
            sql.addprams("@date", dtp.Value);
            sql.ExecSql("select *From dbo.show_Tattendancenamedate(@name,@date)");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
        }

        private void TeacherDetailedAttendance_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ((MainInterface)this.MdiParent).TeachersAttendance.CreateOrShow();
        }

        private void dtp_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dtp.Value > DateTime.Now.Date)
            {
                dtp.Value = DateTime.Now.Date;
                return;
            }
            if (cboname.Text != "")
                cboname_SelectedIndexChanged(sender, e);
            else
            {
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select *from dbo.show_Tattendance(@date)");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
            }
        }

        private void bnsingle_Click(System.Object sender, System.EventArgs e)
        {
            sql.addprams("@name", cboname.Text);
            sql.ExecSql("select *from dbo.show_Tattendances(@name)");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            bind.DataSource = sql.data.Tables[0];
            DataGridView1.DataSource = bind;
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
                e.Graphics.DrawString(sql.data.Tables[0].Rows[j - 1]["Staff Name"].ToString(), fonts, Brushes.Brown, 22, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 270, height, 240, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[j - 1]["Date"].ToString(), fonts, Brushes.Brown, 272, height + 10);
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

        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            PrintDocument1.Print();
        }
    }
}
