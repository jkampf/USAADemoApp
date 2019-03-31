namespace USAADemoApp
{
    partial class formIssueBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIssueBoard));
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.labelSkills = new System.Windows.Forms.Label();
            this.listComment = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(207, 235);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(1);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(81, 20);
            this.buttonComment.TabIndex = 0;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.ButtonComment_Click);
            // 
            // textBoxIssue
            // 
            this.textBoxIssue.Location = new System.Drawing.Point(85, 60);
            this.textBoxIssue.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxIssue.Multiline = true;
            this.textBoxIssue.Name = "textBoxIssue";
            this.textBoxIssue.ReadOnly = true;
            this.textBoxIssue.Size = new System.Drawing.Size(366, 71);
            this.textBoxIssue.TabIndex = 1;
            this.textBoxIssue.Text = resources.GetString("textBoxIssue.Text");
            // 
            // pictureBoxDownvote
            // 
            this.pictureBoxDownvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownvote.BackgroundImage")));
            this.pictureBoxDownvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDownvote.Location = new System.Drawing.Point(53, 60);
            this.pictureBoxDownvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxDownvote.Name = "pictureBoxDownvote";
            this.pictureBoxDownvote.Size = new System.Drawing.Size(20, 36);
            this.pictureBoxDownvote.TabIndex = 3;
            this.pictureBoxDownvote.TabStop = false;
            this.pictureBoxDownvote.Click += new System.EventHandler(this.PictureBoxDownvote_Click);
            // 
            // pictureBoxUpvote
            // 
            this.pictureBoxUpvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpvote.BackgroundImage")));
            this.pictureBoxUpvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUpvote.Location = new System.Drawing.Point(10, 60);
            this.pictureBoxUpvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxUpvote.Name = "pictureBoxUpvote";
            this.pictureBoxUpvote.Size = new System.Drawing.Size(20, 36);
            this.pictureBoxUpvote.TabIndex = 4;
            this.pictureBoxUpvote.TabStop = false;
            this.pictureBoxUpvote.Click += new System.EventHandler(this.PictureBoxUpvote_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(32, 63);
            this.labelCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(19, 13);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "23";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(14, 15);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.welcomeLabel.TabIndex = 6;
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkills.ForeColor = System.Drawing.Color.Black;
            this.labelSkills.Location = new System.Drawing.Point(80, 15);
            this.labelSkills.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(337, 29);
            this.labelSkills.TabIndex = 9;
            this.labelSkills.Text = "No time for skills development";
            // 
            // listComment
            // 
            this.listComment.FormattingEnabled = true;
            this.listComment.Location = new System.Drawing.Point(85, 159);
            this.listComment.Margin = new System.Windows.Forms.Padding(1);
            this.listComment.Name = "listComment";
            this.listComment.Size = new System.Drawing.Size(366, 56);
            this.listComment.TabIndex = 10;
            // 
            // formIssueBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.listComment);
            this.Controls.Add(this.labelSkills);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.textBoxIssue);
            this.Controls.Add(this.buttonComment);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formIssueBoard";
            this.Text = "Issue Board";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.ListBox listComment;
    }
}

