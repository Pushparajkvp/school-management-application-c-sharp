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
    public partial class FeesStructures : Form
    {
        public FeesStructures()
        {
            InitializeComponent();
        }

        private void FeesStructures_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon =Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676753_vector_65_04);
            Grpdetails.Visible = false;
            SqlControl sql = new SqlControl();
            sql.ExecSql("Select name as [Student] from students");
            if (sql.exep != "")
                MessageBox.Show(sql.exep);
            foreach (DataRow r in sql.data.Tables[0].Rows)
            {
                if (cboname.Items.Contains(r["Student"]) == false)
                    cboname.Items.Add(r["Student"]);
            }
            
        }

        private void cboname_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (cboname.Text == "")
            {
                Grpdetails.Visible = false;
                return;
            }
        }

        private void txtpay_TextChanged(System.Object sender, System.EventArgs e)
        {
            if (double.TryParse(txtpay.Text,out double result) == false)
                txtpay.Clear();
        }

        private void loadpay_Click(System.Object sender, System.EventArgs e)
        {
            if (txtpay.Text == "" | txtrange.Text == "")
            {
                MessageBox.Show("Please Enter An Amount and Fill The Range", "Fill Up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult mess;
            mess = MessageBox.Show("Are You sure the amount is collected?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.No)
                return;
            SqlControl sql = new SqlControl();

            sql.addprams("@name", cboname.Text);
            sql.addprams("@date", DateTime.Now.Date);
            sql.addprams("@amount", double.Parse(txtpay.Text));
            sql.ExecProc("exec insert_transaction @name,@date,@amount");
            if (sql.exep != "")
            {
                MessageBox.Show(sql.exep);
                return;
            }
            mess = MessageBox.Show("The Payment is Done! Do you want a Bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                PrintDocument1.Print();
                mess = MessageBox.Show("Do You Want To Print Another Copy?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (mess == DialogResult.Yes)
                    PrintDocument1.Print();
            }
            cboname_SelectedIndexChanged(sender, e);
            loadcan_Click(sender, e);
            txtpay.Text = "";
            txtrange.Text = "";
        }

        private void cboname_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            SqlControl sql = new SqlControl();
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
                return;
            }
            makepay_Click(sender, e);
        }
        private void Button3_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).Feesda.CreateOrShow();
            this.Hide();
        }

        private void makepay_Click(System.Object sender, System.EventArgs e)
        {
            if (cboname.Text == "")
            {
                MessageBox.Show("Please Select A Name First", "No name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }  
            lblpay.Visible = true;
            loadcan.Visible = true;
            loadpay.Visible = true;
            txtpay.Visible = true;
            makepay.Visible = false;
            txtrange.Visible = true;
            Label3.Visible = true;
        }
        private void loadcan_Click(System.Object sender, System.EventArgs e)
        {
            lblpay.Visible = false;
            loadcan.Visible = false;
            loadpay.Visible = false;
            txtpay.Visible = false;
            txtrange.Visible = false;
            Label3.Visible = false;
            makepay.Visible = true;
        }

        private void PrintDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlControl sql = new SqlControl();
            sql.addprams("@name", cboname.Text);
            sql.ExecSql("select *From show_students(@name)");
            SqlControl sql1 = new SqlControl();
            sql1.addprams("@name", cboname.Text);
            sql1.ExecSql("select count(*) as counts From transactions");
            Font fonts;
            fonts = new Font("Arial", 16);
            Image newim;
            newim = SchoolManagementApplciation.Properties.Resources.Bill_Heading;
            System.Drawing.Size sizes = new System.Drawing.Size();
            sizes = new System.Drawing.Size(725, 200);
            newim = new Bitmap(newim, sizes);
            e.Graphics.DrawImage(newim, 20, 20);
            e.Graphics.DrawString("Fees Receipt", new Font("Arial", 26), Brushes.Black, 300, 250);
            e.Graphics.DrawString("No: 00" + sql1.data.Tables[0].Rows[0]["counts"].ToString() + @"\" +DateTime.Now.Date.ToShortMonthName() + @"\" + DateTime.Now.Date.Year.ToString(), new Font("Arial", 16), Brushes.Black, 310, 300);
            e.Graphics.DrawString("Name : " + cboname.Text, fonts, Brushes.Black, 50, 350);
            e.Graphics.DrawString("Registration Number : " + (sql.data.Tables[0].Rows[0]["Register Number"]).ToString(), fonts, Brushes.Black, 450, 350);
            e.Graphics.DrawString("Class : " + lblclass.Text, fonts, Brushes.Black, 50, 400);
            e.Graphics.DrawString("Date : 20/may/2016", fonts, Brushes.Black, 450, 400);
            e.Graphics.DrawRectangle(Pens.Black, 50, 500, 750, 250);
            e.Graphics.DrawRectangle(Pens.Black, 50, 500, 750, 80);
            e.Graphics.DrawString("Description", new Font("Arial", 20), Brushes.Black, 250, 520);
            e.Graphics.DrawString("Coaching Fee", new Font("Arial", 16), Brushes.Black, 60, 630);
            e.Graphics.DrawString(txtrange.Text, new Font("Arial", 16), Brushes.Black, 60, 680);
            e.Graphics.DrawString(txtpay.Text + @"\- Rs", new Font("Arial", 16), Brushes.Black, 650, 650);
            e.Graphics.DrawRectangle(Pens.Black, 600, 500, 200, 250);
            e.Graphics.DrawString("Amount in words  : .............................................................................................", new Font("Arial", 16), Brushes.Black, 50, 800);
            e.Graphics.DrawString("Amount", new Font("Arial", 20), Brushes.Black, 640, 520);
            e.Graphics.DrawString("Signature", new Font("Arial", 16), Brushes.Black, 640, 970);
            e.Graphics.DrawString("Seal", new Font("Arial", 16), Brushes.Black, 200, 970);
            e.Graphics.DrawString("Vinu Academy,177 Mountbatten Road , 5th Street,Kumaran kudil ,Thoraipakkam,chennai 600097", new Font("Arial", 12), Brushes.Black, 100, 1030);
            e.Graphics.DrawString("9381887424", new Font("Arial", 12), Brushes.Black, 400, 1050);
        }

        private void butedit_Click(System.Object sender, System.EventArgs e)
        {
            txtdue.Visible = true;
            lbldue.Visible = false;
            txtdue.Focus();
        }

        private void txtdue_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
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
                cboname_SelectedIndexChanged(sender, e);
            }
        }
    }
}
