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
    public partial class EnterMarkss : Form
    {
        public EnterMarkss()
        {
            InitializeComponent();
        }

        private BindingSource bind = new BindingSource();
        private bool tryer = true;
        private void Entermarkss_Load(System.Object sender, System.EventArgs e)
        {
            SqlControl sql = new SqlControl();
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676723_Test_paper_24);
            sql.ExecSql("select name as [dash] from students");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboname.Items.Contains(r["dash"]) == false)
                    cboname.Items.Add(r["dash"]);
            }
            sql.ExecSql("select name as [lol] from sub");
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cbosub.Items.Contains(r["lol"]) == false)
                    cbosub.Items.Add(r["lol"]);
            }
            dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        private void bnload_Click(System.Object sender, System.EventArgs e)
        {
            SqlControl sql = new SqlControl();
            if (cboname.Text != "" & cbosub.Text != "")
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@sub", cbosub.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select *from dbo.show_marks(@name,@sub,@date)");
                if (sql.count <= 0)
                {
                    sql.addprams("@name", cboname.Text);
                    sql.addprams("@sub", cbosub.Text);
                    sql.addprams("@date", dtp.Value);
                    sql.ExecProc("Exec insert_marks @date,NULL,@sub,@name");
                    bnload_Click(sender, e);
                    return;
                }
                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                return;
            }
            if (cboname.Text != "" & cbosub.Text == "")
            {
                sql.addprams("@name", cboname.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * From dbo.show_marks(@name,default,@date)");
                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                return;
            }
            if (cboname.Text == "" & cbosub.Text != "")
            {
                sql.addprams("@sub", cbosub.Text);
                sql.addprams("@date", dtp.Value);
                sql.ExecSql("select * from dbo.show_marks(default,@sub,@date)");
                bind.DataSource = sql.data.Tables[0];
                DataGridView1.DataSource = bind;
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                return;
            }
        }
        private void DataGridView1_CellParsing(System.Object sender, System.Windows.Forms.DataGridViewCellParsingEventArgs e)
        {
            this.DataGridView1.CurrentCell.Selected = true;
        }
        private void DataGridView1_CellEndEdit(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            SqlControl sql = new SqlControl();
            if (this.DataGridView1.CurrentCell.ColumnIndex == 2)
            {
                Type numberType = this.DataGridView1.CurrentCell.Value.IsNumber();
                if (numberType==null)
                {
                    MessageBox.Show("Please Enter A Number", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                double value = Convert.ToDouble(this.DataGridView1.CurrentCell.Value);
                if (value < 0 || value > 100)
                {
                    MessageBox.Show("Enter a number between 1 to 100", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    bnload_Click(sender, e);
                    return;
                }
                sql.addprams("@name", this.DataGridView1.Rows[this.DataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                sql.addprams("@sub", this.DataGridView1.Rows[this.DataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                sql.addprams("@date", dtp.Value);
                sql.addprams("@mark", this.DataGridView1.CurrentCell.Value);
                sql.ExecProc("exec update_marks @name,@sub,@date,@mark");
                bnload_Click(sender, e);
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
            }
        }
        private bool once = false;
        private void dtp_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dtp.Value > DateTime.Now.Date)
            {
                dtp.Value = DateTime.Now.Date;
                return;
            }
            string names;
            int values;
            values = dtp.Value.Month;
            switch (values)
            {
                case 1:
                    {
                        names = "Jan";
                        break;
                    }

                case 2:
                    {
                        names = "feb";
                        break;
                    }

                case 3:
                    {
                        names = "march";
                        break;
                    }

                case 4:
                    {
                        names = "april";
                        break;
                    }

                case 5:
                    {
                        names = "may";
                        break;
                    }

                case 6:
                    {
                        names = "june";
                        break;
                    }

                case 7:
                    {
                        names = "july";
                        break;
                    }

                case 8:
                    {
                        names = "Aug";
                        break;
                    }

                case 9:
                    {
                        names = "sept";
                        break;
                    }

                case 10:
                    {
                        names = "oct";
                        break;
                    }

                case 11:
                    {
                        names = "Nov";
                        break;
                    }

                case 12:
                    {
                        names = "Dec";
                        break;
                    }

                default:
                    {
                        names = "Default";
                        break;
                    }
            }

            lblcurentdate.Text = "" + names + "-" + dtp.Value.Year;
            if (once == true)
                bnload_Click(sender, e);
            once = true;
        }

        private void bnclear_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                SqlControl sql = new SqlControl();
                sql.addprams("@name", this.DataGridView1.Rows[this.DataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                sql.addprams("@sub", this.DataGridView1.Rows[this.DataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                sql.addprams("@date", dtp.Value);
                sql.ExecProc("exec delete_marks @name,@sub,@date");
                MessageBox.Show("The Mark Details Has Been Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                bnload_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select A Mark Info first In The Grid", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bnprint_Click(System.Object sender, System.EventArgs e)
        {
            if (cboname.Text == "")
            {
                MessageBox.Show("Please Select A Student First !", "Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            PrintDocument1.Print();
            index = 0;
        }
        private int index = 0;
        private void PrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = 250;
            SqlControl sql = new SqlControl();
            sql.addprams("@name", cboname.Text);
            sql.addprams("@date", dtp.Value);
            sql.ExecSql("select * from dbo.show_marks(@name,default,@date)");

            Font fontss = new Font("Arial", 22);
            Font fonts = new Font("Arial", 16);
            Rectangle rectangles = new Rectangle();

            Font fullnamesfont = new Font("Arial", 20);

            e.Graphics.DrawString("Name : ", fullnamesfont, Brushes.Black, 50, 50);
            e.Graphics.DrawString(sql.data.Tables[0].Rows[0]["Student Name"].ToString(), fullnamesfont, Brushes.DarkOrange, 250, 50);
            e.Graphics.DrawString("Class : ", fullnamesfont, Brushes.Black, 50, 100);
            e.Graphics.DrawString(sql.data.Tables[0].Rows[0]["class"].ToString(), fullnamesfont, Brushes.DarkOrange, 250, 100);
            e.Graphics.DrawString("Section : ", fullnamesfont, Brushes.Black, 50, 150);
            e.Graphics.DrawString(sql.data.Tables[0].Rows[0]["section"].ToString(), fullnamesfont, Brushes.DarkOrange, 250, 150);

            rectangles = new Rectangle(20, 200, 250, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Subjects", fontss, Brushes.Black, 22, 210);

            rectangles = new Rectangle(270, 200, 120, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Mark", fonts, Brushes.Black, 272, 210);

            rectangles = new Rectangle(390, 200, 120, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Grade", fonts, Brushes.Black, 392, 210);

            rectangles = new Rectangle(510, 200, 300, 50);
            e.Graphics.DrawRectangle(Pens.Black, rectangles);
            e.Graphics.FillRectangle(Brushes.ForestGreen, rectangles);
            e.Graphics.DrawString("Remarks", fonts, Brushes.Black, 632, 210);
            var loopTo = sql.count - 1;
            for (int r = index; r <= loopTo; r++)
            {
                e.Graphics.DrawRectangle(Pens.Black, 20, height, 250, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["Subject Name"].ToString(), fonts, Brushes.Brown, 22, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 270, height, 120, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["Marks"].ToString(), fonts, Brushes.Brown, 272, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 390, height, 120, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["Grade"].ToString(), fonts, Brushes.Brown, 392, height + 10);
                e.Graphics.DrawRectangle(Pens.Black, 510, height, 300, 50);
                e.Graphics.DrawString(sql.data.Tables[0].Rows[r]["Remark"].ToString(), fonts, Brushes.Brown, 530, height + 10);
                height += 50;
                if (height > 1000)
                {
                    height = 100;
                    index = r + 1;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }
        private void cbosub_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            bnload_Click(sender, e);
        }

        private void cboname_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            cbosub.Text = "";
            bnload_Click(sender, e);
        }

        private void Entermarkss_FormClosed(System.Object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            SqlControl sql = new SqlControl();
            sql.ExecSql("delete from marks where marks is null");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
        }
        private void cbosub_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bnload_Click(sender, e);
        }
    }
}
