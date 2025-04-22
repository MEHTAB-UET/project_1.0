namespace project_1._0
{
    partial class writeConfirmationCode
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
            authenticate = new Button();
            verificationCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(342, 415);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login Page";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // authenticate
            // 
            authenticate.BackColor = SystemColors.Highlight;
            authenticate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authenticate.ForeColor = SystemColors.Control;
            authenticate.Location = new Point(342, 296);
            authenticate.Name = "authenticate";
            authenticate.Size = new Size(200, 56);
            authenticate.TabIndex = 18;
            authenticate.Text = "Continue";
            authenticate.UseVisualStyleBackColor = false;
            // 
            // verificationCode
            // 
            verificationCode.Location = new Point(342, 212);
            verificationCode.Name = "verificationCode";
            verificationCode.Size = new Size(283, 27);
            verificationCode.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 198);
            label2.Name = "label2";
            label2.Size = new Size(259, 41);
            label2.TabIndex = 16;
            label2.Text = "Verification Code :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 37);
            label1.Name = "label1";
            label1.Size = new Size(290, 50);
            label1.TabIndex = 15;
            label1.Text = "Reset Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 129);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // writeConfirmationCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 561);
            Controls.Add(linkLabel1);
            Controls.Add(authenticate);
            Controls.Add(verificationCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "writeConfirmationCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "writeConfirmationCode";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button authenticate;
        private TextBox verificationCode;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}