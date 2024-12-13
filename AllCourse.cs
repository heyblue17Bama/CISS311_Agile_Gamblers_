using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project
{
    //Andy Suljic
    //(CISS 311)
    //Class Project
    //12/12/24

    public partial class AllCourse : Form
    {
        public AllCourse()
        {
            InitializeComponent();
        }

        private void AllCourse_Load(object sender, EventArgs e)
        {
            //loads the query and such
            string connectionString = CISS311_Agile_Gamblers_.Properties.Settings.Default.connString;
            string query = "SELECT courseId, courseTitle, semesterOffered FROM course";

            //loads the value into the data grid
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; 
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }
    }
}
