using System;
using System.Windows.Forms;
using static System.String;
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
            else if (radioButtonSuggestions.Checked == true)
            {
                postCategory = 3;
            }

            if (textBoxPostTitle.Text != Empty && textBoxPostBody.Text != Empty && postCategory != 0)
            {
                Post tmpPost = new Post(textBoxPostTitle.Text, textBoxPostBody.Text, postCategory);
                PostAdded(this, tmpPost);
            }
            else
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }
        }
    }
}
