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
            this.buttonPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(414, 29);
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
            this.buttonGenerateReport.Location = new System.Drawing.Point(341, 469);
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
            this.labelEmployeeFeedback.Location = new System.Drawing.Point(68, 9);
            this.labelEmployeeFeedback.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedback.Name = "labelEmployeeFeedback";
            this.labelEmployeeFeedback.Size = new System.Drawing.Size(331, 40);
            this.labelEmployeeFeedback.TabIndex = 6;
            this.labelEmployeeFeedback.Text = "Employee Feedback App";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(200, 468);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 30;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelEmployeeFeedback);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.viewTopIssuesButton);
            this.Controls.Add(this.checkBoxManager);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button viewTopIssuesButton;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelEmployeeFeedback;
        private System.Windows.Forms.Button buttonPost;
    }
}