using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace USAADemoApp
{
    public delegate void PostEventHandler(object sender, Post p);

    public partial class SubmitPost : Form
    {
        public event PostEventHandler PostAdded;

        public SubmitPost() => InitializeComponent();

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            int postCategory = 0;

            if (radioButtonImplementation.Checked == true)
            {
                postCategory = 1;
            }
            else if (radioButtonIssues.Checked == true)
            {
                postCategory = 2;
            }
            else
            {
                postCategory = 3;
            }

            if (labelPostTitle.Text != null || labelPostBody.Text != null)
            {
                Post tmpPost = new Post(labelPostTitle.Text, labelPostBody.Text, postCategory);
            }
            else
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }
        }
    }
}
