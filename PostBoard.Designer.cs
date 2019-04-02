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
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonNewPost = new System.Windows.Forms.Button();
            this.checkBoxIsManager = new System.Windows.Forms.CheckBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(15, 123);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(438, 604);
            this.listBoxPosts.TabIndex = 5;
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.Location = new System.Drawing.Point(682, 772);
            this.buttonNewPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(103, 34);
            this.buttonNewPost.TabIndex = 3;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = true;
            this.buttonNewPost.Click += new System.EventHandler(this.ButtonNewPost_Click);
            // 
            // checkBoxIsManager
            // 
            this.checkBoxIsManager.AutoSize = true;
            this.checkBoxIsManager.Location = new System.Drawing.Point(1218, 13);
            this.checkBoxIsManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxIsManager.Name = "checkBoxIsManager";
            this.checkBoxIsManager.Size = new System.Drawing.Size(127, 29);
            this.checkBoxIsManager.TabIndex = 2;
            this.checkBoxIsManager.Text = "Manager?";
            this.checkBoxIsManager.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(1218, 50);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(177, 34);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(504, 123);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 604);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(993, 123);
            this.listBox2.Margin = new System.Windows.Forms.Padding(6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(438, 604);
            this.listBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Previous Implementations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Departmental Issues";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1104, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Departmental Suggestions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee Feedback App ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 854);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.checkBoxIsManager);
            this.Controls.Add(this.buttonNewPost);
            this.Controls.Add(this.listBoxPosts);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.Load += new System.EventHandler(this.PostBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonNewPost;
        private System.Windows.Forms.CheckBox checkBoxIsManager;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}