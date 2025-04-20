using Enrollment_Center;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginForm
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            fillComboStudentID();
        }

        private void fillComboStudentID()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            cmbStudentID.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT student_id FROM STUDENT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbStudentID.Items.Add(dr["student_id"].ToString());
            }

            conn.Close();
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT * FROM STUDENT where student_id = @student_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@student_id", cmbStudentID.Text);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())

            {
                int column1Value = reader.GetInt32(0);
                string column2Value = reader.GetString(1);
                string column3Value = reader.GetString(2);
                string column4Value = reader.GetString(3);


                lblStudentID.Text = "Student ID = " + column1Value.ToString();
                lblStudentName.Text = "Student Name = " + column2Value;
                lblStudentPhoneNum.Text = "Student Phone # = " + column3Value;
                lblStudentEmail.Text = "Student Email = " + column4Value;
            }

            reader.Close();

            conn.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent form2 = new frmAddStudent();
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
