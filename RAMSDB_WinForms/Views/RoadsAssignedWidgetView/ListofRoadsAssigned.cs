using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using RAMSDB.Data;
using RAMSDB_WinForms.PavedRoads;
using RAMSDBModel;
using System;
using System.Collections.Generic;

namespace RAMSDB_WinForms.Views.RoadsAssignedWidgetView
{
    public partial class ListofRoadsAssigned : DevExpress.XtraEditors.XtraUserControl
    {

        RAMSDBEntities _context = new RAMSDBEntities();
        List<RoadsPerUser> roadsPerUser = new List<RoadsPerUser>();

        string _roadType = "unpaved";

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();


        public ListofRoadsAssigned()
        {
            InitializeComponent();

            //bsiRecordsCount.Caption = "RECORDS : " + dataLoader.roadsPerUserDL.Count;

            //**For unpaved
            //    roadsPerUserBindingSource.DataSource = dataLoader.unpavedRoadsPerUserDL;


            //** For paved
            roadsPerUserBindingSource.DataSource = dataLoader.pavedRoadsPerUserDL;


            //** For all
            //    roadsPerUserBindingSource.DataSource = dataLoader.roadsPerUserDL;





        }

        public ListofRoadsAssigned(string roadType)
        {
            InitializeComponent();

            if (roadType != null)
            {
                _roadType = roadType;
            }


            var roads = _roadType == "Unpaved" ? dataLoader.unpavedRoadsPerUserDL : dataLoader.pavedRoadsPerUserDL;
            //bsiRecordsCount.Caption = "RECORDS : " + dataLoader.roadsPerUserDL.Count;

            //**For unpaved
            //    roadsPerUserBindingSource.DataSource = dataLoader.unpavedRoadsPerUserDL;


            //** For paved
            roadsPerUserBindingSource.DataSource = roads;// dataLoader.pavedRoadsPerUserDL;


            //** For all
            //    roadsPerUserBindingSource.DataSource = dataLoader.roadsPerUserDL;





        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);

            RibbonForm form = new RibbonForm();

            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {


                    Guid roadIDColumn = (Guid)view.GetRowCellValue(info.RowHandle, view.Columns["RoadID"]);


                    if (_roadType == "Unpaved")
                    {
                        form = new UnpavedConditionSurveyView(roadIDColumn);
                    }
                    else if (_roadType == "Paved")
                    {
                        form = new PavedConditionSurveyView(roadIDColumn);
                    }


                    form.ShowDialog();


                    // var x = _roadType == "Unpaved" ? formUnpaved.ShowDialog() : formPaved.ShowDialog();


                    //  RibbonForm form = new UnpavedConditionSurveyView(roadIDColumn);

                    //   RibbonForm form = new PavedRoads.PavedConditionSurveyView(roadIDColumn);

                    // XtraUserControl form = new UnpavedConditionSurveyView(roadIDColumn);
                    // form.ShowDialog();

                    // XtraDialog.Show(form);

                    //   Form form = new TestForm();
                    //     form.ShowDialog();

                }
            }
        }
    }
}
