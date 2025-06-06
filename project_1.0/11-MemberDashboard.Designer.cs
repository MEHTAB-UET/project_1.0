﻿namespace project_1._0
{
    partial class _11_MemberDashboard
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
            components = new System.ComponentModel.Container();
            dbConnectionBindingSource = new BindingSource(components);
            linkLabel1 = new LinkLabel();
            homePage = new LinkLabel();
            createNewProject = new Button();
            logOutBtn = new Button();
            updateTaskState = new Button();
            progressRoute = new Button();
            trackProgress = new Button();
            viewDepartments = new Button();
            viewProfileBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dbConnectionBindingSource
            // 
            dbConnectionBindingSource.DataSource = typeof(dbConnection);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(573, 194);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(276, 38);
            linkLabel1.TabIndex = 35;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Upgrade to Premuim";
            // 
            // homePage
            // 
            homePage.AutoSize = true;
            homePage.Font = new Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homePage.LinkColor = SystemColors.Highlight;
            homePage.Location = new Point(512, 29);
            homePage.Name = "homePage";
            homePage.Size = new Size(8, 3);
            homePage.TabIndex = 34;
            homePage.TabStop = true;
            homePage.Text = "Home ";
            // 
            // createNewProject
            // 
            createNewProject.BackColor = SystemColors.Highlight;
            createNewProject.BackgroundImageLayout = ImageLayout.Center;
            createNewProject.Font = new Font("Segoe UI", 16.2F);
            createNewProject.ForeColor = SystemColors.Control;
            createNewProject.Location = new Point(12, 390);
            createNewProject.Name = "createNewProject";
            createNewProject.Size = new Size(494, 81);
            createNewProject.TabIndex = 33;
            createNewProject.Text = "View Assign Task";
            createNewProject.UseVisualStyleBackColor = false;
            createNewProject.Click += createNewProject_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.IndianRed;
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Segoe UI", 16.2F);
            logOutBtn.ForeColor = SystemColors.Control;
            logOutBtn.Location = new Point(12, 849);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(494, 90);
            logOutBtn.TabIndex = 32;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // updateTaskState
            // 
            updateTaskState.BackColor = SystemColors.Highlight;
            updateTaskState.BackgroundImageLayout = ImageLayout.Center;
            updateTaskState.Font = new Font("Segoe UI", 16.2F);
            updateTaskState.ForeColor = SystemColors.Control;
            updateTaskState.Location = new Point(12, 477);
            updateTaskState.Name = "updateTaskState";
            updateTaskState.Size = new Size(494, 79);
            updateTaskState.TabIndex = 31;
            updateTaskState.Text = "Update Task Status";
            updateTaskState.UseVisualStyleBackColor = false;
            updateTaskState.Click += updateTaskState_Click;
            // 
            // progressRoute
            // 
            progressRoute.BackColor = SystemColors.Highlight;
            progressRoute.BackgroundImageLayout = ImageLayout.Center;
            progressRoute.Font = new Font("Segoe UI", 16.2F);
            progressRoute.ForeColor = SystemColors.Control;
            progressRoute.Location = new Point(12, 562);
            progressRoute.Name = "progressRoute";
            progressRoute.Size = new Size(494, 78);
            progressRoute.TabIndex = 30;
            progressRoute.Text = "My Progress";
            progressRoute.UseVisualStyleBackColor = false;
            progressRoute.Click += progressRoute_Click;
            // 
            // trackProgress
            // 
            trackProgress.BackColor = SystemColors.Highlight;
            trackProgress.BackgroundImageLayout = ImageLayout.Center;
            trackProgress.Font = new Font("Segoe UI", 16.2F);
            trackProgress.ForeColor = SystemColors.Control;
            trackProgress.Location = new Point(12, 646);
            trackProgress.Name = "trackProgress";
            trackProgress.Size = new Size(494, 78);
            trackProgress.TabIndex = 29;
            trackProgress.Text = "Leave Request";
            trackProgress.UseVisualStyleBackColor = false;
            // 
            // viewDepartments
            // 
            viewDepartments.BackColor = SystemColors.Highlight;
            viewDepartments.BackgroundImageLayout = ImageLayout.Center;
            viewDepartments.Font = new Font("Segoe UI", 16.2F);
            viewDepartments.ForeColor = SystemColors.Control;
            viewDepartments.Location = new Point(12, 740);
            viewDepartments.Name = "viewDepartments";
            viewDepartments.Size = new Size(494, 79);
            viewDepartments.TabIndex = 27;
            viewDepartments.Text = "Change Password";
            viewDepartments.UseVisualStyleBackColor = false;
            viewDepartments.Click += viewDepartments_Click;
            // 
            // viewProfileBtn
            // 
            viewProfileBtn.BackColor = SystemColors.Highlight;
            viewProfileBtn.BackgroundImageLayout = ImageLayout.Center;
            viewProfileBtn.Font = new Font("Segoe UI", 16.2F);
            viewProfileBtn.ForeColor = SystemColors.Control;
            viewProfileBtn.Location = new Point(12, 309);
            viewProfileBtn.Name = "viewProfileBtn";
            viewProfileBtn.Size = new Size(494, 75);
            viewProfileBtn.TabIndex = 26;
            viewProfileBtn.Text = "View Profile";
            viewProfileBtn.UseVisualStyleBackColor = false;
            viewProfileBtn.Click += viewProfileBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(573, 70);
            label1.Name = "label1";
            label1.Size = new Size(825, 92);
            label1.TabIndex = 25;
            label1.Text = "Welcome on Board";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(1538, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 249);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(494, 249);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // _11_MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1875, 1001);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(homePage);
            Controls.Add(createNewProject);
            Controls.Add(logOutBtn);
            Controls.Add(updateTaskState);
            Controls.Add(progressRoute);
            Controls.Add(trackProgress);
            Controls.Add(viewDepartments);
            Controls.Add(viewProfileBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "_11_MemberDashboard";
            Text = "_11_MemberDashboard";
            Load += _11_MemberDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource dbConnectionBindingSource;
        private LinkLabel linkLabel1;
        private LinkLabel homePage;
        private Button createNewProject;
        private Button logOutBtn;
        private Button updateTaskState;
        private Button progressRoute;
        private Button trackProgress;
        private Button viewDepartments;
        private Button viewProfileBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}