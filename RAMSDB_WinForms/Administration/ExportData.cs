using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using RAMSDB.Data;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using Ionic.Zip;

namespace RAMSDB_WinForms.Administration
{
    public partial class ExportData : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        string userMaintenanceBranch;

        public Guid userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        public string[] years = LinqHelper.ListofYearsGC();
        public int _year = LinqHelper.ECYear();// DateTime.Now.Year;


        public ExportData()
        {
            InitializeComponent();
            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());


            /// Check why this is important!
            userMaintenanceBranch = dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).
                Select(c => c.RoadsGISData.MaintenanceBranch).FirstOrDefault() ==null ? "Maintenance Branch": dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).
                Select(c => c.RoadsGISData.MaintenanceBranch).FirstOrDefault().ToString();


        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            // ExportDataToExcel();
            ExportDataToZip();




        }

        private void ExportDataToExcel()
        {
            DataSet dataSet = new DataSet();
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            string filePath = "";

         
               // splashScreenManager1.SetWaitFormDescription = 
                DataTable unpavedRCS = LinqHelper.DataTable
                    (dbContext,
                    "SELECT * FROM [dbo].[UnpavedRoadConditionSurvey] where [UserID] = @uID and [RCSYear]=@year",
                    new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
                    new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
                    );
                unpavedRCS.TableName = "UnpavedRoadConditionSurvey";

                DataTable pavedRCS = LinqHelper.DataTable
                   (dbContext,
                   "SELECT * FROM [dbo].[PavedRoadConditionSurvey] where [UserID] = @uID and [PRCSYear]=@year",
                   new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
                   new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
                   );
                pavedRCS.TableName = "PavedRoadConditionSurvey";

           
                DataTable multiCriteriaData = LinqHelper.DataTable
                 (dbContext,
                 "SELECT * FROM [RAMSDB].[dbo].[MultiCriteriaAnalysisData] mc " +
                 "where [Year] = @year and  mc.[RoadID] in (select [RoadID] from [RAMSDB].[dbo].[RoadsPerUser]" +
                 "where [UserID] = @uID)",
                 new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
                 new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
                 );

                multiCriteriaData.TableName = "MultiCriteriaData";

             
                DataTable trafficSurvey = LinqHelper.DataTable
                (dbContext,
                "SELECT * FROM [RAMSDB].[dbo].[TrafficSurvey] ts " +
                "where [TrafficSurveyYear] = @year and  ts.[RoadID] in " +
                "(select [RoadID] from [dbo].[RoadsPerUser]" +
                "where [UserID] = @uID)",
                new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
                new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
                );

                trafficSurvey.TableName = "TrafficSurvey";


           

            


            

            dataSet.Tables.Add(unpavedRCS);
            dataSet.Tables.Add(pavedRCS);
            dataSet.Tables.Add(multiCriteriaData);
            dataSet.Tables.Add(trafficSurvey);

        
            

            //if (!splashScreenManager2.IsSplashFormVisible)
            //{
            //    splashScreenManager2.ShowWaitForm();
            //    splashScreenManager2.SetWaitFormCaption("Exporting Data");
            //    splashScreenManager2.SetWaitFormDescription("Please wait...");

                 filePath = dataSet.ExportToExcel(yearFilter.ToString());

          //  }

            if (splashScreenManager2.IsSplashFormVisible)
                splashScreenManager2.CloseWaitForm();

            if (filePath != "Nothing to Export")
            {
                lblExportOutput.Text = "Data successfully exported! You can find the excel file in..." +
                               Environment.NewLine +
                               filePath;
            }
            else
            {
                lblExportOutput.Text = filePath;
            }

           
            //lblFilePath.Text = "Data successfully exported! You can find the excel file in..." +
            //                    Environment.NewLine +
            //                    filePath;

            ShowFile(filePath);
        }

        private void ExportDataToZip()
        {

            DataSet dataSet = new DataSet();
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            string filePath = "";


            // splashScreenManager1.SetWaitFormDescription = 
            DataTable unpavedRCS = LinqHelper.DataTable
                (dbContext,
                "SELECT * FROM [dbo].[UnpavedRoadConditionSurvey] where [UserID] = @uID and [RCSYear]=@year",
                new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
                new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
                );
            unpavedRCS.TableName = "UnpavedRoadConditionSurvey";

            DataTable pavedRCS = LinqHelper.DataTable
               (dbContext,
               "SELECT * FROM [dbo].[PavedRoadConditionSurvey] where [UserID] = @uID and [PRCSYear]=@year",
               new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
               new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
               );
            pavedRCS.TableName = "PavedRoadConditionSurvey";


            DataTable multiCriteriaData = LinqHelper.DataTable
             (dbContext,
             "SELECT * FROM [RAMSDB].[dbo].[MultiCriteriaAnalysisData] mc " +
             "where [Year] = @year and  mc.[RoadID] in (select [RoadID] from [RAMSDB].[dbo].[RoadsPerUser]" +
             "where [UserID] = @uID)",
             new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
             new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
             );

            multiCriteriaData.TableName = "MultiCriteriaData";


            DataTable trafficSurvey = LinqHelper.DataTable
            (dbContext,
            "SELECT * FROM [RAMSDB].[dbo].[TrafficSurvey] ts " +
            "where [TrafficSurveyYear] = @year and  ts.[RoadID] in " +
            "(select [RoadID] from [dbo].[RoadsPerUser]" +
            "where [UserID] = @uID)",
            new SqlParameter("uID", SqlDbType.UniqueIdentifier) { Value = userID },
            new SqlParameter("year", SqlDbType.Int) { Value = yearFilter }
            );

            trafficSurvey.TableName = "TrafficSurvey";


            string archiveName = userMaintenanceBranch + "_" +
               yearFilter + "DataExportedOn_" +
               DateTime.Now.Year.ToString() +
               DateTime.Now.Month.ToString() +
               DateTime.Now.Day.ToString() + "_" +
               DateTime.Now.Hour.ToString() + "_" +
               DateTime.Now.Minute.ToString() +

                ".zip";

         

            string archivePath = myDocPath + "\\" + archiveName;

            using (ZipFile zip = new ZipFile())
            {
                zip.AddEntry("UnpavedRoadConditionSurvey.csv", unpavedRCS.ToCsv());
                zip.AddEntry("PavedRoadConditionSurvey.csv", pavedRCS.ToCsv());
                zip.AddEntry("MultiCriteriaData.csv", multiCriteriaData.ToCsv());
                zip.AddEntry("TrafficSurvey.csv", trafficSurvey.ToCsv());
                //  zip.AddEntry("readings/Index.xml", stringContent3);
                zip.Save(archivePath);
            }

         
            if (filePath != "Nothing to Export")
            {
                lblExportOutput.Text = "Data successfully exported! You can find the exported file in..." +
                               Environment.NewLine +
                               archivePath;
            }
            else
            {
                lblExportOutput.Text = archivePath;
            }



            ShowFile(archivePath);




        }

        void ShowFile(string fileName)
        {
            if (!File.Exists(fileName))
                return;
            DialogResult dResult = MessageBox.Show(String.Format("Do you want to open the resulting file?", fileName),
                this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dResult == DialogResult.Yes)
                Process.Start(fileName);
        }

        //string OpenExcel()
        //{
        //    var filePath = string.Empty;

        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.InitialDirectory = "c:\\";
        //        openFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx";
        //        // openFileDialog.FilterIndex = 2;
        //        //  openFileDialog.RestoreDirectory = true;

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            //Get the path of specified file
        //            filePath = openFileDialog.FileName;

        //            //Read the contents of the file into a stream

        //        }
        //        return filePath;
        //    }

        //    //  MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        //}
    }
}