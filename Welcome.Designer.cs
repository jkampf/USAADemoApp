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
            this.viewTopIssuesButton = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.labelEmployeeFeedback = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelImplementations = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelSuggestions = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelIssues = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxImplementations = new System.Windows.Forms.ListBox();
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.listBoxSuggestions = new System.Windows.Forms.ListBox();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(529, 17);
            this.checkBoxManager.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(74, 17);
            this.checkBoxManager.TabIndex = 2;
            this.checkBoxManager.Text = "Manager?";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            this.checkBoxManager.CheckedChanged += new System.EventHandler(this.CheckBoxManager_CheckedChanged);
            // 
            // viewTopIssuesButton
            // 
            this.viewTopIssuesButton.Location = new System.Drawing.Point(443, 639);
            this.viewTopIssuesButton.Margin = new System.Windows.Forms.Padding(1);
            this.viewTopIssuesButton.Name = "viewTopIssuesButton";
            this.viewTopIssuesButton.Size = new System.Drawing.Size(147, 21);
            this.viewTopIssuesButton.TabIndex = 4;
            this.viewTopIssuesButton.Text = "View Issue Board";
            this.viewTopIssuesButton.UseVisualStyleBackColor = true;
            this.viewTopIssuesButton.Click += new System.EventHandler(this.ViewTopIssuesButton_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(496, 529);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(1);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(147, 22);
            this.buttonGenerateReport.TabIndex = 5;
            this.buttonGenerateReport.Text = "Generate Monthly Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // labelEmployeeFeedback
            // 
            this.labelEmployeeFeedback.AutoSize = true;
            this.labelEmployeeFeedback.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedback.Location = new System.Drawing.Point(161, 0);
            this.labelEmployeeFeedback.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedback.Name = "labelEmployeeFeedback";
            this.labelEmployeeFeedback.Size = new System.Drawing.Size(331, 40);
            this.labelEmployeeFeedback.TabIndex = 6;
            this.labelEmployeeFeedback.Text = "Employee Feedback App";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelImplementations);
            this.panel10.Location = new System.Drawing.Point(4, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(211, 94);
            this.panel10.TabIndex = 16;
            // 
            // labelImplementations
            // 
            this.labelImplementations.AutoSize = true;
            this.labelImplementations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImplementations.Location = new System.Drawing.Point(9, 10);
            this.labelImplementations.Name = "labelImplementations";
            this.labelImplementations.Size = new System.Drawing.Size(204, 40);
            this.labelImplementations.TabIndex = 0;
            this.labelImplementations.Text = "What new implementations \r\nare working well ?";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.labelSuggestions);
            this.panel12.Location = new System.Drawing.Point(461, 60);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(249, 94);
            this.panel12.TabIndex = 18;
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuggestions.Location = new System.Drawing.Point(3, 10);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(233, 80);
            this.labelSuggestions.TabIndex = 2;
            this.labelSuggestions.Text = "What do you think can be \r\nimplemented in our department \r\nto increase effeciency" +
    " and \r\nemployee satisfaction?";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.labelIssues);
            this.panel11.Location = new System.Drawing.Point(221, 60);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(237, 78);
            this.panel11.TabIndex = 28;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(3, 10);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(220, 40);
            this.labelIssues.TabIndex = 2;
            this.labelIssues.Text = "What issues/concerns are \r\nholding our department back?";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(324, 528);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 30;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // listBoxImplementations
            // 
            this.listBoxImplementations.FormattingEnabled = true;
            this.listBoxImplementations.Location = new System.Drawing.Point(4, 160);
            this.listBoxImplementations.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxImplementations.Name = "listBoxImplementations";
            this.listBoxImplementations.Size = new System.Drawing.Size(213, 290);
            this.listBoxImplementations.TabIndex = 32;
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.Location = new System.Drawing.Point(228, 160);
            this.listBoxIssues.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(213, 290);
            this.listBoxIssues.TabIndex = 33;
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.Location = new System.Drawing.Point(465, 160);
            this.listBoxSuggestions.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(213, 290);
            this.listBoxSuggestions.TabIndex = 34;
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 581);
            this.Controls.Add(this.listBoxSuggestions);
            this.Controls.Add(this.listBoxIssues);
            this.Controls.Add(this.listBoxImplementations);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.labelEmployeeFeedback);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.viewTopIssuesButton);
            this.Controls.Add(this.checkBoxManager);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button viewTopIssuesButton;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelEmployeeFeedback;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelImplementations;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxImplementations;
        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.ListBox listBoxSuggestions;
    }
}