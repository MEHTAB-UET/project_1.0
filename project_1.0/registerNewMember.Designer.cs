namespace project_1._0
{
    partial class registerNewMember
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
            fullNameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            fullName = new TextBox();
            emailAddress = new TextBox();
            phoneNumber = new TextBox();
            CNIC = new TextBox();
            userName = new TextBox();
            gender = new ComboBox();
            dateofBirth = new DateTimePicker();
            dateofJoining = new DateTimePicker();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loginAsManager = new Button();
            button1 = new Button();
            cnfrmPassword = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label12 = new Label();
            designationCombo = new ComboBox();
            departmentCombo = new ComboBox();
            label13 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 18F);
            fullNameLabel.Location = new Point(156, 256);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(166, 41);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Full Name :";
            fullNameLabel.Click += fullNameLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(716, 45);
            label2.Name = "label2";
            label2.Size = new Size(410, 50);
            label2.TabIndex = 1;
            label2.Text = "Welocme to WorkZen ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(785, 113);
            label3.Name = "label3";
            label3.Size = new Size(253, 38);
            label3.TabIndex = 2;
            label3.Text = "Registration Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(1124, 604);
            label4.Name = "label4";
            label4.Size = new Size(167, 41);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(154, 316);
            label5.Name = "label5";
            label5.Size = new Size(218, 41);
            label5.TabIndex = 4;
            label5.Text = "Email Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(154, 378);
            label6.Name = "label6";
            label6.Size = new Size(235, 41);
            label6.TabIndex = 5;
            label6.Text = "Phone Number :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(156, 447);
            label7.Name = "label7";
            label7.Size = new Size(101, 41);
            label7.TabIndex = 6;
            label7.Text = "CNIC :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(156, 646);
            label8.Name = "label8";
            label8.Size = new Size(131, 41);
            label8.TabIndex = 7;
            label8.Text = "Gender :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(156, 722);
            label9.Name = "label9";
            label9.Size = new Size(199, 41);
            label9.TabIndex = 8;
            label9.Text = "Date of Birth :";
            label9.Click += label9_Click;
            // 
            // fullName
            // 
            fullName.Location = new Point(499, 270);
            fullName.Name = "fullName";
            fullName.Size = new Size(326, 27);
            fullName.TabIndex = 9;
            // 
            // emailAddress
            // 
            emailAddress.Location = new Point(497, 330);
            emailAddress.Name = "emailAddress";
            emailAddress.Size = new Size(326, 27);
            emailAddress.TabIndex = 10;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(497, 392);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(326, 27);
            phoneNumber.TabIndex = 12;
            // 
            // CNIC
            // 
            CNIC.Location = new Point(499, 461);
            CNIC.Name = "CNIC";
            CNIC.Size = new Size(326, 27);
            CNIC.TabIndex = 13;
            // 
            // userName
            // 
            userName.Location = new Point(1467, 618);
            userName.Name = "userName";
            userName.Size = new Size(326, 27);
            userName.TabIndex = 14;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(499, 659);
            gender.Name = "gender";
            gender.Size = new Size(326, 28);
            gender.TabIndex = 15;
            // 
            // dateofBirth
            // 
            dateofBirth.Location = new Point(499, 736);
            dateofBirth.Name = "dateofBirth";
            dateofBirth.Size = new Size(326, 27);
            dateofBirth.TabIndex = 16;
            // 
            // dateofJoining
            // 
            dateofJoining.Location = new Point(499, 814);
            dateofJoining.Name = "dateofJoining";
            dateofJoining.Size = new Size(326, 27);
            dateofJoining.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(156, 800);
            label10.Name = "label10";
            label10.Size = new Size(233, 41);
            label10.TabIndex = 17;
            label10.Text = "Date of Joining :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(156, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 149);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(1127, 270);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 149);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // loginAsManager
            // 
            loginAsManager.BackColor = SystemColors.Highlight;
            loginAsManager.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginAsManager.ForeColor = SystemColors.Control;
            loginAsManager.Location = new Point(1127, 448);
            loginAsManager.Name = "loginAsManager";
            loginAsManager.Size = new Size(164, 46);
            loginAsManager.TabIndex = 21;
            loginAsManager.Text = "Select File";
            loginAsManager.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1127, 531);
            button1.Name = "button1";
            button1.Size = new Size(164, 46);
            button1.TabIndex = 22;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            // 
            // cnfrmPassword
            // 
            cnfrmPassword.Location = new Point(1470, 750);
            cnfrmPassword.Name = "cnfrmPassword";
            cnfrmPassword.Size = new Size(326, 27);
            cnfrmPassword.TabIndex = 26;
            // 
            // password
            // 
            password.Location = new Point(1467, 684);
            password.Name = "password";
            password.Size = new Size(326, 27);
            password.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(1127, 736);
            label1.Name = "label1";
            label1.Size = new Size(272, 41);
            label1.TabIndex = 24;
            label1.Text = "Confirm Password :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(1124, 670);
            label11.Name = "label11";
            label11.Size = new Size(158, 41);
            label11.TabIndex = 23;
            label11.Text = "Password :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(156, 579);
            label12.Name = "label12";
            label12.Size = new Size(192, 41);
            label12.TabIndex = 27;
            label12.Text = "Designation :";
            // 
            // designationCombo
            // 
            designationCombo.FormattingEnabled = true;
            designationCombo.Items.AddRange(new object[] { "Senior Software Engineer", "Software Engineer", "Junior Software Engineer", "Associate ", "Software Engineer", "Backend Developer", "Frontend Developer", "Full Stack Developer", "Mobile App Developer", "Game Developer", "DevOps Engineer", "Database Developer", "Embedded Systems Developer" });
            designationCombo.Location = new Point(497, 592);
            designationCombo.Name = "designationCombo";
            designationCombo.Size = new Size(326, 28);
            designationCombo.TabIndex = 28;
            // 
            // departmentCombo
            // 
            departmentCombo.FormattingEnabled = true;
            departmentCombo.Items.AddRange(new object[] { "Senior Software Engineer", "Software Engineer", "Junior Software Engineer", "Associate ", "Software Engineer", "Backend Developer", "Frontend Developer", "Full Stack Developer", "Mobile App Developer", "Game Developer", "DevOps Engineer", "Database Developer", "Embedded Systems Developer" });
            departmentCombo.Location = new Point(495, 526);
            departmentCombo.Name = "departmentCombo";
            departmentCombo.Size = new Size(326, 28);
            departmentCombo.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(154, 513);
            label13.Name = "label13";
            label13.Size = new Size(192, 41);
            label13.TabIndex = 29;
            label13.Text = "Department :";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1127, 814);
            button2.Name = "button2";
            button2.Size = new Size(287, 46);
            button2.TabIndex = 31;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(1467, 69);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(276, 38);
            linkLabel1.TabIndex = 32;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Upgrade to Premuim";
            // 
            // registerNewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1609, 907);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(departmentCombo);
            Controls.Add(label13);
            Controls.Add(designationCombo);
            Controls.Add(label12);
            Controls.Add(cnfrmPassword);
            Controls.Add(password);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(loginAsManager);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dateofJoining);
            Controls.Add(label10);
            Controls.Add(dateofBirth);
            Controls.Add(gender);
            Controls.Add(userName);
            Controls.Add(CNIC);
            Controls.Add(phoneNumber);
            Controls.Add(emailAddress);
            Controls.Add(fullName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fullNameLabel);
            Name = "registerNewMember";
            Text = "registerNewMember";
            Load += registerNewMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox fullName;
        private TextBox emailAddress;
        private TextBox phoneNumber;
        private TextBox CNIC;
        private TextBox userName;
        private ComboBox gender;
        private DateTimePicker dateofBirth;
        private DateTimePicker dateofJoining;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button loginAsManager;
        private Button button1;
        private TextBox cnfrmPassword;
        private TextBox password;
        private Label label1;
        private Label label11;
        private Label label12;
        private ComboBox designationCombo;
        private ComboBox departmentCombo;
        private Label label13;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}