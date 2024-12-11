using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mark Wehrwein
// CISS 311
// Assignment Final Project
// December 9, 2024
// Agile Gamblers

namespace CISS311_Agile_Gamblers_
{
    public partial class WhosInACourse : Form
    {
        public WhosInACourse()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // close form
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            // load all courses for search
            using SqlConnection conn = new(Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new("SELECT * FROM course WHERE courseId = @courseId", conn);
            adapter.SelectCommand.Parameters.AddWithValue("@courseId", courseIdTextBox.Text);
            DataTable courseTable = new();
            adapter.Fill(courseTable);
            // verify at least one row filled
            if (courseTable.Rows.Count < 1)
            {
                toolStripStatusLabel1.Text = ("No course by that number");
                studentListBox.DataSource = null;
                studentListBox.Items.Clear();
                
            }
            else
            {
                string query = "SELECT student.studentId, student.studentName, enrollment.courseId FROM student JOIN enrollment ON student.studentId=enrollment.studentId WHERE enrollment.courseId = " + courseIdTextBox.Text;
                using SqlConnection conn1 = new(Properties.Settings.Default.connString);
                {
                    

                        conn1.Open();
                        SqlDataAdapter adapter1 = new SqlDataAdapter(query, conn1);
                        DataTable dataTable = new();

                        adapter1.Fill(dataTable);
                        studentListBox.Items.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                             string fillBox = "Student ID: " + row["studentId"].ToString() + " Student Name: " + row["studentName"].ToString();
                             studentListBox.Items.Add(fillBox);
                        }
                    
                }
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            courseIdTextBox.Focus();
            toolStripStatusLabel1.Text = ("");
        }
    }
}
