using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CISS311_Agile_Gamblers_
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlCommand comd = new("INSERT INTO student(studentName) VALUES (@studentName)", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@studentName", studentNameTextBox.Text);
            //comd.Parameters.AddWithValue("@courseId", advisorComboBox.SelectedValue.ToString());
            comd.ExecuteNonQuery();
            MessageBox.Show("Student Saved.");


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void feedbackToolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
