using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RAMSDB_WinForms.UnpavedRoads
{
    public partial class UnpavedMultiCriteriaData : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();

        public Guid _roadID;

        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;
        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<MultiCriteriaAnalysisData> multiCriteriaData = new List<MultiCriteriaAnalysisData>();
        List<RoadsGISData> rgd = new List<RoadsGISData>();

        List<RoadsPerUser> rpu = new List<RoadsPerUser>();


        public UnpavedMultiCriteriaData()
        {
            InitializeComponent();
        }

        public UnpavedMultiCriteriaData(Guid roadID)
        {
            InitializeComponent();



            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            _roadID = roadID;


            multiCriteriaData = dataLoader.multiCriteriaDataDL.Where(c => c.RoadID == roadID && c.Year == _year).ToList();

            rpu = dataLoader.roadsPerUserDL.ToList();
            rgd = _context.RoadsGISData.Where(c => c.RoadID == roadID).ToList();


            lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.ZoneName).FirstOrDefault();// multiCriteriaData.Select(c => c.ro.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            lblWoreda.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            lblRoadOriginDestination.Text = rgd.Select(c => c.RoadOriginDestination).FirstOrDefault().ToString();


            lblLength.Text = String.Format("{0:#,###.00 (km);[#,###.0] (km) ;-; }",
                 rgd.Select(c => c.RoadLengthInKm).FirstOrDefault());
            lblRoadDensity.Text = String.Format("{0:#,###.00;[#,###.0];-; }",
                rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault());


            //   lblLength.Text = rgd.Select(c => c.RoadLengthInKm).FirstOrDefault().ToString(); // multiCriteriaData.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblRoadClassification.Text = rgd.Select(c => c.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();//multiCriteriaData.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
                                                                                                                                         //    lblRoadDensity.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = rgd.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();



            //   multiCriteriaAnalysisDataBindingSource.DataSource = _context.MultiCriteriaAnalysisData.Where(c => c.RoadID == roadID).ToList();

            multiCriteriaAnalysisDataBindingSource.DataSource = multiCriteriaData;

            cooperativeCentersAlongRoadBindingSource.DataSource = _context.CooperativeCentersAlongRoad.ToList();
            tradingCentersAlongRoadBindingSource.DataSource = _context.TradingCentersAlongRoad.ToList();
            kebelesVillagesCommunitiesConnectedBindingSource.DataSource = _context.KebelesVillagesCommunitiesConnected.ToList();
            roadTraversesFarmlandBindingSource.DataSource = _context.RoadTraversesFarmland.ToList();
            marketsConnectByRoadBindingSource.DataSource = _context.MarketsConnectByRoad.ToList();
            healthCentersAlongRoadBindingSource.DataSource = _context.HealthCentersAlongRoad.ToList();
            educationCentersAlongRoadBindingSource.DataSource = _context.EducationCentersAlongRoad.ToList();
            otherProjectsAlongRoadBindingSource.DataSource = _context.OtherProjectsAlongRoad.ToList();


            //gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + multiCriteriaData.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.MultiCriteriaAnalysisData dw = (RAMSDBModel.MultiCriteriaAnalysisData)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "MultiCriteriaAnalysisData");

                    //_context.MultiCriteriaAnalysisData.Add(dw);

                    //_context.SaveChanges();
                }
                else
                {
                    dataLoader.SaveData();
                }
            }
        }

        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            //    _context.SaveChanges();
            dataLoader.SaveData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.SelectedRowsCount > 0)
            {



                GridView view = gridView as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        RAMSDBModel.MultiCriteriaAnalysisData dw = (RAMSDBModel.MultiCriteriaAnalysisData)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "MultiCriteriaAnalysisData");
                        dataLoader.SaveData();
                        //   _context.MultiCriteriaAnalysisData.Attach(dw);
                        //   _context.MultiCriteriaAnalysisData.Remove(dw);
                        //   _context.SaveChanges();
                        view.DeleteRow(rowHandle);

                    }
                    else
                        return;



                }
                else
                {
                    MessageBox.Show("Please first select a row from the table below.");
                }



            }
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            ////   GridView view = gridView as GridView;

            ////   view.UpdateCurrentRow();

            ////   view.ValidateRow +=  gridView_ValidateRow;

            //////   view.SourceView.c


            //      dataLoader.SaveData();
            GridView view = gridView as GridView;

            view.PostEditor();

            view.UpdateCurrentRow();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);


            multiCriteriaAnalysisDataBindingSource.DataSource = dataLoader.multiCriteriaDataDL.
                Where(c => c.RoadID == _roadID && c.Year == yearFilter).ToList();// multiCriteriaData;// _context.MultiCriteriaAnalysisData.ToList(); 
            gridControl.RefreshDataSource();
        }

        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            //view.SetRowCellValue(e.RowHandle, view.Columns["Year"], Convert.ToInt16(_year));

            view.SetRowCellValue(e.RowHandle, view.Columns["Year"],
                cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}
