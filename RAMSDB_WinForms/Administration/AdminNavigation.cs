﻿using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using RAMSDB.Data;
using System;
using System.Windows.Forms;
using static RAMSDB.Data.RAMSDBDataLoader;

namespace RAMSDB_WinForms.Administration
{
    public partial class AdminNavigation : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm  //
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        XtraUserControl rsAssigned = new XtraUserControl();



        public AdminNavigation()
        {



            // MessageBox.Show(LoginInfo.GetLoggedInUser.FullName + "\n" + LoginInfo.GetLoggedInUser.RoadsPerUsers.Count.ToString() + "\n");

            //MessageBox.Show(LoggedInUser.roleName + "\n" + LoggedInUser.userRegion);


            InitializeComponent();
            barUserFullName.Caption = LoginInfo.GetLoggedInUser.FullName.ToString();
            barUserName.Caption = LoginInfo.GetLoggedInUser.UserName.ToString();
            barRole.Caption = LoggedInUser.roleName;
            barLocation.Caption = LoggedInUser.userRegion;

           








        }



        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {





            if (e.Element == null) return;


            SplashScreenManager.ShowForm(typeof(WaitForm1));
            try
            {
                XtraUserControl userControl = new XtraUserControl();
                DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new DevExpress.XtraBars.Ribbon.RibbonForm();
                //  XtraForm      ribbonControl ribbonControl = new ribbonControl();


                string elementName = e.Element.Name;






                switch (elementName)
                {


                    //case "accItemRoadsAssigned":
                    //    userControl = new RAMSDB_WinForms.RoadsAssigned();
                    //    userControl.Text = "Roads Assigned";
                    //    break;
                  //  case 
                    case "accItemRWUnitCost":
                        userControl = new RoadWorkUnitCostAdmin();
                        //    ribbonControl.SelectPage(ribb);
                        //       userControl.Select();
                        userControl.Text = "Road Work Unit Cost";


                        break;

                 
                    //case "accItemConditionSurveyFilter":
                    //    userControl = new Administration.AssignRoadsToUsers();// PavedRoadConditionSurveyFilters();// UnpavedSurveyView;
                    //    userControl.Text = "Paved Roads Condition Survey Data";
                    //    break;

                    case "accItemExport":
                        userControl = new ExportData();// UnpavedRoadConditionSurveyFilters();// UnpavedSurveyView;
                        userControl.Text = "Export Data";
                        break;


                    case "accItemImport":
                        userControl = new ImportData();// RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                        userControl.Text = "Import Data";
                        break;

                        
                    case "accItemAssignUsers":
                        userControl = new AssignRoads();// RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                        userControl.Text = "Assign Roads to Users";
                        break;

                        
 case "accItemExportInitializationData":
                        userControl = new ExportInitializationData();// RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                        userControl.Text = "Export Initialization Data";
                        break;

                        

                            case "accItemManageRoads":
                        userControl = new ManageRoads();// RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                        userControl.Text = "Manage Regional Roads";
                        break;

                     



                            case "accItemManageUsers":
                        userControl = new ManageUsers();// RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();
                        userControl.Text = "Manage Users";
                        break;

                        //case "accItemMaintenanceConditionIndex":
                        //    userControl = new RAMSDB_WinForms.PavedRoads.PavedMaintenanceConditionIndex();
                        //    userControl.Text = "Maintenance Condition Index";
                        //    break;




                        //case "accItemMCAnalysis":
                        //    userControl = new PavedRoadsMultiCriteriaAnalysis();
                        //    userControl.Text = "Paved Roads Multicriteria Analysis";
                        //    break;

                        //case "accItemMCAnalysis":
                        //    userControl = new PPP.ContractRoutineMaintenanceView();
                        //  //  ribbonForm = new PPP.AllocationOfFundsView();
                        //    userControl.Text = "Paved Roads Multicriteria Analysis";
                        //    break;



                        //case "accItemMaintenanceCost":
                        //    userControl = new PavedRoadsMaintenanceCostPlan();
                        //    userControl.Text = "Maintenance Cost per Road";
                        //    break;



                        //case "accItemPrioritizedRoads":
                        //    userControl = new PavedPrioritizedRoads();
                        //    userControl.Text = "Paved Prioritized Roads";
                        //    break;



                }





                //   XtraUserControl userControl = e.Element.Name .Text == "Employees" ? employeesUserControl : customersUserControl;
                //SplashScreenManager.ShowForm(typeof(WaitForm1));
                //try
                //{
                //    tabbedView.AddDocument(userControl);
                //    tabbedView.ActivateDocument(userControl);
                //}
                //finally
                //{
                //    //Close Wait Form
                //    SplashScreenManager.CloseForm(false);
                //}


                tabbedView.AddDocument(userControl);
                tabbedView.ActivateDocument(userControl);
            }
            finally
            {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }

        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {

            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
          //  accordionControl.SelectedElement =  accordionGroupRoadConditionSurvey.Elements[barItemIndex];//  mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
                // if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
                //  else accordionControl.SelectedElement = employeesAccordionControlElement;
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            //if (e.Document.Caption == "Employees") employeesUserControl = CreateUserControl("Employees");
            //else customersUserControl = CreateUserControl("Customers");
        }

        // Assigning a required content for each auto generated Document
        void tabbedView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {



            //if (e.Document == unpavedRoadConditionSurveyFiltersDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadConditionSurveyFilters();

            //if (e.Document == popServedDocument)
            //    e.Control = new RAMSDB_WinForms.PopServed();

            //if (e.Document == unpavedRoadsMaintenanceCostPlanDocument) 
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadsMaintenanceCostPlan();

            //if (e.Document == unpavedRoadsMultiCriteriaAnalysisDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoadsMultiCriteriaAnalysis();


            //     if (e.Document == roadsAssignedDocument)
            //        e.Control = new RAMSDB_WinForms.RoadsAssigned();

            //if (e.Document == MaintenanceConditionIndexDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedRoads.MaintenanceConditionIndex();


            //if (e.Document == unpavedPrioritizedRoadsDocument)
            //    e.Control = new RAMSDB_WinForms.UnpavedPrioritizedRoads();



            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void accItemunpavedResults_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click_1(object sender, EventArgs e)
        {

        }

        private void accItemPopServed_Click(object sender, EventArgs e)
        {

        }

        private void roadsAssigned_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.roleName == "Regional Admin" || LoggedInUser.roleName=="Super Admin")
              {
                accItemRWUnitCost.Visible = true;
                accItemImport.Visible = true;
                accItemExport.Visible = false;
                accordionControl.SelectedElement = accItemManageRoads;// accItemRWUnitCost;
            }
            else if (LoggedInUser.roleName == "Woreda Data Person")
            {
                accItemRWUnitCost.Visible = true;
                accItemImport.Visible = false;
                accItemExport.Visible = true;
                accItemManageUsers.Visible = false;
                accItemAssignUsers.Visible = false;
                accItemExportInitializationData.Visible = false;
                accordionControl.SelectedElement = accItemManageRoads;// accItemExport;
            }

            //  accordionControl.SelectedElement = accItemRWUnitCost;// accItemExport;// accItemRoadsAssigned;

        }

        private void bbiLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();


            // Login fLogin = new Login();

            // this.Close();

            // Application.Run();



            // if (tabbedView.Documents.Count == 0) return;


            // int c = tabbedView.Documents.Count;

            // for (int i=c-1; i>=0; i--)
            // {
            //     tabbedView.RemoveDocument(tabbedView.Documents[i].Control);
            // }


            // //    foreach (var x in tabbedView.Documents.)
            // //{
            // //    tabbedView.Documents.Remove(x);
            // //}

            ////tabbedView.Documents[]
            //  fLogin.Show();


        }

        private void AdminNavigation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AdminNavigation_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}