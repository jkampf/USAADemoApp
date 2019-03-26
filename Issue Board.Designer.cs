namespace USAADemoApp
{
    partial class issueBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueBoardForm));
            this.buttonComment = new System.Windows.Forms.Button();
            this.issueTextBox = new System.Windows.Forms.TextBox();
            this.upvotePictureBox = new System.Windows.Forms.PictureBox();
            this.downvotePictureBox = new System.Windows.Forms.PictureBox();
            this.labelVoteCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issue1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issue2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issue3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.issueLabel = new System.Windows.Forms.Label();
            this.commentListBox = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.upvotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downvotePictureBox)).BeginInit();
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
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // issueTextBox
            // 
            this.issueTextBox.Location = new System.Drawing.Point(113, 120);
            this.issueTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.issueTextBox.Multiline = true;
            this.issueTextBox.Name = "issueTextBox";
            this.issueTextBox.ReadOnly = true;
            this.issueTextBox.Size = new System.Drawing.Size(487, 86);
            this.issueTextBox.TabIndex = 1;
            this.issueTextBox.Text = resources.GetString("issueTextBox.Text");
            // 
            // upvotePictureBox
            // 
            this.upvotePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upvotePictureBox.BackgroundImage")));
            this.upvotePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upvotePictureBox.Location = new System.Drawing.Point(73, 128);
            this.upvotePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.upvotePictureBox.Name = "upvotePictureBox";
            this.upvotePictureBox.Size = new System.Drawing.Size(27, 44);
            this.upvotePictureBox.TabIndex = 3;
            this.upvotePictureBox.TabStop = false;
            this.upvotePictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // downvotePictureBox
            // 
            this.downvotePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downvotePictureBox.BackgroundImage")));
            this.downvotePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downvotePictureBox.Location = new System.Drawing.Point(22, 128);
            this.downvotePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.downvotePictureBox.Name = "downvotePictureBox";
            this.downvotePictureBox.Size = new System.Drawing.Size(27, 44);
            this.downvotePictureBox.TabIndex = 4;
            this.downvotePictureBox.TabStop = false;
            this.downvotePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.issue1ToolStripMenuItem,
            this.issue2ToolStripMenuItem,
            this.issue3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(810, 26);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issue1ToolStripMenuItem
            // 
            this.issue1ToolStripMenuItem.Name = "issue1ToolStripMenuItem";
            this.issue1ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.issue1ToolStripMenuItem.Text = "Issue 1";
            // 
            // issue2ToolStripMenuItem
            // 
            this.issue2ToolStripMenuItem.Name = "issue2ToolStripMenuItem";
            this.issue2ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.issue2ToolStripMenuItem.Text = "Issue 2";
            this.issue2ToolStripMenuItem.Click += new System.EventHandler(this.issue2ToolStripMenuItem_Click);
            // 
            // issue3ToolStripMenuItem
            // 
            this.issue3ToolStripMenuItem.Name = "issue3ToolStripMenuItem";
            this.issue3ToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.issue3ToolStripMenuItem.Text = "Issue 3";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(22, 39);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(66, 17);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "RedDog";
            // 
            // issueLabel
            // 
            this.issueLabel.AutoSize = true;
            this.issueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueLabel.ForeColor = System.Drawing.Color.Black;
            this.issueLabel.Location = new System.Drawing.Point(18, 63);
            this.issueLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.issueLabel.Name = "issueLabel";
            this.issueLabel.Size = new System.Drawing.Size(410, 36);
            this.issueLabel.TabIndex = 9;
            this.issueLabel.Text = "No time for skills development";
            this.issueLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // commentListBox
            // 
            this.commentListBox.FormattingEnabled = true;
            this.commentListBox.ItemHeight = 16;
            this.commentListBox.Location = new System.Drawing.Point(113, 248);
            this.commentListBox.Margin = new System.Windows.Forms.Padding(1);
            this.commentListBox.Name = "commentListBox";
            this.commentListBox.Size = new System.Drawing.Size(487, 68);
            this.commentListBox.TabIndex = 10;
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
            // issueBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.commentListBox);
            this.Controls.Add(this.issueLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelVoteCount);
            this.Controls.Add(this.downvotePictureBox);
            this.Controls.Add(this.upvotePictureBox);
            this.Controls.Add(this.issueTextBox);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "issueBoardForm";
            this.Text = "Issue Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upvotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downvotePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox issueTextBox;
        private System.Windows.Forms.PictureBox upvotePictureBox;
        private System.Windows.Forms.PictureBox downvotePictureBox;
        private System.Windows.Forms.Label labelVoteCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issue1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issue2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issue3ToolStripMenuItem;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label issueLabel;
        private System.Windows.Forms.ListBox commentListBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

