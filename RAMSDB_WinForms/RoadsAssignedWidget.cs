using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using RAMSDB.Data;
using RAMSDB_WinForms.PavedRoads;
using RAMSDB_WinForms.UnpavedRoads;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class RoadsAssignedWidget : DevExpress.XtraEditors.XtraUserControl
    {

        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RibbonForm form = new RibbonForm();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        string _roadType = "Unpaved";

        string initialPath = string.Empty;
        const string defaultFileName = "Assigned Roads.xlsx";


        public RoadsAssignedWidget()
        {
            InitializeComponent();

            ribbonControl1.SelectPage(rpHome);


            this.widgetView1.QueryControl += widgetView1_QueryControl;

            this.initialPath = GetDefaultFilePath();


        }

        public RoadsAssignedWidget(string roadType)
        {
            InitializeComponent();

            if (roadType != null)
            {
                _roadType = roadType;
            }

            ribbonControl1.SelectPage(rpHome);


            this.widgetView1.QueryControl += widgetView1_QueryControl;

            this.initialPath = GetDefaultFilePath();


        }


        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == doclstRoads)
                e.Control = new RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ListofRoadsAssigned(_roadType);

            if (e.Document == docSurfaceType)
                e.Control = new RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucSurfaceType(_roadType);

            if (e.Document == docRoadClass)
                e.Control = new RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucClassification(_roadType);

            if (e.Document == docRoadLength)
                e.Control = new RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucRoadLength(_roadType);

            if (e.Document == docNumOfRoads)
                e.Control = new RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucNumOfRoads(_roadType);







            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }



        private void bbiConditionSurvey_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]


            if (view.SelectedRowsCount > 0)
            {



                //  GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);



                    if (_roadType == "Unpaved")
                    {
                        form = new UnpavedConditionSurveyView(roadIDColumn);
                    }
                    else if (_roadType == "Paved")
                    {
                        form = new PavedConditionSurveyView(roadIDColumn);
                    }

                    form.ShowDialog();

                    //RibbonForm form = new UnpavedConditionSurveyView(roadIDColumn);
                    //form.ShowDialog();
                    // XtraUserControl form = new UnpavedConditionSurveyView(roadIDColumn);
                    //XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }






        }

        private void RoadsAssignedWidget_Load(object sender, EventArgs e)
        {
            ribbonControl1.SelectPage(rpHome);
        }

        private void RoadsAssignedWidget_Shown(object sender, EventArgs e)
        {
            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];
            gc.DataSource = dataLoader.roadsPerUserDL;
        }

        private void bbiTrafficData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]

            if (view.SelectedRowsCount > 0)
            {







                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);




                    RibbonForm form1 = new TrafficSurveyForm(roadIDColumn);

                    //  XtraUserControl form = (XtraUserControl)form1;// TrafficSurveyForm(roadIDColumn);// UnpavedConditionSurveyView(roadIDColumn);
                    form1.Show();

                    //   XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }


        }

        private void bbiMulticriteriaData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]

            if (view.SelectedRowsCount > 0)
            {







                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);



                    RibbonForm form = new UnpavedMultiCriteriaData(roadIDColumn);
                    form.ShowDialog();

                    //XtraUserControl form = new UnpavedMultiCriteriaData(roadIDColumn);// UnpavedConditionSurveyView(roadIDColumn);
                    //XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }

        }

        private void bbiMap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            try
            {
                DevExpress.XtraBars.Ribbon.RibbonForm form = new MapViewer(_roadType);// UnpavedConditionSurveyView(roadIDColumn);
                form.ShowDialog();
            }
            finally
            {
                //Close Wait Form
                SplashScreenManager.CloseForm(false);
            }

        }

        static string GetDefaultFilePath()
        {
            return Path.GetDirectoryName(Application.StartupPath);
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];

            ExportSettings.DefaultExportType = ExportType.DataAware;

            view.OptionsPrint.PrintHeader = true;
            XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            advOptions.ShowColumnHeaders = DefaultBoolean.True;
            advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            advOptions.SheetName = "Exported from Data Grid";


            using (var dialog = new DevExpress.XtraEditors.XtraSaveFileDialog())
            {
                dialog.InitialDirectory = initialPath;

                dialog.ShowDragDropConfirmation = true;
                dialog.Filter = "Excel Files|*.xlsx";
                dialog.FileName = "Roads Assigned";
                //dialog.CreatePrompt = true;
                dialog.OverwritePrompt = true;
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    view.ExportToXlsx(dialog.FileName, advOptions);
                    Process.Start(dialog.FileName);
                }

            }

        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];




            gc.ShowRibbonPrintPreview();

        }

        private void bbiRoadFurniture_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]

            if (view.SelectedRowsCount > 0)
            {







                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);


                    RibbonForm form = new RoadAccessoriesFurnituresView(roadIDColumn);
                    form.ShowDialog();

                    //XtraUserControl form = new UnpavedMultiCriteriaData(roadIDColumn);// UnpavedConditionSurveyView(roadIDColumn);
                    //XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }

        }

        private void bbiAddStructureInventory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]

            if (view.SelectedRowsCount > 0)
            {







                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);


                    RibbonForm form = new StructuresInventoryView(roadIDColumn);
                    form.ShowDialog();

                    //XtraUserControl form = new UnpavedMultiCriteriaData(roadIDColumn);// UnpavedConditionSurveyView(roadIDColumn);
                    //XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }

        }

        private void bbiStructureConditionSurvey_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControl gc = (GridControl)doclstRoads.Control.Controls[0];


            GridView view = (GridView)gc.Views[0];//  doclstRoads.Control.Controls[0]

            if (view.SelectedRowsCount > 0)
            {







                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);


                    RibbonForm form = new StructureConditionSurveyView(roadIDColumn);
                    form.ShowDialog();

                    //XtraUserControl form = new UnpavedMultiCriteriaData(roadIDColumn);// UnpavedConditionSurveyView(roadIDColumn);
                    //XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }

        }
    }
}
