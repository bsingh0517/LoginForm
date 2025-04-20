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
    public partial class frmAddSectionSchedule : Form
    {
        public frmAddSectionSchedule()
        {
            InitializeComponent();
        }

        private void btnAddSectionScheduleInfo_Click(object sender, EventArgs e)
        {
            if (txtLocation.Text == "" || txtRoomNum.Text == "" || txtDays.Text == "" || txtStartTIme.Text == "" || txtEndTime.Text == "" || txtSectionID.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
                return;
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BS_Student_Enrollment;Integrated Security=True;TrustServerCertificate=True");
                conn.Open();
                string query = "INSERT INTO SECTIONSCHEDULE (location, room_number, days, start_time, end_time, section_ID) VALUES (@location, @room_number, @days, @start_time, @end_time, @section_ID)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@location", txtLocation.Text);
                command.Parameters.AddWithValue("@room_number", txtRoomNum.Text);
                command.Parameters.AddWithValue("@days", txtDays.Text);

                command.Parameters.AddWithValue("@start_time", txtStartTIme.Text);
                command.Parameters.AddWithValue("@end_time", txtEndTime.Text);
                command.Parameters.AddWithValue("@section_id", txtSectionID.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Section Schedule Info Added Successfully!");
                conn.Close();
            }
        }

        private void btnGoToSectionSchedhuleInfoPage_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSectionScheduleInfo form2 = new frmSectionScheduleInfo();
            form2.Show();
        }
    }
}
