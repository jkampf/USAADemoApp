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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostBoard));
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
            this.labelCount = new System.Windows.Forms.Label();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.voteStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxImplementations
            // 
            this.listBoxImplementations.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxImplementations.FormattingEnabled = true;
            this.listBoxImplementations.ItemHeight = 16;
            this.listBoxImplementations.Location = new System.Drawing.Point(11, 82);
            this.listBoxImplementations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxImplementations.Name = "listBoxImplementations";
            this.listBoxImplementations.Size = new System.Drawing.Size(320, 404);
            this.listBoxImplementations.TabIndex = 5;
            this.listBoxImplementations.SelectedValueChanged += new System.EventHandler(this.ListBoxImplementations_SelectedValueChanged);
            this.listBoxImplementations.DoubleClick += new System.EventHandler(this.ListBoxImplementations_DoubleClick);
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPost.Location = new System.Drawing.Point(468, 495);
            this.buttonNewPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(125, 46);
            this.buttonNewPost.TabIndex = 3;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = false;
            this.buttonNewPost.Click += new System.EventHandler(this.ButtonNewPost_Click);
            // 
            // checkBoxIsManager
            // 
            this.checkBoxIsManager.AutoSize = true;
            this.checkBoxIsManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsManager.Location = new System.Drawing.Point(773, 23);
            this.checkBoxIsManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIsManager.Name = "checkBoxIsManager";
            this.checkBoxIsManager.Size = new System.Drawing.Size(102, 21);
            this.checkBoxIsManager.TabIndex = 2;
            this.checkBoxIsManager.Text = "Manager?";
            this.checkBoxIsManager.UseVisualStyleBackColor = true;
            this.checkBoxIsManager.CheckedChanged += new System.EventHandler(this.CheckBoxIsManager_CheckedChanged);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.BackColor = System.Drawing.Color.Green;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(888, 14);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(156, 46);
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
            this.listBoxIssues.ItemHeight = 16;
            this.listBoxIssues.Location = new System.Drawing.Point(367, 82);
            this.listBoxIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxIssues.Name = "listBoxIssues";
            this.listBoxIssues.Size = new System.Drawing.Size(320, 404);
            this.listBoxIssues.TabIndex = 8;
            this.listBoxIssues.SelectedValueChanged += new System.EventHandler(this.ListBoxIssues_SelectedValueChanged);
            this.listBoxIssues.DoubleClick += new System.EventHandler(this.ListBoxIssues_DoubleClick);
            // 
            // listBoxSuggestions
            // 
            this.listBoxSuggestions.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxSuggestions.FormattingEnabled = true;
            this.listBoxSuggestions.ItemHeight = 16;
            this.listBoxSuggestions.Location = new System.Drawing.Point(733, 82);
            this.listBoxSuggestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSuggestions.Name = "listBoxSuggestions";
            this.listBoxSuggestions.Size = new System.Drawing.Size(320, 404);
            this.listBoxSuggestions.TabIndex = 9;
            this.listBoxSuggestions.SelectedValueChanged += new System.EventHandler(this.ListBoxSuggestions_SelectedValueChanged);
            this.listBoxSuggestions.DoubleClick += new System.EventHandler(this.ListBoxSuggestions_DoubleClick);
            // 
            // labelImplementations
            // 
            this.labelImplementations.AutoSize = true;
            this.labelImplementations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImplementations.Location = new System.Drawing.Point(67, 62);
            this.labelImplementations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImplementations.Name = "labelImplementations";
            this.labelImplementations.Size = new System.Drawing.Size(193, 17);
            this.labelImplementations.TabIndex = 10;
            this.labelImplementations.Text = "Previous Implementations";
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(431, 62);
            this.labelIssues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(215, 17);
            this.labelIssues.TabIndex = 11;
            this.labelIssues.Text = "Current Departmental Issues";
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuggestions.Location = new System.Drawing.Point(803, 62);
            this.labelSuggestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(199, 17);
            this.labelSuggestions.TabIndex = 12;
            this.labelSuggestions.Text = "Departmental Suggestions";
            // 
            // labelEmployeeFeedbackApp
            // 
            this.labelEmployeeFeedbackApp.AutoSize = true;
            this.labelEmployeeFeedbackApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeFeedbackApp.Location = new System.Drawing.Point(360, 14);
            this.labelEmployeeFeedbackApp.Name = "labelEmployeeFeedbackApp";
            this.labelEmployeeFeedbackApp.Size = new System.Drawing.Size(326, 29);
            this.labelEmployeeFeedbackApp.TabIndex = 13;
            this.labelEmployeeFeedbackApp.Text = "Employee Feedback App ";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCount.Enabled = false;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(55, 26);
            this.labelCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(17, 18);
            this.labelCount.TabIndex = 15;
            this.labelCount.Text = "0";
            // 
            // pictureBoxUpvote
            // 
            this.pictureBoxUpvote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxUpvote.Enabled = false;
            this.pictureBoxUpvote.Image = global::USAADemoApp.Properties.Resources.upArrowBase;
            this.pictureBoxUpvote.Location = new System.Drawing.Point(16, 14);
            this.pictureBoxUpvote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxUpvote.Name = "pictureBoxUpvote";
            this.pictureBoxUpvote.Size = new System.Drawing.Size(33, 46);
            this.pictureBoxUpvote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpvote.TabIndex = 16;
            this.pictureBoxUpvote.TabStop = false;
            this.pictureBoxUpvote.Click += new System.EventHandler(this.PictureBoxUpvote_Click);
            // 
            // pictureBoxDownvote
            // 
            this.pictureBoxDownvote.Enabled = false;
            this.pictureBoxDownvote.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownvote.Image")));
            this.pictureBoxDownvote.Location = new System.Drawing.Point(80, 12);
            this.pictureBoxDownvote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDownvote.Name = "pictureBoxDownvote";
            this.pictureBoxDownvote.Size = new System.Drawing.Size(33, 46);
            this.pictureBoxDownvote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDownvote.TabIndex = 17;
            this.pictureBoxDownvote.TabStop = false;
            this.pictureBoxDownvote.Click += new System.EventHandler(this.PictureBoxDownvote_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // voteStatusLabel
            // 
            this.voteStatusLabel.AutoSize = true;
            this.voteStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.voteStatusLabel.Location = new System.Drawing.Point(121, 20);
            this.voteStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voteStatusLabel.Name = "voteStatusLabel";
            this.voteStatusLabel.Size = new System.Drawing.Size(204, 20);
            this.voteStatusLabel.TabIndex = 18;
            this.voteStatusLabel.Text = "Your Vote Is Recorded!";
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 554);
            this.Controls.Add(this.voteStatusLabel);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.labelCount);
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
            this.MaximizeBox = false;
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.Load += new System.EventHandler(this.PostBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
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
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label voteStatusLabel;
    }
}