/*Kevin Nguyen
Agile Gamblers
Course Number (CISS 311)
Advanced Agile Development
30 Nov 2024*/
// I noticed the buttons and getting the syntax lined up is the hardest part other than collaboration.


using Project;

namespace CISS311_Agile_Gamblers_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open the enroll sutdent form
            EnrollStudent enrollstudent = new EnrollStudent();
            enrollstudent.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WhatCoursesStudentEnrolled whatCoursesStudentEnrolled = new WhatCoursesStudentEnrolled();   
            whatCoursesStudentEnrolled.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCourse addcourse = new AddCourse();
            addcourse.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // open who is in a course
            WhosInACourse whosinacourse = new WhosInACourse();
            whosinacourse.ShowDialog();
        }
    }
}
