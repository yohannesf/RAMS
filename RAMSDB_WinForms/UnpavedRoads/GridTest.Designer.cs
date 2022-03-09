namespace RAMSDB_WinForms
{
    partial class GridTest
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
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.unpavedRoadConditionSurveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRCSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRCSYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadSectionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionChainageStartKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionChainageEndKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionLengthKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYBegin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartNodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndNodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDrainageConditionLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDrainageConditionRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShoulderConditionLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShoulderConditionRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurfaceCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBottleneck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBottleneckSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfAssessment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssessedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_ShoulderConditionLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_ShoulderConditionRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_SurfaceCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_DrainageConditionLeft = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition_DrainageConditionRight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadSurfaceType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadsGISData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadsPerUser = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainRibbonControl.MaxItemId = 13;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage,
            this.ribbonPage1});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1179, 148);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroup1});
            this.mainRibbonPage.KeyTip = "H";
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.GroupName = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            this.mainRibbonPage.ReduceOperations.Add(reduceOperation1);
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave, "SA");
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose, "SV");
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew, "SE");
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset, "RE");
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete, "D");
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose, "C");
            this.mainRibbonPageGroup.KeyTip = "T";
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.KeyTip = "RI";
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSaveAndClose);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiSaveAndNew);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.unpavedRoadConditionSurveyBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 148);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1179, 836);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // unpavedRoadConditionSurveyBindingSource
            // 
            this.unpavedRoadConditionSurveyBindingSource.DataSource = typeof(RAMSDBModel.UnpavedRoadConditionSurvey);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRCSID,
            this.colRCSYear,
            this.colRoadID,
            this.colUserID,
            this.colRoadSectionNo,
            this.colSectionChainageStartKM,
            this.colSectionChainageEndKM,
            this.colSectionLengthKM,
            this.colSurfaceType,
            this.colXBegin,
            this.colYBegin,
            this.colXEnd,
            this.colYEnd,
            this.colStartNodeID,
            this.colEndNodeID,
            this.colDrainageConditionLeft,
            this.colDrainageConditionRight,
            this.colShoulderConditionLeft,
            this.colShoulderConditionRight,
            this.colSurfaceCondition,
            this.colBottleneck,
            this.colBottleneckSize,
            this.colDateOfAssessment,
            this.colAssessedBy,
            this.colComments,
            this.colCondition_ShoulderConditionLeft,
            this.colCondition_ShoulderConditionRight,
            this.colCondition_SurfaceCondition,
            this.colCondition_DrainageConditionLeft,
            this.colCondition_DrainageConditionRight,
            this.colRoadSurfaceType,
            this.colRoadsGISData,
            this.colRoadsPerUser});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colRCSID
            // 
            this.colRCSID.FieldName = "RCSID";
            this.colRCSID.MinWidth = 25;
            this.colRCSID.Name = "colRCSID";
            this.colRCSID.Visible = true;
            this.colRCSID.VisibleIndex = 0;
            this.colRCSID.Width = 94;
            // 
            // colRCSYear
            // 
            this.colRCSYear.FieldName = "RCSYear";
            this.colRCSYear.MinWidth = 25;
            this.colRCSYear.Name = "colRCSYear";
            this.colRCSYear.Visible = true;
            this.colRCSYear.VisibleIndex = 1;
            this.colRCSYear.Width = 94;
            // 
            // colRoadID
            // 
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Visible = true;
            this.colRoadID.VisibleIndex = 2;
            this.colRoadID.Width = 94;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.MinWidth = 25;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 3;
            this.colUserID.Width = 94;
            // 
            // colRoadSectionNo
            // 
            this.colRoadSectionNo.FieldName = "RoadSectionNo";
            this.colRoadSectionNo.MinWidth = 25;
            this.colRoadSectionNo.Name = "colRoadSectionNo";
            this.colRoadSectionNo.Visible = true;
            this.colRoadSectionNo.VisibleIndex = 4;
            this.colRoadSectionNo.Width = 94;
            // 
            // colSectionChainageStartKM
            // 
            this.colSectionChainageStartKM.FieldName = "SectionChainageStartKM";
            this.colSectionChainageStartKM.MinWidth = 25;
            this.colSectionChainageStartKM.Name = "colSectionChainageStartKM";
            this.colSectionChainageStartKM.Visible = true;
            this.colSectionChainageStartKM.VisibleIndex = 5;
            this.colSectionChainageStartKM.Width = 94;
            // 
            // colSectionChainageEndKM
            // 
            this.colSectionChainageEndKM.FieldName = "SectionChainageEndKM";
            this.colSectionChainageEndKM.MinWidth = 25;
            this.colSectionChainageEndKM.Name = "colSectionChainageEndKM";
            this.colSectionChainageEndKM.Visible = true;
            this.colSectionChainageEndKM.VisibleIndex = 6;
            this.colSectionChainageEndKM.Width = 94;
            // 
            // colSectionLengthKM
            // 
            this.colSectionLengthKM.FieldName = "SectionLengthKM";
            this.colSectionLengthKM.MinWidth = 25;
            this.colSectionLengthKM.Name = "colSectionLengthKM";
            this.colSectionLengthKM.Visible = true;
            this.colSectionLengthKM.VisibleIndex = 7;
            this.colSectionLengthKM.Width = 94;
            // 
            // colSurfaceType
            // 
            this.colSurfaceType.FieldName = "SurfaceType";
            this.colSurfaceType.MinWidth = 25;
            this.colSurfaceType.Name = "colSurfaceType";
            this.colSurfaceType.Visible = true;
            this.colSurfaceType.VisibleIndex = 8;
            this.colSurfaceType.Width = 94;
            // 
            // colXBegin
            // 
            this.colXBegin.FieldName = "XBegin";
            this.colXBegin.MinWidth = 25;
            this.colXBegin.Name = "colXBegin";
            this.colXBegin.Visible = true;
            this.colXBegin.VisibleIndex = 9;
            this.colXBegin.Width = 94;
            // 
            // colYBegin
            // 
            this.colYBegin.FieldName = "YBegin";
            this.colYBegin.MinWidth = 25;
            this.colYBegin.Name = "colYBegin";
            this.colYBegin.Visible = true;
            this.colYBegin.VisibleIndex = 10;
            this.colYBegin.Width = 94;
            // 
            // colXEnd
            // 
            this.colXEnd.FieldName = "XEnd";
            this.colXEnd.MinWidth = 25;
            this.colXEnd.Name = "colXEnd";
            this.colXEnd.Visible = true;
            this.colXEnd.VisibleIndex = 11;
            this.colXEnd.Width = 94;
            // 
            // colYEnd
            // 
            this.colYEnd.FieldName = "YEnd";
            this.colYEnd.MinWidth = 25;
            this.colYEnd.Name = "colYEnd";
            this.colYEnd.Visible = true;
            this.colYEnd.VisibleIndex = 12;
            this.colYEnd.Width = 94;
            // 
            // colStartNodeID
            // 
            this.colStartNodeID.FieldName = "StartNodeID";
            this.colStartNodeID.MinWidth = 25;
            this.colStartNodeID.Name = "colStartNodeID";
            this.colStartNodeID.Visible = true;
            this.colStartNodeID.VisibleIndex = 13;
            this.colStartNodeID.Width = 94;
            // 
            // colEndNodeID
            // 
            this.colEndNodeID.FieldName = "EndNodeID";
            this.colEndNodeID.MinWidth = 25;
            this.colEndNodeID.Name = "colEndNodeID";
            this.colEndNodeID.Visible = true;
            this.colEndNodeID.VisibleIndex = 14;
            this.colEndNodeID.Width = 94;
            // 
            // colDrainageConditionLeft
            // 
            this.colDrainageConditionLeft.FieldName = "DrainageConditionLeft";
            this.colDrainageConditionLeft.MinWidth = 25;
            this.colDrainageConditionLeft.Name = "colDrainageConditionLeft";
            this.colDrainageConditionLeft.Visible = true;
            this.colDrainageConditionLeft.VisibleIndex = 15;
            this.colDrainageConditionLeft.Width = 94;
            // 
            // colDrainageConditionRight
            // 
            this.colDrainageConditionRight.FieldName = "DrainageConditionRight";
            this.colDrainageConditionRight.MinWidth = 25;
            this.colDrainageConditionRight.Name = "colDrainageConditionRight";
            this.colDrainageConditionRight.Visible = true;
            this.colDrainageConditionRight.VisibleIndex = 16;
            this.colDrainageConditionRight.Width = 94;
            // 
            // colShoulderConditionLeft
            // 
            this.colShoulderConditionLeft.FieldName = "ShoulderConditionLeft";
            this.colShoulderConditionLeft.MinWidth = 25;
            this.colShoulderConditionLeft.Name = "colShoulderConditionLeft";
            this.colShoulderConditionLeft.Visible = true;
            this.colShoulderConditionLeft.VisibleIndex = 17;
            this.colShoulderConditionLeft.Width = 94;
            // 
            // colShoulderConditionRight
            // 
            this.colShoulderConditionRight.FieldName = "ShoulderConditionRight";
            this.colShoulderConditionRight.MinWidth = 25;
            this.colShoulderConditionRight.Name = "colShoulderConditionRight";
            this.colShoulderConditionRight.Visible = true;
            this.colShoulderConditionRight.VisibleIndex = 18;
            this.colShoulderConditionRight.Width = 94;
            // 
            // colSurfaceCondition
            // 
            this.colSurfaceCondition.FieldName = "SurfaceCondition";
            this.colSurfaceCondition.MinWidth = 25;
            this.colSurfaceCondition.Name = "colSurfaceCondition";
            this.colSurfaceCondition.Visible = true;
            this.colSurfaceCondition.VisibleIndex = 19;
            this.colSurfaceCondition.Width = 94;
            // 
            // colBottleneck
            // 
            this.colBottleneck.FieldName = "Bottleneck";
            this.colBottleneck.MinWidth = 25;
            this.colBottleneck.Name = "colBottleneck";
            this.colBottleneck.Visible = true;
            this.colBottleneck.VisibleIndex = 20;
            this.colBottleneck.Width = 94;
            // 
            // colBottleneckSize
            // 
            this.colBottleneckSize.FieldName = "BottleneckSize";
            this.colBottleneckSize.MinWidth = 25;
            this.colBottleneckSize.Name = "colBottleneckSize";
            this.colBottleneckSize.Visible = true;
            this.colBottleneckSize.VisibleIndex = 21;
            this.colBottleneckSize.Width = 94;
            // 
            // colDateOfAssessment
            // 
            this.colDateOfAssessment.FieldName = "DateOfAssessment";
            this.colDateOfAssessment.MinWidth = 25;
            this.colDateOfAssessment.Name = "colDateOfAssessment";
            this.colDateOfAssessment.Visible = true;
            this.colDateOfAssessment.VisibleIndex = 22;
            this.colDateOfAssessment.Width = 94;
            // 
            // colAssessedBy
            // 
            this.colAssessedBy.FieldName = "AssessedBy";
            this.colAssessedBy.MinWidth = 25;
            this.colAssessedBy.Name = "colAssessedBy";
            this.colAssessedBy.Visible = true;
            this.colAssessedBy.VisibleIndex = 23;
            this.colAssessedBy.Width = 94;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.MinWidth = 25;
            this.colComments.Name = "colComments";
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 24;
            this.colComments.Width = 94;
            // 
            // colCondition_ShoulderConditionLeft
            // 
            this.colCondition_ShoulderConditionLeft.FieldName = "Condition_ShoulderConditionLeft";
            this.colCondition_ShoulderConditionLeft.MinWidth = 25;
            this.colCondition_ShoulderConditionLeft.Name = "colCondition_ShoulderConditionLeft";
            this.colCondition_ShoulderConditionLeft.Visible = true;
            this.colCondition_ShoulderConditionLeft.VisibleIndex = 25;
            this.colCondition_ShoulderConditionLeft.Width = 94;
            // 
            // colCondition_ShoulderConditionRight
            // 
            this.colCondition_ShoulderConditionRight.FieldName = "Condition_ShoulderConditionRight";
            this.colCondition_ShoulderConditionRight.MinWidth = 25;
            this.colCondition_ShoulderConditionRight.Name = "colCondition_ShoulderConditionRight";
            this.colCondition_ShoulderConditionRight.Visible = true;
            this.colCondition_ShoulderConditionRight.VisibleIndex = 26;
            this.colCondition_ShoulderConditionRight.Width = 94;
            // 
            // colCondition_SurfaceCondition
            // 
            this.colCondition_SurfaceCondition.FieldName = "Condition_SurfaceCondition";
            this.colCondition_SurfaceCondition.MinWidth = 25;
            this.colCondition_SurfaceCondition.Name = "colCondition_SurfaceCondition";
            this.colCondition_SurfaceCondition.Visible = true;
            this.colCondition_SurfaceCondition.VisibleIndex = 27;
            this.colCondition_SurfaceCondition.Width = 94;
            // 
            // colCondition_DrainageConditionLeft
            // 
            this.colCondition_DrainageConditionLeft.FieldName = "Condition_DrainageConditionLeft";
            this.colCondition_DrainageConditionLeft.MinWidth = 25;
            this.colCondition_DrainageConditionLeft.Name = "colCondition_DrainageConditionLeft";
            this.colCondition_DrainageConditionLeft.Visible = true;
            this.colCondition_DrainageConditionLeft.VisibleIndex = 28;
            this.colCondition_DrainageConditionLeft.Width = 94;
            // 
            // colCondition_DrainageConditionRight
            // 
            this.colCondition_DrainageConditionRight.FieldName = "Condition_DrainageConditionRight";
            this.colCondition_DrainageConditionRight.MinWidth = 25;
            this.colCondition_DrainageConditionRight.Name = "colCondition_DrainageConditionRight";
            this.colCondition_DrainageConditionRight.Visible = true;
            this.colCondition_DrainageConditionRight.VisibleIndex = 29;
            this.colCondition_DrainageConditionRight.Width = 94;
            // 
            // colRoadSurfaceType
            // 
            this.colRoadSurfaceType.FieldName = "RoadSurfaceType";
            this.colRoadSurfaceType.MinWidth = 25;
            this.colRoadSurfaceType.Name = "colRoadSurfaceType";
            this.colRoadSurfaceType.Visible = true;
            this.colRoadSurfaceType.VisibleIndex = 30;
            this.colRoadSurfaceType.Width = 94;
            // 
            // colRoadsGISData
            // 
            this.colRoadsGISData.FieldName = "RoadsGISData";
            this.colRoadsGISData.MinWidth = 25;
            this.colRoadsGISData.Name = "colRoadsGISData";
            this.colRoadsGISData.Visible = true;
            this.colRoadsGISData.VisibleIndex = 31;
            this.colRoadsGISData.Width = 94;
            // 
            // colRoadsPerUser
            // 
            this.colRoadsPerUser.FieldName = "RoadsPerUser";
            this.colRoadsPerUser.MinWidth = 25;
            this.colRoadsPerUser.Name = "colRoadsPerUser";
            this.colRoadsPerUser.Visible = true;
            this.colRoadsPerUser.VisibleIndex = 32;
            this.colRoadsPerUser.Width = 94;
            // 
            // GridTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GridTest";
            this.Size = new System.Drawing.Size(1179, 984);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource unpavedRoadConditionSurveyBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSID;
        private DevExpress.XtraGrid.Columns.GridColumn colRCSYear;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSectionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageStartKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionChainageEndKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionLengthKM;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colXBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colYBegin;
        private DevExpress.XtraGrid.Columns.GridColumn colXEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colYEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colStartNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEndNodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colDrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colSurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneck;
        private DevExpress.XtraGrid.Columns.GridColumn colBottleneckSize;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfAssessment;
        private DevExpress.XtraGrid.Columns.GridColumn colAssessedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_ShoulderConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_SurfaceCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition_DrainageConditionRight;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadSurfaceType;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadsGISData;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadsPerUser;
    }
}