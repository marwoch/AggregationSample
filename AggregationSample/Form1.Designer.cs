namespace AggregationSample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.btnViewInstructor = new System.Windows.Forms.Button();
            this.btnViewRoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(13, 13);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(120, 95);
            this.lstCourses.TabIndex = 0;
            // 
            // btnViewInstructor
            // 
            this.btnViewInstructor.Location = new System.Drawing.Point(148, 13);
            this.btnViewInstructor.Name = "btnViewInstructor";
            this.btnViewInstructor.Size = new System.Drawing.Size(115, 42);
            this.btnViewInstructor.TabIndex = 1;
            this.btnViewInstructor.Text = "Instructor";
            this.btnViewInstructor.UseVisualStyleBackColor = true;
            this.btnViewInstructor.Click += new System.EventHandler(this.btnViewInstructor_Click);
            // 
            // btnViewRoster
            // 
            this.btnViewRoster.Location = new System.Drawing.Point(148, 66);
            this.btnViewRoster.Name = "btnViewRoster";
            this.btnViewRoster.Size = new System.Drawing.Size(115, 42);
            this.btnViewRoster.TabIndex = 2;
            this.btnViewRoster.Text = "Roster";
            this.btnViewRoster.UseVisualStyleBackColor = true;
            this.btnViewRoster.Click += new System.EventHandler(this.btnViewRoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.btnViewRoster);
            this.Controls.Add(this.btnViewInstructor);
            this.Controls.Add(this.lstCourses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnViewInstructor;
        private System.Windows.Forms.Button btnViewRoster;
    }
}

