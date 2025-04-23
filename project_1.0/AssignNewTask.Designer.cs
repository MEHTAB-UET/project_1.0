namespace project_1._0
{
    partial class AssignNewTask
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            taskTitle = new TextBox();
            startDate = new DateTimePicker();
            dueDate = new DateTimePicker();
            taskDescription = new TextBox();
            priority = new ComboBox();
            RelatedProjects = new ComboBox();
            Department = new ComboBox();
            Employee = new ComboBox();
            assignTaskBtn = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(67, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 187);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(680, 117);
            label1.Name = "label1";
            label1.Size = new Size(393, 62);
            label1.TabIndex = 8;
            label1.Text = "Assign New Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 353);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 9;
            label2.Text = "TaskTitle :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(193, 443);
            label3.Name = "label3";
            label3.Size = new Size(153, 38);
            label3.TabIndex = 10;
            label3.Text = "Start Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 532);
            label4.Name = "label4";
            label4.Size = new Size(148, 38);
            label4.TabIndex = 11;
            label4.Text = "Due Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(193, 619);
            label5.Name = "label5";
            label5.Size = new Size(232, 38);
            label5.TabIndex = 12;
            label5.Text = "Task Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(954, 353);
            label6.Name = "label6";
            label6.Size = new Size(120, 38);
            label6.TabIndex = 13;
            label6.Text = "Priority :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(954, 443);
            label7.Name = "label7";
            label7.Size = new Size(217, 38);
            label7.TabIndex = 14;
            label7.Text = "Related Project :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(954, 532);
            label8.Name = "label8";
            label8.Size = new Size(179, 38);
            label8.TabIndex = 15;
            label8.Text = "Department :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(954, 619);
            label9.Name = "label9";
            label9.Size = new Size(152, 38);
            label9.TabIndex = 16;
            label9.Text = "Employee :";
            // 
            // taskTitle
            // 
            taskTitle.Location = new Point(495, 364);
            taskTitle.Name = "taskTitle";
            taskTitle.Size = new Size(341, 27);
            taskTitle.TabIndex = 17;
            taskTitle.TextChanged += taskTitle_TextChanged;
            // 
            // startDate
            // 
            startDate.Location = new Point(495, 452);
            startDate.Name = "startDate";
            startDate.Size = new Size(341, 27);
            startDate.TabIndex = 18;
            startDate.ValueChanged += startDate_ValueChanged;
            // 
            // dueDate
            // 
            dueDate.Location = new Point(495, 541);
            dueDate.Name = "dueDate";
            dueDate.Size = new Size(341, 27);
            dueDate.TabIndex = 19;
            dueDate.ValueChanged += dueDate_ValueChanged;
            // 
            // taskDescription
            // 
            taskDescription.Location = new Point(495, 619);
            taskDescription.Multiline = true;
            taskDescription.Name = "taskDescription";
            taskDescription.Size = new Size(341, 187);
            taskDescription.TabIndex = 20;
            taskDescription.TextChanged += taskDescription_TextChanged;
            // 
            // priority
            // 
            priority.FormattingEnabled = true;
            priority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priority.Location = new Point(1231, 363);
            priority.Name = "priority";
            priority.Size = new Size(341, 28);
            priority.TabIndex = 21;
            priority.SelectedIndexChanged += priority_SelectedIndexChanged;
            // 
            // RelatedProjects
            // 
            RelatedProjects.FormattingEnabled = true;
            RelatedProjects.Location = new Point(1231, 451);
            RelatedProjects.Name = "RelatedProjects";
            RelatedProjects.Size = new Size(341, 28);
            RelatedProjects.TabIndex = 22;
            RelatedProjects.SelectedIndexChanged += RelatedProjects_SelectedIndexChanged;
            // 
            // Department
            // 
            Department.FormattingEnabled = true;
            Department.Location = new Point(1231, 540);
            Department.Name = "Department";
            Department.Size = new Size(341, 28);
            Department.TabIndex = 23;
            Department.SelectedIndexChanged += Department_SelectedIndexChanged;
            // 
            // Employee
            // 
            Employee.FormattingEnabled = true;
            Employee.Location = new Point(1231, 629);
            Employee.Name = "Employee";
            Employee.Size = new Size(341, 28);
            Employee.TabIndex = 24;
            Employee.SelectedIndexChanged += Employee_SelectedIndexChanged;
            // 
            // assignTaskBtn
            // 
            assignTaskBtn.BackColor = SystemColors.Highlight;
            assignTaskBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            assignTaskBtn.ForeColor = SystemColors.Control;
            assignTaskBtn.Location = new Point(954, 731);
            assignTaskBtn.Name = "assignTaskBtn";
            assignTaskBtn.Size = new Size(254, 75);
            assignTaskBtn.TabIndex = 25;
            assignTaskBtn.Text = "Assign Task";
            assignTaskBtn.UseVisualStyleBackColor = false;
            assignTaskBtn.Click += assignTaskBtn_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = SystemColors.Control;
            cancelButton.Location = new Point(1318, 731);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(254, 75);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AssignNewTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 936);
            Controls.Add(cancelButton);
            Controls.Add(assignTaskBtn);
            Controls.Add(Employee);
            Controls.Add(Department);
            Controls.Add(RelatedProjects);
            Controls.Add(priority);
            Controls.Add(taskDescription);
            Controls.Add(dueDate);
            Controls.Add(startDate);
            Controls.Add(taskTitle);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssignNewTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AssignNewTask";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox taskTitle;
        private DateTimePicker startDate;
        private DateTimePicker dueDate;
        private TextBox taskDescription;
        private ComboBox priority;
        private ComboBox RelatedProjects;
        private ComboBox Department;
        private ComboBox Employee;
        private Button assignTaskBtn;
        private Button cancelButton;
    }
}