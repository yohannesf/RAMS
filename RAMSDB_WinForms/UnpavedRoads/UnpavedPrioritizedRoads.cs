using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RAMSDB_WinForms
{
    public partial class UnpavedPrioritizedRoads : DevExpress.XtraEditors.XtraUserControl
    {
        UnpavedRoadPrioritizationClass prioritizationClass = new UnpavedRoadPrioritizationClass();
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

        public UnpavedPrioritizedRoads()
        {
            InitializeComponent();

            // RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();
            cboYear.Items.AddRange(years);

            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());

            InitBindings();
        }

        private void InitBindings()
        {


            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            roadsAssignedForUser = dataLoader.unpavedRoadsPerUserDL.Select(x => x.RoadID).ToList();


            tentativePrioritizedRoads = _context.PrioritizedRoads.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();


            tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();

            tentativeRoadIDs = tentativePrioritizedRoads.Select(t => t.RoadID).ToList();

            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter).ToList();
            //  bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization(yearFilter).ToList().Count;

            //prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization().Where(c => c.Year == yearFilter);

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

            //  List<Tuple<int, int>> tRoads = new List<Tuple<int, int>>();
            // tRoads = (from t in tentativePrioritizedRoads select new Tuple<int, int>(t.RoadID, t.Year)).ToList();

            int rowIndex = e.ListSourceRowIndex;



            if (e.Column.FieldName != "PTentative") return;

            //if (e.IsSetData && e.Value != null)
            //{
            //   if ((bool)e.Value)
            //    {
            //        RAMSDBModel.PrioritizedRoads roadsSelected = new RAMSDBModel.PrioritizedRoads();

            //        roadsSelected.AdminID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colAdminID);
            //        roadsSelected.Year = Convert.ToInt16((int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear));
            //        roadsSelected.RoadID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
            //        roadsSelected.PTentative = Convert.ToBoolean(e.Value);// (bool)view.GetRowCellValue(rowIndex, colPTentative);



            //        _context.PrioritizedRoads.Add(roadsSelected);

            //        _context.SaveChanges();
            //    }
            //    else if (!(bool)e.Value)
            //    {
            //        int rID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
            //        int rYear = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear);
            //        RAMSDBModel.PrioritizedRoads roadsSelected = (from q in _context.PrioritizedRoads where
            //                                                      q.RoadID == rID && q.Year == rYear
            //                                                      select q).FirstOrDefault();


            //        _context.PrioritizedRoads.Remove(roadsSelected);
            //        _context.SaveChanges();

            //    }
            //    view.RefreshData();

            //}


            if (e.IsGetData)//&& e.Value !=null
            {
                //  int rID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
                // int rYear = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear);
                //  var x = tRoads.ToList();

                if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID) != null)
                {
                    Tuple<Guid, int> t = new Tuple<Guid, int>((Guid)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));
                    e.Value = tentRoads.Contains(t);
                    // e.Value = tentRoads.Contains(new Tuple<int, int>((int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID), (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear)));

                }
                //  Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));

                //tentativeRoadIDs = _context.PrioritizedRoads.Select(t => t.RoadID).ToList();
                //e.Value = tentativeRoadIDs.Contains((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
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


            //    InitBindings();
            //    gridControl1.RefreshDataSource();

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);

            roadsAssignedForUser = dataLoader.unpavedRoadsPerUserDL.Select(x => x.RoadID).ToList();


            tentativePrioritizedRoads = _context.PrioritizedRoads.
                Where(p => roadsAssignedForUser.Contains(p.RoadID) && p.Year == yearFilter).ToList();

            //  tentRoads = tentativePrioritizedRoads.Select(c => new { c.RoadID, c.Year }).AsEnumerable().Select(t => new Tuple<int, int>(t.RoadID, t.Year)).ToList();


            tentRoads = (from t in tentativePrioritizedRoads select new Tuple<Guid, int>(t.RoadID, t.Year)).ToList();
            prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter).ToList();

            //   prioritizedRoadsBindingSource.DataSource = prioritizationClass.RunPrioritization(yearFilter);
            bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization(yearFilter).ToList().Count;



            gridControl1.RefreshDataSource();

            //bsiRecordsCount.Caption = "RECORDS : " + prioritizationClass.RunPrioritization().ToList().Count;

            gridView1.RefreshData();



        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (view == null) return;

            if (e.Column.FieldName != "PTentative") return;

            int rowIndex = e.RowHandle;

            int yearFilter = cboYear.SelectedItem == null ? Convert.ToInt16(_year) : Convert.ToInt16(cboYear.Text);
            roadsAssignedForUser = dataLoader.unpavedRoadsPerUserDL.Select(x => x.RoadID).ToList();

            if (e.Value != null)
            {


                if ((bool)e.Value)
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


        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            //GridView view = sender as GridView;
            //MessageBox.Show(e.Column.FieldName.ToString());

            // if (e.Column.FieldName == "PTentative")
            //{
            //    MessageBox.Show("Here");
            //}

            if (e.Column.FieldName != "PTentative") return;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

            //GridView view = sender as GridView;

            //view.
            //MessageBox.Show(e.Column.FieldName.ToString());

            //if (e.Column.FieldName == "PTentative")
            //{
            //    MessageBox.Show("Here");
            //}

            //if (e.Column.FieldName != "PTentative") return;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  SplashScreenManager splashScreenManager = new SplashScreenManager();

            // sp.IsSplashFormVisible()


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
                bbiRefresh.PerformClick();
            }

            if (splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.CloseWaitForm();



            //SplashScreenManager.ShowForm(typeof(WaitForm1));
            //try
            //{


            //}
            //finally
            //{
            //Close Wait Form
            //     SplashScreenManager.CloseForm(false);


            //splashScreenManager1.CloseWaitForm();
            //  }
            //   bbiRefresh.PerformClick();
        }
    }
}
