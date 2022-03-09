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
    public partial class ContractPeformanceRoutineMaintenanceView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();
        public int recordsCount = 0;


        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();
        List<ContractRoutineMaintenance> contractInfo = new List<ContractRoutineMaintenance>();
        public int cID = 6;



        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;
        public string userWoreda = "";

        //public ContractPeformanceRoutineMaintenanceView()
        //{
        //    InitializeComponent();

        //    contractInfo = _context.ContractRoutineMaintenance.
        //         Where(c => c.ID == contractID).ToList();

        //    contractPeformanceRoutineMaintenanceBindingSource.DataSource =
        //        _context.ContractPeformanceRoutineMaintenance.Where(c => c.ContractRoutineID == contractID).ToList();


        //    contractRoutineMaintenanceBindingSource.DataSource = contractInfo.ToList();

        //    lblRegion.Text = contractInfo.Select(c => c.Region).FirstOrDefault().ToString();
        //    lblWoredaName.Text = contractInfo.Select(c => c.Woreda).FirstOrDefault().ToString();


        //}

        public ContractPeformanceRoutineMaintenanceView(int contractID)
        {
            InitializeComponent();


            cID = contractID;
            contractInfo = _context.ContractRoutineMaintenance.
                Where(c => c.ID == contractID).ToList();



            contractPeformanceRoutineMaintenanceBindingSource.DataSource =
                _context.ContractPeformanceRoutineMaintenance.Where(c => c.ContractRoutineID == contractID).ToList();

            contractRoutineMaintenanceBindingSource.DataSource = contractInfo.ToList();

            lblRegion.Text = contractInfo.Select(c => c.Region).FirstOrDefault().ToString();
            lblWoredaName.Text = contractInfo.Select(c => c.Woreda).FirstOrDefault().ToString();

            //contractPeriodiMSpotRRehabBindingSource.DataSource = _context.ContractPeriodiMSpotRRehab.
            //    Where(c => c.ID == contractID).ToList();






            //var woreda = _context.AdminBoundary.Where(c=>c.RegionName==_region).
            //    Select(c => new { c.ZoneName, c.WoredaName }).ToList();


            //adminBoundaryBindingSource.DataSource = woreda.ToList();

            //userWoreda = _context.RoadsPerUser.Where(c=>c.UserID == _userID).
            //    Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            //cboContractNumber.SelectedIndex = cboContractNumber.FindStringExact(userWoreda);

            //lblRegion.Text = _region;

            //contractPeriodiMSpotRRehabBindingSource.DataSource = _context.ContractPeriodiMSpotRRehab.
            //    Where(c => c.Woreda == userWoreda ).ToList();

            //roadWorkFundingBindingSource.DataSource = _context.RoadWorkFunding.
            //    Where(c=>c.Woreda==userWoreda && c.WorkPlanFiscalYear==_year.ToString()).ToList();

            //    bsiRecordsCount.Caption = "RECORDS : " + contractPeformancePeriodiMSpotRRehabBindingSource.Count.ToString();// unpavedSurvey.Count;

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void GridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {


            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns["ContractRoutineID"], cID);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], cboYear.SelectedItem == null ? _year.ToString() : cboYear.Text);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], txtFY.Text=="" ? _year.ToString() : txtFY.Text);
            // view.SetRowCellValue(e.RowHandle, view.Columns["Woreda"], cboContractNumber.SelectedItem==null ? userWoreda : cboContractNumber.Text);

        }


        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;


            //Validation Goes Here



            //if (view.GetRowCellValue(e.RowHandle, view.Columns["ContractNo"]) == null)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Contract No. is required";
            //}

            //if (view.GetRowCellValue(e.RowHandle, view.Columns["ContractorName"]) == null)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Contractor Name is required";
            //}
            //if (view.GetRowCellValue(e.RowHandle, view.Columns["TypeOfWork"]) == null)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Type of Work is required";
            //}


            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.ContractPeformanceRoutineMaintenance dw = (RAMSDBModel.ContractPeformanceRoutineMaintenance)view.GetRow(e.RowHandle);

                    _context.ContractPeformanceRoutineMaintenance.Add(dw);


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
            //  string woredaFilter = cboContractNumber.SelectedItem == null ? userWoreda : cboContractNumber.Text;

            contractPeformanceRoutineMaintenanceBindingSource.DataSource =
                           _context.ContractPeformanceRoutineMaintenance.Where(c => c.ContractRoutineID == cID).ToList();

            //   bsiRecordsCount.Caption = "RECORDS : " + contractPeformancePeriodiMSpotRRehabBindingSource.Count.ToString();// unpavedSurvey.Count;


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
                        RAMSDBModel.ContractPeformanceRoutineMaintenance dw = (RAMSDBModel.ContractPeformanceRoutineMaintenance)view.GetRow(rowHandle);
                        _context.ContractPeformanceRoutineMaintenance.Remove(dw);
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

        //private void cboWoreda_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    bbiRefresh.PerformClick();// _ItemClick;

        //}


    }
}
