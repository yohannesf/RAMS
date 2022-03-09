using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RAMSDB_WinForms.ViewModel.AssignRoadsToUsersVM
{

    public class RoadClass
    {
        public int? RoadID { get; set; }// { get { return RoadID; } set { if (RoadID != value) { RoadID = value; } } }
        public string WoredaName { get; set; }
        public string ZoneName { get; set; }
        public string ZoneCode { get; set; }
        public string WoredaCode { get; set; }
        public int? AdminID { get; set; }// { get { return AdminID; } set { if (AdminID != value) { AdminID = value; } } }
        public string RoadOriginDestination { get; set; }// { get; set; }

        public string RoadClassificationDescription { get; set; }// { get { return RoadClassification; } set { if (RoadClassification != value) { RoadClassification = value; } } }
        public string RoadIdentifier { get; set; }
        public decimal? RoadLengthInKm { get; set; }// { get { return RoadLengthInKm; } set { if (RoadLengthInKm != value) { RoadLengthInKm = value; } } }
        public string SurfaceTypeName { get; set; }
        //public string roadIdentifier { get; set; } //-------
        //public string 


        public RoadClass(int? roadID, string woredaName, string zoneName, string zoneCode, string woredaCode, int? adminID, string roadOriginDestination,
                                                                                        string roadClassificationDescription,

                                                                                        string RoadIdentifier,
                                                                                        decimal? RoadLengthInKm,
                                                                                        string surfaceTypeName)



        {
            this.RoadID = roadID.GetValueOrDefault();

            //this.RoadID = roadID;
            this.WoredaName = woredaName;
            this.ZoneName = zoneName;
            this.ZoneCode = zoneCode;
            this.WoredaCode = woredaCode;
            this.AdminID = adminID.GetValueOrDefault();
            this.RoadOriginDestination = roadOriginDestination;

            this.RoadClassificationDescription = roadClassificationDescription;
            this.RoadIdentifier = RoadIdentifier;
            this.RoadLengthInKm = RoadLengthInKm.GetValueOrDefault();
            this.SurfaceTypeName = surfaceTypeName;


        }



    }
    public class DistinctZones
    {
        public string zoneName { get; set; }
        public string zoneCode { get; set; }
        // public List<string> wName { get; set; }
        public ReadOnlyCollection<Woreda> Woredas { get; set; }

        public DistinctZones() { }
        public DistinctZones(string name, IList<Woreda> woredas, string zoneCode)
        {
            this.zoneName = name;
            this.zoneCode = zoneCode;
            this.Woredas = new ReadOnlyCollection<Woreda>(woredas);
        }

        public override string ToString()
        {
            return zoneName;
        }
        public IEnumerable<Woreda> wName { get; set; }
    }

    public class Woreda
    {
        public string woredaName { get; set; }
        public string woredaCode { get; set; }
        public int adminID { get; set; }

        public Woreda() { }
        public Woreda(string woredaName, string woredaCode, int adminID)
        {
            this.woredaName = woredaName;
            this.woredaCode = woredaCode;
            this.adminID = adminID;
        }
        public override string ToString()
        {
            return woredaName;
        }
    }
    public class AssignRoadsToUsersVM
    {
        static RAMSDBEntities _context = new RAMSDBEntities();
        public IEnumerable<RoadClass> results = new List<RoadClass>();// GetRoadsInWoredasWithInfo(); //new List<RoadClass>();// = GetRoadsInWoredasWithInfo();
     //   public List<GetAllRoadsCrossingWoredas2Result> r = new List<GetAllRoadsCrossingWoredas2Result>();// List<RoadClass>() as Queryable;// GetRoadsInWoredasWithInfo(); //new List<RoadClass>();// = GetRoadsInWoredasWithInfo();
      //  public List<GetAllRoadsCrossingWoredas2Result> rt = new List<GetAllRoadsCrossingWoredas2Result>();// List<RoadClass>() as Queryable;// GetRoadsInWoredasWithInfo(); //new List<RoadClass>();// = GetRoadsInWoredasWithInfo();

        public ReadOnlyCollection<DistinctZones> UniqueZoneCollection { get; set; }
        public virtual object SelectedItem { get; set; }

        public AssignRoadsToUsersVM()
        {



            //  AdminBoundariesRepository tc = new AdminBoundariesRepository(_context);

            // var result = tc.GetAll();

            // 
            //  results = GetRoadsInWoredasWithInfo();

            //UniqueZoneCollection =  new ReadOnlyCollection<DistinctZones>((from p in results
            //                                                              group (new Tuple<string, string, int>(p.WoredaName, p.WoredaCode, p.AdminID.GetValueOrDefault())) by (p.ZoneName, p.ZoneCode) into g
            //                                                              select (CreateDistinctZone(g.Key.Item1, g.Key.Item2, g.Distinct().ToList()))).ToList());

        }



        public void PopulateResult()
        {

            //  results = GetRoadsInWoredasWithInfo();
        }

        //public async Task<List<GetAllRoadsCrossingWoredas2Result>> GetRoadsInWoredasWithInfoAsync(string woreda, string region)
        //{



        //    _context.Database.CommandTimeout = 0;

        //    //  List<GetAllRoadsCrossingWoredasResult> allroads = _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    r = _context.Database.SqlQuery<GetAllRoadsCrossingWoredas2Result>
        //       ("exec GetAllRoadsCrossingWoredas @worName, @regName",
        //        new SqlParameter("@worName", woreda), new SqlParameter("@regName", region))
        //        .ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    return await Task.FromResult(r.ToList());
        //    //return (from roads in allroads
        //    //        orderby roads.ZoneName, roads.WoredaName, roads.RoadOriginDestination
        //    //        select new RoadClass
        //    //        (
        //    //            roads.RoadID.GetValueOrDefault(),
        //    //            roads.WoredaName,
        //    //            roads.ZoneName,
        //    //            roads.ZoneCode,
        //    //            roads.WoredaCode,
        //    //            roads.AdminID.GetValueOrDefault(),
        //    //            roads.RoadOriginDestination,

        //    //            roads.RoadClassificationDescription,
        //    //            roads.RoadIdentifier,
        //    //            roads.RoadLengthInKm.GetValueOrDefault(),
        //    //            roads.SurfaceTypeName

        //    //        )).ToList();


        //}

        //public async Task<List<GetAllRoadsCrossingWoredas2Result>> GetRoadsInOneWoredasWithInfoAsync(string woreda, string region)
        //{



        //    _context.Database.CommandTimeout = 0;

        //    //  List<GetAllRoadsCrossingWoredasResult> allroads = _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    rt = _context.Database.SqlQuery<GetAllRoadsCrossingWoredas2Result>
        //        ("exec GetAllRoadsCrossingWoredas @worName @regName",
        //        new SqlParameter("@worName", woreda), new SqlParameter("@regName", region)
        //        ).ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    return await Task.FromResult(rt.ToList());
        //    //return (from roads in allroads
        //    //        orderby roads.ZoneName, roads.WoredaName, roads.RoadOriginDestination
        //    //        select new RoadClass
        //    //        (
        //    //            roads.RoadID.GetValueOrDefault(),
        //    //            roads.WoredaName,
        //    //            roads.ZoneName,
        //    //            roads.ZoneCode,
        //    //            roads.WoredaCode,
        //    //            roads.AdminID.GetValueOrDefault(),
        //    //            roads.RoadOriginDestination,

        //    //            roads.RoadClassificationDescription,
        //    //            roads.RoadIdentifier,
        //    //            roads.RoadLengthInKm.GetValueOrDefault(),
        //    //            roads.SurfaceTypeName

        //    //        )).ToList();


        //}


        public async Task<List<RoadsCrossingWoredas>> GetRoadsInOneWoredaInfoAsync(string woreda, string region)
        {



            List<RoadsCrossingWoredas> rcw = new List<RoadsCrossingWoredas>();
            _context.Database.CommandTimeout = 0;

            //  List<GetAllRoadsCrossingWoredasResult> allroads = _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

            rcw = _context.Database.SqlQuery<RoadsCrossingWoredas>
                ("exec GetAllRoadsCrossingWoredas @worName, @regName",
                new SqlParameter("@worName", woreda), new SqlParameter("@regName", region)
                ).ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

            return await Task.FromResult(rcw.ToList());
            //return (from roads in allroads
            //        orderby roads.ZoneName, roads.WoredaName, roads.RoadOriginDestination
            //        select new RoadClass
            //        (
            //            roads.RoadID.GetValueOrDefault(),
            //            roads.WoredaName,
            //            roads.ZoneName,
            //            roads.ZoneCode,
            //            roads.WoredaCode,
            //            roads.AdminID.GetValueOrDefault(),
            //            roads.RoadOriginDestination,

            //            roads.RoadClassificationDescription,
            //            roads.RoadIdentifier,
            //            roads.RoadLengthInKm.GetValueOrDefault(),
            //            roads.SurfaceTypeName

            //        )).ToList();


        }


        //public async Task<IEnumerable<GetAllRoadsCrossingWoredas2Result>> GetRoadsInWoredasWithInfoAsync()
        //{



        //    _context.Database.CommandTimeout = 0;

        //    //  List<GetAllRoadsCrossingWoredasResult> allroads = _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    // r = _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").AsQueryable();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();

        //    return await Task.FromResult(r.ToList());
        //    //return (from roads in allroads
        //    //        orderby roads.ZoneName, roads.WoredaName, roads.RoadOriginDestination
        //    //        select new RoadClass
        //    //        (
        //    //            roads.RoadID.GetValueOrDefault(),
        //    //            roads.WoredaName,
        //    //            roads.ZoneName,
        //    //            roads.ZoneCode,
        //    //            roads.WoredaCode,
        //    //            roads.AdminID.GetValueOrDefault(),
        //    //            roads.RoadOriginDestination,

        //    //            roads.RoadClassificationDescription,
        //    //            roads.RoadIdentifier,
        //    //            roads.RoadLengthInKm.GetValueOrDefault(),
        //    //            roads.SurfaceTypeName

        //    //        )).ToList();


        //}

        //public IEnumerable<RoadClass> GetRoadsInWoredasWithInfo()
        //{



        //    _context.Database.CommandTimeout = 3000;

        //    List<GetAllRoadsCrossingWoredasResult> allroads = 
        //        _context.Database.SqlQuery<GetAllRoadsCrossingWoredasResult>("GetAllRoadsCrossingWoredas").ToList();// await _context.Database.SqlQuery<allroads>("AllSalesPeople").ToListAsync();



        //    return (from roads in allroads
        //            orderby roads.ZoneName, roads.WoredaName, roads.RoadOriginDestination
        //            select new RoadClass
        //            (
        //                roads.RoadID.GetValueOrDefault(),
        //                roads.WoredaName,
        //                roads.ZoneName,
        //                roads.ZoneCode,
        //                roads.WoredaCode,
        //                roads.AdminID.GetValueOrDefault(),
        //                roads.RoadOriginDestination,

        //                roads.RoadClassificationDescription,
        //                roads.RoadIdentifier,
        //                roads.RoadLengthInKm.GetValueOrDefault(),
        //                roads.SurfaceTypeName

        //            )).ToList();


        //}

        //Because a lot of methods use this. It's better to create it once



        static DistinctZones CreateDistinctZone(string name, string zoneCode, List<Tuple<string, string, int>> woreadsx) // ObservableCollection<Woreda> woredas)
        {
            IList<Woreda> woredas = new List<Woreda>();

            foreach (var w in woreadsx)
            {
                Woreda woredaToAdd = new Woreda(w.Item1, w.Item2, w.Item3);
                woredas.Add(woredaToAdd);
                //woredas.Add(x);

            }
            return new DistinctZones(name, woredas, zoneCode);
        }





        public IEnumerable<RoadClass> GetRoadClassDataByZone(string zoneCodePassed)
        {


            return (from q in results where q.ZoneCode == zoneCodePassed select q).ToList();


        }

        public IEnumerable<RoadClass> GetRoadClassDataByWoreda(string woredaCodePassed)
        {

            return (from q in results where q.WoredaCode == woredaCodePassed select q).ToList();


        }
    }
}
