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
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxImplementations
            // 
            this.listBoxImplementations.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxImplementations.FormattingEnabled = true;
            this.listBoxImplementations.Location = new System.Drawing.Point(8, 67);
            this.listBoxImplementations.Name = "listBoxImplementations";
            this.listBoxImplementations.Size = new System.Drawing.Size(241, 329);
            this.listBoxImplementations.TabIndex = 5;
            this.listBoxImplementations.DoubleClick += new System.EventHandler(this.ListBoxImplementations_DoubleClick);
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPost.Location = new System.Drawing.Point(351, 402);
            this.buttonNewPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(94, 37);
            this.buttonNewPost.TabIndex = 3;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = false;
            this.buttonNewPost.Click += new System.EventHandler(this.ButtonNewPost_Click);
            // 
            // checkBoxIsManager
            // 
            this.checkBoxIsManager.AutoSize = true;
            this.checkBoxIsManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsManager.Location = new System.Drawing.Point(580, 19);
            this.checkBoxIsManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxIsManager.Name = "checkBoxIsManager";
            this.checkBoxIsManager.Size = new System.Drawing.Size(82, 17);
            this.checkBoxIsManager.TabIndex = 2;
            this.checkBoxIsManager.Text = "Manager?";
            this.checkBoxIsManager.UseVisualStyleBackColor = true;
            this.checkBoxIsManager.CheckedChanged += new System.EventHandler(this.CheckBoxIsManager_CheckedChanged);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.Color.Green;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(666, 11);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(117, 37);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = false;
            this.buttonGenerateReport.Visible = false;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // listBoxIssues
            // 
            this.listBoxIssues.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxIssues.FormattingEnabled = true;
            this.listBoxIssues.Location = new System.Drawing.Point(275, 67);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(241, 329);
            this.listBoxIssues.TabIndex = 8;
            this.listBoxIssues.DoubleClick += new System.EventHandler(this.ListBoxIssues_DoubleClick);
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.Location = new System.Drawing.Point(550, 67);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(241, 329);
            this.listBoxSuggestions.TabIndex = 9;
            this.listBoxSuggestions.DoubleClick += new System.EventHandler(this.ListBoxSuggestions_DoubleClick);
            // 
            // labelImplementations
            // 
            this.labelImplementations.AutoSize = true;
            this.labelImplementations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImplementations.Location = new System.Drawing.Point(50, 50);
            this.labelImplementations.Name = "labelImplementations";
            this.labelImplementations.Size = new System.Drawing.Size(151, 13);
            this.labelImplementations.TabIndex = 10;
            this.labelImplementations.Text = "Previous Implementations";
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(323, 50);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(167, 13);
            this.labelIssues.TabIndex = 11;
            this.labelIssues.Text = "Current Departmental Issues";
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuggestions.Location = new System.Drawing.Point(602, 50);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(155, 13);
            this.labelSuggestions.TabIndex = 12;
            this.labelSuggestions.Text = "Departmental Suggestions";
            // 
            // labelEmployeeFeedbackApp
            // 
            this.labelEmployeeFeedbackApp.AutoSize = true;
            this.labelEmployeeFeedbackApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedbackApp.Location = new System.Drawing.Point(270, 11);
            this.labelEmployeeFeedbackApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeFeedbackApp.Name = "labelEmployeeFeedbackApp";
            this.labelEmployeeFeedbackApp.Size = new System.Drawing.Size(259, 25);
            this.labelEmployeeFeedbackApp.TabIndex = 13;
            this.labelEmployeeFeedbackApp.Text = "Employee Feedback App ";
            // 
            // pictureBoxDownvote
            // 
            this.pictureBoxDownvote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxDownvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDownvote.Image = global::USAADemoApp.Properties.Resources.downArrowBase;
            this.pictureBoxDownvote.Location = new System.Drawing.Point(58, 7);
            this.pictureBoxDownvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxDownvote.Name = "pictureBoxDownvote";
            this.pictureBoxDownvote.Size = new System.Drawing.Size(23, 41);
            this.pictureBoxDownvote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDownvote.TabIndex = 14;
            this.pictureBoxDownvote.TabStop = false;
            this.pictureBoxDownvote.Click += new System.EventHandler(this.pictureBoxDownvote_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(41, 21);
            this.labelCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(15, 15);
            this.labelCount.TabIndex = 15;
            this.labelCount.Text = "0";
            // 
            // pictureBoxUpvote
            // 
            this.pictureBoxUpvote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxUpvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUpvote.Image = global::USAADemoApp.Properties.Resources.upArrowBasae;
            this.pictureBoxUpvote.InitialImage = global::USAADemoApp.Properties.Resources.upArrowBasae;
            this.pictureBoxUpvote.Location = new System.Drawing.Point(10, 7);
            this.pictureBoxUpvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxUpvote.Name = "pictureBoxUpvote";
            this.pictureBoxUpvote.Size = new System.Drawing.Size(29, 41);
            this.pictureBoxUpvote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpvote.TabIndex = 16;
            this.pictureBoxUpvote.TabStop = false;
            this.pictureBoxUpvote.Click += new System.EventHandler(this.pictureBoxUpvote_Click_1);
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxDownvote);
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
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.Load += new System.EventHandler(this.PostBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
    }
}