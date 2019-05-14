namespace SchoolManagementApplciation
{
    partial class Services
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboname = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Grpdetails = new System.Windows.Forms.GroupBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.lbldue = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btndeleteassociation = new System.Windows.Forms.Button();
            this.butedit = new System.Windows.Forms.Button();
            this.txtdue = new System.Windows.Forms.TextBox();
            this.Grpdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(115, 42);
            this.cboname.Margin = new System.Windows.Forms.Padding(2);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(138, 21);
            this.cboname.TabIndex = 2;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.Cboname_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 42);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Sudent\'s Name";
            // 
            // Grpdetails
            // 
            this.Grpdetails.BackColor = System.Drawing.SystemColors.Control;
            this.Grpdetails.Controls.Add(this.txtdue);
            this.Grpdetails.Controls.Add(this.butedit);
            this.Grpdetails.Controls.Add(this.picbox);
            this.Grpdetails.Controls.Add(this.lblsection);
            this.Grpdetails.Controls.Add(this.lblclass);
            this.Grpdetails.Controls.Add(this.Label7);
            this.Grpdetails.Controls.Add(this.Label6);
            this.Grpdetails.Controls.Add(this.lblname);
            this.Grpdetails.Controls.Add(this.Label5);
            this.Grpdetails.Controls.Add(this.lbldue);
            this.Grpdetails.Controls.Add(this.Label4);
            this.Grpdetails.Controls.Add(this.lblage);
            this.Grpdetails.Controls.Add(this.Label2);
            this.Grpdetails.Location = new System.Drawing.Point(473, 28);
            this.Grpdetails.Margin = new System.Windows.Forms.Padding(2);
            this.Grpdetails.Name = "Grpdetails";
            this.Grpdetails.Padding = new System.Windows.Forms.Padding(2);
            this.Grpdetails.Size = new System.Drawing.Size(353, 502);
            this.Grpdetails.TabIndex = 4;
            this.Grpdetails.TabStop = false;
            this.Grpdetails.Text = "Student Details";
            // 
            // picbox
            // 
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.Location = new System.Drawing.Point(97, 38);
            this.picbox.Margin = new System.Windows.Forms.Padding(2);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(160, 195);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 16;
            this.picbox.TabStop = false;
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Location = new System.Drawing.Point(200, 335);
            this.lblsection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(39, 13);
            this.lblsection.TabIndex = 13;
            this.lblsection.Text = "Label9";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Location = new System.Drawing.Point(200, 299);
            this.lblclass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(39, 13);
            this.lblclass.TabIndex = 12;
            this.lblclass.Text = "Label8";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(118, 335);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Section";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(118, 299);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Class";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(200, 260);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(39, 13);
            this.lblname.TabIndex = 9;
            this.lblname.Text = "Label6";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(118, 260);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Name";
            // 
            // lbldue
            // 
            this.lbldue.AutoSize = true;
            this.lbldue.Location = new System.Drawing.Point(200, 404);
            this.lbldue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldue.Name = "lbldue";
            this.lbldue.Size = new System.Drawing.Size(39, 13);
            this.lbldue.TabIndex = 7;
            this.lbldue.Text = "Label5";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(118, 404);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Due";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(200, 370);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(39, 13);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(118, 370);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Age";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 130);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(442, 267);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Associate Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Associated Services";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Manage Service";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btndeleteassociation
            // 
            this.btndeleteassociation.Location = new System.Drawing.Point(263, 468);
            this.btndeleteassociation.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteassociation.Name = "btndeleteassociation";
            this.btndeleteassociation.Size = new System.Drawing.Size(186, 62);
            this.btndeleteassociation.TabIndex = 9;
            this.btndeleteassociation.Text = "Delete Association";
            this.btndeleteassociation.UseVisualStyleBackColor = true;
            this.btndeleteassociation.Click += new System.EventHandler(this.Btndeleteassociation_Click);
            // 
            // butedit
            // 
            this.butedit.Location = new System.Drawing.Point(269, 401);
            this.butedit.Margin = new System.Windows.Forms.Padding(2);
            this.butedit.Name = "butedit";
            this.butedit.Size = new System.Drawing.Size(67, 21);
            this.butedit.TabIndex = 19;
            this.butedit.Text = "Edit";
            this.butedit.UseVisualStyleBackColor = true;
            this.butedit.Click += new System.EventHandler(this.Butedit_Click);
            // 
            // txtdue
            // 
            this.txtdue.Location = new System.Drawing.Point(203, 401);
            this.txtdue.Margin = new System.Windows.Forms.Padding(2);
            this.txtdue.Name = "txtdue";
            this.txtdue.Size = new System.Drawing.Size(62, 20);
            this.txtdue.TabIndex = 20;
            this.txtdue.Visible = false;
            this.txtdue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtdue_KeyDown);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 547);
            this.Controls.Add(this.btndeleteassociation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Grpdetails);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.Grpdetails.ResumeLayout(false);
            this.Grpdetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox Grpdetails;
        internal System.Windows.Forms.PictureBox picbox;
        internal System.Windows.Forms.Label lblsection;
        internal System.Windows.Forms.Label lblclass;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblname;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lbldue;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblage;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btndeleteassociation;
        internal System.Windows.Forms.Button butedit;
        internal System.Windows.Forms.TextBox txtdue;
    }
}