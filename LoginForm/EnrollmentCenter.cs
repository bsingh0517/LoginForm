using Enrollment_Center;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class frmEnrollmentCenter : Form
    {
        public frmEnrollmentCenter()
        {
            InitializeComponent();
        }

        private void BtnViewStudent_Click(object sender, EventArgs e)
        {
            frmStudentInfo form2 = new frmStudentInfo();
            form2.Show();
            this.Hide();
        }

        private void btnViewFaculty_Click(object sender, EventArgs e)
        {
            frmFacultyInfo form3 = new frmFacultyInfo();
            form3.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            frmCourseInfo form2 = new frmCourseInfo();
            form2.Show();
            this.Hide();
        }

        private void btnViewSection_Click(object sender, EventArgs e)
        {
            frmSectionInfo form2 = new frmSectionInfo();
            form2.Show();
            this.Hide();
        }

        private void btnViewSectionSchedule_Click(object sender, EventArgs e)
        {
            frmSectionScheduleInfo form2 = new frmSectionScheduleInfo();
            form2.Show();
            this.Hide();
        }
    }
}
