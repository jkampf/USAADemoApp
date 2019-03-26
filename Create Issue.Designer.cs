namespace USAADemoApp
{
    partial class createIssueForm
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
            this.postIssueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postIssueButton
            // 
            this.postIssueButton.Location = new System.Drawing.Point(109, 138);
            this.postIssueButton.Margin = new System.Windows.Forms.Padding(1);
            this.postIssueButton.Name = "postIssueButton";
            this.postIssueButton.Size = new System.Drawing.Size(91, 30);
            this.postIssueButton.TabIndex = 0;
            this.postIssueButton.Text = "Post Issue";
            this.postIssueButton.UseVisualStyleBackColor = true;
            this.postIssueButton.Click += new System.EventHandler(this.buttonPostIssue_Click);
            // 
            // createIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 194);
            this.Controls.Add(this.postIssueButton);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "createIssueForm";
            this.Text = "Create Issue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button postIssueButton;
    }
}