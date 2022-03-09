using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms.PPP
{
    public partial class ContractRoutineMaintenanceView : DevExpress.XtraEditors.XtraUserControl// DevExpress.XtraBars.Ribbon.RibbonForm  //DevExpress.XtraEditors.XtraUserControl //
    {
        RAMSDBEntities _context = new RAMSDBEntities();


        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();




        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;
        public string userWoreda = "";


        public ContractRoutineMaintenanceView()
        {
            InitializeComponent();



            var woreda = _context.AdminBoundary.Where(c => c.RegionName == _region).
                OrderBy(c => c.WoredaName).
                Select(c => c.WoredaName).ToList();


            // adminBoundaryBindingSource.DataSource = woreda.ToList();

            cboWoreda.Items.AddRange(woreda.ToArray());

            userWoreda = _context.RoadsPerUser.Where(c => c.UserID == _userID).
                Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            cboWoreda.SelectedIndex = cboWoreda.FindStringExact(userWoreda);

            lblRegion.Text = _region;

            contractRoutineMaintenanceBindingSource.DataSource = _context.ContractRoutineMaintenance.
                Where(c => c.Woreda == userWoreda).ToList();

            //roadWorkFundingBindingSource.DataSource = _context.RoadWorkFunding.
            //    Where(c=>c.Woreda==userWoreda && c.WorkPlanFiscalYear==_year.ToString()).ToList();

            //  bsiRecordsCount.Caption = "RECORDS : " + unpavedSurvey.Count;

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {


            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["Region"], _region);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], cboYear.SelectedItem == null ? _year.ToString() : cboYear.Text);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], txtFY.Text=="" ? _year.ToString() : txtFY.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns["Woreda"], cboWoreda.SelectedItem == null ? userWoreda : cboWoreda.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns["TypeOfWork"], "Routine Maintenance");

        }


        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;


            //Validation Goes Here



            if (view.GetRowCellValue(e.RowHandle, view.Columns["ContractNo"]) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Contract No. is required";
            }

            if (view.GetRowCellValue(e.RowHandle, view.Columns["ContractorName"]) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Contractor Name is required";
            }
            if (view.GetRowCellValue(e.RowHandle, view.Columns["TypeOfWork"]) == null)
            {
                view.SetColumnError(null, "Required");
                e.Valid = false;
                e.ErrorText = "Type of Work is required";
            }


            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.ContractRoutineMaintenance dw = (RAMSDBModel.ContractRoutineMaintenance)view.GetRow(e.RowHandle);

                    _context.ContractRoutineMaintenance.Add(dw);


                    _context.SaveChanges();
                }
                else
                {
                    _context.SaveChanges();
                }
            }

        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridView view = gridView1 as GridView;

            gridView1.PostEditor();

            gridView1.UpdateCurrentRow();
        }


        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            string woredaFilter = cboWoreda.SelectedItem == null ? userWoreda : cboWoreda.Text;


            contractRoutineMaintenanceBindingSource.DataSource = _context.ContractRoutineMaintenance.
                Where(c => c.Woreda == woredaFilter).ToList();

            gridControl1.RefreshDataSource();

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            _context.SaveChanges();

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
                        RAMSDBModel.ContractRoutineMaintenance dw = (RAMSDBModel.ContractRoutineMaintenance)view.GetRow(rowHandle);
                        _context.ContractRoutineMaintenance.Remove(dw);
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

        private void cboWoreda_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();// _ItemClick;

        }

        private void GridView_RowDoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                if (info.InDataRow)
                {
                    if (view.GetRowCellValue(info.RowHandle, view.Columns["ID"]) != null)
                    {


                        int contractID = (int)view.GetRowCellValue(info.RowHandle, view.Columns["ID"]);
                        //   string surfaceTypeColumn = (string)view.GetRowCellValue(info.RowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                        DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new ContractPeformanceRoutineMaintenanceView(contractID);// TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                        ribbonForm.ShowDialog();

                        bbiRefresh.PerformClick();
                        //  gridView1.RefreshData();

                        //  unpavedRoadConditionSurveyBindingSource.DataSource

                        // unpavedRoadConditionSurveyBindingSource.DataSource = dataLoader.unpavedRoadConditionSurveysDL.ToList()
                    }

                }

            }

        }

        private void bbiProgress_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {



                GridView view = gridView1 as GridView;



                int rowHandle = view.GetSelectedRows()[0];

                if (!view.IsGroupRow(rowHandle))
                {
                    if (view.GetRowCellValue(rowHandle, view.Columns["ID"]) != null)
                    {
                       


                            int contractID = (int)view.GetRowCellValue(rowHandle, view.Columns["ID"]);
                            //   string surfaceTypeColumn = (string)view.GetRowCellValue(info.RowHandle, view.Columns["RoadSurfaceType.SurfaceTypeName"]);

                            DevExpress.XtraBars.Ribbon.RibbonForm ribbonForm = new ContractPeformanceRoutineMaintenanceView(contractID);// TentativeRoadMaintenancePlan(yearColumn, roadIDColumn, surfaceTypeColumn);
                            ribbonForm.ShowDialog();

                            bbiRefresh.PerformClick();
                        
                    }


                }
                else
                {
                    MessageBox.Show("Please select a row from the table below first.");
                }



            }
        }
    }

}

