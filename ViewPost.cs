using System;
using System.Windows.Forms;
using static System.Convert;

namespace USAADemoApp
{
    public partial class ViewPost : Form
    {
        public ViewPost() => InitializeComponent();

        private Post currentPost;

        private bool upVote = false;
        private bool downVote = false;

        private void PictureBoxUpvote_Click(object sender, EventArgs e)
        {
            int voteCount = ToInt32(labelCount.Text);

            if (downVote == true)
            {
                voteCount += 2;
                labelCount.Text = Convert.ToString(voteCount);
                downVote = false;
                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
            }
            else if (downVote == false)
            {
                voteCount -= 1;
                labelCount.Text = Convert.ToString(voteCount);
                downVote = true;
                upVote = false;

                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowVoted;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;
            }
        }

        private void PictureBoxDownvote_Click(object sender, EventArgs e)
        {
            int voteCount = ToInt32(labelCount.Text);
            if (upVote == true)
            {
                voteCount -= 1;
                labelCount.Text = Convert.ToString(voteCount);
                upVote = false;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;
            }
            else
            {
                voteCount += 1;
                labelCount.Text = Convert.ToString(voteCount);
                upVote = true;
                downVote = false;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowVoted;
                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
            }
        }

        public void PopulateData(Post post)
        {
            currentPost = post;
            labelPostTitle.Text = post.PostTitle;
            textBoxPostBody.Text = post.PostBody;
        }
    }
}
