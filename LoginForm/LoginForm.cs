using System.Data.SqlClient;
using Enrollment_Center;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /* This function closes the form */
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
        This function validates the username and password present in the database.
        */
        private void btnValidate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Login;Integrated Security=True;TrustServerCertificate=True");
            conn.Open();
            String query = "SELECT COUNT(*) FROM Login_all WHERE username  = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            int count = (int) cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success!");
                frmEnrollmentCenter form2 = new frmEnrollmentCenter();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Error!");
            }
        }
        
    }
}
