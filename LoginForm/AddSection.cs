using LoginForm;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Enrollment_Center
{
    public partial class frmAddSection : Form
    {
        public frmAddSection()
        {
            InitializeComponent();
        }

        private void btnAddSectionInfo_Click(object sender, EventArgs e)
        {
            if (txtSectionID.Text == "" || txtSectionName.Text == "" || txtTerm.Text == "" || txtCourseID.Text == "" || txtInstructorID.Text == "" || txtStartDate.Text == "" || txtEndDate.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO SECTION (section_id, course_id, instructor_id, section_name, start_date, end_date, term) VALUES (@section_id, @course_id, @instructor_id, @section_name, @start_date, @end_date, @term)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@section_id", txtSectionID.Text);
                command.Parameters.AddWithValue("@course_id", txtCourseID.Text);
                command.Parameters.AddWithValue("@instructor_id", txtInstructor_ID.Text);
                
                command.Parameters.AddWithValue("@section_name", txtSectionName.Text);
                command.Parameters.AddWithValue("@start_date", txtStartDate.Text);
                command.Parameters.AddWithValue("@end_date", txtEndDate.Text);

                command.Parameters.AddWithValue("@term", txtTerm.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Section Info Added Successfully!");
                conn.Close();
            }
        }

        private void btnGoToSectionInfoPage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSectionInfo form2 = new frmSectionInfo();
            form2.Show();
        }
    }
}