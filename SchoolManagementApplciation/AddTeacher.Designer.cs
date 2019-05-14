namespace SchoolManagementApplciation
{
    partial class AddTeacher
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
            this.imageT = new System.Windows.Forms.PictureBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.cbodesignation = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.bnsave = new System.Windows.Forms.Button();
            this.bnload = new System.Windows.Forms.Button();
            this.bnclear = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.bnclearing = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtqua = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.imageT)).BeginInit();
            this.SuspendLayout();
            // 
            // imageT
            // 
            this.imageT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageT.Location = new System.Drawing.Point(741, 54);
            this.imageT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageT.Name = "imageT";
            this.imageT.Size = new System.Drawing.Size(300, 372);
            this.imageT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageT.TabIndex = 0;
            this.imageT.TabStop = false;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(241, 82);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(454, 29);
            this.txtfullname.TabIndex = 1;
            // 
            // cbogender
            // 
            this.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Trans Gender"});
            this.cbogender.Location = new System.Drawing.Point(241, 170);
            this.cbogender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(199, 32);
            this.cbogender.TabIndex = 2;
            // 
            // cbodesignation
            // 
            this.cbodesignation.AutoCompleteCustomSource.AddRange(new string[] {
            "Day Care Helper",
            "Day Care Teacher",
            "Primary School Teacher",
            "Account Manager",
            "Tuition Teacher"});
            this.cbodesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbodesignation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbodesignation.FormattingEnabled = true;
            this.cbodesignation.Items.AddRange(new object[] {
            "Day Care Helper",
            "Day Care Teacher",
            "Primary School Teacher",
            "Account Manager",
            "Tuition Teacher"});
            this.cbodesignation.Location = new System.Drawing.Point(241, 339);
            this.cbodesignation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbodesignation.Name = "cbodesignation";
            this.cbodesignation.Size = new System.Drawing.Size(454, 32);
            this.cbodesignation.TabIndex = 4;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(241, 534);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(454, 118);
            this.txtaddress.TabIndex = 6;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(241, 735);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(454, 29);
            this.txtphone.TabIndex = 7;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(241, 846);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(454, 29);
            this.txtemail.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(70, 850);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(135, 25);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Email address";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(70, 740);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 25);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Phone";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(70, 534);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(158, 25);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Contact Address";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(69, 350);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(115, 25);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Designation";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(69, 174);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 25);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Gender";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(69, 82);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 25);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Full Name";
            // 
            // bnsave
            // 
            this.bnsave.Location = new System.Drawing.Point(104, 1149);
            this.bnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(349, 98);
            this.bnsave.TabIndex = 12;
            this.bnsave.Text = "Save!";
            this.bnsave.UseVisualStyleBackColor = true;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // bnload
            // 
            this.bnload.Location = new System.Drawing.Point(741, 472);
            this.bnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnload.Name = "bnload";
            this.bnload.Size = new System.Drawing.Size(183, 90);
            this.bnload.TabIndex = 11;
            this.bnload.Text = "Load";
            this.bnload.UseVisualStyleBackColor = true;
            this.bnload.Click += new System.EventHandler(this.bnload_Click);
            // 
            // bnclear
            // 
            this.bnclear.Location = new System.Drawing.Point(946, 472);
            this.bnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(96, 93);
            this.bnclear.TabIndex = 19;
            this.bnclear.Text = "Clear";
            this.bnclear.UseVisualStyleBackColor = true;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(241, 264);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(274, 29);
            this.DateTimePicker1.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(70, 962);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(120, 25);
            this.Label10.TabIndex = 559;
            this.Label10.Text = "Monthly Pay";
            // 
            // bnclearing
            // 
            this.bnclearing.Location = new System.Drawing.Point(591, 1149);
            this.bnclearing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnclearing.Name = "bnclearing";
            this.bnclearing.Size = new System.Drawing.Size(345, 98);
            this.bnclearing.TabIndex = 13;
            this.bnclearing.Text = "Clear";
            this.bnclearing.UseVisualStyleBackColor = true;
            this.bnclearing.Click += new System.EventHandler(this.bnclearing_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(70, 430);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(119, 25);
            this.Label11.TabIndex = 562;
            this.Label11.Text = "Qualification";
            // 
            // txtqua
            // 
            this.txtqua.Location = new System.Drawing.Point(241, 430);
            this.txtqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtqua.Name = "txtqua";
            this.txtqua.Size = new System.Drawing.Size(454, 29);
            this.txtqua.TabIndex = 5;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Location = new System.Drawing.Point(241, 954);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(136, 29);
            this.ComboBox1.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(70, 264);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 25);
            this.Label1.TabIndex = 563;
            this.Label1.Text = "Date Of Birth";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(70, 1052);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(147, 25);
            this.Label6.TabIndex = 565;
            this.Label6.Text = "Date Of Joining";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(241, 1052);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(274, 29);
            this.dtp.TabIndex = 10;
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 1296);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.txtqua);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.bnclearing);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.bnload);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbodesignation);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.imageT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Teacher";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.PictureBox imageT;
        internal System.Windows.Forms.TextBox txtfullname;
        internal System.Windows.Forms.ComboBox cbogender;
        internal System.Windows.Forms.ComboBox cbodesignation;
        internal System.Windows.Forms.TextBox txtaddress;
        internal System.Windows.Forms.TextBox txtphone;
        internal System.Windows.Forms.TextBox txtemail;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button bnsave;
        internal System.Windows.Forms.Button bnload;
        internal System.Windows.Forms.Button bnclear;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button bnclearing;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtqua;
        internal System.Windows.Forms.TextBox ComboBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker dtp;
    }
    #endregion
}