namespace SchoolManagementApplciation
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cboclass = new System.Windows.Forms.ComboBox();
            this.cbostream = new System.Windows.Forms.ComboBox();
            this.bnloadpicture = new System.Windows.Forms.Button();
            this.bnclearpictue = new System.Windows.Forms.Button();
            this.bnclear = new System.Windows.Forms.Button();
            this.bnsave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.Mtxt = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Ftxt = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(901, 129);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(522, 29);
            this.txtfullname.TabIndex = 2;
            // 
            // cbogender
            // 
            this.cbogender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Trans Gender"});
            this.cbogender.Location = new System.Drawing.Point(88, 372);
            this.cbogender.Margin = new System.Windows.Forms.Padding(4);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(165, 32);
            this.cbogender.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(901, 372);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtaddress.Size = new System.Drawing.Size(522, 91);
            this.txtaddress.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(99, 581);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(561, 29);
            this.txtphone.TabIndex = 9;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(902, 581);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(522, 29);
            this.txtemail.TabIndex = 10;
            // 
            // cboclass
            // 
            this.cboclass.AutoCompleteCustomSource.AddRange(new string[] {
            "Play School",
            "Tuition",
            "Day Care",
            "Pre KG",
            "LKG"});
            this.cboclass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboclass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboclass.CausesValidation = false;
            this.cboclass.FormattingEnabled = true;
            this.cboclass.Items.AddRange(new object[] {
            "Play School",
            "Tuition",
            "Day Care",
            "Pre KG",
            "LKG"});
            this.cboclass.Location = new System.Drawing.Point(103, 690);
            this.cboclass.Margin = new System.Windows.Forms.Padding(4);
            this.cboclass.Name = "cboclass";
            this.cboclass.Size = new System.Drawing.Size(318, 32);
            this.cboclass.TabIndex = 11;
            // 
            // cbostream
            // 
            this.cbostream.AutoCompleteCustomSource.AddRange(new string[] {
            "Undivided",
            "A",
            "B",
            "C",
            "D"});
            this.cbostream.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbostream.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbostream.FormattingEnabled = true;
            this.cbostream.Items.AddRange(new object[] {
            "Undivided",
            "A",
            "B",
            "C",
            "D"});
            this.cbostream.Location = new System.Drawing.Point(901, 690);
            this.cbostream.Margin = new System.Windows.Forms.Padding(4);
            this.cbostream.Name = "cbostream";
            this.cbostream.Size = new System.Drawing.Size(309, 32);
            this.cbostream.TabIndex = 12;
            // 
            // bnloadpicture
            // 
            this.bnloadpicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnloadpicture.Location = new System.Drawing.Point(1320, 833);
            this.bnloadpicture.Margin = new System.Windows.Forms.Padding(4);
            this.bnloadpicture.Name = "bnloadpicture";
            this.bnloadpicture.Size = new System.Drawing.Size(103, 76);
            this.bnloadpicture.TabIndex = 13;
            this.bnloadpicture.Text = "LOAD";
            this.bnloadpicture.UseVisualStyleBackColor = true;
            this.bnloadpicture.Click += new System.EventHandler(this.bnloadpicture_Click);
            // 
            // bnclearpictue
            // 
            this.bnclearpictue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnclearpictue.Location = new System.Drawing.Point(1320, 918);
            this.bnclearpictue.Margin = new System.Windows.Forms.Padding(4);
            this.bnclearpictue.Name = "bnclearpictue";
            this.bnclearpictue.Size = new System.Drawing.Size(103, 80);
            this.bnclearpictue.TabIndex = 16;
            this.bnclearpictue.Text = "Clear";
            this.bnclearpictue.UseVisualStyleBackColor = true;
            this.bnclearpictue.Click += new System.EventHandler(this.bnclearpictue_Click);
            // 
            // bnclear
            // 
            this.bnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnclear.Location = new System.Drawing.Point(565, 861);
            this.bnclear.Margin = new System.Windows.Forms.Padding(4);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(319, 138);
            this.bnclear.TabIndex = 15;
            this.bnclear.Text = "Clear";
            this.bnclear.UseVisualStyleBackColor = true;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // bnsave
            // 
            this.bnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnsave.Location = new System.Drawing.Point(103, 863);
            this.bnsave.Margin = new System.Windows.Forms.Padding(4);
            this.bnsave.Name = "bnsave";
            this.bnsave.Size = new System.Drawing.Size(311, 136);
            this.bnsave.TabIndex = 14;
            this.bnsave.Text = "Save!";
            this.bnsave.UseVisualStyleBackColor = true;
            this.bnsave.Click += new System.EventHandler(this.bnsave_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(84, 99);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(188, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Registration Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(897, 99);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(404, 25);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Full Name Of  The Student With Initial At Last";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(84, 342);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 25);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Gender";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(446, 342);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(123, 25);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Date Of Birth";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(897, 342);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(158, 25);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Contact Address";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(98, 538);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(423, 25);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Contact Phone Number (Parents Recomended)";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(901, 538);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(138, 25);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Email Address";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(103, 655);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 25);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Class";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(901, 655);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(78, 25);
            this.Label9.TabIndex = 22;
            this.Label9.Text = "Section";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(1119, 780);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(150, 25);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "Student\'s Photo";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(441, 14);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(608, 59);
            this.Label11.TabIndex = 24;
            this.Label11.Text = "Welcome To Little Vinu !";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(88, 129);
            this.txtregno.Margin = new System.Windows.Forms.Padding(4);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(565, 29);
            this.txtregno.TabIndex = 1;
            this.txtregno.TextChanged += new System.EventHandler(this.txtregno_TextChanged);
            // 
            // Mtxt
            // 
            this.Mtxt.Location = new System.Drawing.Point(88, 270);
            this.Mtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Mtxt.Name = "Mtxt";
            this.Mtxt.Size = new System.Drawing.Size(565, 29);
            this.Mtxt.TabIndex = 3;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(84, 240);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(144, 25);
            this.Label14.TabIndex = 31;
            this.Label14.Text = "Mother\'s Name";
            // 
            // Ftxt
            // 
            this.Ftxt.Location = new System.Drawing.Point(901, 270);
            this.Ftxt.Margin = new System.Windows.Forms.Padding(4);
            this.Ftxt.Name = "Ftxt";
            this.Ftxt.Size = new System.Drawing.Size(535, 29);
            this.Ftxt.TabIndex = 4;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(896, 240);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(156, 25);
            this.Label15.TabIndex = 33;
            this.Label15.Text = "Father\'s Number";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(450, 372);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(194, 29);
            this.dtp.TabIndex = 6;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(1124, 833);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(137, 166);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1501, 1049);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.Ftxt);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Mtxt);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bnsave);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.bnclearpictue);
            this.Controls.Add(this.bnloadpicture);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cbostream);
            this.Controls.Add(this.cboclass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.txtfullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.TextBox Txtfullname;
        private System.Windows.Forms.ComboBox bogender;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cboclass;
        private System.Windows.Forms.ComboBox cbostream;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button bnloadpicture;
        private System.Windows.Forms.Button bnclearpictue;
        private System.Windows.Forms.Button bnclear;
        private System.Windows.Forms.Button bnsave;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.TextBox Mtxt;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.TextBox Ftxt;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.DateTimePicker dtp;
    }

    #endregion
}