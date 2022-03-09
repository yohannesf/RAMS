namespace RAMSDB_WinForms
{
    partial class RoadsAssigned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoadsAssigned));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiConditionSurvey = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTrafficSurvey = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiViewMap = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMultiCriteria = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.roadsPerUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoadIDMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsPerUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
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
            this.bbiConditionSurvey,
            this.bbiTrafficSurvey,
            this.bbiRefresh,
            this.bbiViewMap,
            this.bbiMultiCriteria,
            this.bbiExport});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 23;
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
            // bbiConditionSurvey
            // 
            this.bbiConditionSurvey.Caption = "Add/Edit Condition Survey";
            this.bbiConditionSurvey.Id = 16;
            this.bbiConditionSurvey.ImageOptions.ImageUri.Uri = "New";
            this.bbiConditionSurvey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiConditionSurvey.ImageOptions.SvgImage")));
            this.bbiConditionSurvey.Name = "bbiConditionSurvey";
            this.bbiConditionSurvey.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConditionSurvey_ItemClick);
            // 
            // bbiTrafficSurvey
            // 
            this.bbiTrafficSurvey.Caption = "Add/Edit Traffic Survey Data";
            this.bbiTrafficSurvey.Id = 17;
            this.bbiTrafficSurvey.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiTrafficSurvey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTrafficSurvey.ImageOptions.SvgImage")));
            this.bbiTrafficSurvey.Name = "bbiTrafficSurvey";
            this.bbiTrafficSurvey.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTrafficSurvey_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiViewMap
            // 
            this.bbiViewMap.Caption = "View in Map";
            this.bbiViewMap.Id = 20;
            this.bbiViewMap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiViewMap.ImageOptions.SvgImage")));
            this.bbiViewMap.Name = "bbiViewMap";
            this.bbiViewMap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiViewMap_ItemClick);
            // 
            // bbiMultiCriteria
            // 
            this.bbiMultiCriteria.Caption = "Add/Edit Multicriteria Data";
            this.bbiMultiCriteria.Id = 21;
            this.bbiMultiCriteria.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiMultiCriteria.ImageOptions.SvgImage")));
            this.bbiMultiCriteria.Name = "bbiMultiCriteria";
            this.bbiMultiCriteria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMultiCriteria_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Hint = "Export data to Excel";
            this.bbiExport.Id = 22;
            this.bbiExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExport.ImageOptions.Image")));
            this.bbiExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExport.ImageOptions.LargeImage")));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiConditionSurvey);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMultiCriteria);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTrafficSurvey);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiViewMap);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Visualization";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExport);
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
            // roadsPerUserBindingSource
            // 
            this.roadsPerUserBindingSource.DataSource = typeof(RAMSDBModel.RoadsPerUser);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoadIDMain,
            this.UserID,
            this.colZone,
            this.colWoreda,
            this.colRoadID,
            this.colRoadClass,
            this.colSurfaceType,
            this.colRoadLength});
            gridFormatRule1.Name = "FormatConditionValues";
            formatConditionIconSet1.CategoryName = "Shapes";
            formatConditionIconSetIcon1.PredefinedName = "TrafficLights4_1.png";
            formatConditionIconSetIcon1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "TrafficLights4_2.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "TrafficLights4_3.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon4.PredefinedName = "TrafficLights4_4.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet1.Name = "TrafficLights4";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colZone, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView_DoubleClick);
            // 
            // colRoadIDMain
            // 
            this.colRoadIDMain.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadIDMain.AppearanceHeader.Options.UseFont = true;
            this.colRoadIDMain.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadIDMain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadIDMain.Caption = "colRoadIDMain";
            this.colRoadIDMain.FieldName = "RoadID";
            this.colRoadIDMain.MinWidth = 25;
            this.colRoadIDMain.Name = "colRoadIDMain";
            this.colRoadIDMain.Width = 94;
            // 
            // UserID
            // 
            this.UserID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.UserID.AppearanceHeader.Options.UseFont = true;
            this.UserID.AppearanceHeader.Options.UseTextOptions = true;
            this.UserID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UserID.Caption = "User ID";
            this.UserID.FieldName = "UserID";
            this.UserID.MinWidth = 25;
            this.UserID.Name = "UserID";
            this.UserID.Width = 94;
            // 
            // colZone
            // 
            this.colZone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colZone.AppearanceHeader.Options.UseFont = true;
            this.colZone.AppearanceHeader.Options.UseTextOptions = true;
            this.colZone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colZone.Caption = "Zone";
            this.colZone.FieldName = "AdminBoundary.ZoneName";
            this.colZone.MinWidth = 25;
            this.colZone.Name = "colZone";
            this.colZone.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colZone.Visible = true;
            this.colZone.VisibleIndex = 0;
            this.colZone.Width = 133;
            // 
            // colWoreda
            // 
            this.colWoreda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colWoreda.AppearanceHeader.Options.UseFont = true;
            this.colWoreda.AppearanceHeader.Options.UseTextOptions = true;
            this.colWoreda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWoreda.Caption = "Woreda";
            this.colWoreda.FieldName = "AdminBoundary.WoredaName";
            this.colWoreda.MinWidth = 25;
            this.colWoreda.Name = "colWoreda";
            this.colWoreda.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colWoreda.Visible = true;
            this.colWoreda.VisibleIndex = 0;
            this.colWoreda.Width = 171;
            // 
            // colRoadID
            // 
            this.colRoadID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadID.AppearanceHeader.Options.UseFont = true;
            this.colRoadID.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadID.Caption = "Road : Origin Destination";
            this.colRoadID.FieldName = "RoadsGISData.RoadOriginDestination";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Visible = true;
            this.colRoadID.VisibleIndex = 1;
            this.colRoadID.Width = 249;
            // 
            // colRoadClass
            // 
            this.colRoadClass.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadClass.AppearanceHeader.Options.UseFont = true;
            this.colRoadClass.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadClass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadClass.Caption = "Classification";
            this.colRoadClass.FieldName = "RoadsGISData.RoadClassification.RoadClassificationDescription";
            this.colRoadClass.MinWidth = 25;
            this.colRoadClass.Name = "colRoadClass";
            this.colRoadClass.Visible = true;
            this.colRoadClass.VisibleIndex = 3;
            this.colRoadClass.Width = 192;
            // 
            // colSurfaceType
            // 
            this.colSurfaceType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colSurfaceType.AppearanceHeader.Options.UseFont = true;
            this.colSurfaceType.AppearanceHeader.Options.UseTextOptions = true;
            this.colSurfaceType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSurfaceType.Caption = "Road Surface Type";
            this.colSurfaceType.FieldName = "RoadsGISData.RoadSurfaceType.SurfaceTypeName";
            this.colSurfaceType.MinWidth = 25;
            this.colSurfaceType.Name = "colSurfaceType";
            this.colSurfaceType.Visible = true;
            this.colSurfaceType.VisibleIndex = 2;
            this.colSurfaceType.Width = 123;
            // 
            // colRoadLength
            // 
            this.colRoadLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadLength.AppearanceHeader.Options.UseFont = true;
            this.colRoadLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadLength.Caption = "Road Length (Km)";
            this.colRoadLength.DisplayFormat.FormatString = "#,###.#;[#,###.#];-;";
            this.colRoadLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRoadLength.FieldName = "RoadsGISData.RoadLengthInKm";
            this.colRoadLength.MinWidth = 25;
            this.colRoadLength.Name = "colRoadLength";
            this.colRoadLength.Visible = true;
            this.colRoadLength.VisibleIndex = 4;
            this.colRoadLength.Width = 92;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.roadsPerUserBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 148);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(933, 562);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add/Edit Condition Survey";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "New";
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Add/Edit Condition Survey";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "New";
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Add/Edit Condition Survey";
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.ImageOptions.ImageUri.Uri = "New";
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // RoadsAssigned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoadsAssigned";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsPerUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiConditionSurvey;
        private DevExpress.XtraBars.BarButtonItem bbiTrafficSurvey;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.BindingSource roadsPerUserBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadIDMain;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadClass;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadLength;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarButtonItem bbiViewMap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiMultiCriteria;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}
