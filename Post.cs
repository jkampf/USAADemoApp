namespace USAADemoApp
{
    public class Post
    {
        private string postTitle;
        private string postBody;
        private int postCategory;

        public string PostTitle { get => postTitle; set => postTitle = value; }
        public string PostBody { get => postBody; set => postBody = value; }
        public int PostCategory { get => postCategory; set => postCategory = value; }

        public Post()
        {

        }
    }
}
