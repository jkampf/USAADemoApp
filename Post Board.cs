using System.ComponentModel;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class PostBoard : Form
    {
        BindingList<Post> listOfPosts;

        public PostBoard()
        {
            InitializeComponent();
        }

        public void PopulateData(BindingList<Post> posts)
        {
            listOfPosts = posts;
            listBoxPosts.DataSource = listOfPosts;
        }
    }
}
