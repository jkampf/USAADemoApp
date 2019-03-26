using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USAADemoApp
{
    public partial class formWelcome : Form
    {
        public List<string> Animals = new List<string>();
        public List<string> Colors = new List<string>();

        public bool isManager = false;

        public formWelcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Animals.Add("Dog");
            Animals.Add("Cat");
            Animals.Add("Lion");
            Animals.Add("Platypus");
            Animals.Add("Dinosaur");
            Animals.Add("Snail");
            Animals.Add("Monkey");

            Colors.Add("Red");
            Colors.Add("Blue");
            Colors.Add("Green");
            Colors.Add("Yellow");

            Random randColor = new Random();
            Random randAnimal = new Random();
            int randomColorIndex = randColor.Next(Colors.Count);
            int randomAnimalIndex = randColor.Next(Colors.Count);
            string userName = "Welcome, " + Colors[randomColorIndex] + Animals[randomAnimalIndex];
            labelWelcome.Text = userName;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxManager.Checked == true)
            {
                buttonPost.Enabled = false;
            }
            if(checkboxManager.Checked == false)
            {
                buttonPost.Enabled = true;
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {

        }

        private void viewTopIssuesButton_Click(object sender, EventArgs e)
        {
            formIssueBoard form1 = new formIssueBoard();
            form1.Show();
        }
    }
}
