namespace USAADemoApp
{
    partial class formIndividualPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIndividualPost));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.labelSkills = new System.Windows.Forms.Label();
            this.listComments = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(206, 455);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(81, 20);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Comment";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonComment_Click);
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
            // listComments
            // 
            this.listComments.FormattingEnabled = true;
            this.listComments.Location = new System.Drawing.Point(17, 192);
            this.listComments.Margin = new System.Windows.Forms.Padding(1);
            this.listComments.Name = "listComments";
            this.listComments.Size = new System.Drawing.Size(441, 160);
            this.listComments.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 373);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 60);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Comments:";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(17, 373);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(54, 13);
            this.labelComment.TabIndex = 13;
            this.labelComment.Text = "Comment:";
            // 
            // formIndividualPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 499);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listComments);
            this.Controls.Add(this.labelSkills);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.textBoxIssue);
            this.Controls.Add(this.buttonSubmit);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formIndividualPost";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.ListBox listComments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelComment;
    }
}

