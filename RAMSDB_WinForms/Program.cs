using RAMSDB.Data;
using System;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.v20_1;

            /**** Working Code **************/
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string dataDir = System.IO.Path.Combine(appDataPath, "RAMS", "DataDirectory");
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);

         //   MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

           // var t = AppDomain.CurrentDomain.BaseDirectory;


            #region PrevCode
            /***** Previous Code *****/
            //  System.IO.DirectoryInfo dirInfo;

            //System.IO.DriveInfo appDataPath;


            // string dataDir;

            //  dirInfo = new System.IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            //   dirInfo = new System.IO.DirectoryInfo(Environment.SpecialFolder.ApplicationData.ToString());



            //string fileName = "F.MDF";

            //   string dataDir1 = appDataPath + "\\"+"RAMS"+"\\" + "DataDirectory";// System.IO.Path.Combine(dirInfo.FullName, "DataDirectory");



            // dataDir = System.IO.Path.Combine(dirInfo.FullName, "DataDirectory");


            // Add handler to handle the exception raised by main threads
            //Application.ThreadException +=
            //new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            ////// Add handler to handle the exception raised by additional threads
            //AppDomain.CurrentDomain.UnhandledException +=
            //new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login fLogin = new Login();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                string user = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserName;
                Application.Run(new frmMain());
                // RibbonForm form = new RibbonForm();
                //  Application.Run(new PavedRoads.PavedConditionSurveyView());
                // Application.Run(new Administration.ImportInitializationData());//.RoadWorkUnitCostAdmin());

                /*  try
                  {
                      string user = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserName;

                      if (user == "Default")
                      {
                          Application.Run(new Administration.ImportInitializationData());// Administration.ExportData()); 

                      }
                      else
                      {
                          Application.Run(new frmMain());
                      }
                      //  Application.Run(new frmMain());

                  }
                  catch (Exception ex)
                  {
                      HandleException(ex);
                  }*/

            }
            else
            {
                Application.Exit();
            }
            // Environment.Exit(-1);
        }
        internal static void HandleException(Exception ex)
        {
            string LF = Environment.NewLine + Environment.NewLine;
            string title = $"Oops... I got a crash at {DateTime.Now}";
            string infos = $"Please take a screenshot of this message\n\r\n\r" +
                           $"Message : {LF}{ex.Message}{LF}" +
                           $"Source : {LF}{ex.Source}{LF}" //+
                                                           //$"Stack : {LF}{ex.StackTrace}{LF}" +
                                                           //$"InnerException : {ex.InnerException}"
                           ;

            MessageBox.Show(infos, title, MessageBoxButtons.OK, MessageBoxIcon.Error); // Do logging of exception details
        }
        //static void Application_ThreadException
        //(object sender, System.Threading.ThreadExceptionEventArgs e)
        //{// All exceptions thrown by the main thread are handled over this method

        //    ShowExceptionDetails(e.Exception);
        //}

        //static void CurrentDomain_UnhandledException
        //    (object sender, UnhandledExceptionEventArgs e)
        //{// All exceptions thrown by additional threads are handled in this method

        //    ShowExceptionDetails(e.ExceptionObject as Exception);

        //    // Suspend the current thread for now to stop the exception from throwing.
        //    Thread.CurrentThread.Suspend();
        //}

        //static void ShowExceptionDetails(Exception Ex)
        //{
        //    // Do logging of exception details
        //    MessageBox.Show(Ex.Message, Ex.TargetSite.ToString(),
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //Application.Run(new Login())
        //    Application.Run(new WoredaDataPerson());
    }
}


