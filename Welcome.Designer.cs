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
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.postButton = new System.Windows.Forms.Button();
            this.viewTopIssuesButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.labelEmployeeFeedback = new System.Windows.Forms.Label();
            this.textBoxImplementations = new System.Windows.Forms.TextBox();
            this.textBoxIssues = new System.Windows.Forms.TextBox();
            this.textBoxSuggestions = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelImplementations = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelSuggestions = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelIssues = new System.Windows.Forms.Label();
            this.buttonPostLeft = new System.Windows.Forms.Button();
            this.buttonPostCenter = new System.Windows.Forms.Button();
            this.buttonPostRight = new System.Windows.Forms.Button();
            this.listBoxImplementations = new System.Windows.Forms.ListBox();
            this.listBoxIssues = new System.Windows.Forms.ListBox();
            this.listBoxSuggestions = new System.Windows.Forms.ListBox();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(13, 26);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(104, 17);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome, User";
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(705, 21);
            this.checkBoxManager.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(94, 21);
            this.checkBoxManager.TabIndex = 2;
            this.checkBoxManager.Text = "Manager?";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            this.checkBoxManager.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(591, 754);
            this.postButton.Margin = new System.Windows.Forms.Padding(1);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(196, 30);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Create Issue ";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // viewTopIssuesButton
            // 
            this.viewTopIssuesButton.Location = new System.Drawing.Point(591, 786);
            this.viewTopIssuesButton.Margin = new System.Windows.Forms.Padding(1);
            this.viewTopIssuesButton.Name = "viewTopIssuesButton";
            this.viewTopIssuesButton.Size = new System.Drawing.Size(196, 26);
            this.viewTopIssuesButton.TabIndex = 4;
            this.viewTopIssuesButton.Text = "View Issue Board";
            this.viewTopIssuesButton.UseVisualStyleBackColor = true;
            this.viewTopIssuesButton.Click += new System.EventHandler(this.viewTopIssuesButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Enabled = false;
            this.generateReportButton.Location = new System.Drawing.Point(591, 761);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(1);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(196, 25);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Monthly Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeFeedback
            // 
            this.labelEmployeeFeedback.AutoSize = true;
            this.labelEmployeeFeedback.Font = new System.Drawing.Font("Ebrima", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedback.Location = new System.Drawing.Point(215, 0);
            this.labelEmployeeFeedback.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmployeeFeedback.Name = "labelEmployeeFeedback";
            this.labelEmployeeFeedback.Size = new System.Drawing.Size(424, 50);
            this.labelEmployeeFeedback.TabIndex = 6;
            this.labelEmployeeFeedback.Text = "Employee Feedback App";
            // 
            // textBoxImplementations
            // 
            this.textBoxImplementations.Location = new System.Drawing.Point(8, 571);
            this.textBoxImplementations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxImplementations.Multiline = true;
            this.textBoxImplementations.Name = "textBoxImplementations";
            this.textBoxImplementations.Size = new System.Drawing.Size(280, 104);
            this.textBoxImplementations.TabIndex = 13;
            // 
            // textBoxIssues
            // 
            this.textBoxIssues.Location = new System.Drawing.Point(287, 571);
            this.textBoxIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIssues.Multiline = true;
            this.textBoxIssues.Name = "textBoxIssues";
            this.textBoxIssues.Size = new System.Drawing.Size(331, 104);
            this.textBoxIssues.TabIndex = 14;
            // 
            // textBoxSuggestions
            // 
            this.textBoxSuggestions.Location = new System.Drawing.Point(615, 571);
            this.textBoxSuggestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSuggestions.Multiline = true;
            this.textBoxSuggestions.Name = "textBoxSuggestions";
            this.textBoxSuggestions.Size = new System.Drawing.Size(331, 104);
            this.textBoxSuggestions.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.labelImplementations);
            this.panel10.Location = new System.Drawing.Point(5, 74);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(281, 116);
            this.panel10.TabIndex = 16;
            // 
            // labelImplementations
            // 
            this.labelImplementations.AutoSize = true;
            this.labelImplementations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImplementations.Location = new System.Drawing.Point(12, 12);
            this.labelImplementations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImplementations.Name = "labelImplementations";
            this.labelImplementations.Size = new System.Drawing.Size(251, 50);
            this.labelImplementations.TabIndex = 0;
            this.labelImplementations.Text = "What new implementations \r\nare working well ?";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.labelSuggestions);
            this.panel12.Location = new System.Drawing.Point(615, 74);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(332, 116);
            this.panel12.TabIndex = 18;
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuggestions.Location = new System.Drawing.Point(4, 12);
            this.labelSuggestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(284, 100);
            this.labelSuggestions.TabIndex = 2;
            this.labelSuggestions.Text = "What do you think can be \r\nimplemented in our department \r\nto increase effeciency" +
    " and \r\nemployee satisfaction?";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.labelIssues);
            this.panel11.Location = new System.Drawing.Point(295, 74);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(316, 96);
            this.panel11.TabIndex = 28;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(4, 12);
            this.labelIssues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(258, 50);
            this.labelIssues.TabIndex = 2;
            this.labelIssues.Text = "What issues/concerns are \r\nholding our department back";
            // 
            // buttonPostLeft
            // 
            this.buttonPostLeft.Location = new System.Drawing.Point(83, 684);
            this.buttonPostLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostLeft.Name = "buttonPostLeft";
            this.buttonPostLeft.Size = new System.Drawing.Size(100, 28);
            this.buttonPostLeft.TabIndex = 29;
            this.buttonPostLeft.Text = "Post";
            this.buttonPostLeft.UseVisualStyleBackColor = true;
            this.buttonPostLeft.Click += new System.EventHandler(this.buttonPostLeft_Click);
            // 
            // buttonPostCenter
            // 
            this.buttonPostCenter.Location = new System.Drawing.Point(392, 684);
            this.buttonPostCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostCenter.Name = "buttonPostCenter";
            this.buttonPostCenter.Size = new System.Drawing.Size(100, 28);
            this.buttonPostCenter.TabIndex = 30;
            this.buttonPostCenter.Text = "Post";
            this.buttonPostCenter.UseVisualStyleBackColor = true;
            this.buttonPostCenter.Click += new System.EventHandler(this.buttonPostCenter_Click);
            // 
            // buttonPostRight
            // 
            this.buttonPostRight.Location = new System.Drawing.Point(726, 684);
            this.buttonPostRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPostRight.Name = "buttonPostRight";
            this.buttonPostRight.Size = new System.Drawing.Size(100, 28);
            this.buttonPostRight.TabIndex = 31;
            this.buttonPostRight.Text = "Post";
            this.buttonPostRight.UseVisualStyleBackColor = true;
            this.buttonPostRight.Click += new System.EventHandler(this.buttonPostRight_Click);
            // 
            // listBoxImplementations
            // 
            this.listBoxImplementations.FormattingEnabled = true;
            this.listBoxImplementations.ItemHeight = 16;
            this.listBoxImplementations.Location = new System.Drawing.Point(5, 197);
            this.listBoxImplementations.Name = "listBoxImplementations";
            this.listBoxImplementations.Size = new System.Drawing.Size(283, 356);
            this.listBoxImplementations.TabIndex = 32;
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.ItemHeight = 16;
            this.listBoxIssues.Location = new System.Drawing.Point(304, 197);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(283, 356);
            this.listBoxIssues.TabIndex = 33;
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.ItemHeight = 16;
            this.listBoxSuggestions.Location = new System.Drawing.Point(620, 197);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(283, 356);
            this.listBoxSuggestions.TabIndex = 34;
            // 
            // formWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 715);
            this.Controls.Add(this.listBoxSuggestions);
            this.Controls.Add(this.listBoxIssues);
            this.Controls.Add(this.listBoxImplementations);
            this.Controls.Add(this.buttonPostRight);
            this.Controls.Add(this.buttonPostCenter);
            this.Controls.Add(this.buttonPostLeft);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.textBoxSuggestions);
            this.Controls.Add(this.textBoxIssues);
            this.Controls.Add(this.textBoxImplementations);
            this.Controls.Add(this.labelEmployeeFeedback);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.viewTopIssuesButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.checkBoxManager);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formWelcome";
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

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button viewTopIssuesButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label labelEmployeeFeedback;
        private System.Windows.Forms.TextBox textBoxImplementations;
        private System.Windows.Forms.TextBox textBoxIssues;
        private System.Windows.Forms.TextBox textBoxSuggestions;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label labelImplementations;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.Button buttonPostLeft;
        private System.Windows.Forms.Button buttonPostCenter;
        private System.Windows.Forms.Button buttonPostRight;
        private System.Windows.Forms.ListBox listBoxImplementations;
        private System.Windows.Forms.ListBox listBoxIssues;
        private System.Windows.Forms.ListBox listBoxSuggestions;
    }
}