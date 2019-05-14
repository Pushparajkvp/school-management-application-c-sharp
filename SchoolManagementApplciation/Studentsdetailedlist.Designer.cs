namespace SchoolManagementApplciation
{
    partial class Studentsdetailedlist
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
            this.Label2 = new System.Windows.Forms.Label();
            this.bnprint = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.cbosection = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(439, 18);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 25);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Enter The Date";
            // 
            // bnprint
            // 
            this.bnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprint.Location = new System.Drawing.Point(745, 18);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(400, 132);
            this.bnprint.TabIndex = 11;
            this.bnprint.Text = "Print";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(56, 18);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(254, 25);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Enter The Name Of Student";
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(56, 52);
            this.cboname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(261, 32);
            this.cboname.TabIndex = 9;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(439, 50);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(274, 29);
            this.dtp.TabIndex = 8;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // cboclass
            // 
            this.cboclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Location = new System.Drawing.Point(56, 138);
            this.cboclass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(261, 32);
            this.cboclass.TabIndex = 13;
            this.cboclass.SelectedIndexChanged += new System.EventHandler(this.cboclass_SelectedIndexChanged);
            // 
            // cbosection
            // 
            this.cbosection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosection.FormattingEnabled = true;
            this.cbosection.Location = new System.Drawing.Point(439, 138);
            this.cbosection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbosection.Name = "cbosection";
            this.cbosection.Size = new System.Drawing.Size(274, 32);
            this.cbosection.TabIndex = 14;
            this.cbosection.SelectedIndexChanged += new System.EventHandler(this.cbosection_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(56, 104);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 25);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Class";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(439, 104);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 25);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "Section";
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
            this.DataGridView1.Location = new System.Drawing.Point(4, 238);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1195, 670);
            this.DataGridView1.TabIndex = 17;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(327, 46);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(63, 45);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "Only";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Studentsdetailedlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 908);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbosection);
            this.Controls.Add(this.cboclass);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.dtp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Studentsdetailedlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailed Student Attendance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Studentsdetailedlist_FormClosed);
            this.Load += new System.EventHandler(this.Studentsdetailedlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.ComboBox cboclass;
        internal System.Windows.Forms.ComboBox cbosection;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PresentAbsentDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button Button1;

        #endregion
    }
}