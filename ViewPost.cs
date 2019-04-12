using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class ViewPost : Form
    {
        public ViewPost() => InitializeComponent();

        private Post currentPost;

        public void PopulateData(Post post)
        {
            currentPost = post;
            labelPostTitle.Text = post.PostTitle;
            textBoxPostBody.Text = post.PostBody;
        }
    }
}
