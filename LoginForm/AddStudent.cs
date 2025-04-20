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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudentInfo_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtStudentName.Text == "" || txtStudentPhone.Text == "" || txtStudentEmail.Text == "" || txtInstructorID.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO STUDENT (student_id, student_name, student_phone_number, student_email_address, instructor_id) VALUES (@student_id, @student_name, @student_phone_number, @student_email_address, @instructor_id)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@student_id", txtStudentID.Text);
                command.Parameters.AddWithValue("@student_name", txtStudentName.Text);
                command.Parameters.AddWithValue("@student_phone_number", txtStudentPhone.Text);
                command.Parameters.AddWithValue("@student_email_address", txtStudentEmail.Text);
                command.Parameters.AddWithValue("@instructor_id", txtInstructorID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Student Info Added Successfully!");
                conn.Close();
            }
        }

        private void btnGoToStudentInfoPage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStudentInfo form2 = new frmStudentInfo();
            form2.Show();
        }
    }
}
