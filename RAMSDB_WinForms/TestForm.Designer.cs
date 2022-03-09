namespace RAMSDB_WinForms
{
    partial class TestForm
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
            this.officeSupplyAdminCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpavedRoadConditionSurveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roadsGISDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prioritizedRoadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unpavedTentativeRoadMaintenancePlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.annualRoadWorkPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnnualPlanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFYearEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSectionLength = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoutineMaintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodicMaintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRehabilitation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadBottleneck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStructuralBottleneck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr1Plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr1Achievement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr2Plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr2Achievement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr3Plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr3Achievement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr4Plan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtr4Achievement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoadsGISData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdminBoundary = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.officeSupplyAdminCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsGISDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedTentativeRoadMaintenancePlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualRoadWorkPlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // officeSupplyAdminCostBindingSource
            // 
            this.officeSupplyAdminCostBindingSource.DataSource = typeof(RAMSDBModel.OfficeSupplyAdminCost);
            // 
            // unpavedRoadConditionSurveyBindingSource
            // 
            this.unpavedRoadConditionSurveyBindingSource.DataSource = typeof(RAMSDBModel.UnpavedRoadConditionSurvey);
            // 
            // roadsGISDataBindingSource
            // 
            this.roadsGISDataBindingSource.DataSource = typeof(RAMSDBModel.RoadsGISData);
            // 
            // prioritizedRoadsBindingSource
            // 
            this.prioritizedRoadsBindingSource.DataSource = typeof(RAMSDBModel.PrioritizedRoads);
            // 
            // unpavedTentativeRoadMaintenancePlanBindingSource
            // 
            this.unpavedTentativeRoadMaintenancePlanBindingSource.DataSource = typeof(RAMSDBModel.UnpavedTentativeRoadMaintenancePlan);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.annualRoadWorkPlanBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(100, 110);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(993, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // annualRoadWorkPlanBindingSource
            // 
            this.annualRoadWorkPlanBindingSource.DataSource = typeof(RAMSDBModel.AnnualRoadWorkPlan);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnnualPlanID,
            this.colRoadID,
            this.colFYearEC,
            this.colAdminID,
            this.colSectionLength,
            this.colRoutineMaintenance,
            this.colPeriodicMaintenance,
            this.colRehabilitation,
            this.colRoadBottleneck,
            this.colStructuralBottleneck,
            this.colQtr1Plan,
            this.colQtr1Achievement,
            this.colQtr2Plan,
            this.colQtr2Achievement,
            this.colQtr3Plan,
            this.colQtr3Achievement,
            this.colQtr4Plan,
            this.colQtr4Achievement,
            this.colRemarks,
            this.colRoadsGISData,
            this.colAdminBoundary});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colAnnualPlanID
            // 
            this.colAnnualPlanID.FieldName = "AnnualPlanID";
            this.colAnnualPlanID.MinWidth = 25;
            this.colAnnualPlanID.Name = "colAnnualPlanID";
            this.colAnnualPlanID.Visible = true;
            this.colAnnualPlanID.VisibleIndex = 0;
            this.colAnnualPlanID.Width = 94;
            // 
            // colRoadID
            // 
            this.colRoadID.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colRoadID.FieldName = "RoadID";
            this.colRoadID.MinWidth = 25;
            this.colRoadID.Name = "colRoadID";
            this.colRoadID.Visible = true;
            this.colRoadID.VisibleIndex = 1;
            this.colRoadID.Width = 94;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.prioritizedRoadsBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "RoadsGISData.RoadOriginDestination";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "RoadID";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colFYearEC
            // 
            this.colFYearEC.FieldName = "FYearEC";
            this.colFYearEC.MinWidth = 25;
            this.colFYearEC.Name = "colFYearEC";
            this.colFYearEC.Visible = true;
            this.colFYearEC.VisibleIndex = 2;
            this.colFYearEC.Width = 94;
            // 
            // colAdminID
            // 
            this.colAdminID.FieldName = "AdminID";
            this.colAdminID.MinWidth = 25;
            this.colAdminID.Name = "colAdminID";
            this.colAdminID.Visible = true;
            this.colAdminID.VisibleIndex = 3;
            this.colAdminID.Width = 94;
            // 
            // colSectionLength
            // 
            this.colSectionLength.FieldName = "SectionLength";
            this.colSectionLength.MinWidth = 25;
            this.colSectionLength.Name = "colSectionLength";
            this.colSectionLength.Visible = true;
            this.colSectionLength.VisibleIndex = 4;
            this.colSectionLength.Width = 94;
            // 
            // colRoutineMaintenance
            // 
            this.colRoutineMaintenance.FieldName = "RoutineMaintenance";
            this.colRoutineMaintenance.MinWidth = 25;
            this.colRoutineMaintenance.Name = "colRoutineMaintenance";
            this.colRoutineMaintenance.Visible = true;
            this.colRoutineMaintenance.VisibleIndex = 5;
            this.colRoutineMaintenance.Width = 94;
            // 
            // colPeriodicMaintenance
            // 
            this.colPeriodicMaintenance.FieldName = "PeriodicMaintenance";
            this.colPeriodicMaintenance.MinWidth = 25;
            this.colPeriodicMaintenance.Name = "colPeriodicMaintenance";
            this.colPeriodicMaintenance.Visible = true;
            this.colPeriodicMaintenance.VisibleIndex = 6;
            this.colPeriodicMaintenance.Width = 94;
            // 
            // colRehabilitation
            // 
            this.colRehabilitation.FieldName = "Rehabilitation";
            this.colRehabilitation.MinWidth = 25;
            this.colRehabilitation.Name = "colRehabilitation";
            this.colRehabilitation.Visible = true;
            this.colRehabilitation.VisibleIndex = 7;
            this.colRehabilitation.Width = 94;
            // 
            // colRoadBottleneck
            // 
            this.colRoadBottleneck.FieldName = "RoadBottleneck";
            this.colRoadBottleneck.MinWidth = 25;
            this.colRoadBottleneck.Name = "colRoadBottleneck";
            this.colRoadBottleneck.Visible = true;
            this.colRoadBottleneck.VisibleIndex = 8;
            this.colRoadBottleneck.Width = 94;
            // 
            // colStructuralBottleneck
            // 
            this.colStructuralBottleneck.FieldName = "StructuralBottleneck";
            this.colStructuralBottleneck.MinWidth = 25;
            this.colStructuralBottleneck.Name = "colStructuralBottleneck";
            this.colStructuralBottleneck.Visible = true;
            this.colStructuralBottleneck.VisibleIndex = 9;
            this.colStructuralBottleneck.Width = 94;
            // 
            // colQtr1Plan
            // 
            this.colQtr1Plan.FieldName = "Qtr1Plan";
            this.colQtr1Plan.MinWidth = 25;
            this.colQtr1Plan.Name = "colQtr1Plan";
            this.colQtr1Plan.Visible = true;
            this.colQtr1Plan.VisibleIndex = 10;
            this.colQtr1Plan.Width = 94;
            // 
            // colQtr1Achievement
            // 
            this.colQtr1Achievement.FieldName = "Qtr1Achievement";
            this.colQtr1Achievement.MinWidth = 25;
            this.colQtr1Achievement.Name = "colQtr1Achievement";
            this.colQtr1Achievement.Visible = true;
            this.colQtr1Achievement.VisibleIndex = 11;
            this.colQtr1Achievement.Width = 94;
            // 
            // colQtr2Plan
            // 
            this.colQtr2Plan.FieldName = "Qtr2Plan";
            this.colQtr2Plan.MinWidth = 25;
            this.colQtr2Plan.Name = "colQtr2Plan";
            this.colQtr2Plan.Visible = true;
            this.colQtr2Plan.VisibleIndex = 12;
            this.colQtr2Plan.Width = 94;
            // 
            // colQtr2Achievement
            // 
            this.colQtr2Achievement.FieldName = "Qtr2Achievement";
            this.colQtr2Achievement.MinWidth = 25;
            this.colQtr2Achievement.Name = "colQtr2Achievement";
            this.colQtr2Achievement.Visible = true;
            this.colQtr2Achievement.VisibleIndex = 13;
            this.colQtr2Achievement.Width = 94;
            // 
            // colQtr3Plan
            // 
            this.colQtr3Plan.FieldName = "Qtr3Plan";
            this.colQtr3Plan.MinWidth = 25;
            this.colQtr3Plan.Name = "colQtr3Plan";
            this.colQtr3Plan.Visible = true;
            this.colQtr3Plan.VisibleIndex = 14;
            this.colQtr3Plan.Width = 94;
            // 
            // colQtr3Achievement
            // 
            this.colQtr3Achievement.FieldName = "Qtr3Achievement";
            this.colQtr3Achievement.MinWidth = 25;
            this.colQtr3Achievement.Name = "colQtr3Achievement";
            this.colQtr3Achievement.Visible = true;
            this.colQtr3Achievement.VisibleIndex = 15;
            this.colQtr3Achievement.Width = 94;
            // 
            // colQtr4Plan
            // 
            this.colQtr4Plan.FieldName = "Qtr4Plan";
            this.colQtr4Plan.MinWidth = 25;
            this.colQtr4Plan.Name = "colQtr4Plan";
            this.colQtr4Plan.Visible = true;
            this.colQtr4Plan.VisibleIndex = 16;
            this.colQtr4Plan.Width = 94;
            // 
            // colQtr4Achievement
            // 
            this.colQtr4Achievement.FieldName = "Qtr4Achievement";
            this.colQtr4Achievement.MinWidth = 25;
            this.colQtr4Achievement.Name = "colQtr4Achievement";
            this.colQtr4Achievement.Visible = true;
            this.colQtr4Achievement.VisibleIndex = 17;
            this.colQtr4Achievement.Width = 94;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.MinWidth = 25;
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 18;
            this.colRemarks.Width = 94;
            // 
            // colRoadsGISData
            // 
            this.colRoadsGISData.FieldName = "RoadsGISData.RoadLengthInKm";
            this.colRoadsGISData.MinWidth = 25;
            this.colRoadsGISData.Name = "colRoadsGISData";
            this.colRoadsGISData.Visible = true;
            this.colRoadsGISData.VisibleIndex = 19;
            this.colRoadsGISData.Width = 94;
            // 
            // colAdminBoundary
            // 
            this.colAdminBoundary.FieldName = "AdminBoundary";
            this.colAdminBoundary.MinWidth = 25;
            this.colAdminBoundary.Name = "colAdminBoundary";
            this.colAdminBoundary.Visible = true;
            this.colAdminBoundary.VisibleIndex = 20;
            this.colAdminBoundary.Width = 94;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 689);
            this.Controls.Add(this.gridControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeSupplyAdminCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedRoadConditionSurveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadsGISDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prioritizedRoadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpavedTentativeRoadMaintenancePlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annualRoadWorkPlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource unpavedRoadConditionSurveyBindingSource;
        private System.Windows.Forms.BindingSource officeSupplyAdminCostBindingSource;
        private System.Windows.Forms.BindingSource unpavedTentativeRoadMaintenancePlanBindingSource;
        private System.Windows.Forms.BindingSource prioritizedRoadsBindingSource;
        private System.Windows.Forms.BindingSource roadsGISDataBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource annualRoadWorkPlanBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAnnualPlanID;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadID;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colFYearEC;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminID;
        private DevExpress.XtraGrid.Columns.GridColumn colSectionLength;
        private DevExpress.XtraGrid.Columns.GridColumn colRoutineMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodicMaintenance;
        private DevExpress.XtraGrid.Columns.GridColumn colRehabilitation;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadBottleneck;
        private DevExpress.XtraGrid.Columns.GridColumn colStructuralBottleneck;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr1Plan;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr1Achievement;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr2Plan;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr2Achievement;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr3Plan;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr3Achievement;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr4Plan;
        private DevExpress.XtraGrid.Columns.GridColumn colQtr4Achievement;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colRoadsGISData;
        private DevExpress.XtraGrid.Columns.GridColumn colAdminBoundary;
    }
}