namespace LoginForm
{
    partial class frmEnrollmentCenter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnViewFaculty = new Button();
            btnViewCourse = new Button();
            btnViewStudent = new Button();
            btnViewSection = new Button();
            btnViewSectionSchedule = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(205, 42);
            label1.Name = "label1";
            label1.Size = new Size(832, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Enrollment Center";
            // 
            // btnViewFaculty
            // 
            btnViewFaculty.BackColor = Color.FromArgb(192, 255, 192);
            btnViewFaculty.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewFaculty.ForeColor = Color.Maroon;
            btnViewFaculty.Location = new Point(31, 146);
            btnViewFaculty.Name = "btnViewFaculty";
            btnViewFaculty.Size = new Size(459, 80);
            btnViewFaculty.TabIndex = 1;
            btnViewFaculty.Text = "View Faculty";
            btnViewFaculty.UseVisualStyleBackColor = false;
            btnViewFaculty.Click += btnViewFaculty_Click;
            // 
            // btnViewCourse
            // 
            btnViewCourse.BackColor = Color.FromArgb(192, 255, 192);
            btnViewCourse.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewCourse.ForeColor = Color.Maroon;
            btnViewCourse.Location = new Point(31, 344);
            btnViewCourse.Name = "btnViewCourse";
            btnViewCourse.Size = new Size(459, 80);
            btnViewCourse.TabIndex = 2;
            btnViewCourse.Text = "View Course";
            btnViewCourse.UseVisualStyleBackColor = false;
            btnViewCourse.Click += btnViewCourse_Click;
            // 
            // btnViewStudent
            // 
            btnViewStudent.BackColor = Color.FromArgb(192, 255, 192);
            btnViewStudent.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStudent.ForeColor = Color.Maroon;
            btnViewStudent.Location = new Point(31, 249);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new Size(459, 80);
            btnViewStudent.TabIndex = 3;
            btnViewStudent.Text = "View Student";
            btnViewStudent.UseVisualStyleBackColor = false;
            btnViewStudent.Click += BtnViewStudent_Click;
            // 
            // btnViewSection
            // 
            btnViewSection.BackColor = Color.FromArgb(192, 255, 192);
            btnViewSection.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSection.ForeColor = Color.Maroon;
            btnViewSection.Location = new Point(31, 430);
            btnViewSection.Name = "btnViewSection";
            btnViewSection.Size = new Size(459, 80);
            btnViewSection.TabIndex = 4;
            btnViewSection.Text = "View Section";
            btnViewSection.UseVisualStyleBackColor = false;
            btnViewSection.Click += btnViewSection_Click;
            // 
            // btnViewSectionSchedule
            // 
            btnViewSectionSchedule.BackColor = Color.FromArgb(192, 255, 192);
            btnViewSectionSchedule.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSectionSchedule.ForeColor = Color.Maroon;
            btnViewSectionSchedule.Location = new Point(31, 531);
            btnViewSectionSchedule.Name = "btnViewSectionSchedule";
            btnViewSectionSchedule.Size = new Size(592, 80);
            btnViewSectionSchedule.TabIndex = 6;
            btnViewSectionSchedule.Text = "View Section Schedule";
            btnViewSectionSchedule.UseVisualStyleBackColor = false;
            btnViewSectionSchedule.Click += btnViewSectionSchedule_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 192);
            btnExit.Font = new Font("Elephant", 19.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Maroon;
            btnExit.Location = new Point(952, 547);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(263, 80);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmEnrollmentCenter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1247, 666);
            Controls.Add(btnExit);
            Controls.Add(btnViewSectionSchedule);
            Controls.Add(btnViewSection);
            Controls.Add(btnViewStudent);
            Controls.Add(btnViewCourse);
            Controls.Add(btnViewFaculty);
            Controls.Add(label1);
            Name = "frmEnrollmentCenter";
            Text = "Enrollment Center";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewFaculty;
        private Button btnViewCourse;
        private Button btnViewStudent;
        private Button btnViewSection;
        private Button btnViewStudentSection;
        private Button btnViewSectionSchedule;
        private Button btnViewStudentParkingFine;
        private Button btnExit;
    }
}