namespace project_1._0
{
    partial class addNewDept
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
            addDeptBtn = new Button();
            managerUserId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(263, 431);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Dashboard";
            linkLabel1.VisitedLinkColor = Color.Red;
            // 
            // addDeptBtn
            // 
            addDeptBtn.BackColor = SystemColors.Highlight;
            addDeptBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDeptBtn.ForeColor = SystemColors.Control;
            addDeptBtn.Location = new Point(263, 253);
            addDeptBtn.Name = "addDeptBtn";
            addDeptBtn.Size = new Size(200, 56);
            addDeptBtn.TabIndex = 12;
            addDeptBtn.Text = "Add";
            addDeptBtn.UseVisualStyleBackColor = false;
            // 
            // managerUserId
            // 
            managerUserId.Location = new Point(263, 176);
            managerUserId.Multiline = true;
            managerUserId.Name = "managerUserId";
            managerUserId.Size = new Size(200, 37);
            managerUserId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 185);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 8;
            label2.Text = "Department Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 59);
            label1.Name = "label1";
            label1.Size = new Size(328, 41);
            label1.TabIndex = 7;
            label1.Text = "Add New Department";
            // 
            // cancel
            // 
            cancel.BackColor = Color.IndianRed;
            cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.Control;
            cancel.Location = new Point(263, 335);
            cancel.Name = "cancel";
            cancel.Size = new Size(200, 56);
            cancel.TabIndex = 14;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 123);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // addNewDept
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 565);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(linkLabel1);
            Controls.Add(addDeptBtn);
            Controls.Add(managerUserId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addNewDept";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Department";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button addDeptBtn;
        private TextBox managerUserId;
        private Label label2;
        private Label label1;
        private Button cancel;
        private PictureBox pictureBox1;
    }
}