namespace RAMSDB_WinForms
{
    partial class frmUnpavedAnnualPlanReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnpavedAnnualPlanReport));
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal1 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.unpavedTentativeRoadMaintenancePlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldTentRMaintPlan1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRCSID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRoadID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCatWorkID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLength1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnpavedRoadConditionSurvey1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnpavedCategoryofWorkWorkDescription = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRoadsGISData1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lblNumRoads = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblWoreda = new DevExpress.XtraEditors.LabelControl();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblRegion = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedTentativeRoadMaintenancePlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bbiExport});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHome});
            this.ribbon.Size = new System.Drawing.Size(1556, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export or Print";
            this.bbiExport.Id = 1;
            this.bbiExport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiExport.ImageOptions.SvgImage")));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // rpHome
            // 
            this.rpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpHome.MergeOrder = 0;
            this.rpHome.Name = "rpHome";
            this.rpHome.Text = "Home";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiExport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Export and Print";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 741);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1556, 28);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pivotGridControl1.Appearance.GrandTotalCell.Options.UseFont = true;
            this.pivotGridControl1.DataSource = this.unpavedTentativeRoadMaintenancePlanBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldTentRMaintPlan1,
            this.fieldRCSID1,
            this.fieldRoadID1,
            this.fieldYear1,
            this.fieldCatWorkID1,
            this.fieldLength1,
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName,
            this.fieldUnpavedRoadConditionSurvey1,
            this.fieldUnpavedCategoryofWorkWorkDescription,
            this.pivotGridField1,
            this.pivotGridField2});
            this.pivotGridControl1.Location = new System.Drawing.Point(20, 0);
            this.pivotGridControl1.MenuManager = this.ribbon;
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1516, 472);
            this.pivotGridControl1.TabIndex = 2;
            this.pivotGridControl1.Click += new System.EventHandler(this.pivotGridControl1_Click);
            // 
            // unpavedTentativeRoadMaintenancePlanBindingSource
            // 
            this.unpavedTentativeRoadMaintenancePlanBindingSource.DataSource = typeof(RAMSDBModel.UnpavedTentativeRoadMaintenancePlan);
            // 
            // fieldTentRMaintPlan1
            // 
            this.fieldTentRMaintPlan1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldTentRMaintPlan1.Appearance.Header.Options.UseFont = true;
            this.fieldTentRMaintPlan1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldTentRMaintPlan1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldTentRMaintPlan1.AreaIndex = 0;
            this.fieldTentRMaintPlan1.Caption = "Tent RMaint Plan";
            this.fieldTentRMaintPlan1.FieldName = "TentRMaintPlan";
            this.fieldTentRMaintPlan1.Name = "fieldTentRMaintPlan1";
            // 
            // fieldRCSID1
            // 
            this.fieldRCSID1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldRCSID1.Appearance.Header.Options.UseFont = true;
            this.fieldRCSID1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldRCSID1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldRCSID1.AreaIndex = 1;
            this.fieldRCSID1.Caption = "RCSID";
            this.fieldRCSID1.FieldName = "RCSID";
            this.fieldRCSID1.Name = "fieldRCSID1";
            // 
            // fieldRoadID1
            // 
            this.fieldRoadID1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldRoadID1.Appearance.Header.Options.UseFont = true;
            this.fieldRoadID1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldRoadID1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldRoadID1.AreaIndex = 2;
            this.fieldRoadID1.Caption = "Road ID";
            this.fieldRoadID1.FieldName = "RoadID";
            this.fieldRoadID1.Name = "fieldRoadID1";
            // 
            // fieldYear1
            // 
            this.fieldYear1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldYear1.Appearance.Header.Options.UseFont = true;
            this.fieldYear1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldYear1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldYear1.AreaIndex = 3;
            this.fieldYear1.Caption = "Year";
            this.fieldYear1.FieldName = "Year";
            this.fieldYear1.Name = "fieldYear1";
            // 
            // fieldCatWorkID1
            // 
            this.fieldCatWorkID1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldCatWorkID1.Appearance.Header.Options.UseFont = true;
            this.fieldCatWorkID1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldCatWorkID1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldCatWorkID1.AreaIndex = 4;
            this.fieldCatWorkID1.Caption = "Cat Work ID";
            this.fieldCatWorkID1.FieldName = "CatWorkID";
            this.fieldCatWorkID1.Name = "fieldCatWorkID1";
            this.fieldCatWorkID1.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.ID;
            // 
            // fieldLength1
            // 
            this.fieldLength1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldLength1.Appearance.Header.Options.UseFont = true;
            this.fieldLength1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldLength1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldLength1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldLength1.AreaIndex = 0;
            this.fieldLength1.Caption = "Length";
            this.fieldLength1.CellFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.fieldLength1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.fieldLength1.FieldName = "Length";
            this.fieldLength1.GrandTotalText = "Total KM of planned roads";
            this.fieldLength1.Name = "fieldLength1";
            this.fieldLength1.Width = 140;
            // 
            // fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName
            // 
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Appearance.Header.Options.UseFont = true;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Appearance.Header.Options.UseTextOptions = true;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.AreaIndex = 1;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Caption = "Surface Type";
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.ExpandedInFieldsGroup = false;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.FieldName = "RoadsGISData.RoadSurfaceType.SurfaceTypeName";
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Name = "fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName";
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName.Width = 140;
            // 
            // fieldUnpavedRoadConditionSurvey1
            // 
            this.fieldUnpavedRoadConditionSurvey1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldUnpavedRoadConditionSurvey1.Appearance.Header.Options.UseFont = true;
            this.fieldUnpavedRoadConditionSurvey1.Appearance.Header.Options.UseTextOptions = true;
            this.fieldUnpavedRoadConditionSurvey1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldUnpavedRoadConditionSurvey1.AreaIndex = 5;
            this.fieldUnpavedRoadConditionSurvey1.Caption = "UnpavedRoadConditionSurvey";
            this.fieldUnpavedRoadConditionSurvey1.FieldName = "UnpavedRoadConditionSurvey";
            this.fieldUnpavedRoadConditionSurvey1.Name = "fieldUnpavedRoadConditionSurvey1";
            // 
            // fieldUnpavedCategoryofWorkWorkDescription
            // 
            this.fieldUnpavedCategoryofWorkWorkDescription.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.fieldUnpavedCategoryofWorkWorkDescription.Appearance.Header.Options.UseFont = true;
            this.fieldUnpavedCategoryofWorkWorkDescription.Appearance.Header.Options.UseTextOptions = true;
            this.fieldUnpavedCategoryofWorkWorkDescription.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldUnpavedCategoryofWorkWorkDescription.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldUnpavedCategoryofWorkWorkDescription.AreaIndex = 0;
            this.fieldUnpavedCategoryofWorkWorkDescription.Caption = "Planned Intervention Descriptions and Activities";
            this.fieldUnpavedCategoryofWorkWorkDescription.FieldName = "UnpavedCategoryofWork.WorkDescription";
            this.fieldUnpavedCategoryofWorkWorkDescription.GrandTotalText = "Total for Road";
            this.fieldUnpavedCategoryofWorkWorkDescription.Name = "fieldUnpavedCategoryofWorkWorkDescription";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.pivotGridField1.Appearance.Header.Options.UseFont = true;
            this.pivotGridField1.Appearance.Header.Options.UseTextOptions = true;
            this.pivotGridField1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.ExpandedInFieldsGroup = false;
            this.pivotGridField1.FieldName = "RoadsGISData.RoadOriginDestination";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.AllowEdit = false;
            this.pivotGridField1.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridField1.Width = 354;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.pivotGridField2.Appearance.Header.Options.UseFont = true;
            this.pivotGridField2.Appearance.Header.Options.UseTextOptions = true;
            this.pivotGridField2.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField2.AreaIndex = 2;
            this.pivotGridField2.Caption = "Total Length of Road";
            this.pivotGridField2.CellFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField2.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal1});
            this.pivotGridField2.ExpandedInFieldsGroup = false;
            this.pivotGridField2.FieldName = "RoadsGISData.RoadLengthInKm";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 140;
            // 
            // fieldRoadsGISData1
            // 
            this.fieldRoadsGISData1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRoadsGISData1.AreaIndex = 1;
            this.fieldRoadsGISData1.Caption = "Roads GIS Data";
            this.fieldRoadsGISData1.FieldName = "RoadsGISData";
            this.fieldRoadsGISData1.Name = "fieldRoadsGISData1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 178);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lblNumRoads);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblWoreda);
            this.splitContainerControl1.Panel1.Controls.Add(this.cboYear);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblRegion);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.pivotGridControl1);
            this.splitContainerControl1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1556, 563);
            this.splitContainerControl1.SplitterPosition = 79;
            this.splitContainerControl1.TabIndex = 5;
            // 
            // lblNumRoads
            // 
            this.lblNumRoads.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRoads.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblNumRoads.Appearance.Options.UseFont = true;
            this.lblNumRoads.Appearance.Options.UseForeColor = true;
            this.lblNumRoads.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNumRoads.Location = new System.Drawing.Point(721, 15);
            this.lblNumRoads.Name = "lblNumRoads";
            this.lblNumRoads.Size = new System.Drawing.Size(170, 41);
            this.lblNumRoads.TabIndex = 14;
            this.lblNumRoads.Text = "numRoads";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(589, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 41);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "# of Roads";
            // 
            // lblWoreda
            // 
            this.lblWoreda.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWoreda.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblWoreda.Appearance.Options.UseFont = true;
            this.lblWoreda.Appearance.Options.UseForeColor = true;
            this.lblWoreda.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWoreda.Location = new System.Drawing.Point(413, 15);
            this.lblWoreda.Name = "lblWoreda";
            this.lblWoreda.Size = new System.Drawing.Size(170, 41);
            this.lblWoreda.TabIndex = 9;
            this.lblWoreda.Text = "WoredaName";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(1106, 26);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(176, 24);
            this.cboYear.TabIndex = 13;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(1003, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(142, 41);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Year (EC)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(320, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 41);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Woreda";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 41);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Region";
            // 
            // lblRegion
            // 
            this.lblRegion.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblRegion.Appearance.Options.UseFont = true;
            this.lblRegion.Appearance.Options.UseForeColor = true;
            this.lblRegion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRegion.Location = new System.Drawing.Point(122, 15);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(170, 41);
            this.lblRegion.TabIndex = 8;
            this.lblRegion.Text = "RegionName";
            // 
            // frmUnpavedAnnualPlanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmUnpavedAnnualPlanReport";
            this.Size = new System.Drawing.Size(1556, 769);
            this.Load += new System.EventHandler(this.frmUnpavedAnnualPlanReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedTentativeRoadMaintenancePlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource unpavedTentativeRoadMaintenancePlanBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTentRMaintPlan1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRCSID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRoadID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCatWorkID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLength1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRoadsGISDataRoadSurfaceTypeSurfaceTypeName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnpavedRoadConditionSurvey1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnpavedCategoryofWorkWorkDescription;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRoadsGISData1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ComboBox cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblRegion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.LabelControl lblWoreda;
        private DevExpress.XtraEditors.LabelControl lblNumRoads;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}