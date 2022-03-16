using System.Collections.Generic;
using System.Data.Entity;


namespace RAMSDB.Data
{
    using DevExpress.XtraMap;
    using RAMSDBModel;
    using System.Linq;


    public partial class MapControlThis
    {
        public virtual MapControl MapControl { get { return null; } }
    }


    public abstract class DataLoaderBase
    {
        protected void LoadIfNeed(ref bool checkFlag, IQueryable target)
        {
            if (!checkFlag)
            {
                target.Load();
                checkFlag = true;
            }
        }
    }

    public class RAMSDBDataLoader : DataLoaderBase
    {
        RAMSDBEntities context;
        public RAMSDBDataLoader()
        {
            context = RAMSDBDataLoader.Create();
        }

        public int SaveData()
        {
            return context.SaveChanges();
        }

        public void AddNew(object toBeAdded, string sender)
        {
            if (sender == "MultiCriteriaAnalysisData")
            {
                MultiCriteriaAnalysisData add = (MultiCriteriaAnalysisData)toBeAdded;

                context.MultiCriteriaAnalysisData.Add(add);
                SaveData();

            }

            if (sender == "UnpavedRoadConditionSurvey")
            {
                UnpavedRoadConditionSurvey add = (UnpavedRoadConditionSurvey)toBeAdded;

                context.UnpavedRoadConditionSurvey.Add(add);
                SaveData();

            }

            if (sender == "PavedRoadConditionSurvey")
            {
                PavedRoadConditionSurvey add = (PavedRoadConditionSurvey)toBeAdded;

                context.PavedRoadConditionSurvey.Add(add);
                SaveData();

            }

            if (sender == "TrafficSurvey")
            {
                TrafficSurvey add = (TrafficSurvey)toBeAdded;

                context.TrafficSurvey.Add(add);
                SaveData();

            }





        }

        public void Delete(object tobeDeleted, string sender)
        {


            if (sender == "MultiCriteriaAnalysisData")
            {
                MultiCriteriaAnalysisData delete = (MultiCriteriaAnalysisData)tobeDeleted;
                context.MultiCriteriaAnalysisData.Attach(delete);
                context.MultiCriteriaAnalysisData.Remove(delete);

            }

            if (sender == "UnpavedRoadConditionSurvey")
            {
                UnpavedRoadConditionSurvey delete = (UnpavedRoadConditionSurvey)tobeDeleted;
                context.UnpavedRoadConditionSurvey.Attach(delete);
                context.UnpavedRoadConditionSurvey.Remove(delete);

            }

            if (sender == "PavedRoadConditionSurvey")
            {
                PavedRoadConditionSurvey delete = (PavedRoadConditionSurvey)tobeDeleted;
                context.PavedRoadConditionSurvey.Attach(delete);
                context.PavedRoadConditionSurvey.Remove(delete);

            }

            if (sender == "TrafficSurvey")
            {
                TrafficSurvey delete = (TrafficSurvey)tobeDeleted;
                context.TrafficSurvey.Attach(delete);
                context.TrafficSurvey.Remove(delete);

            }











        }



        public static class LoginInfo
        {
            public static User GetLoggedInUser;

            // Roles: "Regional Admin", "Super Admin", "Woreda Data Person"




        }

        public static class LoggedInUser
        {
            public static string roleName = LoginInfo.GetLoggedInUser.Role.RoleName;//.Role.RoleName.FirstOrDefault().ToString();
            public static string userRegion =   LoginInfo.GetLoggedInUser.Region;

        }

        public List<RoadsPerUser> roadsPerUserDL
        {


            get
            {
                if (LoggedInUser.roleName == "Regional Admin")
                {
                   return context.RoadsPerUser.ToList();
                    //   return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.AdminBoundary.RegionName == LoggedInUser.userRegion).Select(c => c)).ToList();
                }

                if (LoggedInUser.roleName == "Woreda Data Person")
                {
                    return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.UserID == LoginInfo.GetLoggedInUser.UserID)).ToList();
                }
                else
                    return context.RoadsPerUser.ToList();

            }

        }

        public List<RoadsPerUser> unpavedRoadsPerUserDL
        {


            get
            {
                if (LoggedInUser.roleName == "Regional Admin")
                {
                    return context.RoadsPerUser.Where(c => c.RoadsGISData.RoadType == 1).ToList();
                    //   return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.AdminBoundary.RegionName == LoggedInUser.userRegion).Select(c => c)).ToList();
                }

                if (LoggedInUser.roleName == "Woreda Data Person")
                {
                    return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.UserID == LoginInfo.GetLoggedInUser.UserID
                    //  && c.RoadID == c.RoadsGISData.RoadTypePavedUnpaved.ID==1
                    //  && c.RoadsGISData.RoadTypePavedUnpaved.RoadType == "unpaved"

                    ).Where(c => c.RoadsGISData.RoadType == 1)).ToList();
                }
                else
                    return context.RoadsPerUser.Where(c => c.RoadsGISData.RoadType == 1).ToList();

            }

        }

        public List<RoadsPerUser> pavedRoadsPerUserDL
        {


            get
            {
                if (LoggedInUser.roleName == "Regional Admin")
                {
                    return context.RoadsPerUser.Where(c => c.RoadsGISData.RoadType == 2).ToList();
                    //   return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.AdminBoundary.RegionName == LoggedInUser.userRegion).Select(c => c)).ToList();
                }

                if (LoggedInUser.roleName == "Woreda Data Person")
                {
                    return (LoginInfo.GetLoggedInUser.RoadsPerUsers.Where(c => c.UserID == LoginInfo.GetLoggedInUser.UserID


                    ).Where(c => c.RoadsGISData.RoadType == 2)).ToList();
                }
                else
                    return context.RoadsPerUser.Where(c => c.RoadsGISData.RoadType == 2).ToList();

            }

        }

        public List<UnpavedRoadConditionSurvey> unpavedRoadConditionSurveysDL
        {
            get
            {

                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.UnpavedRoadConditionSurvey.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();


            }
        }

        public List<PavedRoadConditionSurvey> pavedRoadConditionSurveysDL
        {
            get
            {

                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.PavedRoadConditionSurvey.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();


            }
        }

        //public List<UnpavedTentativeRoadMaintenancePlan> tentativeRoadMaintenancePlanDL
        //{
        //    get
        //    {
        //        var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

        //        return context.UnpavedTentativeRoadMaintenancePlan.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList(); 

        //    }
        //}

        public List<UnpavedTentativeRoadMaintenancePlan> tentativeUnpavedRoadMaintenancePlanDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Where(c => c.RoadsGISData.RoadType == 1).Select(x => x.RoadID).ToList();

                return context.UnpavedTentativeRoadMaintenancePlan.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }

        public List<PavedTentativeRoadMaintenancePlan> tentativePavedRoadMaintenancePlanDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Where(c => c.RoadsGISData.RoadType == 2).Select(x => x.RoadID).ToList();

                return context.PavedTentativeRoadMaintenancePlan.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }


        public List<MultiCriteriaAnalysisData> multiCriteriaDataDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.MultiCriteriaAnalysisData.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }

        public List<TrafficSurvey> trafficSurveysDL
        {
            get
            {
                var roadsAssignedForUser = roadsPerUserDL.Select(x => x.RoadID).ToList();

                return context.TrafficSurvey.Where(p => roadsAssignedForUser.Contains(p.RoadID)).ToList();

            }
        }



        public static RAMSDBEntities Create()
        {
            //Preload().Wait();
            return new RAMSDBEntities();
        }
    }
}
