namespace project_1._0
{
    partial class updateTaskStatus
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
            logOutBtn = new Button();
            viewDepartments = new Button();
            taskCombo = new ComboBox();
            stateCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(411, 92);
            label1.Name = "label1";
            label1.Size = new Size(642, 68);
            label1.TabIndex = 27;
            label1.Text = "Update Task Status";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(56, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 136);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(258, 255);
            label2.Name = "label2";
            label2.Size = new Size(187, 41);
            label2.TabIndex = 31;
            label2.Text = "Select Task :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(258, 349);
            label3.Name = "label3";
            label3.Size = new Size(159, 41);
            label3.TabIndex = 32;
            label3.Text = "Set State :";
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.IndianRed;
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Segoe UI", 16.2F);
            logOutBtn.ForeColor = SystemColors.Control;
            logOutBtn.Location = new Point(639, 478);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(258, 72);
            logOutBtn.TabIndex = 34;
            logOutBtn.Text = "Cancel";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // viewDepartments
            // 
            viewDepartments.BackColor = SystemColors.Highlight;
            viewDepartments.BackgroundImageLayout = ImageLayout.Center;
            viewDepartments.Font = new Font("Segoe UI", 16.2F);
            viewDepartments.ForeColor = SystemColors.Control;
            viewDepartments.Location = new Point(258, 478);
            viewDepartments.Name = "viewDepartments";
            viewDepartments.Size = new Size(258, 72);
            viewDepartments.TabIndex = 33;
            viewDepartments.Text = "Set State";
            viewDepartments.UseVisualStyleBackColor = false;
            viewDepartments.Click += viewDepartments_Click;
            // 
            // taskCombo
            // 
            taskCombo.FormattingEnabled = true;
            taskCombo.Location = new Point(585, 268);
            taskCombo.Name = "taskCombo";
            taskCombo.Size = new Size(312, 28);
            taskCombo.TabIndex = 35;
            taskCombo.SelectedIndexChanged += taskCombo_SelectedIndexChanged;
            // 
            // stateCombo
            // 
            stateCombo.FormattingEnabled = true;
            stateCombo.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            stateCombo.Location = new Point(585, 362);
            stateCombo.Name = "stateCombo";
            stateCombo.Size = new Size(312, 28);
            stateCombo.TabIndex = 36;
            stateCombo.SelectedIndexChanged += stateCombo_SelectedIndexChanged;
            // 
            // updateTaskStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 621);
            Controls.Add(stateCombo);
            Controls.Add(taskCombo);
            Controls.Add(logOutBtn);
            Controls.Add(viewDepartments);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "updateTaskStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "updateTaskStatus";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Button logOutBtn;
        private Button viewDepartments;
        private ComboBox taskCombo;
        private ComboBox stateCombo;
    }
}