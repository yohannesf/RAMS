using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms.PPP
{
    public partial class RoadExpenditureProgress : DevExpress.XtraEditors.XtraUserControl// DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Guid> tentativeRoadIDs = new List<Guid>();
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        RAMSDBEntities _context = new RAMSDBEntities();
        List<Guid> roadsAssignedForUser = new List<Guid>();
        List<Tuple<Guid, int>> tentRoads = new List<Tuple<Guid, int>>();
        List<RAMSDBModel.PrioritizedRoads> tentativePrioritizedRoads = new List<RAMSDBModel.PrioritizedRoads>();


        //public string[] years = LinqHelper.ListofYearsGC();
        //public int _year = DateTime.Now.Year;

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();

        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        int _numberOfRoads;

        List<RoadsGISData> rgd = new List<RoadsGISData>();
        List<RoadsPerUser> rpu = new List<RoadsPerUser>();
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;






        public RoadExpenditureProgress()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());



            //  _year = cboYear.SelectedItem == null ? Convert.ToInt16(DateTime.Now.Year) : Convert.ToInt16(cboYear.Text);


            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            roadsAssignedForUser = dataLoader.roadsPerUserDL.Select(z => z.RoadID).ToList();


            rgd = _context.RoadsGISData.Where(c => roadsAssignedForUser.Contains(c.RoadID)).ToList();//.ToList();
            rpu = dataLoader.roadsPerUserDL.ToList();


            lblWoreda.Text = rpu.Where(c => roadsAssignedForUser.Contains(c.RoadID)).Select(c => c.AdminBoundary.WoredaName).FirstOrDefault(); //multiCriteriaData.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();


            lblRegion.Text = _region;// unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.ZoneName).FirstOrDefault().ToString();



            tentativePrioritizedRoads = _context.PrioritizedRoads.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();

            tentativeRoadIDs = tentativePrioritizedRoads.Select(t => t.RoadID).ToList();


            var pRoadIDs = _context.RoadsGISData.Where(c => tentativeRoadIDs.Contains(c.RoadID)).ToList();
            //var pRoadIDYear = pRoadIDs.Where(c => c.Year == yearFilter).ToList();




            _numberOfRoads = pRoadIDs.Select(c => c.RoadID).Distinct().ToList().Count;

            //    lblNumRoads.Text = _numberOfRoads.ToString();







            //  lblWoreda.Text = unpavedSurvey.Select(c => c.RoadsPerUser.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            roadsGISDataBindingSource.DataSource = pRoadIDs.ToList();




            annualRoadExpenditurePlanBindingSource.DataSource = _context.AnnualRoadExpenditurePlan.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.FYearEC == yearFilter).ToList();

            //unpavedRoadConditionSurveyBindingSource.DataSource = _context.UnpavedRoadConditionSurvey.
            //    Where(c=>c.RCSYear==_year).ToList();



            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + _context.AnnualRoadExpenditurePlan.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.FYearEC == yearFilter).ToList().Count;
        }

        public RoadExpenditureProgress(int roadID)
        {
            InitializeComponent();







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

            // view.SetRowCellValue(e.RowHandle, view.Columns["RoadID"], _roadID);
            view.SetRowCellValue(e.RowHandle, view.Columns["FYearEC"],
                cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text));
            // view.SetRowCellValue(e.RowHandle, view.Columns["RCSYear"], Convert.ToInt16(_year));

            //  view.SetRowCellValue(e.RowHandle, view.Columns["UserID"], _userID);
            //    view.SetRowCellValue(e.RowHandle, view.Columns["SurfaceType"], _SurfaceType);
        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;



            //if ((int)view.GetRowCellValue(e.RowHandle, view.Columns["SurfaceType"]) == 0)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Road Surface Type is Required";
            //}

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.AnnualRoadExpenditurePlan dw = (RAMSDBModel.AnnualRoadExpenditurePlan)view.GetRow(e.RowHandle);


                    //  dataLoader.AddNew(dw, "UnpavedRoadConditionSurvey");


                    _context.AnnualRoadExpenditurePlan.Add(dw);
                    _context.SaveChanges();
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

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);


            annualRoadExpenditurePlanBindingSource.DataSource = _context.AnnualRoadExpenditurePlan.
               Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.FYearEC == yearFilter).ToList();


            //unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.
            //    Where(c => c.RoadID == _roadID && c.RCSYear == yearFilter).ToList();

            // unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.Where(c => c.RoadID == _roadID).ToList();

            gridControl1.RefreshDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            _context.SaveChanges();
            // dataLoader.SaveData();
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
                        RAMSDBModel.AnnualRoadExpenditurePlan dw = (RAMSDBModel.AnnualRoadExpenditurePlan)view.GetRow(rowHandle);

                        //dataLoader.Delete(dw, "UnpavedRoadConditionSurvey");
                        //dataLoader.SaveData();
                        ////   _context.MultiCriteriaAnalysisData.Attach(dw);
                        _context.AnnualRoadExpenditurePlan.Remove(dw);
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
