using RAMSDB.Data;
using RAMSDBModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ucNumOfRoads : DevExpress.XtraEditors.XtraUserControl
    {

        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        string _roadType = "Unpaved";

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public ucNumOfRoads()
        {
            InitializeComponent();

            lblNumOfRoads.Text = dataLoader.roadsPerUserDL.Count.ToString();
        }

        public ucNumOfRoads(string roadType)
        {
            InitializeComponent();

            if (roadType != null)
            {
                _roadType = roadType;
            }

            string numofRoads = dataLoader.roadsPerUserDL.
                Where(c => c.RoadsGISData.RoadTypePavedUnpaved.RoadType == _roadType).ToList().Count.ToString();


            lblNumOfRoads.Text = numofRoads;// dataLoader.roadsPerUserDL.Count.ToString();
        }
    }
}
