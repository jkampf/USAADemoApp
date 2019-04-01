using System;
using System.Windows.Forms;
using static System.String;

namespace USAADemoApp
{
    public partial class SubmitPost : Form
    {
        public SubmitPost()
        {
            InitializeComponent();
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            if (textBoxPostTitle.Text == Empty || textBoxPostBody.Text == Empty)
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }
            else
            {
                int postCategory;
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

                Post tmpPost = new Post(textBoxPostTitle.Text, textBoxPostBody.Text, postCategory);
                MessageBox.Show("Post added to board.");
                ClearInputs();
                return;
            }
        }

        private void ClearInputs()
        {
            textBoxPostTitle.Text = "";
            textBoxPostBody.Text = "";
            radioButtonImplementation.Checked = true;
        }
    }
}
