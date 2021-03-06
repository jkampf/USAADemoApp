﻿using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "scrumdevils.cis440.com";
                builder.Database = "scrumdevils_";
                builder.UserID = "scrumdevils";
                builder.Password = "!!Cis440";

                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                string baseq = "INSERT INTO `usaa`(`Ranking`, `post title`, `post body`, `feedback type`) VALUES (2,'value-2','value-3','value-4')";


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'implementation');";
                MySqlCommand insertImplementationCommand = new MySqlCommand(insertImplementation, connection);
                insertImplementationCommand.ExecuteNonQuery();

            }
            else if (radioButtonIssues.Checked == true)
            {
                postCategory = 2;
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "scrumdevils.cis440.com";
                builder.Database = "scrumdevils_";
                builder.UserID = "scrumdevils";
                builder.Password = "!!Cis440";

                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                string baseq = "INSERT INTO `usaa`(`Ranking`, `post title`, `post body`, `feedback type`) VALUES (2,'value-2','value-3','value-4')";


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'Issues');";
                MySqlCommand insertImplementationCommand = new MySqlCommand(insertImplementation, connection);
                insertImplementationCommand.ExecuteNonQuery();
            }
            else if (radioButtonSuggestions.Checked == true)
            {
                postCategory = 3;
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "scrumdevils.cis440.com";
                builder.Database = "scrumdevils_";
                builder.UserID = "scrumdevils";
                builder.Password = "!!Cis440";

                MySqlConnection connection = new MySqlConnection(builder.ToString());
                connection.Open();

                string baseq = "INSERT INTO `usaa`(`Ranking`, `post title`, `post body`, `feedback type`) VALUES (2,'value-2','value-3','value-4')";


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'suggestions');";
                MySqlCommand insertImplementationCommand = new MySqlCommand(insertImplementation, connection);
                insertImplementationCommand.ExecuteNonQuery();
            }

            if (textBoxPostTitle.Text != Empty && textBoxPostBody.Text != Empty && postCategory != 0)
            {
                Post tmpPost = new Post(textBoxPostTitle.Text, textBoxPostBody.Text, postCategory);
                PostAdded(this, tmpPost);

                radioButtonImplementation.Checked = false;
                radioButtonIssues.Checked = false;
                radioButtonSuggestions.Checked = false;
                textBoxPostTitle.Clear();
                textBoxPostBody.Clear();
                postCategory = 0;
            }
            else
            {
                MessageBox.Show("Enter all data fields.");
                return;
            }
        }

        private void SubmitPost_Load(object sender, EventArgs e)
        {

        }
    }
}