namespace Enrollment_Center
{
    partial class frmSectionScheduleInfo
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
            lblRoomNum = new Label();
            lblLocation = new Label();
            cmbSectionID = new ComboBox();
            btnGoToEnrollmentCenter = new Button();
            btnShowSectionScheduleInfo = new Button();
            btnAddSectionSchedule = new Button();
            label1 = new Label();
            lblDays = new Label();
            lblEndTIme = new Label();
            lblStartTime = new Label();
            SuspendLayout();
            // 
            // lblSectionID
            // 
            lblSectionID.AutoSize = true;
            lblSectionID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionID.Location = new Point(507, 132);
            lblSectionID.Name = "lblSectionID";
            lblSectionID.Size = new Size(0, 48);
            lblSectionID.TabIndex = 33;
            // 
            // lblRoomNum
            // 
            lblRoomNum.AutoSize = true;
            lblRoomNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNum.Location = new Point(507, 270);
            lblRoomNum.Name = "lblRoomNum";
            lblRoomNum.Size = new Size(0, 48);
            lblRoomNum.TabIndex = 32;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(507, 208);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(0, 48);
            lblLocation.TabIndex = 31;
            // 
            // cmbSectionID
            // 
            cmbSectionID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbSectionID.FormattingEnabled = true;
            cmbSectionID.Location = new Point(340, 17);
            cmbSectionID.Name = "cmbSectionID";
            cmbSectionID.Size = new Size(493, 56);
            cmbSectionID.TabIndex = 30;
            // 
            // btnGoToEnrollmentCenter
            // 
            btnGoToEnrollmentCenter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToEnrollmentCenter.Location = new Point(1, 475);
            btnGoToEnrollmentCenter.Name = "btnGoToEnrollmentCenter";
            btnGoToEnrollmentCenter.Size = new Size(280, 69);
            btnGoToEnrollmentCenter.TabIndex = 29;
            btnGoToEnrollmentCenter.Text = "Go Back";
            btnGoToEnrollmentCenter.UseVisualStyleBackColor = true;
            btnGoToEnrollmentCenter.Click += btnGoToEnrollmentCenter_Click;
            // 
            // btnShowSectionScheduleInfo
            // 
            btnShowSectionScheduleInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowSectionScheduleInfo.Location = new Point(1, 132);
            btnShowSectionScheduleInfo.Name = "btnShowSectionScheduleInfo";
            btnShowSectionScheduleInfo.Size = new Size(418, 69);
            btnShowSectionScheduleInfo.TabIndex = 28;
            btnShowSectionScheduleInfo.Text = "Show Section Schedule Info";
            btnShowSectionScheduleInfo.UseVisualStyleBackColor = true;
            btnShowSectionScheduleInfo.Click += btnShowSectionScheduleInfo_Click;
            // 
            // btnAddSectionSchedule
            // 
            btnAddSectionSchedule.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSectionSchedule.Location = new Point(1, 256);
            btnAddSectionSchedule.Name = "btnAddSectionSchedule";
            btnAddSectionSchedule.Size = new Size(418, 76);
            btnAddSectionSchedule.TabIndex = 27;
            btnAddSectionSchedule.Text = "Add Section Schedule";
            btnAddSectionSchedule.UseVisualStyleBackColor = true;
            btnAddSectionSchedule.Click += btnAddSectionSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, 25);
            label1.Name = "label1";
            label1.Size = new Size(311, 48);
            label1.TabIndex = 26;
            label1.Text = "Select Section ID:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDays.Location = new Point(505, 338);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(0, 48);
            lblDays.TabIndex = 36;
            // 
            // lblEndTIme
            // 
            lblEndTIme.AutoSize = true;
            lblEndTIme.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTIme.Location = new Point(505, 471);
            lblEndTIme.Name = "lblEndTIme";
            lblEndTIme.Size = new Size(0, 48);
            lblEndTIme.TabIndex = 35;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTime.Location = new Point(505, 401);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(0, 48);
            lblStartTime.TabIndex = 34;
            // 
            // frmSectionScheduleInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1198, 600);
            Controls.Add(lblDays);
            Controls.Add(lblEndTIme);
            Controls.Add(lblStartTime);
            Controls.Add(lblSectionID);
            Controls.Add(lblRoomNum);
            Controls.Add(lblLocation);
            Controls.Add(cmbSectionID);
            Controls.Add(btnGoToEnrollmentCenter);
            Controls.Add(btnShowSectionScheduleInfo);
            Controls.Add(btnAddSectionSchedule);
            Controls.Add(label1);
            Name = "frmSectionScheduleInfo";
            Text = "Section Schedule ";
            Load += frmSectionScheduleInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSectionID;
        private Label lblRoomNum;
        private Label lblLocation;
        private ComboBox cmbSectionID;
        private Button btnGoToEnrollmentCenter;
        private Button btnShowSectionScheduleInfo;
        private Button btnAddSectionSchedule;
        private Label label1;
        private Label lblDays;
        private Label lblEndTIme;
        private Label lblStartTime;
    }
}