namespace project_1._0
{
    partial class ManagerLogin
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
            label2 = new Label();
            label3 = new Label();
            managerUserId = new TextBox();
            managerPassword = new TextBox();
            loginAsManager = new Button();
            forgetPassword = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(48, 33);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 0;
            label1.Text = "Welocme to WorkZen ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 150);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 1;
            label2.Text = "User ID :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 279);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            label3.Click += label3_Click;
            // 
            // managerUserId
            // 
            managerUserId.Location = new Point(210, 141);
            managerUserId.Multiline = true;
            managerUserId.Name = "managerUserId";
            managerUserId.Size = new Size(200, 37);
            managerUserId.TabIndex = 3;
            managerUserId.TextChanged += managerUserId_TextChanged;
            // 
            // managerPassword
            // 
            managerPassword.Location = new Point(210, 270);
            managerPassword.Multiline = true;
            managerPassword.Name = "managerPassword";
            managerPassword.Size = new Size(200, 37);
            managerPassword.TabIndex = 4;
            managerPassword.TextChanged += managerPassword_TextChanged;
            // 
            // loginAsManager
            // 
            loginAsManager.BackColor = SystemColors.Highlight;
            loginAsManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsManager.ForeColor = SystemColors.Control;
            loginAsManager.Location = new Point(207, 370);
            loginAsManager.Name = "loginAsManager";
            loginAsManager.Size = new Size(200, 56);
            loginAsManager.TabIndex = 5;
            loginAsManager.Text = "Login";
            loginAsManager.UseVisualStyleBackColor = false;
            loginAsManager.Click += loginAsManager_Click;
            // 
            // forgetPassword
            // 
            forgetPassword.AutoSize = true;
            forgetPassword.Location = new Point(207, 488);
            forgetPassword.Name = "forgetPassword";
            forgetPassword.Size = new Size(128, 20);
            forgetPassword.TabIndex = 6;
            forgetPassword.TabStop = true;
            forgetPassword.Text = "Forget Password ?";
            forgetPassword.VisitedLinkColor = Color.Red;
            forgetPassword.LinkClicked += forgetPassword_LinkClicked;
            // 
            // ManagerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 600);
            Controls.Add(forgetPassword);
            Controls.Add(loginAsManager);
            Controls.Add(managerPassword);
            Controls.Add(managerUserId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerLogin";
            Load += ManagerLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox managerUserId;
        private TextBox managerPassword;
        private Button loginAsManager;
        private LinkLabel forgetPassword;
    }
}