namespace USAADemoApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voteCountLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.issue1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issue2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issue3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentList = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1150, 194);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(173, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 102);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(52, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 102);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // voteCountLabel
            // 
            this.voteCountLabel.AutoSize = true;
            this.voteCountLabel.Location = new System.Drawing.Point(117, 335);
            this.voteCountLabel.Name = "voteCountLabel";
            this.voteCountLabel.Size = new System.Drawing.Size(53, 37);
            this.voteCountLabel.TabIndex = 5;
            this.voteCountLabel.Text = "23";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(44, 45);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 37);
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
            this.menuStrip1.Size = new System.Drawing.Size(1974, 56);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // issue1ToolStripMenuItem
            // 
            this.issue1ToolStripMenuItem.Name = "issue1ToolStripMenuItem";
            this.issue1ToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.issue1ToolStripMenuItem.Text = "Issue 1";
            // 
            // issue2ToolStripMenuItem
            // 
            this.issue2ToolStripMenuItem.Name = "issue2ToolStripMenuItem";
            this.issue2ToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.issue2ToolStripMenuItem.Text = "Issue 2";
            this.issue2ToolStripMenuItem.Click += new System.EventHandler(this.issue2ToolStripMenuItem_Click);
            // 
            // issue3ToolStripMenuItem
            // 
            this.issue3ToolStripMenuItem.Name = "issue3ToolStripMenuItem";
            this.issue3ToolStripMenuItem.Size = new System.Drawing.Size(140, 52);
            this.issue3ToolStripMenuItem.Text = "Issue 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "RedDog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(996, 82);
            this.label2.TabIndex = 9;
            this.label2.Text = "No time for skills development";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CommentList
            // 
            this.CommentList.FormattingEnabled = true;
            this.CommentList.ItemHeight = 37;
            this.CommentList.Location = new System.Drawing.Point(269, 573);
            this.CommentList.Name = "CommentList";
            this.CommentList.Size = new System.Drawing.Size(1150, 152);
            this.CommentList.TabIndex = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(248, 912);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1606, 873);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1746);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.CommentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.voteCountLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label voteCountLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issue1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issue2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issue3ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CommentList;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

