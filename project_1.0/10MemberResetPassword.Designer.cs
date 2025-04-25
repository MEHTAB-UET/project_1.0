namespace project_1._0
{
    partial class _10MemberResetPassword
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
            employeeNewPassword = new TextBox();
            cnfrmPassword = new TextBox();
            label3 = new Label();
            backToLoginPage = new LinkLabel();
            reset = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeeNewPassword
            // 
            employeeNewPassword.Location = new Point(340, 212);
            employeeNewPassword.Name = "employeeNewPassword";
            employeeNewPassword.Size = new Size(283, 27);
            employeeNewPassword.TabIndex = 36;
            // 
            // cnfrmPassword
            // 
            cnfrmPassword.Location = new Point(340, 274);
            cnfrmPassword.Name = "cnfrmPassword";
            cnfrmPassword.Size = new Size(283, 27);
            cnfrmPassword.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 260);
            label3.Name = "label3";
            label3.Size = new Size(272, 41);
            label3.TabIndex = 34;
            label3.Text = "Confirm Password :";
            // 
            // backToLoginPage
            // 
            backToLoginPage.AutoSize = true;
            backToLoginPage.Location = new Point(340, 438);
            backToLoginPage.Name = "backToLoginPage";
            backToLoginPage.Size = new Size(135, 20);
            backToLoginPage.TabIndex = 33;
            backToLoginPage.TabStop = true;
            backToLoginPage.Text = "Back to Login Page";
            backToLoginPage.VisitedLinkColor = Color.Red;
            backToLoginPage.LinkClicked += backToLoginPage_LinkClicked;
            // 
            // reset
            // 
            reset.BackColor = SystemColors.Highlight;
            reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reset.ForeColor = SystemColors.Control;
            reset.Location = new Point(340, 342);
            reset.Name = "reset";
            reset.Size = new Size(200, 56);
            reset.TabIndex = 32;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 198);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 31;
            label2.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(340, 60);
            label1.Name = "label1";
            label1.Size = new Size(290, 50);
            label1.TabIndex = 30;
            label1.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 129);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // _10MemberResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 556);
            Controls.Add(employeeNewPassword);
            Controls.Add(cnfrmPassword);
            Controls.Add(label3);
            Controls.Add(backToLoginPage);
            Controls.Add(reset);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "_10MemberResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_10MemberResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox employeeNewPassword;
        private TextBox cnfrmPassword;
        private Label label3;
        private LinkLabel backToLoginPage;
        private Button reset;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}