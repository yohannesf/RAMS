namespace RAMSDB_WinForms.PavedRoads
{
    partial class PavedTentativeRoadMaintenancePlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PavedTentativeRoadMaintenancePlan));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pavedTentativeRoadMaintenancePlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTentRMaintPlan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntervention = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatWorkID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtyUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatWorkID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScope = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryofWorkNameGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.categoryofWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWorkCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryofWorkName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatWorkID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblRoadName = new System.Windows.Forms.Label();
            this.lblSurfaceType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavedTentativeRoadMaintenancePlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryofWorkNameGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryofWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1429, 192);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Selected";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 696);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1429, 28);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pavedTentativeRoadMaintenancePlanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 121);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CategoryofWorkNameGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1299, 361);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTentRMaintPlan,
            this.colRoadID,
            this.colYear,
            this.colIntervention,
            this.colCatWorkID,
            this.colQuantity,
            this.colQtyUnit,
            this.colRowCost,
            this.colUnitCost,
            this.colCatWorkID2,
            this.colScope});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "rowCost", this.colRowCost, "#,###.00;[#,###.0];-;")});
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Click here to Add New Workplan";
            this.gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView_InitNewRow);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GridView_RowValidated);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GridView_UnboundColumn);
            // 
            // colTentRMaintPlan
            // 
            this.colTentRMaintPlan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTentRMaintPlan.AppearanceHeader.Options.UseFont = true;
            this.colTentRMaintPlan.AppearanceHeader.Options.UseTextOptions = true;
            this.colTentRMaintPlan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTentRMaintPlan.FieldName = "TentRMaintPlan";
            this.colTentRMaintPlan.MinWidth = 25;
            this.colTentRMaintPlan.Name = "colTentRMaintPlan";
            this.colTentRMaintPlan.Width = 94;
            // 
            // colRoadID
            // 
            this.colRoadID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadID.AppearanceHeader.Options.UseFont = true;
            this.colRoadID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Width = 94;
            // 
            // colYear
            // 
            this.colYear.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colYear.AppearanceHeader.Options.UseFont = true;
            this.colYear.AppearanceHeader.Options.UseTextOptions = true;
            this.colYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 25;
            this.colYear.Name = "colYear";
            this.colYear.Width = 94;
            // 
            // colIntervention
            // 
            this.colIntervention.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colIntervention.AppearanceHeader.Options.UseFont = true;
            this.colIntervention.AppearanceHeader.Options.UseTextOptions = true;
            this.colIntervention.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIntervention.Caption = "Intervention";
            this.colIntervention.FieldName = "Intervention";
            this.colIntervention.MinWidth = 25;
            this.colIntervention.Name = "colIntervention";
            this.colIntervention.Visible = true;
            this.colIntervention.VisibleIndex = 0;
            this.colIntervention.Width = 224;
            // 
            // colCatWorkID
            // 
            this.colCatWorkID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colCatWorkID.AppearanceHeader.Options.UseFont = true;
            this.colCatWorkID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCatWorkID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCatWorkID.Caption = "Activity Name";
            this.colCatWorkID.FieldName = "ActivityName";
            this.colCatWorkID.MinWidth = 25;
            this.colCatWorkID.Name = "colCatWorkID";
            this.colCatWorkID.Visible = true;
            this.colCatWorkID.VisibleIndex = 2;
            this.colCatWorkID.Width = 364;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 90;
            // 
            // colQtyUnit
            // 
            this.colQtyUnit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQtyUnit.AppearanceHeader.Options.UseFont = true;
            this.colQtyUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtyUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQtyUnit.Caption = "Unit";
            this.colQtyUnit.FieldName = "QtyUnit";
            this.colQtyUnit.MinWidth = 25;
            this.colQtyUnit.Name = "colQtyUnit";
            this.colQtyUnit.Visible = true;
            this.colQtyUnit.VisibleIndex = 4;
            this.colQtyUnit.Width = 77;
            // 
            // colRowCost
            // 
            this.colRowCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRowCost.AppearanceHeader.Options.UseFont = true;
            this.colRowCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colRowCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRowCost.Caption = "Total Cost";
            this.colRowCost.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colRowCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRowCost.FieldName = "rowCost";
            this.colRowCost.MinWidth = 25;
            this.colRowCost.Name = "colRowCost";
            this.colRowCost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "rowCost", "SUM={0:c0}")});
            this.colRowCost.UnboundExpression = "[Quantity] * [UnitCost]";
            this.colRowCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRowCost.Visible = true;
            this.colRowCost.VisibleIndex = 6;
            this.colRowCost.Width = 191;
            // 
            // colUnitCost
            // 
            this.colUnitCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colUnitCost.AppearanceHeader.Options.UseFont = true;
            this.colUnitCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitCost.Caption = "Unit Cost";
            this.colUnitCost.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.MinWidth = 25;
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 5;
            this.colUnitCost.Width = 74;
            // 
            // colCatWorkID2
            // 
            this.colCatWorkID2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colCatWorkID2.AppearanceHeader.Options.UseFont = true;
            this.colCatWorkID2.AppearanceHeader.Options.UseTextOptions = true;
            this.colCatWorkID2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCatWorkID2.FieldName = "CatWorkID";
            this.colCatWorkID2.MinWidth = 25;
            this.colCatWorkID2.Name = "colCatWorkID2";
            this.colCatWorkID2.Width = 94;
            // 
            // colScope
            // 
            this.colScope.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colScope.AppearanceHeader.Options.UseFont = true;
            this.colScope.AppearanceHeader.Options.UseTextOptions = true;
            this.colScope.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colScope.Caption = "Scope";
            this.colScope.FieldName = "Scope";
            this.colScope.MinWidth = 25;
            this.colScope.Name = "colScope";
            this.colScope.Visible = true;
            this.colScope.VisibleIndex = 1;
            this.colScope.Width = 113;
            // 
            // CategoryofWorkNameGridLookUpEdit1
            // 
            this.CategoryofWorkNameGridLookUpEdit1.AutoHeight = false;
            this.CategoryofWorkNameGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CategoryofWorkNameGridLookUpEdit1.DataSource = this.categoryofWorkBindingSource;
            this.CategoryofWorkNameGridLookUpEdit1.DisplayMember = "ActivityName";
            this.CategoryofWorkNameGridLookUpEdit1.KeyMember = "ActivityCode;ActivityName";
            this.CategoryofWorkNameGridLookUpEdit1.Name = "CategoryofWorkNameGridLookUpEdit1";
            this.CategoryofWorkNameGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.CategoryofWorkNameGridLookUpEdit1.ValueMember = "CatWorkID";
            // 
            // categoryofWorkBindingSource
            // 
            this.categoryofWorkBindingSource.DataSource = typeof(RAMSDBModel.PavedCategoryofWork);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkCode,
            this.colWorkDescription,
            this.colCategoryofWorkName,
            this.colCatWorkID1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colWorkCode
            // 
            this.colWorkCode.FieldName = "WorkCode";
            this.colWorkCode.Name = "colWorkCode";
            this.colWorkCode.Visible = true;
            this.colWorkCode.VisibleIndex = 0;
            // 
            // colWorkDescription
            // 
            this.colWorkDescription.FieldName = "WorkDescription";
            this.colWorkDescription.Name = "colWorkDescription";
            this.colWorkDescription.Visible = true;
            this.colWorkDescription.VisibleIndex = 1;
            // 
            // colCategoryofWorkName
            // 
            this.colCategoryofWorkName.FieldName = "CategoryofWorkName";
            this.colCategoryofWorkName.Name = "colCategoryofWorkName";
            this.colCategoryofWorkName.Visible = true;
            this.colCategoryofWorkName.VisibleIndex = 2;
            // 
            // colCatWorkID1
            // 
            this.colCatWorkID1.FieldName = "CatWorkID";
            this.colCatWorkID1.Name = "colCatWorkID1";
            // 
            // lblRoadName
            // 
            this.lblRoadName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadName.Location = new System.Drawing.Point(24, 24);
            this.lblRoadName.Name = "lblRoadName";
            this.lblRoadName.Size = new System.Drawing.Size(1275, 48);
            this.lblRoadName.TabIndex = 8;
            this.lblRoadName.Text = "lblRoadName";
            // 
            // lblSurfaceType
            // 
            this.lblSurfaceType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceType.Location = new System.Drawing.Point(461, 88);
            this.lblSurfaceType.Name = "lblSurfaceType";
            this.lblSurfaceType.Size = new System.Drawing.Size(850, 29);
            this.lblSurfaceType.TabIndex = 8;
            this.lblSurfaceType.Text = "lblSurfaceType";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "lblYear";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "7c97697f-5bb0-4130-a43a-e4b3a4e134a2";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("170e7854-56e8-44fa-aafc-acb8afd12ec0", null, null, null, null, null, null, "Save", "Save successful!", "Changes to database sucessfully saved.", null, DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic)});
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lblSurfaceType);
            this.layoutControl1.Controls.Add(this.label2);
            this.layoutControl1.Controls.Add(this.lblRoadName);
            this.layoutControl1.Location = new System.Drawing.Point(33, 198);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(878, 213, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1323, 494);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1323, 494);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(449, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lblSurfaceType;
            this.layoutControlItem3.Location = new System.Drawing.Point(449, 76);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(854, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1303, 365);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsPrint.AllowPrintGroupCaption = false;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1303, 76);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblRoadName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1279, 52);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PavedTentativeRoadMaintenancePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 724);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "PavedTentativeRoadMaintenancePlan";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Tentative Road Maintenance Cost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pavedTentativeRoadMaintenancePlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryofWorkNameGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryofWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTentRMaintPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colCatWorkID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource categoryofWorkBindingSource;
        private System.Windows.Forms.Label lblRoadName;
        private System.Windows.Forms.Label lblSurfaceType;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit CategoryofWorkNameGridLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryofWorkName;
        private DevExpress.XtraGrid.Columns.GridColumn colCatWorkID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRowCost;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colCatWorkID2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource pavedTentativeRoadMaintenancePlanBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colScope;
        private DevExpress.XtraGrid.Columns.GridColumn colIntervention;
        private DevExpress.XtraGrid.Columns.GridColumn colQtyUnit;
    }
}