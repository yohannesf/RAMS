using RAMSDB.Data;

namespace RAMSDB_WinForms
{
    public partial class FormForTesting : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();


        public FormForTesting()
        {
            InitializeComponent();
            // MessageBox.Show( LoginInfo.GetLoggedInUser.UserName);


            //  multiCriteriaMatrixBindingSource.DataSource = prioritizationClass.MultiCriteriaAnalysis();
            //    var p = prioritizationClass.RunPrioritization().ToList().Count;

            //  prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization();

            // costPerRoadBindingSource.DataSource = prioritizationClass.TotalCostPerRoad().ToList();

        }

        //public void RunPrioritization()
        //{

        //   // IQueryable<CostPerRoad> cost = new List<CostPerRoad>().AsQueryable();
        //   // IQueryable<MultiCriteriaMatrix> matrices = new List<MultiCriteriaMatrix>().AsQueryable();
        //   // IQueryable<PopulationServedPerRoad> pop = new List<PopulationServedPerRoad>().AsQueryable();

        //   var pop = prioritizationClass.PopServed().ToList();
        //    var cost = prioritizationClass.TotalCostPerRoad().ToList();
        //    var matrices = prioritizationClass.MultiCriteriaAnalysis().ToList();

        //    var x = (from c in cost
        //             join mc in matrices on c.RoadID equals mc.RoadID
        //             join p in pop on c.RoadID equals p.RoadID

        //             select new
        //             {
        //                 Year = c.Year,
        //                 RoadID = c.RoadID,
        //                 AdminID = c.AdminID,
        //                 Zone = c.Zone,
        //                 Woreda = c.Woreda,

        //                 RoadOriginDestination = c.OriginDestination,
        //                 RoadSurfaceType = c.SurfaceType,
        //                 RoadClass = c.Classification,

        //                 PopulationServed = p.PopulationServed,
        //                 BenefitFactor = mc.BenefitFactor,
        //                 TotalCost = c.TotalCost,
        //                 OverallScore = c.TotalCost == 0 ? 0 : ((p.PopulationServed) * (mc.BenefitFactor)) / c.TotalCost
        //             }).ToList();
        //    //foreach(var t in x)
        //    //{
        //    //    t.
        //    //}

        //    gridControl1.DataSource = x.ToList();
        //}


    }
}