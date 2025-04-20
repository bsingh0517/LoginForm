namespace Enrollment_Center
{
    partial class frmAddInstructor
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
            btnAddStudentInfo = new Button();
            txtInstructorEmail = new TextBox();
            txtInstructorPhone = new TextBox();
            txtInstructorName = new TextBox();
            txtInstructorID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGoToFacultyPage = new Button();
            SuspendLayout();
            // 
            // btnAddStudentInfo
            // 
            btnAddStudentInfo.BackColor = Color.FromArgb(192, 192, 255);
            btnAddStudentInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudentInfo.Location = new Point(99, 409);
            btnAddStudentInfo.Name = "btnAddStudentInfo";
            btnAddStudentInfo.Size = new Size(207, 69);
            btnAddStudentInfo.TabIndex = 28;
            btnAddStudentInfo.Text = "Add";
            btnAddStudentInfo.UseVisualStyleBackColor = false;
            btnAddStudentInfo.Click += btnAddStudentInfo_Click;
            // 
            // txtInstructorEmail
            // 
            txtInstructorEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstructorEmail.Location = new Point(281, 266);
            txtInstructorEmail.Name = "txtInstructorEmail";
            txtInstructorEmail.Size = new Size(718, 55);
            txtInstructorEmail.TabIndex = 27;
            // 
            // txtInstructorPhone
            // 
            txtInstructorPhone.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstructorPhone.Location = new Point(281, 187);
            txtInstructorPhone.Name = "txtInstructorPhone";
            txtInstructorPhone.Size = new Size(594, 55);
            txtInstructorPhone.TabIndex = 26;
            // 
            // txtInstructorName
            // 
            txtInstructorName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstructorName.Location = new Point(281, 106);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(534, 55);
            txtInstructorName.TabIndex = 25;
            // 
            // txtInstructorID
            // 
            txtInstructorID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstructorID.Location = new Point(281, 34);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(239, 55);
            txtInstructorID.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 266);
            label4.Name = "label4";
            label4.Size = new Size(121, 48);
            label4.TabIndex = 23;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 177);
            label3.Name = "label3";
            label3.Size = new Size(137, 48);
            label3.TabIndex = 22;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 109);
            label2.Name = "label2";
            label2.Size = new Size(129, 48);
            label2.TabIndex = 21;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 34);
            label1.Name = "label1";
            label1.Size = new Size(244, 48);
            label1.TabIndex = 20;
            label1.Text = "Instructor ID:";
            // 
            // btnGoToFacultyPage
            // 
            btnGoToFacultyPage.BackColor = Color.FromArgb(192, 192, 255);
            btnGoToFacultyPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToFacultyPage.Location = new Point(792, 422);
            btnGoToFacultyPage.Name = "btnGoToFacultyPage";
            btnGoToFacultyPage.Size = new Size(207, 69);
            btnGoToFacultyPage.TabIndex = 29;
            btnGoToFacultyPage.Text = "Go Back";
            btnGoToFacultyPage.UseVisualStyleBackColor = false;
            btnGoToFacultyPage.Click += btnGoToFacultyPage_Click;
            // 
            // frmAddInstructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1192, 595);
            Controls.Add(btnGoToFacultyPage);
            Controls.Add(btnAddStudentInfo);
            Controls.Add(txtInstructorEmail);
            Controls.Add(txtInstructorPhone);
            Controls.Add(txtInstructorName);
            Controls.Add(txtInstructorID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddInstructor";
            Text = "Add Instructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddStudentInfo;
        private TextBox txtInstructorEmail;
        private TextBox txtInstructorPhone;
        private TextBox txtInstructorName;
        private TextBox txtInstructorID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGoToFacultyPage;
    }
}