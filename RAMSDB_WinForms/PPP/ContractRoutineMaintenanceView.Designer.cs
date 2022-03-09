namespace RAMSDB_WinForms.PPP
{
    partial class ContractRoutineMaintenanceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractRoutineMaintenanceView));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiProgress = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cboWoreda = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblRegion = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contractRoutineMaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeOfWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboTypeofWork = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractingEngEstimate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateContractAwarded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnnualWorkDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRatePerWorkDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkedCboTypeofWork = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.adminBoundaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editRoadSurfaceType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractRoutineMaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeofWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedCboTypeofWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBoundaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRoadSurfaceType)).BeginInit();
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
            this.bbiSave,
            this.bbiDelete,
            this.bbiRefresh,
            this.bbiProgress});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1407, 148);
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
            // bbiProgress
            // 
            this.bbiProgress.Caption = "Add / View Progress Details";
            this.bbiProgress.Id = 20;
            this.bbiProgress.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiProgress.ImageOptions.SvgImage")));
            this.bbiProgress.Name = "bbiProgress";
            this.bbiProgress.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiProgress_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiProgress);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Progress";
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 708);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1407, 28);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 148);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1407, 560);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 12);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cboWoreda);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblRegion);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1383, 536);
            this.splitContainerControl1.SplitterPosition = 67;
            this.splitContainerControl1.TabIndex = 4;
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
            this.gridControl1.DataSource = this.contractRoutineMaintenanceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboTypeofWork,
            this.checkedCboTypeofWork,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1383, 457);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contractRoutineMaintenanceBindingSource
            // 
            this.contractRoutineMaintenanceBindingSource.DataSource = typeof(RAMSDBModel.ContractRoutineMaintenance);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colRegion,
            this.colWoreda,
            this.colTypeOfWork,
            this.colContractNo,
            this.colRoadSection,
            this.colSectionLength,
            this.colContractorName,
            this.colContractingEngEstimate,
            this.colDateContractAwarded,
            this.colContractPrice,
            this.colAnnualWorkDays,
            this.colRatePerWorkDays,
            this.colStartDate,
            this.colEndDate});
            this.gridView1.GridControl = this.gridControl1;
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
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView_RowDoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
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
            // colTypeOfWork
            // 
            this.colTypeOfWork.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTypeOfWork.AppearanceHeader.Options.UseFont = true;
            this.colTypeOfWork.AppearanceHeader.Options.UseTextOptions = true;
            this.colTypeOfWork.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTypeOfWork.ColumnEdit = this.cboTypeofWork;
            this.colTypeOfWork.FieldName = "TypeOfWork";
            this.colTypeOfWork.MinWidth = 25;
            this.colTypeOfWork.Name = "colTypeOfWork";
            this.colTypeOfWork.Visible = true;
            this.colTypeOfWork.VisibleIndex = 0;
            this.colTypeOfWork.Width = 112;
            // 
            // cboTypeofWork
            // 
            this.cboTypeofWork.AutoHeight = false;
            this.cboTypeofWork.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTypeofWork.Items.AddRange(new object[] {
            "Routine Maintenance"});
            this.cboTypeofWork.Name = "cboTypeofWork";
            // 
            // colContractNo
            // 
            this.colContractNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colContractNo.AppearanceHeader.Options.UseFont = true;
            this.colContractNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colContractNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractNo.FieldName = "ContractNo";
            this.colContractNo.MinWidth = 25;
            this.colContractNo.Name = "colContractNo";
            this.colContractNo.Visible = true;
            this.colContractNo.VisibleIndex = 1;
            this.colContractNo.Width = 151;
            // 
            // colRoadSection
            // 
            this.colRoadSection.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadSection.AppearanceHeader.Options.UseFont = true;
            this.colRoadSection.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadSection.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadSection.FieldName = "RoadSection";
            this.colRoadSection.MinWidth = 25;
            this.colRoadSection.Name = "colRoadSection";
            this.colRoadSection.Visible = true;
            this.colRoadSection.VisibleIndex = 2;
            this.colRoadSection.Width = 122;
            // 
            // colSectionLength
            // 
            this.colSectionLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colSectionLength.AppearanceHeader.Options.UseFont = true;
            this.colSectionLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colSectionLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSectionLength.Caption = "Section Length";
            this.colSectionLength.FieldName = "SectionLength";
            this.colSectionLength.MinWidth = 25;
            this.colSectionLength.Name = "colSectionLength";
            this.colSectionLength.Visible = true;
            this.colSectionLength.VisibleIndex = 3;
            this.colSectionLength.Width = 120;
            // 
            // colContractorName
            // 
            this.colContractorName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colContractorName.AppearanceHeader.Options.UseFont = true;
            this.colContractorName.AppearanceHeader.Options.UseTextOptions = true;
            this.colContractorName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractorName.FieldName = "ContractorName";
            this.colContractorName.MinWidth = 25;
            this.colContractorName.Name = "colContractorName";
            this.colContractorName.Visible = true;
            this.colContractorName.VisibleIndex = 4;
            this.colContractorName.Width = 151;
            // 
            // colContractingEngEstimate
            // 
            this.colContractingEngEstimate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colContractingEngEstimate.AppearanceHeader.Options.UseFont = true;
            this.colContractingEngEstimate.AppearanceHeader.Options.UseTextOptions = true;
            this.colContractingEngEstimate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractingEngEstimate.FieldName = "ContractingEngEstimate";
            this.colContractingEngEstimate.MinWidth = 25;
            this.colContractingEngEstimate.Name = "colContractingEngEstimate";
            this.colContractingEngEstimate.Visible = true;
            this.colContractingEngEstimate.VisibleIndex = 5;
            this.colContractingEngEstimate.Width = 149;
            // 
            // colDateContractAwarded
            // 
            this.colDateContractAwarded.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colDateContractAwarded.AppearanceHeader.Options.UseFont = true;
            this.colDateContractAwarded.AppearanceHeader.Options.UseTextOptions = true;
            this.colDateContractAwarded.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDateContractAwarded.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.colDateContractAwarded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateContractAwarded.FieldName = "DateContractAwarded";
            this.colDateContractAwarded.MinWidth = 25;
            this.colDateContractAwarded.Name = "colDateContractAwarded";
            this.colDateContractAwarded.Visible = true;
            this.colDateContractAwarded.VisibleIndex = 6;
            this.colDateContractAwarded.Width = 136;
            // 
            // colContractPrice
            // 
            this.colContractPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colContractPrice.AppearanceHeader.Options.UseFont = true;
            this.colContractPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colContractPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colContractPrice.FieldName = "ContractPrice";
            this.colContractPrice.MinWidth = 25;
            this.colContractPrice.Name = "colContractPrice";
            this.colContractPrice.Visible = true;
            this.colContractPrice.VisibleIndex = 7;
            this.colContractPrice.Width = 94;
            // 
            // colAnnualWorkDays
            // 
            this.colAnnualWorkDays.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colAnnualWorkDays.AppearanceHeader.Options.UseFont = true;
            this.colAnnualWorkDays.AppearanceHeader.Options.UseTextOptions = true;
            this.colAnnualWorkDays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAnnualWorkDays.FieldName = "AnnualWorkDays";
            this.colAnnualWorkDays.MinWidth = 25;
            this.colAnnualWorkDays.Name = "colAnnualWorkDays";
            this.colAnnualWorkDays.Visible = true;
            this.colAnnualWorkDays.VisibleIndex = 8;
            this.colAnnualWorkDays.Width = 94;
            // 
            // colRatePerWorkDays
            // 
            this.colRatePerWorkDays.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRatePerWorkDays.AppearanceHeader.Options.UseFont = true;
            this.colRatePerWorkDays.AppearanceHeader.Options.UseTextOptions = true;
            this.colRatePerWorkDays.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRatePerWorkDays.FieldName = "RatePerWorkDays";
            this.colRatePerWorkDays.MinWidth = 25;
            this.colRatePerWorkDays.Name = "colRatePerWorkDays";
            this.colRatePerWorkDays.Visible = true;
            this.colRatePerWorkDays.VisibleIndex = 9;
            this.colRatePerWorkDays.Width = 94;
            // 
            // colStartDate
            // 
            this.colStartDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colStartDate.AppearanceHeader.Options.UseFont = true;
            this.colStartDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colStartDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartDate.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.MinWidth = 25;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 10;
            this.colStartDate.Width = 94;
            // 
            // colEndDate
            // 
            this.colEndDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colEndDate.AppearanceHeader.Options.UseFont = true;
            this.colEndDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndDate.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.MinWidth = 25;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 11;
            this.colEndDate.Width = 94;
            // 
            // checkedCboTypeofWork
            // 
            this.checkedCboTypeofWork.AllowMultiSelect = true;
            this.checkedCboTypeofWork.AutoHeight = false;
            this.checkedCboTypeofWork.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedCboTypeofWork.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
            this.checkedCboTypeofWork.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Periodic Maintenance"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Spot Repairs "),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Rehabilitation"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Other")});
            this.checkedCboTypeofWork.Name = "checkedCboTypeofWork";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1407, 560);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.splitContainerControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1387, 540);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // adminBoundaryBindingSource
            // 
            this.adminBoundaryBindingSource.DataSource = typeof(RAMSDBModel.AdminBoundary);
            // 
            // editRoadSurfaceType
            // 
            this.editRoadSurfaceType.Name = "editRoadSurfaceType";
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
            // ContractRoutineMaintenanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ContractRoutineMaintenanceView";
            this.Size = new System.Drawing.Size(1407, 736);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractRoutineMaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTypeofWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedCboTypeofWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBoundaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editRoadSurfaceType)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboWoreda;
        private System.Windows.Forms.BindingSource adminBoundaryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboTypeofWork;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit checkedCboTypeofWork;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource contractRoutineMaintenanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeOfWork;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSection;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionLength;
        private DevExpress.XtraGrid.Columns.GridColumn colContractorName;
        private DevExpress.XtraGrid.Columns.GridColumn colContractingEngEstimate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateContractAwarded;
        private DevExpress.XtraGrid.Columns.GridColumn colContractPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnualWorkDays;
        private DevExpress.XtraGrid.Columns.GridColumn colRatePerWorkDays;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiProgress;
    }
}
