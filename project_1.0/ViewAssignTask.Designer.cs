namespace project_1._0
{
    partial class ViewAssignTask
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            viewAssignedTaskData = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            logOutBtn = new Button();
            done = new Button();
            ((System.ComponentModel.ISupportInitialize)viewAssignedTaskData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(547, 69);
            label1.Name = "label1";
            label1.Size = new Size(737, 68);
            label1.TabIndex = 26;
            label1.Text = "Task Assigned To You";
            label1.Click += label1_Click;
            // 
            // viewAssignedTaskData
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            viewAssignedTaskData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            viewAssignedTaskData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAssignedTaskData.Location = new Point(21, 225);
            viewAssignedTaskData.Name = "viewAssignedTaskData";
            viewAssignedTaskData.RowHeadersWidth = 51;
            viewAssignedTaskData.Size = new Size(1770, 420);
            viewAssignedTaskData.TabIndex = 27;
            viewAssignedTaskData.CellContentClick += viewAssignedTaskData_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1591, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 136);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(21, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 136);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.IndianRed;
            logOutBtn.BackgroundImageLayout = ImageLayout.Center;
            logOutBtn.Font = new Font("Segoe UI", 16.2F);
            logOutBtn.ForeColor = SystemColors.Control;
            logOutBtn.Location = new Point(1557, 674);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(240, 72);
            logOutBtn.TabIndex = 34;
            logOutBtn.Text = "Log Out";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // done
            // 
            done.BackColor = SystemColors.Highlight;
            done.BackgroundImageLayout = ImageLayout.Center;
            done.Font = new Font("Segoe UI", 16.2F);
            done.ForeColor = SystemColors.Control;
            done.Location = new Point(1297, 674);
            done.Name = "done";
            done.Size = new Size(240, 72);
            done.TabIndex = 33;
            done.Text = "Done";
            done.UseVisualStyleBackColor = false;
            done.Click += done_Click;
            // 
            // ViewAssignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 758);
            Controls.Add(logOutBtn);
            Controls.Add(done);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(viewAssignedTaskData);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAssignTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewAssignTask";
            ((System.ComponentModel.ISupportInitialize)viewAssignedTaskData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView viewAssignedTaskData;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button logOutBtn;
        private Button done;
    }
}