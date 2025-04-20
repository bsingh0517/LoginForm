using LoginForm;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_Center
{
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        private void btnAddStudentInfo_Click(object sender, EventArgs e)
        {
            if (txtInstructorID.Text == "" || txtInstructorName.Text == "" || txtInstructorPhone.Text == "" || txtInstructorEmail.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO FACULTY (instructor_id, instructor_name, instructor_phone_number, instructor_email_address) VALUES (@instructor_id, @instructor_name, @instructor_phone_number, @instructor_email_address)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@instructor_id", txtInstructorID.Text);
                command.Parameters.AddWithValue("@instructor_name", txtInstructorName.Text);
                command.Parameters.AddWithValue("@instructor_phone_number", txtInstructorPhone.Text);
                command.Parameters.AddWithValue("@instructor_email_address", txtInstructorEmail.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Instructor Info Added Successfully!");
                conn.Close();
            }
        }

        private void btnGoToFacultyPage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmFacultyInfo form2 = new frmFacultyInfo();
            form2.Show();
        }
    }
}
