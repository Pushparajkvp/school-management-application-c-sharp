namespace SchoolManagementApplciation
{
    partial class AssociateService
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbojoiningterm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboname
            // 
            this.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(152, 25);
            this.cboname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(138, 21);
            this.cboname.TabIndex = 3;
            this.cboname.SelectedIndexChanged += new System.EventHandler(this.Cboname_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Associate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbojoiningterm
            // 
            this.cbojoiningterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbojoiningterm.FormattingEnabled = true;
            this.cbojoiningterm.Items.AddRange(new object[] {
            "First Term (june-sep)",
            "Second Term (oct-dec)",
            "Third Term (jan-mar)"});
            this.cbojoiningterm.Location = new System.Drawing.Point(152, 78);
            this.cbojoiningterm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbojoiningterm.Name = "cbojoiningterm";
            this.cbojoiningterm.Size = new System.Drawing.Size(138, 21);
            this.cbojoiningterm.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Joining Term";
            // 
            // AssociateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbojoiningterm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssociateService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssociateService";
            this.Load += new System.EventHandler(this.AssociateService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ComboBox cbojoiningterm;
        private System.Windows.Forms.Label label2;
    }
}