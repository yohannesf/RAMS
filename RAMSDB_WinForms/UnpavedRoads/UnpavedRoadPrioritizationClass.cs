using RAMSDB_WinForms.UnpavedRoads;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RAMSDB.Data
{

    public class CostPerRoad
    {
        public int Year { get; set; }
        public Guid RoadID { get; set; }
        public int AdminID { get; set; }
        public decimal TotalCost { get; set; }

        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string OriginDestination { get; set; }
        public decimal RoadLength { get; set; }
        public string Classification { get; set; }
        public string SurfaceType { get; set; }
    }

    public class MultiCriteriaMatrix
    {
        public int Year { get; set; }
        public Guid RoadID { get; set; }
        public int AdminID { get; set; }
        public Guid RID { get; set; }
        public int TCYear { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string RoadOriginDestination { get; set; }
        public decimal BenefitFactor { get; set; }
        public decimal TrafficPerDay { get; set; }
        public decimal TrafficFlowPoint { get; set; }
        public decimal TrafficFlowScore { get; set; }
        public string TradingCenters { get; set; }
        public decimal TradingCentersPoint { get; set; }
        public decimal TradingCenterScore { get; set; }
        public string KebelesVillagesCommunitiesConnected { get; set; }
        public decimal KebelesVillagesCommunitiesConnectedPoint { get; set; }
        public decimal KebelesVillagesCommunitiesConnectedScore { get; set; }
        public string RoadClassification { get; set; }
        public decimal RoadClassificationPoint { get; set; }
        public decimal RoadClassificationScore { get; set; }
        public string RoadTraversesFarmland { get; set; }
        public decimal RoadTraversesFarmlandPoint { get; set; }
        public decimal RoadTraversesFarmlandScore { get; set; }
        public string CooperativeCentersAlongRoad { get; set; }
        public decimal CooperativeCentersPoint { get; set; }
        public decimal CooperativeCentersAlongRoadScore { get; set; }
        public string MarketsConnectByRoad { get; set; }
        public decimal MarketsConnectByRoadPoint { get; set; }
        public decimal MarketsConnectByRoadScore { get; set; }
        public string HealthCentersAlongRoad { get; set; }
        public decimal HealthCentersAlongRoadPoint { get; set; }
        public decimal HealthCentersAlongRoadScore { get; set; }
        public string EducationCentersConnected { get; set; }
        public decimal EducationCentersConnectedPoint { get; set; }
        public decimal EducationCentersConnectedScore { get; set; }
        public string OtherProjectsAlongRoad { get; set; }
        public decimal OtherProjectsAlongRoadPoint { get; set; }
        public decimal OtherProjectsAlongRoadScore { get; set; }
    }

    public class PopulationServedPerRoad
    {

        public Guid RoadID { get; set; }
        public int AdminID { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string OriginDestination { get; set; }
        public decimal RoadLength { get; set; }
        public decimal RoadLengthWoredaTotal { get; set; }
        public decimal WoredaPopulation { get; set; }
        public decimal PopulationServed { get; set; }
    }

    public class PrioritizedRoads
    {
        public int Year { get; set; }
        public Guid RoadID { get; set; }
        public int AdminID { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string RoadOriginDestination { get; set; }
        public string RoadSurfaceType { get; set; }
        public string RoadClass { get; set; }
        public decimal PopulationServed { get; set; }
        public decimal BenefitFactor { get; set; }
        public decimal TotalCost { get; set; }
        public decimal OverallScore { get; set; }
    }

    class UnpavedRoadPrioritizationClass
    {
        RAMSDBEntities _context = new RAMSDBEntities();

        //ObservableCollection<CostPerRoad> tc = new ObservableCollection<CostPerRoad>();

        //BindingList<CostPerRoad> costPerRoads = new BindingList<CostPerRoad>();
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;


        IQueryable<CostPerRoad> costPerRoad = new List<CostPerRoad>().AsQueryable();
        IQueryable<MultiCriteriaMatrix> multiCriterias = new List<MultiCriteriaMatrix>().AsQueryable();
        IQueryable<PopulationServedPerRoad> populationServed = new List<PopulationServedPerRoad>().AsQueryable();
        IQueryable<PrioritizedRoads> prioritizedRoads = new List<PrioritizedRoads>().AsQueryable();
        List<Guid> roadsAssignedForUser = new List<Guid>();// dataLoader.roadsPerUserDL.Select(x => x.RoadID).ToList();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public UnpavedRoadPrioritizationClass()
        {
            //TotalCostPerRoad();
            // roadsAssignedForUser = dataLoader.roadsPerUserDL.Select(x => x.RoadID).ToList();
            roadsAssignedForUser = dataLoader.unpavedRoadsPerUserDL.Select(x => x.RoadID).ToList();

        }

        #region PopulationServerd

        public IQueryable<PopulationServedPerRoad> PopServed(string roadType)
        {

            //!!!!!!!!!----------------REMEMBER TO CHANGE REGION NAME BY VARIABLE

            // string regionName = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
            // string regionName = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserRoles.Select(c=>c.use)

            roadType = roadType.ToLower();

            var populationByWoreda = (from p in _context.AdminBoundary
                                      where p.RegionName == _region
                                      select new { _adminID = p.AdminID, _woredaName = p.WoredaName, _population = p.Population }).ToList();


            //var populationByWoreda = (from p in _context.AdminBoundary where p.RegionName == "SNNP" select new { _adminID = p.AdminID, _woredaName = p.WoredaName, _population = p.Population }).ToList();

            List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();


            if (roadType == "unpaved")
            {
                roadsPerUser = dataLoader.unpavedRoadsPerUserDL.ToList();

            }
            if (roadType == "paved")
            {
                roadsPerUser = dataLoader.pavedRoadsPerUserDL.ToList();

            }

            var totalLengthofRoadsByWoreda = (from road in roadsPerUser
                                              join roadInfo in _context.RoadsGISData on road.RoadID equals roadInfo.RoadID
                                              join adminInfo in _context.AdminBoundary on road.AdminID equals adminInfo.AdminID
                                              group road by new { adminInfo.AdminID, adminInfo.WoredaName }
                                             into result
                                              select new
                                              {
                                                  _adminID = result.Key.AdminID,
                                                  _wordaName = result.Key.WoredaName,
                                                  _woredaRoadLength = result.Sum(c => c.RoadsGISData.RoadLengthInKm)
                                              }).ToList();

            // var roadsPerUser = _context.RoadsPerUser.Include("RoadsGISData").ToList();

            // var roadsPerUser = dataLoader.roadsPerUserDL.ToList();

            // var roadsPerUser = dataLoader.unpavedRoadsPerUserDL.ToList();


            populationServed = (from r in roadsPerUser
                                join p in populationByWoreda on r.AdminID equals p._adminID
                                join t in totalLengthofRoadsByWoreda on r.AdminID equals t._adminID
                                orderby r.AdminBoundary.ZoneName, r.AdminBoundary.WoredaName, r.RoadsGISData.RoadOriginDestination
                                select new PopulationServedPerRoad
                                {
                                    RoadID = r.RoadID,
                                    AdminID = r.AdminID,
                                    Zone = r.AdminBoundary.ZoneName,
                                    Woreda = r.AdminBoundary.WoredaName,
                                    OriginDestination = r.RoadsGISData.RoadOriginDestination,
                                    RoadLength = (decimal)r.RoadsGISData.RoadLengthInKm,


                                    RoadLengthWoredaTotal = (decimal)t._woredaRoadLength,
                                    WoredaPopulation = (decimal)p._population,
                                    
                                    PopulationServed = (decimal)r.RoadsGISData.PopulationServed
                                }).AsQueryable();


            /*
             * populationServed = (from r in roadsPerUser
                                join p in populationByWoreda on r.AdminID equals p._adminID
                                join t in totalLengthofRoadsByWoreda on r.AdminID equals t._adminID
                                orderby r.AdminBoundary.ZoneName, r.AdminBoundary.WoredaName, r.RoadsGISData.RoadOriginDestination
                                select new PopulationServedPerRoad
                                {
                                    RoadID = r.RoadID,
                                    AdminID = r.AdminID,
                                    Zone = r.AdminBoundary.ZoneName,
                                    Woreda = r.AdminBoundary.WoredaName,
                                    OriginDestination = r.RoadsGISData.RoadOriginDestination,
                                    RoadLength = (decimal)r.RoadsGISData.RoadLengthInKm,


                                    RoadLengthWoredaTotal = (decimal)t._woredaRoadLength,
                                    WoredaPopulation = (decimal)p._population,
                                    PopulationServed = p._population.GetValueOrDefault() * ((r.RoadsGISData.RoadLengthInKm.GetValueOrDefault()) / t._woredaRoadLength.GetValueOrDefault())
                                }).AsQueryable();
            */

            return populationServed;

        }
        #endregion



        #region Multi-Criteria Analysis
        public IQueryable<MultiCriteriaMatrix> MultiCriteriaAnalysis(int year)

        {

            //var c = _context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList().Count;
            //var d = _context.MultiCriteriaAnalysisData.ToList().Count();

            var mcWeights = _context.CriteriaWeight.ToList();


            #region Phase1
            var mcMatrix = (from mc in _context.MultiCriteriaAnalysisData.
                            Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == year).ToList()

                            group mc by new { mc.Year, mc.RoadID } into result
                            select new
                            {
                                _year = result.Key.Year,
                                _roadID = (Guid)result.Key.RoadID,

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

            // trafficCountScore.Where(t=>t.TcYear==year).ToList()

            //on new { coRID = Convert.ToInt32(co._roadID), coYe = Convert.ToInt32(co._year) } equals
            //                   new { coRID = Convert.ToInt32(tc.RoadID), coYe = Convert.ToInt32(tc.TcYear) }

            multiCriterias = (from co in mcMatrix
                              join tc in trafficCountScore
                               on new { coRID =(Guid)co._roadID, coYe = Convert.ToInt32(co._year) } equals
                               new { coRID = (Guid)tc.RoadID, coYe = Convert.ToInt32(tc.TcYear) }
                              join rgis in _context.RoadsGISData.AsQueryable() on co._roadID equals rgis.RoadID
                              join perUser in _context.RoadsPerUser.AsQueryable() on co._roadID equals perUser.RoadID
                              select new MultiCriteriaMatrix
                              {
                                  Year = co._year,
                                  RoadID = (Guid)co._roadID,
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

        public IQueryable<MultiCriteriaMatrix> MultiCriteriaAnalysis()

        {

            //var c = _context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList().Count;
            //var d = _context.MultiCriteriaAnalysisData.ToList().Count();

            var mcWeights = _context.CriteriaWeight.ToList();


            #region Phase1
            var mcMatrix = (from mc in _context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList()

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



            var trafficCountScore = _context.Database.SqlQuery<TrafficScoreCalculationResult>("TrafficScoreCalculation").ToList();


            multiCriterias = (from co in mcMatrix
                              join tc in trafficCountScore
                               on new { coRID = Convert.ToInt32(co._roadID), coYe = Convert.ToInt32(co._year) } equals
                               new { coRID = Convert.ToInt32(tc.RoadID), coYe = Convert.ToInt32(tc.TcYear) }
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

        #region TotalCostPerRoad()

        public IQueryable<CostPerRoad> TotalCostPerRoad(int year)
        {


            UnpavedCreateTentativePlan utp = new UnpavedCreateTentativePlan();

            utp.CreateTentative(year);



            var perRoadperCatCost = from tc in _context.UnpavedTentativeRoadMaintenancePlan
                                    where tc.Year == year
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

          

            return costPerRoad.Where(p => roadsAssignedForUser.Contains(p.RoadID));


        }


        //public IQueryable<CostPerRoad> TotalCostPerRoad()
        //{


        //    UnpavedCreateTentativePlan utp = new UnpavedCreateTentativePlan();

        //    utp.CreateTentative();



        //    var perRoadperCatCost = from tc in _context.UnpavedTentativeRoadMaintenancePlan
        //                            join uc in _context.UnpavedRoadUnitCost on tc.CatWorkID equals uc.CatWorkID
        //                            let q = tc.Length * uc.UnpavedUnitCost
        //                            group tc by new { tc.Year, tc.RoadID, q } into result

        //                            // select new {result.Key.Year, result.Key.Year, (result.Key.q).GetValueOrDefault().}

        //                            select new
        //                            {
        //                                result.Key.Year,
        //                                result.Key.RoadID,

        //                                perRowCost = (result.Select(c => c.Length).FirstOrDefault() *
        //                                 (from c in result select c.UnpavedCategoryofWork.UnpavedRoadUnitCosts.Select(t => t.UnpavedUnitCost).Sum()).FirstOrDefault())
        //                            };



        //    var totalCostPerRoad = from tc in perRoadperCatCost
        //                           group tc by new { tc.Year, tc.RoadID } into result
        //                           orderby result.Key.Year descending
        //                           select new { result.Key.Year, result.Key.RoadID, TotalCost = result.Select(c => c.perRowCost).Sum() };



        //    var perUser = _context.RoadsPerUser.AsQueryable();

        //    var admin = _context.AdminBoundary.AsQueryable();
        //    var roadGIS = _context.RoadsGISData.AsQueryable();//.ToList();




        //    costPerRoad = (from t in totalCostPerRoad
        //                  join g in roadGIS on t.RoadID equals g.RoadID
        //                  join p in perUser on t.RoadID equals p.RoadID
        //                  orderby t.Year descending
        //                  select new CostPerRoad
        //                  {
        //                      Year = t.Year,
        //                      RoadID = t.RoadID,
        //                      AdminID = p.AdminBoundary.AdminID,
        //                      TotalCost = (decimal)t.TotalCost,
        //                      Zone = p.AdminBoundary.ZoneName,
        //                      Woreda = p.AdminBoundary.WoredaName,
        //                      OriginDestination = g.RoadOriginDestination,
        //                      RoadLength = (decimal)g.RoadLengthInKm,
        //                      Classification = g.RoadClassification.RoadClassificationDescription,
        //                      SurfaceType = g.RoadSurfaceType.SurfaceTypeName
        //                  }) ;

        //    return costPerRoad.Where(p => roadsAssignedForUser.Contains(p.RoadID));


        //}
        #endregion

        #region Prioritization
        public IQueryable<PrioritizedRoads> RunPrioritization(int year)
        {
            // _ = TotalCostPerRoad();
            List<CostPerRoad> cost = new List<CostPerRoad>();
            List<MultiCriteriaMatrix> matrices = new List<MultiCriteriaMatrix>();
            List<PopulationServedPerRoad> pop = new List<PopulationServedPerRoad>();


            pop = PopServed("unpaved").ToList();
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
                                    ((ps == null ? 0 : ps.PopulationServed) * (ms == null ? 0 : ms.BenefitFactor)) / (c.TotalCost*100)
                                    //OverallScore = c.TotalCost == 0 ? 0 : ((rs.PopulationServed) * (ls.BenefitFactor)) / c.TotalCost
                                }).AsQueryable();




            return prioritizedRoads.Where(p => roadsAssignedForUser.Contains(p.RoadID));
            // return prioritizedRoads;

        }

        //public IQueryable<PrioritizedRoads> RunPrioritization()
        //{
        //   // _ = TotalCostPerRoad();
        //    List<CostPerRoad> cost = new List<CostPerRoad>();
        //    List<MultiCriteriaMatrix> matrices = new List<MultiCriteriaMatrix>();
        //    List<PopulationServedPerRoad> pop = new List<PopulationServedPerRoad>();


        //     pop = PopServed("unpaved").ToList();
        //     cost = TotalCostPerRoad().ToList();
        //     matrices = MultiCriteriaAnalysis().ToList();

        //    //var pop = PopServed().ToList();
        //    //var cost = TotalCostPerRoad().ToList();
        //    //var matrices = MultiCriteriaAnalysis().ToList();

        //    var t = cost.ToList().Count;
        //    var x = matrices.ToList().Count;
        //    var z = pop.ToList().Count;

        //    foreach(var tx in matrices)
        //    {
        //        var c = tx.BenefitFactor;
        //    }

        //    prioritizedRoads = (from c in cost
        //             join mc in matrices on c.RoadID equals mc.RoadID
        //             join p in pop on c.RoadID equals p.RoadID

        //             select new PrioritizedRoads
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
        //                 BenefitFactor =   mc.BenefitFactor,
        //                 TotalCost = c.TotalCost,
        //                 OverallScore = c.TotalCost == 0 ? 0 : ((p.PopulationServed) * (mc.BenefitFactor)) / c.TotalCost
        //             }).AsQueryable();

        //    return prioritizedRoads.Where(p => roadsAssignedForUser.Contains(p.RoadID));
        //   // return prioritizedRoads;

        //}
        #endregion
    }
}
