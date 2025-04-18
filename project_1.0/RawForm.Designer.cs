namespace project_1._0
{
    partial class RawForm
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
            sqlConnector = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // sqlConnector
            // 
            sqlConnector.Location = new Point(24, 26);
            sqlConnector.Name = "sqlConnector";
            sqlConnector.Size = new Size(117, 53);
            sqlConnector.TabIndex = 0;
            sqlConnector.Text = "Connect SQL";
            sqlConnector.UseVisualStyleBackColor = true;
            sqlConnector.Click += sqlConnector_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 26);
            button1.Name = "button1";
            button1.Size = new Size(157, 53);
            button1.TabIndex = 1;
            button1.Text = "sendingMailBtn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RawForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(sqlConnector);
            Name = "RawForm";
            Text = "RawForm";
            ResumeLayout(false);
        }

        #endregion

        private Button sqlConnector;
        private Button button1;
    }
}