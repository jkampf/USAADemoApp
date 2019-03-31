using System;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class FormWelcome : Form
    {
        public bool isManager = false;

        public FormWelcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void ViewTopIssuesButton_Click(object sender, EventArgs e)
        {
            formIssueBoard form1 = new formIssueBoard();
            form1.Show();
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
                buttonPost.Enabled = false;
            }
            if (checkBoxManager.Checked == false)
            {
                buttonPost.Enabled = true;
            }
        }
    }
}
