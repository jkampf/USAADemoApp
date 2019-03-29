using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USAADemoApp
{
    class Post
    {
        private int voteRank;
        private string postTitle;
        private string postContent;

        public int VoteRank { get => voteRank; set => voteRank = value; }
        public string PostTitle { get => postTitle; set => postTitle = value; }
        public string PostContent { get => postContent; set => postContent = value; }
    }
}
