namespace USAADemoApp
{
    partial class formWelcome
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.checkboxManager = new System.Windows.Forms.CheckBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonViewIssue = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.labelEmployeeFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(5, 6);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(46, 17);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "label1";
            // 
            // checkboxManager
            // 
            this.checkboxManager.AutoSize = true;
            this.checkboxManager.Location = new System.Drawing.Point(345, 6);
            this.checkboxManager.Margin = new System.Windows.Forms.Padding(1);
            this.checkboxManager.Name = "checkboxManager";
            this.checkboxManager.Size = new System.Drawing.Size(94, 21);
            this.checkboxManager.TabIndex = 2;
            this.checkboxManager.Text = "Manager?";
            this.checkboxManager.UseVisualStyleBackColor = true;
            this.checkboxManager.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(127, 114);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(196, 29);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Create Issue ";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.postButton_Click);
            // 
            // buttonViewIssue
            // 
            this.buttonViewIssue.Location = new System.Drawing.Point(127, 166);
            this.buttonViewIssue.Margin = new System.Windows.Forms.Padding(1);
            this.buttonViewIssue.Name = "buttonViewIssue";
            this.buttonViewIssue.Size = new System.Drawing.Size(196, 26);
            this.buttonViewIssue.TabIndex = 4;
            this.buttonViewIssue.Text = "View Issue Board";
            this.buttonViewIssue.UseVisualStyleBackColor = true;
            this.buttonViewIssue.Click += new System.EventHandler(this.viewTopIssuesButton_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(127, 213);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(1);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(196, 25);
            this.buttonGenerateReport.TabIndex = 5;
            this.buttonGenerateReport.Text = "Generate Monthly Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeFeedback
            // 
            this.labelEmployeeFeedback.AutoSize = true;
            this.labelEmployeeFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedback.Location = new System.Drawing.Point(5, 48);
            this.labelEmployeeFeedback.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedback.Name = "labelEmployeeFeedback";
            this.labelEmployeeFeedback.Size = new System.Drawing.Size(437, 42);
            this.labelEmployeeFeedback.TabIndex = 6;
            this.labelEmployeeFeedback.Text = "Employee Feedback App";
            // 
            // formWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 266);
            this.Controls.Add(this.labelEmployeeFeedback);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.buttonViewIssue);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.checkboxManager);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formWelcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.CheckBox checkboxManager;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonViewIssue;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelEmployeeFeedback;
    }
}