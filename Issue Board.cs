﻿using System;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class formIssueBoard : Form
    {
        public bool upVote = false;
        public bool downVote = false;

        public formIssueBoard()
        {
            InitializeComponent();
        }

        private void ButtonComment_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxUpvote_Click(object sender, EventArgs e)
        {
            int voteCount = Convert.ToInt32(labelCount.Text);

            if (downVote == true)
            {
                voteCount = voteCount + 2;
                labelCount.Text = Convert.ToString(voteCount);
                downVote = false;
                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
            }
            else if (downVote == false)
            {
                voteCount = voteCount - 1;
                labelCount.Text = Convert.ToString(voteCount);
                downVote = true;
                upVote = false;

                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowVoted;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;
            }
        }

        private void PictureBoxDownvote_Click(object sender, EventArgs e)
        {
            int voteCount = Convert.ToInt32(labelCount.Text);
            if (upVote == true)
            {
                voteCount = voteCount - 1;
                labelCount.Text = Convert.ToString(voteCount);
                upVote = false;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;

            }
            else if (upVote == false)
            {
                voteCount = voteCount + 1;
                labelCount.Text = Convert.ToString(voteCount);
                upVote = true;
                downVote = false;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowVoted;
                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
            }
        }
    }
}
