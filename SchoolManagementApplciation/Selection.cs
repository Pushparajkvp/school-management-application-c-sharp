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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }
        private void teacher_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).TeachersAttendance.CreateOrShow();
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            ((MainInterface)this.MdiParent).StudentAt.CreateOrShow();
        }

        private void Selection_Load(System.Object sender, System.EventArgs e)
        {
            this.Icon = Utils.GetIcon(SchoolManagementApplciation.Properties.Resources._1459676787_19);
        }
    }
}
