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
    public partial class frmCourseInfo : Form
    {
        public frmCourseInfo()
        {
            InitializeComponent();
        }

        private void fillComboCourseID()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            cmbCourseID.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT course_id FROM COURSE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbCourseID.Items.Add(dr["course_id"].ToString());
            }

            conn.Close();
        }
        private void btnShowCourseInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT * FROM COURSE where course_id = @course_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@course_id", cmbCourseID.Text);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())

            {
                string column1Value = reader.GetString(0);
                string column2Value = reader.GetString(1);
                int column3Value = reader.GetInt32(2);

                lblCourseID.Text = "Course ID = " + column1Value.ToString();
                lblCourseName.Text = "Course Name = " + column2Value;
                lblCreditHours.Text = "Credit Hours = " + column3Value.ToString();
            }

            reader.Close();

            conn.Close();
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            fillComboCourseID();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse form2 = new frmAddCourse();
            form2.Show();
            this.Hide();
        }

        private void btnGoToEnrollmentCenter_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEnrollmentCenter form2 = new frmEnrollmentCenter();
            form2.Show();
        }
    }
}
