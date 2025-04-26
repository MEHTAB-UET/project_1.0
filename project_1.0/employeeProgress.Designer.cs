namespace project_1._0
{
    partial class employeeProgress
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            logOutBtn = new Button();
            viewDepartments = new Button();
            totalAssignTaskLabel = new Label();
            TotalTaskCompleted = new Label();
            taskInProgress = new Label();
            progressPercentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(290, 36);
            label1.Name = "label1";
            label1.Size = new Size(723, 92);
            label1.TabIndex = 26;
            label1.Text = "Progress Report";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(25, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 136);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(290, 268);
            label2.Name = "label2";
            label2.Size = new Size(256, 38);
            label2.TabIndex = 32;
            label2.Text = "Total Assign Task :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(290, 330);
            label3.Name = "label3";
            label3.Size = new Size(313, 38);
            label3.TabIndex = 33;
            label3.Text = "Total Task Completed :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.Location = new Point(290, 394);
            label4.Name = "label4";
            label4.Size = new Size(243, 38);
            label4.TabIndex = 34;
            label4.Text = "Task in Progress :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label5.Location = new Point(290, 456);
            label5.Name = "label5";
            label5.Size = new Size(298, 38);
            label5.TabIndex = 35;
            label5.Text = "Progress Percentage :";
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.IndianRed;
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Segoe UI", 16.2F);
            logOutBtn.ForeColor = SystemColors.Control;
            logOutBtn.Location = new Point(669, 569);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(258, 72);
            logOutBtn.TabIndex = 37;
            logOutBtn.Text = "Back";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // viewDepartments
            // 
            viewDepartments.BackColor = SystemColors.Highlight;
            viewDepartments.BackgroundImageLayout = ImageLayout.Center;
            viewDepartments.Font = new Font("Segoe UI", 16.2F);
            viewDepartments.ForeColor = SystemColors.Control;
            viewDepartments.Location = new Point(288, 569);
            viewDepartments.Name = "viewDepartments";
            viewDepartments.Size = new Size(258, 72);
            viewDepartments.TabIndex = 36;
            viewDepartments.Text = "Done";
            viewDepartments.UseVisualStyleBackColor = false;
            viewDepartments.Click += viewDepartments_Click;
            // 
            // totalAssignTaskLabel
            // 
            totalAssignTaskLabel.AutoSize = true;
            totalAssignTaskLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalAssignTaskLabel.Location = new Point(671, 273);
            totalAssignTaskLabel.Name = "totalAssignTaskLabel";
            totalAssignTaskLabel.Size = new Size(76, 31);
            totalAssignTaskLabel.TabIndex = 38;
            totalAssignTaskLabel.Text = "label6";
            totalAssignTaskLabel.Click += totalAssignTaskLabel_Click;
            // 
            // TotalTaskCompleted
            // 
            TotalTaskCompleted.AutoSize = true;
            TotalTaskCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalTaskCompleted.Location = new Point(671, 337);
            TotalTaskCompleted.Name = "TotalTaskCompleted";
            TotalTaskCompleted.Size = new Size(76, 31);
            TotalTaskCompleted.TabIndex = 39;
            TotalTaskCompleted.Text = "label7";
            TotalTaskCompleted.Click += TotalTaskCompleted_Click;
            // 
            // taskInProgress
            // 
            taskInProgress.AutoSize = true;
            taskInProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskInProgress.Location = new Point(671, 399);
            taskInProgress.Name = "taskInProgress";
            taskInProgress.Size = new Size(76, 31);
            taskInProgress.TabIndex = 40;
            taskInProgress.Text = "label8";
            taskInProgress.Click += taskInProgress_Click;
            // 
            // progressPercentage
            // 
            progressPercentage.AutoSize = true;
            progressPercentage.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            progressPercentage.Location = new Point(671, 461);
            progressPercentage.Name = "progressPercentage";
            progressPercentage.Size = new Size(76, 31);
            progressPercentage.TabIndex = 41;
            progressPercentage.Text = "label9";
            progressPercentage.Click += progressPercentage_Click;
            // 
            // employeeProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 711);
            Controls.Add(progressPercentage);
            Controls.Add(taskInProgress);
            Controls.Add(TotalTaskCompleted);
            Controls.Add(totalAssignTaskLabel);
            Controls.Add(logOutBtn);
            Controls.Add(viewDepartments);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employeeProgress";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employeeProgress";
            Load += employeeProgress_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button logOutBtn;
        private Button viewDepartments;
        private Label totalAssignTaskLabel;
        private Label TotalTaskCompleted;
        private Label taskInProgress;
        private Label progressPercentage;
    }
}