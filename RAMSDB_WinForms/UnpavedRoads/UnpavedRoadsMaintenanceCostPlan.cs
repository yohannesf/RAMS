﻿using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class UnpavedRoadsMaintenanceCostPlan : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;


        public UnpavedRoadsMaintenanceCostPlan()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            gridControl.DataSource = prioritizationClass.TotalCostPerRoad(_year).ToList();// selected.ToList();

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.TotalCostPerRoad(_year).ToList().Count;


            //gridControl.DataSource = prioritizationClass.TotalCostPerRoad().ToList();// selected.ToList();

            // bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.TotalCostPerRoad().ToList().Count;


            //   InitBinding();
            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        public void InitBinding()
        {
            var perRoadperCatCost = from tc in _context.UnpavedTentativeRoadMaintenancePlan
                                    join uc in _context.UnpavedRoadUnitCost on tc.CatWorkID equals uc.CatWorkID
                                    let q = tc.Length * uc.UnpavedUnitCost
                                    group tc by new { tc.Year, tc.RoadID, q } into result

                                    // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

                                    select new
                                    {
                                        result.Key.Year,
                                        result.Key.RoadID,

                                        perRowCost = (result.Select(c => c.Length).FirstOrDefault() *
                                         (from c in result select c.UnpavedCategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault())
                                    };

            var totalCostPerRoad = from tc in perRoadperCatCost
                                   group tc by new { tc.Year, tc.RoadID } into result
                                   orderby result.Key.Year descending
                                   select new { result.Key.Year, result.Key.RoadID, TotalCost = result.Select(c => c.perRowCost).Sum() };


            var perUser = _context.RoadsPerUser.AsQueryable();

            //foreach(var t in perUser)
            //{
            //    t.ad
            //}
            var admin = _context.AdminBoundary.AsQueryable();
            var roadGIS = _context.RoadsGISData.AsQueryable();//.ToList();




            var selected = from t in totalCostPerRoad
                           join g in roadGIS on t.RoadID equals g.RoadID
                           join p in perUser on t.RoadID equals p.RoadID
                           orderby t.Year descending
                           select new
                           {
                               t.Year,
                               t.RoadID,
                               t.TotalCost,
                               Zone = p.AdminBoundary.ZoneName,
                               Woreda = p.AdminBoundary.WoredaName,
                               OriginDestination = g.RoadOriginDestination,
                               RoadLength = g.RoadLengthInKm,
                               Classification = g.RoadClassification.RoadClassificationDescription,
                               SurfaceType = g.RoadSurfaceType.SurfaceTypeName
                           };



            //gridControl.DataSource = selected.ToList();

            //bsiRecordsCount.Caption = "RECORDS : " + totalCostPerRoad.ToList().Count;

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

                    //   MessageBox.Show(view.GetRowCellValue(info.RowHandle, view.Columns[1]).GetType().ToString());
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(info.RowHandle, view.Columns["Year"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(info.RowHandle, view.Columns["SurfaceType"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();


                    // MessageBox.Show(x.ToString() + " " + g.ToString() + " " + t.ToString());

                    //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                    //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                }
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            gridControl.DataSource = prioritizationClass.TotalCostPerRoad(yearFilter).ToList();// selected.ToList();

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.TotalCostPerRoad(yearFilter).ToList().Count;
            gridControl.RefreshDataSource();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {



                GridView view = gridView as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["Year"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["SurfaceType"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                    ribbonForm.ShowDialog();

                    gridView.RefreshData();


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
