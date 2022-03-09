using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms.Administration
{
    public partial class ManageRoads : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
      
        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();

      //  public string[] years = LinqHelper.ListofYearsGC();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<RoadsGISData> roadData = new List<RoadsGISData>();
        List<AdminBoundary> adminBoundary = new List<AdminBoundary>();
        List<RoadsPerUser> rpu = new List<RoadsPerUser>();

        public Guid _roadID;
       // public int _year = DateTime.Now.Year;
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;
        public int _SurfaceType;




        public ManageRoads()
        {
            InitializeComponent();

            roadData = _context.RoadsGISData.
                Where(c => c.RegionName == _region && c.IsActive==true).ToList();

            adminBoundary = _context.AdminBoundary.
                OrderBy(c=>c.WoredaName).
                Where(c => c.RegionName == _region).ToList();

            roadsGISDataBindingSource.DataSource = roadData;

            lblRegion.Text = _region;

            roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.ToList();
            roadClassificationBindingSource.DataSource = _context.RoadClassification.ToList();
            roadTypePavedUnpavedBindingSource.DataSource = _context.RoadTypePavedUnpaved.ToList();
            adminBoundaryBindingSource.DataSource = adminBoundary;



            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + roadData.Count;
        }

        public ManageRoads(Guid roadID)
        {
            //InitializeComponent();

          
            ////  _year = cboYear.SelectedItem == null ? Convert.ToInt16(DateTime.Now.Year) : Convert.ToInt16(cboYear.Text);

            //roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.
            //    Where(c => c.RoadTypePavedUnpaved.RoadType == "unpaved").ToList();

            //_roadID = roadID;

            //rpu = dataLoader.roadsPerUserDL.ToList();
            //roadData = _context.RoadsGISData.Where(c => c.RoadID == roadID).ToList();

          


           

            //lblZone.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            //lblWoreda.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            //lblRoadOriginDestination.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            ////   lblLength.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();
            //lblLength.Text = String.Format("{0:#,###.00 (km);[#,###.0] (km) ;-; }", unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault());
            //lblRoadDensity.Text = String.Format("{0:#,###.00;[#,###.0];-; }", unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault());


            //lblRoadClassification.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();

            ////lblRoadDensity.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();

            //lblRoadSurfaceType.Text = unpavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();



        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            Guid rID = Guid.NewGuid();

            //   Int16 rowYear = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            view.SetRowCellValue(e.RowHandle, colRoadID, rID);// view.Columns["RegionName"], _region);
            view.SetRowCellValue(e.RowHandle, view.Columns["RegionName"], _region);
            view.SetRowCellValue(e.RowHandle, view.Columns["IsActive"], true);

            //    view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));
            // view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], Convert.ToInt16(_year));


        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.GetRowCellValue(e.RowHandle, colAdminID) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Woreda is Required";
            }


            if (view.GetRowCellValue(e.RowHandle, colRoadOriginName) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Origin Name is Required";
            }

            if (view.GetRowCellValue(e.RowHandle, colRoadType) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Type is Required";
            }

            if (view.GetRowCellValue(e.RowHandle, view.Columns["SurfaceType"]) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Surface Type is Required";
            }

       
            if (view.GetRowCellValue(e.RowHandle, colRoadClassID) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Classification is Required";
            }

            if (view.GetRowCellValue(e.RowHandle, colRoadLengthInKm) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Length is Required";
            }


            //if (view.GetRowCellValue(e.RowHandle, colRoadDestinationName) == null)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Road Destination Name is Required";
            //}

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RoadsGISData dw = (RoadsGISData)view.GetRow(e.RowHandle);
                    // RAMSDBModel.UnpavedRoadConditionSurvey dw = (RAMSDBModel.UnpavedRoadConditionSurvey)view.GetRow(e.RowHandle);

                    _context.RoadsGISData.Add(dw);
                    _context.SaveChanges();
                  
                    bbiRefresh.PerformClick();


                    //_context.UnpavedRoadConditionSurvey.Add(dw);
                    //_context.SaveChanges();
                }
                else
                {
                    _context.SaveChanges();
                }
            }

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridView view = gridView1 as GridView;

            gridView1.PostEditor();

            gridView1.UpdateCurrentRow();
            //_context.SaveChanges();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // gridView1.RefreshData();

            roadData = _context.RoadsGISData.
                Where(c => c.RegionName == _region && c.IsActive == true).ToList();

            //unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.
            //    Where(c => c.RoadID == _roadID && c.RCSYear == yearFilter).ToList();

            //unpavedSurvey = dataLoader.unpavedRoadConditionSurveysDL.
            //  Where(c => c.RoadID == _roadID && c.RCSYear == yearFilter).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + roadData.ToList().Count;
            roadsGISDataBindingSource.DataSource = roadData;

            //  unpavedRoadConditionSurveyBindingSource.DataSource = unpavedSurvey.ToList();
            gridControl1.RefreshDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            _context.SaveChanges();
          //  dataLoader.SaveData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {

                   
                        RoadsGISData dw = (RoadsGISData)view.GetRow(rowHandle);
                        dw.IsActive = false;
                         _context.SaveChanges();


                        view.DeleteRow(rowHandle);
                        bbiRefresh.PerformClick();

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

       
    }
}
