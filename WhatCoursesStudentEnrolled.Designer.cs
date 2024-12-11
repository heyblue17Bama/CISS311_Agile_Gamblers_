namespace CISS311_Agile_Gamblers_
{
    partial class WhatCoursesStudentEnrolled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatCoursesStudentEnrolled));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            studentComboBox = new ComboBox();
            enrolledCoursesListBox = new ListBox();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(studentComboBox);
            groupBox1.Controls.Add(enrolledCoursesListBox);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(905, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(331, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 3;
            label2.Text = "Courses Enrolled";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 24);
            label1.TabIndex = 2;
            label1.Text = "Select A Student";
            // 
            // studentComboBox
            // 
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(278, 70);
            studentComboBox.Margin = new Padding(4, 3, 4, 3);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(297, 23);
            studentComboBox.TabIndex = 1;
            studentComboBox.SelectedIndexChanged += studentComboBox_SelectedIndexChanged;
            // 
            // enrolledCoursesListBox
            // 
            enrolledCoursesListBox.FormattingEnabled = true;
            enrolledCoursesListBox.ItemHeight = 15;
            enrolledCoursesListBox.Location = new Point(52, 173);
            enrolledCoursesListBox.Margin = new Padding(4, 3, 4, 3);
            enrolledCoursesListBox.Name = "enrolledCoursesListBox";
            enrolledCoursesListBox.Size = new Size(804, 214);
            enrolledCoursesListBox.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(335, 415);
            closeButton.Margin = new Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(211, 60);
            closeButton.TabIndex = 4;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // WhatCoursesStudentEnrolled
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(closeButton);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "WhatCoursesStudentEnrolled";
            Text = "WhatCoursesStudentEnrolled";
            Load += WhatCoursesStudentEnrolled_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ListBox enrolledCoursesListBox;
        private System.Windows.Forms.Button closeButton;
    }
}