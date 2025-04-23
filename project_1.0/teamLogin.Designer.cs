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
            memberForgetPassword = new LinkLabel();
            loginAsMember = new Button();
            memberPassword = new TextBox();
            memberUserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // memberForgetPassword
            // 
            memberForgetPassword.AutoSize = true;
            memberForgetPassword.Location = new Point(205, 438);
            memberForgetPassword.Name = "memberForgetPassword";
            memberForgetPassword.Size = new Size(128, 20);
            memberForgetPassword.TabIndex = 13;
            memberForgetPassword.TabStop = true;
            memberForgetPassword.Text = "Forget Password ?";
            memberForgetPassword.VisitedLinkColor = Color.Red;
            // 
            // loginAsMember
            // 
            loginAsMember.BackColor = SystemColors.Highlight;
            loginAsMember.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsMember.ForeColor = SystemColors.Control;
            loginAsMember.Location = new Point(205, 335);
            loginAsMember.Name = "loginAsMember";
            loginAsMember.Size = new Size(200, 56);
            loginAsMember.TabIndex = 12;
            loginAsMember.Text = "Login";
            loginAsMember.UseVisualStyleBackColor = false;
            // 
            // memberPassword
            // 
            memberPassword.Location = new Point(205, 253);
            memberPassword.Multiline = true;
            memberPassword.Name = "memberPassword";
            memberPassword.Size = new Size(200, 37);
            memberPassword.TabIndex = 11;
            // 
            // memberUserId
            // 
            memberUserId.Location = new Point(205, 154);
            memberUserId.Multiline = true;
            memberUserId.Name = "memberUserId";
            memberUserId.Size = new Size(200, 37);
            memberUserId.TabIndex = 10;
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
            ClientSize = new Size(496, 565);
            Controls.Add(memberForgetPassword);
            Controls.Add(loginAsMember);
            Controls.Add(memberPassword);
            Controls.Add(memberUserId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "teamLogin";
            Text = "teamLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel memberForgetPassword;
        private Button loginAsMember;
        private TextBox memberPassword;
        private TextBox memberUserId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}