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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void btnAddCourseInfo_Click(object sender, EventArgs e)
        {
            if (txtCourseID.Text == "" || txtCourseName.Text == "" || txtCreditHours.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO COURSE (course_id, course_name, credit_hours) VALUES (@course_id, @course_name, @credit_hours)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@course_id", txtCourseID.Text);
                command.Parameters.AddWithValue("@course_name", txtCourseName.Text);
                command.Parameters.AddWithValue("@credit_hours", txtCreditHours.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Course Info Added Successfully!");
                conn.Close();
            }
        }

        private void btnGoToCourseInfoPage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCourseInfo form2 = new frmCourseInfo();
            form2.Show();
        }

     
    }
}
