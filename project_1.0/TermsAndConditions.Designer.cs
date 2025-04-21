namespace project_1._0
{
    partial class TermsAndConditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsAndConditions));
            termsAndConditionLorem = new TextBox();
            accept = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // termsAndConditionLorem
            // 
            termsAndConditionLorem.BorderStyle = BorderStyle.None;
            termsAndConditionLorem.Location = new Point(12, 12);
            termsAndConditionLorem.Multiline = true;
            termsAndConditionLorem.Name = "termsAndConditionLorem";
            termsAndConditionLorem.ScrollBars = ScrollBars.Vertical;
            termsAndConditionLorem.Size = new Size(1115, 624);
            termsAndConditionLorem.TabIndex = 0;
            termsAndConditionLorem.Text = resources.GetString("termsAndConditionLorem.Text");
            termsAndConditionLorem.UseWaitCursor = true;
            // 
            // accept
            // 
            accept.Location = new Point(869, 665);
            accept.Name = "accept";
            accept.Size = new Size(101, 29);
            accept.TabIndex = 1;
            accept.Text = "Accept";
            accept.UseVisualStyleBackColor = true;
            accept.Click += accept_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(1010, 665);
            Cancel.Name = "Cancel";
            Cancel.RightToLeft = RightToLeft.Yes;
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // TermsAndConditions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 706);
            Controls.Add(Cancel);
            Controls.Add(accept);
            Controls.Add(termsAndConditionLorem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TermsAndConditions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TermsAndConditions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox termsAndConditionLorem;
        private Button accept;
        private Button Cancel;
    }
}