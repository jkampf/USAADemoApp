namespace USAADemoApp
{
    partial class IndividualPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndividualPost));
            this.buttonSubmitComment = new System.Windows.Forms.Button();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.listPostComments = new System.Windows.Forms.ListBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmitComment
            // 
            this.buttonSubmitComment.Location = new System.Drawing.Point(171, 444);
            this.buttonSubmitComment.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSubmitComment.Name = "buttonSubmitComment";
            this.buttonSubmitComment.Size = new System.Drawing.Size(141, 20);
            this.buttonSubmitComment.TabIndex = 0;
            this.buttonSubmitComment.Text = "Submit Comment";
            this.buttonSubmitComment.UseVisualStyleBackColor = true;
            this.buttonSubmitComment.Click += new System.EventHandler(this.ButtonSubmitComment_Click);
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(85, 60);
            this.textBoxPostBody.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.ReadOnly = true;
            this.textBoxPostBody.Size = new System.Drawing.Size(366, 71);
            this.textBoxPostBody.TabIndex = 1;
            this.textBoxPostBody.Text = "Post Body";
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
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostTitle.ForeColor = System.Drawing.Color.Black;
            this.labelPostTitle.Location = new System.Drawing.Point(80, 15);
            this.labelPostTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(115, 29);
            this.labelPostTitle.TabIndex = 9;
            this.labelPostTitle.Text = "Post Title";
            // 
            // listPostComments
            // 
            this.listPostComments.FormattingEnabled = true;
            this.listPostComments.Location = new System.Drawing.Point(17, 179);
            this.listPostComments.Margin = new System.Windows.Forms.Padding(1);
            this.listPostComments.Name = "listPostComments";
            this.listPostComments.Size = new System.Drawing.Size(434, 134);
            this.listPostComments.TabIndex = 10;
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(17, 339);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(434, 78);
            this.textBoxBody.TabIndex = 11;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(14, 153);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(59, 13);
            this.labelComments.TabIndex = 12;
            this.labelComments.Text = "Comments:";
            // 
            // IndividualPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.listPostComments);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.buttonSubmitComment);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "IndividualPost";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmitComment;
        private System.Windows.Forms.TextBox textBoxPostBody;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.ListBox listPostComments;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelComments;
    }
}

