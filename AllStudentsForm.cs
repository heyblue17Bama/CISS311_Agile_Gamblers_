using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISS311_Agile_Gamblers_
{
    public partial class AllStudentsForm : Form
    {
        public AllStudentsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) //closes the window app.
        {
            this.Close();
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllStudentsForm_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.connString;
            string query = "SELECT studentID, studentName FROM student";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                studentGridView.DataSource = dataTable;
            }
        }
    }
}
