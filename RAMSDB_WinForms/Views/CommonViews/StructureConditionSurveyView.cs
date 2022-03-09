using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms
{
    public partial class StructureConditionSurveyView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        List<UnpavedRoadConditionSurvey> unpavedSurvey = new List<UnpavedRoadConditionSurvey>();

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
       // public string[] years = LinqHelper.ListofYearsGC();

        List<RoadsGISData> rgd = new List<RoadsGISData>();
        List<RoadsPerUser> rpu = new List<RoadsPerUser>();

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        public Guid _roadID;
       // public int _year = DateTime.Now.Year;
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public int _SurfaceType;




        public StructureConditionSurveyView()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            structuresInventoryBindingSource.DataSource = _context.StructuresInventory.ToList();

            structureConditionSurveyBindingSource.DataSource = _context.StructureConditionSurvey.ToList();
            conditionBindingSource.DataSource = _context.Condition.ToList();




            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + _context.StructureConditionSurvey.
                Where(c => c.SCSYear == _year).ToList().Count;
        }

        public StructureConditionSurveyView(Guid roadID)
        {
            InitializeComponent();

            _roadID = roadID;

            rgd = _context.RoadsGISData.Where(c => c.RoadID == roadID).ToList();//.ToList();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            structuresInventoryBindingSource.DataSource = _context.StructuresInventory.
                Where(c => c.RoadID == _roadID).ToList();

            structureConditionSurveyBindingSource.DataSource = _context.StructureConditionSurvey.
                Where(c => c.StructuresInventory.RoadID == _roadID && c.SCSYear == _year)
                .ToList();

            conditionBindingSource.DataSource = _context.Condition.ToList();


            //  _year = cboYear.SelectedItem == null ? Convert.ToInt16(DateTime.Now.Year) : Convert.ToInt16(cboYear.Text);

            rpu = dataLoader.roadsPerUserDL.ToList();



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





            //   lblZone.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();

            //   lblWoreda.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            //   lblRoadOriginDestination.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadOriginDestination).FirstOrDefault().ToString();
            ////   lblLength.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault().ToString();
            //   lblLength.Text = String.Format("{0:#,###.00 (km);[#,###.0] (km) ;-; }", unpavedSurvey.Select(c => c.RoadsGISData.RoadLengthInKm).FirstOrDefault());
            //   lblRoadDensity.Text = String.Format("{0:#,###.00;[#,###.0];-; }", unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault());


            //   lblRoadClassification.Text = unpavedSurvey.Select(c => c.RoadsGISData.RoadClassification.RoadClassificationDescription).FirstOrDefault().ToString();

            //    //lblRoadDensity.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.RoadDensity).FirstOrDefault().ToString();

            //   lblRoadSurfaceType.Text = unpavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeName).FirstOrDefault().ToString();

            //   _SurfaceType = unpavedSurvey.Select(c => c.RoadSurfaceType.SurfaceTypeID).FirstOrDefault();

            //   unpavedRoadConditionSurveyBindingSource.DataSource = unpavedSurvey; //   _context.UnpavedRoadConditionSurvey.ToList();

            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;


            //   bsiRecordsCount.Caption = "RECORDS : " + unpavedSurvey.Count;

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

            //   Int16 rowYear = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            //  view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["SCSYear"],
                cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));
            //    view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));
            // view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], Convert.ToInt16(_year));

            // view.SetRowCellValue(e.RowHandle, view.Columns["UserID"], _userID);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["SurfaceType"], _SurfaceType);
        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;



            if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["StructureID"]) == 0)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Structure is required";
            }

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.StructureConditionSurvey dw = (RAMSDBModel.StructureConditionSurvey)view.GetRow(e.RowHandle);


                    // dataLoader.AddNew(dw, "UnpavedRoadConditionSurvey");


                    _context.StructureConditionSurvey.Add(dw);
                    _context.SaveChanges();
                }
                else
                {
                    dataLoader.SaveData();
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

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            structureConditionSurveyBindingSource.DataSource = _context.StructureConditionSurvey.
            Where(c => c.StructuresInventory.RoadID == _roadID && c.SCSYear == yearFilter)
            .ToList();


            //  structureConditionSurveyBindingSource.DataSource = _context.StructureConditionSurvey.ToList();

            // unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RoadID == _roadID).ToList();

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
                        RAMSDBModel.StructureConditionSurvey dw = (RAMSDBModel.StructureConditionSurvey)view.GetRow(rowHandle);

                        // dataLoader.Delete(dw, "UnpavedRoadConditionSurvey");
                        //   dataLoader.SaveData();
                        //   _context.MultiCriteriaAnalysisData.Attach(dw);
                        _context.StructureConditionSurvey.Remove(dw);
                        _context.SaveChanges();
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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}
