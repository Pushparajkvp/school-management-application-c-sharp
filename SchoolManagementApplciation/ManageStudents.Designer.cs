namespace SchoolManagementApplciation
{
    partial class ManageStudents
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bnnew = new System.Windows.Forms.Button();
            this.bnprint = new System.Windows.Forms.Button();
            this.bndelete = new System.Windows.Forms.Button();
            this.bnrefresh = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(16, 92);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1578, 746);
            this.DataGridView1.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(18, 50);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(1576, 29);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyUp);
            // 
            // bnnew
            // 
            this.bnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnnew.Location = new System.Drawing.Point(87, 909);
            this.bnnew.Margin = new System.Windows.Forms.Padding(4);
            this.bnnew.Name = "bnnew";
            this.bnnew.Size = new System.Drawing.Size(316, 124);
            this.bnnew.TabIndex = 2;
            this.bnnew.Text = "Add New Student";
            this.bnnew.UseVisualStyleBackColor = true;
            this.bnnew.Click += new System.EventHandler(this.bnnew_Click);
            // 
            // bnprint
            // 
            this.bnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnprint.Location = new System.Drawing.Point(1220, 909);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(316, 124);
            this.bnprint.TabIndex = 3;
            this.bnprint.Text = "Edit";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // bndelete
            // 
            this.bndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bndelete.Location = new System.Drawing.Point(852, 909);
            this.bndelete.Margin = new System.Windows.Forms.Padding(4);
            this.bndelete.Name = "bndelete";
            this.bndelete.Size = new System.Drawing.Size(316, 124);
            this.bndelete.TabIndex = 4;
            this.bndelete.Text = "Delete";
            this.bndelete.UseVisualStyleBackColor = true;
            this.bndelete.Click += new System.EventHandler(this.bndelete_Click);
            // 
            // bnrefresh
            // 
            this.bnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnrefresh.Location = new System.Drawing.Point(456, 909);
            this.bnrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.bnrefresh.Name = "bnrefresh";
            this.bnrefresh.Size = new System.Drawing.Size(316, 124);
            this.bnrefresh.TabIndex = 5;
            this.bnrefresh.Text = "Refresh";
            this.bnrefresh.UseVisualStyleBackColor = true;
            this.bnrefresh.Click += new System.EventHandler(this.bnrefresh_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 20);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(176, 25);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Enter Name to filter";
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1612, 1095);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bnrefresh);
            this.Controls.Add(this.bndelete);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.bnnew);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Student";
            this.Load += new System.EventHandler(this.ManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.DataGridViewTextBoxColumn EmailAddressDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button bnnew;
        internal System.Windows.Forms.Button bnprint;
        internal System.Windows.Forms.Button bndelete;
        internal System.Windows.Forms.Button bnrefresh;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FullNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ContactPhoneNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal System.Windows.Forms.Label Label1;

        #endregion
    }
}