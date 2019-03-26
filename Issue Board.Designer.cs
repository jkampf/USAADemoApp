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
            this.textboxIssue = new System.Windows.Forms.TextBox();
            this.pictureboxUpvote = new System.Windows.Forms.PictureBox();
            this.pictureboxDownvote = new System.Windows.Forms.PictureBox();
            this.labelVoteCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolstripmenuitemIssue1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuitemIssue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripmenuitemIssue3 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelssue = new System.Windows.Forms.Label();
            this.listComment = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUpvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxDownvote)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(330, 216);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(1);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(79, 25);
            this.buttonComment.TabIndex = 0;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            // 
            // textboxIssue
            // 
            this.textboxIssue.Location = new System.Drawing.Point(113, 120);
            this.textboxIssue.Margin = new System.Windows.Forms.Padding(1);
            this.textboxIssue.Multiline = true;
            this.textboxIssue.Name = "textboxIssue";
            this.textboxIssue.ReadOnly = true;
            this.textboxIssue.Size = new System.Drawing.Size(487, 86);
            this.textboxIssue.TabIndex = 1;
            this.textboxIssue.Text = resources.GetString("textboxIssue.Text");
            // 
            // pictureboxUpvote
            // 
            this.pictureboxUpvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxUpvote.BackgroundImage")));
            this.pictureboxUpvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxUpvote.Location = new System.Drawing.Point(73, 128);
            this.pictureboxUpvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureboxUpvote.Name = "pictureboxUpvote";
            this.pictureboxUpvote.Size = new System.Drawing.Size(27, 44);
            this.pictureboxUpvote.TabIndex = 3;
            this.pictureboxUpvote.TabStop = false;
            this.pictureboxUpvote.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureboxDownvote
            // 
            this.pictureboxDownvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxDownvote.BackgroundImage")));
            this.pictureboxDownvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxDownvote.Location = new System.Drawing.Point(22, 128);
            this.pictureboxDownvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureboxDownvote.Name = "pictureboxDownvote";
            this.pictureboxDownvote.Size = new System.Drawing.Size(27, 44);
            this.pictureboxDownvote.TabIndex = 4;
            this.pictureboxDownvote.TabStop = false;
            this.pictureboxDownvote.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelVoteCount
            // 
            this.labelVoteCount.AutoSize = true;
            this.labelVoteCount.Location = new System.Drawing.Point(49, 145);
            this.labelVoteCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVoteCount.Name = "labelVoteCount";
            this.labelVoteCount.Size = new System.Drawing.Size(24, 17);
            this.labelVoteCount.TabIndex = 5;
            this.labelVoteCount.Text = "23";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(19, 19);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 17);
            this.welcomeLabel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuitemIssue1,
            this.toolstripmenuitemIssue2,
            this.toolstripmenuitemIssue3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(810, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolstripmenuitemIssue1
            // 
            this.toolstripmenuitemIssue1.Name = "toolstripmenuitemIssue1";
            this.toolstripmenuitemIssue1.Size = new System.Drawing.Size(65, 24);
            this.toolstripmenuitemIssue1.Text = "Issue 1";
            // 
            // toolstripmenuitemIssue2
            // 
            this.toolstripmenuitemIssue2.Name = "toolstripmenuitemIssue2";
            this.toolstripmenuitemIssue2.Size = new System.Drawing.Size(65, 24);
            this.toolstripmenuitemIssue2.Text = "Issue 2";
            this.toolstripmenuitemIssue2.Click += new System.EventHandler(this.issue2ToolStripMenuItem_Click);
            // 
            // toolstripmenuitemIssue3
            // 
            this.toolstripmenuitemIssue3.Name = "toolstripmenuitemIssue3";
            this.toolstripmenuitemIssue3.Size = new System.Drawing.Size(65, 24);
            this.toolstripmenuitemIssue3.Text = "Issue 3";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(22, 39);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(66, 17);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "RedDog";
            // 
            // labelssue
            // 
            this.labelssue.AutoSize = true;
            this.labelssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelssue.ForeColor = System.Drawing.Color.Black;
            this.labelssue.Location = new System.Drawing.Point(18, 63);
            this.labelssue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelssue.Name = "labelssue";
            this.labelssue.Size = new System.Drawing.Size(410, 36);
            this.labelssue.TabIndex = 9;
            this.labelssue.Text = "No time for skills development";
            this.labelssue.Click += new System.EventHandler(this.label2_Click);
            // 
            // listComment
            // 
            this.listComment.FormattingEnabled = true;
            this.listComment.ItemHeight = 16;
            this.listComment.Location = new System.Drawing.Point(113, 248);
            this.listComment.Margin = new System.Windows.Forms.Padding(1);
            this.listComment.Name = "listComment";
            this.listComment.Size = new System.Drawing.Size(487, 68);
            this.listComment.TabIndex = 10;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(73, 337);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(1);
            this.webBrowser.MinimumSize = new System.Drawing.Size(8, 9);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(676, 56);
            this.webBrowser.TabIndex = 11;
            this.webBrowser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // formIssueBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.listComment);
            this.Controls.Add(this.labelssue);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelVoteCount);
            this.Controls.Add(this.pictureboxDownvote);
            this.Controls.Add(this.pictureboxUpvote);
            this.Controls.Add(this.textboxIssue);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formIssueBoard";
            this.Text = "Issue Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxUpvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxDownvote)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textboxIssue;
        private System.Windows.Forms.PictureBox pictureboxUpvote;
        private System.Windows.Forms.PictureBox pictureboxDownvote;
        private System.Windows.Forms.Label labelVoteCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuitemIssue1;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuitemIssue2;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuitemIssue3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelssue;
        private System.Windows.Forms.ListBox listComment;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

