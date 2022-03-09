using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms.PavedRoads
{
    public partial class PavedConditionSurveyView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<PavedRoadConditionSurvey> pavedSurvey = new List<PavedRoadConditionSurvey>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();


        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
       // public string[] years = LinqHelper.ListofYearsGC();
        public Guid _roadID;
       // public int _year = DateTime.Now.Year;
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public int _SurfaceType;

        List<RoadsGISData> rgd = new List<RoadsGISData>();
        List<RoadsPerUser> rpu = new List<RoadsPerUser>();




        public PavedConditionSurveyView()
        {
            InitializeComponent();


            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());


            pavedRoadConditionSurveyBindingSource.DataSource = _context.PavedRoadConditionSurvey.Where(c => c.PRCSYear == _year).ToList();
            roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.Where(c => c.RoadTypePavedUnpaved.RoadType == "paved").ToList();
            pavedOverallConditionBindingSource.DataSource = _context.PavedOverallCondition.ToList();
            pavedSideDrainSiltBindingSource.DataSource = _context.PavedSideDrainSilt.ToList();

            pavedSideDrainScourBindingSource.DataSource = _context.PavedSideDrainScour.ToList();
            pavedShoulderDeformationScourBindingSource.DataSource = _context.PavedShoulderDeformationScour.ToList();
            pavedShoulderEdgeStepBindingSource.DataSource = _context.PavedShoulderEdgeStep.ToList();
            pavedShoulderEdgeDamageBindingSource.DataSource = _context.PavedShoulderEdgeDamage.ToList();
            pavedCarriagewayRuttingBindingSource.DataSource = _context.PavedCarriagewayRutting.ToList();
            pavedCarriagewayCrackingBindingSource.DataSource = _context.PavedCarriagewayCracking.ToList();
            pavedCarriagewayFailureBindingSource.DataSource = _context.PavedCarriagewayFailure.ToList();
            pavedCarriagewayPotholesBindingSource.DataSource = _context.PavedCarriagewayPotholes.ToList();
            pavedCarriagewayRavellingBleedingBindingSource.DataSource = _context.PavedCarriagewayRavellingBleeding.ToList();
            pavedVegetationControlBindingSource.DataSource = _context.PavedVegetationControl.ToList();


            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + _context.PavedRoadConditionSurvey.Where(c => c.PRCSYear == _year).ToList().Count;
        }

        public PavedConditionSurveyView(Guid roadID)
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());


            roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.Where(c => c.RoadTypePavedUnpaved.RoadType == "paved").ToList();
            pavedOverallConditionBindingSource.DataSource = _context.PavedOverallCondition.ToList();
            pavedSideDrainSiltBindingSource.DataSource = _context.PavedSideDrainSilt.ToList();
            pavedSideDrainScourBindingSource.DataSource = _context.PavedSideDrainScour.ToList();
            pavedShoulderDeformationScourBindingSource.DataSource = _context.PavedShoulderDeformationScour.ToList();
            pavedShoulderEdgeStepBindingSource.DataSource = _context.PavedShoulderEdgeStep.ToList();
            pavedShoulderEdgeDamageBindingSource.DataSource = _context.PavedShoulderEdgeDamage.ToList();
            pavedCarriagewayRuttingBindingSource.DataSource = _context.PavedCarriagewayRutting.ToList();
            pavedCarriagewayCrackingBindingSource.DataSource = _context.PavedCarriagewayCracking.ToList();
            pavedCarriagewayFailureBindingSource.DataSource = _context.PavedCarriagewayFailure.ToList();
            pavedCarriagewayPotholesBindingSource.DataSource = _context.PavedCarriagewayPotholes.ToList();
            pavedCarriagewayRavellingBleedingBindingSource.DataSource = _context.PavedCarriagewayRavellingBleeding.ToList();
            pavedVegetationControlBindingSource.DataSource = _context.PavedVegetationControl.ToList();


            _roadID = roadID;

            rpu = dataLoader.roadsPerUserDL.ToList();
            rgd = _context.RoadsGISData.Where(c => c.RoadID == roadID).ToList();

            pavedOverallConditionBindingSource.DataSource = _context.PavedOverallCondition.ToList();


            pavedSurvey = dataLoader.pavedRoadConditionSurveysDL.
                Where(c => c.RoadID == roadID && c.PRCSYear == _year).ToList();


            lblZone.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.ZoneName).FirstOrDefault();// multiCriteriaData.Select(c => c.ro.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            lblWoreda.Text = rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            lblRoadOriginDestination.Text = rgd.Select(c => c.RoadOriginDestination).FirstOrDefault().ToString();
            // lblLength.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            lblLength.Text = String.Format("{0:#,###.00 (km);[#,###.0] (km) ;-; }",
                 rgd.Select(c => c.RoadLengthInKm).FirstOrDefault());
            lblRoadDensity.Text = String.Format("{0:#,###.00;[#,###.0];-; }",
                rpu.Where(t => t.RoadID == roadID).Select(c => c.AdminBoundary.RoadDensity).FirstOrDefault());


            lblRoadClassification.Text = rgd.Select(c => c.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();//multiCriteriaData.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            lblRoadSurfaceType.Text = rgd.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();// multiCriteriaData.Select(c => c.RoadsGISData.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();
            _SurfaceType = rgd.Select(c => c.RoadSurfaceType.SurfaceTypeID).FirstOrDefault();

            //lblZone.Text = pavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            //lblWoreda.Text = pavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            //lblRoadOriginDestination.Text = pavedSurvey.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            //lblLength.Text = pavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();

            //lblRoadClassification.Text = pavedSurvey.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();
            //lblRoadDensity.Text = pavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();
            //lblRoadSurfaceType.Text = pavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();
            lblRoadType.Text = rgd.Select(c => c.RoadTypePavedUnpaved.RoadType).FirstOrDefault().ToString();

            //_SurfaceType = pavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeID).FirstOrDefault();

            pavedRoadConditionSurveyBindingSource.DataSource = pavedSurvey; //   _context.UnpavedRoadConditionSurvey.ToList();

            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + pavedSurvey.ToList().Count;

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
            view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["PRCSYear"],
                cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));
            view.SetRowCellValue(e.RowHandle, view.Columns["UserID"], _userID);
            view.SetRowCellValue(e.RowHandle, view.Columns["SurfaceType"], _SurfaceType);
        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;



            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["SurfaceType"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Road Surface Type is Required";
            }

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.PavedRoadConditionSurvey dw = (RAMSDBModel.PavedRoadConditionSurvey)view.GetRow(e.RowHandle);


                    dataLoader.AddNew(dw, "PavedRoadConditionSurvey");
                    bbiRefresh.PerformClick();


                    //_context.UnpavedRoadConditionSurvey.Add(dw);
                    //_context.SaveChanges();
                }
                else
                {
                    dataLoader.SaveData();
                }
            }

        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  _context.SaveChanges();
            GridView view = gridView1 as GridView;

            gridView1.PostEditor();

            gridView1.UpdateCurrentRow();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // gridView1.RefreshData();

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);


            pavedSurvey = dataLoader.pavedRoadConditionSurveysDL.
               Where(c => c.RoadID == _roadID && c.PRCSYear == yearFilter).ToList();

            bsiRecordsCount.Caption = "RECORDS : " + pavedSurvey.ToList().Count;

            pavedRoadConditionSurveyBindingSource.DataSource = pavedSurvey.ToList();

            //pavedRoadConditionSurveyBindingSource.DataSource = dataLoader.
            //    pavedRoadConditionSurveysDL.
            //    Where(c => c.RoadID == _roadID && c.PRCSYear == yearFilter).ToList();
            gridControl1.RefreshDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //_context.SaveChanges();
            dataLoader.SaveData();
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
                        RAMSDBModel.PavedRoadConditionSurvey dw = (RAMSDBModel.PavedRoadConditionSurvey)view.GetRow(rowHandle);

                        dataLoader.Delete(dw, "PavedRoadConditionSurvey");
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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}
