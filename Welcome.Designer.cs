namespace USAADemoApp
{
    partial class FormWelcome
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
            this.labelEmployeeFeedback = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBoxFeedbackType = new System.Windows.Forms.GroupBox();
            this.buttonSuggestions = new System.Windows.Forms.RadioButton();
            this.buttonIssues = new System.Windows.Forms.RadioButton();
            this.buttonImplementation = new System.Windows.Forms.RadioButton();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelBody = new System.Windows.Forms.Label();
            this.buttonViewPosts = new System.Windows.Forms.Button();
            this.groupBoxFeedbackType.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.buttonGenerateReport.Location = new System.Drawing.Point(341, 469);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(1);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(147, 22);
            this.buttonGenerateReport.TabIndex = 8;
            this.buttonGenerateReport.Text = "Generate Monthly Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // labelEmployeeFeedback
            // 
            this.labelEmployeeFeedback.AutoSize = true;
            this.labelEmployeeFeedback.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedback.Location = new System.Drawing.Point(81, 9);
            this.labelEmployeeFeedback.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedback.Name = "labelEmployeeFeedback";
            this.labelEmployeeFeedback.Size = new System.Drawing.Size(331, 40);
            this.labelEmployeeFeedback.TabIndex = 9;
            this.labelEmployeeFeedback.Text = "Employee Feedback App";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(231, 468);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // groupBoxFeedbackType
            // 
            this.groupBoxFeedbackType.Controls.Add(this.buttonSuggestions);
            this.groupBoxFeedbackType.Controls.Add(this.buttonIssues);
            this.groupBoxFeedbackType.Controls.Add(this.buttonImplementation);
            this.groupBoxFeedbackType.Location = new System.Drawing.Point(193, 70);
            this.groupBoxFeedbackType.Name = "groupBoxFeedbackType";
            this.groupBoxFeedbackType.Size = new System.Drawing.Size(124, 99);
            this.groupBoxFeedbackType.TabIndex = 10;
            this.groupBoxFeedbackType.TabStop = false;
            this.groupBoxFeedbackType.Text = "Feedback Type:";
            // 
            // buttonSuggestions
            // 
            this.buttonSuggestions.AutoSize = true;
            this.buttonSuggestions.Location = new System.Drawing.Point(6, 65);
            this.buttonSuggestions.Name = "buttonSuggestions";
            this.buttonSuggestions.Size = new System.Drawing.Size(83, 17);
            this.buttonSuggestions.TabIndex = 4;
            this.buttonSuggestions.TabStop = true;
            this.buttonSuggestions.Text = "Suggestions";
            this.buttonSuggestions.UseVisualStyleBackColor = true;
            // 
            // buttonIssues
            // 
            this.buttonIssues.AutoSize = true;
            this.buttonIssues.Location = new System.Drawing.Point(6, 42);
            this.buttonIssues.Name = "buttonIssues";
            this.buttonIssues.Size = new System.Drawing.Size(55, 17);
            this.buttonIssues.TabIndex = 3;
            this.buttonIssues.TabStop = true;
            this.buttonIssues.Text = "Issues";
            this.buttonIssues.UseVisualStyleBackColor = true;
            // 
            // buttonImplementation
            // 
            this.buttonImplementation.AutoSize = true;
            this.buttonImplementation.Location = new System.Drawing.Point(6, 19);
            this.buttonImplementation.Name = "buttonImplementation";
            this.buttonImplementation.Size = new System.Drawing.Size(96, 17);
            this.buttonImplementation.TabIndex = 2;
            this.buttonImplementation.TabStop = true;
            this.buttonImplementation.Text = "Implementation";
            this.buttonImplementation.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(51, 19);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(425, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(15, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Title:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxBody);
            this.panel1.Controls.Add(this.labelBody);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(29, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 229);
            this.panel1.TabIndex = 34;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(51, 56);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(425, 156);
            this.textBoxBody.TabIndex = 6;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(15, 56);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(34, 13);
            this.labelBody.TabIndex = 12;
            this.labelBody.Text = "Body:";
            // 
            // buttonViewPosts
            // 
            this.buttonViewPosts.Location = new System.Drawing.Point(113, 468);
            this.buttonViewPosts.Name = "buttonViewPosts";
            this.buttonViewPosts.Size = new System.Drawing.Size(75, 23);
            this.buttonViewPosts.TabIndex = 35;
            this.buttonViewPosts.Text = "View Posts";
            this.buttonViewPosts.UseVisualStyleBackColor = true;
            this.buttonViewPosts.Click += new System.EventHandler(this.ButtonViewPosts_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.buttonViewPosts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxFeedbackType);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelEmployeeFeedback);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.checkBoxManager);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.groupBoxFeedbackType.ResumeLayout(false);
            this.groupBoxFeedbackType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelEmployeeFeedback;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupBoxFeedbackType;
        private System.Windows.Forms.RadioButton buttonSuggestions;
        private System.Windows.Forms.RadioButton buttonIssues;
        private System.Windows.Forms.RadioButton buttonImplementation;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Button buttonViewPosts;
    }
}