namespace SchoolManagementApplciation
{
    partial class TeacherDetailedAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.bnprint = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.bnsingle = new System.Windows.Forms.Button();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(434, 60);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(274, 29);
            this.dtp.TabIndex = 1;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(52, 63);
            this.cboname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(323, 32);
            this.cboname.TabIndex = 2;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(52, 28);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(226, 25);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Enter The Name Of Staff";
            // 
            // bnprint
            // 
            this.bnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprint.Location = new System.Drawing.Point(741, 28);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(400, 132);
            this.bnprint.TabIndex = 4;
            this.bnprint.Text = "Print";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(434, 28);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 25);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Enter The Date";
            // 
            // bnsingle
            // 
            this.bnsingle.Location = new System.Drawing.Point(52, 108);
            this.bnsingle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnsingle.Name = "bnsingle";
            this.bnsingle.Size = new System.Drawing.Size(324, 76);
            this.bnsingle.TabIndex = 6;
            this.bnsingle.Text = "Get All Details about this staff";
            this.bnsingle.UseVisualStyleBackColor = true;
            this.bnsingle.Click += new System.EventHandler(this.bnsingle_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(-1, 212);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1199, 678);
            this.DataGridView1.TabIndex = 7;
            // 
            // TeacherDetailedAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 908);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.bnsingle);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.dtp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherDetailedAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Detailed Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherDetailedAttendance_FormClosed);
            this.Load += new System.EventHandler(this.TeacherDetailedAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TotalMonthDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button bnsingle;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PresentAbsentDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView DataGridView1;

        #endregion
    }
}