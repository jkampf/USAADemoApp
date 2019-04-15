using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Convert;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace USAADemoApp
{

    public partial class PostBoard : Form 
    {
        public PostBoard() => InitializeComponent();
        public bool firstrun = true;

        Post selectedPost;
        SubmitPost submitPost;
        ViewPost viewPost;
        

        BindingList<Post> listOfImplementationPosts;
        BindingList<Post> listOfIssuePosts;
        BindingList<Post> listOfSuggestionPosts;

        private void ButtonNewPost_Click(object sender, System.EventArgs e)
        {
            submitPost = new SubmitPost();
            submitPost.PostAdded += new PostEventHandler(AddPost_PostAdded);
            submitPost.ShowDialog();
        }

        private void AddPost_PostAdded(object sender, Post p)
        {
            if (p.PostCategory == 1)
            {
                listOfImplementationPosts.Add(p);
                listBoxImplementations.DataSource = listOfImplementationPosts;
            }
            else if (p.PostCategory == 2)
            {
                listOfIssuePosts.Add(p);
                listBoxIssues.DataSource = listOfIssuePosts;
            }
            else if (p.PostCategory == 3)
            {
                listOfSuggestionPosts.Add(p);
                listBoxSuggestions.DataSource = listOfSuggestionPosts;
            }
        }

        private void ButtonGenerateReport_Click(object sender, System.EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet previousImplementationsSheet;
            Excel.Worksheet departmentalIssuesSheet;
            Excel.Worksheet departmentalSuggestionsSheet;

            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            previousImplementationsSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            departmentalIssuesSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);
            departmentalSuggestionsSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(misValue, misValue, misValue, misValue);

            //add data 

             MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "scrumdevils.cis440.com";
                builder.Database = "scrumdevils_";
                builder.UserID = "scrumdevils";
                builder.Password = "!!Cis440";

                MySqlConnection connection3 = new MySqlConnection(builder.ToString());
                connection3.Open();


                string selectDepartmentTitle = "SELECT `post title` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
                MySqlCommand selectCurrentDepartmentCommand = new MySqlCommand(selectDepartmentTitle, connection3);

                string departmentTitle;
                departmentTitle = selectCurrentDepartmentCommand.ExecuteScalar().ToString();

            string selectDepartmentBody = "SELECT `post title` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectCurrentDepartmentBody = new MySqlCommand(selectDepartmentBody, connection3);

            string departmentBody;
            departmentBody = selectCurrentDepartmentBody.ExecuteScalar().ToString();

            string selectDepartmentRanking = "SELECT `Ranking` FROM usaa where `feedback type` = 'Current Departmental Issues' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectCurrentDepartmentRanking = new MySqlCommand(selectDepartmentRanking, connection3);

            string departmentRanking;
            departmentRanking = selectCurrentDepartmentRanking.ExecuteScalar().ToString();

            string selectImplementTitle = "SELECT `post title` FROM usaa where `feedback type` = 'Previous Implementations' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectCurrentImplementCommand = new MySqlCommand(selectImplementTitle, connection3);

            string implementTitle;
            implementTitle = selectCurrentImplementCommand.ExecuteScalar().ToString();

            string selectImplementBody = "SELECT `post title` FROM usaa where `feedback type` = 'Previous Implementations' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectCurrentImplementBody = new MySqlCommand(selectImplementBody, connection3);

            string implementBody;
            implementBody = selectCurrentImplementBody.ExecuteScalar().ToString();

            string selectRanking = "SELECT `Ranking` FROM usaa where `feedback type` = 'Previous Implementations' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectImplementRanking = new MySqlCommand(selectRanking, connection3);

            string implementRanking;
            implementRanking = selectImplementRanking.ExecuteScalar().ToString();

            string selectSuggestTitle = "SELECT `post title` FROM usaa where `feedback type` = 'Departmental Suggestion' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectSuggestCommand = new MySqlCommand(selectSuggestTitle, connection3);

            string suggestTitle;
            suggestTitle = selectSuggestCommand.ExecuteScalar().ToString();

            string selectSuggestBody = "SELECT `post title` FROM usaa where `feedback type` = 'Departmental Suggestion' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectSuggestBodyCommand = new MySqlCommand(selectSuggestBody, connection3);

            string suggestBody;
            suggestBody = selectSuggestBodyCommand.ExecuteScalar().ToString();

            string suggestRanking = "SELECT `Ranking` FROM usaa where `feedback type` = 'Departmental Suggestion' ORDER BY ranking DESC LIMIT 0,1";
            MySqlCommand selectSuggestRanking = new MySqlCommand(suggestRanking, connection3);

            string suggestTopRanking;
            suggestTopRanking = selectSuggestRanking.ExecuteScalar().ToString();


            previousImplementationsSheet.Cells[19, 1] = "";
            previousImplementationsSheet.Cells[19, 2] = "Previous Implementation Issues";

            previousImplementationsSheet.Cells[20, 1] = implementTitle;
            previousImplementationsSheet.Cells[20, 2] = implementRanking;

            previousImplementationsSheet.Cells[20, 3] = implementBody;

            previousImplementationsSheet.Cells[21, 1] = "Bring your own device to work";
            previousImplementationsSheet.Cells[21, 2] = "15";

            previousImplementationsSheet.Cells[21, 3] = "The implementation of the new security system which has allowed portability to work from home and office. ";

            previousImplementationsSheet.Cells[22, 1] = "the new training program ";
            previousImplementationsSheet.Cells[22, 2] = "12";

            previousImplementationsSheet.Cells[22, 3] = "I like the new training programs we get every month they helping us to learn more. ";

            previousImplementationsSheet.Cells[23, 1] = "Ticketing Service ";
            previousImplementationsSheet.Cells[23, 2] = "8";

            previousImplementationsSheet.Cells[23, 3] = "I think moving to the new software provider for our ticketing services was a great implentation. It has really helped lower the time taken to process clients in order to help them with their current issues";

            previousImplementationsSheet.Cells[24, 1] = "Increase days for paternal leave";
            previousImplementationsSheet.Cells[24, 2] = "4";

            previousImplementationsSheet.Cells[24, 3] = "I think increasing days for increasing paternal leave to 3 weeks boosted the morale of employees as they feel the organization cares about their work life balance.";

            departmentalIssuesSheet.Cells[19, 1] = "";
            departmentalIssuesSheet.Cells[19, 2] = "Departmental Issues";

            departmentalIssuesSheet.Cells[20, 1] = departmentTitle;
            departmentalIssuesSheet.Cells[20, 2] = departmentRanking;

            departmentalIssuesSheet.Cells[20, 3] = departmentBody;

            departmentalIssuesSheet.Cells[21, 1] = "Transition of Database";
            departmentalIssuesSheet.Cells[21, 2] = "19";

            departmentalIssuesSheet.Cells[21, 3] = "The organization has been using an old aged and database and we need to transition into a newer database for efficient data extraction and cost minimization.";

            departmentalIssuesSheet.Cells[22, 1] = "Extended working hours ";
            departmentalIssuesSheet.Cells[22, 2] = "14";

            departmentalIssuesSheet.Cells[22, 3] = "sometimes we have to stay extra hours to finish a project this has a negative impact on our family life and health. in addition to making us lose motivation. ";

            departmentalIssuesSheet.Cells[23, 1] = "Attention to all team members";
            departmentalIssuesSheet.Cells[23, 2] = "8";

            departmentalIssuesSheet.Cells[23, 3] = "I have been faced in a recurring situation for the last 9 weeks. Every Friday, for the last 9 weeks, I have spent the first 30 minutes of the weekly meeting without the ability to be recognized as a speaker and reflect on my week. The same peers are targeted by management and the same ones receiving benefits, promotions, etc. How can management better recognize the hard work of the greater employees instead of just a specific group?";

            departmentalIssuesSheet.Cells[24, 1] = "My voice isn't being heard";
            departmentalIssuesSheet.Cells[24, 2] = "6";

            departmentalIssuesSheet.Cells[24, 3] = "My managers dismisses any suggestions or feedback I give them for improving workplace productivity. I'm never taken seriously. How can I resolve this?";

            departmentalSuggestionsSheet.Cells[19, 1] = "";
            departmentalSuggestionsSheet.Cells[19, 2] = "Departmental Suggestions";

            departmentalSuggestionsSheet.Cells[20, 1] = suggestTitle;
            departmentalSuggestionsSheet.Cells[20, 2] = suggestTopRanking;

            departmentalSuggestionsSheet.Cells[20, 3] = suggestBody;

            departmentalSuggestionsSheet.Cells[21, 1] = "Bi-Monthly Town Hall with Senior Management";
            departmentalSuggestionsSheet.Cells[21, 2] = "17";

            departmentalSuggestionsSheet.Cells[21, 3] = "It would be easier to manage time and tasks if senior management routinely informed the department about new integrations and changes to the department.";

            departmentalSuggestionsSheet.Cells[22, 1] = "Healthy Eating Incentives";
            departmentalSuggestionsSheet.Cells[22, 2] = "14";

            departmentalSuggestionsSheet.Cells[22, 3] = "It would be neat if employees received health insurance discounts and other perks for eating healthy. Everyone would benefit.";

            departmentalSuggestionsSheet.Cells[23, 1] = "Mentorship Program ";
            departmentalSuggestionsSheet.Cells[23, 2] = "9";

            departmentalSuggestionsSheet.Cells[23, 3] = "As a senior employee I would like to offer the opportunity to mentor new hires. I think it could be a good idea if we created a mentorship program where senior employees can be available to help new hires transtition succesfully into our department ";

            departmentalSuggestionsSheet.Cells[24, 1] = "Casual Fridays ";
            departmentalSuggestionsSheet.Cells[24, 2] = "6";

            departmentalSuggestionsSheet.Cells[24, 3] = "I think it could be a good idea to implement casual Fridays in our office. I have recently read of the success a lot of companies are having with this implementation and I think it could be a good idea ";

            Excel.Range chartRange;
            Excel.Range departmentRange;
            Excel.Range departmentSuggestRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)previousImplementationsSheet.ChartObjects();
            Excel.ChartObjects departmentCharts = (Excel.ChartObjects)departmentalIssuesSheet.ChartObjects();
            Excel.ChartObjects departmentSuggestCharts = (Excel.ChartObjects)departmentalSuggestionsSheet.ChartObjects();

            Excel.ChartObject myChart = xlCharts.Add(10, 10, 350, 250);
            Excel.ChartObject departChart = departmentCharts.Add(10, 10, 350, 250);
            Excel.ChartObject departSugChart = departmentSuggestCharts.Add(10, 10, 350, 250);

            Excel.Chart chartPage = myChart.Chart;

            Excel.Chart departPage = departChart.Chart;

            Excel.Chart departSugPage = departSugChart.Chart;

            chartRange = previousImplementationsSheet.get_Range("A19", "b24");
            departmentRange = departmentalIssuesSheet.get_Range("A19", "b24");
            departmentSuggestRange = departmentalSuggestionsSheet.get_Range("A19","b24");

            chartPage.SetSourceData(chartRange, misValue);
            departPage.SetSourceData(departmentRange, misValue);
            departSugPage.SetSourceData(departmentSuggestRange, misValue);

            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
            departPage.ChartType = Excel.XlChartType.xlColumnClustered;
            departSugPage.ChartType = Excel.XlChartType.xlColumnClustered;

            Excel.Application excelApp = new Excel.Application();

            xlWorkBook.SaveAs("ManagerReport.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            // replace with presenters excel location
            //System.Diagnostics.Process.Start(@"C:\Users\russe\Documents\ManagerReport.xls");
        }

        private void PostBoard_Load(object sender, System.EventArgs e)
        {

            listOfImplementationPosts = new BindingList<Post>();
            listBoxImplementations.DataSource = listOfImplementationPosts;
            listOfIssuePosts = new BindingList<Post>();
            listBoxIssues.DataSource = listOfIssuePosts;
            listOfSuggestionPosts = new BindingList<Post>();
            listBoxSuggestions.DataSource = listOfSuggestionPosts;
            voteStatusLabel.Visible = false;
            timer1.Interval = 1000;
            

    }

    private void CheckBoxIsManager_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBoxIsManager.Checked == true)
            {
                buttonGenerateReport.Visible = true;
            }
            else
            {
                buttonGenerateReport.Visible = false;
            }
        }

        private void ListBoxImplementations_DoubleClick(object sender, System.EventArgs e)
        {
            LBHandler(listBoxImplementations);
        }

        private void ListBoxIssues_DoubleClick(object sender, System.EventArgs e)
        {
            LBHandler(listBoxIssues);
        }

        private void ListBoxSuggestions_DoubleClick(object sender, System.EventArgs e)
        {
            LBHandler(listBoxSuggestions);
        }

        private void LBHandler(ListBox listBox)
        {
            if (listBox.SelectedItem == null)
            {
                return;
            }

            selectedPost = (Post)listBox.SelectedItem;

            viewPost = new ViewPost();
            viewPost.PopulateData(selectedPost);
            viewPost.ShowDialog();
        }

        private void LBHandlerVotes(ListBox listBox)
        {
            pictureBoxUpvote.Enabled = true;
            pictureBoxDownvote.Enabled = true;
            labelCount.Enabled = true;

            if (listBox.SelectedItem == null)
            {
                return;
            }

            selectedPost = (Post)(listBox.SelectedItem);
            labelCount.Text = selectedPost.PostVotes.ToString();

            if (selectedPost.PostVotes == 1)
            {
                pictureBoxUpvote.Image = Properties.Resources.upArrowVoted;
                pictureBoxDownvote.Image = Properties.Resources.downArrowBase;
            }
            else if (selectedPost.PostVotes == 0 )
            {
                pictureBoxUpvote.Image = Properties.Resources.upArrowBase;
                pictureBoxDownvote.Image = Properties.Resources.downArrowBase;
            }
            else
            {
                pictureBoxUpvote.Image = Properties.Resources.upArrowBase;
                pictureBoxDownvote.Image = Properties.Resources.downArrowVoted;
            }
        }

        private void PictureBoxUpvote_Click(object sender, EventArgs e)
        {
            pictureBoxDownvote.Image = Properties.Resources.downArrowBase;

            if (selectedPost.PostVotes < 1)
            {
                selectedPost.PostVotes = 1;
                labelCount.Text = Convert.ToString(selectedPost.PostVotes);
                pictureBoxUpvote.Image = Properties.Resources.upArrowVoted;
            }
            else
            {
                selectedPost.PostVotes = 0;
                labelCount.Text = Convert.ToString(selectedPost.PostVotes);
                pictureBoxUpvote.Image = Properties.Resources.upArrowBase;
            }
            
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            voteStatusLabel.Visible = true;
            timer1.Start();
        }

        private void PictureBoxDownvote_Click(object sender, EventArgs e)
        {
            int voteCount = ToInt32(labelCount.Text);
            pictureBoxUpvote.Image = Properties.Resources.upArrowBase;

            if (voteCount >= 0)
            {
                selectedPost.PostVotes = -1;
                labelCount.Text = Convert.ToString(selectedPost.PostVotes);
                pictureBoxDownvote.Image = Properties.Resources.downArrowVoted;
            }
            else
            {
                selectedPost.PostVotes = 0;
                labelCount.Text = Convert.ToString(selectedPost.PostVotes);
                pictureBoxDownvote.Image = Properties.Resources.downArrowBase;
            }
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            voteStatusLabel.Visible = true;
            timer1.Start();
        }

        private void ListBoxImplementations_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxImplementations.SelectionMode = SelectionMode.One;
            LBHandlerVotes(listBoxImplementations);
            listBoxIssues.SelectionMode = SelectionMode.None;
            listBoxSuggestions.SelectionMode = SelectionMode.None;
        }

        private void ListBoxIssues_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxIssues.SelectionMode = SelectionMode.One;
            LBHandlerVotes(listBoxIssues);
            listBoxImplementations.SelectionMode = SelectionMode.None;
            listBoxSuggestions.SelectionMode = SelectionMode.None;
        }

        private void ListBoxSuggestions_SelectedValueChanged(object sender, EventArgs e)
        {
            listBoxSuggestions.SelectionMode = SelectionMode.One;
            LBHandlerVotes(listBoxSuggestions);
            listBoxImplementations.SelectionMode = SelectionMode.None;
            listBoxIssues.SelectionMode = SelectionMode.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            voteStatusLabel.Visible = false;

        }
    }
}
