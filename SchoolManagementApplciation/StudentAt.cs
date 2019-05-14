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
    public partial class StudentAt : Form
    {
        public StudentAt()
        {
            InitializeComponent();
        }

        private int cotn = 0;
        private void StudentsAt_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676288_cmyk_04);
            dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            grphidden.Visible = true;
            grpbox.Visible = false;
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
            sql.ExecProc("exec update_leaves");
        }
        private void see()
        {
            SqlControl sql2 = new SqlControl();
            sql2.ExecProc("exec update_leaves");
            if (cotn > 0)
            {
                int numm = 1;
                var loopTo = cotn;
                for (var j = 1; j <= loopTo; j++)
                {
                    pan.Controls["Combos" + numm.ToString()].Dispose();
                    pan.Controls["Names" + numm.ToString()].Dispose();
                    numm += 1;
                }
            }
            cotn = 0;
            try
            {
                pan.Controls["bnload"].Dispose();
            }
            catch (Exception ex)
            {
            }
            SqlControl sql = new SqlControl();
            sql.addprams("@class", cboclass.Text);
            sql.addprams("@section", cbosection.Text);
            sql.addprams("@date", dtp.Value);
            sql.ExecSql("select * from dbo.show_stuat(@class,@section,@date) order by name asc");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            if (sql.count != 0)
            {
                int arraysize;
                arraysize = sql.count;
                ComboBox[] combos = new ComboBox[arraysize + 1];
                Label[] lables = new Label[arraysize + 1];
                Font fonts = new Font("Arial", 12);
                int num = 1;
                int yy = 100;
                var loopTo1 = sql.count;
                for (var j = 1; j <= loopTo1; j++)
                {
                    combos[j] = new ComboBox();
                    combos[j].Name = "Combos" + num.ToString();
                    combos[j].Location = new Point(300, yy);
                    combos[j].Size = new Size(140, 24);
                    combos[j].Text = sql.data.Tables[0].Rows[j - 1]["at"].ToString();
                    pan.Controls.Add(combos[j]);

                    lables[j] = new Label();
                    lables[j].Name = "Names" + num.ToString();
                    lables[j].Location = new Point(50, yy);
                    lables[j].Size = new Size(140, 24);
                    lables[j].Font = fonts;
                    lables[j].Text = sql.data.Tables[0].Rows[j - 1]["name"].ToString();
                    pan.Controls.Add(lables[j]);
                    lables[j].Click += clicky;

                    yy += 50;
                    num += 1;
                    cotn += 1;
                }
                cbofill.Enabled = false;
            }
            else
            {
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }

                int arraysize;
                arraysize = sql.count;
                ComboBox[] combos = new ComboBox[arraysize + 1];
                Label[] lables = new Label[arraysize + 1];
                Font fonts = new Font("Arial", 12);
                int num = 1;
                Button butt;
                Font buttfont = new Font("Arial", 22);
                int yy = 100;
                var loopTo2 = sql.count;
                for (var j = 1; j <= loopTo2; j++)
                {
                    combos[j] = new ComboBox();
                    combos[j].Name = "Combos" + num.ToString();
                    combos[j].Location = new Point(300, yy);
                    combos[j].Size = new Size(140, 24);
                    combos[j].Items.Add("Present");
                    combos[j].Items.Add("Absent");
                    pan.Controls.Add(combos[j]);

                    lables[j] = new Label();
                    lables[j].Name = "Names" + num.ToString();
                    lables[j].Location = new Point(50, yy);
                    lables[j].Size = new Size(140, 24);
                    lables[j].Font = fonts;
                    lables[j].Text = sql.data.Tables[0].Rows[j - 1]["name"].ToString();
                    pan.Controls.Add(lables[j]);
                    lables[j].Click += clicky;

                    yy += 50;
                    num += 1;
                    cotn += 1;
                }

                butt = new Button();
                butt.Name = "bnload";
                butt.Text = "Save";
                butt.Font = buttfont;
                butt.Location = new Point(75, yy + 50);
                butt.Size = new Size(400, 100);
                butt.Click += saves;
                pan.Controls.Add(butt);

                grphidden.Visible = true;
                grpbox.Visible = false;

                boons = true;
                cbofill.Enabled = true;
            }
        }
        public void clicky(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cbosection.Text != "")
            {
                SqlControl sql = new SqlControl();
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                int num = 1;
                var loopTo = sql.count;
                for (var j = 1; j <= loopTo; j++)
                {
                    if (sender == pan.Controls["Names" + num.ToString()])
                    {
                        SqlControl sql1 = new SqlControl();
                        sql1.addprams("@class", cboclass.Text);
                        sql1.addprams("@section", cbosection.Text);
                        sql1.addprams("@name", pan.Controls["Names" + num.ToString()].Text);
                        sql1.ExecSql("select * from dbo.show_atclassname(@class,@section,@name)");
                        PictureBox1.ImageLocation = sql1.data.Tables[0].Rows[0]["pic"].ToString();
                        lblnames.Text = sql1.data.Tables[0].Rows[0]["name"].ToString();
                        lblgender.Text = sql1.data.Tables[0].Rows[0]["gender"].ToString();
                        lblclass.Text = sql1.data.Tables[0].Rows[0]["class"].ToString();
                        lblsection.Text = sql1.data.Tables[0].Rows[0]["section"].ToString();
                        lblnoholidays.Text = sql1.data.Tables[0].Rows[0]["leaves"].ToString();
                        dates();
                    }
                    num += 1;
                }
                grphidden.Visible = false;
                grpbox.Visible = true;
            }
            else
                MessageBox.Show("You must not leave class and section empty", "Fill Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void saves(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cbosection.Text != "")
            {
                SqlControl sql = new SqlControl();
                sql.addprams("@class", cboclass.Text);
                sql.addprams("@section", cbosection.Text);
                sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                int num = 1;
                var loopTo = sql.count;
                for (var j = 1; j <= loopTo; j++)
                {
                    if (pan.Controls["Combos" + num.ToString()].Text == "")
                    {
                        MessageBox.Show("You cannot leave a field blank", "Fill all up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    num += 1;
                }
                num = 1;
                var loopTo1 = sql.count;
                for (var j = 1; j <= loopTo1; j++)
                {
                    SqlControl sql1 = new SqlControl();
                    sql1.addprams("@name", pan.Controls["Names" + num.ToString()].Text);
                    sql1.addprams("@date", dtp.Value);
                    ComboBox combo = (ComboBox)pan.Controls["Combos" + num.ToString()];
                    sql1.addprams("@at", combo.SelectedIndex + 1);
                    sql1.ExecProc("exec insert_at @name,@date,@at");
                    if (sql1.exep != "")
                    {
                        MessageBox.Show(sql1.exep);
                        return;
                    }
                    num += 1;
                }
                see();
            }
        }

        private void dtp_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dtp.Value.Date > DateTime.Now.Date)
            {
                dtp.Value = DateTime.Now.Date;
                return;
            }
            if (cboclass.Text != "" & cbosection.Text != "")
                see();
        }
        private bool boons;

        private void cbofill_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (boons == true)
            {
                SqlControl sql = new SqlControl();
                if (cboclass.Text != "" & cbosection.Text != "")
                {
                    sql.addprams("@class", cboclass.Text);
                    sql.addprams("@section", cbosection.Text);
                    sql.ExecSql("select * from dbo.show_atclass(@class,@section) order by name asc");
                    if (sql.exep != "")
                    {
                        MessageBox.Show(sql.exep);
                        return;
                    }
                    int num = 1;
                    var loopTo = sql.count;
                    for (var j = 1; j <= loopTo; j++)
                    {
                        ComboBox combo = (ComboBox)pan.Controls["Combos" + num.ToString()];
                        if (cbofill.SelectedIndex == 0)
                            combo.SelectedIndex = 0;
                        else
                            combo.SelectedIndex = 1;
                        num += 1;
                    }
                }
            }
        }
        private void pan_Click(System.Object sender, System.EventArgs e)
        {
            grphidden.Visible = true;
            grpbox.Visible = false;
        }
        private void dates()
        {
            ListBox1.Items.Clear();
            SqlControl sql = new SqlControl();
            sql.addprams("@name", lblnames.Text);
            sql.addprams("@date", dtp.Value.Month);
            sql.ExecSql("select *from dbo.get_dates(@name,@date)");
            var loopTo = sql.count;
            for (var j = 1; j <= loopTo; j++)
                ListBox1.Items.Add(sql.data.Tables[0].Rows[0]["dates"].ToString());
        }
        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).Studentsdetailedlist.CreateOrShow();
            this.Hide();
        }

        private void cboclass_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cbosection.Text != "")
                see();
        }

        private void cbosection_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (cboclass.Text != "" & cbosection.Text != "")
                see();
        }

    }
}
