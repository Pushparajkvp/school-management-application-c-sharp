namespace SchoolManagementApplciation
{
    partial class EnterMarkss
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.bnload = new System.Windows.Forms.Button();
            this.cbosub = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblcurentdate = new System.Windows.Forms.Label();
            this.bnclear = new System.Windows.Forms.Button();
            this.bnprint = new System.Windows.Forms.Button();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(0, 342);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1690, 668);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
            this.DataGridView1.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGridView1_CellParsing);
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(38, 88);
            this.cboname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(338, 32);
            this.cboname.TabIndex = 1;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.cboname_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(880, 69);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(274, 29);
            this.dtp.TabIndex = 2;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // bnload
            // 
            this.bnload.Location = new System.Drawing.Point(494, 54);
            this.bnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnload.Name = "bnload";
            this.bnload.Size = new System.Drawing.Size(219, 86);
            this.bnload.TabIndex = 3;
            this.bnload.Text = "LOAD";
            this.bnload.UseVisualStyleBackColor = true;
            this.bnload.Click += new System.EventHandler(this.bnload_Click);
            // 
            // cbosub
            // 
            this.cbosub.AutoCompleteCustomSource.AddRange(new string[] {
            "Maths",
            "Physics",
            "English",
            "Chemisty",
            "History",
            "Econmics",
            "Computer Science",
            "Bussinesss Maths",
            "Civics",
            "Tamil",
            "Hindi",
            "French",
            "Biology",
            "Science",
            "Zoology",
            "Botany",
            "Ariviyal Tamil",
            "English",
            "Geography",
            " Environmental Science",
            " Agricultural Science",
            "Commercial Studies",
            "Technical Drawing",
            "Drawing",
            "Abacus",
            "SST"});
            this.cbosub.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbosub.FormattingEnabled = true;
            this.cbosub.Location = new System.Drawing.Point(43, 207);
            this.cbosub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbosub.Name = "cbosub";
            this.cbosub.Size = new System.Drawing.Size(334, 32);
            this.cbosub.TabIndex = 4;
            this.cbosub.SelectedIndexChanged += new System.EventHandler(this.cbosub_SelectedIndexChanged);
            this.cbosub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbosub_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(43, 172);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(129, 25);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Enter Subject";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(38, 54);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(115, 25);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Enter Name";
            // 
            // lblcurentdate
            // 
            this.lblcurentdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurentdate.Location = new System.Drawing.Point(873, 130);
            this.lblcurentdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcurentdate.Name = "lblcurentdate";
            this.lblcurentdate.Size = new System.Drawing.Size(286, 100);
            this.lblcurentdate.TabIndex = 7;
            this.lblcurentdate.Text = "Label3";
            this.lblcurentdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnclear
            // 
            this.bnclear.Location = new System.Drawing.Point(494, 182);
            this.bnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnclear.Name = "bnclear";
            this.bnclear.Size = new System.Drawing.Size(219, 84);
            this.bnclear.TabIndex = 8;
            this.bnclear.Text = "Delete Record";
            this.bnclear.UseVisualStyleBackColor = true;
            this.bnclear.Click += new System.EventHandler(this.bnclear_Click);
            // 
            // bnprint
            // 
            this.bnprint.Location = new System.Drawing.Point(1282, 69);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(316, 100);
            this.bnprint.TabIndex = 9;
            this.bnprint.Text = "PRINT";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // EnterMarkss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1690, 1010);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnclear);
            this.Controls.Add(this.lblcurentdate);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbosub);
            this.Controls.Add(this.bnload);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.DataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EnterMarkss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Marks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Entermarkss_FormClosed);
            this.Load += new System.EventHandler(this.Entermarkss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ComboBox cboname;
        internal System.Windows.Forms.DateTimePicker dtp;
        internal System.Windows.Forms.Button bnload;
        internal System.Windows.Forms.ComboBox cbosub;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblcurentdate;
        internal System.Windows.Forms.Button bnclear;
        internal System.Windows.Forms.Button bnprint;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
    }

    #endregion
}