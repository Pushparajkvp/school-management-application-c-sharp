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
    public partial class TeachersAttendance : Form
    {
        public TeachersAttendance()
        {
            InitializeComponent();
        }
        private int cotn = 0;
        private void TeachersAttendance_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676288_cmyk_04);
            dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            grphidden.Visible = true;
            grpbox.Visible = false;
            see();
        }
        public void clicky(System.Object sender, System.EventArgs e)
        {
            SqlControl sql2 = new SqlControl();
            sql2.ExecSql("Select * from teacher");
            if (sql2.exep != "")
            {
                MessageBox.Show(sql2.exep);
                return;
            }

            int num = 1;
            var loopTo = sql2.count;
            for (var j = 1; j <= loopTo; j++)
            {
                if (sender == pan.Controls["Names" + num.ToString()])
                {
                    SqlControl sql1 = new SqlControl();
                    sql1.addprams("@name", pan.Controls["Names" + num.ToString()].Text);
                    sql1.ExecSql("Select *From dbo.teacher_shows(@name)");
                    if (sql1.exep != "")
                    {
                        MessageBox.Show(sql1.exep);
                        return;
                    }
                    Picbox1.ImageLocation = sql1.data.Tables[0].Rows[0]["Picture"].ToString();
                    lbldesig.Text = sql1.data.Tables[0].Rows[0]["Designation"].ToString();
                    lblgender.Text = sql1.data.Tables[0].Rows[0]["Gender"].ToString();
                    lbltname.Text = sql1.data.Tables[0].Rows[0]["Staff Name"].ToString();
                    lblleaves.Text = sql1.data.Tables[0].Rows[0]["leave"].ToString();
                }
                num += 1;
            }
            grphidden.Visible = false;
            grpbox.Visible = true;
            dates();
        }

        private void see()
        {
            if (cotn > 0)
            {
                int num = 1;
                var loopTo = cotn;
                for (var j = 1; j <= loopTo; j++)
                {
                    pan.Controls["Combos" + num.ToString()].Dispose();
                    pan.Controls["Names" + num.ToString()].Dispose();
                    num += 1;
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
            sql.addprams("@date", dtp.Value);
            sql.ExecSql("select * from dbo.show_Tattendance(@date)");
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
                    combos[j].Text = sql.data.Tables[0].Rows[j - 1]["P/A"].ToString();
                    pan.Controls.Add(combos[j]);

                    lables[j] = new Label();
                    lables[j].Name = "Names" + num.ToString();
                    lables[j].Location = new Point(50, yy);
                    lables[j].Size = new Size(140, 24);
                    lables[j].Font = fonts;
                    lables[j].Text = sql.data.Tables[0].Rows[j - 1]["Staff Name"].ToString();
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
                SqlControl sqls = new SqlControl();
                sqls.ExecSql("select * from teacher");
                if (sqls.exep != "")
                {
                    MessageBox.Show(sqls.exep);
                    return;
                }
                int arraysize;
                arraysize = sqls.count;
                ComboBox[] combos = new ComboBox[arraysize + 1];
                Label[] lables = new Label[arraysize + 1];
                Font fonts = new Font("Arial", 12);
                int num = 1;
                Button butt;
                Font buttfont = new Font("Arial", 22);
                int yy = 100;
                var loopTo2 = sqls.count;
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
                    lables[j].Text = sqls.data.Tables[0].Rows[j - 1]["name"].ToString();
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
                cbofill.Enabled = true;
            }
            grphidden.Visible = true;
            grpbox.Visible = false;

            boons = true;
        }
        private bool boons;
        public void saves(System.Object sender, System.EventArgs e)
        {
            SqlControl sqls = new SqlControl();
            sqls.ExecSql("select * from teacher");
            if (sqls.exep != "")
            {
                MessageBox.Show(sqls.exep);
                return;
            }
            int num = 1;
            var loopTo = sqls.count;
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
            var loopTo1 = sqls.count;
            for (var j = 1; j <= loopTo1; j++)
            {
                SqlControl sql = new SqlControl();
                sql.addprams("@name", sqls.data.Tables[0].Rows[j - 1]["name"]);
                sql.addprams("@date", dtp.Value);
                ComboBox combo = new ComboBox();
                combo = (ComboBox)pan.Controls["Combos" + num.ToString()];
                sql.addprams("@at", combo.SelectedIndex + 1);
                sql.ExecProc("exec insert_Tat @name,@date,@at");
                if (sql.exep != "")
                {
                    MessageBox.Show(sql.exep);
                    return;
                }
                num += 1;
            }
            see();
        }

        private void dtp_ValueChanged(System.Object sender, System.EventArgs e)
        {
            if (dtp.Value.Date > DateTime.Now.Date)
            {
                dtp.Value = DateTime.Now.Date;
                return;
            }
            see();
            cbofill.Text = "";
        }

        private void cbofill_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if (boons == true)
            {
                SqlControl sqls = new SqlControl();
                sqls.ExecSql("select * from teacher");
                if (sqls.exep != "")
                {
                    MessageBox.Show(sqls.exep);
                    return;
                }
                int num = 1;
                var loopTo = sqls.count;
                for (var j = 1; j <= loopTo; j++)
                {
                    ComboBox combo = new ComboBox();
                    combo = (ComboBox)pan.Controls["Combos" + num.ToString()];
                    if (cbofill.SelectedIndex == 0)
                        combo.SelectedIndex = 0;
                    else
                        combo.SelectedIndex = 1;
                    num += 1;
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
            lstbo.Items.Clear();
            SqlControl sql = new SqlControl();
            sql.addprams("@date", dtp.Value.Month);
            sql.addprams("@name", lbltname.Text);
            sql.ExecSql("select * from dbo.get_datess(@name,@date)");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }

            var loopTo = sql.count;
            for (var j = 1; j <= loopTo; j++)
            {
                if (lstbo.Items.Contains(sql.data.Tables[0].Rows[j - 1]["date"]) == false)
                    lstbo.Items.Add(sql.data.Tables[0].Rows[j - 1]["date"]);
            }
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).TeacherDetailedAttendance.CreateOrShow();
            this.Hide();
        }
    }
}
