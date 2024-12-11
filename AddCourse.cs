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

namespace Project
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            //loadws the database and table
            using SqlConnection conn = new(CISS311_Agile_Gamblers_.Properties.Settings.Default.connString);
            using SqlDataAdapter adapter = new("SELECT * FROM Course", conn);
            DataTable courseTable = new();
            adapter.Fill(courseTable);
             
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(CISS311_Agile_Gamblers_.Properties.Settings.Default.connString);
            
            using SqlCommand comd = new("INSERT INTO course(courseTitle," +
                " courseId) VALUES(@courseTitle, @courseId)", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseTitle", textBox1.Text); //Course Textbox
            comd.Parameters.AddWithValue("@semesterOffered", textBox2.Text); //Semester date
            comd.ExecuteNonQuery();
            MessageBox.Show("Course saved!");

        }
    }
}