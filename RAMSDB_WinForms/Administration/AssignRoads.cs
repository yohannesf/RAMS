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
    public partial class AssignRoads : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
      
     

        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();

        List<RoadsGISData> roadData = new List<RoadsGISData>();
        List<AdminBoundary> adminBoundary = new List<AdminBoundary>();
        List<RoadsPerUser> rpu = new List<RoadsPerUser>();

        public Guid _roadID;
       // public int _year = DateTime.Now.Year;
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;
        List<Role> _roles = new List<Role>();
        List<UserRole> _userRoles = new List<UserRole>();
        List<User> _users = new List<User>();



        public AssignRoads()
        {
            InitializeComponent();

            roadData = _context.RoadsGISData.
                Where(c => c.RegionName == _region && c.IsActive==true && c.AdminID!=null).ToList();

            adminBoundary = _context.AdminBoundary.
                OrderBy(c=>c.WoredaName).
                Where(c => c.RegionName == _region).ToList();

            rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();


            roadsGISDataBindingSource.DataSource = roadData;

            lblRegion.Text = _region;

            roadSurfaceTypeBindingSource.DataSource = _context.RoadSurfaceType.ToList();
            roadClassificationBindingSource.DataSource = _context.RoadClassification.ToList();
            roadTypePavedUnpavedBindingSource.DataSource = _context.RoadTypePavedUnpaved.ToList();
            adminBoundaryBindingSource.DataSource = adminBoundary;

            _users = _context.User.Where(c => c.Region == _region && c.IsActive == true).ToList();


            userBindingSource.DataSource = _users;


            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl1.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + roadData.Count;
        }

        public AssignRoads(int roadID)
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

      

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // gridView1.RefreshData();

            roadData = _context.RoadsGISData.
                Where(c => c.RegionName == _region && c.IsActive == true && c.AdminID != null).ToList();

            rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();



            roadsGISDataBindingSource.DataSource = roadData;

            //  unpavedRoadConditionSurveyBindingSource.DataSource = unpavedSurvey.ToList();
            gridControl1.RefreshDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            _context.SaveChanges();
          //  dataLoader.SaveData();
        }

        //private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (gridView1.SelectedRowsCount > 0)
        //    {



        //        GridView view = gridView1 as GridView;



        //        int rowHandle = view.GetSelectedRows()[0];

        //        if (!view.IsGroupRow(rowHandle))
        //        {

        //            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        //            if (dialogResult == DialogResult.Yes)
        //            {

                   
        //                RoadsGISData dw = (RoadsGISData)view.GetRow(rowHandle);
        //                dw.IsActive = false;
        //                 _context.SaveChanges();


        //                view.DeleteRow(rowHandle);
        //                bbiRefresh.PerformClick();

        //            }
        //            else
        //                return;



        //        }
        //        else
        //        {
        //            MessageBox.Show("Please first select a row from the table below.");
        //        }

        //    }
        //}

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;

            if (view == null) return;

            //  List<Tuple<int, int>> tRoads = new List<Tuple<int, int>>();
            // tRoads = (from t in tentativePrioritizedRoads select new Tuple<int, int>(t.RoadID, t.Year)).ToList();

            int rowIndex = e.ListSourceRowIndex;



            if (e.Column.FieldName != "colUser") return;




            if (e.IsGetData)
            {
                //  int rID = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID);
                // int rYear = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear);
                //  var x = tRoads.ToList();

                if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID) != null)
                {
                    Guid uID = rpu.Where(c => c.RoadID == (Guid)view.GetListSourceRowCellValue(rowIndex, "RoadID")).Select(c => c.UserID).FirstOrDefault();
                    e.Value = uID;// rpu.Where(c => c.RoadID == (int)view.GetListSourceRowCellValue(rowIndex, "RoadID")).Select(c => c.UserID);
                                  //  Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));
                                  //   e.Value = tentRoads.Contains(t);
                                  // e.Value = tentRoads.Contains(new Tuple<int, int>((int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colRoadID), (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, colYear)));

                }
                //  Tuple<int, int> t = new Tuple<int, int>((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"), (int)view.GetListSourceRowCellValue(rowIndex, "Year"));

                //tentativeRoadIDs = _context.PrioritizedRoads.Select(t => t.RoadID).ToList();
                //e.Value = tentativeRoadIDs.Contains((int)view.GetListSourceRowCellValue(rowIndex, "RoadID"));
            }
        }

        private void btnUnassign_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView view = gridView1 as GridView;



            if (view == null) return;



            if (view.GetFocusedRowCellValue(colRoadID.FieldName) == null) return;
           
            if (view.GetFocusedRowCellValue(colUser.FieldName) == null || (Guid)view.GetFocusedRowCellValue(colUser.FieldName) == Guid.Empty) return;

            int rowHandle = view.FocusedRowHandle;//.GetFocusedRow(rowHandle;//.GetSelectedRows()[0];
            if (!view.IsGroupRow(rowHandle))
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Unassign the road from this user?", "Unassign", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    RoadsPerUser roadsPerUser = new RoadsPerUser();

                    Guid uID = (Guid)view.GetFocusedRowCellValue(colUser.FieldName);
                    Guid rID = (Guid)view.GetFocusedRowCellValue(colRoadID.FieldName);
                    int aID = (int)view.GetFocusedRowCellValue(colAdminID.FieldName);



                    roadsPerUser.UserID = (Guid)view.GetFocusedRowCellValue(colUser.FieldName);
                    roadsPerUser.RoadID = (Guid)view.GetFocusedRowCellValue(colRoadID.FieldName);
                    roadsPerUser.AdminID = (int)view.GetFocusedRowCellValue(colAdminID.FieldName);


                    var customer = _context.RoadsPerUser.Single
                        (c => c.UserID == uID &&
                        c.RoadID == rID);
                    _context.RoadsPerUser.Remove(customer);


                    _context.SaveChanges();

                    rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();

       



                    view.RefreshRowCell(rowHandle, colUser);
                  
                }
                else
                    return;



            }






        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (gridLookupUserAssign.Text == string.Empty) { MessageBox.Show("Please Select a User First"); return; }
            User selecteduser = new User();

            if (gridLookupUserAssign.Text != string.Empty)

            {

                selecteduser = (User)gridLookupUserAssign.GetSelectedDataRow();
                //   int userID = selecteduser.UserID;

                var gridSelectedTuples = GetSelectedValues2(gridView1, "RoadID", "AdminID").ToList();

                if (gridSelectedTuples.Count == 0)
                {
                    MessageBox.Show("Please Select Roads"); return;
                }

                RoadsPerUserRepository roadPerUserRepo = new RoadsPerUserRepository(_context);



                List<RAMSDBModel.RoadsPerUser> roadPerUserGridSelected = new List<RAMSDBModel.RoadsPerUser>();

                // UsersRepository tc = new UsersRepository(_context);
                // List<Users> u = new List<Users>();
                int t = 0;

                for (int i = 0; i < gridSelectedTuples.Count; i++)
                {
                    RAMSDBModel.RoadsPerUser rpu = new RAMSDBModel.RoadsPerUser();
                    rpu.RoadID = gridSelectedTuples[i].Item1;
                    rpu.AdminID = gridSelectedTuples[i].Item2;
                    rpu.UserID = selecteduser.UserID;



                    //  _context.RoadsPerUsers.Add(rpu);
                    roadPerUserGridSelected.Add(rpu);


                }

              

                _context.RoadsPerUser.AddRange(roadPerUserGridSelected);

                // roadPerUserRepo.AddRange(roadPerUserGridSelected);
                // _context.RoadsPerUsers.AddRange(tg);

                var numRecordsAdded = roadPerUserRepo.Context.SaveChanges();

                rpu = _context.RoadsPerUser.Where(c => c.AdminBoundary.RegionName == _region).ToList();


                gridView1.RefreshData();


                //view.RefreshRowCell(rowHandle, colUser);
                // var x = _context.SaveChanges();

                MessageBox.Show(numRecordsAdded.ToString() + " road(s) assigned to selected user.");


            }
        }


        private List<Tuple<Guid, int>> GetSelectedValues2(DevExpress.XtraGrid.Views.Grid.GridView view, string roadID, string adminID)


        {

            int[] selectedRows = gridView1.GetSelectedRows();//.GetSelectedRowHandles();//.SelectedItems.Count;
            List<Tuple<Guid, int>> x = new List<Tuple<Guid, int>>();

            // int[] selectedRows = view.GetSelectedRows();
            object[,] result = new object[selectedRows.Length, 2];
            for (int i = 0; i < selectedRows.Length; i++)
            {
                int rowHandle = selectedRows[i];
                if (!gridView1.IsGroupRow(rowHandle))

                {
                    object troadID = view.GetRowCellValue(rowHandle, roadID);
                    object tadminID = view.GetRowCellValue(rowHandle, adminID);
                    result[i, 0] = view.GetRowCellValue(rowHandle, roadID);
                    result[i, 1] = view.GetRowCellValue(rowHandle, adminID);
                    // x.Append(tuple[troadID,tAdminID]);
                    x.Add(new Tuple<Guid, int>((Guid)troadID, (int)tadminID));
                }
                else
                {
                    result[i, 0] = -1;
                    result[i, 1] = -1;

                }//.Skip();//[i] = -1; // default value  
            }

            //foreach(var x in result)
            //{
            //    if (x == null)
            //    {
            //        var t = "Null";
            //    }
            //}

            //result.

            // var list = new List<(object[,],int)>(result);

            //ArrayList a1 =  new ArrayList();
            //a1 = result;


            //a1 = result;







            //lst.RemoveAll(x=>x==-1)
            //   list.RemoveAll(x => x== null);

            //    result = object[](list);

            //list.RemoveAll(list[0] => list[0] == -1);



            // vehicles.RemoveAll(vehicle => vehicle.EnquiryID == 123);

            return x.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
