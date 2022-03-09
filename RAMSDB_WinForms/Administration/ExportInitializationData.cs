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
    public partial class ExportInitializationData : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm //DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Guid userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string userRegion = RAMSDBDataLoader.LoggedInUser.userRegion;//.LoginInfo.GetLoggedInUser.Region;

        public string[] years = LinqHelper.ListofYearsGC();
        public int _year = LinqHelper.ECYear();// DateTime.Now.Year;


        public ExportInitializationData()
        {
            InitializeComponent();
          
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            //  ExportDataToExcel();
            ExportDataToZip();




        }

        private void ExportDataToExcel()
        {
            DataSet dataSet = new DataSet();
            string filePath = "";
            //if (!splashScreenManager3.IsSplashFormVisible)
            //{
            //    splashScreenManager3.ShowWaitForm();
            //    splashScreenManager3.SetWaitFormCaption("Exporting Data");
            //    splashScreenManager3.SetWaitFormDescription("Please wait...");

            //[Shape].STAsText()as Shape

            // splashScreenManager1.SetWaitFormDescription = 
            DataTable roadGISData = LinqHelper.DataTable
                (dbContext,
                "SELECT RoadID,Shape,ObjectID,RoadLengthInKm,RoadIdentifier,RoadOwner,RoadOriginName,RoadDestinationName,OriginDestDescription,GravelThickness,RoadClassID,RoadType,SurfaceType,CarriagewayWidth,RoadConstructedYear,AdminID,RegionName,IsActive,ShapeID,RoadOriginDestination FROM [dbo].[RoadsGISData] where [RegionName] = @rName  ",
                new SqlParameter("rName", SqlDbType.NVarChar) { Value = userRegion  }
                );

            // and [RoadID] = @rID, new SqlParameter("rID", SqlDbType.UniqueIdentifier) { Value = Guid.Parse("de86a4b8-ccb6-41aa-8d08-01b9bb5b3978")
            //DataTable roadGISData = LinqHelper.DataTable
            //   (dbContext,
            //   "SELECT RoadID FROM [dbo].[RoadsGISData] where [RegionName] = @rName ",
            //   new SqlParameter("rName", SqlDbType.NVarChar) { Value = userRegion }
            //   );

            //DataTable roadGISData = LinqHelper.DataTable
            //   (dbContext,
            //   "SELECT * FROM [dbo].[RoadsGISData] where [RegionName] = @rName ",
            //   new SqlParameter("rName", SqlDbType.NVarChar) { Value = userRegion }
            //   );

            roadGISData.TableName = "ListofRoads";

            // string filename = OpenSavefileDialog();
            //dt.ToCSV(filename);
            //filePath = "D:\\Temp\\roadGISData.csv";
            //File.WriteAllText(filePath, roadGISData.ToCsv());
            ////roadGISData.ToCsv();

            DataTable userList = LinqHelper.DataTable
                   (dbContext,
                   "SELECT * FROM [dbo].[User] where [Region] = @rName ",
                   new SqlParameter("rName",SqlDbType.VarChar) { Value = userRegion }
                   );
            userList.TableName = "ListofUsers";

            //filePath = "D:\\Temp\\userList.csv";
            //File.WriteAllText(filePath, userList.ToCsv());



            DataTable roadsPerUsers = LinqHelper.DataTable
             (dbContext,
             "SELECT * FROM [dbo].[RoadsPerUser] mc " +
             "where    mc.[UserID] in (select [UserID] from [dbo].[User]" +
             "where [Region] = @rName)",
             new SqlParameter("rName", SqlDbType.VarChar) { Value = userRegion }
             );



            //DataTable roadsPerUsers = LinqHelper.DataTable
            //(dbContext,
            //"SELECT AdminID FROM [RAMSDB].[dbo].[RoadsPerUser]" 
            //);

            roadsPerUsers.TableName = "RoadsPerUsers";

            //filePath = "D:\\Temp\\roadsPerUsers.csv";
            //File.WriteAllText(filePath, userList.ToCsv());



            //DataTable trafficSurvey = LinqHelper.DataTable
            //(dbContext,
            //"SELECT * FROM [RAMSDB].[dbo].[TrafficSurvey] ts " +
            //"where  ts.[RoadID] in " +
            //"(select [RoadID] from [RAMSDB].[dbo].[RoadsPerUser]" +
            //"where [UserID] = @uID)",
            //new SqlParameter("uID", SqlDbType.Int) { Value = userID }
            //);

            //trafficSurvey.TableName = "TrafficSurvey";


         //   var ttt = roadsPerUsers.Rows.Count;
           






            dataSet.Tables.Add(roadGISData);
           dataSet.Tables.Add(userList);
            dataSet.Tables.Add(roadsPerUsers);
            //dataSet.Tables.Add(trafficSurvey);

        
            

          

              //!!!!!!!!!!! - change Later
                filePath = dataSet.InitializationDataExportToExcel();

           // }

            if (splashScreenManager4.IsSplashFormVisible)
                splashScreenManager4.CloseWaitForm();

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

            //lblExportOutput.Text = "Data successfully exported! You can find the excel file in..." +
            //                    Environment.NewLine +
            //                    filePath;
            ////lblFilePath.Text = "Data successfully exported! You can find the excel file in..." +
            //                    Environment.NewLine +
            //                    filePath;

            ShowFile(filePath);
        }

        private void ExportDataToZip()
        {
            DataSet dataSet = new DataSet();
            string filePath = "";
           
            DataTable roadGISData = LinqHelper.DataTable
                (dbContext,
                "SELECT RoadID,Shape.MakeValid().ToString() as Shape,ObjectID,RoadLengthInKm,RoadIdentifier,RoadOwner,RoadOriginName,RoadDestinationName,OriginDestDescription,GravelThickness,RoadClassID,RoadType,SurfaceType,CarriagewayWidth,RoadConstructedYear,AdminID,RegionName,IsActive,ShapeID,RoadOriginDestination FROM [dbo].[RoadsGISData] where [RegionName] = @rName  ",
                new SqlParameter("rName", SqlDbType.NVarChar) { Value = userRegion }
                );


            roadGISData.TableName = "ListofRoads";

           
            //filePath = "D:\\Temp\\roadGISData.csv";
            //File.WriteAllText(filePath, roadGISData.ToCsv());
            ////roadGISData.ToCsv();

            DataTable userList = LinqHelper.DataTable
                   (dbContext,
                   "SELECT * FROM [dbo].[User] where [Region] = @rName ",
                   new SqlParameter("rName", SqlDbType.VarChar) { Value = userRegion }
                   );
            userList.TableName = "ListofUsers";

            //filePath = "D:\\Temp\\userList.csv";
            //File.WriteAllText(filePath, userList.ToCsv());



            DataTable roadsPerUsers = LinqHelper.DataTable
             (dbContext,
             "SELECT * FROM [dbo].[RoadsPerUser] mc " +
             "where    mc.[UserID] in (select [UserID] from [dbo].[User]" +
             "where [Region] = @rName)",
             new SqlParameter("rName", SqlDbType.VarChar) { Value = userRegion }
             );



          

            roadsPerUsers.TableName = "RoadsPerUsers";

            //filePath = "D:\\Temp\\roadsPerUsers.csv";
            //File.WriteAllText(filePath, userList.ToCsv());

            string archiveName = userRegion + "_" +
                    LinqHelper.ECYear().ToString() + "DataExportedOn_" +
                    DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() +
                    DateTime.Now.Day.ToString() + "_" +
                    DateTime.Now.Hour.ToString() + "_" +
                    DateTime.Now.Minute.ToString() +

                     ".zip";

            string archivePath = myDocPath + "\\" + archiveName;

            using (ZipFile zip = new ZipFile())
            {
                zip.AddEntry("ListofRoads.csv", roadGISData.ToCsv());
                zip.AddEntry("ListofUsers.csv", userList.ToCsv());
                zip.AddEntry("RoadsPerUsers.csv", roadsPerUsers.ToCsv());
                //  zip.AddEntry("readings/Index.xml", stringContent3);
                zip.Save(archivePath);
            }




            // }

            if (splashScreenManager4.IsSplashFormVisible)
                splashScreenManager4.CloseWaitForm();

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