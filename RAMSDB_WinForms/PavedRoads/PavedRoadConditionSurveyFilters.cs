using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RAMSDB_WinForms.PavedRoads
{
    public partial class PavedRoadConditionSurveyFilters : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        RAMSDBModel.RAMSDBEntities dbContext2 = new RAMSDBModel.RAMSDBEntities();
        List<Guid> tentative = new List<Guid>();
        List<PavedRoadConditionSurvey> uRCS = new List<PavedRoadConditionSurvey>();

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;

        public PavedRoadConditionSurveyFilters()
        {
            InitializeComponent();


            InitBindings();



        }

        private void InitBindings()
        {

            IQueryable<RoadsPerUser> roadsPerUsers = dbContext.RoadsPerUser.AsQueryable();


            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            tentative = dataLoader.tentativePavedRoadMaintenancePlanDL
                .Where(r => r.Year == _year).Select(r => r.RoadID).ToList();

            pavedRoadConditionSurveyBindingSource.DataSource = dataLoader.pavedRoadConditionSurveysDL.
                Where(r => r.PRCSYear == _year).ToList(); // dbContext.UnpavedRoadConditionSurvey.Local.ToBindingList();




            bsiRecordsCount.Caption = "RECORDS : " + dataLoader.pavedRoadConditionSurveysDL.
                Where(r => r.PRCSYear == _year).ToList().Count;
        }



        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();// gridControl.ShowRibbonPrintPreview();
        }

        private void GridView_RowDoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {


                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(info.RowHandle, view.Columns["PRCSYear"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(info.RowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm =
                        new PavedTentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    gridView1.RefreshData();

                    //  unpavedRoadConditionSurveyBindingSource.DataSource

                    // unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.ToList()


                }

            }
        }


        private void GridView_UnboundColumns(object sender, CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;


            int rowIndex = e.ListSourceRowIndex;

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            // var x = dataLoader.tentativeRoadMaintenancePlanDL.Select(r => r.RoadID).ToList();
            if (e.Column.FieldName != "colPlanSet") return;
            if (e.IsGetData)
            {
                tentative = dataLoader.tentativePavedRoadMaintenancePlanDL.
                    Where(r => r.Year == yearFilter).Select(r => r.RoadID).ToList();
                e.Value = tentative.Contains((Guid)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            tentative = dataLoader.tentativePavedRoadMaintenancePlanDL
            .Where(r => r.Year == _year).Select(r => r.RoadID).ToList();

            pavedRoadConditionSurveyBindingSource.DataSource = dataLoader.pavedRoadConditionSurveysDL.
                Where(r => r.PRCSYear == yearFilter).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + dataLoader.pavedRoadConditionSurveysDL.
              Where(r => r.PRCSYear == yearFilter).ToList().Count;

            gridControl1.RefreshDataSource();


            //   gridView1.RefreshData();
            //InitBindings();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["PRCSYear"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new PavedTentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    InitBindings();


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["PRCSYear"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new PavedTentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    InitBindings();


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}
