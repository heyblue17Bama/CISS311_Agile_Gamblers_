namespace CISS311_Agile_Gamblers_
{
    partial class EnrollStudent
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
            studentComboBox = new ComboBox();
            courseComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            enrollButton = new Button();
            closeButton = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(studentComboBox);
            groupBox1.Controls.Add(courseComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enroll a student";
            // 
            // studentComboBox
            // 
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Location = new Point(192, 48);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new Size(121, 23);
            studentComboBox.TabIndex = 4;
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(192, 93);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(121, 23);
            courseComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 96);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Select a Course:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a Student:";
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(113, 225);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(75, 23);
            enrollButton.TabIndex = 1;
            enrollButton.Text = "&Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += enrollButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(302, 226);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 290);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(563, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // EnrollStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 312);
            Controls.Add(statusStrip1);
            Controls.Add(closeButton);
            Controls.Add(enrollButton);
            Controls.Add(groupBox1);
            Name = "EnrollStudent";
            Text = "EnrollStudent";
            Load += EnrollStudent_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox studentComboBox;
        private ComboBox courseComboBox;
        private Label label2;
        private Label label1;
        private Button enrollButton;
        private Button closeButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}