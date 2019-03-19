namespace USAADemoApp
{
    partial class Welcome
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.postButton = new System.Windows.Forms.Button();
            this.viewTopIssuesButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 14);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(100, 37);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(819, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(206, 41);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Manager?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(302, 264);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(466, 68);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Create Issue ";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // viewTopIssuesButton
            // 
            this.viewTopIssuesButton.Location = new System.Drawing.Point(302, 384);
            this.viewTopIssuesButton.Name = "viewTopIssuesButton";
            this.viewTopIssuesButton.Size = new System.Drawing.Size(466, 59);
            this.viewTopIssuesButton.TabIndex = 4;
            this.viewTopIssuesButton.Text = "View Issue Board";
            this.viewTopIssuesButton.UseVisualStyleBackColor = true;
            this.viewTopIssuesButton.Click += new System.EventHandler(this.viewTopIssuesButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Enabled = false;
            this.generateReportButton.Location = new System.Drawing.Point(302, 493);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(466, 57);
            this.generateReportButton.TabIndex = 5;
            this.generateReportButton.Text = "Generate Monthly Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1025, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Feedback App";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.viewTopIssuesButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button viewTopIssuesButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label label1;
    }
}