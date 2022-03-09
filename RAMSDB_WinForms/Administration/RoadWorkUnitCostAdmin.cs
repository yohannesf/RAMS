﻿using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RAMSDB_WinForms.Administration
{
    public partial class RoadWorkUnitCostAdmin : DevExpress.XtraEditors.XtraUserControl // DevExpress.XtraBars.Ribbon.RibbonForm
    {
        RAMSDBModel.RAMSDBEntities dbContext = new RAMSDBModel.RAMSDBEntities();
        public RoadWorkUnitCostAdmin()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext

           
            ribbon.SelectPage(rpHome);
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.

            unpavedRoadUnitCostBindingSource.DataSource = dbContext.UnpavedRoadUnitCost.ToList();
            // Instantiate a new DBContext

            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.

            // Bind data to control when loading complete
            pavedRoadUnitCostBindingSource.DataSource = dbContext.PavedRoadUnitCost.ToList();
        }

        private void gridUnpavedUnitCost_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Valid)
            {


                dbContext.SaveChanges();
            }
        }

        private void gridPavedUnitCost_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Valid)
            {


                dbContext.SaveChanges();
            }

        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            GridView viewPaved = gridPavedUnitCost as GridView;
            GridView viewUnpaved = gridUnpavedUnitCost as GridView;

            viewPaved.PostEditor();
            viewUnpaved.PostEditor();

            viewPaved.UpdateCurrentRow();
            viewUnpaved.UpdateCurrentRow();

        }

        private void RoadWorkUnitCostAdmin_Load(object sender, System.EventArgs e)
        {
            ribbon.SelectPage(rpHome);
        }
    }
}