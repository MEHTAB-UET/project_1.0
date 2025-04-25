namespace project_1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            loginAsManager = new Button();
            loginAsMember = new Button();
            termAndCondition = new Label();
            privacyPolicy = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 249);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginAsManager
            // 
            loginAsManager.BackColor = SystemColors.Highlight;
            loginAsManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsManager.ForeColor = SystemColors.Control;
            loginAsManager.Location = new Point(42, 268);
            loginAsManager.Name = "loginAsManager";
            loginAsManager.Size = new Size(398, 103);
            loginAsManager.TabIndex = 1;
            loginAsManager.Text = "Login as Project Manager";
            loginAsManager.UseVisualStyleBackColor = false;
            loginAsManager.Click += loginAsManager_Click;
            // 
            // loginAsMember
            // 
            loginAsMember.BackColor = SystemColors.Highlight;
            loginAsMember.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsMember.ForeColor = SystemColors.Control;
            loginAsMember.Location = new Point(42, 390);
            loginAsMember.Name = "loginAsMember";
            loginAsMember.Size = new Size(398, 103);
            loginAsMember.TabIndex = 2;
            loginAsMember.Text = "Login as Employee";
            loginAsMember.UseVisualStyleBackColor = false;
            loginAsMember.Click += loginAsMember_Click;
            // 
            // termAndCondition
            // 
            termAndCondition.AutoSize = true;
            termAndCondition.ForeColor = SystemColors.Highlight;
            termAndCondition.Location = new Point(42, 649);
            termAndCondition.Name = "termAndCondition";
            termAndCondition.Size = new Size(152, 20);
            termAndCondition.TabIndex = 3;
            termAndCondition.Text = "Terms and Conditions";
            termAndCondition.Click += termAndCondition_Click;
            // 
            // privacyPolicy
            // 
            privacyPolicy.AutoSize = true;
            privacyPolicy.ForeColor = SystemColors.Highlight;
            privacyPolicy.Location = new Point(343, 649);
            privacyPolicy.Name = "privacyPolicy";
            privacyPolicy.Size = new Size(97, 20);
            privacyPolicy.TabIndex = 4;
            privacyPolicy.Text = "Privacy Policy";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(42, 515);
            button1.Name = "button1";
            button1.Size = new Size(398, 103);
            button1.TabIndex = 5;
            button1.Text = "Login as Client";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(494, 678);
            Controls.Add(button1);
            Controls.Add(privacyPolicy);
            Controls.Add(termAndCondition);
            Controls.Add(loginAsMember);
            Controls.Add(loginAsManager);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button loginAsManager;
        private Button loginAsMember;
        private Label termAndCondition;
        private Label privacyPolicy;
        private Button button1;
    }
}
