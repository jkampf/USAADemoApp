using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.String;

namespace USAADemoApp
{
    public delegate void PostEventHandler(object sender, Post p);

    public partial class Welcome : Form
    {
        BindingList<Post> listOfPosts = new BindingList<Post>();
        PostBoard postBoardForm;

        public Welcome()
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
                listOfPosts.Add(tmpPost);
                MessageBox.Show("Post added to board.");
                ClearInputs();
                return;
            }
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

        private void ButtonViewBoard_Click(object sender, EventArgs e)
        {
            postBoardForm = new PostBoard();
            postBoardForm.PopulateData(listOfPosts);
            postBoardForm.ShowDialog();
        }

        private void ClearInputs()
        {
            textBoxPostTitle.Text = "";
            textBoxPostBody.Text = "";
            radioButtonImplementation.Checked = true;
        }
    }
}
