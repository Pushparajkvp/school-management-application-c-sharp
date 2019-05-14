using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SchoolManagementApplciation
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            new SqlControl().ExecProc("exec dbo.update_fees");
            this.Close();
        }
    }
}
