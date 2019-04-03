using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace USAADemoApp
{
    public partial class PostBoard : Form
    {
        public PostBoard() => InitializeComponent();


        private void ButtonNewPost_Click(object sender, System.EventArgs e)
        {   

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

            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 120, 350, 250);
            Excel.ChartObject departChart = (Excel.ChartObject)departmentCharts.Add(10, 120, 350, 250);
            Excel.ChartObject departSugChart = (Excel.ChartObject)departmentSuggestCharts.Add(10, 120, 350, 250);

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
    }
}
