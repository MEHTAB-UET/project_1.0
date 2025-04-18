namespace project_1._0
{
    partial class managerDashboard
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
            addNewDept = new Button();
            assignNewTask = new Button();
            trackProgress = new Button();
            manageTask = new Button();
            viewDepartments = new Button();
            registerNewMember = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            createNewProject = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addNewDept
            // 
            addNewDept.BackColor = SystemColors.Highlight;
            addNewDept.BackgroundImageLayout = ImageLayout.Center;
            addNewDept.Font = new Font("Segoe UI", 16.2F);
            addNewDept.ForeColor = SystemColors.Control;
            addNewDept.Location = new Point(22, 443);
            addNewDept.Name = "addNewDept";
            addNewDept.Size = new Size(494, 72);
            addNewDept.TabIndex = 16;
            addNewDept.Text = "Add New Department";
            addNewDept.UseVisualStyleBackColor = false;
            // 
            // assignNewTask
            // 
            assignNewTask.BackColor = SystemColors.Highlight;
            assignNewTask.BackgroundImageLayout = ImageLayout.Center;
            assignNewTask.Font = new Font("Segoe UI", 16.2F);
            assignNewTask.ForeColor = SystemColors.Control;
            assignNewTask.Location = new Point(22, 521);
            assignNewTask.Name = "assignNewTask";
            assignNewTask.Size = new Size(494, 72);
            assignNewTask.TabIndex = 15;
            assignNewTask.Text = "Assign New Task";
            assignNewTask.UseVisualStyleBackColor = false;
            // 
            // trackProgress
            // 
            trackProgress.BackColor = SystemColors.Highlight;
            trackProgress.BackgroundImageLayout = ImageLayout.Center;
            trackProgress.Font = new Font("Segoe UI", 16.2F);
            trackProgress.ForeColor = SystemColors.Control;
            trackProgress.Location = new Point(22, 599);
            trackProgress.Name = "trackProgress";
            trackProgress.Size = new Size(494, 72);
            trackProgress.TabIndex = 14;
            trackProgress.Text = "Track Progress";
            trackProgress.UseVisualStyleBackColor = false;
            // 
            // manageTask
            // 
            manageTask.BackColor = SystemColors.Highlight;
            manageTask.BackgroundImageLayout = ImageLayout.Center;
            manageTask.Font = new Font("Segoe UI", 16.2F);
            manageTask.ForeColor = SystemColors.Control;
            manageTask.Location = new Point(22, 682);
            manageTask.Name = "manageTask";
            manageTask.Size = new Size(494, 72);
            manageTask.TabIndex = 13;
            manageTask.Text = "Manage Task";
            manageTask.UseVisualStyleBackColor = false;
            // 
            // viewDepartments
            // 
            viewDepartments.BackColor = SystemColors.Highlight;
            viewDepartments.BackgroundImageLayout = ImageLayout.Center;
            viewDepartments.Font = new Font("Segoe UI", 16.2F);
            viewDepartments.ForeColor = SystemColors.Control;
            viewDepartments.Location = new Point(22, 760);
            viewDepartments.Name = "viewDepartments";
            viewDepartments.Size = new Size(494, 72);
            viewDepartments.TabIndex = 12;
            viewDepartments.Text = "View Departments";
            viewDepartments.UseVisualStyleBackColor = false;
            // 
            // registerNewMember
            // 
            registerNewMember.BackColor = SystemColors.Highlight;
            registerNewMember.BackgroundImageLayout = ImageLayout.Center;
            registerNewMember.Font = new Font("Segoe UI", 16.2F);
            registerNewMember.ForeColor = SystemColors.Control;
            registerNewMember.Location = new Point(22, 287);
            registerNewMember.Name = "registerNewMember";
            registerNewMember.Size = new Size(494, 72);
            registerNewMember.TabIndex = 11;
            registerNewMember.Text = "Register New Member";
            registerNewMember.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(844, 106);
            label1.Name = "label1";
            label1.Size = new Size(267, 62);
            label1.TabIndex = 10;
            label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 249);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // createNewProject
            // 
            createNewProject.BackColor = SystemColors.Highlight;
            createNewProject.BackgroundImageLayout = ImageLayout.Center;
            createNewProject.Font = new Font("Segoe UI", 16.2F);
            createNewProject.ForeColor = SystemColors.Control;
            createNewProject.Location = new Point(22, 365);
            createNewProject.Name = "createNewProject";
            createNewProject.Size = new Size(494, 72);
            createNewProject.TabIndex = 18;
            createNewProject.Text = "Create New Project";
            createNewProject.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 16.2F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(22, 860);
            button2.Name = "button2";
            button2.Size = new Size(494, 72);
            button2.TabIndex = 17;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 935);
            Controls.Add(createNewProject);
            Controls.Add(button2);
            Controls.Add(addNewDept);
            Controls.Add(assignNewTask);
            Controls.Add(trackProgress);
            Controls.Add(manageTask);
            Controls.Add(viewDepartments);
            Controls.Add(registerNewMember);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "managerDashboard";
            Text = "managerDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addNewDept;
        private Button assignNewTask;
        private Button trackProgress;
        private Button manageTask;
        private Button viewDepartments;
        private Button registerNewMember;
        private Label label1;
        private PictureBox pictureBox1;
        private Button createNewProject;
        private Button button2;
    }
}