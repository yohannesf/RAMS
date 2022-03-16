namespace RAMSDB_WinForms
{
    partial class UnpavedPrioritizedRoads
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.prioritizedRoadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZoe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Woreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadOriginDestination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadClassification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPopulationServed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenefitFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOverallScore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTentative = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::RAMSDB_WinForms.WaitForm1), true, true, typeof(System.Windows.Forms.UserControl));
            this.colMaintenanceBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(933, 148);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 710);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(933, 28);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.prioritizedRoadsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(933, 562);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // prioritizedRoadsBindingSource
            // 
            this.prioritizedRoadsBindingSource.DataSource = typeof(RAMSDB.Data.PrioritizedRoads);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYear,
            this.colRoadID,
            this.colAdminID,
            this.colZoe,
            this.colMaintenanceBranch,
            this.Woreda,
            this.colRoadOriginDestination,
            this.colRoadSurfaceType,
            this.colRoadClassification,
            this.colPopulationServed,
            this.colBenefitFactor,
            this.colTotalCost,
            this.colOverallScore,
            this.colPTentative});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
            this.gridView1.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard;
            this.gridView1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOverallScore, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GridView_ValidateRow);
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GridView_UnboundColumns);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colYear
            // 
            this.colYear.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colYear.AppearanceHeader.Options.UseFont = true;
            this.colYear.AppearanceHeader.Options.UseTextOptions = true;
            this.colYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 25;
            this.colYear.Name = "colYear";
            this.colYear.Width = 120;
            // 
            // colRoadID
            // 
            this.colRoadID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadID.AppearanceHeader.Options.UseFont = true;
            this.colRoadID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadID.Caption = "RoadID";
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Width = 94;
            // 
            // colAdminID
            // 
            this.colAdminID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colAdminID.AppearanceHeader.Options.UseFont = true;
            this.colAdminID.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdminID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdminID.Caption = "AdminID";
            this.colAdminID.FieldName = "AdminID";
            this.colAdminID.MinWidth = 25;
            this.colAdminID.Name = "colAdminID";
            this.colAdminID.Width = 94;
            // 
            // colZoe
            // 
            this.colZoe.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colZoe.AppearanceHeader.Options.UseFont = true;
            this.colZoe.AppearanceHeader.Options.UseTextOptions = true;
            this.colZoe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colZoe.Caption = "Zone";
            this.colZoe.FieldName = "Zone";
            this.colZoe.MinWidth = 25;
            this.colZoe.Name = "colZoe";
            this.colZoe.Width = 94;
            // 
            // Woreda
            // 
            this.Woreda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Woreda.AppearanceHeader.Options.UseFont = true;
            this.Woreda.AppearanceHeader.Options.UseTextOptions = true;
            this.Woreda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Woreda.Caption = "Woreda";
            this.Woreda.FieldName = "Woreda";
            this.Woreda.MinWidth = 25;
            this.Woreda.Name = "Woreda";
            this.Woreda.Visible = true;
            this.Woreda.VisibleIndex = 1;
            this.Woreda.Width = 94;
            // 
            // colRoadOriginDestination
            // 
            this.colRoadOriginDestination.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadOriginDestination.AppearanceHeader.Options.UseFont = true;
            this.colRoadOriginDestination.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadOriginDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadOriginDestination.Caption = "Road Origin - Destination";
            this.colRoadOriginDestination.FieldName = "RoadOriginDestination";
            this.colRoadOriginDestination.MinWidth = 25;
            this.colRoadOriginDestination.Name = "colRoadOriginDestination";
            this.colRoadOriginDestination.Visible = true;
            this.colRoadOriginDestination.VisibleIndex = 2;
            this.colRoadOriginDestination.Width = 295;
            // 
            // colRoadSurfaceType
            // 
            this.colRoadSurfaceType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadSurfaceType.AppearanceHeader.Options.UseFont = true;
            this.colRoadSurfaceType.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadSurfaceType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadSurfaceType.Caption = "Road Surface Type";
            this.colRoadSurfaceType.FieldName = "RoadSurfaceType";
            this.colRoadSurfaceType.MinWidth = 25;
            this.colRoadSurfaceType.Name = "colRoadSurfaceType";
            this.colRoadSurfaceType.Visible = true;
            this.colRoadSurfaceType.VisibleIndex = 3;
            this.colRoadSurfaceType.Width = 134;
            // 
            // colRoadClassification
            // 
            this.colRoadClassification.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadClassification.AppearanceHeader.Options.UseFont = true;
            this.colRoadClassification.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadClassification.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadClassification.Caption = "Road Classification";
            this.colRoadClassification.FieldName = "RoadClass";
            this.colRoadClassification.MinWidth = 25;
            this.colRoadClassification.Name = "colRoadClassification";
            this.colRoadClassification.Visible = true;
            this.colRoadClassification.VisibleIndex = 4;
            this.colRoadClassification.Width = 140;
            // 
            // colPopulationServed
            // 
            this.colPopulationServed.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colPopulationServed.AppearanceHeader.Options.UseFont = true;
            this.colPopulationServed.AppearanceHeader.Options.UseTextOptions = true;
            this.colPopulationServed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPopulationServed.Caption = "Population Served";
            this.colPopulationServed.DisplayFormat.FormatString = "#,###;[#,###];-;";
            this.colPopulationServed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPopulationServed.FieldName = "PopulationServed";
            this.colPopulationServed.MinWidth = 25;
            this.colPopulationServed.Name = "colPopulationServed";
            this.colPopulationServed.Visible = true;
            this.colPopulationServed.VisibleIndex = 5;
            this.colPopulationServed.Width = 94;
            // 
            // colBenefitFactor
            // 
            this.colBenefitFactor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colBenefitFactor.AppearanceHeader.Options.UseFont = true;
            this.colBenefitFactor.AppearanceHeader.Options.UseTextOptions = true;
            this.colBenefitFactor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBenefitFactor.Caption = "Benefit Factor";
            this.colBenefitFactor.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colBenefitFactor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBenefitFactor.FieldName = "BenefitFactor";
            this.colBenefitFactor.MinWidth = 25;
            this.colBenefitFactor.Name = "colBenefitFactor";
            this.colBenefitFactor.Visible = true;
            this.colBenefitFactor.VisibleIndex = 6;
            this.colBenefitFactor.Width = 130;
            // 
            // colTotalCost
            // 
            this.colTotalCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceHeader.Options.UseFont = true;
            this.colTotalCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.Caption = "Total Cost";
            this.colTotalCost.DisplayFormat.FormatString = "#,###;[#,###];-;";
            this.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 25;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 7;
            this.colTotalCost.Width = 94;
            // 
            // colOverallScore
            // 
            this.colOverallScore.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colOverallScore.AppearanceHeader.Options.UseFont = true;
            this.colOverallScore.AppearanceHeader.Options.UseTextOptions = true;
            this.colOverallScore.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOverallScore.Caption = "Overall Score";
            this.colOverallScore.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colOverallScore.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOverallScore.FieldName = "OverallScore";
            this.colOverallScore.MinWidth = 25;
            this.colOverallScore.Name = "colOverallScore";
            this.colOverallScore.Visible = true;
            this.colOverallScore.VisibleIndex = 8;
            this.colOverallScore.Width = 94;
            // 
            // colPTentative
            // 
            this.colPTentative.Caption = "Set as priority";
            this.colPTentative.FieldName = "PTentative";
            this.colPTentative.MinWidth = 25;
            this.colPTentative.Name = "colPTentative";
            this.colPTentative.ToolTip = "Tentative : Final prioritization will be done through Regional Administration";
            this.colPTentative.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colPTentative.Visible = true;
            this.colPTentative.VisibleIndex = 9;
            this.colPTentative.Width = 94;
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 18;
            this.cboYear.Location = new System.Drawing.Point(463, 7);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(176, 26);
            this.cboYear.TabIndex = 19;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(372, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 35);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Year (EC)";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 148);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.cboYear);
            this.gridSplitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(933, 562);
            this.gridSplitContainer1.TabIndex = 22;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // colMaintenanceBranch
            // 
            this.colMaintenanceBranch.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMaintenanceBranch.AppearanceHeader.Options.UseFont = true;
            this.colMaintenanceBranch.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaintenanceBranch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaintenanceBranch.FieldName = "MaintenanceBranch";
            this.colMaintenanceBranch.MinWidth = 25;
            this.colMaintenanceBranch.Name = "colMaintenanceBranch";
            this.colMaintenanceBranch.Visible = true;
            this.colMaintenanceBranch.VisibleIndex = 0;
            this.colMaintenanceBranch.Width = 120;
            // 
            // UnpavedPrioritizedRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UnpavedPrioritizedRoads";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colZoe;
        private DevExpress.XtraGrid.Columns.GridColumn Woreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadOriginDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colBenefitFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colPopulationServed;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colOverallScore;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClassification;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colPTentative;
        private System.Windows.Forms.BindingSource prioritizedRoadsBindingSource;
        private System.Windows.Forms.ComboBox cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaintenanceBranch;
    }
}
