using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class formIssueBoard : Form
    {
        public bool upVote = false;
        public bool downVote = false;
        public List<string> Animals = new List<string>();
        public List<string> Colors = new List<string>();

        public formIssueBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int voteCount = Convert.ToInt32(labelCount.Text);
            if(upVote == true)
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void issue2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
