//WhatCoursesStudentEnrolled
//Ryan Furniss
//CISS 311
//12-10-24

// Having trouble getting the actual design of the form to show when "What Courses Student Enrolled" button is clicked.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS311_Agile_Gamblers_
{
    public partial class WhatCoursesStudentEnrolled : Form
    {

        public WhatCoursesStudentEnrolled()
        {
            InitializeComponent();
        }
        [Obsolete]
        private void WhatCoursesStudentEnrolled_Load(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM student", conn);
            {
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                studentComboBox.DisplayMember = "studentName";
                studentComboBox.ValueMember = "studentId";
                studentComboBox.DataSource = studentTable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //following line closes form
            Close();
        }

        [Obsolete]
        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            //using (SqlCommand comd = new SqlCommand("SELECT coursesEnrolled FROM student " + "WHERE student.studentId = @studentId", conn))
            using SqlCommand comd = new("SELECT course.courseTitle FROM enrollment JOIN course ON enrollment.courseId = course.courseID WHERE studentId = @studentId", conn);
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@studentId", studentComboBox.SelectedValue.ToString());
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);
                enrolledCoursesListBox.DisplayMember = "courseTitle";
                enrolledCoursesListBox.ValueMember = "studentId";
                enrolledCoursesListBox.DataSource = studentTable;
            }
        }
    }
}
