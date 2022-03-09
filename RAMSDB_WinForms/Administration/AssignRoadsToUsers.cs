using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDB_WinForms.ViewModel.AssignRoadsToUsersVM;
using RAMSDBModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAMSDB_WinForms.Administration
{
    public partial class AssignRoadsToUsers : DevExpress.XtraBars.Ribbon.RibbonForm  // DevExpress.XtraEditors.XtraUserControl
    {
        AssignRoadsToUsersVM vm = new AssignRoadsToUsersVM();
        RAMSDBEntities _context = new RAMSDBEntities();

        List<RoadsPerUser> rpu = new List<RoadsPerUser>();
        string _region = RAMSDBDataLoader.LoggedInUser.userRegion;

        CheckEdit edit;



        public AssignRoadsToUsers()
        {
            InitializeComponent();
            edit = new CheckEdit()
            {
                Text = String.Empty
            };
            edit.Properties.GlyphAlignment = HorzAlignment.Center;

            rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();

            //  RoadClass c = new RoadClass();

            //   gridControl.DataSource = vm.GetRoadsInWoredasWithInfo().ToList();
            //  gridControl.DataSource = vm.GetRoadsInWoredasWithInfoAsync(); // vm.GetRoadsInWoredasWithInfo().ToList();

            userBindingSource.DataSource = _context.User.ToList();

            roadsCrossingWoredasBindingSource.DataSource = _context.RoadsCrossingWoredas.ToList();

            // var f = InitBind();

            //  gridControl.DataSource = () ;
            //  roadClassBindingSource.DataSource =  InitBind();

            //var xxx =
            //    roadClassBindingSource.Count;
            // roadClassBindingSource.DataSource = InitBind();
        }

        public async Task InitBind()
        {
            //var f = await vm.GetRoadsInWoredasWithInfoAsync();

            ////   gridControl.DataSource = vm.GetRoadsInWoredasWithInfo().ToList();
            //await vm.GetRoadsInWoredasWithInfoAsync(); // vm.GetRoadsInWoredasWithInfo().ToList();


        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") gridControl.ShowRibbonPrintPreview();
        }

        private void windowsUIButtonPanel_Click(object sender, EventArgs e)
        {
            //User selecteduser = new User();
            //if (gridLookupUserAssign.Text == null) { MessageBox.Show("Please Select a User First"); return; }

            //if (gridLookupUserAssign.Text != null)

            //{
            //    selecteduser = (User)gridLookupUserAssign.GetSelectedDataRow();
            //    //   int userID = selecteduser.UserID;

            //    var gridSelectedTuples = GetSelectedValues2(gridView, "RoadID", "AdminID").ToList();



            //    RoadsPerUserRepository roadPerUserRepo = new RoadsPerUserRepository(_context);



            //    List<RAMSDBModel.RoadsPerUser> roadPerUserGridSelected = new List<RAMSDBModel.RoadsPerUser>();

            //    // UsersRepository tc = new UsersRepository(_context);
            //    // List<Users> u = new List<Users>();
            //    int t = 0;

            //    for (int i = 0; i < gridSelectedTuples.Count; i++)
            //    {
            //        RAMSDBModel.RoadsPerUser rpu = new RAMSDBModel.RoadsPerUser();
            //        rpu.RoadID = gridSelectedTuples[i].Item1;
            //        rpu.AdminID = gridSelectedTuples[i].Item2;
            //        rpu.UserID = selecteduser.UserID;



            //        //  _context.RoadsPerUsers.Add(rpu);
            //        roadPerUserGridSelected.Add(rpu);


            //    }

            //    var a = 1;

            //    _context.RoadsPerUser.AddRange(roadPerUserGridSelected);

            //    // roadPerUserRepo.AddRange(roadPerUserGridSelected);
            //    // _context.RoadsPerUsers.AddRange(tg);

            //    var numRecordsAdded = roadPerUserRepo.Context.SaveChanges();
            //    // var x = _context.SaveChanges();

            //    MessageBox.Show(numRecordsAdded.ToString());


            }
        }

    //    private List<Tuple<int, int>> GetSelectedValues2(DevExpress.XtraGrid.Views.Grid.GridView view, string roadID, string adminID)


    //    {

    //        int[] selectedRows = gridView.GetSelectedRows();//.GetSelectedRowHandles();//.SelectedItems.Count;
    //        List<Tuple<int, int>> x = new List<Tuple<int, int>>();

    //        // int[] selectedRows = view.GetSelectedRows();
    //        object[,] result = new object[selectedRows.Length, 2];
    //        for (int i = 0; i < selectedRows.Length; i++)
    //        {
    //            int rowHandle = selectedRows[i];
    //            if (!gridView.IsGroupRow(rowHandle))

    //            {
    //                object troadID = view.GetRowCellValue(rowHandle, roadID);
    //                object tadminID = view.GetRowCellValue(rowHandle, adminID);
    //                result[i, 0] = view.GetRowCellValue(rowHandle, roadID);
    //                result[i, 1] = view.GetRowCellValue(rowHandle, adminID);
    //                // x.Append(tuple[troadID,tAdminID]);
    //                x.Add(new Tuple<int, int>((int)troadID, (int)tadminID));
    //            }
    //            else
    //            {
    //                result[i, 0] = -1;
    //                result[i, 1] = -1;

    //            }//.Skip();//[i] = -1; // default value  
    //        }

    //        //foreach(var x in result)
    //        //{
    //        //    if (x == null)
    //        //    {
    //        //        var t = "Null";
    //        //    }
    //        //}

    //        //result.

    //        // var list = new List<(object[,],int)>(result);

    //        //ArrayList a1 =  new ArrayList();
    //        //a1 = result;


    //        //a1 = result;







    //        //lst.RemoveAll(x=>x==-1)
    //        //   list.RemoveAll(x => x== null);

    //        //    result = object[](list);

    //        //list.RemoveAll(list[0] => list[0] == -1);



    //        // vehicles.RemoveAll(vehicle => vehicle.EnquiryID == 123);

    //        return x.ToList();
    //    }

    //    async public void gridControl_Load(object sender, EventArgs e)
    //    {

    //        var clearExisitngData = _context.Database.ExecuteSqlCommand("Delete from RoadsCrossingWoredas");// SqlQuery<RAMSDBModel.>("TrafficScoreCalculation").ToList();




    //        List<string> woredas = _context.AdminBoundary.Where(c => c.RegionName == _region).
    //          OrderBy(c => c.WoredaName).
    //          Select(c => c.WoredaName).ToList();

    //        // List<string> woredas = new List<string>() { "Meskan" };

    //        List<RoadsCrossingWoredas> rsCrossingWoredas = new List<RoadsCrossingWoredas>();
    //        var t = _region;

    //        //  List<GetAllRoadsCrossingWoredas2Result> objList = new List<GetAllRoadsCrossingWoredas2Result>();
    //        foreach (var woreda in woredas)
    //        {
    //            List<RoadsCrossingWoredas> roads = await Task.Run(() => vm.GetRoadsInOneWoredaInfoAsync(woreda, _region));

    //            foreach (var road in roads)
    //            {
    //                rsCrossingWoredas.Add(road);
    //                //objList.Add(road);
    //            }



    //            // objList.Add()

    //            // objList.Add((GetAllRoadsCrossingWoredasResult)(await Task.Run(() => vm.GetRoadsInWoredasWithInfoAsync(woreda))));
    //            //gridControl.DataSource = objList.ToList();
    //            gridControl.DataSource = rsCrossingWoredas.ToList();
    //        }
    //        _context.RoadsCrossingWoredas.AddRange(rsCrossingWoredas);
    //        _context.SaveChanges();
    //        var ttt = rsCrossingWoredas.ToList();

    //        // gridControl.DataSource = await Task.Run(() => vm.GetRoadsInWoredasWithInfoAsync()); //GetDataHere()); ;// ;
    //    }

    //    private void btnUnassign_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    //    {

    //        GridView view = gridView as GridView;



    //        if (view == null) return;



    //        if (view.GetFocusedRowCellValue(colRoadID.FieldName) == null) return;
    //        if ((int)view.GetFocusedRowCellValue(colUser.FieldName) == 0) return;

    //        //  var rID = view.GetFocusedRowCellValue(colRoadID.FieldName).ToString();
    //        //    var uID = view.GetFocusedRowCellValue(colUser.FieldName).ToString();

    //        int rowHandle = view.FocusedRowHandle;//.GetFocusedRow(rowHandle;//.GetSelectedRows()[0];
    //        if (!view.IsGroupRow(rowHandle))
    //        {

    //            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Unassign the road from this user?", "Unassign", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
    //            if (dialogResult == DialogResult.Yes)
    //            {
    //                RoadsPerUser roadsPerUser = new RoadsPerUser();

    //                int uID = (int)view.GetFocusedRowCellValue(colUser.FieldName);
    //                int rID = (int)view.GetFocusedRowCellValue(colRoadID.FieldName);
    //                int aID = (int)view.GetFocusedRowCellValue(colAdminID.FieldName);



    //                roadsPerUser.UserID = (int)view.GetFocusedRowCellValue(colUser.FieldName);
    //                roadsPerUser.RoadID = (int)view.GetFocusedRowCellValue(colRoadID.FieldName);
    //                roadsPerUser.AdminID = (int)view.GetFocusedRowCellValue(colAdminID.FieldName);


    //                var customer = _context.RoadsPerUser.Single
    //                    (c => c.UserID == uID &&
    //                    c.RoadID == rID);
    //                _context.RoadsPerUser.Remove(customer);




    //                //       localDb.Customers.Single(o => o.CustomerId == id);
    //                //    localDb.Customers.Remove(customer);
    //                //   localDb.SaveChanges();


    //                //  _context.RoadsPerUser.Remove(roadsPerUser);



    //                //    view.PostEditor();

    //                //    view.UpdateCurrentRow();
    //                _context.SaveChanges();

    //                rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();


    //                //  gridControl.RefreshDataSource();

    //                //view.CustomUnboundColumnData += (s, ed) =>
    //                //{
    //                //    var t = 1;
    //                //    //    if (ed.Column.FieldName == "colUnassign")
    //                //    //    {
    //                //    //        // Populate columns
    //                //    //        //if (e.IsGetData)
    //                //    //        //{
    //                //    //        //    if (unboundData.ContainsKey(e.ListSourceRowIndex))
    //                //    //        //        e.Value = unboundData[e.ListSourceRowIndex];
    //                //    //        //}
    //                //    //        //// Post edits back to the source
    //                //    //        //if (e.IsSetData && e.Value != null)
    //                //    //        //{
    //                //    //        //    unboundData[e.ListSourceRowIndex] = e.Value.ToString();
    //                //    //        //}
    //                //    //    }
    //                //};



    //                gridView.RefreshRowCell(rowHandle, colUser);
    //                //gridView.RefreshRow(rowHandle);
    //                //   gridView.RefreshData();

    //                //  view.CustomUnboundColumnData += gridView_CustomUnboundColumnData(c,c)

    //                //  gridView_CustomUnboundColumnData+;
    //                //  view.RefreshData();
    //                //     view.CustomUnboundColumnData += gridView_CustomUnboundColumnData;

    //            }
    //            else
    //                return;



    //        }




    //        //MessageBox.Show(rID + '\n' + uID );




    //        //  List<Tuple<int, int>> tRoads = new List<Tuple<int, int>>();
    //        // tRoads = (from t in tentativePrioritizedRoads select new Tuple<int, int>(t.RoadID, t.Year)).ToList();

    //        //  int rowIndex = e.ListSourceRowIndex;



    //        //   if (e.Column.FieldName != "PTentative") return;

    //    }

    //    private void View_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    //    {

    //        throw new NotImplementedException();
    //    }

    //    //private void btnUnassign_ButtonClick(object sender, EventArgs e)
    //    //{
    //    //    if (gridView == null) return;

    //    //    if (gridView.GetFocusedRowCellValue(colRoadID.FieldName) == null) return;

    //    //    var rID = gridView.GetFocusedRowCellValue(colRoadID.FieldName).ToString();
    //    //    var uID = gridView.GetFocusedRowCellValue(colUserID.FieldName).ToString();

    //    //    MessageBox.Show(rID + '\n' + uID);
    //    //}

    //    private void gridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    //    {
    //        GridView view = sender as GridView;

    //        if (view == null) return;

    //        //  List<Tuple<int, int>> tRoads = new List<Tuple<int, int>>();
    //        // tRoads = (from t in tentativePrioritizedRoads select new Tuple<int, int>(t.RoadID, t.Year)).ToList();

    //        int rowIndex = e.ListSourceRowIndex;



    //        if (e.Column.FieldName != "colUser") return;




    //        if (e.IsGetData)
    //        {
    //            //  int rID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
    //            // int rYear = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear);
    //            //  var x = tRoads.ToList();

    //            if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID) != null)
    //            {
    //                int uID = rpu.Where(c => c.RoadID == (int)view.GetListSourceRowCellValue(rowIndex, "RoadID")).Select(c => c.UserID).FirstOrDefault();
    //                e.Value = uID;// rpu.Where(c => c.RoadID == (int)view.GetListSourceRowCellValue(rowIndex, "RoadID")).Select(c => c.UserID);
    //                              //  Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));
    //                              //   e.Value = tentRoads.Contains(t);
    //                              // e.Value = tentRoads.Contains(new Tuple<int, int>((int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID), (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear)));

    //            }
    //            //  Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));

    //            //tentativeRoadIDs = _context.PrioritizedRoads.Select(t => t.RoadID).ToList();
    //            //e.Value = tentativeRoadIDs.Contains((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
    //        }
    //    }

    //    private void gridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
    //    {
    //        var rowInfo = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;

    //        if (rowInfo.GroupText.Contains("Zone Name"))
    //        {
    //            rowInfo.SelectorInfo = null;
    //            e.DefaultDraw();
    //        }
    //        else
    //        {
    //            e.DefaultDraw();
    //        }

    //        e.Handled = true;
    //    }

    //    private void gridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    //    {
    //        int[] selectedRows = gridView.GetSelectedRows();
    //        var sRoads = GetSelectedRoads(gridView, "RoadID").ToList();
    //        var x = sRoads.Count;

    //        gridView.SelectionChanged -= gridView_SelectionChanged;

    //        // gridView.OptionsSelection..sho.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.False;// false;

    //        for (int row = 0; row < gridView.RowCount; row++)
    //        {
    //            if (gridView.GetRowCellValue(row, colRoadID) != null)
    //            {


    //                int rID = (int)gridView.GetRowCellValue(row, colRoadID);


    //                if (sRoads.Contains(rID) && !(selectedRows.Contains(row)))
    //                {
    //                    gridView.UnselectRow(row);
    //                    //    gridView.cell
    //                    // gridView.OptionsColumn.AllowEdit = false;
    //                    //  GridCheckMarksSelection selector = new GridCheckMarksSelection(gridView);
    //                    //   selector.DisabledRecords.Add(gridView.GetRow(row));
    //                    // selector.DisabledRecords.Add(list[3]);
    //                    // gridView.CustomDrawRowIndicator += gridView_CustomDrawRowIndicator;
    //                }
    //            }
    //        }

    //        gridView.SelectionChanged += gridView_SelectionChanged;

    //    }

    //    private List<int> GetSelectedRoads(DevExpress.XtraGrid.Views.Grid.GridView view, string roadID)


    //    {

    //        int[] selectedRows = gridView.GetSelectedRows();//.GetSelectedRowHandles();//.SelectedItems.Count;
    //        List<int> x = new List<int>();

    //        // int[] selectedRows = view.GetSelectedRows();
    //        object[] result = new object[selectedRows.Length];
    //        for (int i = 0; i < selectedRows.Length; i++)
    //        {
    //            int rowHandle = selectedRows[i];
    //            if (!gridView.IsGroupRow(rowHandle))

    //            {
    //                object troadID = view.GetRowCellValue(rowHandle, roadID);
    //                //  object tadminID = view.GetRowCellValue(rowHandle, adminID);
    //                result[i] = view.GetRowCellValue(rowHandle, roadID);
    //                //  result[i, 1] = view.GetRowCellValue(rowHandle, adminID);
    //                // x.Append(tuple[troadID,tAdminID]);
    //                x.Add((int)troadID);//, (int)tadminID));
    //            }
    //            else
    //            {
    //                result[i] = -1;
    //                // result[i, 1] = -1;

    //            }//.Skip();//[i] = -1; // default value  
    //        }

    //        //foreach(var x in result)
    //        //{
    //        //    if (x == null)
    //        //    {
    //        //        var t = "Null";
    //        //    }
    //        //}

    //        //result.

    //        // var list = new List<(object[,],int)>(result);

    //        //ArrayList a1 =  new ArrayList();
    //        //a1 = result;


    //        //a1 = result;







    //        //lst.RemoveAll(x=>x==-1)
    //        //   list.RemoveAll(x => x== null);

    //        //    result = object[](list);

    //        //list.RemoveAll(list[0] => list[0] == -1);



    //        // vehicles.RemoveAll(vehicle => vehicle.EnquiryID == 123);

    //        return x.ToList();
    //    }

    //    private void gridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    //    {
    //        //   GridView gridView = sender as GridView;

    //        //   //gridView.VisibleColumns.IndexOf().ToString()

    //        //   //gridControl.Columns[["FieldName"].VisibleIndex

    //        // //  gridView.getcol

    //        ////gridView.index gridView.indexof

    //        //   if (e.Column.AbsoluteIndex == 0)
    //        //   {
    //        //       ObjectState state;
    //        //       bool value = IsNeedDisable(e, gridView);
    //        //       if (value)
    //        //       {
    //        //           edit.Enabled = true;
    //        //           state = ObjectState.Normal;
    //        //       }
    //        //       else
    //        //       {
    //        //           edit.Enabled = false;
    //        //           state = ObjectState.Disabled;
    //        //       }

    //        //       //DrawCheckBox(e.Graphics,
    //        //       //    e.Bounds,
    //        //       //    Convert.ToBoolean(e.CellValue), state);

    //        //       //e.Handled = true;
    //        //    }
    //    }

    //    private bool IsNeedDisable(DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e, GridView gridView)
    //    {
    //        return true;// (bool)gridView.GetRowCellValue(e.RowHandle, gridView.Columns[2]);
    //    }

    //    protected void DrawCheckBox(Graphics g, Rectangle r, bool Checked, ObjectState state)
    //    {
    //        CheckEditViewInfo info;
    //        CheckEditPainter painter;
    //        ControlGraphicsInfoArgs args;

    //        edit.EditValue = Checked;

    //        info = edit.Properties.CreateViewInfo() as CheckEditViewInfo;
    //        painter = edit.Properties.CreatePainter() as CheckEditPainter;

    //        info.State = state;
    //        info.EditValue = Checked;
    //        info.Bounds = r;

    //        info.CalcViewInfo(g);
    //        args = new ControlGraphicsInfoArgs(info, new GraphicsCache(g), r);

    //        painter.Draw(args);
    //        args.Cache.Dispose();
    //    }
    //}
}
