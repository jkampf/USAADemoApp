using System.ComponentModel;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Convert;

namespace USAADemoApp
{
    public partial class PostBoard : Form
    {
        public PostBoard() => InitializeComponent();

        Post selectedPost;
        Post currentPost;
        SubmitPost submitPost;
        ViewPost viewPost;
        ListBox ListBox;

        BindingList<Post> listOfImplementationPosts;
        BindingList<Post> listOfIssuePosts;
        BindingList<Post> listOfSuggestionPosts;

        private bool upVote = false;
        private bool downVote = false;
        private int voteCount;
        private object listBox;

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
            previousImplementationsSheet.Cells[1, 1] = "";
            previousImplementationsSheet.Cells[1, 2] = "Previous Implementation Issues";

            previousImplementationsSheet.Cells[2, 1] = "Issue 1";
            previousImplementationsSheet.Cells[2, 2] = "100";

            previousImplementationsSheet.Cells[2, 3] = "Full Issue 1 Information (body)";

            previousImplementationsSheet.Cells[3, 1] = "Issue 2";
            previousImplementationsSheet.Cells[3, 2] = "88";

            previousImplementationsSheet.Cells[3, 3] = "Full Issue 2 Information (body)";

            previousImplementationsSheet.Cells[4, 1] = "Issue 3";
            previousImplementationsSheet.Cells[4, 2] = "44";

            previousImplementationsSheet.Cells[4, 3] = "Full Issue 3 Information (body)";

            previousImplementationsSheet.Cells[5, 1] = "Issue 4";
            previousImplementationsSheet.Cells[5, 2] = "30";

            previousImplementationsSheet.Cells[5, 3] = "Full Issue 4 Information (body)";

            previousImplementationsSheet.Cells[6, 1] = "Issue 5";
            previousImplementationsSheet.Cells[6, 2] = "12";

            previousImplementationsSheet.Cells[6, 3] = "Full Issue 5 Information (body)";

            departmentalIssuesSheet.Cells[1, 1] = "";
            departmentalIssuesSheet.Cells[1, 2] = "Departmental Issues";

            departmentalIssuesSheet.Cells[2, 1] = "Issue 1";
            departmentalIssuesSheet.Cells[2, 2] = "56";

            departmentalIssuesSheet.Cells[2, 3] = "Full Issue 1 Information (body)";

            departmentalIssuesSheet.Cells[3, 1] = "Issue 2";
            departmentalIssuesSheet.Cells[3, 2] = "32";

            departmentalIssuesSheet.Cells[3, 3] = "Full Issue 2 Information (body)";

            departmentalIssuesSheet.Cells[4, 1] = "Issue 3";
            departmentalIssuesSheet.Cells[4, 2] = "10";

            departmentalIssuesSheet.Cells[4, 3] = "Full Issue 3 Information (body)";

            departmentalIssuesSheet.Cells[5, 1] = "Issue 4";
            departmentalIssuesSheet.Cells[5, 2] = "8";

            departmentalIssuesSheet.Cells[5, 3] = "Full Issue 4 Information (body)";

            departmentalIssuesSheet.Cells[6, 1] = "Issue 5";
            departmentalIssuesSheet.Cells[6, 2] = "4";

            departmentalIssuesSheet.Cells[6, 3] = "Full Issue 5 Information (body)";

            departmentalSuggestionsSheet.Cells[1, 1] = "";
            departmentalSuggestionsSheet.Cells[1, 2] = "Departmental Suggestions";

            departmentalSuggestionsSheet.Cells[2, 1] = "Issue 1";
            departmentalSuggestionsSheet.Cells[2, 2] = "89";

            departmentalSuggestionsSheet.Cells[2, 3] = "Full Issue 1 Information (body)";

            departmentalSuggestionsSheet.Cells[3, 1] = "Issue 2";
            departmentalSuggestionsSheet.Cells[3, 2] = "85";

            departmentalSuggestionsSheet.Cells[3, 3] = "Full Issue 2 Information (body)";

            departmentalSuggestionsSheet.Cells[4, 1] = "Issue 3";
            departmentalSuggestionsSheet.Cells[4, 2] = "70";

            departmentalSuggestionsSheet.Cells[4, 3] = "Full Issue 3 Information (body)";

            departmentalSuggestionsSheet.Cells[5, 1] = "Issue 4";
            departmentalSuggestionsSheet.Cells[5, 2] = "36";

            departmentalSuggestionsSheet.Cells[5, 3] = "Full Issue 4 Information (body)";

            departmentalSuggestionsSheet.Cells[6, 1] = "Issue 5";
            departmentalSuggestionsSheet.Cells[6, 2] = "22";

            departmentalSuggestionsSheet.Cells[6, 3] = "Full Issue 1 Information (body)";

            Excel.Range chartRange;
            Excel.Range departmentRange;
            Excel.Range departmentSuggestRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)previousImplementationsSheet.ChartObjects();
            Excel.ChartObjects departmentCharts = (Excel.ChartObjects)departmentalIssuesSheet.ChartObjects();
            Excel.ChartObjects departmentSuggestCharts = (Excel.ChartObjects)departmentalSuggestionsSheet.ChartObjects();

            Excel.ChartObject myChart = xlCharts.Add(10, 120, 350, 250);
            Excel.ChartObject departChart = departmentCharts.Add(10, 120, 350, 250);
            Excel.ChartObject departSugChart = departmentSuggestCharts.Add(10, 120, 350, 250);

            Excel.Chart chartPage = myChart.Chart;

            Excel.Chart departPage = departChart.Chart;

            Excel.Chart departSugPage = departSugChart.Chart;

            chartRange = previousImplementationsSheet.get_Range("A1", "b6");
            departmentRange = departmentalIssuesSheet.get_Range("A1", "b6");
            departmentSuggestRange = departmentalSuggestionsSheet.get_Range("A1","b6");

            chartPage.SetSourceData(chartRange, misValue);
            departPage.SetSourceData(departmentRange, misValue);
            departSugPage.SetSourceData(departmentSuggestRange, misValue);

            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
            departPage.ChartType = Excel.XlChartType.xlColumnClustered;
            departSugPage.ChartType = Excel.XlChartType.xlColumnClustered;

            Excel.Application excelApp = new Excel.Application();

            xlWorkBook.SaveAs("ManagerReport.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
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

        //private void pictureBoxUpvote_Click(object sender, System.EventArgs e)
        //{
        //    if (downVote == true)
        //    {
        //        voteCount += 1;
        //        downVote = false;

        //    }
        //}

        //private void pictureBoxDownvote_Click(object sender, System.EventArgs e)
        //{
        //    if (downVote == true)
        //    {
        //        voteCount -= 1;
        //        upVote = false;
        //        downVote = true;
        //    }

        //    else
        //    {
        //        voteCount += 1;
        //        upVote = true;

        //    }
        //}

        private void pictureBoxUpvote_Click_1(object sender, System.EventArgs e)
        {
             currentPost = (Post)ListBox.SelectedItem;
            int voteCount = ToInt32(labelCount.Text);
            voteCount = ToInt32(labelCount.Text);

            if (downVote == true)
            {
                voteCount += 2;
                voteCount += 1;
                labelCount.Text = System.Convert.ToString(voteCount);
                downVote = false;
                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
            }

            else if (downVote == false)
            {
                voteCount -= 1;
                labelCount.Text = System.Convert.ToString(voteCount);
                downVote = true;
                upVote = false;

                pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowVoted;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;
            }

           currentPost.PostVotes = voteCount;

        }

        private void pictureBoxDownvote_Click(object sender, System.EventArgs e)
        {
            currentPost = (Post)ListBox.SelectedItem;
            int voteCount = ToInt32(labelCount.Text);
            if (upVote == true)
                voteCount = ToInt32(labelCount.Text);
            if (downVote == true)
            {
                voteCount -= 1;
                labelCount.Text = System.Convert.ToString(voteCount);
                upVote = false;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowBasae;
            }

            else
            {
                voteCount += 1;
                pictureBoxDownvote.BackgroundImage = Properties.Resources.upArrowVoted;
            pictureBoxUpvote.BackgroundImage = Properties.Resources.downArrowBase;
        }

    currentPost.PostVotes = voteCount;
        }
    }
}
