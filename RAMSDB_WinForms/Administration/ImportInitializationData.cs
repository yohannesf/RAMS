using DevExpress.DataProcessing;
using DevExpress.Export.Xl;
using Microsoft.VisualBasic.FileIO;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace RAMSDB_WinForms.Administration
{
   

    public partial class ImportInitializationData : DevExpress.XtraBars.Ribbon.RibbonForm// DevExpress.XtraEditors.XtraUserControl // 
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public Guid userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        public string[] years = LinqHelper.ListofYearsGC();
        public int _year = DateTime.Now.Year;

        public ImportInitializationData()
        {
            InitializeComponent();
           

        }

        string OpenExcel()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx";
                // openFileDialog.FilterIndex = 2;
                //  openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream

                }
                return filePath;
            }

            //  MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        string OpenCSV()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = myDocPath;// "c:\\";
                openFileDialog.Filter = "CSV Files(.csv)|*.csv";
                openFileDialog.Title = "Import data";
               
                // openFileDialog.FilterIndex = 2;
                //  openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream

                }
                return filePath;
            }

            //  MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }
        
        string OpenZip()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = myDocPath;// "c:\\";
                openFileDialog.Filter = "Zip Files(.zip)|*.zip";
                openFileDialog.Title = "Import data";

                // openFileDialog.FilterIndex = 2;
                //  openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream

                }
                return filePath;
            }

            //  MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        public void GetDataTableOfExcel(string file_path)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["RAMSDBEntitiesConnectionString"].ToString();

            DataSet dataSet = new DataSet();
            if (!splashScreenManager3.IsSplashFormVisible)
            {
                splashScreenManager3.ShowWaitForm();
                splashScreenManager3.SetWaitFormCaption("Importing Data");
                splashScreenManager3.SetWaitFormDescription("Please wait...");


                using (OleDbConnection conn = new OleDbConnection())
                {

                    DataTable xlTable = new DataTable();


                    string Import_FileName = file_path;
                    //Import_FileName = System.IO.Path.GetDirectoryName(file_path);
                    string fileExtension = Path.GetExtension(Import_FileName);
                    if (fileExtension == ".xlsx")
                        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";

                    conn.Open();

                    xlTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    System.String strExcelSheetNames = "";
                    string sheetName;
                    //Loop through the excel database table names and take only 
                    //the tables that ends with a $ characters. Other tables are not worksheets...
                    for (int lngStart = 0; lngStart < xlTable.Rows.Count; lngStart++)
                    {
                        //Remove the single-quote surrounding the table name...
                        sheetName = xlTable.Rows[lngStart][2].ToString().Replace("'", "");
                        if (sheetName.EndsWith("$")) //Yes, this is a worksheet
                        {
                            //concatenate with a single-quote delimeter... to be returned 
                            //as a string array later using the split function
                            strExcelSheetNames += sheetName.Substring(0, sheetName.Length - 1) + "~";
                        }
                    }

                    if (strExcelSheetNames.EndsWith("~"))
                    //the last single quote needs to be removed 
                    //so that the array index ends with the last sheetname
                    {
                        strExcelSheetNames = strExcelSheetNames.Substring(0,
                                                strExcelSheetNames.Length - 1);
                    }

                    conn.Close();
                    // conn.Dispose();

                    char[] chrDelimter = { '~' };
                    var xlSheets = strExcelSheetNames.Split(chrDelimter);


                    conn.Open();
                    foreach (string sheet in xlSheets)
                    {
                        DataTable dt = new DataTable();
                        using (OleDbCommand comm = new OleDbCommand())
                        {
                            comm.CommandText = "Select * from [" + sheet + "$]";
                            comm.Connection = conn;
                            using (OleDbDataAdapter da = new OleDbDataAdapter())
                            {
                                da.SelectCommand = comm;
                                da.Fill(dt);
                            }


                        }
                        dt.TableName = sheet;
                        dataSet.Tables.Add(dt);

                    }

                    conn.Close();
                    conn.Dispose();
                    var x = dataSet.Tables.Count;// dt.Rows.Count;
                    var z = 1;

                    //   CustomersEntities entities = new CustomersEntities();



                }

                foreach (DataTable dataTable in dataSet.Tables)
                {

                    // tc.Connection.Open()



                    switch (dataTable.TableName)
                    {

                        case "ListofRoads":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                                RoadsGISData mc = new RoadsGISData();

                                mc = row.Cast<RoadsGISData>();
                                // dbContext.RoadsGISData.Add(mc);
                               // dbContext.RoadsGISData.AddOrUpdate(mc);
                                dbContext.Set<RoadsGISData>().
                                    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                                    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName);
                              //  dbContext.SaveChanges();
                            }
                            break;

                        case "ListofUsers":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                //using (RAMSDBEntities tc = new RAMSDBEntities())
                                //{
                                   
                                //    using (TransactionScope scope = new TransactionScope())
                                //    {
                                //        tc.Database.Connection.Open();
                                //        tc.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [RAMSDB].[dbo].[User] ON");
                                //User mc = new User();

                                //mc = row.Cast<User>();
                                //var tt = new User()
                                //{
                                //    UserID = 158,
                                //    UserName = mc.UserName,
                                //    Password = mc.Password,
                                //    IsActive = mc.IsActive,
                                //    RoleID = mc.RoleID,
                                //    Region = mc.Region
                                //};
                                //tc.User.Add(tt);
                                //        tc.SaveChanges();

                                //        tc.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [RAMSDB].[dbo].[User] OFF");
                                //        scope.Complete();
                                //    }
                                //}
                                splashScreenManager3.SetWaitFormCaption("Importing List of Users");
                                User mc = new User();



                                mc = row.Cast<User>();
                                dbContext.Set<User>().AddIfNotExists(mc, x => x.UserName == mc.UserName);
                              //  dbContext.Users.AddObject(mc);
                                //dbContext.SaveChanges();
                                //  tc.Set<User>().AddIfNotExists(tt, x => x.UserName == tt.UserName);
                                // var y = dbContext.Set<User>().AddIfNotExists(mc, x => x.UserName == mc.UserName);
                               //  dbContext.User.Add(mc);

                            }
                            break;

                        case "RoadsPerUsers":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager3.SetWaitFormCaption("Importing Roads Per Users");
                                RoadsPerUser mc = new RoadsPerUser();

                                mc = row.Cast<RoadsPerUser>();
                                dbContext.Set<RoadsPerUser>().AddIfNotExists(mc, x => x.UserID == mc.UserID && x.RoadID == mc.RoadID && x.AdminID == mc.AdminID);
                              //  dbContext.SaveChanges();
                                //dbContext.RoadsPerUser.Add(mc);


                            }
                            break;


                        default:
                            {
                                MessageBox.Show("The Excel file imported is the wrong format!", "Incorrect Format", MessageBoxButtons.OK);
                                if (splashScreenManager3.IsSplashFormVisible)
                                    splashScreenManager3.CloseWaitForm();
                                return;
                            }
                            break;
                    }


                }
                

            }

            if (splashScreenManager3.IsSplashFormVisible)
                splashScreenManager3.CloseWaitForm();

            dbContext.SaveChanges();
            MessageBox.Show("Data Imported Successfully!");

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            /*********For Excel
            string filePath = OpenExcel();

            if (filePath != null)
            {
                GetDataTableOfExcel(filePath);
            }
            */
            //string filePath = OpenCSV();

            //if (filePath != null)
            //{
            //    ImportFromCSV(filePath);
            //}

            string filePath = OpenZip();

            if (filePath != null)
            {
                ImportFromZip(filePath);
            }
        }

        private void ImportInitializationData_Load(object sender, EventArgs e)
        {

        }

        private void ImportFromCSV(string fileName)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            DataTable csvData = new DataTable();

            try
            {

                using (TextFieldParser csvReader = new TextFieldParser(fileName))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            if (fileName == "ListofRoads")
            {
                List<RoadsGISData> rgd = new List<RoadsGISData>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    RoadsGISData mc = new RoadsGISData();


                    mc = row.Cast<RoadsGISData>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.RoadsGISData.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "ListofUsers")
            {
                List<User> us = new List<User>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    User mc = new User();


                    mc = row.Cast<User>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.User.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "ListofUsers")
            {
                List<User> us = new List<User>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    User mc = new User();


                    mc = row.Cast<User>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.User.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            //  return csvData;



            // var ttx = rgd.ToList().Count;
            // dgList.DataSource = data;

        }

        private void ReadFromCSV(StreamReader stream, string fileName)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            DataTable csvData = new DataTable();

            try
            {

                using (TextFieldParser csvReader = new TextFieldParser(stream))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            if (fileName == "ListofRoads.csv")
            {
                List<RoadsGISData> rgd = new List<RoadsGISData>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    RoadsGISData mc = new RoadsGISData();


                    mc = row.Cast<RoadsGISData>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.RoadsGISData.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "ListofUsers.csv")
            {
                List<User> us = new List<User>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    User mc = new User();


                    mc = row.Cast<User>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.User.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "RoadsPerUsers.csv")
            {
                List<RoadsPerUser> rpu = new List<RoadsPerUser>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    RoadsPerUser mc = new RoadsPerUser();


                    mc = row.Cast<RoadsPerUser>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.RoadsPerUser.AddOrUpdate(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("File not RAMS export");
                return;
            }
            //  return csvData;



            // var ttx = rgd.ToList().Count;
            // dgList.DataSource = data;

        }


        private void ImportFromZip(string fileName)
        {
            if (!splashScreenManager3.IsSplashFormVisible)
            {
                splashScreenManager3.ShowWaitForm();
                splashScreenManager3.SetWaitFormCaption("Importing Data");
                splashScreenManager3.SetWaitFormDescription("Please wait...");
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (ZipArchive zip = new ZipArchive(fs))
            {
               
                foreach (var entry in zip.Entries)
                {
                    splashScreenManager3.SetWaitFormCaption("Importing "+entry.Name);


                    using (StreamReader stream = new StreamReader(entry.Open()))
                    {
                        LinqHelper.ReadFromCSV(stream, entry.FullName);
                       // ReadFromCSV(stream, entry.FullName);

                    }
                }

            }
            if (splashScreenManager3.IsSplashFormVisible)
                splashScreenManager3.CloseWaitForm();

            MessageBox.Show("Import completed successfully.");
        }
    }
}