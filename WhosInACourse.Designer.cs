namespace CISS311_Agile_Gamblers_
{
    partial class WhosInACourse
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
            groupBox1 = new GroupBox();
            findButton = new Button();
            courseTitleLabel = new Label();
            courseIdTextBox = new TextBox();
            studentListBox = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(findButton);
            groupBox1.Controls.Add(courseTitleLabel);
            groupBox1.Controls.Add(courseIdTextBox);
            groupBox1.Controls.Add(studentListBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Course Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // findButton
            // 
            findButton.Location = new Point(327, 44);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 6;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // courseTitleLabel
            // 
            courseTitleLabel.AutoSize = true;
            courseTitleLabel.BorderStyle = BorderStyle.Fixed3D;
            courseTitleLabel.Location = new Point(125, 78);
            courseTitleLabel.Name = "courseTitleLabel";
            courseTitleLabel.Size = new Size(2, 17);
            courseTitleLabel.TabIndex = 5;
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(106, 42);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(100, 23);
            courseIdTextBox.TabIndex = 4;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(40, 143);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(497, 94);
            studentListBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 111);
            label3.Name = "label3";
            label3.Size = new Size(196, 15);
            label3.TabIndex = 2;
            label3.Text = "All Students Enrolled In This Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Course ID:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 344);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(630, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(270, 305);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // WhosInACourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 366);
            Controls.Add(closeButton);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Name = "WhosInACourse";
            Text = "WhosInACourse";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button findButton;
        private Label courseTitleLabel;
        private TextBox courseIdTextBox;
        private ListBox studentListBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button closeButton;
    }
}