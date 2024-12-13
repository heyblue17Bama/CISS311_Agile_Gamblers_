using System.Data.SqlClient;
using System.Data;

//Andy Suljic
//(CISS 311)
//Class Project
//12/2/24

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
            using SqlCommand comd = new("INSERT INTO Course(courseTitle," +
                " semesterOffered) VALUES(@courseTitle, @semesterOffered)", conn);
            conn.Open();
            comd.Parameters.AddWithValue("@courseTitle", textBox1.Text); //Course Textbox
            comd.Parameters.AddWithValue("@semesterOffered", textBox2.Text); //Semester date
            comd.ExecuteNonQuery(); //Saves the inputs
            MessageBox.Show("Course saved!");

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}