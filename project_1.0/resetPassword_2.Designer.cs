namespace project_1._0
{
    partial class resetPassword_2
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
            linkLabel1 = new LinkLabel();
            loginAsManager = new Button();
            managerUserId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(327, 438);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login Page";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // loginAsManager
            // 
            loginAsManager.BackColor = SystemColors.Highlight;
            loginAsManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsManager.ForeColor = SystemColors.Control;
            loginAsManager.Location = new Point(327, 342);
            loginAsManager.Name = "loginAsManager";
            loginAsManager.Size = new Size(200, 56);
            loginAsManager.TabIndex = 24;
            loginAsManager.Text = "Reset";
            loginAsManager.UseVisualStyleBackColor = false;
            // 
            // managerUserId
            // 
            managerUserId.Location = new Point(327, 212);
            managerUserId.Name = "managerUserId";
            managerUserId.Size = new Size(283, 27);
            managerUserId.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 198);
            label2.Name = "label2";
            label2.Size = new Size(226, 41);
            label2.TabIndex = 22;
            label2.Text = "New Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 37);
            label1.Name = "label1";
            label1.Size = new Size(290, 50);
            label1.TabIndex = 21;
            label1.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 129);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 260);
            label3.Name = "label3";
            label3.Size = new Size(272, 41);
            label3.TabIndex = 26;
            label3.Text = "Confirm Password :";
            // 
            // resetPassword_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 561);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(loginAsManager);
            Controls.Add(managerUserId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "resetPassword_2";
            Text = "resetPassword_2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button loginAsManager;
        private TextBox managerUserId;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label3;
    }
}