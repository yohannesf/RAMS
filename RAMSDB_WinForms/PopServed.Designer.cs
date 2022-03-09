namespace RAMSDB_WinForms
{
    partial class PopServed
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoreda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoredaLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoredaPopulation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPopulationServed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 148);
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
            this.colRoadID,
            this.colZone,
            this.colWoreda,
            this.colRoadName,
            this.colRoadLength,
            this.colWoredaLength,
            this.colWoredaPopulation,
            this.colPopulationServed});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
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
            this.colRoadID.Width = 109;
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
            this.colZone.VisibleIndex = 0;
            this.colZone.Width = 109;
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
            this.colWoreda.VisibleIndex = 1;
            this.colWoreda.Width = 109;
            // 
            // colRoadName
            // 
            this.colRoadName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadName.AppearanceHeader.Options.UseFont = true;
            this.colRoadName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadName.Caption = "Origin Destination";
            this.colRoadName.FieldName = "OriginDestination";
            this.colRoadName.MinWidth = 25;
            this.colRoadName.Name = "colRoadName";
            this.colRoadName.Visible = true;
            this.colRoadName.VisibleIndex = 2;
            this.colRoadName.Width = 109;
            // 
            // colRoadLength
            // 
            this.colRoadLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colRoadLength.AppearanceHeader.Options.UseFont = true;
            this.colRoadLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoadLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoadLength.Caption = "RoadLength";
            this.colRoadLength.DisplayFormat.FormatString = "#,###.00;[#,###.0];";
            this.colRoadLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRoadLength.FieldName = "RoadLength";
            this.colRoadLength.MinWidth = 25;
            this.colRoadLength.Name = "colRoadLength";
            this.colRoadLength.Visible = true;
            this.colRoadLength.VisibleIndex = 3;
            this.colRoadLength.Width = 109;
            // 
            // colWoredaLength
            // 
            this.colWoredaLength.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colWoredaLength.AppearanceHeader.Options.UseFont = true;
            this.colWoredaLength.AppearanceHeader.Options.UseTextOptions = true;
            this.colWoredaLength.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWoredaLength.Caption = "Road Length (WoredaTotal)";
            this.colWoredaLength.DisplayFormat.FormatString = "#,###.00;[#,###.0];";
            this.colWoredaLength.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWoredaLength.FieldName = "RoadLengthWoredaTotal";
            this.colWoredaLength.MinWidth = 25;
            this.colWoredaLength.Name = "colWoredaLength";
            this.colWoredaLength.Visible = true;
            this.colWoredaLength.VisibleIndex = 4;
            this.colWoredaLength.Width = 109;
            // 
            // colWoredaPopulation
            // 
            this.colWoredaPopulation.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colWoredaPopulation.AppearanceHeader.Options.UseFont = true;
            this.colWoredaPopulation.AppearanceHeader.Options.UseTextOptions = true;
            this.colWoredaPopulation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colWoredaPopulation.Caption = "Woreda Population";
            this.colWoredaPopulation.DisplayFormat.FormatString = "#,###.00;[#,###.0];";
            this.colWoredaPopulation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWoredaPopulation.FieldName = "WoredaPopulation";
            this.colWoredaPopulation.MinWidth = 25;
            this.colWoredaPopulation.Name = "colWoredaPopulation";
            this.colWoredaPopulation.Visible = true;
            this.colWoredaPopulation.VisibleIndex = 5;
            this.colWoredaPopulation.Width = 109;
            // 
            // colPopulationServed
            // 
            this.colPopulationServed.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colPopulationServed.AppearanceHeader.Options.UseFont = true;
            this.colPopulationServed.AppearanceHeader.Options.UseTextOptions = true;
            this.colPopulationServed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPopulationServed.Caption = "Population Served";
            this.colPopulationServed.DisplayFormat.FormatString = "#,###.00;[#,###.0];";
            this.colPopulationServed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPopulationServed.FieldName = "PopulationServed";
            this.colPopulationServed.MinWidth = 25;
            this.colPopulationServed.Name = "colPopulationServed";
            this.colPopulationServed.Visible = true;
            this.colPopulationServed.VisibleIndex = 6;
            this.colPopulationServed.Width = 109;
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
            // PopServed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PopServed";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colZone;
        private DevExpress.XtraGrid.Columns.GridColumn colWoreda;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadLength;
        private DevExpress.XtraGrid.Columns.GridColumn colWoredaLength;
        private DevExpress.XtraGrid.Columns.GridColumn colWoredaPopulation;
        private DevExpress.XtraGrid.Columns.GridColumn colPopulationServed;
    }
}
