namespace USAADemoApp
{
    public class Post
    {
        private string postTitle;
        private string postBody;
        private int postCategory;
        private int postVotes;

        public string PostTitle { get => postTitle; set => postTitle = value; }
        public string PostBody { get => postBody; set => postBody = value; }
        public int PostCategory { get => postCategory; set => postCategory = value; }
        public int PostVotes { get => postVotes; set => postVotes = value; }

        public Post(string postTitle, string postBody, int postCategory)
        {
            this.postTitle = postTitle;
            this.postBody = postBody;
            this.postCategory = postCategory;
            this.PostVotes = PostVotes;
        }

        public override string ToString()
        {
            return postTitle;
        }
    }
}
