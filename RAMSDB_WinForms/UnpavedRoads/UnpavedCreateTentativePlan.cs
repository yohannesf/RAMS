using RAMSDB.Data;
using System.Collections.Generic;
using System.Linq;


namespace RAMSDB_WinForms.UnpavedRoads
{
    class UnpavedCreateTentativePlan
    {

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();

        public void CreateTentative(int year)
        {
            // year = 2019;
            var urc = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RCSYear == year).ToList();

            var firstPhase = from u in urc
                             select new
                             {
                                 u.RCSID,
                                 u.RCSYear,
                                 u.RoadID,
                                 u.RoadsPerUser.AdminBoundary.ZoneName,
                                 u.RoadsPerUser.AdminBoundary.WoredaName,
                                 u.RoadsGISData.RoadOriginDestination,
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



            var clearExisitngData = dbContext.Database.ExecuteSqlCommand("Delete from UnpavedTentativeRoadMaintenancePlan where Year={0}", year);// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();



            //   var ttt = 1;

            List<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan> tplan = new List<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan>();
            // dbContext.                UnpavedTentativeRoadMaintenancePlan.Where(c=>c.Year==year).ToList();



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
        }
        //public void CreateTentative()
        //{
        //    var urc = dataLoader.unpavedRoadConditionSurveysDL.ToList();

        //    var firstPhase = from u in urc
        //                     select new
        //                     {
        //                         u.RCSID,
        //                         u.RCSYear,
        //                         u.RoadID,
        //                         u.RoadsPerUser.AdminBoundary.ZoneName,
        //                         u.RoadsPerUser.AdminBoundary.WoredaName,
        //                         u.RoadsGISData.RoadOriginDestination,
        //                         u.SectionLengthKM,
        //                         SurfaceConditionFactor = u.SurfaceCondition,


        //                         ShoulderConditionFactor = (u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

        //                                                 (double)((u.ShoulderConditionRight.GetValueOrDefault() + u.ShoulderConditionLeft.GetValueOrDefault()) /
        //                                                     (
        //                                                       (double)((u.ShoulderConditionRight.HasValue ? 1 : 0) + (u.ShoulderConditionLeft.HasValue ? 1 : 0))
        //                                                     )),



        //                         DrainageConditionFactor = (u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0) == 0 ? 0 :

        //                                                           (double)((u.DrainageConditionRight.GetValueOrDefault() + u.DrainageConditionLeft.GetValueOrDefault()) /
        //                                                               (
        //                                                                 (double)((u.DrainageConditionRight.HasValue ? 1 : 0) + (u.DrainageConditionLeft.HasValue ? 1 : 0))
        //                                                               ))


        //                     }
        //            ;


        //    var secondPhase = (from u in firstPhase
        //                       select new
        //                       {
        //                           u.RCSID,
        //                           u.RCSYear,
        //                           u.RoadID,
        //                           u.ZoneName,
        //                           u.WoredaName,
        //                           u.RoadOriginDestination,
        //                           u.SectionLengthKM,
        //                           u.SurfaceConditionFactor,
        //                           u.ShoulderConditionFactor,
        //                           u.DrainageConditionFactor,
        //                           MaintenanceConditionIndex = u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4,

        //                           RoutineMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false,
        //                           PeriodicMaintenance = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) > 1.5 ?
        //                                                 (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) < 2.5 ? true : false : false,
        //                           Rehabilitation = (u.SurfaceConditionFactor * 0.4 + u.ShoulderConditionFactor * 0.2 + u.DrainageConditionFactor * 0.4) >= 2.5 ? true : false
        //                       });



        //    var clearExisitngData = dbContext.Database.ExecuteSqlCommand("Delete from UnpavedTentativeRoadMaintenancePlan");// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();





        //    List<RAMSDBModel.UnpavedTentativeRoadMaintenancePlan> tplan = dbContext.UnpavedTentativeRoadMaintenancePlan.ToList();



        //    foreach (var roadSegment in secondPhase)
        //    {




        //        if (roadSegment.Rehabilitation)
        //        {
        //            RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
        //            tp.RCSID = roadSegment.RCSID;
        //            tp.RoadID = roadSegment.RoadID;

        //            tp.Year = roadSegment.RCSYear;
        //            //  tp.CatWorkID = 1;
        //            tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Rehabilitation").Select(c => c.CatWorkID).FirstOrDefault();
        //            tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();


        //            tplan.Add(tp);





        //        }

        //        if (roadSegment.RoutineMaintenance)
        //        {
        //            RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
        //            tp.RCSID = roadSegment.RCSID;
        //            tp.RoadID = roadSegment.RoadID;
        //            tp.Year = roadSegment.RCSYear;
        //            tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Routine Maintenance").Select(c => c.CatWorkID).FirstOrDefault();

        //            // tp.CatWorkID = 1;
        //            tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

        //            tplan.Add(tp);





        //        }

        //        if (roadSegment.PeriodicMaintenance)
        //        {
        //            RAMSDBModel.UnpavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.UnpavedTentativeRoadMaintenancePlan();
        //            tp.RCSID = roadSegment.RCSID;
        //            tp.RoadID = roadSegment.RoadID;
        //            tp.Year = roadSegment.RCSYear;
        //            tp.CatWorkID = dbContext.UnpavedCategoryofWork.Where(c => c.WorkDescription == "Periodic Maintenance").Select(c => c.CatWorkID).FirstOrDefault();

        //            //   tp.CatWorkID = 2;
        //            tp.Length = roadSegment.SectionLengthKM.GetValueOrDefault();

        //            tplan.Add(tp);




        //        }
        //    }



        //    dbContext.UnpavedTentativeRoadMaintenancePlan.AddRange(tplan);
        //    dbContext.SaveChanges();
        //}


        //}
    }
}
