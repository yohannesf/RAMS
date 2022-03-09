namespace RAMSDB_WinForms
{
    partial class RoadsAssignedWidget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoadsAssignedWidget));
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            this.columnDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.columnDefinition3 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
            this.doclstRoads = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.docNumOfRoads = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.docRoadClass = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.docSurfaceType = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.docRoadLength = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.rowDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
            this.rowDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
            this.stackGroup1 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiConditionSurvey = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMulticriteriaData = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTrafficData = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMap = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRoadFurniture = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAddStructureInventory = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStructureConditionSurvey = new DevExpress.XtraBars.BarButtonItem();
            this.rpHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doclstRoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumOfRoads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoadClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSurfaceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoadLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.widgetView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
            // 
            // widgetView1
            // 
            this.widgetView1.Columns.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition[] {
            this.columnDefinition1,
            this.columnDefinition2,
            this.columnDefinition3});
            this.widgetView1.DocumentProperties.AllowClose = false;
            this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.doclstRoads,
            this.docNumOfRoads,
            this.docRoadClass,
            this.docSurfaceType,
            this.docRoadLength});
            this.widgetView1.DocumentSpacing = 5;
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout;
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widgetView1.Rows.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition[] {
            this.rowDefinition1,
            this.rowDefinition2});
            this.widgetView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.widgetView1_QueryControl);
            // 
            // columnDefinition1
            // 
            this.columnDefinition1.Length.UnitValue = 1.65D;
            // 
            // columnDefinition2
            // 
            this.columnDefinition2.Length.UnitValue = 0.35D;
            // 
            // doclstRoads
            // 
            this.doclstRoads.Caption = "List of Roads";
            this.doclstRoads.ControlName = "lstRoads";
            this.doclstRoads.ControlTypeName = "RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ListofRoadsAssigned";
            // 
            // docNumOfRoads
            // 
            this.docNumOfRoads.Caption = "# of Roads";
            this.docNumOfRoads.ColumnIndex = 1;
            this.docNumOfRoads.ControlName = "ucNumOfRoads";
            this.docNumOfRoads.ControlTypeName = "RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucNumOfRoads";
            // 
            // docRoadClass
            // 
            this.docRoadClass.Caption = "Road Classification";
            this.docRoadClass.ColumnIndex = 2;
            this.docRoadClass.ControlName = "ucRoadClass";
            this.docRoadClass.ControlTypeName = "RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucClassification";
            // 
            // docSurfaceType
            // 
            this.docSurfaceType.Caption = "By Surface Type";
            this.docSurfaceType.ColumnIndex = 2;
            this.docSurfaceType.ControlName = "ucSurfaceType";
            this.docSurfaceType.ControlTypeName = "RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucSurfaceType";
            this.docSurfaceType.RowIndex = 1;
            // 
            // docRoadLength
            // 
            this.docRoadLength.Caption = "Length of Roads";
            this.docRoadLength.ColumnSpan = 2;
            this.docRoadLength.ControlName = "ucRoadLength";
            this.docRoadLength.ControlTypeName = "RAMSDB_WinForms.Views.RoadsAssignedWidgetView.ucRoadLength";
            this.docRoadLength.RowIndex = 1;
            // 
            // rowDefinition1
            // 
            this.rowDefinition1.Length.UnitValue = 1.5D;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiConditionSurvey,
            this.bbiMulticriteriaData,
            this.bbiTrafficData,
            this.bbiMap,
            this.bbiExport,
            this.bbiPrintPreview,
            this.bbiRoadFurniture,
            this.bbiAddStructureInventory,
            this.bbiStructureConditionSurvey});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHome});
            this.ribbonControl1.Size = new System.Drawing.Size(872, 178);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // bbiConditionSurvey
            // 
            this.bbiConditionSurvey.Caption = "Add/Edit Condition Survey";
            this.bbiConditionSurvey.Id = 1;
            this.bbiConditionSurvey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiConditionSurvey.ImageOptions.SvgImage")));
            this.bbiConditionSurvey.Name = "bbiConditionSurvey";
            this.bbiConditionSurvey.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConditionSurvey_ItemClick);
            // 
            // bbiMulticriteriaData
            // 
            this.bbiMulticriteriaData.Caption = "Add/Edit Multi-Criteria Data";
            this.bbiMulticriteriaData.Id = 2;
            this.bbiMulticriteriaData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiMulticriteriaData.ImageOptions.SvgImage")));
            this.bbiMulticriteriaData.Name = "bbiMulticriteriaData";
            this.bbiMulticriteriaData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMulticriteriaData_ItemClick);
            // 
            // bbiTrafficData
            // 
            this.bbiTrafficData.Caption = "Add/Edit Traffic Survey Data";
            this.bbiTrafficData.Id = 3;
            this.bbiTrafficData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTrafficData.ImageOptions.SvgImage")));
            this.bbiTrafficData.Name = "bbiTrafficData";
            this.bbiTrafficData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTrafficData_ItemClick);
            // 
            // bbiMap
            // 
            this.bbiMap.Caption = "View in Map";
            this.bbiMap.Id = 4;
            this.bbiMap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiMap.ImageOptions.SvgImage")));
            this.bbiMap.Name = "bbiMap";
            this.bbiMap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMap_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Id = 5;
            this.bbiExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExport.ImageOptions.Image")));
            this.bbiExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExport.ImageOptions.LargeImage")));
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 6;
            this.bbiPrintPreview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiPrintPreview.ImageOptions.SvgImage")));
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bbiRoadFurniture
            // 
            this.bbiRoadFurniture.Caption = "Add / Edit Road Furnitures / Accessories";
            this.bbiRoadFurniture.Id = 7;
            this.bbiRoadFurniture.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiRoadFurniture.ImageOptions.Image")));
            this.bbiRoadFurniture.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiRoadFurniture.ImageOptions.LargeImage")));
            this.bbiRoadFurniture.Name = "bbiRoadFurniture";
            this.bbiRoadFurniture.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRoadFurniture_ItemClick);
            // 
            // bbiAddStructureInventory
            // 
            this.bbiAddStructureInventory.Caption = "Structure Inventory";
            this.bbiAddStructureInventory.Id = 9;
            this.bbiAddStructureInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAddStructureInventory.ImageOptions.SvgImage")));
            this.bbiAddStructureInventory.Name = "bbiAddStructureInventory";
            this.bbiAddStructureInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddStructureInventory_ItemClick);
            // 
            // bbiStructureConditionSurvey
            // 
            this.bbiStructureConditionSurvey.Caption = "Add / Edit Structure Condition Survey";
            this.bbiStructureConditionSurvey.Id = 10;
            this.bbiStructureConditionSurvey.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiStructureConditionSurvey.ImageOptions.SvgImage")));
            this.bbiStructureConditionSurvey.Name = "bbiStructureConditionSurvey";
            this.bbiStructureConditionSurvey.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStructureConditionSurvey_ItemClick);
            // 
            // rpHome
            // 
            this.rpHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rpHome.MergeOrder = 1;
            this.rpHome.Name = "rpHome";
            this.rpHome.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiConditionSurvey);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiMulticriteriaData);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiTrafficData);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRoadFurniture);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAddStructureInventory);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiStructureConditionSurvey);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiMap);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Visualization";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiExport);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Print and Export";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 596);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(872, 28);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // RoadsAssignedWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "RoadsAssignedWidget";
            this.Size = new System.Drawing.Size(872, 624);
            this.Load += new System.EventHandler(this.RoadsAssignedWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doclstRoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docNumOfRoads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoadClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docSurfaceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docRoadLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document doclstRoads;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document docNumOfRoads;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document docRoadClass;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document docSurfaceType;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document docRoadLength;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem bbiConditionSurvey;
        private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition2;
        private DevExpress.XtraBars.BarButtonItem bbiMulticriteriaData;
        private DevExpress.XtraBars.BarButtonItem bbiTrafficData;
        private DevExpress.XtraBars.BarButtonItem bbiMap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition3;
        private DevExpress.XtraBars.BarButtonItem bbiRoadFurniture;
        private DevExpress.XtraBars.BarButtonItem bbiAddStructureInventory;
        private DevExpress.XtraBars.BarButtonItem bbiStructureConditionSurvey;
    }
}
