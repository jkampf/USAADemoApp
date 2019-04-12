namespace USAADemoApp
{
    partial class ViewPost
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
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPostBody.Location = new System.Drawing.Point(28, 77);
            this.textBoxPostBody.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.ReadOnly = true;
            this.textBoxPostBody.Size = new System.Drawing.Size(487, 86);
            this.textBoxPostBody.TabIndex = 1;
            this.textBoxPostBody.Text = "Post Body";
            // 
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostTitle.ForeColor = System.Drawing.Color.Black;
            this.labelPostTitle.Location = new System.Drawing.Point(22, 24);
            this.labelPostTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(149, 36);
            this.labelPostTitle.TabIndex = 9;
            this.labelPostTitle.Text = "Post Title";
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 212);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.textBoxPostBody);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ViewPost";
            this.Text = "Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPostBody;
        private System.Windows.Forms.Label labelPostTitle;
    }
}

