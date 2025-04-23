namespace project_1._0
{
    partial class createNewProject
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
            cancel = new Button();
            backToDashboard = new LinkLabel();
            addNewProject = new Button();
            projectName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ClientName = new TextBox();
            label3 = new Label();
            ProjectDescription = new TextBox();
            label4 = new Label();
            deadline = new Label();
            deadlineOfProject = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 123);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.IndianRed;
            cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.Control;
            cancel.Location = new Point(249, 694);
            cancel.Name = "cancel";
            cancel.Size = new Size(200, 56);
            cancel.TabIndex = 21;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            // 
            // backToDashboard
            // 
            backToDashboard.AutoSize = true;
            backToDashboard.Location = new Point(249, 764);
            backToDashboard.Name = "backToDashboard";
            backToDashboard.Size = new Size(135, 20);
            backToDashboard.TabIndex = 20;
            backToDashboard.TabStop = true;
            backToDashboard.Text = "Back to Dashboard";
            backToDashboard.VisitedLinkColor = Color.Red;
            // 
            // addNewProject
            // 
            addNewProject.BackColor = SystemColors.Highlight;
            addNewProject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewProject.ForeColor = SystemColors.Control;
            addNewProject.Location = new Point(249, 632);
            addNewProject.Name = "addNewProject";
            addNewProject.Size = new Size(200, 56);
            addNewProject.TabIndex = 19;
            addNewProject.Text = "Add";
            addNewProject.UseVisualStyleBackColor = false;
            // 
            // projectName
            // 
            projectName.Location = new Point(249, 204);
            projectName.Multiline = true;
            projectName.Name = "projectName";
            projectName.Size = new Size(200, 37);
            projectName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 213);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 17;
            label2.Text = "Project Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 86);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 16;
            label1.Text = "Create New Project";
            // 
            // ClientName
            // 
            ClientName.Location = new Point(249, 280);
            ClientName.Multiline = true;
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(200, 37);
            ClientName.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 289);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 23;
            label3.Text = "Client Name";
            // 
            // ProjectDescription
            // 
            ProjectDescription.Location = new Point(249, 353);
            ProjectDescription.Multiline = true;
            ProjectDescription.Name = "ProjectDescription";
            ProjectDescription.Size = new Size(200, 121);
            ProjectDescription.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 362);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 25;
            label4.Text = "Description";
            // 
            // deadline
            // 
            deadline.AutoSize = true;
            deadline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deadline.Location = new Point(47, 511);
            deadline.Name = "deadline";
            deadline.Size = new Size(102, 28);
            deadline.TabIndex = 27;
            deadline.Text = "DeadLine :";
            // 
            // deadlineOfProject
            // 
            deadlineOfProject.Location = new Point(249, 527);
            deadlineOfProject.Name = "deadlineOfProject";
            deadlineOfProject.Size = new Size(217, 27);
            deadlineOfProject.TabIndex = 28;
            // 
            // createNewProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 841);
            Controls.Add(deadlineOfProject);
            Controls.Add(deadline);
            Controls.Add(ProjectDescription);
            Controls.Add(label4);
            Controls.Add(ClientName);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(backToDashboard);
            Controls.Add(addNewProject);
            Controls.Add(projectName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "createNewProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "createNewProject";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cancel;
        private LinkLabel backToDashboard;
        private Button addNewProject;
        private TextBox projectName;
        private Label label2;
        private Label label1;
        private TextBox ClientName;
        private Label label3;
        private TextBox ProjectDescription;
        private Label label4;
        private Label deadline;
        private DateTimePicker deadlineOfProject;
    }
}