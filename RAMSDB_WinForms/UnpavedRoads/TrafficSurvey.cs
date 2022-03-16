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

    public partial class TrafficSurveyForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        RAMSDBEntities _context = new RAMSDBEntities();

        public Guid _roadID;

        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<TrafficSurvey> trafficSurveys = new List<TrafficSurvey>();

        List<RoadsPerUser> rpu = new List<RoadsPerUser>();
        List<RoadsGISData> rgd = new List<RoadsGISData>();


        public TrafficSurveyForm()
        {
            InitializeComponent();
        }

        public TrafficSurveyForm(Guid roadID)
        {
            InitializeComponent();

            _roadID = roadID;

            vehicleTypeBindingSource.DataSource = _context.VehicleType.ToList();
            trafficCountHourBindingSource.DataSource = _context.TrafficCountHour.ToList();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            trafficSurveys = dataLoader.trafficSurveysDL.Where(c => c.RoadID == roadID && c.TrafficSurveyYear == _year).ToList();

            trafficSurveyBindingSource.DataSource = trafficSurveys.ToList();


            rpu = dataLoader.roadsPerUserDL.ToList();
            rgd = _context.RoadsGISData.Where(c => c.RoadID == roadID).ToList();


            lblRoadOriginDestination.Text = rgd.Select(c => c.RoadOriginDestination).FirstOrDefault().ToString();
            // lblLength.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblLength.Text = String.Format("{0:#,###.00 (km);[#,###.0] (km) ;-; }",
                 rgd.Select(c => c.RoadLengthInKm).FirstOrDefault());
            lblRoadDensity.Text = String.Format("{0:#,###.00;[#,###.0];-; }",
                rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault());


            lblRoadClassification.Text = rgd.Select(c => c.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();//multiCriteriaData.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = rgd.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();



            // lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.ZoneName).FirstOrDefault();// multiCriteriaData.Select(c => c.ro.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();
            lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.RoadsGISData.MaintenanceBranch.MaintenanceBranch1).FirstOrDefault();
            lblWoreda.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            //lblRoadOriginDestination.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            //lblLength.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            //lblRoadClassification.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            //lblRoadDensity.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            //lblRoadSurfaceType.Text = trafficSurveys.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();


            bsiRecordsCount.Caption = "RECORDS : " + trafficSurveys.Count.ToString(); // _context.TrafficSurvey.ToList().Count;

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;




            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["VehicleTypeID"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Vehicle Type is Required";
            }

            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["TCHourID"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Survey Hour is Required";
            }

            if ((decimal)view.GetRowCellValue(e.RowHandle, view.Columns["TrafficCount"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Traffic Count cannot be Zero";
            }


            //VehicleTypeID
            //TCHourID

            //TrafficCount

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.TrafficSurvey dw = (RAMSDBModel.TrafficSurvey)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "TrafficSurvey");
                    bbiRefresh.PerformClick();

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
                        RAMSDBModel.TrafficSurvey dw = (RAMSDBModel.TrafficSurvey)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "TrafficSurvey");
                        dataLoader.SaveData();
                        //   _context.MultiCriteriaAnalysisData.Attach(dw);
                        //   _context.MultiCriteriaAnalysisData.Remove(dw);
                        //   _context.SaveChanges();
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

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            GridView view = gridView as GridView;

            view.PostEditor();

            view.UpdateCurrentRow();

            //  dataLoader.SaveData();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);


            trafficSurveys = dataLoader.trafficSurveysDL.Where(c => c.RoadID == _roadID && c.TrafficSurveyYear == yearFilter).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + trafficSurveys.ToList().Count; // _context.TrafficSurvey.ToList().Count;

            trafficSurveyBindingSource.DataSource = trafficSurveys.ToList();


            //bsiRecordsCount.Caption = "RECORDS : " + dataLoader.trafficSurveysDL.
            //    Where(c => c.RoadID == _roadID && c.TrafficSurveyYear == yearFilter).ToList().Count.ToString(); // _context.TrafficSurvey.ToList().Count;

            gridControl.RefreshDataSource();
        }

        private void gridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["TrafficSurveyYear"],
                cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}