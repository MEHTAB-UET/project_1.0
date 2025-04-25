namespace project_1._0
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            projectWithDeadlineAndClientName = new DataGridView();
            dbConnectionBindingSource = new BindingSource(components);
            linkLabel1 = new LinkLabel();
            homePage = new LinkLabel();
            createNewProject = new Button();
            logOutBtn = new Button();
            addNewDept = new Button();
            assignNewTask = new Button();
            trackProgress = new Button();
            manageTask = new Button();
            viewDepartments = new Button();
            registerNewMember = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            projectNameTotalBudgetandPaidBudget = new DataGridView();
            departmentData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)projectWithDeadlineAndClientName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectNameTotalBudgetandPaidBudget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentData).BeginInit();
            SuspendLayout();
            // 
            // projectWithDeadlineAndClientName
            // 
            projectWithDeadlineAndClientName.AllowUserToAddRows = false;
            projectWithDeadlineAndClientName.AllowUserToDeleteRows = false;
            projectWithDeadlineAndClientName.AutoGenerateColumns = false;
            projectWithDeadlineAndClientName.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            projectWithDeadlineAndClientName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            projectWithDeadlineAndClientName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectWithDeadlineAndClientName.DataSource = dbConnectionBindingSource;
            projectWithDeadlineAndClientName.GridColor = SystemColors.InactiveCaption;
            projectWithDeadlineAndClientName.Location = new Point(1207, 294);
            projectWithDeadlineAndClientName.Name = "projectWithDeadlineAndClientName";
            projectWithDeadlineAndClientName.ReadOnly = true;
            projectWithDeadlineAndClientName.RowHeadersWidth = 51;
            projectWithDeadlineAndClientName.Size = new Size(634, 306);
            projectWithDeadlineAndClientName.TabIndex = 36;
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
            linkLabel1.Location = new Point(1525, 124);
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
            createNewProject.Location = new Point(12, 372);
            createNewProject.Name = "createNewProject";
            createNewProject.Size = new Size(494, 72);
            createNewProject.TabIndex = 33;
            createNewProject.Text = "Create New Project";
            createNewProject.UseVisualStyleBackColor = false;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.IndianRed;
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Segoe UI", 16.2F);
            logOutBtn.ForeColor = SystemColors.Control;
            logOutBtn.Location = new Point(12, 867);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(494, 72);
            logOutBtn.TabIndex = 32;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            // 
            // addNewDept
            // 
            addNewDept.BackColor = SystemColors.Highlight;
            addNewDept.BackgroundImageLayout = ImageLayout.Center;
            addNewDept.Font = new Font("Segoe UI", 16.2F);
            addNewDept.ForeColor = SystemColors.Control;
            addNewDept.Location = new Point(12, 450);
            addNewDept.Name = "addNewDept";
            addNewDept.Size = new Size(494, 72);
            addNewDept.TabIndex = 31;
            addNewDept.Text = "Add New Department / Designation";
            addNewDept.UseVisualStyleBackColor = false;
            // 
            // assignNewTask
            // 
            assignNewTask.BackColor = SystemColors.Highlight;
            assignNewTask.BackgroundImageLayout = ImageLayout.Center;
            assignNewTask.Font = new Font("Segoe UI", 16.2F);
            assignNewTask.ForeColor = SystemColors.Control;
            assignNewTask.Location = new Point(12, 528);
            assignNewTask.Name = "assignNewTask";
            assignNewTask.Size = new Size(494, 72);
            assignNewTask.TabIndex = 30;
            assignNewTask.Text = "Assign New Task";
            assignNewTask.UseVisualStyleBackColor = false;
            // 
            // trackProgress
            // 
            trackProgress.BackColor = SystemColors.Highlight;
            trackProgress.BackgroundImageLayout = ImageLayout.Center;
            trackProgress.Font = new Font("Segoe UI", 16.2F);
            trackProgress.ForeColor = SystemColors.Control;
            trackProgress.Location = new Point(12, 606);
            trackProgress.Name = "trackProgress";
            trackProgress.Size = new Size(494, 72);
            trackProgress.TabIndex = 29;
            trackProgress.Text = "Track Progress";
            trackProgress.UseVisualStyleBackColor = false;
            // 
            // manageTask
            // 
            manageTask.BackColor = SystemColors.Highlight;
            manageTask.BackgroundImageLayout = ImageLayout.Center;
            manageTask.Font = new Font("Segoe UI", 16.2F);
            manageTask.ForeColor = SystemColors.Control;
            manageTask.Location = new Point(12, 689);
            manageTask.Name = "manageTask";
            manageTask.Size = new Size(494, 72);
            manageTask.TabIndex = 28;
            manageTask.Text = "Manage Task";
            manageTask.UseVisualStyleBackColor = false;
            // 
            // viewDepartments
            // 
            viewDepartments.BackColor = SystemColors.Highlight;
            viewDepartments.BackgroundImageLayout = ImageLayout.Center;
            viewDepartments.Font = new Font("Segoe UI", 16.2F);
            viewDepartments.ForeColor = SystemColors.Control;
            viewDepartments.Location = new Point(12, 767);
            viewDepartments.Name = "viewDepartments";
            viewDepartments.Size = new Size(494, 72);
            viewDepartments.TabIndex = 27;
            viewDepartments.Text = "View Departments";
            viewDepartments.UseVisualStyleBackColor = false;
            // 
            // registerNewMember
            // 
            registerNewMember.BackColor = SystemColors.Highlight;
            registerNewMember.BackgroundImageLayout = ImageLayout.Center;
            registerNewMember.Font = new Font("Segoe UI", 16.2F);
            registerNewMember.ForeColor = SystemColors.Control;
            registerNewMember.Location = new Point(12, 294);
            registerNewMember.Name = "registerNewMember";
            registerNewMember.Size = new Size(494, 72);
            registerNewMember.TabIndex = 26;
            registerNewMember.Text = "Register New Member";
            registerNewMember.UseVisualStyleBackColor = false;
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
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 249);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // projectNameTotalBudgetandPaidBudget
            // 
            projectNameTotalBudgetandPaidBudget.AllowUserToAddRows = false;
            projectNameTotalBudgetandPaidBudget.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            projectNameTotalBudgetandPaidBudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            projectNameTotalBudgetandPaidBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectNameTotalBudgetandPaidBudget.Location = new Point(573, 294);
            projectNameTotalBudgetandPaidBudget.Name = "projectNameTotalBudgetandPaidBudget";
            projectNameTotalBudgetandPaidBudget.ReadOnly = true;
            projectNameTotalBudgetandPaidBudget.RowHeadersWidth = 51;
            projectNameTotalBudgetandPaidBudget.Size = new Size(613, 306);
            projectNameTotalBudgetandPaidBudget.TabIndex = 38;
            // 
            // departmentData
            // 
            departmentData.AllowUserToAddRows = false;
            departmentData.AllowUserToDeleteRows = false;
            departmentData.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            departmentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            departmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentData.DataSource = dbConnectionBindingSource;
            departmentData.Location = new Point(573, 624);
            departmentData.Name = "departmentData";
            departmentData.ReadOnly = true;
            departmentData.RowHeadersWidth = 51;
            departmentData.Size = new Size(1255, 306);
            departmentData.TabIndex = 37;
            // 
            // _11_MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1875, 1001);
            Controls.Add(projectWithDeadlineAndClientName);
            Controls.Add(linkLabel1);
            Controls.Add(homePage);
            Controls.Add(createNewProject);
            Controls.Add(logOutBtn);
            Controls.Add(addNewDept);
            Controls.Add(assignNewTask);
            Controls.Add(trackProgress);
            Controls.Add(manageTask);
            Controls.Add(viewDepartments);
            Controls.Add(registerNewMember);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(projectNameTotalBudgetandPaidBudget);
            Controls.Add(departmentData);
            Name = "_11_MemberDashboard";
            Text = "_11_MemberDashboard";
            ((System.ComponentModel.ISupportInitialize)projectWithDeadlineAndClientName).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectNameTotalBudgetandPaidBudget).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView projectWithDeadlineAndClientName;
        private BindingSource dbConnectionBindingSource;
        private LinkLabel linkLabel1;
        private LinkLabel homePage;
        private Button createNewProject;
        private Button logOutBtn;
        private Button addNewDept;
        private Button assignNewTask;
        private Button trackProgress;
        private Button manageTask;
        private Button viewDepartments;
        private Button registerNewMember;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView projectNameTotalBudgetandPaidBudget;
        private DataGridView departmentData;
    }
}