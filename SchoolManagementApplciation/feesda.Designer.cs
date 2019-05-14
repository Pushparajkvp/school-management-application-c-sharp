namespace SchoolManagementApplciation
{
    partial class feesda
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.bnprint = new System.Windows.Forms.Button();
            this.document = new System.Drawing.Printing.PrintDocument();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(16, 69);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(1105, 29);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyUp);
            // 
            // bnprint
            // 
            this.bnprint.Location = new System.Drawing.Point(1169, 20);
            this.bnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnprint.Name = "bnprint";
            this.bnprint.Size = new System.Drawing.Size(426, 114);
            this.bnprint.TabIndex = 2;
            this.bnprint.Text = "Print The List";
            this.bnprint.UseVisualStyleBackColor = true;
            this.bnprint.Click += new System.EventHandler(this.bnprint_Click);
            // 
            // document
            // 
            this.document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 34);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(231, 25);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Enter The Name To Filter";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(21, 141);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1573, 776);
            this.DataGridView1.TabIndex = 4;
            // 
            // feesda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1612, 951);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bnprint);
            this.Controls.Add(this.txtsearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "feesda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.feesda_FormClosed);
            this.Load += new System.EventHandler(this.feesda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Button bnprint;
        internal System.Drawing.Printing.PrintDocument document;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.BindingSource FeesBindingSource;
        internal System.Windows.Forms.DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FullNameDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumberDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FeesDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DueDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridViewTextBoxColumn LastpaidDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView DataGridView1;
        #endregion
    }
}