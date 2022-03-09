using DevExpress.XtraMap;
using RAMSDBModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms
{
    public partial class MapTest : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        //  ICollection<RoadsGISData> rGIS = new  List<RoadsGISData>();
        RAMSDBEntities _context = new RAMSDBEntities();
        //System.Collections.ICollection c = new System.Collections.ICollection();
        public MapTest()
        {
            InitializeComponent();
            var t = _context.RoadsGISData.ToList().Select(c => c.Shape);

            List<string> wkt = _context.AdminBoundary.Select(c => c.Shape.AsText()).ToList();
            List<int> srid = _context.AdminBoundary.Select(c => c.Shape.ElementCount.GetValueOrDefault()).ToList();

            IEnumerable<SqlGeometryItem> colle = new SqlGeometryItemCollection(sqlGeometryItemStorage1);//<SqlGeometryItem>().AsEnumerable();








            SqlGeometryItem[] item = new SqlGeometryItem[5];

            //item.WktString = wkt[0];





            SqlGeometryItemCollection sqlGeometryItems = new SqlGeometryItemCollection(sqlGeometryItemStorage1);

            // List<SqlGeometryItem> items = new List<SqlGeometryItem>(;

            //items..AddRange(wkt)

            // wkt.CopyTo(items.WktString);


            // items.CopyTo()

            // items.AddRange()

            //     items[0]..AddRange()

            //   sqlGeometryItems.AddRange()

            //  List<SqlGeometryItem> rGIS = _context.RoadsGISData.ToList().Select(c => c.Shape.AsText);// as I
            //  sqlGeometryItemStorage1.Items.AddRange( (SqlGeometryItem) rGIS);


            vectorItemsLayer1.Data = sqlGeometryItemStorage1;





            //  layerRoads.Colorizer = CreateColorizer();
            mapControl1.Layers.Add(vectorItemsLayer1);





            //mapControl1.Legends.Add(new ColorListLegend()
            //{
            //    RangeStopsFormat = "0,,M",
            //    Header = "Room Type",
            //    Layer = layerRoads,



            //});



            //  layerRoads.DataLoaded += layer_DataLoaded;

            mapControl1.ZoomToFitLayerItems();//.ZoomToFitLayerItems();
            mapControl1.Focus();
        }
    }
}