namespace USAADemoApp
{
    partial class PostBoard
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
            this.listBoxImplementations = new System.Windows.Forms.ListBox();
            this.buttonNewPost = new System.Windows.Forms.Button();
            this.checkBoxIsManager = new System.Windows.Forms.CheckBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.listBoxSuggestions = new System.Windows.Forms.ListBox();
            this.labelImplementations = new System.Windows.Forms.Label();
            this.labelIssues = new System.Windows.Forms.Label();
            this.labelSuggestions = new System.Windows.Forms.Label();
            this.labelEmployeeFeedbackApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxImplementations
            // 
            this.listBoxImplementations.FormattingEnabled = true;
            this.listBoxImplementations.ItemHeight = 16;
            this.listBoxImplementations.Location = new System.Drawing.Point(11, 82);
            this.listBoxImplementations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxImplementations.Name = "listBoxImplementations";
            this.listBoxImplementations.Size = new System.Drawing.Size(320, 404);
            this.listBoxImplementations.TabIndex = 5;
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.Location = new System.Drawing.Point(496, 515);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPost.TabIndex = 3;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = true;
            this.buttonNewPost.Click += new System.EventHandler(this.ButtonNewPost_Click);
            // 
            // checkBoxIsManager
            // 
            this.checkBoxIsManager.AutoSize = true;
            this.checkBoxIsManager.Location = new System.Drawing.Point(796, 21);
            this.checkBoxIsManager.Name = "checkBoxIsManager";
            this.checkBoxIsManager.Size = new System.Drawing.Size(94, 21);
            this.checkBoxIsManager.TabIndex = 2;
            this.checkBoxIsManager.Text = "Manager?";
            this.checkBoxIsManager.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(896, 21);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.ItemHeight = 16;
            this.listBoxIssues.Location = new System.Drawing.Point(367, 82);
            this.listBoxIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(320, 404);
            this.listBoxIssues.TabIndex = 8;
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.ItemHeight = 16;
            this.listBoxSuggestions.Location = new System.Drawing.Point(722, 82);
            this.listBoxSuggestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(320, 404);
            this.listBoxSuggestions.TabIndex = 9;
            // 
            // labelImplementations
            // 
            this.labelImplementations.AutoSize = true;
            this.labelImplementations.Location = new System.Drawing.Point(67, 61);
            this.labelImplementations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImplementations.Name = "labelImplementations";
            this.labelImplementations.Size = new System.Drawing.Size(169, 17);
            this.labelImplementations.TabIndex = 10;
            this.labelImplementations.Text = "Previous Implementations";
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Location = new System.Drawing.Point(431, 61);
            this.labelIssues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(188, 17);
            this.labelIssues.TabIndex = 11;
            this.labelIssues.Text = "Current Departmental Issues";
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Location = new System.Drawing.Point(803, 61);
            this.labelSuggestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(175, 17);
            this.labelSuggestions.TabIndex = 12;
            this.labelSuggestions.Text = "Departmental Suggestions";
            // 
            // labelEmployeeFeedbackApp
            // 
            this.labelEmployeeFeedbackApp.AutoSize = true;
            this.labelEmployeeFeedbackApp.Location = new System.Drawing.Point(432, 19);
            this.labelEmployeeFeedbackApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeFeedbackApp.Name = "labelEmployeeFeedbackApp";
            this.labelEmployeeFeedbackApp.Size = new System.Drawing.Size(169, 17);
            this.labelEmployeeFeedbackApp.TabIndex = 13;
            this.labelEmployeeFeedbackApp.Text = "Employee Feedback App ";
            this.labelEmployeeFeedbackApp.Click += new System.EventHandler(this.label4_Click);
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 569);
            this.Controls.Add(this.labelEmployeeFeedbackApp);
            this.Controls.Add(this.labelSuggestions);
            this.Controls.Add(this.labelIssues);
            this.Controls.Add(this.labelImplementations);
            this.Controls.Add(this.listBoxSuggestions);
            this.Controls.Add(this.listBoxIssues);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.checkBoxIsManager);
            this.Controls.Add(this.buttonNewPost);
            this.Controls.Add(this.listBoxImplementations);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.Load += new System.EventHandler(this.PostBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImplementations;
        private System.Windows.Forms.Button buttonNewPost;
        private System.Windows.Forms.CheckBox checkBoxIsManager;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.ListBox listBoxSuggestions;
        private System.Windows.Forms.Label labelImplementations;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Label labelEmployeeFeedbackApp;
    }
}