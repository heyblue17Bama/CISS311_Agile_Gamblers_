namespace CISS311_Agile_Gamblers_
{
    partial class AllStudentsForm
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
            studentGridView = new DataGridView();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // studentGridView
            // 
            studentGridView.AllowUserToAddRows = false;
            studentGridView.AllowUserToDeleteRows = false;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Location = new Point(202, 110);
            studentGridView.Name = "studentGridView";
            studentGridView.ReadOnly = true;
            studentGridView.Size = new Size(462, 150);
            studentGridView.TabIndex = 0;
            studentGridView.CellContentClick += studentGridView_CellContentClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(151, 338);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(177, 52);
            closeButton.TabIndex = 1;
            closeButton.Text = "Cl&ose";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AllStudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(studentGridView);
            Name = "AllStudentsForm";
            Text = "All Students Form";
            Load += AllStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentGridView;
        private Button closeButton;
    }
}