namespace Enrollment_Center
{
    partial class frmCourseInfo
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
            btnGoToEnrollmentCenter = new Button();
            btnShowCourseInfo = new Button();
            btnAddCourse = new Button();
            label1 = new Label();
            cmbCourseID = new ComboBox();
            lblCourseName = new Label();
            lblCreditHours = new Label();
            lblCourseID = new Label();
            SuspendLayout();
            // 
            // btnGoToEnrollmentCenter
            // 
            btnGoToEnrollmentCenter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToEnrollmentCenter.Location = new Point(39, 483);
            btnGoToEnrollmentCenter.Name = "btnGoToEnrollmentCenter";
            btnGoToEnrollmentCenter.Size = new Size(280, 69);
            btnGoToEnrollmentCenter.TabIndex = 13;
            btnGoToEnrollmentCenter.Text = "Go Back";
            btnGoToEnrollmentCenter.UseVisualStyleBackColor = true;
            btnGoToEnrollmentCenter.Click += btnGoToEnrollmentCenter_Click;
            // 
            // btnShowCourseInfo
            // 
            btnShowCourseInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowCourseInfo.Location = new Point(39, 140);
            btnShowCourseInfo.Name = "btnShowCourseInfo";
            btnShowCourseInfo.Size = new Size(353, 69);
            btnShowCourseInfo.TabIndex = 12;
            btnShowCourseInfo.Text = "Show Course Info";
            btnShowCourseInfo.UseVisualStyleBackColor = true;
            btnShowCourseInfo.Click += btnShowCourseInfo_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCourse.Location = new Point(39, 259);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(280, 69);
            btnAddCourse.TabIndex = 11;
            btnAddCourse.Text = "Add Course";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(302, 48);
            label1.TabIndex = 10;
            label1.Text = "Select Course ID:";
            // 
            // cmbCourseID
            // 
            cmbCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCourseID.FormattingEnabled = true;
            cmbCourseID.Location = new Point(378, 25);
            cmbCourseID.Name = "cmbCourseID";
            cmbCourseID.Size = new Size(493, 56);
            cmbCourseID.TabIndex = 14;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseName.Location = new Point(506, 339);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(0, 48);
            lblCourseName.TabIndex = 15;
            // 
            // lblCreditHours
            // 
            lblCreditHours.AutoSize = true;
            lblCreditHours.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreditHours.Location = new Point(506, 409);
            lblCreditHours.Name = "lblCreditHours";
            lblCreditHours.Size = new Size(0, 48);
            lblCreditHours.TabIndex = 16;
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseID.Location = new Point(506, 259);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(0, 48);
            lblCourseID.TabIndex = 17;
            // 
            // frmCourseInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1126, 571);
            Controls.Add(lblCourseID);
            Controls.Add(lblCreditHours);
            Controls.Add(lblCourseName);
            Controls.Add(cmbCourseID);
            Controls.Add(btnGoToEnrollmentCenter);
            Controls.Add(btnShowCourseInfo);
            Controls.Add(btnAddCourse);
            Controls.Add(label1);
            Name = "frmCourseInfo";
            Text = "Course Info";
            Load += CourseInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGoToEnrollmentCenter;
        private Button btnShowCourseInfo;
        private Button btnAddCourse;
        private Label label1;
        private ComboBox cmbCourseID;
        private Label lblCourseName;
        private Label lblCreditHours;
        private Label lblCourseID;
    }
}