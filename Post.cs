namespace USAADemoApp
{
    public class Post
    {
        private string postTitle;
        private string postContent;
        private int postCategory;

        public string PostTitle { get => postTitle; set => postTitle = value; }
        public string PostContent { get => postContent; set => postContent = value; }
        public int PostCategory { get => postCategory; set => postCategory = value; }

        public Post(string postTitle, string postContent, int postCategory)
        {
            this.postTitle = postTitle;
            this.postContent = postContent;
            this.postCategory = postCategory;
        }
    }
}
