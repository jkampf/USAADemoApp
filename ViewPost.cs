using System;
using System.Windows.Forms;
using static System.Convert;

namespace USAADemoApp
{
    public partial class ViewPost : Form
    {
        Post currentPost;

        public void PopulateData(Post post)
        {
            currentPost = post;
            labelPostTitle.Text = post.PostTitle;
            textBoxPostBody.Text = post.PostBody;
        }
    }
}
