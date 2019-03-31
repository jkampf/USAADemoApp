using System;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void ViewTopIssuesButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxManager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManager.Checked == true)
            {
                buttonPost.Enabled = false;
                buttonGenerateReport.Enabled = true;
            }
            else
            {
                buttonPost.Enabled = true;
                buttonGenerateReport.Enabled = false;
            }
        }
    }
}
