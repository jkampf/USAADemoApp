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
            this.comboBoxPostCategory = new System.Windows.Forms.ComboBox();
            this.labelPostCategory = new System.Windows.Forms.Label();
            this.buttonNewPost = new System.Windows.Forms.Button();
            this.checkBoxIsManager = new System.Windows.Forms.CheckBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(20, 82);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(528, 404);
            this.listBoxPosts.TabIndex = 2;
            // 
            // comboBoxPostCategory
            // 
            this.comboBoxPostCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPostCategory.FormattingEnabled = true;
            this.comboBoxPostCategory.Items.AddRange(new object[] {
            "Implementation",
            "Issues",
            "Suggestions"});
            this.comboBoxPostCategory.Location = new System.Drawing.Point(125, 31);
            this.comboBoxPostCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPostCategory.Name = "comboBoxPostCategory";
            this.comboBoxPostCategory.Size = new System.Drawing.Size(266, 24);
            this.comboBoxPostCategory.TabIndex = 1;
            // 
            // labelPostCategory
            // 
            this.labelPostCategory.AutoSize = true;
            this.labelPostCategory.Location = new System.Drawing.Point(16, 31);
            this.labelPostCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostCategory.Name = "labelPostCategory";
            this.labelPostCategory.Size = new System.Drawing.Size(101, 17);
            this.labelPostCategory.TabIndex = 3;
            this.labelPostCategory.Text = "Post Category:";
            // 
            // buttonNewPost
            // 
            this.buttonNewPost.Location = new System.Drawing.Point(241, 517);
            this.buttonNewPost.Name = "buttonNewPost";
            this.buttonNewPost.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPost.TabIndex = 4;
            this.buttonNewPost.Text = "New Post";
            this.buttonNewPost.UseVisualStyleBackColor = true;
            this.buttonNewPost.Click += new System.EventHandler(this.ButtonNewPost_Click);
            // 
            // checkBoxIsManager
            // 
            this.checkBoxIsManager.AutoSize = true;
            this.checkBoxIsManager.Location = new System.Drawing.Point(454, 34);
            this.checkBoxIsManager.Name = "checkBoxIsManager";
            this.checkBoxIsManager.Size = new System.Drawing.Size(94, 21);
            this.checkBoxIsManager.TabIndex = 5;
            this.checkBoxIsManager.Text = "Manager?";
            this.checkBoxIsManager.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(419, 517);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerateReport.TabIndex = 6;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 569);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.checkBoxIsManager);
            this.Controls.Add(this.buttonNewPost);
            this.Controls.Add(this.labelPostCategory);
            this.Controls.Add(this.comboBoxPostCategory);
            this.Controls.Add(this.listBoxPosts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ComboBox comboBoxPostCategory;
        private System.Windows.Forms.Label labelPostCategory;
        private System.Windows.Forms.Button buttonNewPost;
        private System.Windows.Forms.CheckBox checkBoxIsManager;
        private System.Windows.Forms.Button buttonGenerateReport;
    }
}