namespace Enrollment_Center
{
    partial class frmFacultyInfo
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
            lblInstructorEmail = new Label();
            lblInstructorPhoneNum = new Label();
            lblInstructorName = new Label();
            lblInstructorID = new Label();
            btnShowInstructorInfo = new Button();
            btnAddInstructor = new Button();
            label1 = new Label();
            cmbInstructorID = new ComboBox();
            btnGoToEnrollmentCenter = new Button();
            SuspendLayout();
            // 
            // lblInstructorEmail
            // 
            lblInstructorEmail.AutoSize = true;
            lblInstructorEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorEmail.Location = new Point(544, 475);
            lblInstructorEmail.Name = "lblInstructorEmail";
            lblInstructorEmail.Size = new Size(0, 48);
            lblInstructorEmail.TabIndex = 17;
            // 
            // lblInstructorPhoneNum
            // 
            lblInstructorPhoneNum.AutoSize = true;
            lblInstructorPhoneNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorPhoneNum.Location = new Point(544, 405);
            lblInstructorPhoneNum.Name = "lblInstructorPhoneNum";
            lblInstructorPhoneNum.Size = new Size(0, 48);
            lblInstructorPhoneNum.TabIndex = 16;
            // 
            // lblInstructorName
            // 
            lblInstructorName.AutoSize = true;
            lblInstructorName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorName.Location = new Point(544, 339);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(0, 48);
            lblInstructorName.TabIndex = 15;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorID.Location = new Point(544, 272);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(0, 48);
            lblInstructorID.TabIndex = 14;
            // 
            // btnShowInstructorInfo
            // 
            btnShowInstructorInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowInstructorInfo.Location = new Point(32, 143);
            btnShowInstructorInfo.Name = "btnShowInstructorInfo";
            btnShowInstructorInfo.Size = new Size(379, 69);
            btnShowInstructorInfo.TabIndex = 12;
            btnShowInstructorInfo.Text = "Show Instructor Info";
            btnShowInstructorInfo.UseVisualStyleBackColor = true;
            btnShowInstructorInfo.Click += btnShowInstructorInfo_Click;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddInstructor.Location = new Point(32, 262);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Size = new Size(280, 69);
            btnAddInstructor.TabIndex = 11;
            btnAddInstructor.Text = "Add Instructor";
            btnAddInstructor.UseVisualStyleBackColor = true;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(353, 48);
            label1.TabIndex = 10;
            label1.Text = "Select Instructor ID:";
            // 
            // cmbInstructorID
            // 
            cmbInstructorID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbInstructorID.FormattingEnabled = true;
            cmbInstructorID.Location = new Point(411, 33);
            cmbInstructorID.Name = "cmbInstructorID";
            cmbInstructorID.Size = new Size(493, 56);
            cmbInstructorID.TabIndex = 9;
            // 
            // btnGoToEnrollmentCenter
            // 
            btnGoToEnrollmentCenter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToEnrollmentCenter.Location = new Point(32, 465);
            btnGoToEnrollmentCenter.Name = "btnGoToEnrollmentCenter";
            btnGoToEnrollmentCenter.Size = new Size(280, 69);
            btnGoToEnrollmentCenter.TabIndex = 18;
            btnGoToEnrollmentCenter.Text = "Go Back";
            btnGoToEnrollmentCenter.UseVisualStyleBackColor = true;
            btnGoToEnrollmentCenter.Click += btnGoToEnrollmentCenter_Click;
            // 
            // frmFacultyInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1209, 614);
            Controls.Add(btnGoToEnrollmentCenter);
            Controls.Add(lblInstructorEmail);
            Controls.Add(lblInstructorPhoneNum);
            Controls.Add(lblInstructorName);
            Controls.Add(lblInstructorID);
            Controls.Add(btnShowInstructorInfo);
            Controls.Add(btnAddInstructor);
            Controls.Add(label1);
            Controls.Add(cmbInstructorID);
            Name = "frmFacultyInfo";
            Text = "Faculty Info";
            Load += frmFacultyInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructorEmail;
        private Label lblInstructorPhoneNum;
        private Label lblInstructorName;
        private Label lblInstructorID;
        private Button btnShowInstructorInfo;
        private Button btnAddInstructor;
        private Label label1;
        private ComboBox cmbInstructorID;
        private Button btnGoToEnrollmentCenter;
    }
}