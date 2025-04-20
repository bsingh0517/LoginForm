namespace Enrollment_Center
{
    partial class frmAddCourse
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
            txtCreditHours = new TextBox();
            txtCourseName = new TextBox();
            txtCourseID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGoToCourseInfoPage = new Button();
            btnAddCourseInfo = new Button();
            SuspendLayout();
            // 
            // txtCreditHours
            // 
            txtCreditHours.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCreditHours.Location = new Point(369, 200);
            txtCreditHours.Name = "txtCreditHours";
            txtCreditHours.Size = new Size(326, 55);
            txtCreditHours.TabIndex = 20;
            // 
            // txtCourseName
            // 
            txtCourseName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCourseName.Location = new Point(369, 129);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(532, 55);
            txtCourseName.TabIndex = 19;
            // 
            // txtCourseID
            // 
            txtCourseID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCourseID.Location = new Point(369, 54);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(239, 55);
            txtCourseID.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 200);
            label3.Name = "label3";
            label3.Size = new Size(243, 48);
            label3.TabIndex = 17;
            label3.Text = "Credit Hours:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 132);
            label2.Name = "label2";
            label2.Size = new Size(129, 48);
            label2.TabIndex = 16;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 57);
            label1.Name = "label1";
            label1.Size = new Size(193, 48);
            label1.TabIndex = 15;
            label1.Text = "Course ID:";
            // 
            // btnGoToCourseInfoPage
            // 
            btnGoToCourseInfoPage.BackColor = Color.FromArgb(192, 192, 255);
            btnGoToCourseInfoPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToCourseInfoPage.Location = new Point(551, 358);
            btnGoToCourseInfoPage.Name = "btnGoToCourseInfoPage";
            btnGoToCourseInfoPage.Size = new Size(207, 69);
            btnGoToCourseInfoPage.TabIndex = 22;
            btnGoToCourseInfoPage.Text = "Go Back";
            btnGoToCourseInfoPage.UseVisualStyleBackColor = false;
            btnGoToCourseInfoPage.Click += btnGoToCourseInfoPage_Click;
            // 
            // btnAddCourseInfo
            // 
            btnAddCourseInfo.BackColor = Color.FromArgb(192, 192, 255);
            btnAddCourseInfo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCourseInfo.Location = new Point(111, 358);
            btnAddCourseInfo.Name = "btnAddCourseInfo";
            btnAddCourseInfo.Size = new Size(207, 69);
            btnAddCourseInfo.TabIndex = 21;
            btnAddCourseInfo.Text = "Add";
            btnAddCourseInfo.UseVisualStyleBackColor = false;
            btnAddCourseInfo.Click += btnAddCourseInfo_Click;
            // 
            // frmAddCourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1208, 592);
            Controls.Add(btnGoToCourseInfoPage);
            Controls.Add(btnAddCourseInfo);
            Controls.Add(txtCreditHours);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddCourse";
            Text = "Add Course";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreditHours;
        private TextBox txtCourseName;
        private TextBox txtCourseID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGoToCourseInfoPage;
        private Button btnAddCourseInfo;
    }
}