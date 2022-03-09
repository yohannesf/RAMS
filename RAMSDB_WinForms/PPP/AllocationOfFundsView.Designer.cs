namespace RAMSDB_WinForms.PPP
{
    partial class AllocationOfFundsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllocationOfFundsView));
            this.conditionEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboWoreda = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblRegion = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.roadWorkFundingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkPlanFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFundingSource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterventionCostRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterventionCostPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterventionCostRehabilitation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterventionCostRoadBottlenech = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInterventionCostStructureBottlenech = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editRoadSurfaceType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.adminBoundaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.conditionEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadWorkFundingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRoadSurfaceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBoundaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionEdit
            // 
            this.conditionEdit.AutoHeight = false;
            this.conditionEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.conditionEdit.DisplayMember = "ConditionName";
            this.conditionEdit.KeyMember = "CID";
            this.conditionEdit.Name = "conditionEdit";
            this.conditionEdit.NullText = "";
            this.conditionEdit.ValueMember = "CID";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiSave,
            this.bbiDelete,
            this.bbiRefresh});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1227, 148);
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
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 16;
            this.bbiSave.ImageOptions.ImageUri.Uri = "New";
            this.bbiSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSave.ImageOptions.SvgImage")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1227, 28);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 148);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1227, 561);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cboYear);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.cboWoreda);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblRegion);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1203, 537);
            this.splitContainerControl1.SplitterPosition = 67;
            this.splitContainerControl1.TabIndex = 4;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(833, 15);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(176, 24);
            this.cboYear.TabIndex = 7;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(655, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 41);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Fiscal Year (EC)";
            // 
            // cboWoreda
            // 
            this.cboWoreda.FormattingEnabled = true;
            this.cboWoreda.Location = new System.Drawing.Point(433, 13);
            this.cboWoreda.Name = "cboWoreda";
            this.cboWoreda.Size = new System.Drawing.Size(176, 24);
            this.cboWoreda.TabIndex = 4;
            this.cboWoreda.SelectedIndexChanged += new System.EventHandler(this.cboWoreda_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(322, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 41);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Woreda";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(14, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 41);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Region";
            // 
            // lblRegion
            // 
            this.lblRegion.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.lblRegion.Appearance.Options.UseFont = true;
            this.lblRegion.Appearance.Options.UseForeColor = true;
            this.lblRegion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRegion.Location = new System.Drawing.Point(124, 4);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(170, 41);
            this.lblRegion.TabIndex = 1;
            this.lblRegion.Text = "RegionName";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.roadWorkFundingBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.editRoadSurfaceType,
            this.conditionEdit});
            this.gridControl1.Size = new System.Drawing.Size(1203, 458);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // roadWorkFundingBindingSource
            // 
            this.roadWorkFundingBindingSource.DataSource = typeof(RAMSDBModel.RoadWorkFunding);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colWorkPlanFiscalYear,
            this.colRegion,
            this.colWoreda,
            this.colFundingSource,
            this.colRoadLength,
            this.colInterventionCostRM,
            this.colInterventionCostPM,
            this.colInterventionCostRehabilitation,
            this.colInterventionCostRoadBottlenech,
            this.colInterventionCostStructureBottlenech,
            this.colYearCost});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearCost", this.colYearCost, "#,###.00;[#,###.0];-;")});
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Click here to add a new";
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.GridView_InitNewRow);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.GridView_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colWorkPlanFiscalYear
            // 
            this.colWorkPlanFiscalYear.FieldName = "WorkPlanFiscalYear";
            this.colWorkPlanFiscalYear.MinWidth = 25;
            this.colWorkPlanFiscalYear.Name = "colWorkPlanFiscalYear";
            this.colWorkPlanFiscalYear.Width = 94;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.MinWidth = 25;
            this.colRegion.Name = "colRegion";
            this.colRegion.Width = 94;
            // 
            // colWoreda
            // 
            this.colWoreda.FieldName = "Woreda";
            this.colWoreda.MinWidth = 25;
            this.colWoreda.Name = "colWoreda";
            this.colWoreda.Width = 94;
            // 
            // colFundingSource
            // 
            this.colFundingSource.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colFundingSource.AppearanceHeader.Options.UseFont = true;
            this.colFundingSource.AppearanceHeader.Options.UseTextOptions = true;
            this.colFundingSource.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFundingSource.FieldName = "FundingSource";
            this.colFundingSource.MinWidth = 25;
            this.colFundingSource.Name = "colFundingSource";
            this.colFundingSource.Visible = true;
            this.colFundingSource.VisibleIndex = 0;
            this.colFundingSource.Width = 149;
            // 
            // colRoadLength
            // 
            this.colRoadLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadLength.AppearanceHeader.Options.UseFont = true;
            this.colRoadLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadLength.FieldName = "RoadLength";
            this.colRoadLength.MinWidth = 25;
            this.colRoadLength.Name = "colRoadLength";
            this.colRoadLength.Visible = true;
            this.colRoadLength.VisibleIndex = 1;
            this.colRoadLength.Width = 94;
            // 
            // colInterventionCostRM
            // 
            this.colInterventionCostRM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colInterventionCostRM.AppearanceHeader.Options.UseFont = true;
            this.colInterventionCostRM.AppearanceHeader.Options.UseTextOptions = true;
            this.colInterventionCostRM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInterventionCostRM.Caption = "Cost - Routine Maintenance";
            this.colInterventionCostRM.FieldName = "InterventionCostRM";
            this.colInterventionCostRM.MinWidth = 25;
            this.colInterventionCostRM.Name = "colInterventionCostRM";
            this.colInterventionCostRM.Visible = true;
            this.colInterventionCostRM.VisibleIndex = 2;
            this.colInterventionCostRM.Width = 145;
            // 
            // colInterventionCostPM
            // 
            this.colInterventionCostPM.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colInterventionCostPM.AppearanceHeader.Options.UseFont = true;
            this.colInterventionCostPM.AppearanceHeader.Options.UseTextOptions = true;
            this.colInterventionCostPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInterventionCostPM.Caption = "Cost - Periodic Maintenance";
            this.colInterventionCostPM.FieldName = "InterventionCostPM";
            this.colInterventionCostPM.MinWidth = 25;
            this.colInterventionCostPM.Name = "colInterventionCostPM";
            this.colInterventionCostPM.Visible = true;
            this.colInterventionCostPM.VisibleIndex = 3;
            this.colInterventionCostPM.Width = 141;
            // 
            // colInterventionCostRehabilitation
            // 
            this.colInterventionCostRehabilitation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colInterventionCostRehabilitation.AppearanceHeader.Options.UseFont = true;
            this.colInterventionCostRehabilitation.AppearanceHeader.Options.UseTextOptions = true;
            this.colInterventionCostRehabilitation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInterventionCostRehabilitation.Caption = "Cost - Rehabilitation";
            this.colInterventionCostRehabilitation.FieldName = "InterventionCostRehabilitation";
            this.colInterventionCostRehabilitation.MinWidth = 25;
            this.colInterventionCostRehabilitation.Name = "colInterventionCostRehabilitation";
            this.colInterventionCostRehabilitation.Visible = true;
            this.colInterventionCostRehabilitation.VisibleIndex = 4;
            this.colInterventionCostRehabilitation.Width = 136;
            // 
            // colInterventionCostRoadBottlenech
            // 
            this.colInterventionCostRoadBottlenech.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colInterventionCostRoadBottlenech.AppearanceHeader.Options.UseFont = true;
            this.colInterventionCostRoadBottlenech.AppearanceHeader.Options.UseTextOptions = true;
            this.colInterventionCostRoadBottlenech.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInterventionCostRoadBottlenech.Caption = "Cost - Road Bottleneck";
            this.colInterventionCostRoadBottlenech.FieldName = "InterventionCostRoadBottleneck";
            this.colInterventionCostRoadBottlenech.MinWidth = 25;
            this.colInterventionCostRoadBottlenech.Name = "colInterventionCostRoadBottlenech";
            this.colInterventionCostRoadBottlenech.Visible = true;
            this.colInterventionCostRoadBottlenech.VisibleIndex = 5;
            this.colInterventionCostRoadBottlenech.Width = 146;
            // 
            // colInterventionCostStructureBottlenech
            // 
            this.colInterventionCostStructureBottlenech.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colInterventionCostStructureBottlenech.AppearanceHeader.Options.UseFont = true;
            this.colInterventionCostStructureBottlenech.AppearanceHeader.Options.UseTextOptions = true;
            this.colInterventionCostStructureBottlenech.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInterventionCostStructureBottlenech.Caption = "Cost - Structure Bottleneck";
            this.colInterventionCostStructureBottlenech.FieldName = "InterventionCostStructureBottleneck";
            this.colInterventionCostStructureBottlenech.MinWidth = 25;
            this.colInterventionCostStructureBottlenech.Name = "colInterventionCostStructureBottlenech";
            this.colInterventionCostStructureBottlenech.Visible = true;
            this.colInterventionCostStructureBottlenech.VisibleIndex = 6;
            this.colInterventionCostStructureBottlenech.Width = 151;
            // 
            // colYearCost
            // 
            this.colYearCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colYearCost.AppearanceHeader.Options.UseFont = true;
            this.colYearCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colYearCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYearCost.Caption = "Year Cost (birr)";
            this.colYearCost.FieldName = "YearCost";
            this.colYearCost.MinWidth = 25;
            this.colYearCost.Name = "colYearCost";
            this.colYearCost.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "YearCost", "SUM={0:c0}")});
            this.colYearCost.Visible = true;
            this.colYearCost.VisibleIndex = 7;
            this.colYearCost.Width = 123;
            // 
            // editRoadSurfaceType
            // 
            this.editRoadSurfaceType.AutoHeight = false;
            this.editRoadSurfaceType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editRoadSurfaceType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SurfaceTypeName", "Surface Type Name", 136, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.editRoadSurfaceType.DisplayMember = "SurfaceTypeName";
            this.editRoadSurfaceType.KeyMember = "SurfaceTypeID;SurfaceTypeName";
            this.editRoadSurfaceType.Name = "editRoadSurfaceType";
            this.editRoadSurfaceType.ValueMember = "SurfaceTypeID";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1227, 561);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.splitContainerControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1207, 541);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // adminBoundaryBindingSource
            // 
            this.adminBoundaryBindingSource.DataSource = typeof(RAMSDBModel.AdminBoundary);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.FieldName = "InterventionCostRehabilitation";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 172;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.FieldName = "InterventionCostRehabilitation";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 172;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.FieldName = "InterventionCostRehabilitation";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 172;
            // 
            // AllocationOfFundsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllocationOfFundsView";
            this.Size = new System.Drawing.Size(1227, 737);
            ((System.ComponentModel.ISupportInitialize)(this.conditionEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadWorkFundingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRoadSurfaceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBoundaryBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblRegion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit editRoadSurfaceType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit conditionEdit;
        private System.Windows.Forms.BindingSource roadWorkFundingBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkPlanFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colFundingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadLength;
        private DevExpress.XtraGrid.Columns.GridColumn colInterventionCostRM;
        private DevExpress.XtraGrid.Columns.GridColumn colInterventionCostPM;
        private DevExpress.XtraGrid.Columns.GridColumn colInterventionCostRehabilitation;
        private DevExpress.XtraGrid.Columns.GridColumn colInterventionCostRoadBottlenech;
        private DevExpress.XtraGrid.Columns.GridColumn colInterventionCostStructureBottlenech;
        private DevExpress.XtraGrid.Columns.GridColumn colYearCost;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboWoreda;
        private System.Windows.Forms.BindingSource adminBoundaryBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cboYear;
    }
}
