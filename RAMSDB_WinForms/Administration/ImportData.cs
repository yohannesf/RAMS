using DevExpress.Export.Xl;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace RAMSDB_WinForms.Administration
{
   

    public partial class ImportData : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        public Guid userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        public string[] years = LinqHelper.ListofYearsGC();
        public int _year = DateTime.Now.Year;

        public ImportData()
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

        public void GetDataTableOfExcel(string file_path)
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["RAMSDBEntitiesConnectionString"].ToString();

            DataSet dataSet = new DataSet();
            if (!splashScreenManager2.IsSplashFormVisible)
            {
                splashScreenManager2.ShowWaitForm();
                splashScreenManager2.SetWaitFormCaption("Importing Data");
                splashScreenManager2.SetWaitFormDescription("Please wait...");


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
                    switch (dataTable.TableName)
                    {
                        case "TrafficSurvey":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager2.SetWaitFormCaption("Importing Traffic Survey Data");
                                TrafficSurvey mc = new TrafficSurvey();

                                mc = row.Cast<TrafficSurvey>();
                                dbContext.TrafficSurvey.Add(mc);
                            }
                            break;

                        case "MultiCriteriaData":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager2.SetWaitFormCaption("Importing Multi-Criteria Data");
                                MultiCriteriaAnalysisData mc = new MultiCriteriaAnalysisData();

                                mc = row.Cast<MultiCriteriaAnalysisData>();
                                dbContext.MultiCriteriaAnalysisData.Add(mc);


                            }
                            break;

                        case "PavedRoadConditionSurvey":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager2.SetWaitFormCaption("Importing Paved Condition Survey Data");
                                PavedRoadConditionSurvey mc = new PavedRoadConditionSurvey();

                                mc = row.Cast<PavedRoadConditionSurvey>();
                                dbContext.PavedRoadConditionSurvey.Add(mc);


                            }
                            break;

                        case "UnpavedRoadConditionSurvey":
                            foreach (DataRow row in dataTable.Rows)
                            {
                                splashScreenManager2.SetWaitFormCaption("Importing Unpaved Condition Survey Data");
                                UnpavedRoadConditionSurvey mc = new UnpavedRoadConditionSurvey();

                                mc = row.Cast<UnpavedRoadConditionSurvey>();
                                dbContext.UnpavedRoadConditionSurvey.Add(mc);


                            }
                            break;
                        default:
                            {
                                MessageBox.Show("The Excel file imported is the wrong format!", "Incorrect Format", MessageBoxButtons.OK);
                                return;
                            }
                            break;
                    }


                }

            }

            if (splashScreenManager2.IsSplashFormVisible)
                splashScreenManager2.CloseWaitForm();

            dbContext.SaveChanges();
            MessageBox.Show("Data Imported Successfully!");

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //string filePath = OpenExcel();

            //if (filePath != null)
            //{
            //    GetDataTableOfExcel(filePath);
            //}
            string filePath = OpenZip();

            if (filePath != null)
            {
                ImportFromZip(filePath);
            }
        }

        private void ImportData_Load(object sender, EventArgs e)
        {

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

        private void ImportFromZip(string fileName)
        {
            if (!splashScreenManager2.IsSplashFormVisible)
            {
                splashScreenManager2.ShowWaitForm();
                splashScreenManager2.SetWaitFormCaption("Importing Data");
                splashScreenManager2.SetWaitFormDescription("Please wait...");
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (ZipArchive zip = new ZipArchive(fs))
            {

                foreach (var entry in zip.Entries)
                {
                    splashScreenManager2.SetWaitFormCaption("Importing " + entry.Name);


                    using (StreamReader stream = new StreamReader(entry.Open()))
                    {
                        LinqHelper.ReadFromCSV(stream, entry.FullName);
                        // ReadFromCSV(stream, entry.FullName);

                    }
                }

            }
            if (splashScreenManager2.IsSplashFormVisible)
                splashScreenManager2.CloseWaitForm();

            MessageBox.Show("Import completed successfully.");
        }
    }
}