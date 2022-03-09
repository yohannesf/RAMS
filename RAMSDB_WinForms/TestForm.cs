﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RAMSDB_WinForms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();


            var perRoadperCatCost = from tc in dbContext.UnpavedTentativeRoadMaintenancePlan
                                    where tc.Year == 2020
                                    join uc in dbContext.UnpavedRoadUnitCost on tc.CatWorkID equals uc.CatWorkID
                                    //    let q = tc.Length * uc.UnpavedUnitCost
                                    group tc by new { tc.Year, tc.RoadID } into result

                                    // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

                                    select new
                                    {
                                        result.Key.Year,
                                        result.Key.RoadID,
                                        // RM = result.Where(x=>x.UnpavedCategoryofWork.WorkDescription=="Routine Maintenance")
                                        //   result.Key.WorkDescription,
                                        RMperRowCost = (result.Select(c => c.Length).FirstOrDefault() *
                                         (from c in result
                                          where c.UnpavedCategoryofWork.WorkDescription == "Routine Maintenance"
                                          select c.UnpavedCategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault()),

                                        PMperRowCost = (result.Select(c => c.Length).FirstOrDefault() *
                                         (from c in result
                                          where c.UnpavedCategoryofWork.WorkDescription == "Periodic Maintenance"
                                          select c.UnpavedCategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault()),

                                        RHperRowCost = (result.Select(c => c.Length).FirstOrDefault() *
                                         (from c in result
                                          where c.UnpavedCategoryofWork.WorkDescription == "Rehabilitation"
                                          select c.UnpavedCategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault())



                                    };

            var z = perRoadperCatCost.ToList();


            //var totalCostPerRoad = from tc in perRoadperCatCost
            //                       group tc by new { tc.Year, tc.RoadID } into result
            //                       orderby result.Key.Year descending
            //                       select new { result.Key.Year, result.Key.RoadID, TotalCost = result.Select(c => c.perRowCost).Sum() };


            roadsGISDataBindingSource.DataSource = dbContext.RoadsGISData.ToList();

            prioritizedRoadsBindingSource.DataSource = dbContext.PrioritizedRoads.ToList();

            annualRoadWorkPlanBindingSource.DataSource = dbContext.AnnualRoadWorkPlan.ToList();

            unpavedTentativeRoadMaintenancePlanBindingSource.DataSource = perRoadperCatCost.ToList(); // dbContext.UnpavedTentativeRoadMaintenancePlan.ToList();

            officeSupplyAdminCostBindingSource.DataSource = dbContext.OfficeSupplyAdminCost.ToList();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            //        dbContext.UnpavedRoadConditionSurvey.LoadAsync().ContinueWith(loadTask =>
            //        {
            //// Bind data to control when loading complete
            //unpavedRoadConditionSurveyBindingSource.DataSource = dbContext.UnpavedRoadConditionSurvey.Local.ToBindingList();
            //        }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

            //GridView1 view = sender as GridView1;

            //if (view == null) return;


            //int rowIndex = e.ListSourceRowIndex;



            //if (e.Column.FieldName != "RID") return;




            //if (e.IsGetData)
            //{



            //    if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID) != null)
            //    {


            //        Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));
            //        e.Value = tentRoads.Contains(t);
            //    }
            //}

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
