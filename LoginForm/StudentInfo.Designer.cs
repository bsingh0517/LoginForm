namespace LoginForm
{
    partial class frmStudentInfo
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
            cmbStudentID = new ComboBox();
            label1 = new Label();
            btnAddStudent = new Button();
            btnShowStudentInfo = new Button();
            label2 = new Label();
            lblStudentID = new Label();
            lblStudentName = new Label();
            lblStudentPhoneNum = new Label();
            lblStudentEmail = new Label();
            btnGoToEnrollmentCenter = new Button();
            SuspendLayout();
            // 
            // cmbStudentID
            // 
            cmbStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStudentID.FormattingEnabled = true;
            cmbStudentID.Location = new Point(374, 80);
            cmbStudentID.Name = "cmbStudentID";
            cmbStudentID.Size = new Size(493, 56);
            cmbStudentID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(319, 48);
            label1.TabIndex = 1;
            label1.Text = "Select Student ID:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(36, 306);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(280, 69);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowStudentInfo
            // 
            btnShowStudentInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowStudentInfo.Location = new Point(36, 187);
            btnShowStudentInfo.Name = "btnShowStudentInfo";
            btnShowStudentInfo.Size = new Size(353, 69);
            btnShowStudentInfo.TabIndex = 3;
            btnShowStudentInfo.Text = "Show Student Info";
            btnShowStudentInfo.UseVisualStyleBackColor = true;
            btnShowStudentInfo.Click += btnShowStudentInfo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(766, 234);
            label2.Name = "label2";
            label2.Size = new Size(0, 48);
            label2.TabIndex = 4;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(548, 316);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(0, 48);
            lblStudentID.TabIndex = 5;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(548, 383);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(0, 48);
            lblStudentName.TabIndex = 6;
            // 
            // lblStudentPhoneNum
            // 
            lblStudentPhoneNum.AutoSize = true;
            lblStudentPhoneNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentPhoneNum.Location = new Point(548, 449);
            lblStudentPhoneNum.Name = "lblStudentPhoneNum";
            lblStudentPhoneNum.Size = new Size(0, 48);
            lblStudentPhoneNum.TabIndex = 7;
            // 
            // lblStudentEmail
            // 
            lblStudentEmail.AutoSize = true;
            lblStudentEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentEmail.Location = new Point(548, 519);
            lblStudentEmail.Name = "lblStudentEmail";
            lblStudentEmail.Size = new Size(0, 48);
            lblStudentEmail.TabIndex = 8;
            // 
            // btnGoToEnrollmentCenter
            // 
            btnGoToEnrollmentCenter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToEnrollmentCenter.Location = new Point(36, 530);
            btnGoToEnrollmentCenter.Name = "btnGoToEnrollmentCenter";
            btnGoToEnrollmentCenter.Size = new Size(280, 69);
            btnGoToEnrollmentCenter.TabIndex = 9;
            btnGoToEnrollmentCenter.Text = "Go Back";
            btnGoToEnrollmentCenter.UseVisualStyleBackColor = true;
            btnGoToEnrollmentCenter.Click += btnGoToEnrollmentCenter_Click;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1225, 624);
            Controls.Add(btnGoToEnrollmentCenter);
            Controls.Add(lblStudentEmail);
            Controls.Add(lblStudentPhoneNum);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Controls.Add(label2);
            Controls.Add(btnShowStudentInfo);
            Controls.Add(btnAddStudent);
            Controls.Add(label1);
            Controls.Add(cmbStudentID);
            Name = "frmStudentInfo";
            Text = "StudentInfo";
            Load += StudentInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudentID;
        private Label label1;
        private Button btnAddStudent;
        private Button btnShowStudentInfo;
        private Label label2;
        private Label lblStudentID;
        private Label lblStudentName;
        private Label lblStudentPhoneNum;
        private Label lblStudentEmail;
        private Button btnGoToEnrollmentCenter;
    }
}