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

// Mark Wehrwein
// CISS 311
// Assignment Final Project
// December 9, 2024
// Agile Gamblers

namespace CISS311_Agile_Gamblers_
{
    public partial class EnrollStudent : Form
    {
        public EnrollStudent()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            // load classes and students from database for combo boxs
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new("SELECT * FROM student", conn);
            DataTable studentTable = new();
            adapter.Fill(studentTable);
            studentComboBox.DisplayMember = "studentName";
            studentComboBox.ValueMember = "studentId";
            studentComboBox.DataSource = studentTable;

            using SqlDataAdapter adapter1 = new("SELECT * FROM course", conn);
            DataTable courseTable = new();
            adapter1.Fill(courseTable);
            courseComboBox.DisplayMember = "courseTitle";
            courseComboBox.ValueMember = "courseId";
            courseComboBox.DataSource = courseTable;

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            // see if student is already enrolled
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter2 = new("SELECT * FROM enrollment WHERE courseId = @courseId AND studentId = @studentId", conn);
            adapter2.SelectCommand.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);
            adapter2.SelectCommand.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue);
            DataTable enrollment = new();
            adapter2.Fill(enrollment);
            // check to see if student is already enrolled
            if (enrollment.Rows.Count > 0)
            {
                MessageBox.Show("Student is already enrolled in this class");
            }
            else
            {
                // if not enrolled, enroll student
                using SqlConnection conn1 = new(Properties.Settings.Default.connString);
                using SqlCommand comd = new("INSERT INTO enrollment(courseId, studentId) VALUES (@courseId, @studentID)", conn1);
                conn1.Open();
                comd.Parameters.AddWithValue("@courseId", courseComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue);
                comd.ExecuteNonQuery();
                // Show success message
                toolStripStatusLabel2.Text = "Student enrolled";                
            }      

        }
    }
}
