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
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(15, 67);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(397, 329);
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
            this.comboBoxPostCategory.Location = new System.Drawing.Point(94, 25);
            this.comboBoxPostCategory.Name = "comboBoxPostCategory";
            this.comboBoxPostCategory.Size = new System.Drawing.Size(143, 21);
            this.comboBoxPostCategory.TabIndex = 1;
            // 
            // labelPostCategory
            // 
            this.labelPostCategory.AutoSize = true;
            this.labelPostCategory.Location = new System.Drawing.Point(12, 25);
            this.labelPostCategory.Name = "labelPostCategory";
            this.labelPostCategory.Size = new System.Drawing.Size(76, 13);
            this.labelPostCategory.TabIndex = 3;
            this.labelPostCategory.Text = "Post Category:";
            // 
            // PostBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.labelPostCategory);
            this.Controls.Add(this.comboBoxPostCategory);
            this.Controls.Add(this.listBoxPosts);
            this.Name = "PostBoard";
            this.Text = "Post Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ComboBox comboBoxPostCategory;
        private System.Windows.Forms.Label labelPostCategory;
    }
}