using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Reflection;
using DevExpress.XtraSplashScreen;
using RAMSDB_WinForms;
using System.Threading;
using System.Data.Entity.Spatial;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using DevExpress.Utils.Extensions;
using Microsoft.SqlServer.Types;
using System.Text;
using System.IO;
using System.IO.Packaging;
using Microsoft.VisualBasic.FileIO;
using RAMSDBModel;
using System.Data.Entity.Migrations;
using System.Windows;

namespace RAMSDB.Data
{
    public static class LinqHelper
    {
        public static RAMSDBModel.RAMSDBEntities  dbContext = new RAMSDBModel.RAMSDBEntities();

        public static double? WeightedAverage<T>(this IEnumerable<T> records, Func<T, double> value, Func<T, double> weight)
        {
            double weightedValueSum = records.Sum(x => value(x) * weight(x));
            double weightSum = records.Sum(x => weight(x));

            if (weightSum != 0)
                return Math.Round(weightedValueSum / weightSum, 2);
            else
                return null;
            //   throw new DivideByZeroException("Your message here");
        }

        public static string[] ListofYearsGC()
        {
            string[] years = new string[11];
            int _year = DateTime.Now.Year;
            // int[] years = new int[11];

            int x = 2;

            for (int i = 0; i < 11; i++)
            {


                years[i] = (_year + x).ToString();
                x--;
            }
            return years;
        }

        //public static int[] ListofYearsGC()
        //{
        //    int[] years = new int[11];
        //    int _year = DateTime.Now.Year;
        //    // int[] years = new int[11];

        //    int x = 5;

        //    for (int i = 0; i < 11; i++)
        //    {


        //        years[i] = Convert.ToInt16(_year + x);
        //        x--;
        //    }
        //    return years;
        //}

        public static T ToObject<T>(this DataRow dataRow)
     where T : new()
        {
            T item = new T();
            foreach (DataColumn column in dataRow.Table.Columns)
            {
                if (dataRow[column] != DBNull.Value)
                {
                    PropertyInfo prop = item.GetType().GetProperty(column.ColumnName);
                    if (prop != null)
                    {
                        object result = Convert.ChangeType(dataRow[column], prop.PropertyType);
                        prop.SetValue(item, result, null);
                        continue;
                    }
                    else
                    {
                        FieldInfo fld = item.GetType().GetField(column.ColumnName);
                        if (fld != null)
                        {
                            object result = Convert.ChangeType(dataRow[column], fld.FieldType);
                            fld.SetValue(item, result);
                        }
                    }
                }
            }
            return item;
        }
        public static T Cast<T>(this DataRow dataRow) where T : new()
        {
            T item = new T();

            IEnumerable<PropertyInfo> properties = item.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                                                                 .Where(x => x.CanWrite);

            foreach (DataColumn column in dataRow.Table.Columns)
            {
                if (dataRow[column] == DBNull.Value)
                {
                    continue;
                }

                PropertyInfo property = properties.FirstOrDefault(x => column.ColumnName.Equals(x.Name, StringComparison.OrdinalIgnoreCase));

                if (property == null)
                {
                    continue;
                }

                try
                {
                    Type t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                    if (t == typeof(DbGeometry))
                    {
                        DbGeometry Shape = DbGeometry.FromText(dataRow[column].ToString(), 4326);
                        object safeValue = Shape;// (dataRow[column]);
                        property.SetValue(item, safeValue, null);
                    }

                    //Guid guidId = Guid.Parse 
                       if (t != typeof(DbGeometry))
                    {
                        if (t == typeof(Guid))
                        {
                            Guid guid = Guid.Parse(dataRow[column].ToString());

                            object safeValue = guid;// (dataRow[column]);
                            property.SetValue(item, safeValue, null);

                        }
                        else
                        {


                            object safeValue = (dataRow[column] == null) ? null : Convert.ChangeType(dataRow[column], t);

                            property.SetValue(item, safeValue, null);
                        }
                    }



                }
                catch
                {
                    throw new Exception($"The value '{dataRow[column]}' cannot be mapped to the property '{property.Name}'!");
                }

            }

            return item;
        }

        public static T AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            return !exists ? dbSet.Add(entity) : null;
        }

     


        public static DataTable DataTable(this DbContext context, string sqlQuery,
                                      params DbParameter[] parameters)
        {
            /*
         * Usage DataTable
         * var db = new MopDb();
         * 
         *
         *stored procedure
         * DataTable searchUser = db.DataTable(
            "EXEC sp_test_role @name = @paramName",
            new SqlParameter("paramName", SqlDbType.NVarChar) { Value = "sa" }
        );

        select query
        DataTable likeUser = db.DataTable(
            "SELECT * FROM [dbo].[tbl_test_role] WHERE [name] LIKE '%' + @paramName +'%'",
            new SqlParameter("paramName", SqlDbType.NVarChar) { Value = "a" }
        );

        */
            DataTable dataTable = new DataTable();
            DbConnection connection = context.Database.Connection;
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
            using (var cmd = dbFactory.CreateCommand())
            {
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlQuery;
                if (parameters != null)
                {
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                {
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }

        public static string[] ListofYearsEC()
        {
            string[] years = new string[11];
            int _year = ECYear();
            // int[] years = new int[11];

            int x = 5;

            for (int i = 0; i < 11; i++)
            {


                years[i] = (_year + x).ToString();
                x--;
            }
            return years;
        }

        public static int ECYear()
        {
            DateTime dtNow = DateTime.Now;
            int ecYear = dtNow.Year;

            if (dtNow.Month < 9)
            {
                ecYear = dtNow.Year - 8;
            }

            if (dtNow.Month == 9)
            {
                if (dtNow.Day <= 10)
                {
                    ecYear = dtNow.Year - 8;
                }
                else
                {
                    ecYear = dtNow.Year - 7;
                }
            }

            if (dtNow.Month > 9)
            {
                ecYear = dtNow.Year - 7;
            }

            return ecYear;

        }

        public static void ReadFromCSV(StreamReader stream, string fileName)
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
            else if (fileName == "UnpavedRoadConditionSurvey.csv")
            {
                List<UnpavedRoadConditionSurvey> rpu = new List<UnpavedRoadConditionSurvey>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    UnpavedRoadConditionSurvey mc = new UnpavedRoadConditionSurvey();


                    mc = row.Cast<UnpavedRoadConditionSurvey>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.UnpavedRoadConditionSurvey.Add(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "PavedRoadConditionSurvey.csv")
            {
                List<PavedRoadConditionSurvey> rpu = new List<PavedRoadConditionSurvey>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    PavedRoadConditionSurvey mc = new PavedRoadConditionSurvey();


                    mc = row.Cast<PavedRoadConditionSurvey>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.PavedRoadConditionSurvey.Add(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "MultiCriteriaData.csv")
            {
                List<MultiCriteriaAnalysisData> rpu = new List<MultiCriteriaAnalysisData>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    MultiCriteriaAnalysisData mc = new MultiCriteriaAnalysisData();


                    mc = row.Cast<MultiCriteriaAnalysisData>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.MultiCriteriaAnalysisData.Add(mc);
                    //dbContext.Set<RoadsGISData>().
                    //    AddIfNotExists(mc, x => x.RoadOriginName == mc.RoadOriginName && x.RoadDestinationName == mc.RoadDestinationName
                    //    && x.AdminID == mc.AdminID && x.RegionName == mc.RegionName && x.RoadID == mc.RoadID);
                    dbContext.SaveChanges();
                }
            }
            else if (fileName == "TrafficSurvey.csv")
            {
                List<TrafficSurvey> rpu = new List<TrafficSurvey>();
                foreach (DataRow row in csvData.Rows)
                {
                    //splashScreenManager3.SetWaitFormCaption("Importing List of Roads");

                    TrafficSurvey mc = new TrafficSurvey();


                    mc = row.Cast<TrafficSurvey>();
                    // rgd.Add(mc);
                    // dbContext.RoadsGISData.Add(mc);
                    dbContext.TrafficSurvey.Add(mc);
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

    }

    public static class My_DataTable_Extensions
    {

       public static RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();

        public static int count = dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).ToList().Count;

        // if (count==0) return;
        //  public static var = dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID)

        public static string userWoreda;

        public static string _region = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.Region;

       public static string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        /// <summary>
        /// Export DataTable to Excel file
        /// </summary>
        /// <param name="DataTable">Source DataTable</param>
        /// <param name="ExcelFilePath">Path to result file name</param>
        public static void ExportToExcel(this System.Data.DataTable DataTable, string ExcelFilePath = null)
        {
            if (count == 0) return;// "Nothing to Export";

            userWoreda = dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).
           Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            try
            {
                int ColumnsCount;

                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;

                // DataCells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                       // Cells[j, i] = DataTable.Rows[j][i];
                        Cells[j, i] = DataTable.Rows[j][i].GetType().Name == "Guid" ? DataTable.Rows[j][i].ToString() : DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                Worksheet.Rows.RowHeight = 15;//.Columns().AutoFitContents();

                string workBookName = userWoreda +
                    DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() +
                    DateTime.Now.Day.ToString() + "_" +
                    DateTime.Now.Hour.ToString() + "_" +
                    DateTime.Now.Minute.ToString() +

                     ".xlsx";

                ExcelFilePath = myDocPath + "\\" + workBookName;

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();
                        System.Windows.MessageBox.Show("Excel file saved!");
                       
                        
                        releaseObject(Worksheet);

                        releaseObject(Excel);

                        // releaseObject(oexcel);
                        GC.Collect();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        public static string ExportToExcel(this System.Data.DataSet dataSet, string yearFilter, string ExcelFilePath = null)
        {
            if (count == 0) return "Nothing to Export";

            userWoreda= dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).
           Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            string returnPath = "";
            try
            {

             
                int ColumnsCount;

                if (dataSet.Tables.Count == 0)// || (ColumnsCount = dt1.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                //Because the workbook already creates a default sheet
                int numDataTables =  dataSet.Tables.Count - 1 ;

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();
                Excel.ActiveWorkbook.Worksheets.Add(Count: numDataTables);

                // single worksheet
                // ;

                SplashScreenManager.ShowForm(typeof(WaitForm1));

                SplashScreenManager.Default.SetWaitFormCaption("Please wait: Exporting data...");


                int sheetCounter = 1;
                foreach (DataTable DataTable in dataSet.Tables)
                {
                    SplashScreenManager.Default.SetWaitFormDescription("Exporting " + DataTable.TableName);

                    ColumnsCount = DataTable.Columns.Count;
                      Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveWorkbook.Worksheets.get_Item(sheetCounter);
                 
                    Worksheet.Name = DataTable.TableName;

                    object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;

                // DataCells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                            // Cells[j, i] = DataTable.Rows[j][i];
                        Cells[j, i] = DataTable.Rows[j][i].GetType().Name == "Guid" ? DataTable.Rows[j][i].ToString() : DataTable.Rows[j][i];


                    Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                Worksheet.Rows.RowHeight = 15;//.Columns().AutoFitContents();
                    Worksheet.Protect();
                    sheetCounter++;
                  //  Excel.Worksheets.Add();
                }
                SplashScreenManager.CloseForm(false);


                string workBookName = userWoreda +"_" + 
                    yearFilter + "DataExportedOn_" +
                    DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() +
                    DateTime.Now.Day.ToString() + "_" +
                    DateTime.Now.Hour.ToString() + "_" +
                    DateTime.Now.Minute.ToString() +

                     ".xlsx";

                ExcelFilePath = myDocPath + "\\" + workBookName;

              // Worksheet = Excel.ActiveSheet();

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Excel.ActiveWorkbook.SaveAs(ExcelFilePath);
                       // Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();

                        returnPath =  ExcelFilePath;

                        
                     //   System.Windows.MessageBox.Show("Excel file saved!");


                        releaseObject(Excel.ActiveWorkbook);

                        releaseObject(Excel);

                        // releaseObject(oexcel);
                        GC.Collect();
                        return returnPath;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                       // return returnPath;
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                    return returnPath;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
                //return returnPath;
            }
        }

        public static string InitializationDataExportToExcel(this System.Data.DataSet dataSet)
        {

            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            // if (count == 0) return "Nothing to Export";

            // userWoreda = dbContext.RoadsPerUser.Where(c => c.UserID == RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID).
            //Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();






            string ExcelFilePath = null;

            //SplashScreen x = new SplashScreen();

            // x.ActiveForm = WaitForm1;



            string returnPath = "";

            try
            {


                int ColumnsCount;

                if (dataSet.Tables.Count == 0)// || (ColumnsCount = dt1.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                //Because the workbook already creates a default sheet
                int numDataTables = dataSet.Tables.Count - 1;

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();
                Excel.ActiveWorkbook.Worksheets.Add(Count: numDataTables);

                // single worksheet
                // ;


                int sheetCounter = 1;
                SplashScreenManager.ShowForm(typeof(WaitForm1));

                SplashScreenManager.Default.SetWaitFormCaption("Please wait: Exporting data...");
                foreach (DataTable DataTable in dataSet.Tables)
                {
                  //  string x = "Exporting " + DataTable.TableName;
                    SplashScreenManager.Default.SetWaitFormDescription("Exporting " + DataTable.TableName);


                    ColumnsCount = DataTable.Columns.Count;
                    Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveWorkbook.Worksheets.get_Item(sheetCounter);

                    Worksheet.Name = DataTable.TableName;

                    object[] Header = new object[ColumnsCount];

                    // column headings               
                    for (int i = 0; i < ColumnsCount; i++)
                        Header[i] = DataTable.Columns[i].ColumnName;

                    Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                    HeaderRange.Value = Header;
                    HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    HeaderRange.Font.Bold = true;

                    // DataCells
                    int RowsCount = DataTable.Rows.Count;
                    object[,] Cells = new object[RowsCount, ColumnsCount];

                    /*
                     * 
                       if (t != typeof(DbGeometry))
                    {
                        if (t == typeof(Guid))
                        {*/

                    for (int j = 0; j < RowsCount; j++)
                        for (int i = 0; i < ColumnsCount; i++)
                            Cells[j, i] = DataTable.Rows[j][i].GetType().Name == "Guid" ? DataTable.Rows[j][i].ToString() : DataTable.Rows[j][i];

                    //if (DataTable.Rows[j][i].GetType().Name == "Guid" )
                    //{
                    //    Cells[j, i] = DataTable.Rows[j][i].ToString();
                    //}
                    //else if (DataTable.Rows[j][i].GetType().Name == "SqlGeometry")
                    //{
                    //    // var wkt = SqlGeometry.STGeomFromText(new SqlChars(geom.AsText()), 4326).MakeValid().STAsText().ToSqlString().ToString();

                    //    SqlGeometry sqlGeo = (SqlGeometry)DataTable.Rows[j][i];
                    //    DbGeometry dbGeo = DbGeometry.FromBinary(sqlGeo.STAsBinary().Buffer);
                    //    var x = DataTable.Rows[j][i];
                    //    Cells[j, i] = dbGeo;
                    //    // Cells[j, i] = DataTable.Rows[j][i].CastTo<SqlGeometry>();
                    //}
                    //else
                    //{
                    //    Cells[j, i] = DataTable.Rows[j][i];
                    //}
                    // Worksheet.Cells[i+ 1, ColumnsCount] = DataTable.Rows[j][i];


                    Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]),
                        (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                    Worksheet.Rows.RowHeight = 15;//.Columns().AutoFitContents();
              //  Worksheet.Columns[1, 1].EntireColumn.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight);
                Worksheet.Protect();
                    sheetCounter++;
                    //  Excel.Worksheets.Add();
                }
                SplashScreenManager.CloseForm(false);

                string workBookName = _region + "_" +
                    LinqHelper.ECYear().ToString() + "DataExportedOn_" +
                    DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() +
                    DateTime.Now.Day.ToString() + "_" +
                    DateTime.Now.Hour.ToString() + "_" +
                    DateTime.Now.Minute.ToString() +

                     ".xlsx";

                ExcelFilePath = myDocPath + "\\" + workBookName;

                // Worksheet = Excel.ActiveSheet();

                // check fielpath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Excel.ActiveWorkbook.SaveAs(ExcelFilePath);
                        // Worksheet.SaveAs(ExcelFilePath);
                        Excel.Quit();

                        returnPath = ExcelFilePath;


                        //   System.Windows.MessageBox.Show("Excel file saved!");


                     //   releaseObject(Excel.ActiveWorkbook);

                      //  releaseObject(Excel);

                        // releaseObject(oexcel);
                        GC.Collect();
                        return returnPath;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                        // return returnPath;
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                    return returnPath;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
                //return returnPath;
            }



        }

        


        private static void releaseObject(object o) 
        { try { while (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0) { } } 
            catch { } finally { o = null; } }

        public static string ToCsv(this DataTable dataTable)
        {
            StringBuilder sbData = new StringBuilder();

            // Only return Null if there is no structure.
            if (dataTable.Columns.Count == 0)
                return null;

            foreach (var col in dataTable.Columns)
            {
                if (col == null)
                    sbData.Append(",");
                else
                    sbData.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\",");
            }

            sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    if (column == null)
                        sbData.Append(",");
                    else
                        sbData.Append("\"" + column.ToString().Replace("\"", "\"\"") + "\",");
                }
                sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);
            }

            return sbData.ToString();
        }


        //public static string ToCsv(this System.Data.DataSet dataSet)
        //{

        //   // List<File> txtDatas = new List<File>();


        //    if (dataSet.Tables.Count == 0)// || (ColumnsCount = dt1.Columns.Count) == 0)
        //        throw new Exception("ExportToExcel: Null or empty input table!\n");

        //    //Because the workbook already creates a default sheet
        //    int numDataTables = dataSet.Tables.Count;// - 1;

        //    foreach (DataTable dataTable in dataSet.Tables)
        //    {

        //        StringBuilder sbData = new StringBuilder();

        //        // Only return Null if there is no structure.
        //        if (dataTable.Columns.Count == 0)
        //            return null;

        //        foreach (var col in dataTable.Columns)
        //        {
        //            if (col == null)
        //                sbData.Append(",");
        //            else
        //                sbData.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\",");
        //        }

        //        sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);

        //        foreach (DataRow dr in dataTable.Rows)
        //        {
        //            foreach (var column in dr.ItemArray)
        //            {
        //                if (column == null)
        //                    sbData.Append(",");
        //                else
        //                    sbData.Append("\"" + column.ToString().Replace("\"", "\"\"") + "\",");
        //            }
        //            sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);
        //        }

        //        return sbData.ToString();
        //    }
        //}


    }

   
}


