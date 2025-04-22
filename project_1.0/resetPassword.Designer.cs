namespace project_1._0
{
    partial class resetPassword
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
            linkLabel1 = new LinkLabel();
            getCode = new Button();
            managerUserId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(299, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login Page";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // getCode
            // 
            getCode.BackColor = SystemColors.Highlight;
            getCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getCode.ForeColor = SystemColors.Control;
            getCode.Location = new Point(299, 290);
            getCode.Name = "getCode";
            getCode.Size = new Size(200, 56);
            getCode.TabIndex = 12;
            getCode.Text = "Get Code";
            getCode.UseVisualStyleBackColor = false;
            getCode.Click += getCode_Click;
            // 
            // managerUserId
            // 
            managerUserId.Location = new Point(299, 212);
            managerUserId.Name = "managerUserId";
            managerUserId.Size = new Size(283, 27);
            managerUserId.TabIndex = 10;
            managerUserId.TextChanged += managerUserId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 198);
            label2.Name = "label2";
            label2.Size = new Size(103, 41);
            label2.TabIndex = 8;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 37);
            label1.Name = "label1";
            label1.Size = new Size(290, 50);
            label1.TabIndex = 7;
            label1.Text = "Reset Password";
            // 
            // resetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 608);
            Controls.Add(linkLabel1);
            Controls.Add(getCode);
            Controls.Add(managerUserId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "resetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "resetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button getCode;
        private TextBox managerUserId;
        private Label label2;
        private Label label1;
    }
}