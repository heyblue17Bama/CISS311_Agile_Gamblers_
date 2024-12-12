namespace CISS311_Agile_Gamblers_
{
    partial class AddStudentForm
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
            addButton = new Button();
            closeButton = new Button();
            groupBox1 = new GroupBox();
            studentNameTextBox = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            feedbackToolStripStatusLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(165, 225);
            addButton.Name = "addButton";
            addButton.Size = new Size(146, 23);
            addButton.TabIndex = 0;
            addButton.Text = "Add a Student";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(465, 225);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(studentNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(closeButton);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 285);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Student Data";
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(266, 70);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(213, 23);
            studentNameTextBox.TabIndex = 3;
            studentNameTextBox.TextChanged += studentNameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 77);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 2;
            label1.Text = "New Student Name:";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { feedbackToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // feedbackToolStripStatusLabel
            // 
            feedbackToolStripStatusLabel.Name = "feedbackToolStripStatusLabel";
            feedbackToolStripStatusLabel.Size = new Size(94, 17);
            feedbackToolStripStatusLabel.Text = "Status message: ";
            feedbackToolStripStatusLabel.Click += feedbackToolStripStatusLabel_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Name = "AddStudentForm";
            Text = "Add Student Form";
            Load += AddStudentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button closeButton;
        private GroupBox groupBox1;
        private TextBox studentNameTextBox;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel feedbackToolStripStatusLabel;
    }
}