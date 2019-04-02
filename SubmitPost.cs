using System;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class SubmitPost : Form
    {
        public SubmitPost() => InitializeComponent();

        Post tmpPost;

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (radioButtonImplementation.Checked == true)
            {
                tmpPost.PostCategory = 1;
            }
            else if (radioButtonIssues.Checked == true)
            {
                tmpPost.PostCategory = 2;
            }
            else
            {
                tmpPost.PostCategory = 3;
            }
            if (labelPostTitle.Text != null && labelPostBody.Text != null)
            {
                tmpPost.PostTitle = textBoxPostTitle.Text;
                tmpPost.PostBody = textBoxPostBody.Text;
            }
            else
            {
                MessageBox.Show("Invalid user input.");
            }
        }
    }
}
