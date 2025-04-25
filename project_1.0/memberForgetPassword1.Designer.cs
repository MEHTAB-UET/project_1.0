namespace project_1._0
{
    partial class memberForgetPassword1
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
            getCode = new Button();
            memberEmailForOTP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(299, 400);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login Page";
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // getCode
            // 
            getCode.BackColor = SystemColors.Highlight;
            getCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getCode.ForeColor = SystemColors.Control;
            getCode.Location = new Point(299, 290);
            getCode.Name = "getCode";
            getCode.Size = new Size(200, 56);
            getCode.TabIndex = 18;
            getCode.Text = "Get Code";
            getCode.UseVisualStyleBackColor = false;
            // 
            // memberEmailForOTP
            // 
            memberEmailForOTP.Location = new Point(299, 212);
            memberEmailForOTP.Name = "memberEmailForOTP";
            memberEmailForOTP.Size = new Size(283, 27);
            memberEmailForOTP.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 198);
            label2.Name = "label2";
            label2.Size = new Size(103, 41);
            label2.TabIndex = 16;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(299, 57);
            label3.Name = "label3";
            label3.Size = new Size(290, 50);
            label3.TabIndex = 15;
            label3.Text = "Reset Password";
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
            // memberForgetPassword1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 503);
            Controls.Add(linkLabel1);
            Controls.Add(getCode);
            Controls.Add(memberEmailForOTP);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "memberForgetPassword1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "memberForgetPassword1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button getCode;
        private TextBox memberEmailForOTP;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}