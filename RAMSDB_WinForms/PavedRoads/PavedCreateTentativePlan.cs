using RAMSDB.Data;
using System.Collections.Generic;
using System.Linq;

namespace RAMSDB_WinForms.PavedRoads
{

    class PavedCreateTentativePlan
    {
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();

        public void CreateTentative(int year)
        {
            var prcsurvey = dataLoader.pavedRoadConditionSurveysDL.Where(c => c.PRCSYear == year).ToList();

            var leftSilt = dbContext.PavedSideDrainSilt.ToList();
            var rightSilt = dbContext.PavedSideDrainSilt.ToList();

            // MessageBox.Show(urc.Count().ToString());

            var firstPhase = from p in prcsurvey
                                 //Drainage

                             join lSilt in dbContext.PavedSideDrainSilt.ToList() on p.LeftDrainSilt equals lSilt.ID into leftDrainSilt
                             join rSilt in dbContext.PavedSideDrainSilt.ToList() on p.RightDrainSilt equals rSilt.ID into rightDrainSilt
                             join lScour in dbContext.PavedSideDrainScour.ToList() on p.LeftDrainScour equals lScour.ID into leftDrainScour
                             join rScour in dbContext.PavedSideDrainScour.ToList() on p.RightDrainScour equals rScour.ID into rightDrainScour

                             //Shoulder

                             join lShoulderScour in dbContext.PavedShoulderDeformationScour.ToList() on p.LeftShoulderDeformationScour equals lShoulderScour.ID into leftShoulderScour
                             join rShoulderScour in dbContext.PavedShoulderDeformationScour.ToList() on p.RightShoulderDeformationScour equals rShoulderScour.ID into rightShoulderScour

                             join lShoulderEDamage in dbContext.PavedShoulderEdgeDamage.ToList() on p.LeftShoulderEdgeDamage equals lShoulderEDamage.ID into leftShoulderEDamage
                             join rShoulderEDamage in dbContext.PavedShoulderEdgeDamage.ToList() on p.RightShoulderEdgeDamage equals rShoulderEDamage.ID into rightShoulderEDamage

                             join lShoulderEStep in dbContext.PavedShoulderEdgeStep.ToList() on p.LeftShoulderEdgeStep equals lShoulderEStep.ID into leftShoulderEStep
                             join rShoulderEStep in dbContext.PavedShoulderEdgeStep.ToList() on p.RightShoulderEdgeStep equals rShoulderEStep.ID into rightShoulderEStep

                             //CarraiageWay

                             join cwRutting in dbContext.PavedCarriagewayRutting.ToList() on p.CarriagewayRutting equals cwRutting.ID into cWayRutting
                             join cwCracking in dbContext.PavedCarriagewayCracking.ToList() on p.CarriagewayCracking equals cwCracking.ID into cWayCracking
                             join cwPotholes in dbContext.PavedCarriagewayPotholes.ToList() on p.CarriagewayPotholes equals cwPotholes.ID into cWayPotholes
                             join cwRavelling in dbContext.PavedCarriagewayRavellingBleeding.ToList() on p.CarriagewayRavellingBleeding equals cwRavelling.ID into cWayRavelling
                             join cwFailure in dbContext.PavedCarriagewayFailure.ToList() on p.CarriagewayFailure equals cwFailure.ID into cWayFailure

                             //Drainage
                             from ls in leftDrainSilt.DefaultIfEmpty()
                             from rs in rightDrainSilt.DefaultIfEmpty()
                             from lscr in leftDrainScour.DefaultIfEmpty()
                             from rscr in rightDrainScour.DefaultIfEmpty()

                                 //Shoulder
                             from rshscr in rightShoulderScour.DefaultIfEmpty()
                             from lshscr in leftShoulderScour.DefaultIfEmpty()
                             from lshEDamage in leftShoulderEDamage.DefaultIfEmpty()
                             from rshEDamage in rightShoulderEDamage.DefaultIfEmpty()
                             from lshEStep in leftShoulderEStep.DefaultIfEmpty()
                             from rshEStep in rightShoulderEStep.DefaultIfEmpty()

                                 //Carriageway
                             from cwrut in cWayRutting.DefaultIfEmpty()
                             from cwcrack in cWayCracking.DefaultIfEmpty()
                             from cwpot in cWayPotholes.DefaultIfEmpty()
                             from cwravel in cWayRavelling.DefaultIfEmpty()
                             from cwfail in cWayFailure.DefaultIfEmpty()

                             select new
                             {

                                 p.PRCSID,
                                 p.PRCSYear,
                                 p.RoadID,

                                 p.RoadsPerUser.AdminBoundary.ZoneName,
                                 p.RoadsPerUser.AdminBoundary.WoredaName,
                                 p.RoadsGISData.RoadOriginDestination,

                                 //Drainage Silt
                                 leftDrainageSiltRate = ls == null ? 0 : ls.SideDrainSiltRate,
                                 leftDrainageSiltQty = ls == null ? 0 : ls.QtyM3,
                                 leftDrainageSiltActivity = ls == null ? " " : ls.ActivityCode,

                                 rightDrainageSiltRate = rs == null ? 0 : rs.SideDrainSiltRate,
                                 rightDrainageSiltQty = rs == null ? 0 : rs.QtyM3,
                                 rightDrainageSiltActivity = rs == null ? " " : rs.ActivityCode,

                                 //Drainage Scour
                                 leftDrainageScourRate = lscr == null ? 0 : lscr.SideDrainScourRate,
                                 leftDrainageScourQty = lscr == null ? 0 : lscr.QtyM3,
                                 leftDrainageScourActivity = lscr == null ? " " : lscr.ActivityCode,

                                 rightDrainageScourRate = rscr == null ? 0 : rscr.SideDrainScourRate,
                                 rightDrainageScourQty = rscr == null ? 0 : rscr.QtyM3,
                                 rightDrainageScourActivity = rscr == null ? " " : rscr.ActivityCode,

                                 //Shoulder Scour
                                 leftShoulderScourRate = lshscr == null ? 0 : lshscr.ShoulderDeformationScourRate,
                                 leftShoulderScourQty = lshscr == null ? 0 : lshscr.QtyM3,
                                 leftShoulderScourActivity = lshscr == null ? " " : lshscr.ActivityCode,

                                 rightShoulderScourRate = rshscr == null ? 0 : rshscr.ShoulderDeformationScourRate,
                                 rightShoulderScourQty = rshscr == null ? 0 : rshscr.QtyM3,
                                 rightShoulderScourActivity = rshscr == null ? " " : rshscr.ActivityCode,

                                 leftShoulderEDamageRate = lshEDamage == null ? 0 : lshEDamage.EdgeDamageRate,
                                 leftShoulderEDamageQty = lshEDamage == null ? 0 : lshEDamage.QtyM3,
                                 leftShoulderEDamageActivity = lshEDamage == null ? " " : lshEDamage.ActivityCode,

                                 rightShoulderEDamageRate = rshEDamage == null ? 0 : rshEDamage.EdgeDamageRate,
                                 rightShoulderEDamageQty = rshEDamage == null ? 0 : rshEDamage.QtyM3,
                                 rightShoulderEDamageActivity = rshEDamage == null ? " " : rshEDamage.ActivityCode,

                                 leftShoulderEStepRate = lshEStep == null ? 0 : lshEStep.EdgeStepRate,
                                 leftShoulderEStepQty = lshEStep == null ? 0 : lshEStep.QtyM2,
                                 leftShoulderEStepActivity = lshEStep == null ? " " : lshEStep.ActivityCode,



                                 rightShoulderEStepRate = rshEStep == null ? 0 : rshEStep.EdgeStepRate,
                                 rightShoulderEStepQty = rshEStep == null ? 0 : rshEStep.QtyM2,
                                 rightShoulderEStepActivity = rshEStep == null ? " " : rshEStep.ActivityCode,

                                 //Carraigeway
                                 cwRuttingRate = cwrut == null ? 0 : cwrut.CarriagewayRuttingRate,
                                 cwRuttingQty = cwrut == null ? 0 : cwrut.QtyMM,
                                 cwRuttingActivity = cwrut == null ? " " : cwrut.ActivityCode,

                                 cwCrackingRate = cwcrack == null ? 0 : cwcrack.CarriagewayCrackingRate,
                                 cwCrackingQty = cwcrack == null ? 0 : cwcrack.QtyM2,
                                 cwCrackingActivity = cwcrack == null ? " " : cwcrack.ActivityCode,


                                 cwPotholeRate = cwpot == null ? 0 : cwpot.CarriagewayPotholesRate,
                                 cwPotholeQty = cwpot == null ? 0 : cwpot.QtyM3,
                                 cwPotholeActivity = cwpot == null ? " " : cwpot.ActivityCode,

                                 cwRavellingRate = cwravel == null ? 0 : cwravel.CarriagewayRavellingBleedingRate,
                                 cwRavellingQty = cwravel == null ? 0 : cwravel.QtyM2,
                                 cwRavellingActivity = cwravel == null ? " " : cwravel.ActivityCode,


                                 cwFailureRate = cwfail == null ? 0 : cwfail.CarriagewayFailureRate,
                                 cwFailureQty = cwfail == null ? 0 : cwfail.QtyM3,
                                 cwFailureActivity = cwfail == null ? " " : cwfail.ActivityCode,



                             }
                    ;




            var clearExisitngData = dbContext.Database.ExecuteSqlCommand("Delete from PavedTentativeRoadMaintenancePlan where Year = {0}", year);// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();





            List<RAMSDBModel.PavedTentativeRoadMaintenancePlan> tplan = new List<RAMSDBModel.PavedTentativeRoadMaintenancePlan>();
            // dbContext.PavedTentativeRoadMaintenancePlan.ToList();

            //   RAMSDBModel.PavedCategoryofWork cw = new RAMSDBModel.PavedCategoryofWork();

            foreach (var roadSegment in firstPhase)
            {
                //    RAMSDBModel.PavedCategoryofWork cw = new RAMSDBModel.PavedCategoryofWork();

                if (roadSegment.leftDrainageSiltRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftDrainageSiltActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftDrainageSiltQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightDrainageSiltRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightDrainageSiltActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightDrainageSiltQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftDrainageScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftDrainageScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftDrainageScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightDrainageScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightDrainageScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightDrainageScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderEDamageRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderEDamageActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderEDamageQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderEDamageRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderEDamageActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderEDamageQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderEStepRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderEStepActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderEStepQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderEStepRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderEStepActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderEStepQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwCrackingRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwCrackingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwCrackingQty;
                    tplan.Add(tp);
                }

                //if (roadSegment.cwRuttingRate != 0)
                //{
                //    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                //    tp.PRCSID = roadSegment.PRCSID;
                //    tp.RoadID = roadSegment.RoadID;

                //    tp.Year = roadSegment.PRCSYear;
                //    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwRuttingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                //    tp.Quantity = roadSegment.cwRuttingQty.GetValueOrDefault();
                //    tplan.Add(tp);
                //}

                if (roadSegment.cwPotholeRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwPotholeActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwPotholeQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwRavellingRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwRavellingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwRavellingQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwFailureRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwFailureActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwFailureQty;
                    tplan.Add(tp);
                }








            }




            dbContext.PavedTentativeRoadMaintenancePlan.AddRange(tplan);
            dbContext.SaveChanges();
        }

        public void CreateTentative()
        {
            var prcsurvey = dataLoader.pavedRoadConditionSurveysDL.ToList();

            var leftSilt = dbContext.PavedSideDrainSilt.ToList();
            var rightSilt = dbContext.PavedSideDrainSilt.ToList();

            // MessageBox.Show(urc.Count().ToString());

            var firstPhase = from p in prcsurvey
                                 //Drainage

                             join lSilt in dbContext.PavedSideDrainSilt.ToList() on p.LeftDrainSilt equals lSilt.ID into leftDrainSilt
                             join rSilt in dbContext.PavedSideDrainSilt.ToList() on p.RightDrainSilt equals rSilt.ID into rightDrainSilt
                             join lScour in dbContext.PavedSideDrainScour.ToList() on p.LeftDrainScour equals lScour.ID into leftDrainScour
                             join rScour in dbContext.PavedSideDrainScour.ToList() on p.RightDrainScour equals rScour.ID into rightDrainScour

                             //Shoulder

                             join lShoulderScour in dbContext.PavedShoulderDeformationScour.ToList() on p.LeftShoulderDeformationScour equals lShoulderScour.ID into leftShoulderScour
                             join rShoulderScour in dbContext.PavedShoulderDeformationScour.ToList() on p.RightShoulderDeformationScour equals rShoulderScour.ID into rightShoulderScour

                             join lShoulderEDamage in dbContext.PavedShoulderEdgeDamage.ToList() on p.LeftShoulderEdgeDamage equals lShoulderEDamage.ID into leftShoulderEDamage
                             join rShoulderEDamage in dbContext.PavedShoulderEdgeDamage.ToList() on p.RightShoulderEdgeDamage equals rShoulderEDamage.ID into rightShoulderEDamage

                             join lShoulderEStep in dbContext.PavedShoulderEdgeStep.ToList() on p.LeftShoulderEdgeStep equals lShoulderEStep.ID into leftShoulderEStep
                             join rShoulderEStep in dbContext.PavedShoulderEdgeStep.ToList() on p.RightShoulderEdgeStep equals rShoulderEStep.ID into rightShoulderEStep

                             //CarraiageWay

                             join cwRutting in dbContext.PavedCarriagewayRutting.ToList() on p.CarriagewayRutting equals cwRutting.ID into cWayRutting
                             join cwCracking in dbContext.PavedCarriagewayCracking.ToList() on p.CarriagewayCracking equals cwCracking.ID into cWayCracking
                             join cwPotholes in dbContext.PavedCarriagewayPotholes.ToList() on p.CarriagewayPotholes equals cwPotholes.ID into cWayPotholes
                             join cwRavelling in dbContext.PavedCarriagewayRavellingBleeding.ToList() on p.CarriagewayRavellingBleeding equals cwRavelling.ID into cWayRavelling
                             join cwFailure in dbContext.PavedCarriagewayFailure.ToList() on p.CarriagewayFailure equals cwFailure.ID into cWayFailure

                             //Drainage
                             from ls in leftDrainSilt.DefaultIfEmpty()
                             from rs in rightDrainSilt.DefaultIfEmpty()
                             from lscr in leftDrainScour.DefaultIfEmpty()
                             from rscr in rightDrainScour.DefaultIfEmpty()

                                 //Shoulder
                             from rshscr in rightShoulderScour.DefaultIfEmpty()
                             from lshscr in leftShoulderScour.DefaultIfEmpty()
                             from lshEDamage in leftShoulderEDamage.DefaultIfEmpty()
                             from rshEDamage in rightShoulderEDamage.DefaultIfEmpty()
                             from lshEStep in leftShoulderEStep.DefaultIfEmpty()
                             from rshEStep in rightShoulderEStep.DefaultIfEmpty()

                                 //Carriageway
                             from cwrut in cWayRutting.DefaultIfEmpty()
                             from cwcrack in cWayCracking.DefaultIfEmpty()
                             from cwpot in cWayPotholes.DefaultIfEmpty()
                             from cwravel in cWayRavelling.DefaultIfEmpty()
                             from cwfail in cWayFailure.DefaultIfEmpty()

                             select new
                             {

                                 p.PRCSID,
                                 p.PRCSYear,
                                 p.RoadID,

                                 p.RoadsPerUser.AdminBoundary.ZoneName,
                                 p.RoadsPerUser.AdminBoundary.WoredaName,
                                 p.RoadsGISData.RoadOriginDestination,

                                 //Drainage Silt
                                 leftDrainageSiltRate = ls == null ? 0 : ls.SideDrainSiltRate,
                                 leftDrainageSiltQty = ls == null ? 0 : ls.QtyM3,
                                 leftDrainageSiltActivity = ls == null ? " " : ls.ActivityCode,

                                 rightDrainageSiltRate = rs == null ? 0 : rs.SideDrainSiltRate,
                                 rightDrainageSiltQty = rs == null ? 0 : rs.QtyM3,
                                 rightDrainageSiltActivity = rs == null ? " " : rs.ActivityCode,

                                 //Drainage Scour
                                 leftDrainageScourRate = lscr == null ? 0 : lscr.SideDrainScourRate,
                                 leftDrainageScourQty = lscr == null ? 0 : lscr.QtyM3,
                                 leftDrainageScourActivity = lscr == null ? " " : lscr.ActivityCode,

                                 rightDrainageScourRate = rscr == null ? 0 : rscr.SideDrainScourRate,
                                 rightDrainageScourQty = rscr == null ? 0 : rscr.QtyM3,
                                 rightDrainageScourActivity = rscr == null ? " " : rscr.ActivityCode,

                                 //Shoulder Scour
                                 leftShoulderScourRate = lshscr == null ? 0 : lshscr.ShoulderDeformationScourRate,
                                 leftShoulderScourQty = lshscr == null ? 0 : lshscr.QtyM3,
                                 leftShoulderScourActivity = lshscr == null ? " " : lshscr.ActivityCode,

                                 rightShoulderScourRate = rshscr == null ? 0 : rshscr.ShoulderDeformationScourRate,
                                 rightShoulderScourQty = rshscr == null ? 0 : rshscr.QtyM3,
                                 rightShoulderScourActivity = rshscr == null ? " " : rshscr.ActivityCode,

                                 leftShoulderEDamageRate = lshEDamage == null ? 0 : lshEDamage.EdgeDamageRate,
                                 leftShoulderEDamageQty = lshEDamage == null ? 0 : lshEDamage.QtyM3,
                                 leftShoulderEDamageActivity = lshEDamage == null ? " " : lshEDamage.ActivityCode,

                                 rightShoulderEDamageRate = rshEDamage == null ? 0 : rshEDamage.EdgeDamageRate,
                                 rightShoulderEDamageQty = rshEDamage == null ? 0 : rshEDamage.QtyM3,
                                 rightShoulderEDamageActivity = rshEDamage == null ? " " : rshEDamage.ActivityCode,

                                 leftShoulderEStepRate = lshEStep == null ? 0 : lshEStep.EdgeStepRate,
                                 leftShoulderEStepQty = lshEStep == null ? 0 : lshEStep.QtyM2,
                                 leftShoulderEStepActivity = lshEStep == null ? " " : lshEStep.ActivityCode,



                                 rightShoulderEStepRate = rshEStep == null ? 0 : rshEStep.EdgeStepRate,
                                 rightShoulderEStepQty = rshEStep == null ? 0 : rshEStep.QtyM2,
                                 rightShoulderEStepActivity = rshEStep == null ? " " : rshEStep.ActivityCode,

                                 //Carraigeway
                                 cwRuttingRate = cwrut == null ? 0 : cwrut.CarriagewayRuttingRate,
                                 cwRuttingQty = cwrut == null ? 0 : cwrut.QtyMM,
                                 cwRuttingActivity = cwrut == null ? " " : cwrut.ActivityCode,

                                 cwCrackingRate = cwcrack == null ? 0 : cwcrack.CarriagewayCrackingRate,
                                 cwCrackingQty = cwcrack == null ? 0 : cwcrack.QtyM2,
                                 cwCrackingActivity = cwcrack == null ? " " : cwcrack.ActivityCode,


                                 cwPotholeRate = cwpot == null ? 0 : cwpot.CarriagewayPotholesRate,
                                 cwPotholeQty = cwpot == null ? 0 : cwpot.QtyM3,
                                 cwPotholeActivity = cwpot == null ? " " : cwpot.ActivityCode,

                                 cwRavellingRate = cwravel == null ? 0 : cwravel.CarriagewayRavellingBleedingRate,
                                 cwRavellingQty = cwravel == null ? 0 : cwravel.QtyM2,
                                 cwRavellingActivity = cwravel == null ? " " : cwravel.ActivityCode,


                                 cwFailureRate = cwfail == null ? 0 : cwfail.CarriagewayFailureRate,
                                 cwFailureQty = cwfail == null ? 0 : cwfail.QtyM3,
                                 cwFailureActivity = cwfail == null ? " " : cwfail.ActivityCode,



                             }
                    ;




            var clearExisitngData = dbContext.Database.ExecuteSqlCommand("Delete from PavedTentativeRoadMaintenancePlan");// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();





            List<RAMSDBModel.PavedTentativeRoadMaintenancePlan> tplan = dbContext.PavedTentativeRoadMaintenancePlan.ToList();

            //   RAMSDBModel.PavedCategoryofWork cw = new RAMSDBModel.PavedCategoryofWork();

            foreach (var roadSegment in firstPhase)
            {
                //    RAMSDBModel.PavedCategoryofWork cw = new RAMSDBModel.PavedCategoryofWork();

                if (roadSegment.leftDrainageSiltRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftDrainageSiltActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftDrainageSiltQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightDrainageSiltRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightDrainageSiltActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightDrainageSiltQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftDrainageScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftDrainageScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftDrainageScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightDrainageScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightDrainageScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightDrainageScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderScourRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderScourActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderScourQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderEDamageRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderEDamageActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderEDamageQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderEDamageRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderEDamageActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderEDamageQty;
                    tplan.Add(tp);
                }

                if (roadSegment.leftShoulderEStepRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.leftShoulderEStepActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.leftShoulderEStepQty;
                    tplan.Add(tp);
                }

                if (roadSegment.rightShoulderEStepRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.rightShoulderEStepActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.rightShoulderEStepQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwCrackingRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwCrackingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwCrackingQty;
                    tplan.Add(tp);
                }

                //if (roadSegment.cwRuttingRate != 0)
                //{
                //    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                //    tp.PRCSID = roadSegment.PRCSID;
                //    tp.RoadID = roadSegment.RoadID;

                //    tp.Year = roadSegment.PRCSYear;
                //    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwRuttingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                //    tp.Quantity = roadSegment.cwRuttingQty.GetValueOrDefault();
                //    tplan.Add(tp);
                //}

                if (roadSegment.cwPotholeRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwPotholeActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwPotholeQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwRavellingRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwRavellingActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwRavellingQty;
                    tplan.Add(tp);
                }

                if (roadSegment.cwFailureRate != 0)
                {
                    RAMSDBModel.PavedTentativeRoadMaintenancePlan tp = new RAMSDBModel.PavedTentativeRoadMaintenancePlan();

                    tp.PRCSID = roadSegment.PRCSID;
                    tp.RoadID = roadSegment.RoadID;

                    tp.Year = roadSegment.PRCSYear;
                    tp.CatWorkID = dbContext.PavedCategoryofWork.Where(c => c.ActivityCode == roadSegment.cwFailureActivity).Select(c => c.CatWorkID).FirstOrDefault();
                    tp.Quantity = roadSegment.cwFailureQty;
                    tplan.Add(tp);
                }








            }




            dbContext.PavedTentativeRoadMaintenancePlan.AddRange(tplan);
            dbContext.SaveChanges();
        }
    }
}
