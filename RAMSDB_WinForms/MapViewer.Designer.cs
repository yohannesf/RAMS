namespace RAMSDB_WinForms
{
    partial class MapViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapViewer));
            DevExpress.XtraMap.CartesianMapCoordinateSystem cartesianMapCoordinateSystem1 = new DevExpress.XtraMap.CartesianMapCoordinateSystem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.chkSurfaceType = new DevExpress.XtraBars.BarCheckItem();
            this.chkRoadClass = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.listSourceDataAdapter1 = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.layerRoads = new DevExpress.XtraMap.VectorItemsLayer();
            this.layerWoreda = new DevExpress.XtraMap.VectorItemsLayer();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.chkSurfaceType,
            this.chkRoadClass});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(834, 192);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // chkSurfaceType
            // 
            this.chkSurfaceType.Caption = "Surface Type";
            this.chkSurfaceType.GroupIndex = 1;
            this.chkSurfaceType.Id = 1;
            this.chkSurfaceType.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chkSurfaceType.ImageOptions.SvgImage")));
            this.chkSurfaceType.Name = "chkSurfaceType";
            this.chkSurfaceType.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MapMode_CheckedChanged);
            // 
            // chkRoadClass
            // 
            this.chkRoadClass.Caption = "Road Classification";
            this.chkRoadClass.GroupIndex = 1;
            this.chkRoadClass.Id = 2;
            this.chkRoadClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chkRoadClass.ImageOptions.SvgImage")));
            this.chkRoadClass.Name = "chkRoadClass";
            this.chkRoadClass.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MapMode_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.chkSurfaceType);
            this.ribbonPageGroup1.ItemLinks.Add(this.chkRoadClass);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Map Info";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 641);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(834, 28);
            this.vectorItemsLayer1.Name = "b";
            this.listSourceDataAdapter1.Mappings.ImageIndex = "ObjectID";
            this.listSourceDataAdapter1.Mappings.Text = "RoadOriginDestination";
            this.listSourceDataAdapter1.Mappings.Type = "ObjectID";
            // 
            // mapControl1
            // 
            cartesianMapCoordinateSystem1.MeasureUnit = DevExpress.XtraMap.MeasureUnit.Meter;
            this.mapControl1.CoordinateSystem = cartesianMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.layerRoads);
            this.mapControl1.Layers.Add(this.layerWoreda);
            this.mapControl1.Location = new System.Drawing.Point(0, 192);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(834, 449);
            this.mapControl1.TabIndex = 2;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.layerRoads.HighlightedItemStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layerRoads.HighlightedItemStyle.StrokeWidth = 10;
            this.layerRoads.HighlightedItemStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.layerRoads.ItemStyle.Stroke = System.Drawing.Color.Black;
            this.layerRoads.ItemStyle.StrokeWidth = 3;
            this.layerRoads.Name = "layerRoads";
            this.layerWoreda.ItemImageIndex = 0;
            this.layerWoreda.Name = "WoredaLayer";
            this.layerWoreda.ToolTipPattern = "{Woreda}";
            this.layerWoreda.ZIndex = 101;
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipController1.Appearance.Options.UseFont = true;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // MapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 669);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MapViewer";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MapViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1;
        private DevExpress.XtraMap.ListSourceDataAdapter listSourceDataAdapter1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.VectorItemsLayer layerWoreda;
        private DevExpress.XtraMap.VectorItemsLayer layerRoads;
        private DevExpress.XtraBars.BarCheckItem chkSurfaceType;
        private DevExpress.XtraBars.BarCheckItem chkRoadClass;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}