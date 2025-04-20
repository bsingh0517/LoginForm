namespace Enrollment_Center
{
    partial class frmAddStudent
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtStudentPhone = new TextBox();
            txtStudentEmail = new TextBox();
            btnAddStudentInfo = new Button();
            label5 = new Label();
            txtInstructorID = new TextBox();
            btnGoToStudentInfoPage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 62);
            label1.Name = "label1";
            label1.Size = new Size(210, 48);
            label1.TabIndex = 8;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 137);
            label2.Name = "label2";
            label2.Size = new Size(129, 48);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 205);
            label3.Name = "label3";
            label3.Size = new Size(137, 48);
            label3.TabIndex = 10;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 294);
            label4.Name = "label4";
            label4.Size = new Size(121, 48);
            label4.TabIndex = 11;
            label4.Text = "Email:";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(299, 59);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(239, 55);
            txtStudentID.TabIndex = 12;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentName.Location = new Point(299, 134);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(363, 55);
            txtStudentName.TabIndex = 13;
            // 
            // txtStudentPhone
            // 
            txtStudentPhone.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentPhone.Location = new Point(299, 214);
            txtStudentPhone.Name = "txtStudentPhone";
            txtStudentPhone.Size = new Size(326, 55);
            txtStudentPhone.TabIndex = 14;
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStudentEmail.Location = new Point(299, 294);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(427, 55);
            txtStudentEmail.TabIndex = 15;
            // 
            // btnAddStudentInfo
            // 
            btnAddStudentInfo.BackColor = Color.FromArgb(192, 192, 255);
            btnAddStudentInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudentInfo.Location = new Point(418, 476);
            btnAddStudentInfo.Name = "btnAddStudentInfo";
            btnAddStudentInfo.Size = new Size(207, 69);
            btnAddStudentInfo.TabIndex = 16;
            btnAddStudentInfo.Text = "Add";
            btnAddStudentInfo.UseVisualStyleBackColor = false;
            btnAddStudentInfo.Click += btnAddStudentInfo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 375);
            label5.Name = "label5";
            label5.Size = new Size(239, 48);
            label5.TabIndex = 17;
            label5.Text = "Instructor Id:";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInstructorID.Location = new Point(299, 368);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(427, 55);
            txtInstructorID.TabIndex = 18;
            // 
            // btnGoToStudentInfoPage
            // 
            btnGoToStudentInfoPage.BackColor = Color.FromArgb(192, 192, 255);
            btnGoToStudentInfoPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToStudentInfoPage.Location = new Point(858, 476);
            btnGoToStudentInfoPage.Name = "btnGoToStudentInfoPage";
            btnGoToStudentInfoPage.Size = new Size(207, 69);
            btnGoToStudentInfoPage.TabIndex = 19;
            btnGoToStudentInfoPage.Text = "Go Back";
            btnGoToStudentInfoPage.UseVisualStyleBackColor = false;
            btnGoToStudentInfoPage.Click += btnGoToStudentInfoPage_Click;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1095, 557);
            Controls.Add(btnGoToStudentInfoPage);
            Controls.Add(txtInstructorID);
            Controls.Add(label5);
            Controls.Add(btnAddStudentInfo);
            Controls.Add(txtStudentEmail);
            Controls.Add(txtStudentPhone);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddStudent";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtStudentPhone;
        private TextBox txtStudentEmail;
        private Button btnAddStudentInfo;
        private Label label5;
        private TextBox txtInstructorID;
        private Button btnGoToStudentInfoPage;
    }
}