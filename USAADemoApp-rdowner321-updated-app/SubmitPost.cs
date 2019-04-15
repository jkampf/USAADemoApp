using System;
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


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'Previous Implementations');";
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


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'Current Departmental Issues');";
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


                string insertImplementation = "INSERT into `usaa` (`Ranking`, `post title`, `post body`,`feedback type`) VALUES ('4','" + textBoxPostTitle.Text + "','" + textBoxPostBody.Text + "'," + "'Departmental Suggestion');";
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
            //Populate();
        }
        public void Populate()
        {
            PostBoard pb = new PostBoard();

            if (pb.firstrun == true)
            {
                pb.firstrun = false;

                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "scrumdevils.cis440.com";
                builder.Database = "scrumdevils_";
                builder.UserID = "scrumdevils";
                builder.Password = "!!Cis440";

                MySqlConnection connection2 = new MySqlConnection(builder.ToString());
                connection2.Open();


                string selectDepartmentTitle = "SELECT `post title` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
                MySqlCommand selectCurrentDepartmentCommand = new MySqlCommand(selectDepartmentTitle, connection2);

                string departmentTitle;
                departmentTitle = selectCurrentDepartmentCommand.ExecuteScalar().ToString();

                string selectDepartmentBody = "SELECT `post body` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
                MySqlCommand selectCurrentDepartmentBody = new MySqlCommand(selectDepartmentBody, connection2);

                string departmentBody;
                departmentBody = selectCurrentDepartmentBody.ExecuteScalar().ToString();

                string selectDepartmentRanking = "SELECT `Ranking` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
                MySqlCommand selectCurrentDepartmentRanking = new MySqlCommand(selectDepartmentRanking, connection2);

                int departmentRanking;
                departmentRanking = Convert.ToInt32(selectCurrentDepartmentRanking.ExecuteScalar().ToString());
                Post department1 = new Post(departmentTitle, departmentBody, 2);
                department1.PostVotes = departmentRanking;
                PostAdded(this, department1);

                Post department2 = new Post("Transition of Database", "The organization has been using an old aged and database and we need to transition into a newer database for efficient data extraction and cost minimization.", 2);
                department2.PostVotes = 19;
                PostAdded(this, department2);

                Post department3 = new Post("Extended working hours ", "sometimes we have to stay extra hours to finish a project this has a negative impact on our family life and health. in addition to making us lose motivation. ", 2);
                department3.PostVotes = 14;
                PostAdded(this, department3);

                Post department4 = new Post("Attention to all team members", "I have been faced in a recurring situation for the last 9 weeks. Every Friday, for the last 9 weeks, I have spent the first 30 minutes of the weekly meeting without the ability to be recognized as a speaker and reflect on my week. The same peers are targeted by management and the same ones receiving benefits, promotions, etc. How can management better recognize the hard work of the greater employees instead of just a specific group?", 2);
                department4.PostVotes = 8;
                PostAdded(this, department4);

                Post department5 = new Post("My voice isn't being heard", "My managers dismisses any suggestions or feedback I give them for improving workplace productivity. I'm never taken seriously. How can I resolve this?", 2);
                department5.PostVotes = 6;
                PostAdded(this, department5);

                Post department6 = new Post("Tech Support Dept. Recognition", "Over the past month, I have felt a lack of direction from those I am a subordinate of. I am required to field at least 25 tickets a day and have been completing upwards of 40 for the past month with no recgonition. What incentive is there for me to outperform my peers?", 2);
                department6.PostVotes = 3;
                PostAdded(this, department2);

                Post implement1 = new Post("Increased the amount of training opportunities", "The company has diversified and incremented training programs for employees interested in emerging technologies and idiosyncratic subject areas.", 1);
                implement1.PostVotes = 20;
                PostAdded(this, implement1);

                Post implement2 = new Post("Bring your own device to work", "The implementation of the new security system which has allowed portability to work from home and office. ", 1);
                implement2.PostVotes = 15;
                PostAdded(this, implement2);

                Post implement3 = new Post("the new training program ", "I like the new training programs we get every month they helping us to learn more. ", 1);
                implement3.PostVotes = 12;
                PostAdded(this, implement3);

                Post implement4 = new Post("Ticketing Service ", "I think moving to the new software provider for our ticketing services was a great implentation. It has really helped lower the time taken to process clients in order to help them with their current issues", 1);
                implement4.PostVotes = 8;
                PostAdded(this, implement4);

                Post implement5 = new Post("Increase days for paternal leave", "I think increasing days for increasing paternal leave to 3 weeks boosted the morale of employees as they feel the organization cares about their work life balance.", 1);
                implement5.PostVotes = 20;
                PostAdded(this, implement5);

                Post suggestion1 = new Post("Celebrating sucess when getting a goal done", "as a team it would be a good idea to celebrate after we get a project done it will improve our relationship together", 3);
                suggestion1.PostVotes = 25;
                PostAdded(this, suggestion1);

                Post suggestion2 = new Post("Bi-Monthly Town Hall with Senior Management", "It would be easier to manage time and tasks if senior management routinely informed the department about new integrations and changes to the department.", 3);
                suggestion2.PostVotes = 17;
                PostAdded(this, suggestion2);

                Post suggestion3 = new Post("Healthy Eating Incentives", "It would be neat if employees received health insurance discounts and other perks for eating healthy. Everyone would benefit.", 3);
                suggestion3.PostVotes = 14;
                PostAdded(this, suggestion3);

                Post suggestion4 = new Post("Mentorship Program ", "As a senior employee I would like to offer the opportunity to mentor new hires. I think it could be a good idea if we created a mentorship program where senior employees can be available to help new hires transtition succesfully into our department ", 3);
                suggestion4.PostVotes = 9;
                PostAdded(this, suggestion4);

                Post suggestion5 = new Post("Casual Fridays ", "I think it could be a good idea to implement casual Fridays in our office. I have recently read of the success a lot of companies are having with this implementation and I think it could be a good idea ", 3);
                suggestion5.PostVotes = 6;
                PostAdded(this, suggestion5);

                Post suggestion6 = new Post("Group Lunches ", "I have heard other departments setting aside time once every two weeks or so in order to meet for group lunches. I think this could be a good idea in order for our department to get to know each other better and learn more about those we work with ", 3);
                suggestion6.PostVotes = 2;
                PostAdded(this, suggestion6);
            }
        }

        private void SubmitPost_ResizeBegin(object sender, EventArgs e)
        {
            //Populate();
        }

        private void SubmitPost_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Populate();
        }

        private void SubmitPost_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Populate();
        }
    }
}