using DevExpress.XtraCharts;
using RAMSDB.Data;
using RAMSDBModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucClassification : DevExpress.XtraEditors.XtraUserControl
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        string _roadType = "Unpaved";


        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucClassification()
        {
            InitializeComponent();

            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                     group roads by roads.RoadsGISData.RoadClassification.RoadClassificationDescription into grp
                                     select new { RoadClassification = grp.Key, NumberofRoads = grp.Count() };


            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Classification", ViewType.Pie);

            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadClassification";
            series1.ValueDataMembers.AddRange(new string[] { "NumberofRoads" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);

            // Format the the series labels. 
            //   series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels.  
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.Inside;
        }

        public ucClassification(string roadType)
        {
            InitializeComponent();

            if (roadType != null)
            {
                _roadType = roadType;
            }

            var roadsBySurfaceType = from roads in dataLoader.roadsPerUserDL
                                     where roads.RoadsGISData.RoadTypePavedUnpaved.RoadType == _roadType

                                     group roads by roads.RoadsGISData.RoadClassification.RoadClassificationDescription into grp
                                     select new { RoadClassification = grp.Key, NumberofRoads = grp.Count() };


            //  chartControl1.Titles.Add(new ChartTitle() { Text = "Land Area by Country" });

            // Create a pie series. 
            Series series1 = new Series("Road by Classification", ViewType.Pie);

            // Bind the series to data. 
            series1.DataSource = roadsBySurfaceType.ToList();
            series1.ArgumentDataMember = "RoadClassification";
            series1.ValueDataMembers.AddRange(new string[] { "NumberofRoads" });

            // Add the series to the chart. 
            chartControl1.Series.Add(series1);

            // Format the the series labels. 
            //   series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels.  
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.Inside;
        }
    }
}
