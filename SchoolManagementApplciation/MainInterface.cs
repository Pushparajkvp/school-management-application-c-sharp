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
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            AddStudent.MdiParent = this;
            AddTeacher.MdiParent = this;
            Edits.MdiParent = this;
            EnterMarkss.MdiParent = this;
            Feesda.MdiParent = this;
            FeesStructures.MdiParent = this;
            ManageStudents.MdiParent = this;
            ManageTeacher.MdiParent = this;
            ManageUsers.MdiParent = this;
            Selection.MdiParent = this;
            StudentAt.MdiParent = this;
            Studentsdetailedlist.MdiParent = this;
            TeacherDetailedAttendance.MdiParent = this;
            TeachersAttendance.MdiParent = this;
            WelcomeScreen.MdiParent = this;
            Services.MdiParent = this;
            AddService.MdiParent = this;
            AssociateService.MdiParent = this;
            ManageServices.MdiParent = this;
        }
        private SqlControl sqlm = new SqlControl();

       


        private void MainInterface_Load(System.Object sender, System.EventArgs e)
        {
            if (DateTime.Now.Day == 1)
            {
                this.FeesStructures.CreateOrShow();
                this.FeesStructures.MdiParent = this;
            }
            
            sqlm.ExecSql("select id from students where due>0");
            if (sqlm.count != 0)
            {
                NotifyIcon1.BalloonTipText = sqlm.count + "  Students have to pay the fees";
                NotifyIcon1.BalloonTipTitle = "Fee Info";
                NotifyIcon1.ShowBalloonTip(100);
            }
            sqlm.ExecProc("exec update_leaves");
            sqlm.ExecSql("");
        }

        private void ToolStripButton7_Click(System.Object sender, System.EventArgs e)
        {
            this.AddStudent.CreateOrShow();
        }

        private void ToolStripButton13_Click(System.Object sender, System.EventArgs e)
        {
            this.ManageStudents.CreateOrShow();
        }

        private void ToolStripButton14_Click(System.Object sender, System.EventArgs e)
        {
            this.ManageTeacher.CreateOrShow();
        }

        private void ToolStripButton15_Click(System.Object sender, System.EventArgs e)
        {
            this.EnterMarkss.CreateOrShow();
        }

        private void ToolStripButton16_Click(System.Object sender, System.EventArgs e)
        {
            this.FeesStructures.CreateOrShow();
        }

        private void ToolStripButton17_Click(System.Object sender, System.EventArgs e)
        {
            this.Selection.CreateOrShow();
        }

        private void ToolStripButton18_Click(System.Object sender, System.EventArgs e)
        {
            this.ManageUsers.CreateOrShow();
        }

        private void ToolStripButton19_Click(System.Object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ToolStripButton20_Click(System.Object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void ToolStripButton22_Click(object sender, EventArgs e)
        {
            this.Services.CreateOrShow();
        }


        private ManageServices _ManageServices = new ManageServices();
        public ManageServices ManageServices
        {
            get
            {
                if (_ManageServices.IsDisposed)
                {
                    _ManageServices = new ManageServices();
                    _ManageServices.MdiParent = this;
                }
                return _ManageServices;
            }
            set
            {
                _ManageServices = value;
            }
        }

        private AssociateService _AssociateService = new AssociateService();
        public AssociateService AssociateService
        {
            get
            {
                if (_AssociateService.IsDisposed)
                {
                    _AssociateService = new AssociateService();
                    _AssociateService.MdiParent = this;
                }
                return _AssociateService;
            }
            set
            {
                _AssociateService = value;
            }
        }
        private Services _Services = new Services();
        public Services Services
        {
            get
            {
                if (_Services.IsDisposed)
                {
                    _Services = new Services();
                    _Services.MdiParent = this;
                }
                return _Services;
            }
            set
            {
                _Services = value;
            }
        }
        private AddStudent _AddStudent = new AddStudent();
        public AddStudent AddStudent
        {
            get
            {
                if (_AddStudent.IsDisposed)
                {
                    _AddStudent = new AddStudent();
                    _AddStudent.MdiParent = this;
                }
                return _AddStudent;
            }
            set
            {
                _AddStudent = value;
            }
        }

        private AddTeacher _AddTeacher = new AddTeacher();
        public AddTeacher AddTeacher
        {
            get
            {
                if (_AddTeacher.IsDisposed)
                {
                    _AddTeacher = new AddTeacher();
                    _AddTeacher.MdiParent = this;
                }
                return _AddTeacher;
            }
            set
            {
                _AddTeacher = value;
            }
        }

        private Edits _Edits = new Edits();
        public Edits Edits
        {
            get
            {
                if (_Edits.IsDisposed)
                {
                    _Edits = new Edits();
                    _Edits.MdiParent = this;
                }
                return _Edits;
            }
            set
            {
                _Edits = value;
            }
        }

        private EnterMarkss _EnterMarkss = new EnterMarkss();
        public EnterMarkss EnterMarkss
        {
            get
            {
                if (_EnterMarkss.IsDisposed)
                {
                    _EnterMarkss = new EnterMarkss();
                    _EnterMarkss.MdiParent = this;
                }
                return _EnterMarkss;
            }
            set
            {
                _EnterMarkss = value;
            }
        }

        private feesda _Feesda = new feesda();
        public feesda Feesda
        {
            get
            {
                if (_Feesda.IsDisposed)
                {
                    _Feesda = new feesda();
                    _Feesda.MdiParent = this;
                }
                return _Feesda;
            }
            set
            {
                _Feesda = value;
            }
        }

        private FeesStructures _FeesStructures = new FeesStructures();
        public FeesStructures FeesStructures
        {
            get
            {
                if (_FeesStructures.IsDisposed)
                {
                    _FeesStructures = new FeesStructures();
                    _FeesStructures.MdiParent = this;
                }
                return _FeesStructures;
            }
            set
            {
                _FeesStructures = value;
            }
        }

        private ManageStudents _ManageStudents = new ManageStudents();
        public ManageStudents ManageStudents
        {
            get
            {
                if (_ManageStudents.IsDisposed)
                {
                    _ManageStudents = new ManageStudents();
                    _ManageStudents.MdiParent = this;
                }
                return _ManageStudents;
            }
            set
            {
                _ManageStudents = value;
            }
        }

        private ManageTeacher _ManageTeacher = new ManageTeacher();
        public ManageTeacher ManageTeacher
        {
            get
            {
                if (_ManageTeacher.IsDisposed)
                {
                    _ManageTeacher = new ManageTeacher();
                    _ManageTeacher.MdiParent = this;
                }
                return _ManageTeacher;
            }
            set
            {
                _ManageTeacher = value;
            }
        }

        private ManageUsers _ManageUsers = new ManageUsers();
        public ManageUsers ManageUsers
        {
            get
            {
                if (_ManageUsers.IsDisposed)
                {
                    _ManageUsers = new ManageUsers();
                    _ManageUsers.MdiParent = this;
                }
                return _ManageUsers;
            }
            set
            {
                _ManageUsers = value;
            }
        }

        private AddService _AddService = new AddService();
        public AddService AddService
        {
            get
            {
                if (_AddService.IsDisposed)
                {
                    _AddService = new AddService();
                    _AddService.MdiParent = this;
                }
                return _AddService;
            }
            set
            {
                _AddService = value;
            }
        }

        private Selection _Selection = new Selection();
        public Selection Selection
        {
            get
            {
                if (_Selection.IsDisposed)
                {
                    _Selection = new Selection();
                    _Selection.MdiParent = this;
                }
                return _Selection;
            }
            set
            {
                _Selection = value;
            }
        }

        private StudentAt _StudentAt = new StudentAt();
        public StudentAt StudentAt
        {
            get
            {
                if (_StudentAt.IsDisposed)
                {
                    _StudentAt = new StudentAt();
                    _StudentAt.MdiParent = this;
                }
                return _StudentAt;
            }
            set
            {
                _StudentAt = value;
            }
        }

        private Studentsdetailedlist _Studentsdetailedlist = new Studentsdetailedlist();
        public Studentsdetailedlist Studentsdetailedlist
        {
            get
            {
                if (_Studentsdetailedlist.IsDisposed)
                {
                    _Studentsdetailedlist = new Studentsdetailedlist();
                    _Studentsdetailedlist.MdiParent = this;
                }
                return _Studentsdetailedlist;
            }
            set
            {
                _Studentsdetailedlist = value;
            }
        }

        private TeacherDetailedAttendance _TeacherDetailedAttendance = new TeacherDetailedAttendance();
        public TeacherDetailedAttendance TeacherDetailedAttendance
        {
            get
            {
                if (_TeacherDetailedAttendance.IsDisposed)
                {
                    _TeacherDetailedAttendance = new TeacherDetailedAttendance();
                    _TeacherDetailedAttendance.MdiParent = this;
                }
                return _TeacherDetailedAttendance;
            }
            set
            {
                _TeacherDetailedAttendance = value;
            }
        }

        private TeachersAttendance _TeachersAttendance = new TeachersAttendance();
        public TeachersAttendance TeachersAttendance
        {
            get
            {
                if (_TeachersAttendance.IsDisposed)
                {
                    _TeachersAttendance = new TeachersAttendance();
                    _TeachersAttendance.MdiParent = this;
                }
                return _TeachersAttendance;
            }
            set
            {
                _TeachersAttendance = value;
            }
        }

        private WelcomeScreen _WelcomeScreen = new WelcomeScreen();
        public WelcomeScreen WelcomeScreen
        {
            get
            {
                if (_WelcomeScreen.IsDisposed)
                {
                    _WelcomeScreen = new WelcomeScreen();
                    _WelcomeScreen.MdiParent = this;
                }
                return _WelcomeScreen;
            }
            set
            {
                _WelcomeScreen = value;
            }
        }

       
    }
}
