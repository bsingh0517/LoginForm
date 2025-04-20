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
    public partial class frmSectionInfo : Form
    {
        public frmSectionInfo()
        {
            InitializeComponent();
        }

        private void btnShowSectionInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT * FROM SECTION where section_id = @section_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@section_id", cmbSectionID.Text);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())

            {
                int column1Value = reader.GetInt32(0);
                string column2Value = reader.GetString(1);
                int column3Value = reader.GetInt32(2);
                string column4Value = reader.GetString(3);
                DateTime column5Value = reader.GetDateTime(4);
                DateTime column6Value = reader.GetDateTime(5);
                string column7Value = reader.GetString(6);

                lblSectionID.Text = "Section ID = " + column1Value.ToString();
                lblCourseID.Text = "Course ID = " + column2Value;
                lblInstructorID.Text = "Instructor ID = " + column3Value.ToString();
                lblSectionName.Text = "Section Name = " + column4Value.ToString();
                lblStartDate.Text = "Start Date = " + column5Value.ToString();
                lblEndDate.Text = "End Date = " + column6Value.ToString();
                lblTerm.Text = "Term = " + column7Value;
            }

            reader.Close();

            conn.Close();
        }

        private void fillComboSectionID()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            cmbSectionID.Items.Clear();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT section_id FROM SECTION";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbSectionID.Items.Add(dr["section_id"].ToString());
            }

            conn.Close();
        }
        private void SectionInfo_Load(object sender, EventArgs e)
        {
            fillComboSectionID();
        }

        private void btnGoToEnrollmentCenter_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEnrollmentCenter form2 = new frmEnrollmentCenter();
            form2.Show();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            frmAddSection form2 = new frmAddSection();
            form2.Show();
            this.Hide();
        }

      
    }
}
