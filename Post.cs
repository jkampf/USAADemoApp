namespace USAADemoApp
{
    class Post
    {
        private int voteRank;
        private string postTitle;
        private string postContent;
        private string[] postComments;

        public int VoteRank { get => voteRank; set => voteRank = value; }
        public string PostTitle { get => postTitle; set => postTitle = value; }
        public string PostContent { get => postContent; set => postContent = value; }
        public string[] PostComments { get => postComments; set => postComments = value; }
    }
}
