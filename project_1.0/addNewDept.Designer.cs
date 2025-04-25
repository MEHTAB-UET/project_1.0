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
            newDeptName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cancel = new Button();
            pictureBox1 = new PictureBox();
            cancelBtn = new Button();
            addDesignation = new Button();
            designation = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            departmentCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(986, 115);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Dashboard";
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // addDeptBtn
            // 
            addDeptBtn.BackColor = SystemColors.Highlight;
            addDeptBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDeptBtn.ForeColor = SystemColors.Control;
            addDeptBtn.Location = new Point(776, 299);
            addDeptBtn.Name = "addDeptBtn";
            addDeptBtn.Size = new Size(200, 56);
            addDeptBtn.TabIndex = 12;
            addDeptBtn.Text = "Add";
            addDeptBtn.UseVisualStyleBackColor = false;
            addDeptBtn.Click += addDeptBtn_Click;
            // 
            // newDeptName
            // 
            newDeptName.Location = new Point(458, 219);
            newDeptName.Multiline = true;
            newDeptName.Name = "newDeptName";
            newDeptName.Size = new Size(518, 37);
            newDeptName.TabIndex = 10;
            newDeptName.TextChanged += newDeptName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 228);
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
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(458, 94);
            label1.Name = "label1";
            label1.Size = new Size(336, 41);
            label1.TabIndex = 7;
            label1.Text = "Add New Department ";
            // 
            // cancel
            // 
            cancel.BackColor = Color.IndianRed;
            cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel.ForeColor = SystemColors.Control;
            cancel.Location = new Point(458, 299);
            cancel.Name = "cancel";
            cancel.Size = new Size(200, 56);
            cancel.TabIndex = 14;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 123);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.IndianRed;
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.Control;
            cancelBtn.Location = new Point(458, 650);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(200, 56);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addDesignation
            // 
            addDesignation.BackColor = SystemColors.Highlight;
            addDesignation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDesignation.ForeColor = SystemColors.Control;
            addDesignation.Location = new Point(776, 650);
            addDesignation.Name = "addDesignation";
            addDesignation.Size = new Size(200, 56);
            addDesignation.TabIndex = 18;
            addDesignation.Text = "Add";
            addDesignation.UseVisualStyleBackColor = false;
            addDesignation.Click += addDesignation_Click;
            // 
            // designation
            // 
            designation.Location = new Point(458, 570);
            designation.Multiline = true;
            designation.Name = "designation";
            designation.Size = new Size(518, 37);
            designation.TabIndex = 17;
            designation.TextChanged += designation_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 579);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 16;
            label3.Text = "Designation :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(458, 422);
            label4.Name = "label4";
            label4.Size = new Size(327, 41);
            label4.TabIndex = 20;
            label4.Text = "Add New Designation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(190, 512);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 21;
            label5.Text = "Select Department :";
            // 
            // departmentCombo
            // 
            departmentCombo.FormattingEnabled = true;
            departmentCombo.Items.AddRange(new object[] { " " });
            departmentCombo.Location = new Point(458, 512);
            departmentCombo.Name = "departmentCombo";
            departmentCombo.Size = new Size(518, 28);
            departmentCombo.TabIndex = 31;
            departmentCombo.SelectedIndexChanged += departmentCombo_SelectedIndexChanged;
            // 
            // addNewDept
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 731);
            Controls.Add(departmentCombo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cancelBtn);
            Controls.Add(addDesignation);
            Controls.Add(designation);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(cancel);
            Controls.Add(linkLabel1);
            Controls.Add(addDeptBtn);
            Controls.Add(newDeptName);
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
        private TextBox newDeptName;
        private Label label2;
        private Label label1;
        private Button cancel;
        private PictureBox pictureBox1;
        private Button cancelBtn;
        private Button addDesignation;
        private TextBox designation;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox departmentCombo;
    }
}