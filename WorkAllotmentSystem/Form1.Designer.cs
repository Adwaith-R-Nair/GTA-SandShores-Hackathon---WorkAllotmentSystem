namespace WorkAllotmentSystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.workname = new System.Windows.Forms.TextBox();
            this.skillsRequired = new System.Windows.Forms.CheckedListBox();
            this.experience = new System.Windows.Forms.TextBox();
            this.Skills = new System.Windows.Forms.CheckedListBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(622, 291);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(133, 69);
            this.Statistics.TabIndex = 1;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Register Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Register work";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // workname
            // 
            this.workname.Location = new System.Drawing.Point(103, 77);
            this.workname.Name = "workname";
            this.workname.Size = new System.Drawing.Size(93, 22);
            this.workname.TabIndex = 4;
            this.workname.Text = "jjjj";
            // 
            // skillsRequired
            // 
            this.skillsRequired.FormattingEnabled = true;
            this.skillsRequired.Items.AddRange(new object[] {
            "AIKnowledge",
            "Leadership",
            "TimeManagement",
            "Communication",
            "DatabaseKnowledge"});
            this.skillsRequired.Location = new System.Drawing.Point(91, 139);
            this.skillsRequired.Name = "skillsRequired";
            this.skillsRequired.Size = new System.Drawing.Size(175, 89);
            this.skillsRequired.TabIndex = 5;
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(626, 56);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(150, 22);
            this.experience.TabIndex = 6;
            // 
            // Skills
            // 
            this.Skills.FormattingEnabled = true;
            this.Skills.Items.AddRange(new object[] {
            "AIKnowledge",
            "Leadership",
            "TimeManagement",
            "Communication",
            "DatabaseKnowledge"});
            this.Skills.Location = new System.Drawing.Point(629, 102);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(172, 89);
            this.Skills.TabIndex = 7;
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(629, 12);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(153, 22);
            this.empname.TabIndex = 8;
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(69, 395);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(713, 22);
            this.debug.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.Skills);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.skillsRequired);
            this.Controls.Add(this.workname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox workname;
        private System.Windows.Forms.CheckedListBox skillsRequired;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.CheckedListBox Skills;
        private System.Windows.Forms.TextBox empname;
        private System.Windows.Forms.TextBox debug;
    }
}

