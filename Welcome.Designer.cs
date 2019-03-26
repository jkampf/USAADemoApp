namespace USAADemoApp
{
    partial class welcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.managerCheckBox = new System.Windows.Forms.CheckBox();
            this.postButton = new System.Windows.Forms.Button();
            this.viewIssueButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.employeeFeedbackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(5, 6);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(46, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "label1";
            // 
            // managerCheckBox
            // 
            this.managerCheckBox.AutoSize = true;
            this.managerCheckBox.Location = new System.Drawing.Point(345, 6);
            this.managerCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.managerCheckBox.Name = "managerCheckBox";
            this.managerCheckBox.Size = new System.Drawing.Size(94, 21);
            this.managerCheckBox.TabIndex = 2;
            this.managerCheckBox.Text = "Manager?";
            this.managerCheckBox.UseVisualStyleBackColor = true;
            this.managerCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(127, 114);
            this.postButton.Margin = new System.Windows.Forms.Padding(1);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(196, 29);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Create Issue ";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // viewIssueButton
            // 
            this.viewIssueButton.Location = new System.Drawing.Point(127, 166);
            this.viewIssueButton.Margin = new System.Windows.Forms.Padding(1);
            this.viewIssueButton.Name = "viewIssueButton";
            this.viewIssueButton.Size = new System.Drawing.Size(196, 26);
            this.viewIssueButton.TabIndex = 4;
            this.viewIssueButton.Text = "View Issue Board";
            this.viewIssueButton.UseVisualStyleBackColor = true;
            this.viewIssueButton.Click += new System.EventHandler(this.viewTopIssuesButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Enabled = false;
            this.generateReportButton.Location = new System.Drawing.Point(127, 213);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(1);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(196, 25);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Monthly Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // employeeFeedbackLabel
            // 
            this.employeeFeedbackLabel.AutoSize = true;
            this.employeeFeedbackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeFeedbackLabel.Location = new System.Drawing.Point(5, 48);
            this.employeeFeedbackLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.employeeFeedbackLabel.Name = "employeeFeedbackLabel";
            this.employeeFeedbackLabel.Size = new System.Drawing.Size(437, 42);
            this.employeeFeedbackLabel.TabIndex = 6;
            this.employeeFeedbackLabel.Text = "Employee Feedback App";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 266);
            this.Controls.Add(this.employeeFeedbackLabel);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.viewIssueButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.managerCheckBox);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "welcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.CheckBox managerCheckBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button viewIssueButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label employeeFeedbackLabel;
    }
}