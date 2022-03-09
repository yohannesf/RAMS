namespace RAMSDB_WinForms.PavedRoads
{
    partial class PavedRoadsMaintenanceCostPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PavedRoadsMaintenanceCostPlan));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiViewDetails = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(933, 590);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColYear,
            this.colOrDes,
            this.colTotalCost,
            this.colZone,
            this.colWoreda,
            this.colLength,
            this.colClass,
            this.colSurfaceType,
            this.colRoadID});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.DoubleClick += new System.EventHandler(this.GridView_DoubleClick);
            // 
            // ColYear
            // 
            this.ColYear.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ColYear.AppearanceHeader.Options.UseFont = true;
            this.ColYear.AppearanceHeader.Options.UseTextOptions = true;
            this.ColYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColYear.Caption = "Year";
            this.ColYear.FieldName = "Year";
            this.ColYear.MinWidth = 25;
            this.ColYear.Name = "ColYear";
            // 
            // colOrDes
            // 
            this.colOrDes.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colOrDes.AppearanceHeader.Options.UseFont = true;
            this.colOrDes.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrDes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrDes.Caption = "Origin Destination ";
            this.colOrDes.FieldName = "OriginDestination";
            this.colOrDes.MinWidth = 25;
            this.colOrDes.Name = "colOrDes";
            this.colOrDes.Visible = true;
            this.colOrDes.VisibleIndex = 0;
            this.colOrDes.Width = 120;
            // 
            // colTotalCost
            // 
            this.colTotalCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colTotalCost.AppearanceHeader.Options.UseFont = true;
            this.colTotalCost.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalCost.Caption = "Total Cost";
            this.colTotalCost.DisplayFormat.FormatString = "c0";
            this.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.MinWidth = 25;
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 1;
            this.colTotalCost.Width = 117;
            // 
            // colZone
            // 
            this.colZone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colZone.AppearanceHeader.Options.UseFont = true;
            this.colZone.AppearanceHeader.Options.UseTextOptions = true;
            this.colZone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colZone.Caption = "Zone";
            this.colZone.FieldName = "Zone";
            this.colZone.MinWidth = 25;
            this.colZone.Name = "colZone";
            this.colZone.Visible = true;
            this.colZone.VisibleIndex = 2;
            this.colZone.Width = 117;
            // 
            // colWoreda
            // 
            this.colWoreda.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colWoreda.AppearanceHeader.Options.UseFont = true;
            this.colWoreda.AppearanceHeader.Options.UseTextOptions = true;
            this.colWoreda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWoreda.Caption = "Woreda";
            this.colWoreda.FieldName = "Woreda";
            this.colWoreda.MinWidth = 25;
            this.colWoreda.Name = "colWoreda";
            this.colWoreda.Visible = true;
            this.colWoreda.VisibleIndex = 3;
            this.colWoreda.Width = 117;
            // 
            // colLength
            // 
            this.colLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colLength.AppearanceHeader.Options.UseFont = true;
            this.colLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLength.Caption = "Road Length (KM)";
            this.colLength.DisplayFormat.FormatString = "#,###.00;[#,###.0];-;";
            this.colLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLength.FieldName = "RoadLength";
            this.colLength.MinWidth = 25;
            this.colLength.Name = "colLength";
            this.colLength.Visible = true;
            this.colLength.VisibleIndex = 4;
            this.colLength.Width = 117;
            // 
            // colClass
            // 
            this.colClass.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colClass.AppearanceHeader.Options.UseFont = true;
            this.colClass.AppearanceHeader.Options.UseTextOptions = true;
            this.colClass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClass.Caption = "Classification";
            this.colClass.FieldName = "Classification";
            this.colClass.MinWidth = 25;
            this.colClass.Name = "colClass";
            this.colClass.Visible = true;
            this.colClass.VisibleIndex = 5;
            this.colClass.Width = 117;
            // 
            // colSurfaceType
            // 
            this.colSurfaceType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colSurfaceType.AppearanceHeader.Options.UseFont = true;
            this.colSurfaceType.AppearanceHeader.Options.UseTextOptions = true;
            this.colSurfaceType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSurfaceType.Caption = "Surface Type";
            this.colSurfaceType.FieldName = "SurfaceType";
            this.colSurfaceType.MinWidth = 25;
            this.colSurfaceType.Name = "colSurfaceType";
            this.colSurfaceType.Visible = true;
            this.colSurfaceType.VisibleIndex = 6;
            this.colSurfaceType.Width = 125;
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
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiViewDetails,
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
            // bbiViewDetails
            // 
            this.bbiViewDetails.Caption = "View Details";
            this.bbiViewDetails.Id = 17;
            this.bbiViewDetails.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiViewDetails.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiViewDetails.ImageOptions.SvgImage")));
            this.bbiViewDetails.Name = "bbiViewDetails";
            this.bbiViewDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiViewDetails);
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
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.ItemHeight = 18;
            this.cboYear.Location = new System.Drawing.Point(511, 7);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(176, 26);
            this.cboYear.TabIndex = 23;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(420, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 35);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Year (EC)";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 148);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.gridSplitContainer1.Panel1.Controls.Add(this.cboYear);
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl);
            this.gridSplitContainer1.Size = new System.Drawing.Size(933, 590);
            this.gridSplitContainer1.TabIndex = 26;
            // 
            // PavedRoadsMaintenanceCostPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PavedRoadsMaintenanceCostPlan";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiViewDetails;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colOrDes;
        private DevExpress.XtraGrid.Columns.GridColumn colLength;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn ColYear;
        private System.Windows.Forms.ComboBox cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}
