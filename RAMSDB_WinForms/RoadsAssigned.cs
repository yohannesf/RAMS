using DevExpress.Export;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using RAMSDB.Data;
using RAMSDB_WinForms.UnpavedRoads;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class RoadsAssigned : DevExpress.XtraEditors.XtraUserControl
    {
        string initialPath = string.Empty;
        const string defaultFileName = "Assigned Roads.xlsx";


        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        public RoadsAssigned()
        {
            InitializeComponent();

            this.initialPath = GetDefaultFilePath();




            bsiRecordsCount.Caption = "RECORDS : " + dataLoader.roadsPerUserDL.Count;

            roadsPerUserBindingSource.DataSource = dataLoader.roadsPerUserDL;

            // Bind data to control when loading complete
            //   roadsPerUserBindingSource.DataSource = _context.RoadsPerUser.Local.ToBindingList();// dbContext.RoadsPerUser.Local.ToBindingList();

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {//
            gridControl1.ShowRibbonPrintPreview();






            //gridControl1.ExportToXlsx("grid-export.xlsx");

            //string path = ".xlsx";

            //////Customize export options 
            //(gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
            //XlsxExportOptionsEx advOptions = new XlsxExportOptionsEx();
            ////advOptions.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
            ////advOptions.ShowTotalSummaries = DevExpress.Utils.DefaultBoolean.False;
            ////advOptions.SheetName = "Exported from Data Grid";

            //gridControl1.export
            //gridControl1.ExportToXlsx(path, advOptions);
            //// Open the created XLSX file with the default application. 
            //Process.Start(path);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {


                    Guid roadIDColumn = (Guid)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);

                    RibbonForm form = new UnpavedConditionSurveyView(roadIDColumn);

                    form.ShowDialog();

                    // XtraUserControl form = new UnpavedConditionSurveyView(roadIDColumn);
                    XtraDialog.Show(form);

                    //   Form form = new TestForm();
                    //     form.ShowDialog();

                }
            }
        }

        private void bbiConditionSurvey_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);



                    RibbonForm form = new UnpavedConditionSurveyView(roadIDColumn);
                    form.ShowDialog();
                    // XtraUserControl form = new UnpavedConditionSurveyView(roadIDColumn);
                    //   XtraDialog.Show(form);


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }

        }





        private void bbiMultiCriteria_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



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

        private void bbiTrafficSurvey_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



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

        private void bbiViewMap_ItemClick(object sender, ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(WaitForm1));
            try
            {
                DevExpress.XtraBars.Ribbon.RibbonForm form = new MapViewer();// UnpavedConditionSurveyView(roadIDColumn);
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

        private void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExportSettings.DefaultExportType = ExportType.DataAware;

            (gridControl1.MainView as GridView).OptionsPrint.PrintHeader = true;
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
                    gridControl1.ExportToXlsx(dialog.FileName, advOptions);
                    Process.Start(dialog.FileName);
                }

            }

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}