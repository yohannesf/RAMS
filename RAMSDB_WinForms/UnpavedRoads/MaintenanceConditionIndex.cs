using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RAMSDB_WinForms.UnpavedRoads
{
    public partial class MaintenanceConditionIndex : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();

        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();

        public MaintenanceConditionIndex()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());


            InitBindings();
            // var urc = dbContext.UnpavedRoadConditionSurvey.ToList();


        }

        public void InitBindings()
        {

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            var urc = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RCSYear == yearFilter).ToList();

            var firstPhase = from u in urc
                             select new
                             {
                                 u.RCSID,
                                 u.RCSYear,
                                 u.RoadID,
                                 u.RoadsPerUser.AdminBoundary.ZoneName,
                                 u.RoadsPerUser.AdminBoundary.WoredaName,
                                 u.RoadsGISData.RoadOriginDestination,
                                 u.RoadsGISData.MaintenanceBranch.MaintenanceBranch1,
                                 u.SectionLengthKM,
                                 SurfaceConditionFactor = u.SurfaceCondition,


                                 ShoulderConditionFactor = (u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

                                                         (double)((u.ShoulderConditionRight.GetValueOrDefault() + u.ShoulderConditionLeft.GetValueOrDefault()) /
                                                             (
                                                               (double)((u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0))
                                                             )),



                                 DrainageConditionFactor = (u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

                                                                   (double)((u.DrainageConditionRight.GetValueOrDefault() + u.DrainageConditionLeft.GetValueOrDefault()) /
                                                                       (
                                                                         (double)((u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0))
                                                                       ))


                             }
                    ;


            var secondPhase = (from u in firstPhase
                               select new
                               {
                                   u.RCSID,
                                   u.RCSYear,
                                   u.RoadID,
                                   u.ZoneName,
                                   u.WoredaName,
                                   u.RoadOriginDestination,
                                   u.MaintenanceBranch1,
                                   u.SectionLengthKM,
                                   u.SurfaceConditionFactor,
                                   u.ShoulderConditionFactor,
                                   u.DrainageConditionFactor,
                                   MaintenanceConditionIndex = u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4,

                                   RoutineMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false,
                                   PeriodicMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) > 1.5 ?
                                                         (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false : false,
                                   Rehabilitation = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) >= 2.5 ? true : false
                               });



            var trafficCountScore = dbContext.Database.ExecuteSqlCommand("Delete from UnpavedTentativeRoadMaintenancePlan");// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();





            List<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan> tplan = dbContext.UnpavedTentativeRoadMaintenancePlan.ToList();



            foreach (var roadSegment in secondPhase)
            {




                if (roadSegment.Rehabilitation)
                {
                    RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.RCSYear;
                    //  tp.CatWorkID = 1;
                    tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Rehabilitation").Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();


                    tplan.Add(tp);





                }

                if (roadSegment.RoutineMaintenance)
                {
                    RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;
                    tp.Year = roadSegment.RCSYear;
                    tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Routine Maintenance").Select(c => c.CatWorkID).FirstOrDefault();

                    // tp.CatWorkID = 1;
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

                    tplan.Add(tp);





                }

                if (roadSegment.PeriodicMaintenance)
                {
                    RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
                    tp.RCSID = roadSegment.RCSID;
                    tp.RoadID = roadSegment.RoadID;
                    tp.Year = roadSegment.RCSYear;
                    tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Periodic Maintenance").Select(c => c.CatWorkID).FirstOrDefault();

                    //   tp.CatWorkID = 2;
                    tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

                    tplan.Add(tp);




                }
            }



            dbContext.UnpavedTentativeRoadMaintenancePlan.AddRange(tplan);
            dbContext.SaveChanges();


            gridControl.DataSource = secondPhase.ToList(); ;
            bsiRecordsCount.Caption = "RECORDS : " + secondPhase.ToList().Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();


        }

        private void bbiViewCost_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {



                GridView view = gridView as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    int yearColumn = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

                    //int yearColumn = Convert.ToInt32(view.GetRowCellValue(rowHandle, view.Columns["RCSYear"]));
                    Guid roadIDColumn = (Guid)view.GetRowCellValue(rowHandle, view.Columns["RoadID"]);
                    //    string surfaceTypeColumn = (string)view.GetRowCellValue(rowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                    DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new TentativeRoadMaintenancePlan(yearColumn, roadIDColumn);
                    ribbonForm.ShowDialog();




                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            InitBindings();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitBindings();
        }

        private void GridView_RowDoubleClick(object sender, EventArgs e)
        {
            bbiViewCost.PerformClick();
        }
    }
}
