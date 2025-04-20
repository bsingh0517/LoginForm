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
    public partial class frmFacultyInfo : Form
    {
        public frmFacultyInfo()
        {
            InitializeComponent();
        }

        private void fillComboInstructorID()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            cmbInstructorID.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT instructor_id FROM FACULTY";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbInstructorID.Items.Add(dr["instructor_id"].ToString());
            }

            conn.Close();
        }
        private void btnShowInstructorInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT * FROM FACULTY where instructor_id = @instructor_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@instructor_id", cmbInstructorID.Text);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())

            {
                int column1Value = reader.GetInt32(0);
                string column2Value = reader.GetString(1);
                string column3Value = reader.GetString(2);
                string column4Value = reader.GetString(3);


                lblInstructorID.Text = "Instructor ID = " + column1Value.ToString();
                lblInstructorName.Text = "Instructor Name = " + column2Value;
                lblInstructorPhoneNum.Text = "Instructor Phone # = " + column3Value;
                lblInstructorEmail.Text = "Instructor Email = " + column4Value;
            }

            reader.Close();

            conn.Close();
        }

        private void frmFacultyInfo_Load(object sender, EventArgs e)
        {
            fillComboInstructorID();
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            frmAddInstructor form4 = new frmAddInstructor();
            form4.Show();
            this.Hide();
        }

        private void btnGoToEnrollmentCenter_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEnrollmentCenter form3 = new frmEnrollmentCenter();
            form3.Show();
        }
    }
}
