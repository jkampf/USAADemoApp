namespace USAADemoApp
{
    partial class Welcome
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
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.labelEmployeeFeedbackApp = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBoxFeedbackType = new System.Windows.Forms.GroupBox();
            this.radioButtonSuggestions = new System.Windows.Forms.RadioButton();
            this.radioButtonIssues = new System.Windows.Forms.RadioButton();
            this.radioButtonImplementation = new System.Windows.Forms.RadioButton();
            this.buttonViewBoard = new System.Windows.Forms.Button();
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.textBoxPostTitle = new System.Windows.Forms.TextBox();
            this.labelPostBody = new System.Windows.Forms.Label();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.groupBoxFeedbackType.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(431, 29);
            this.checkBoxManager.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(74, 17);
            this.checkBoxManager.TabIndex = 1;
            this.checkBoxManager.Text = "Manager?";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            this.checkBoxManager.CheckedChanged += new System.EventHandler(this.CheckBoxManager_CheckedChanged);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(357, 430);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(1);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(120, 22);
            this.buttonGenerateReport.TabIndex = 8;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // labelEmployeeFeedbackApp
            // 
            this.labelEmployeeFeedbackApp.AutoSize = true;
            this.labelEmployeeFeedbackApp.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedbackApp.Location = new System.Drawing.Point(81, 9);
            this.labelEmployeeFeedbackApp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedbackApp.Name = "labelEmployeeFeedbackApp";
            this.labelEmployeeFeedbackApp.Size = new System.Drawing.Size(331, 40);
            this.labelEmployeeFeedbackApp.TabIndex = 9;
            this.labelEmployeeFeedbackApp.Text = "Employee Feedback App";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(220, 429);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // groupBoxFeedbackType
            // 
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonSuggestions);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonIssues);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonImplementation);
            this.groupBoxFeedbackType.Location = new System.Drawing.Point(193, 61);
            this.groupBoxFeedbackType.Name = "groupBoxFeedbackType";
            this.groupBoxFeedbackType.Size = new System.Drawing.Size(124, 99);
            this.groupBoxFeedbackType.TabIndex = 10;
            this.groupBoxFeedbackType.TabStop = false;
            this.groupBoxFeedbackType.Text = "Feedback Type:";
            // 
            // radioButtonSuggestions
            // 
            this.radioButtonSuggestions.AutoSize = true;
            this.radioButtonSuggestions.Location = new System.Drawing.Point(6, 65);
            this.radioButtonSuggestions.Name = "radioButtonSuggestions";
            this.radioButtonSuggestions.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSuggestions.TabIndex = 4;
            this.radioButtonSuggestions.TabStop = true;
            this.radioButtonSuggestions.Text = "Suggestions";
            this.radioButtonSuggestions.UseVisualStyleBackColor = true;
            // 
            // radioButtonIssues
            // 
            this.radioButtonIssues.AutoSize = true;
            this.radioButtonIssues.Location = new System.Drawing.Point(6, 42);
            this.radioButtonIssues.Name = "radioButtonIssues";
            this.radioButtonIssues.Size = new System.Drawing.Size(55, 17);
            this.radioButtonIssues.TabIndex = 3;
            this.radioButtonIssues.TabStop = true;
            this.radioButtonIssues.Text = "Issues";
            this.radioButtonIssues.UseVisualStyleBackColor = true;
            // 
            // radioButtonImplementation
            // 
            this.radioButtonImplementation.AutoSize = true;
            this.radioButtonImplementation.Location = new System.Drawing.Point(6, 19);
            this.radioButtonImplementation.Name = "radioButtonImplementation";
            this.radioButtonImplementation.Size = new System.Drawing.Size(96, 17);
            this.radioButtonImplementation.TabIndex = 2;
            this.radioButtonImplementation.TabStop = true;
            this.radioButtonImplementation.Text = "Implementation";
            this.radioButtonImplementation.UseVisualStyleBackColor = true;
            // 
            // buttonViewBoard
            // 
            this.buttonViewBoard.Location = new System.Drawing.Point(88, 429);
            this.buttonViewBoard.Name = "buttonViewBoard";
            this.buttonViewBoard.Size = new System.Drawing.Size(75, 23);
            this.buttonViewBoard.TabIndex = 35;
            this.buttonViewBoard.Text = "View Board";
            this.buttonViewBoard.UseVisualStyleBackColor = true;
            this.buttonViewBoard.Click += new System.EventHandler(this.ButtonViewBoard_Click);
            // 
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Location = new System.Drawing.Point(12, 175);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(30, 13);
            this.labelPostTitle.TabIndex = 11;
            this.labelPostTitle.Text = "Title:";
            // 
            // textBoxPostTitle
            // 
            this.textBoxPostTitle.Location = new System.Drawing.Point(52, 175);
            this.textBoxPostTitle.Name = "textBoxPostTitle";
            this.textBoxPostTitle.Size = new System.Drawing.Size(425, 20);
            this.textBoxPostTitle.TabIndex = 5;
            // 
            // labelPostBody
            // 
            this.labelPostBody.AutoSize = true;
            this.labelPostBody.Location = new System.Drawing.Point(12, 229);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(34, 13);
            this.labelPostBody.TabIndex = 12;
            this.labelPostBody.Text = "Body:";
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(52, 226);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.Size = new System.Drawing.Size(425, 156);
            this.textBoxPostBody.TabIndex = 6;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 501);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.buttonViewBoard);
            this.Controls.Add(this.labelPostBody);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.textBoxPostTitle);
            this.Controls.Add(this.groupBoxFeedbackType);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelEmployeeFeedbackApp);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.checkBoxManager);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.groupBoxFeedbackType.ResumeLayout(false);
            this.groupBoxFeedbackType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelEmployeeFeedbackApp;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupBoxFeedbackType;
        private System.Windows.Forms.RadioButton radioButtonSuggestions;
        private System.Windows.Forms.RadioButton radioButtonIssues;
        private System.Windows.Forms.RadioButton radioButtonImplementation;
        private System.Windows.Forms.Button buttonViewBoard;
        private System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.TextBox textBoxPostTitle;
        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.TextBox textBoxPostBody;
    }
}