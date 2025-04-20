namespace Enrollment_Center
{
    partial class frmSectionInfo
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
            lblSectionID = new Label();
            lblTerm = new Label();
            lblSectionName = new Label();
            cmbSectionID = new ComboBox();
            btnGoToEnrollmentCenter = new Button();
            btnShowSectionInfo = new Button();
            btnAddSection = new Button();
            label1 = new Label();
            lblCourseID = new Label();
            lblInstructorID = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            SuspendLayout();
            // 
            // lblSectionID
            // 
            lblSectionID.AutoSize = true;
            lblSectionID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionID.Location = new Point(478, 139);
            lblSectionID.Name = "lblSectionID";
            lblSectionID.Size = new Size(0, 48);
            lblSectionID.TabIndex = 25;
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTerm.Location = new Point(478, 513);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(0, 48);
            lblTerm.TabIndex = 24;
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionName.Location = new Point(478, 329);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(0, 48);
            lblSectionName.TabIndex = 23;
            // 
            // cmbSectionID
            // 
            cmbSectionID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSectionID.FormattingEnabled = true;
            cmbSectionID.Location = new Point(373, 24);
            cmbSectionID.Name = "cmbSectionID";
            cmbSectionID.Size = new Size(493, 56);
            cmbSectionID.TabIndex = 22;
            // 
            // btnGoToEnrollmentCenter
            // 
            btnGoToEnrollmentCenter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToEnrollmentCenter.Location = new Point(34, 482);
            btnGoToEnrollmentCenter.Name = "btnGoToEnrollmentCenter";
            btnGoToEnrollmentCenter.Size = new Size(280, 69);
            btnGoToEnrollmentCenter.TabIndex = 21;
            btnGoToEnrollmentCenter.Text = "Go Back";
            btnGoToEnrollmentCenter.UseVisualStyleBackColor = true;
            btnGoToEnrollmentCenter.Click += btnGoToEnrollmentCenter_Click;
            // 
            // btnShowSectionInfo
            // 
            btnShowSectionInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowSectionInfo.Location = new Point(34, 139);
            btnShowSectionInfo.Name = "btnShowSectionInfo";
            btnShowSectionInfo.Size = new Size(353, 69);
            btnShowSectionInfo.TabIndex = 20;
            btnShowSectionInfo.Text = "Show Section Info";
            btnShowSectionInfo.UseVisualStyleBackColor = true;
            btnShowSectionInfo.Click += btnShowSectionInfo_Click;
            // 
            // btnAddSection
            // 
            btnAddSection.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSection.Location = new Point(34, 258);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new Size(280, 69);
            btnAddSection.TabIndex = 19;
            btnAddSection.Text = "Add Section";
            btnAddSection.UseVisualStyleBackColor = true;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(311, 48);
            label1.TabIndex = 18;
            label1.Text = "Select Section ID:";
            // 
            // lblCourseID
            // 
            lblCourseID.AutoSize = true;
            lblCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseID.Location = new Point(478, 204);
            lblCourseID.Name = "lblCourseID";
            lblCourseID.Size = new Size(0, 48);
            lblCourseID.TabIndex = 26;
            // 
            // lblInstructorID
            // 
            lblInstructorID.AutoSize = true;
            lblInstructorID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorID.Location = new Point(478, 268);
            lblInstructorID.Name = "lblInstructorID";
            lblInstructorID.Size = new Size(0, 48);
            lblInstructorID.TabIndex = 27;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.Location = new Point(478, 394);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(0, 48);
            lblStartDate.TabIndex = 28;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.Location = new Point(478, 455);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(0, 48);
            lblEndDate.TabIndex = 29;
            // 
            // frmSectionInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1226, 625);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblInstructorID);
            Controls.Add(lblCourseID);
            Controls.Add(lblSectionID);
            Controls.Add(lblTerm);
            Controls.Add(lblSectionName);
            Controls.Add(cmbSectionID);
            Controls.Add(btnGoToEnrollmentCenter);
            Controls.Add(btnShowSectionInfo);
            Controls.Add(btnAddSection);
            Controls.Add(label1);
            Name = "frmSectionInfo";
            Text = "Section Info";
            Load += SectionInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSectionID;
        private Label lblTerm;
        private Label lblSectionName;
        private ComboBox cmbSectionID;
        private Button btnGoToEnrollmentCenter;
        private Button btnShowSectionInfo;
        private Button btnAddSection;
        private Label label1;
        private Label lblCourseID;
        private Label lblInstructorID;
        private Label lblStartDate;
        private Label lblEndDate;
    }
}