using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Linq;

namespace RAMSDB_WinForms
{
    public partial class UnpavedRoadsMultiCriteriaAnalysis : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();

        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;

        public UnpavedRoadsMultiCriteriaAnalysis()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());


            gridControl1.DataSource = prioritizationClass.MultiCriteriaAnalysis(_year).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.MultiCriteriaAnalysis(_year).ToList().Count;
            // PopulationServed();
            // TrafficCount();
            // MultiCriteriaMatrix();
            //  TotalCost();
            //dataLayoutControl1.DataSource = GetDataSource();
            //dataLayoutControl1.RetrieveFields();

            //List<BaseLayoutItem> flatList = new FlatItemsList().GetItemsList(dataLayoutControl1.Root);
            //BaseLayoutItem aboutItem = flatList.First(e => e.Text == "About");
            //aboutItem.TextLocation = DevExpress.Utils.Locations.Top;
        }

        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            gridControl1.DataSource = prioritizationClass.MultiCriteriaAnalysis(yearFilter).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.MultiCriteriaAnalysis(yearFilter).ToList().Count;
            gridView1.RefreshData();
            gridControl1.RefreshDataSource();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
                bbiRefresh.PerformClick();
            }

            if (splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.CloseWaitForm();
        }

        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        //public void PopulationServed()
        //{
        //    var populationByWoreda = (from p in _context.AdminBoundary where p.RegionName == "SNNP" select new { _adminID = p.AdminID, _woredaName = p.WoredaName, _population = p.Population }).ToList();

        //    //var totalLengthofRoadsInWoreda =

        //    var totalLengthofRoadsByWoreda = (from road in _context.RoadsPerUser
        //                                     join roadInfo in _context.RoadsGISData on road.RoadID equals roadInfo.RoadID
        //                                     join adminInfo in _context.AdminBoundary on road.AdminID equals adminInfo.AdminID
        //                                     group road by new { adminInfo.AdminID, adminInfo.WoredaName }
        //                                     into result
        //                                     select new { 
        //                                         _adminID = result.Key.AdminID, _wordaName = result.Key.WoredaName, _woredaRoadLength = result.Sum(c => c.RoadsGISData.RoadLengthInKm) }).ToList();

        //    var rpu = _context.RoadsPerUser.Include("RoadsGISData").ToList();


        //    var popServed = (from r in rpu
        //                     join p in populationByWoreda on r.AdminID equals p._adminID
        //                     join t in totalLengthofRoadsByWoreda on r.AdminID equals t._adminID
        //                     select new { 
        //                         rID = r.RoadID, 
        //                         rLength = r.RoadsGISData.RoadLengthInKm.GetValueOrDefault(), 
        //                         wTot = t._woredaRoadLength.GetValueOrDefault(), 
        //                         pop = p._population.GetValueOrDefault(),
        //                         _popServed = p._population.GetValueOrDefault() * ((r.RoadsGISData.RoadLengthInKm.GetValueOrDefault()) / t._woredaRoadLength.GetValueOrDefault())}).ToList();

        //                     //select new { pop= p._population.GetValueOrDefault(),ad= r.AdminID }).ToList();// result.Key.RoadID, result.Key._population}) ;
        //    //(x._population * ((z.RoadLengthInKm) / t._woredaRoadLength))}
        //    //foreach (var t in popServed)
        //    //{
        //    //    var x = t.rID;
        //    //    var z = t.rLength;
        //    //    var g = t.wTot;
        //    //    var a = t.pop;
        //    //}


        //    gridControl1.DataSource = popServed.ToList();            
        //                    //_context.RoadsGISData.Include(rgD => rgD.)
        //                    //group roads by _context.RoadsGISData.Include(c=>c. product.Field<string>("Style") into g
        //                    //select new
        //                    //{
        //                    //    Style = g.Key,
        //                    //    AverageListPrice =
        //                    //        g.Average(product => product.Field<Decimal>("ListPrice"))
        //                    //};



        //}

        //public void TotalCost()
        //{
        //    var perRoadperCatCost = from tc in _context.TentativeRoadMaintenancePlan
        //                           join uc in _context.UnpavedRoadUnitCost on tc.CatWorkID equals uc.CatWorkID
        //                           let q = tc.Length * uc.UnpavedUnitCost
        //                           group tc by new { tc.Year, tc.RoadID,q } into result

        //                          // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

        //                           select new
        //                           {
        //                               result.Key.Year,
        //                               result.Key.RoadID,

        //                               perRowCost =  (result.Select(c => c.Length).FirstOrDefault() *
        //                                (from c in result select c.CategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault())
        //                           };

        //    var totalCostPerRoad = from tc in perRoadperCatCost
        //                        group tc by new { tc.Year, tc.RoadID } into result
        //                        orderby result.Key.Year descending
        //                        select new { result.Key.Year, result.Key.RoadID, TotalCost= result.Select(c => c.perRowCost).Sum() };


        //    //leng = result.Select(c => c.Length).FirstOrDefault(),
        //    //tt = (from c in result select c.CategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault()
        //    //                     //  result.Key.Year*result.Key.RoadID};// tc.Year, tc.RoadID, q }; 


        //    //foreach(var x in totalCostPerRoad)
        //    //{
        //    //    x.tt.
        //    //}
        //    //  tCost=result.Aggregate(1, (x,y) => (result.Select(c => c.Length).FirstOrDefault())* (result.Key.UnpavedUnitCost) )  };

        //    //select new
        //    //{
        //    //    result.Key.Year,
        //    //    result.Key.RoadID,
        //    //    result.Key.CatWorkID,
        //    //    result.Key.UnpavedUnitCost,
        //    //    length = result.Select(c => c.Length).FirstOrDefault(),
        //    //    tCost = result.Aggregate(1, (x, y) => (result.Select(c => c.Length).FirstOrDefault()) * (result.Key.UnpavedUnitCost))
        //    //};
        //  //  return totalCostPerRoad.AsQueryable();
        //    gridControl1.DataSource = totalCostPerRoad.ToList();

        //}

        //public void TrafficCount()
        //{
        //    var trafficCount = from tc in _context.TrafficSurvey
        //                       group tc by new { tc.RoadID, tc.TrafficSurveyYear } into result
        //                       select new { _year = result.Key.TrafficSurveyYear, _roadID = result.Key.RoadID, _trafficCount = result.Sum(t => t.TrafficCount) } into tCount
        //                       orderby tCount._year descending, tCount._trafficCount descending
        //                       select tCount;
        //                       ;
        //    gridControl1.DataSource = trafficCount.ToList();
        //}

        //public void MultiCriteriaMatrix()
        //    //join tc in trafficCount on mc.RoadID equals tc.RoadID
        //{
        //   // var trafficCount = _context.TrafficSurvey.ToList();

        //    var mcWeights = _context.CriteriaWeight.ToList();

        //    //foreach(var t in mcWeights)
        //    //{
        //    //    t.
        //    //}

        //    var mcMatrix = (from mc in _context.MultiCriteriaAnalysisData

        //                   group mc by new { mc.Year, mc.RoadID } into result
        //                   select new 
        //                   {
        //                       _year = result.Key.Year,
        //                       _roadID = result.Key.RoadID,

        //                       //_trafficSurvey =  result.Select(t=>t.RoadsGISData.T)

        //                       //-------------Trading Center
        //                        _TradingCenterCategory = result.Select(t => t.TradingCentersAlongRoad.TradingCenterAlongCategory).FirstOrDefault(),
        //                       _TradingCenterPoint = result.Select(t => t.TradingCentersAlongRoad.CateogryMaxPoints).FirstOrDefault(),
        //                       _TradingCenterWeight = result.Select(t=>t.TradingCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _TradingCenterScore = ((result.Select(t => t.TradingCentersAlongRoad.CateogryMaxPoints).FirstOrDefault())
        //                                            /(result.Select(t => t.TradingCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,


        //                       //------------
        //                       _KebeleVillageCommunity = result.Select(t => t.KebelesVillagesCommunitiesConnected.KVCConnectedDescription).FirstOrDefault(),
        //                       _KebeleVillageCommPoint = result.Select(t => t.KebelesVillagesCommunitiesConnected.CategoryMaxPoints).FirstOrDefault(),
        //                       _KebeleVillageCommWeight = result.Select(t=>t.KebelesVillagesCommunitiesConnected.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       __KebeleVillageCommScore = ((result.Select(t => t.KebelesVillagesCommunitiesConnected.CategoryMaxPoints).FirstOrDefault()) 
        //                                                    /(result.Select(t => t.KebelesVillagesCommunitiesConnected.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,


        //                       _roadClassDescription = result.Select(t => t.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault(),
        //                       _roadClassPoint = result.Select(t => t.RoadsGISData.RoadClassification.CategoryMaxPoint).FirstOrDefault(),
        //                       _roadClassWeight = result.Select(t=>t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _roadClassScore = ((result.Select(t => t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()) 
        //                                        /(result.Select(t => t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,

        //                       _roadThroughFarmLand = result.Select(t => t.RoadTraversesFarmland.RoadTravFarmDescription).FirstOrDefault(),
        //                       _roadThroughFarmLandPoint = result.Select(t => t.RoadTraversesFarmland.CategoryMaxPoints).FirstOrDefault(),
        //                       _roadThroughFarmLandWeight = result.Select(t=>t.RoadTraversesFarmland.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _roadThroughFarmLandScore = ((result.Select(t => t.RoadTraversesFarmland.CategoryMaxPoints).FirstOrDefault())
        //                                                    /(result.Select(t => t.RoadTraversesFarmland.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100 ,

        //                       _cooperativesDescription = result.Select(t => t.CooperativeCentersAlongRoad.CcentersAlongRoadDescription).FirstOrDefault(),
        //                       _cooperativesPoint = result.Select(t => t.CooperativeCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
        //                       _cooperativesWeight = result.Select(t=>t.CooperativeCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _cooperativesScore = ((result.Select(t => t.CooperativeCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
        //                                            /(result.Select(t => t.CooperativeCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100 ,


        //                       _marketsDescription = result.Select(t => t.MarketsConnectByRoad.MarketsConnectByRoadDescription).FirstOrDefault(),
        //                       _marketsPoint = result.Select(t => t.MarketsConnectByRoad.CategoryMaxPoints).FirstOrDefault(),
        //                       _marketsWeight = result.Select(t=>t.MarketsConnectByRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _marketsScore = ((result.Select(t => t.MarketsConnectByRoad.CategoryMaxPoints).FirstOrDefault()) 
        //                                        /(result.Select(t => t.MarketsConnectByRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,


        //                       _healthCentersDescription = result.Select(t => t.HealthCentersAlongRoad.HealthCentersAlongRoadDescription).FirstOrDefault(),
        //                       _healthCentersPoint = result.Select(t => t.HealthCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
        //                       _healthCenterWeight = result.Select(t=>t.HealthCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _healthCenterScore = ((result.Select(t => t.HealthCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
        //                                            /(result.Select(t => t.HealthCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,


        //                       _educationCentersDescription = result.Select(t => t.EducationCentersAlongRoad.EducationCentersAlongRoadDescription).FirstOrDefault(),
        //                       _educationCentersPoint = result.Select(t => t.EducationCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
        //                       _educationCentersWeight = result.Select(t=>t.EducationCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _educationCentersScore = ((result.Select(t => t.EducationCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
        //                                                /(result.Select(t => t.EducationCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100,

        //                       _otherProjectsDescription = result.Select(t => t.OtherProjectsAlongRoad.OtherProjectsAlongRoadDescription).FirstOrDefault(),
        //                       _otherProjectsPoint = result.Select(t=>t.OtherProjectsAlongRoad.CategoryMaxPoints).FirstOrDefault(),
        //                       _otherProjectsWeight = result.Select(t=>t.OtherProjectsAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

        //                       _otherProjectsScore = ((result.Select(t => t.OtherProjectsAlongRoad.CategoryMaxPoints).FirstOrDefault())
        //                                            /(result.Select(t => t.OtherProjectsAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault()))*100



        //                   }).ToList();

        //    //var trafficCount = (from tc in _context.TrafficSurvey
        //    //                   group tc by new { tc.RoadID, tc.TrafficSurveyYear } into result
        //    //                   select new { _year = result.Key.TrafficSurveyYear, _roadID = result.Key.RoadID, 
        //    //                   _trafficCount = (result.Sum(t => t.TrafficCount))>50 ? from t in _context.TrafficPerDayPoints where t.CriteriaWeightID==4  select(t.CateogryMaxPoints) :
        //    //                   from x in _context.TrafficPerDayPoints where x.CriteriaWeightID == 4 select (x.CateogryMaxPoints)

        //    //                   } into tCount
        //    //                   orderby tCount._year descending, tCount._trafficCount descending
        //    //                   select tCount).ToList();

        //    var trafficCountScore =  _context.Database.SqlQuery<TrafficScoreCalculationResult>("TrafficScoreCalculation").ToList();


        //    var comb = (from co in mcMatrix
        //                join tc in trafficCountScore
        //                 on new { coRID = Convert.ToInt32(co._roadID), coYe = Convert.ToInt32(co._year) } equals
        //                 new { coRID = Convert.ToInt32(tc.RoadID), coYe = Convert.ToInt32(tc.TcYear) }
        //                 join rgis in _context.RoadsGISData.AsQueryable() on co._roadID equals rgis.RoadID
        //                 join perUser in _context.RoadsPerUser.AsQueryable() on co._roadID equals perUser.RoadID
        //                select new 
        //                {
        //                    Year = co._year,
        //                    RoadID = co._roadID,
        //                    RID = tc.RoadID,
        //                    TCYear = tc.TcYear,
        //                   Zone = perUser.AdminBoundary.ZoneName,
        //                   Woreda= perUser.AdminBoundary.WoredaName,
        //                    RoadOriginDestination = rgis.RoadOriginDestination,
        //                    BenefitFactor =
        //                            (co._TradingCenterScore +
        //                            co.__KebeleVillageCommScore +
        //                            co._roadClassScore +
        //                            co._roadThroughFarmLandScore +
        //                            co._cooperativesScore +
        //                            co._marketsScore +
        //                            co._healthCenterScore +
        //                            co._educationCentersScore+
        //                            co._otherProjectsScore+
        //                            tc.CriteriaScore)/10,


        //                    TrafficPerDay = tc.TCount,
        //                    TrafficFlowPoint = tc.CategoryMaxPoints,
        //                    //        trafficCriteriaWeight = tc.CriteriaWeight,
        //                    TrafficFlowScore = tc.CriteriaScore,


        //                   TradingCenters = co._TradingCenterCategory,
        //                    TradingCentersPoint = co._TradingCenterPoint,
        //                    //  co._TradingCenterWeight,
        //                    TradingCenterScore=  co._TradingCenterScore,

        //                     KebelesVillagesCommunitiesConnected= co._KebeleVillageCommunity,
        //                    KebelesVillagesCommunitiesConnectedPoint =  co._KebeleVillageCommPoint,
        //                    //   co._KebeleVillageCommWeight,
        //                    KebelesVillagesCommunitiesConnectedScore = co.__KebeleVillageCommScore,

        //                    RoadClassification = co._roadClassDescription,
        //                    RoadClassificationPoint =  co._roadClassPoint,
        //                    //   co._roadClassWeight,
        //                    RoadClassificationScore = co._roadClassScore,

        //                    RoadTraversesFarmland = co._roadThroughFarmLand,
        //                    RoadTraversesFarmlandPoint = co._roadThroughFarmLandPoint,
        //                    //     co._roadThroughFarmLandWeight,
        //                    RoadTraversesFarmlandScore= co._roadThroughFarmLandScore,

        //                    CooperativeCentersAlongRoad = co._cooperativesDescription,
        //                    CooperativeCentersPoint =  co._cooperativesPoint,
        //                    //     co._cooperativesWeight,
        //                    CooperativeCentersAlongRoadScore = co._cooperativesScore,

        //                    MarketsConnectByRoad = co._marketsDescription,
        //                    MarketsConnectByRoadPoint = co._marketsPoint,
        //                    //       co._marketsWeight,
        //                    MarketsConnectByRoadScore =  co._marketsScore,

        //                    HealthCentersAlongRoad =  co._healthCentersDescription,
        //                    HealthCentersAlongRoadPoint = co._healthCentersPoint,
        //                    //      co._healthCenterWeight,
        //                    HealthCentersAlongRoadScore = co._healthCenterScore,

        //                    EducationCentersConnected = co._educationCentersDescription,
        //                    EducationCentersConnectedPoint = co._educationCentersPoint,
        //                    //       co._educationCentersWeight,
        //                    EducationCentersConnectedScore = co._educationCentersScore,

        //                    OtherProjectsAlongRoad = co._otherProjectsDescription,
        //                    OtherProjectsAlongRoadPoint = co._otherProjectsPoint,
        //                    //       co._otherProjectsWeight,
        //                    OtherProjectsAlongRoadScore = co._otherProjectsScore


        //                });


        //               //into p
        //               //select p;

        //    var g = comb.ToList();





        //    //foreach (var t in mcMatrix)
        //    //{
        //    //    var x = t._TradingCenterPoint;
        //    //}
        //   // gridControl1.DataSource = comb.ToList();
        //}

        ////private static Expression<Func<int,decimal,decimal>> Predicate(int _year, decimal _trafficCount)
        ////{
        ////    RAMSDBEntities _context = new RAMSDBEntities();
        ////    decimal point = 0;

        ////    var trafficPerDayPoints = _context.TrafficPerDayPoints.ToList();

        ////    if (_trafficCount > 50)
        ////    {
        ////        return trafficPerDayPoints.Where(t => t.TrafficPerDayPointsID == 4).Where(t => t.CriteriaWeight.Year == _year)
        ////            .Select(g => g.CateogryMaxPoints.GetValueOrDefault()).FirstOrDefault();

        ////    }
        ////    //elseif (trafficCount>)

        ////    //switch (trafficCount)
        ////    //{
        ////    //    case (trafficCount == 50):
        ////    //        t = x.Select(g => g.CriteriaWeightID).FirstOrDefault();
        ////    //        break;
        ////    //}

        ////    //return point;
        ////}

        //private decimal TSurvey(int _year, decimal _trafficCount)
        //{
        //    decimal point=0;

        //    var trafficPerDayPoints = _context.TrafficPerDayPoints.ToList();

        //    if (_trafficCount > 50)
        //    {
        //        point = trafficPerDayPoints.Where(t=>t.TrafficPerDayPointsID==4).Where(t=>t.CriteriaWeight.Year==_year)
        //            .Select(g => g.CateogryMaxPoints.GetValueOrDefault()).FirstOrDefault();

        //    }
        //    //elseif (trafficCount>)

        //    //switch (trafficCount)
        //    //{
        //    //    case (trafficCount == 50):
        //    //        t = x.Select(g => g.CriteriaWeightID).FirstOrDefault();
        //    //        break;
        //    //}

        //    return point;
        //}
    }
}