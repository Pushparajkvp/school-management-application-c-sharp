namespace SchoolManagementApplciation
{
    partial class ManageTeacher
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.bnadd = new System.Windows.Forms.Button();
            this.bnrefresh = new System.Windows.Forms.Button();
            this.bndelete = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.bnprint = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(26, 57);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(1558, 29);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
            // 
            // bnadd
            // 
            this.bnadd.Location = new System.Drawing.Point(26, 858);
            this.bnadd.Margin = new System.Windows.Forms.Padding(4);
            this.bnadd.Name = "bnadd";
            this.bnadd.Size = new System.Drawing.Size(353, 88);
            this.bnadd.TabIndex = 2;
            this.bnadd.Text = "Add New Teacher";
            this.bnadd.UseVisualStyleBackColor = true;
            this.bnadd.Click += new System.EventHandler(this.Bnadd_Click);
            // 
            // bnrefresh
            // 
            this.bnrefresh.Location = new System.Drawing.Point(830, 858);
            this.bnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(353, 88);
            this.bnrefresh.TabIndex = 4;
            this.bnrefresh.Text = "Refresh";
            this.bnrefresh.UseVisualStyleBackColor = true;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // bndelete
            // 
            this.bndelete.Location = new System.Drawing.Point(426, 858);
            this.bndelete.Margin = new System.Windows.Forms.Padding(4);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(353, 88);
            this.bndelete.TabIndex = 5;
            this.bndelete.Text = "Delete Selected Teacher Records";
            this.bndelete.UseVisualStyleBackColor = true;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 27);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 25);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Search";
            // 
            // bnprint
            // 
            this.bnprint.Location = new System.Drawing.Point(1232, 858);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(353, 88);
            this.bnprint.TabIndex = 3;
            this.bnprint.Text = "Close";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(26, 117);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1559, 717);
            this.DataGridView1.TabIndex = 7;
            // 
            // ManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1609, 978);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bndelete);
            this.Controls.Add(this.bnrefresh);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnadd);
            this.Controls.Add(this.TextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageTeacher";
            this.Load += new System.EventHandler(this.ManageTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button bnadd;
        internal System.Windows.Forms.Button bnrefresh;
        internal System.Windows.Forms.Button bndelete;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn StaffIDDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FullNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.DataGridView DataGridView1;

        #endregion
    }
}