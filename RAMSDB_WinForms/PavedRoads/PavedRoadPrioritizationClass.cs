using RAMSDB_WinForms.PavedRoads;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RAMSDB.Data
{
    //public class CostPerRoad
    //{
    //    public int Year { get; set; }
    //    public int RoadID { get; set; }
    //    public int AdminID { get; set; }
    //    public decimal TotalCost { get; set; }

    //    public string Zone { get; set; }
    //    public string Woreda { get; set; }
    //    public string OriginDestination { get; set; }
    //    public decimal RoadLength { get; set; }
    //    public string Classification { get; set; }
    //    public string SurfaceType { get; set; }
    //}

    //public class MultiCriteriaMatrix
    //{
    //    public int Year { get; set; }
    //    public int RoadID { get; set; }
    //    public int AdminID { get; set; }
    //    public int RID { get; set; }
    //    public int TCYear { get; set; }
    //    public string Zone { get; set; }
    //    public string Woreda { get; set; }
    //    public string RoadOriginDestination { get; set; }
    //    public decimal BenefitFactor { get; set; }
    //    public decimal TrafficPerDay { get; set; }
    //    public decimal TrafficFlowPoint { get; set; }
    //    public decimal TrafficFlowScore { get; set; }
    //    public string TradingCenters { get; set; }
    //    public decimal TradingCentersPoint { get; set; }
    //    public decimal TradingCenterScore { get; set; }
    //    public string KebelesVillagesCommunitiesConnected { get; set; }
    //    public decimal KebelesVillagesCommunitiesConnectedPoint { get; set; }
    //    public decimal KebelesVillagesCommunitiesConnectedScore { get; set; }
    //    public string RoadClassification { get; set; }
    //    public decimal RoadClassificationPoint { get; set; }
    //    public decimal RoadClassificationScore { get; set; }
    //    public string RoadTraversesFarmland { get; set; }
    //    public decimal RoadTraversesFarmlandPoint { get; set; }
    //    public decimal RoadTraversesFarmlandScore { get; set; }
    //    public string CooperativeCentersAlongRoad { get; set; }
    //    public decimal CooperativeCentersPoint { get; set; }
    //    public decimal CooperativeCentersAlongRoadScore { get; set; }
    //    public string MarketsConnectByRoad { get; set; }
    //    public decimal MarketsConnectByRoadPoint { get; set; }
    //    public decimal MarketsConnectByRoadScore { get; set; }
    //    public string HealthCentersAlongRoad { get; set; }
    //    public decimal HealthCentersAlongRoadPoint { get; set; }
    //    public decimal HealthCentersAlongRoadScore { get; set; }
    //    public string EducationCentersConnected { get; set; }
    //    public decimal EducationCentersConnectedPoint { get; set; }
    //    public decimal EducationCentersConnectedScore { get; set; }
    //    public string OtherProjectsAlongRoad { get; set; }
    //    public decimal OtherProjectsAlongRoadPoint { get; set; }
    //    public decimal OtherProjectsAlongRoadScore { get; set; }
    //}

    //public class PopulationServedPerRoad
    //{

    //    public int RoadID { get; set; }
    //    public int AdminID { get; set; }
    //    public string Zone { get; set; }
    //    public string Woreda { get; set; }
    //    public string OriginDestination { get; set; }
    //    public decimal RoadLength { get; set; }
    //    public decimal RoadLengthWoredaTotal { get; set; }
    //    public decimal WoredaPopulation { get; set; }
    //    public decimal PopulationServed { get; set; }
    //}

    //public class PrioritizedRoads
    //{
    //    public int Year { get; set; }
    //    public int RoadID { get; set; }
    //    public int AdminID { get; set; }
    //    public string Zone { get; set; }
    //    public string Woreda { get; set; }
    //    public string RoadOriginDestination { get; set; }
    //    public string RoadSurfaceType { get; set; }
    //    public string RoadClass { get; set; }
    //    public decimal PopulationServed { get; set; }
    //    public decimal BenefitFactor { get; set; }
    //    public decimal TotalCost { get; set; }
    //    public decimal OverallScore { get; set; }
    //}

    class PavedRoadPrioritizationClass
    {
        RAMSDBEntities _context = new RAMSDBEntities();

        IQueryable<CostPerRoad> costPerRoad = new List<CostPerRoad>().AsQueryable();
        IQueryable<MultiCriteriaMatrix> multiCriterias = new List<MultiCriteriaMatrix>().AsQueryable();
        IQueryable<PopulationServedPerRoad> populationServed = new List<PopulationServedPerRoad>().AsQueryable();
        IQueryable<PrioritizedRoads> prioritizedRoads = new List<PrioritizedRoads>().AsQueryable();
        List<Guid> roadsAssignedForUser = new List<Guid>();// dataLoader.roadsPerUserDL.Select(x => x.RoadID).ToList();
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public PavedRoadPrioritizationClass()
        {
            //TotalCostPerRoad();
            //roadsAssignedForUser = dataLoader.roadsPerUserDL.Select(x => x.RoadID).ToList();
            roadsAssignedForUser = dataLoader.pavedRoadsPerUserDL.Select(x => x.RoadID).ToList();

        }



        #region TotalCostPerRoad()

        public IQueryable<CostPerRoad> TotalCostPerRoad(int year)
        {
            PavedCreateTentativePlan ptp = new PavedCreateTentativePlan();

            ptp.CreateTentative(year);

            var perRoadperCatCost = from trp in _context.PavedTentativeRoadMaintenancePlan
                                    where trp.Year == year
                                    join uc in _context.PavedRoadUnitCost on trp.CatWorkID equals uc.CatWorkID
                                    let tCost = trp.Quantity * uc.PavedUnitCost
                                    group trp by new { trp.Year, trp.RoadID, tCost } into result

                                    // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

                                    select new
                                    {
                                        result.Key.Year,
                                        result.Key.RoadID,


                                        perRowCost = (result.Select(c => c.Quantity).Sum() *
                                         (from c in result select c.PavedCategoryofWork.PavedRoadUnitCosts.Select(t => t.PavedUnitCost).Sum()).FirstOrDefault())
                                    };



            var totalCostPerRoad = from tc in perRoadperCatCost
                                   group tc by new { tc.Year, tc.RoadID } into result
                                   orderby result.Key.Year descending
                                   select new { result.Key.Year, result.Key.RoadID, TotalCost = result.Select(c => c.perRowCost).Sum() };

            //var zzz = totalCostPerRoad.ToList();

            var perUser = _context.RoadsPerUser.AsQueryable();

            // var ttt = perUser.ToList();

            var admin = _context.AdminBoundary.AsQueryable();
            var roadGIS = _context.RoadsGISData.AsQueryable();//.ToList();




            costPerRoad = (from t in totalCostPerRoad
                           join g in roadGIS on t.RoadID equals g.RoadID into rGIS
                           join p in perUser on t.RoadID equals p.RoadID into rPerUser
                           from ls in rGIS.DefaultIfEmpty()
                           from rs in rPerUser.DefaultIfEmpty()
                           orderby t.Year descending
                           select new CostPerRoad
                           {
                               Year = t.Year,
                               RoadID = t.RoadID,
                               AdminID = rs.AdminBoundary.AdminID,
                               TotalCost = (decimal)t.TotalCost,
                               Zone = rs.AdminBoundary.ZoneName,
                               Woreda = rs.AdminBoundary.WoredaName,
                               OriginDestination = ls.RoadOriginDestination,
                               RoadLength = (decimal)ls.RoadLengthInKm,
                               Classification = ls.RoadClassification.RoadClassificationDescription,
                               SurfaceType = ls.RoadSurfaceType.SurfaceTypeName
                           });

            //  var kkk = costPerRoad.ToList();

            return costPerRoad.Where(p => roadsAssignedForUser.Contains(p.RoadID));


        }

        public IQueryable<CostPerRoad> TotalCostPerRoad()
        {
            PavedCreateTentativePlan ptp = new PavedCreateTentativePlan();

            ptp.CreateTentative();

            var perRoadperCatCost = from trp in _context.PavedTentativeRoadMaintenancePlan
                                    join uc in _context.PavedRoadUnitCost on trp.CatWorkID equals uc.CatWorkID
                                    let tCost = trp.Quantity * uc.PavedUnitCost
                                    group trp by new { trp.Year, trp.RoadID, tCost } into result

                                    // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

                                    select new
                                    {
                                        result.Key.Year,
                                        result.Key.RoadID,


                                        perRowCost = (result.Select(c => c.Quantity).Sum() *
                                         (from c in result select c.PavedCategoryofWork.PavedRoadUnitCosts.Select(t => t.PavedUnitCost).Sum()).FirstOrDefault())
                                    };



            var totalCostPerRoad = from tc in perRoadperCatCost
                                   group tc by new { tc.Year, tc.RoadID } into result
                                   orderby result.Key.Year descending
                                   select new { result.Key.Year, result.Key.RoadID, TotalCost = result.Select(c => c.perRowCost).Sum() };

            //var zzz = totalCostPerRoad.ToList();

            var perUser = _context.RoadsPerUser.AsQueryable();

            // var ttt = perUser.ToList();

            var admin = _context.AdminBoundary.AsQueryable();
            var roadGIS = _context.RoadsGISData.AsQueryable();//.ToList();




            costPerRoad = (from t in totalCostPerRoad
                           join g in roadGIS on t.RoadID equals g.RoadID
                           join p in perUser on t.RoadID equals p.RoadID
                           orderby t.Year descending
                           select new CostPerRoad
                           {
                               Year = t.Year,
                               RoadID = t.RoadID,
                               AdminID = p.AdminBoundary.AdminID,
                               TotalCost = (decimal)t.TotalCost,
                               Zone = p.AdminBoundary.ZoneName,
                               Woreda = p.AdminBoundary.WoredaName,
                               OriginDestination = g.RoadOriginDestination,
                               RoadLength = (decimal)g.RoadLengthInKm,
                               Classification = g.RoadClassification.RoadClassificationDescription,
                               SurfaceType = g.RoadSurfaceType.SurfaceTypeName
                           });

            //  var kkk = costPerRoad.ToList();

            return costPerRoad.Where(p => roadsAssignedForUser.Contains(p.RoadID));


        }
        #endregion

        #region Multi-Criteria Analysis

        public IQueryable<MultiCriteriaMatrix> MultiCriteriaAnalysis(int year)

        {

            // var c = _context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList().Count;
            //var d = _context.MultiCriteriaAnalysisData.ToList().Count();

            var mcWeights = _context.CriteriaWeight.ToList();


            #region Phase1
            var mcMatrix = (from mc in _context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).
                                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == year).ToList()
                            group mc by new { mc.Year, mc.RoadID } into result
                            select new
                            {
                                _year = result.Key.Year,
                                _roadID = result.Key.RoadID,

                                //_trafficSurvey =  result.Select(t=>t.RoadsGISData.T)

                                //-------------Trading Center
                                _TradingCenterCategory = result.Select(t => t.TradingCentersAlongRoad.TradingCenterAlongCategory).FirstOrDefault(),
                                _TradingCenterPoint = result.Select(t => t.TradingCentersAlongRoad.CateogryMaxPoints).FirstOrDefault(),
                                _TradingCenterWeight = result.Select(t => t.TradingCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _TradingCenterScore = ((result.Select(t => t.TradingCentersAlongRoad.CateogryMaxPoints).FirstOrDefault())
                                                     / (result.Select(t => t.TradingCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,


                                //------------
                                _KebeleVillageCommunity = result.Select(t => t.KebelesVillagesCommunitiesConnected.KVCConnectedDescription).FirstOrDefault(),
                                _KebeleVillageCommPoint = result.Select(t => t.KebelesVillagesCommunitiesConnected.CategoryMaxPoints).FirstOrDefault(),
                                _KebeleVillageCommWeight = result.Select(t => t.KebelesVillagesCommunitiesConnected.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                __KebeleVillageCommScore = ((result.Select(t => t.KebelesVillagesCommunitiesConnected.CategoryMaxPoints).FirstOrDefault())
                                                             / (result.Select(t => t.KebelesVillagesCommunitiesConnected.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,


                                _roadClassDescription = result.Select(t => t.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault(),
                                _roadClassPoint = result.Select(t => t.RoadsGISData.RoadClassification.CategoryMaxPoint).FirstOrDefault(),
                                _roadClassWeight = result.Select(t => t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _roadClassScore = ((result.Select(t => t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())
                                                 / (result.Select(t => t.RoadsGISData.RoadClassification.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,

                                _roadThroughFarmLand = result.Select(t => t.RoadTraversesFarmland.RoadTravFarmDescription).FirstOrDefault(),
                                _roadThroughFarmLandPoint = result.Select(t => t.RoadTraversesFarmland.CategoryMaxPoints).FirstOrDefault(),
                                _roadThroughFarmLandWeight = result.Select(t => t.RoadTraversesFarmland.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _roadThroughFarmLandScore = ((result.Select(t => t.RoadTraversesFarmland.CategoryMaxPoints).FirstOrDefault())
                                                             / (result.Select(t => t.RoadTraversesFarmland.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,

                                _cooperativesDescription = result.Select(t => t.CooperativeCentersAlongRoad.CcentersAlongRoadDescription).FirstOrDefault(),
                                _cooperativesPoint = result.Select(t => t.CooperativeCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
                                _cooperativesWeight = result.Select(t => t.CooperativeCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _cooperativesScore = ((result.Select(t => t.CooperativeCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
                                                     / (result.Select(t => t.CooperativeCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,


                                _marketsDescription = result.Select(t => t.MarketsConnectByRoad.MarketsConnectByRoadDescription).FirstOrDefault(),
                                _marketsPoint = result.Select(t => t.MarketsConnectByRoad.CategoryMaxPoints).FirstOrDefault(),
                                _marketsWeight = result.Select(t => t.MarketsConnectByRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _marketsScore = ((result.Select(t => t.MarketsConnectByRoad.CategoryMaxPoints).FirstOrDefault())
                                                 / (result.Select(t => t.MarketsConnectByRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,


                                _healthCentersDescription = result.Select(t => t.HealthCentersAlongRoad.HealthCentersAlongRoadDescription).FirstOrDefault(),
                                _healthCentersPoint = result.Select(t => t.HealthCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
                                _healthCenterWeight = result.Select(t => t.HealthCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _healthCenterScore = ((result.Select(t => t.HealthCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
                                                     / (result.Select(t => t.HealthCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,


                                _educationCentersDescription = result.Select(t => t.EducationCentersAlongRoad.EducationCentersAlongRoadDescription).FirstOrDefault(),
                                _educationCentersPoint = result.Select(t => t.EducationCentersAlongRoad.CategoryMaxPoints).FirstOrDefault(),
                                _educationCentersWeight = result.Select(t => t.EducationCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _educationCentersScore = ((result.Select(t => t.EducationCentersAlongRoad.CategoryMaxPoints).FirstOrDefault())
                                                         / (result.Select(t => t.EducationCentersAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100,

                                _otherProjectsDescription = result.Select(t => t.OtherProjectsAlongRoad.OtherProjectsAlongRoadDescription).FirstOrDefault(),
                                _otherProjectsPoint = result.Select(t => t.OtherProjectsAlongRoad.CategoryMaxPoints).FirstOrDefault(),
                                _otherProjectsWeight = result.Select(t => t.OtherProjectsAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault(),

                                _otherProjectsScore = ((result.Select(t => t.OtherProjectsAlongRoad.CategoryMaxPoints).FirstOrDefault())
                                                     / (result.Select(t => t.OtherProjectsAlongRoad.CriteriaWeight.CriteriaWeightScore).FirstOrDefault())) * 100



                            }).ToList();
            #endregion



            var trafficCountScore = _context.Database.SqlQuery<TrafficScoreCalculationResult>("TrafficScoreCalculation").
                Where(t => t.TcYear == year).ToList();


            multiCriterias = (from co in mcMatrix
                              join tc in trafficCountScore
                               on new { coRID = (Guid)co._roadID, coYe = Convert.ToInt32(co._year) } equals
                               new { coRID = (Guid)tc.RoadID, coYe = Convert.ToInt32(tc.TcYear) }
                              join rgis in _context.RoadsGISData.AsQueryable() on co._roadID equals rgis.RoadID
                              join perUser in _context.RoadsPerUser.AsQueryable() on co._roadID equals perUser.RoadID
                              select new MultiCriteriaMatrix
                              {
                                  Year = co._year,
                                  RoadID = co._roadID,
                                  AdminID = perUser.AdminBoundary.AdminID,
                                  RID = (Guid)tc.RoadID,
                                  TCYear = (int)tc.TcYear,
                                  Zone = perUser.AdminBoundary.ZoneName,
                                  Woreda = perUser.AdminBoundary.WoredaName,
                                  RoadOriginDestination = rgis.RoadOriginDestination,
                                  BenefitFactor = (decimal)
                                          (co._TradingCenterScore +
                                          co.__KebeleVillageCommScore +
                                          co._roadClassScore +
                                          co._roadThroughFarmLandScore +
                                          co._cooperativesScore +
                                          co._marketsScore +
                                          co._healthCenterScore +
                                          co._educationCentersScore +
                                          co._otherProjectsScore +
                                          tc.CriteriaScore) / 10,


                                  TrafficPerDay = (decimal)tc.TCount,
                                  TrafficFlowPoint = (decimal)tc.CategoryMaxPoints,
                                  //        trafficCriteriaWeight = tc.CriteriaWeight,
                                  TrafficFlowScore = (decimal)tc.CriteriaScore,


                                  TradingCenters = co._TradingCenterCategory,
                                  TradingCentersPoint = (decimal)co._TradingCenterPoint,
                                  //  co._TradingCenterWeight,
                                  TradingCenterScore = (decimal)co._TradingCenterScore,

                                  KebelesVillagesCommunitiesConnected = co._KebeleVillageCommunity,
                                  KebelesVillagesCommunitiesConnectedPoint = (decimal)co._KebeleVillageCommPoint,
                                  //   co._KebeleVillageCommWeight,
                                  KebelesVillagesCommunitiesConnectedScore = (decimal)co.__KebeleVillageCommScore,

                                  RoadClassification = co._roadClassDescription,
                                  RoadClassificationPoint = (decimal)co._roadClassPoint,
                                  //   co._roadClassWeight,
                                  RoadClassificationScore = (decimal)co._roadClassScore,

                                  RoadTraversesFarmland = co._roadThroughFarmLand,
                                  RoadTraversesFarmlandPoint = (decimal)co._roadThroughFarmLandPoint,
                                  //     co._roadThroughFarmLandWeight,
                                  RoadTraversesFarmlandScore = (decimal)co._roadThroughFarmLandScore,

                                  CooperativeCentersAlongRoad = co._cooperativesDescription,
                                  CooperativeCentersPoint = (decimal)co._cooperativesPoint,
                                  //     co._cooperativesWeight,
                                  CooperativeCentersAlongRoadScore = (decimal)co._cooperativesScore,

                                  MarketsConnectByRoad = co._marketsDescription,
                                  MarketsConnectByRoadPoint = (decimal)co._marketsPoint,
                                  //       co._marketsWeight,
                                  MarketsConnectByRoadScore = (decimal)co._marketsScore,

                                  HealthCentersAlongRoad = co._healthCentersDescription,
                                  HealthCentersAlongRoadPoint = (decimal)co._healthCentersPoint,
                                  //      co._healthCenterWeight,
                                  HealthCentersAlongRoadScore = (decimal)co._healthCenterScore,

                                  EducationCentersConnected = co._educationCentersDescription,
                                  EducationCentersConnectedPoint = (decimal)co._educationCentersPoint,
                                  //       co._educationCentersWeight,
                                  EducationCentersConnectedScore = (decimal)co._educationCentersScore,

                                  OtherProjectsAlongRoad = co._otherProjectsDescription,
                                  OtherProjectsAlongRoadPoint = (decimal)co._otherProjectsPoint,
                                  //       co._otherProjectsWeight,
                                  OtherProjectsAlongRoadScore = (decimal)co._otherProjectsScore


                              }).AsQueryable();

            //foreach(var x in multiCriterias)
            //{
            //    var t = x.RoadOriginDestination;
            //}


            return multiCriterias;
            //return multiCriterias.Where(p => roadsAssignedForUser.Contains(p.RoadID));




            //return multiCriterias;


        }
        #endregion


        #region Prioritization
        public IQueryable<PrioritizedRoads> RunPrioritization(int year)
        {
            // _ = TotalCostPerRoad();
            List<CostPerRoad> cost = new List<CostPerRoad>();
            List<MultiCriteriaMatrix> matrices = new List<MultiCriteriaMatrix>();
            List<PopulationServedPerRoad> pop = new List<PopulationServedPerRoad>();
            UnpavedRoadPrioritizationClass uRPC = new UnpavedRoadPrioritizationClass();


            pop = uRPC.PopServed("paved").ToList();
            cost = TotalCostPerRoad(year).ToList();
            matrices = MultiCriteriaAnalysis(year).ToList();

            //var pop = PopServed().ToList();
            //var cost = TotalCostPerRoad().ToList();
            //var matrices = MultiCriteriaAnalysis().ToList();

            var t = cost.ToList().Count;
            var x = matrices.ToList().Count;
            var z = pop.ToList().Count;

            foreach (var tx in matrices)
            {
                var c = tx.BenefitFactor;
            }

            prioritizedRoads = (from c in cost
                                join mc in matrices on c.RoadID equals mc.RoadID into mcMatrices
                                join p in pop on c.RoadID equals p.RoadID into popServed
                                from ms in mcMatrices.DefaultIfEmpty()
                                from ps in popServed.DefaultIfEmpty()
                                select new PrioritizedRoads
                                {
                                    Year = c.Year,
                                    RoadID = c.RoadID,
                                    AdminID = c.AdminID,
                                    Zone = c.Zone,
                                    Woreda = c.Woreda,

                                    RoadOriginDestination = c.OriginDestination,
                                    RoadSurfaceType = c.SurfaceType,
                                    RoadClass = c.Classification,

                                    PopulationServed = ps == null ? 0 : ps.PopulationServed,// p.PopulationServed,
                                    BenefitFactor = ms == null ? 0 : ms.BenefitFactor,// mc.BenefitFactor,
                                    TotalCost = c.TotalCost,
                                    OverallScore = c.TotalCost == 0 ? 0 :
                                    ((ps == null ? 0 : ps.PopulationServed) * (ms == null ? 0 : ms.BenefitFactor)) / c.TotalCost
                                }).AsQueryable();

            return prioritizedRoads.Where(p => roadsAssignedForUser.Contains(p.RoadID)).OrderBy(p => p.RoadID);
            // return prioritizedRoads;

        }
        #endregion
    }
}
