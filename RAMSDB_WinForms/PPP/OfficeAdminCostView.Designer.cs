namespace RAMSDB_WinForms.PPP
{
    partial class OfficeAdminCostView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeAdminCostView));
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
            this.officeSupplyAdminCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkPlanFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSepMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOctMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNovMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDecMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJanMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFebMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAprMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMayMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJunMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJulMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAugMothlyExpense = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.officeSupplyAdminCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridControl1.DataSource = this.officeSupplyAdminCostBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1203, 458);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // officeSupplyAdminCostBindingSource
            // 
            this.officeSupplyAdminCostBindingSource.DataSource = typeof(RAMSDBModel.OfficeSupplyAdminCost);
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
            this.colItem,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotalCost,
            this.colSepMothlyExpense,
            this.colOctMothlyExpense,
            this.colNovMothlyExpense,
            this.colDecMothlyExpense,
            this.colJanMothlyExpense,
            this.colFebMothlyExpense,
            this.colMarMothlyExpense,
            this.colAprMothlyExpense,
            this.colMayMothlyExpense,
            this.colJunMothlyExpense,
            this.colJulMothlyExpense,
            this.colAugMothlyExpense});
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
            this.colRegion.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRegion.AppearanceHeader.Options.UseFont = true;
            this.colRegion.AppearanceHeader.Options.UseTextOptions = true;
            this.colRegion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegion.FieldName = "Region";
            this.colRegion.MinWidth = 25;
            this.colRegion.Name = "colRegion";
            this.colRegion.Width = 94;
            // 
            // colWoreda
            // 
            this.colWoreda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colWoreda.AppearanceHeader.Options.UseFont = true;
            this.colWoreda.AppearanceHeader.Options.UseTextOptions = true;
            this.colWoreda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWoreda.FieldName = "Woreda";
            this.colWoreda.MinWidth = 25;
            this.colWoreda.Name = "colWoreda";
            this.colWoreda.Width = 94;
            // 
            // colItem
            // 
            this.colItem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colItem.AppearanceHeader.Options.UseFont = true;
            this.colItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItem.FieldName = "Item";
            this.colItem.MinWidth = 25;
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            this.colItem.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 94;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colUnitPrice.AppearanceHeader.Options.UseFont = true;
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.MinWidth = 25;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            this.colUnitPrice.Width = 94;
            // 
            // colTotalCost
            // 
            this.colTotalCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceHeader.Options.UseFont = true;
            this.colTotalCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 25;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 3;
            this.colTotalCost.Width = 94;
            // 
            // colSepMothlyExpense
            // 
            this.colSepMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colSepMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colSepMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colSepMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSepMothlyExpense.Caption = "Monthly Expense - Sep";
            this.colSepMothlyExpense.FieldName = "SepMothlyExpense";
            this.colSepMothlyExpense.MinWidth = 25;
            this.colSepMothlyExpense.Name = "colSepMothlyExpense";
            this.colSepMothlyExpense.Visible = true;
            this.colSepMothlyExpense.VisibleIndex = 4;
            this.colSepMothlyExpense.Width = 94;
            // 
            // colOctMothlyExpense
            // 
            this.colOctMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colOctMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colOctMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colOctMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOctMothlyExpense.Caption = "Oct";
            this.colOctMothlyExpense.FieldName = "OctMothlyExpense";
            this.colOctMothlyExpense.MinWidth = 25;
            this.colOctMothlyExpense.Name = "colOctMothlyExpense";
            this.colOctMothlyExpense.Visible = true;
            this.colOctMothlyExpense.VisibleIndex = 5;
            this.colOctMothlyExpense.Width = 94;
            // 
            // colNovMothlyExpense
            // 
            this.colNovMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colNovMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colNovMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colNovMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNovMothlyExpense.Caption = "Nov";
            this.colNovMothlyExpense.FieldName = "NovMothlyExpense";
            this.colNovMothlyExpense.MinWidth = 25;
            this.colNovMothlyExpense.Name = "colNovMothlyExpense";
            this.colNovMothlyExpense.Visible = true;
            this.colNovMothlyExpense.VisibleIndex = 6;
            this.colNovMothlyExpense.Width = 94;
            // 
            // colDecMothlyExpense
            // 
            this.colDecMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colDecMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colDecMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colDecMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDecMothlyExpense.Caption = "Dec";
            this.colDecMothlyExpense.FieldName = "DecMothlyExpense";
            this.colDecMothlyExpense.MinWidth = 25;
            this.colDecMothlyExpense.Name = "colDecMothlyExpense";
            this.colDecMothlyExpense.Visible = true;
            this.colDecMothlyExpense.VisibleIndex = 7;
            this.colDecMothlyExpense.Width = 94;
            // 
            // colJanMothlyExpense
            // 
            this.colJanMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colJanMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colJanMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colJanMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJanMothlyExpense.Caption = "Jan";
            this.colJanMothlyExpense.FieldName = "JanMothlyExpense";
            this.colJanMothlyExpense.MinWidth = 25;
            this.colJanMothlyExpense.Name = "colJanMothlyExpense";
            this.colJanMothlyExpense.Visible = true;
            this.colJanMothlyExpense.VisibleIndex = 8;
            this.colJanMothlyExpense.Width = 94;
            // 
            // colFebMothlyExpense
            // 
            this.colFebMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colFebMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colFebMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colFebMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFebMothlyExpense.Caption = "Feb";
            this.colFebMothlyExpense.FieldName = "FebMothlyExpense";
            this.colFebMothlyExpense.MinWidth = 25;
            this.colFebMothlyExpense.Name = "colFebMothlyExpense";
            this.colFebMothlyExpense.Visible = true;
            this.colFebMothlyExpense.VisibleIndex = 9;
            this.colFebMothlyExpense.Width = 94;
            // 
            // colMarMothlyExpense
            // 
            this.colMarMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMarMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colMarMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colMarMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMarMothlyExpense.Caption = "Mar";
            this.colMarMothlyExpense.FieldName = "MarMothlyExpense";
            this.colMarMothlyExpense.MinWidth = 25;
            this.colMarMothlyExpense.Name = "colMarMothlyExpense";
            this.colMarMothlyExpense.Visible = true;
            this.colMarMothlyExpense.VisibleIndex = 10;
            this.colMarMothlyExpense.Width = 94;
            // 
            // colAprMothlyExpense
            // 
            this.colAprMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colAprMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colAprMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colAprMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAprMothlyExpense.Caption = "Apr";
            this.colAprMothlyExpense.FieldName = "AprMothlyExpense";
            this.colAprMothlyExpense.MinWidth = 25;
            this.colAprMothlyExpense.Name = "colAprMothlyExpense";
            this.colAprMothlyExpense.Visible = true;
            this.colAprMothlyExpense.VisibleIndex = 11;
            this.colAprMothlyExpense.Width = 94;
            // 
            // colMayMothlyExpense
            // 
            this.colMayMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colMayMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colMayMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colMayMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMayMothlyExpense.Caption = "May";
            this.colMayMothlyExpense.FieldName = "MayMothlyExpense";
            this.colMayMothlyExpense.MinWidth = 25;
            this.colMayMothlyExpense.Name = "colMayMothlyExpense";
            this.colMayMothlyExpense.Visible = true;
            this.colMayMothlyExpense.VisibleIndex = 12;
            this.colMayMothlyExpense.Width = 94;
            // 
            // colJunMothlyExpense
            // 
            this.colJunMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colJunMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colJunMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colJunMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJunMothlyExpense.Caption = "Jun";
            this.colJunMothlyExpense.FieldName = "JunMothlyExpense";
            this.colJunMothlyExpense.MinWidth = 25;
            this.colJunMothlyExpense.Name = "colJunMothlyExpense";
            this.colJunMothlyExpense.Visible = true;
            this.colJunMothlyExpense.VisibleIndex = 13;
            this.colJunMothlyExpense.Width = 94;
            // 
            // colJulMothlyExpense
            // 
            this.colJulMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colJulMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colJulMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colJulMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJulMothlyExpense.Caption = "Jul";
            this.colJulMothlyExpense.FieldName = "JulMothlyExpense";
            this.colJulMothlyExpense.MinWidth = 25;
            this.colJulMothlyExpense.Name = "colJulMothlyExpense";
            this.colJulMothlyExpense.Visible = true;
            this.colJulMothlyExpense.VisibleIndex = 14;
            this.colJulMothlyExpense.Width = 94;
            // 
            // colAugMothlyExpense
            // 
            this.colAugMothlyExpense.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colAugMothlyExpense.AppearanceHeader.Options.UseFont = true;
            this.colAugMothlyExpense.AppearanceHeader.Options.UseTextOptions = true;
            this.colAugMothlyExpense.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAugMothlyExpense.Caption = "Aug";
            this.colAugMothlyExpense.FieldName = "AugMothlyExpense";
            this.colAugMothlyExpense.MinWidth = 25;
            this.colAugMothlyExpense.Name = "colAugMothlyExpense";
            this.colAugMothlyExpense.Visible = true;
            this.colAugMothlyExpense.VisibleIndex = 15;
            this.colAugMothlyExpense.Width = 94;
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
            // OfficeAdminCostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OfficeAdminCostView";
            this.Size = new System.Drawing.Size(1227, 737);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeSupplyAdminCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.BindingSource officeSupplyAdminCostBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkPlanFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
      //  private DevExpress.XtraGrid.Columns.GridColumn colRoadLength;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colSepMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colOctMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colNovMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colDecMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colJanMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colFebMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colMarMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colAprMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colMayMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colJunMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colJulMothlyExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colAugMothlyExpense;
    }
}
