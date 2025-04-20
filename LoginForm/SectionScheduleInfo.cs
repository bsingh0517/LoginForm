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
    public partial class frmSectionScheduleInfo : Form
    {
        public frmSectionScheduleInfo()
        {
            InitializeComponent();
        }

        private void btnShowSectionScheduleInfo_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            string query = "SELECT * FROM SECTIONSCHEDULE where section_id = @section_id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@section_id", cmbSectionID.Text);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.Read())

            {
                string column1Value = reader.GetString(0);
                int column2Value = reader.GetInt32(1);
                string column3Value = reader.GetString(2);
                DateTime column4Value = reader.GetDateTime(3);
                DateTime column5Value = reader.GetDateTime(4);
                int column6Value = reader.GetInt32(5);

                lblLocation.Text = "Location = " + column1Value;
                lblRoomNum.Text = "Room Number = " + column2Value;
                lblDays.Text = "Days = " + column3Value;
                lblStartTime.Text = "Start Time = " + column4Value.ToString();
                lblEndTIme.Text = "End Time = " + column5Value.ToString();
                lblSectionID.Text = "Section ID = " + column6Value.ToString();

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
            cmd.CommandText = "SELECT section_id FROM SECTIONSCHEDULE";
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

        private void frmSectionScheduleInfo_Load(object sender, EventArgs e)
        {
            fillComboSectionID();
        }

        private void btnGoToEnrollmentCenter_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEnrollmentCenter form2 = new frmEnrollmentCenter();
            form2.Show();
        }

        private void btnAddSectionSchedule_Click(object sender, EventArgs e)
        {
            frmAddSectionSchedule form2 = new frmAddSectionSchedule();
            form2.Show();
            this.Hide();
        }
    }
}
