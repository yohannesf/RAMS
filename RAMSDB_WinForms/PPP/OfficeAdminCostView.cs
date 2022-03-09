using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using RAMSDB.Data;
using RAMSDBModel;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace RAMSDB_WinForms.PPP
{
    public partial class OfficeAdminCostView : DevExpress.XtraEditors.XtraUserControl// DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBEntities _context = new RAMSDBEntities();


        RAMSDBDataLoader dataLoader = new RAMSDBDataLoader();



        public int _year = LinqHelper.ECYear();
        public string[] years = LinqHelper.ListofYearsEC();
        public Guid _userID = RAMSDBDataLoader.LoginInfo.GetLoggedInUser.UserID;
        public string _region = RAMSDBDataLoader.LoggedInUser.userRegion;
        public string userWoreda = "";


        public OfficeAdminCostView()
        {
            InitializeComponent();



            cboYear.Items.AddRange(years);
            cboYear.SelectedIndex = cboYear.FindStringExact(_year.ToString());



            var woreda = _context.AdminBoundary.Where(c => c.RegionName == _region).
                   OrderBy(c => c.WoredaName).
                   Select(c => c.WoredaName).ToList();


            // adminBoundaryBindingSource.DataSource = woreda.ToList();

            cboWoreda.Items.AddRange(woreda.ToArray());

            userWoreda = _context.RoadsPerUser.Where(c => c.UserID == _userID).
                Select(c => c.AdminBoundary.WoredaName).FirstOrDefault().ToString();

            cboWoreda.SelectedIndex = cboWoreda.FindStringExact(userWoreda);

            lblRegion.Text = _region;

            officeSupplyAdminCostBindingSource.DataSource = _context.OfficeSupplyAdminCost.
                Where(c => c.Woreda == userWoreda && c.WorkPlanFiscalYear == _year.ToString()).ToList();

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
            view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], cboYear.SelectedItem == null ? _year.ToString() : cboYear.Text);
            //  view.SetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"], txtFY.Text=="" ? _year.ToString() : txtFY.Text);
            view.SetRowCellValue(e.RowHandle, view.Columns["Woreda"], cboWoreda.SelectedItem == null ? userWoreda : cboWoreda.Text);

        }


        private void GridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;


            //Validation Goes Here


            //if (view.GetRowCellValue(e.RowHandle, view.Columns["WorkPlanFiscalYear"]) == null)
            //{
            //    view.SetColumnError(null, "Required");
            //    e.Valid = false;
            //    e.ErrorText = "Road Surface Type is Required";
            //}

            if (e.Valid)
            {


                if (view.IsNewItemRow(e.RowHandle))
                {
                    RAMSDBModel.OfficeSupplyAdminCost dw = (RAMSDBModel.OfficeSupplyAdminCost)view.GetRow(e.RowHandle);

                    _context.OfficeSupplyAdminCost.Add(dw);


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
            string yearFilter = cboYear.SelectedItem == null ? _year.ToString() : cboYear.Text;

            officeSupplyAdminCostBindingSource.DataSource = _context.OfficeSupplyAdminCost.
                Where(c => c.Woreda == woredaFilter && c.WorkPlanFiscalYear == yearFilter).ToList();

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
                        RAMSDBModel.OfficeSupplyAdminCost dw = (RAMSDBModel.OfficeSupplyAdminCost)view.GetRow(rowHandle);
                        _context.OfficeSupplyAdminCost.Remove(dw);
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

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bbiRefresh.PerformClick();
        }
    }
}
