namespace SchoolManagementApplciation
{
    partial class Selection
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
            this.teacher = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(126, 76);
            this.teacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(446, 135);
            this.teacher.TabIndex = 0;
            this.teacher.Text = "Teacher\'s Attendance";
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(126, 294);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(446, 135);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Student\'s Attendance";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(701, 574);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.teacher);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Selection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.Selection_Load);
            this.ResumeLayout(false);

        }
        internal System.Windows.Forms.Button teacher;
        internal System.Windows.Forms.Button Button1;

        #endregion
    }
}