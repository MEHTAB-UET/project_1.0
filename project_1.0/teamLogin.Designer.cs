namespace project_1._0
{
    partial class teamLogin
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
            employeeForgetPassword = new LinkLabel();
            loginAsEmployee = new Button();
            employeePassword = new TextBox();
            employeeUserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // employeeForgetPassword
            // 
            employeeForgetPassword.AutoSize = true;
            employeeForgetPassword.Location = new Point(205, 445);
            employeeForgetPassword.Name = "employeeForgetPassword";
            employeeForgetPassword.Size = new Size(128, 20);
            employeeForgetPassword.TabIndex = 13;
            employeeForgetPassword.TabStop = true;
            employeeForgetPassword.Text = "Forget Password ?";
            employeeForgetPassword.VisitedLinkColor = Color.Red;
            employeeForgetPassword.LinkClicked += employeeForgetPassword_LinkClicked;
            // 
            // loginAsEmployee
            // 
            loginAsEmployee.BackColor = SystemColors.Highlight;
            loginAsEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsEmployee.ForeColor = SystemColors.Control;
            loginAsEmployee.Location = new Point(205, 335);
            loginAsEmployee.Name = "loginAsEmployee";
            loginAsEmployee.Size = new Size(200, 56);
            loginAsEmployee.TabIndex = 12;
            loginAsEmployee.Text = "Login";
            loginAsEmployee.UseVisualStyleBackColor = false;
            loginAsEmployee.Click += loginAsEmployee_Click;
            // 
            // employeePassword
            // 
            employeePassword.Location = new Point(205, 253);
            employeePassword.Multiline = true;
            employeePassword.Name = "employeePassword";
            employeePassword.Size = new Size(200, 37);
            employeePassword.TabIndex = 11;
            employeePassword.TextChanged += employeePassword_TextChanged;
            // 
            // employeeUserId
            // 
            employeeUserId.Location = new Point(205, 154);
            employeeUserId.Multiline = true;
            employeeUserId.Name = "employeeUserId";
            employeeUserId.Size = new Size(200, 37);
            employeeUserId.TabIndex = 10;
            employeeUserId.TextChanged += employeeUserId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 262);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 9;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 163);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 8;
            label2.Text = "User ID :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 7;
            label1.Text = "Welocme to WorkZen ";
            // 
            // teamLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 565);
            Controls.Add(employeeForgetPassword);
            Controls.Add(loginAsEmployee);
            Controls.Add(employeePassword);
            Controls.Add(employeeUserId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "teamLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "teamLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel employeeForgetPassword;
        private Button loginAsEmployee;
        private TextBox employeePassword;
        private TextBox employeeUserId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}