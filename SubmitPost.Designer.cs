namespace USAADemoApp
{
    partial class SubmitPost
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxFeedbackType = new System.Windows.Forms.GroupBox();
            this.radioButtonSuggestions = new System.Windows.Forms.RadioButton();
            this.radioButtonIssues = new System.Windows.Forms.RadioButton();
            this.radioButtonImplementation = new System.Windows.Forms.RadioButton();
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.textBoxPostTitle = new System.Windows.Forms.TextBox();
            this.labelPostBody = new System.Windows.Forms.Label();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.groupBoxFeedbackType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(209, 340);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // groupBoxFeedbackType
            // 
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonSuggestions);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonIssues);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonImplementation);
            this.groupBoxFeedbackType.Location = new System.Drawing.Point(49, 11);
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
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Location = new System.Drawing.Point(10, 127);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(30, 13);
            this.labelPostTitle.TabIndex = 11;
            this.labelPostTitle.Text = "Title:";
            // 
            // textBoxPostTitle
            // 
            this.textBoxPostTitle.Location = new System.Drawing.Point(49, 127);
            this.textBoxPostTitle.Name = "textBoxPostTitle";
            this.textBoxPostTitle.Size = new System.Drawing.Size(425, 20);
            this.textBoxPostTitle.TabIndex = 5;
            // 
            // labelPostBody
            // 
            this.labelPostBody.AutoSize = true;
            this.labelPostBody.Location = new System.Drawing.Point(10, 169);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(34, 13);
            this.labelPostBody.TabIndex = 12;
            this.labelPostBody.Text = "Body:";
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(49, 169);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.Size = new System.Drawing.Size(425, 156);
            this.textBoxPostBody.TabIndex = 6;
            // 
            // SubmitPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 382);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.labelPostBody);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.textBoxPostTitle);
            this.Controls.Add(this.groupBoxFeedbackType);
            this.Controls.Add(this.buttonSubmit);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SubmitPost";
            this.Text = "Submit New Post";
            this.groupBoxFeedbackType.ResumeLayout(false);
            this.groupBoxFeedbackType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxFeedbackType;
        private System.Windows.Forms.RadioButton radioButtonSuggestions;
        private System.Windows.Forms.RadioButton radioButtonIssues;
        private System.Windows.Forms.RadioButton radioButtonImplementation;
        private System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.TextBox textBoxPostTitle;
        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.TextBox textBoxPostBody;
    }
}