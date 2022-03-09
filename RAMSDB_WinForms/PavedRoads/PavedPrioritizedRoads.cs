using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms.PavedRoads
{
    public partial class PavedPrioritizedRoads : DevExpress.XtraEditors.XtraUserControl
    {
        PavedRoadPrioritizationClass prioritizationClass = new PavedRoadPrioritizationClass();
        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        List<Guid> tentativeRoadIDs = new List<Guid>();
        List<Tuple<Guid, int>> tentRoads = new List<Tuple<Guid, int>>();
        RAMSDBEntities _context = new RAMSDBEntities();
        List<Guid> roadsAssignedForUser = new List<Guid>();
        List<RAMSDBModel.PrioritizedRoads> tentativePrioritizedRoads = new List<RAMSDBModel.PrioritizedRoads>();

        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();

       // public string[] years = LinqHelper.ListofYearsGC();
     //   public int _year = DateTime.Now.Year;

        public PavedPrioritizedRoads()
        {
            InitializeComponent();

            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            // RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();

            InitBindings();
        }

        private void InitBindings()
        {
            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            roadsAssignedForUser = dataLoader.pavedRoadsPerUserDL.Select(x => x.RoadID).ToList();


            tentativePrioritizedRoads = _context.PrioritizedRoads.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();


            tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();


            tentativeRoadIDs = tentativePrioritizedRoads.Select(t => t.RoadID).ToList();


            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter);

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization(yearFilter).ToList().Count;
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }




        private void GridView_UnboundColumns(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {



            GridView view = sender as GridView;

            if (view == null) return;


            int rowIndex = e.ListSourceRowIndex;



            if (e.Column.FieldName != "PTentative") return;




            if (e.IsGetData)
            {



                if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID) != null)
                {


                    Tuple<Guid, int> t = new Tuple<Guid, int>((Guid)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));
                    e.Value = tentRoads.Contains(t);
                }
            }





        }

        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Valid)
            {



                _context.SaveChanges();

            }
        }




        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            roadsAssignedForUser = dataLoader.unpavedRoadsPerUserDL.Select(x => x.RoadID).ToList();


            tentativePrioritizedRoads = _context.PrioritizedRoads.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();

            //  tentRoads = tentativePrioritizedRoads.Select(c => new { c.RoadID, c.Year }).AsEnumerable().Select(t => new Tuple<int, int>(t.RoadID, t.Year)).ToList();


            tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();
            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter).ToList();

            //  prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter);

            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization(yearFilter).ToList().Count;

            gridControl1.RefreshDataSource();
            gridView1.RefreshData();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
                // splashScreenManager1.SetWaitFormCaption("Calculating Prioritization Index");
                bbiRefresh.PerformClick();
            }

            if (splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.CloseWaitForm();
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view == null) return;

            if (e.Column.FieldName != "PTentative") return;

            int rowIndex = e.RowHandle;

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            roadsAssignedForUser = dataLoader.pavedRoadsPerUserDL.Select(x => x.RoadID).ToList();

            if (e.Value != null)
            {



                if ((bool)e.Value == true)
                {


                    RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();

                    RAMSDB.Data.PrioritizedRoads dw = (RAMSDB.Data.PrioritizedRoads)view.GetRow(e.RowHandle);

                    roadsSelected.AdminID = dw.AdminID;
                    roadsSelected.Year = Convert.ToInt16(dw.Year);
                    roadsSelected.RoadID = dw.RoadID;
                    roadsSelected.PTentative = Convert.ToBoolean(e.Value);// (bool)view.GetRowCellValue(rowIndex, colPTentative);

                    _context.PrioritizedRoads.Add(roadsSelected);

                    view.PostEditor();

                    view.UpdateCurrentRow();
                    _context.SaveChanges();


                    tentativePrioritizedRoads = _context.PrioritizedRoads.
                             Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();

                    tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();


                    tentativeRoadIDs = tentativePrioritizedRoads.Select(t => t.RoadID).ToList();



                }



                else if (!(bool)e.Value)
                {

                    RAMSDB.Data.PrioritizedRoads dw = (RAMSDB.Data.PrioritizedRoads)view.GetRow(e.RowHandle);

                    //int rID = (int)view.GetListSourceRowCellValue(rowIndex, colRoadID);
                    int rYear = Convert.ToInt16(dw.Year);
                    RAMSDBModel.PrioritizedRoads roadsSelected = (from q in _context.PrioritizedRoads
                                                                  where
                              q.RoadID == dw.RoadID && q.Year == rYear
                                                                  select q).FirstOrDefault();

                    if (roadsSelected != null)
                    {


                        _context.PrioritizedRoads.Remove(roadsSelected);
                        view.PostEditor();

                        view.UpdateCurrentRow();
                        _context.SaveChanges();


                        tentativePrioritizedRoads = _context.PrioritizedRoads.
                          Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();


                        tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();


                        tentativeRoadIDs = tentativePrioritizedRoads.Select(t => t.RoadID).ToList();
                    }

                }
            }
        }




    }

}

