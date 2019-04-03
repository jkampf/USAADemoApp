using System;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class SubmitPost : Form
    {
        public SubmitPost() => InitializeComponent();

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int postCategory = 0;

            if (radioButtonImplementation.Checked == true)
            {
                postCategory = 1;
            }
            else if (radioButtonIssues.Checked == true)
            {
                postCategory = 2;
            }
            else
            {
                postCategory = 3;
            }

            if (labelPostTitle.Text != null || labelPostBody.Text != null)
            {
                Post tmpPost = new Post(labelPostTitle.Text, labelPostBody.Text, postCategory);
            }
            else
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }
        }
    }
}
