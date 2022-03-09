namespace RAMSDB_WinForms
{
    partial class FormForTesting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.prioritizedRoadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadOriginDestination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPopulationServed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefitFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverallScore = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(910, 192);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 561);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(910, 28);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.prioritizedRoadsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 192);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(910, 369);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.colRoadID,
            this.colAdminID,
            this.colZone,
            this.colWoreda,
            this.colRoadOriginDestination,
            this.colRoadSurfaceType,
            this.colRoadClass,
            this.colPopulationServed,
            this.colBenefitFactor,
            this.colTotalCost,
            this.colOverallScore});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // prioritizedRoadsBindingSource
            // 
            this.prioritizedRoadsBindingSource.DataSource = typeof(RAMSDB.Data.PrioritizedRoads);
            // 
            // colYear
            // 
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 25;
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            this.colYear.Width = 94;
            // 
            // colRoadID
            // 
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Visible = true;
            this.colRoadID.VisibleIndex = 1;
            this.colRoadID.Width = 94;
            // 
            // colAdminID
            // 
            this.colAdminID.FieldName = "AdminID";
            this.colAdminID.MinWidth = 25;
            this.colAdminID.Name = "colAdminID";
            this.colAdminID.Visible = true;
            this.colAdminID.VisibleIndex = 2;
            this.colAdminID.Width = 94;
            // 
            // colZone
            // 
            this.colZone.FieldName = "Zone";
            this.colZone.MinWidth = 25;
            this.colZone.Name = "colZone";
            this.colZone.Visible = true;
            this.colZone.VisibleIndex = 3;
            this.colZone.Width = 94;
            // 
            // colWoreda
            // 
            this.colWoreda.FieldName = "Woreda";
            this.colWoreda.MinWidth = 25;
            this.colWoreda.Name = "colWoreda";
            this.colWoreda.Visible = true;
            this.colWoreda.VisibleIndex = 4;
            this.colWoreda.Width = 94;
            // 
            // colRoadOriginDestination
            // 
            this.colRoadOriginDestination.FieldName = "RoadOriginDestination";
            this.colRoadOriginDestination.MinWidth = 25;
            this.colRoadOriginDestination.Name = "colRoadOriginDestination";
            this.colRoadOriginDestination.Visible = true;
            this.colRoadOriginDestination.VisibleIndex = 5;
            this.colRoadOriginDestination.Width = 94;
            // 
            // colRoadSurfaceType
            // 
            this.colRoadSurfaceType.FieldName = "RoadSurfaceType";
            this.colRoadSurfaceType.MinWidth = 25;
            this.colRoadSurfaceType.Name = "colRoadSurfaceType";
            this.colRoadSurfaceType.Visible = true;
            this.colRoadSurfaceType.VisibleIndex = 6;
            this.colRoadSurfaceType.Width = 94;
            // 
            // colRoadClass
            // 
            this.colRoadClass.FieldName = "RoadClass";
            this.colRoadClass.MinWidth = 25;
            this.colRoadClass.Name = "colRoadClass";
            this.colRoadClass.Visible = true;
            this.colRoadClass.VisibleIndex = 7;
            this.colRoadClass.Width = 94;
            // 
            // colPopulationServed
            // 
            this.colPopulationServed.FieldName = "PopulationServed";
            this.colPopulationServed.MinWidth = 25;
            this.colPopulationServed.Name = "colPopulationServed";
            this.colPopulationServed.Visible = true;
            this.colPopulationServed.VisibleIndex = 8;
            this.colPopulationServed.Width = 94;
            // 
            // colBenefitFactor
            // 
            this.colBenefitFactor.FieldName = "BenefitFactor";
            this.colBenefitFactor.MinWidth = 25;
            this.colBenefitFactor.Name = "colBenefitFactor";
            this.colBenefitFactor.Visible = true;
            this.colBenefitFactor.VisibleIndex = 9;
            this.colBenefitFactor.Width = 94;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 25;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 10;
            this.colTotalCost.Width = 94;
            // 
            // colOverallScore
            // 
            this.colOverallScore.FieldName = "OverallScore";
            this.colOverallScore.MinWidth = 25;
            this.colOverallScore.Name = "colOverallScore";
            this.colOverallScore.Visible = true;
            this.colOverallScore.VisibleIndex = 11;
            this.colOverallScore.Width = 94;
            // 
            // FormForTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 589);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FormForTesting";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormForTesting";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource prioritizedRoadsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminID;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadOriginDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClass;
        private DevExpress.XtraGrid.Columns.GridColumn colPopulationServed;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefitFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colOverallScore;
    }
}