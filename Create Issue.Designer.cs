namespace USAADemoApp
{
    partial class formCreateIssue
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
            this.buttonPostIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPostIssue
            // 
            this.buttonPostIssue.Location = new System.Drawing.Point(109, 138);
            this.buttonPostIssue.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPostIssue.Name = "buttonPostIssue";
            this.buttonPostIssue.Size = new System.Drawing.Size(91, 30);
            this.buttonPostIssue.TabIndex = 0;
            this.buttonPostIssue.Text = "Post Issue";
            this.buttonPostIssue.UseVisualStyleBackColor = true;
            // 
            // formCreateIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 194);
            this.Controls.Add(this.buttonPostIssue);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formCreateIssue";
            this.Text = "Create Issue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPostIssue;
    }
}