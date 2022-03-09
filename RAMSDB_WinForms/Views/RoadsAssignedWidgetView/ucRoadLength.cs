using DevExpress.XtraCharts;
using RAMSDB.Data;
using RAMSDBModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucRoadLength : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        string _roadType = "Unpaved";

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucRoadLength()
        {
            InitializeComponent();



            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                     select new { RoadName = roads.RoadsGISData.RoadOriginDestination, RoadLength = roads.RoadsGISData.RoadLengthInKm.GetValueOrDefault() };




            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Length", ViewType.Bar);


            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadName";
            series1.ValueDataMembers.AddRange(new string[] { "RoadLength" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);
            // ((XYDiagram)chartControl1.Diagram).Rotated = true;

        }

        public ucRoadLength(string roadType)
        {
            InitializeComponent();

            if (roadType != null)
            {
                _roadType = roadType;
            }

            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                     where roads.RoadsGISData.RoadTypePavedUnpaved.RoadType == _roadType
                                     select new { RoadName = roads.RoadsGISData.RoadOriginDestination, RoadLength = roads.RoadsGISData.RoadLengthInKm.GetValueOrDefault() };




            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Length", ViewType.Bar);


            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadName";
            series1.ValueDataMembers.AddRange(new string[] { "RoadLength" });

            //  series1.ToolTipPointPattern = "{0:#,###.00 (km);[#,###.0] (km) ;-; }";
            //series1.ToolTipSeriesPattern = "{0:#,###.00 (km);[#,###.0] (km) ;-; }";


            // Add the series to the chart. 
            chartControl1.Series.Add(series1);
            // ((XYDiagram)chartControl1.Diagram).Rotated = true;

        }
    }
}
